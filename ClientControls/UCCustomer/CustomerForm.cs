using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cafetea.ClientControls.UCCustomer
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        public void SetCustomerData(string name, string email)
        {
            nameCustomerFormlbl.Text = name;
            emailCsFormlbl.Text = email;
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteCsBtn_Click(object sender, EventArgs e)
        {
            // call CustomerService to delete if needed
            MessageBox.Show("Customer deleted!");
            this.Close();
        }
    }
}
