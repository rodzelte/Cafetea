using Cafetea.Forms;
using System;
using System.IO;
using System.Windows.Forms;

namespace Cafetea.SuperAdminControls
{
    public partial class ActivationKey : Form
    {
        private const string AdminKey = "adminkey";
        private readonly string keyFile = Path.Combine(Application.StartupPath, "activated.txt");

        public ActivationKey()
        {
            InitializeComponent();
            activateBtn.Click += ActivateBtn_Click;

            // Check if already activated
            if (File.Exists(keyFile))
            {
                OpenMainDashboard();
            }
        }

        private void ActivateBtn_Click(object? sender, EventArgs e)
        {
            string enteredKey = productKeyActivationtb.Text.Trim();

            if (string.IsNullOrWhiteSpace(enteredKey))
            {
                MessageBox.Show("Please enter the activation key.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (enteredKey == AdminKey)
            {
                MessageBox.Show("Activation Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Show T&C form
                using var agreementForm = new UserAgreement();
                agreementForm.ShowDialog();


                if (agreementForm.Accepted)
                {
                    // Save activation
                    File.WriteAllText(keyFile, AdminKey);

                    OpenMainDashboard();
                }
                else
                {
                    MessageBox.Show("You must accept the Terms & Agreement to proceed.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    Application.Exit();
                }
            }
            else
            {
                MessageBox.Show("Invalid activation key!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OpenMainDashboard()
        {
            var dashboard = new MainForm(); // Replace with your main dashboard
            dashboard.Show();
            this.Hide();
        }
    }
}