using Cafetea.AdminControls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Cafetea.Forms
{
    public partial class loginUC : UserControl
    {
        public loginUC()
        {
            InitializeComponent();
        }

        private void registerBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm? main = this.FindForm() as MainForm;

            if (main != null)
            {
                main.LoadFormControl(new registerUC()); 
            }
        }

        private void usernameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordField_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameField.Text.Trim();
            string password = passwordField.Text.Trim();

            string? role = Cafetea.Database.UserService.Login(username, password);

            if (role != null)
            { 
                // Open the Dashboard form
                Dashboard dashboard = new Dashboard();

                // Load the correct control based on role
                switch (role)
                {
                    case "SuperAdmin":
                        dashboard.LoadAdminControl(new UCDashboard()); // example for SuperAdmin
                        break;
                    case "Staff":
                        dashboard.LoadAdminControl(new UCCustomer()); // example for Staff
                        break;
                    case "Client":
                        dashboard.LoadAdminControl(new UCOrders()); // example for Client
                        break;
                }

                dashboard.Show();
                this.FindForm()?.Hide(); // hide the login form
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
