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
    public partial class CarForm : Form
    {
        public CarForm()
        {
            InitializeComponent();

            //lblMsg.Text = AppDomain.CurrentDomain.BaseDirectory;

            GetColors();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnPicture_Click(object sender, EventArgs e)
        {

        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            var frm = new ColorForm();
            frm.Show();
        }

        private void btnMark_Click(object sender, EventArgs e)
        {
            var frm = new MarkForm();
            frm.Show();
        }

        private void btnModel_Click(object sender, EventArgs e)
        {

        }

        private void GetColors()
        {
            if (File.Exists($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json"))
            {
                var colorsInJson = File.ReadAllText($"{AppDomain.CurrentDomain.BaseDirectory}\\colors.json", Encoding.UTF8);
                var colorList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Models.Color>>(colorsInJson);
                
                cbColor.DataSource = colorList.Where(x=> x.Visible).ToList();
                cbColor.DisplayMember = "Name";
                cbColor.ValueMember = "Id";
            }
        }
    }
}
