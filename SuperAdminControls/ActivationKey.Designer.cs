namespace Cafetea.SuperAdminControls
{
    partial class ActivationKey
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            productKeyActivationtb = new TextBox();
            activateBtn = new Guna.UI2.WinForms.Guna2Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(49, 47);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 0;
            label1.Text = "Product Key";
            // 
            // productKeyActivationtb
            // 
            productKeyActivationtb.Location = new Point(139, 44);
            productKeyActivationtb.Name = "productKeyActivationtb";
            productKeyActivationtb.PlaceholderText = "XXXX-XXXX-XXXX-XXXX";
            productKeyActivationtb.Size = new Size(267, 23);
            productKeyActivationtb.TabIndex = 1;
            // 
            // activateBtn
            // 
            activateBtn.CustomizableEdges = customizableEdges1;
            activateBtn.DisabledState.BorderColor = Color.DarkGray;
            activateBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            activateBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            activateBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            activateBtn.Font = new Font("Segoe UI", 9F);
            activateBtn.ForeColor = Color.White;
            activateBtn.Location = new Point(352, 94);
            activateBtn.Name = "activateBtn";
            activateBtn.ShadowDecoration.CustomizableEdges = customizableEdges2;
            activateBtn.Size = new Size(102, 20);
            activateBtn.TabIndex = 2;
            activateBtn.Text = "Activate";
            activateBtn.Click += ActivateBtn_Click;
            // 
            // TNC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 22, 33);
            ClientSize = new Size(466, 137);
            Controls.Add(activateBtn);
            Controls.Add(productKeyActivationtb);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TNC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TNC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox productKeyActivationtb;
        private Guna.UI2.WinForms.Guna2Button activateBtn;
    }
}