using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INTEC.WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
             Calcular();
        }

        private void Calcular()
        {
            if (string.IsNullOrEmpty(txtPrimerParcial.Text))
            {
                MessageBox.Show($"La Nota del Primer Parcial es Requerida.");
                return;
            }

            if (string.IsNullOrEmpty(txtSegundoParcial.Text))
            {
                MessageBox.Show($"La Nota del Segundo Parcial es Requerida.");
                return;
            }

            if (string.IsNullOrEmpty(txtTercerParcial.Text))
            {
                MessageBox.Show($"La Nota del Tercer Parcial es Requerida.");
                return;
            }

            double n1, n2, n3, pro;

            n1 = int.Parse(txtPrimerParcial.Text);
            n2 = Convert.ToInt32(txtSegundoParcial.Text);
            n3 = int.Parse(txtTercerParcial.Text);

            pro = (n1 + n2 + n3) / 3;

            lblPromedio.Text = double.Parse(pro.ToString()).ToString("#.##");
        }

        private void txtPrimerParcial_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
