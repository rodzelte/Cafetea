using System;
using System.Windows.Forms;

namespace Cafetea.SuperAdminControls
{
    public partial class UserAgreement : Form
    {
        public bool Accepted { get; private set; } = false;

        public UserAgreement()
        {
            InitializeComponent();

            // Hook up buttons
            acceptBtn.Click += AcceptBtn_Click;
            declineBtn.Click += DeclineBtn_Click;

            // Example: Set your terms text
            agreementText.Text = "Terms & Agreement...\n\nPlease read carefully before proceeding.";
        }

        private void AcceptBtn_Click(object? sender, EventArgs e)
        {
            Accepted = true;
            this.Close();
        }

        private void DeclineBtn_Click(object? sender, EventArgs e)
        {
            Accepted = false;
            this.Close();
        }

    }
}
