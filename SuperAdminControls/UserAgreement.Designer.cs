namespace Cafetea.SuperAdminControls
{
    partial class UserAgreement
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            acceptBtn = new Guna.UI2.WinForms.Guna2Button();
            declineBtn = new Guna.UI2.WinForms.Guna2Button();
            panel1 = new Panel();
            agreementText = new RichTextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // acceptBtn
            // 
            acceptBtn.CustomizableEdges = customizableEdges9;
            acceptBtn.DisabledState.BorderColor = Color.DarkGray;
            acceptBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            acceptBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            acceptBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            acceptBtn.Font = new Font("Segoe UI", 9F);
            acceptBtn.ForeColor = Color.White;
            acceptBtn.Location = new Point(30, 538);
            acceptBtn.Name = "acceptBtn";
            acceptBtn.ShadowDecoration.CustomizableEdges = customizableEdges10;
            acceptBtn.Size = new Size(141, 24);
            acceptBtn.TabIndex = 0;
            acceptBtn.Text = "Accept";
            acceptBtn.Click += AcceptBtn_Click;
            // 
            // declineBtn
            // 
            declineBtn.CustomizableEdges = customizableEdges11;
            declineBtn.DisabledState.BorderColor = Color.DarkGray;
            declineBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            declineBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            declineBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            declineBtn.Font = new Font("Segoe UI", 9F);
            declineBtn.ForeColor = Color.White;
            declineBtn.Location = new Point(220, 538);
            declineBtn.Name = "declineBtn";
            declineBtn.ShadowDecoration.CustomizableEdges = customizableEdges12;
            declineBtn.Size = new Size(141, 24);
            declineBtn.TabIndex = 1;
            declineBtn.Text = "Decline";
            declineBtn.Click += DeclineBtn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(agreementText);
            panel1.Location = new Point(39, 44);
            panel1.Name = "panel1";
            panel1.Size = new Size(309, 444);
            panel1.TabIndex = 2;
            // 
            // agreementText
            // 
            agreementText.BackColor = Color.FromArgb(16, 22, 33);
            agreementText.ForeColor = Color.WhiteSmoke;
            agreementText.Location = new Point(3, 0);
            agreementText.Name = "agreementText";
            agreementText.ReadOnly = true;
            agreementText.Size = new Size(303, 441);
            agreementText.TabIndex = 1;
            agreementText.Text = "";
            // 
            // UserAgreement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 22, 33);
            ClientSize = new Size(397, 583);
            Controls.Add(panel1);
            Controls.Add(declineBtn);
            Controls.Add(acceptBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserAgreement";
            Text = "UserAgreement";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button acceptBtn;
        private Guna.UI2.WinForms.Guna2Button declineBtn;
        private Panel panel1;
        private RichTextBox agreementText;
    }
}