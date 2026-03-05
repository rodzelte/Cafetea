using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Cafetea.SuperAdminControls
{
    public partial class UserAgreement : Form
    {
        public bool Accepted { get; private set; } = false;

        // Win32 API to get scroll position
        [DllImport("user32.dll")]
        private static extern int GetScrollPos(IntPtr hWnd, int nBar);
        private const int SB_VERT = 1;

        public UserAgreement()
        {
            InitializeComponent();

            // Set terms text
            agreementText.Text = @"Cafetea Software Terms & Agreement

Welcome to Cafetea! Before using this software, please read these terms carefully. By clicking 'Accept', you agree to comply with all terms outlined below.

1. **Authorized Use**
   - This software is intended for authorized users only.
   - You must not share your activation key with others or attempt to bypass licensing.

2. **Data Responsibility**
   - All data entered into the system is your responsibility.
   - Cafetea is not liable for any incorrect or incomplete data input.

3. **Privacy and Confidentiality**
   - Do not share sensitive customer or company information.
   - All data collected should be used in compliance with applicable privacy laws.

4. **Software Integrity**
   - Do not attempt to modify, reverse-engineer, or redistribute the software.
   - Unauthorized tampering may lead to legal consequences.

5. **Accountability**
   - Users must follow proper procedures when placing or processing orders.
   - Misuse of the software may result in suspension or loss of access.

6. **Support and Updates**
   - Cafetea may provide updates or support at its discretion.
   - Users should install updates to ensure proper functionality and security.

7. **Limitation of Liability**
   - Cafetea is not responsible for financial loss, data loss, or operational issues arising from misuse of the software.

8. **Acceptance**
   - By clicking 'Accept', you acknowledge that you have read, understood, and agreed to these terms.
   - You must scroll to the bottom to activate the 'Accept' button.

Please scroll to the bottom to enable the 'Accept' button and continue using the software safely.";

            // Disable Accept button initially
            acceptBtn.Enabled = false;

            // Hook up buttons
            acceptBtn.Click += AcceptBtn_Click;
            declineBtn.Click += DeclineBtn_Click;

            // Hook scroll event
            agreementText.VScroll += AgreementText_VScroll;
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

        private void AgreementText_VScroll(object? sender, EventArgs e)
        {
            // Get current scroll position
            int scrollPos = GetScrollPos(agreementText.Handle, SB_VERT);

            // Get the maximum scroll range
            int maxScroll = agreementText.GetLineFromCharIndex(agreementText.TextLength) - agreementText.Lines.Length + 1;

            if (scrollPos >= maxScroll)
                acceptBtn.Enabled = true;
            else
                acceptBtn.Enabled = false;
        }
    }
}