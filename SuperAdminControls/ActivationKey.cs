using Cafetea.Forms;
using System;
using System.Windows.Forms;

namespace Cafetea.SuperAdminControls
{
    public partial class ActivationKey : Form
    {
        private const string AdminKey = "adminkey";

        public ActivationKey()
        {
            InitializeComponent();
            activateBtn.Click += ActivateBtn_Click;
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

              

                if (agreementForm.Accepted)
                {
                    MessageBox.Show("Thank you for accepting the Terms & Agreement.", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Load main dashboard
                    var dashboard = new MainForm(); // Replace with your actual main form
                    dashboard.Show();
                    this.Hide();
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
    }
}