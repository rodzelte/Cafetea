using System;
using System.Windows.Forms;
using Cafetea.Database;

namespace Cafetea.Forms
{
    public partial class registerUC : UserControl
    {
        public registerUC()
        {
            InitializeComponent();

            // Populate role dropdown
            roleDropdown.Items.Clear();
            roleDropdown.Items.Add("Client");
            roleDropdown.Items.Add("Staff");
            roleDropdown.Items.Add("SuperAdmin");
            roleDropdown.SelectedIndex = 0; // default selection
        }

        // Redirect to loginUC when clicking the "Sign In" link
        private void signinBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MainForm? main = this.FindForm() as MainForm;
            if (main != null)
            {
                main.LoadFormControl(new loginUC());
            }
        }

        // Register button click
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = usernameField.Text.Trim();
            string password = passwordField.Text.Trim();
            string role = roleDropdown.SelectedItem?.ToString() ?? "";

            // Validate input
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                bool success = UserService.Register(username, password, role);

                if (success)
                {
                    MessageBox.Show("Registration successful! You can now login.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear fields
                    usernameField.Text = "";
                    passwordField.Text = "";
                    roleDropdown.SelectedIndex = 0;

                    // Redirect to loginUC
                    MainForm? main = this.FindForm() as MainForm;
                    if (main != null)
                    {
                        main.LoadFormControl(new loginUC());
                    }
                }
                else
                {
                    MessageBox.Show("Username already exists. Try another.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}