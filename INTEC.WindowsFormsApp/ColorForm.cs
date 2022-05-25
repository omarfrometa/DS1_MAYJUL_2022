using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTEC.WindowsFormsApp
{
    public partial class ColorForm : Form
    {
        public bool Adding { get; set; } = true;
        public ColorForm()
        {
            InitializeComponent();

            ReadJson();
        }

        private void ReadJson()
        {
            var colorList = new List<Models.Color>();
            //Reading Json File
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json"))
            {
                var colorsInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json", Encoding.UTF8);
                colorList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Models.Color>>(colorsInJson);
                dgvRecords.DataSource = colorList;

                txtID.Text = (colorList.Count + 1).ToString();
            }
            else
            {
                txtID.Text = "1";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveJson();
        }

        private void SaveJson()
        {
            try
            {
                var colorList = new List<Models.Color>();

                if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json"))
                {
                    var colorsInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json", Encoding.UTF8);
                    colorList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Models.Color>>(colorsInJson);
                }

                var color = new Models.Color();
                if (Adding == true) //Add new Item
                {
                    color = new Models.Color
                    {
                        Id = int.Parse(txtID.Text),
                        Name = txtName.Text,
                        Visible = chkVisible.Checked,
                        CreatedDate = DateTime.Now
                    };
                    
                }   
                else //Update Item
                {
                    var Id = Convert.ToInt32(txtID.Text);
                    color = colorList.FirstOrDefault(x => x.Id == Id);
                    if (color != null)
                    {
                        colorList.Remove(color);
                        color.Name = txtName.Text;
                        color.Visible = chkVisible.Checked;
                        color.ModifiedDate = DateTime.Now;
                    }
                }

                //Add item to List
                colorList.Add(color);

                var json = Newtonsoft.Json.JsonConvert.SerializeObject(colorList);

                //Saving Json file in Disk
                var sw = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json", false, Encoding.UTF8);
                sw.WriteLine(json);
                sw.Close();

                MessageBox.Show("El color fue creado con exito.");

                //Clear fields
                clearFields();

                //Read Json Method
                ReadJson();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        private void clearFields()
        {
            Adding = true;
            txtID.Text = string.Empty;
            txtName.Text = string.Empty;
            chkVisible.Checked = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            clearFields();
            ReadJson();
        }

        private void dgvRecords_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Contextual Right Click Menu in DataGridDview
            if (e.Button == MouseButtons.Right)
            {
                dgvRecords.Rows[e.RowIndex].Selected = true;
                var rI = e.RowIndex;
                dgvRecords.CurrentCell = dgvRecords.Rows[e.RowIndex].Cells[1];
                contextMenuStrip1.Show(dgvRecords, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Deteling row Contextual Menu
            if (dgvRecords.SelectedRows.Count != 0)
            {
                txtID.Text = dgvRecords.CurrentRow.Cells["Id"].Value.ToString();
                txtName.Text = dgvRecords.CurrentRow.Cells["Name"].Value.ToString();
                chkVisible.Checked = (bool)dgvRecords.CurrentRow.Cells["Visible"].Value;
                Adding = false;
            }
        }

        private void deleteRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Remove row from Json File and List
            DialogResult dr = MessageBox.Show("Estas Seguro que deseas eliminar este registro.", "DS II", MessageBoxButtons.YesNo, MessageBoxIcon.Hand);
            if (dr == DialogResult.Yes)
            {
                var colorList = new List<Models.Color>();

                if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json"))
                {
                    var colorsInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json", Encoding.UTF8);
                    colorList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Models.Color>>(colorsInJson);

                    var Id = Convert.ToInt32(dgvRecords.CurrentRow.Cells["Id"].Value);
                    var color = colorList.FirstOrDefault(x => x.Id == Id); //Find Default Element
                    if (color != null)
                    {
                        colorList.Remove(color);

                        //Convert List to Json Object
                        var json = Newtonsoft.Json.JsonConvert.SerializeObject(colorList);

                        //Write Json File
                        StreamWriter sw = new StreamWriter($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json", false, Encoding.UTF8);
                        sw.WriteLine(json);
                        sw.Close();

                        ReadJson();
                    }
                }
            }
        }
    }
}
