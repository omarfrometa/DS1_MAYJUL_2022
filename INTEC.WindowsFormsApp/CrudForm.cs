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
    public partial class CrudForm : Form
    {
        private bool Adding = false;
        List<Contact> Contacts = new List<Contact>();
        public CrudForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmptyControls();
            EnableControls(true);
            Adding = true;
            txtId.Text = Guid.NewGuid().ToString();

            btnAdd.Enabled = false;
            btnRead.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void EmptyControls()
        {
            txtId.Text = string.Empty;
            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtAddress.Text = string.Empty;
            txtState.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtEmail.Text = string.Empty;
        }

        private void EnableControls(bool enabled)
        {
            txtFirstName.Enabled = enabled;
            txtLastName.Enabled = enabled;
            txtAddress.Enabled = enabled;
            txtState.Enabled = enabled;
            txtCity.Enabled = enabled;
            txtPhone.Enabled = enabled;
            txtEmail.Enabled = enabled;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void Save()
        {
            if (Adding == true)
            {
                //Add new record
                var contact = new Contact { 
                    Id = txtId.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Address = txtAddress.Text,
                    State = txtState.Text,
                    City = txtCity.Text,
                    Phone = txtPhone.Text,
                    Email = txtEmail.Text,
                    CreatedDate = DateTime.Now
                };

                Contacts.Add(contact);

                MessageBox.Show("Contacto Agregado.");

                EmptyControls();
                EnableControls(false);

                btnAdd.Enabled = true;
                btnRead.Enabled = true;
                btnDelete.Enabled = true;

                GetContacts();
            }
            else
            { 
                //Update existing record
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            GetContacts();
        }

        private void GetContacts()
        {
            dgContacts.DataSource = null;
            dgContacts.DataSource = Contacts;

            dgContacts.Columns["Id"].Visible = false;
            dgContacts.Columns["Address"].Visible = false;
        }
    }

    public class Contact 
    { 
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
