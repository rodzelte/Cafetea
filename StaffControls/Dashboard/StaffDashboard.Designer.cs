namespace Cafetea.StaffControls.Dashboard
{
    partial class StaffDashboard
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            UCPanel = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            label2 = new Label();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            OrderBtn = new Guna.UI2.WinForms.Guna2Button();
            OrderProgressBtn = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel2.SuspendLayout();
            guna2Panel3.SuspendLayout();
            SuspendLayout();
            // 
            // UCPanel
            // 
            UCPanel.CustomizableEdges = customizableEdges11;
            UCPanel.Location = new Point(0, 208);
            UCPanel.Name = "UCPanel";
            UCPanel.ShadowDecoration.CustomizableEdges = customizableEdges12;
            UCPanel.Size = new Size(869, 495);
            UCPanel.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Controls.Add(label2);
            guna2Panel2.CustomizableEdges = customizableEdges13;
            guna2Panel2.Location = new Point(0, 1);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges14;
            guna2Panel2.Size = new Size(869, 71);
            guna2Panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(319, 24);
            label2.Name = "label2";
            label2.Size = new Size(194, 25);
            label2.TabIndex = 1;
            label2.Text = "Welcome to Cafetea!";
            // 
            // guna2Panel3
            // 
            guna2Panel3.Controls.Add(OrderBtn);
            guna2Panel3.Controls.Add(OrderProgressBtn);
            guna2Panel3.CustomizableEdges = customizableEdges19;
            guna2Panel3.Location = new Point(0, 100);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges20;
            guna2Panel3.Size = new Size(869, 86);
            guna2Panel3.TabIndex = 2;
            // 
            // OrderBtn
            // 
            OrderBtn.CustomizableEdges = customizableEdges15;
            OrderBtn.DisabledState.BorderColor = Color.DarkGray;
            OrderBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            OrderBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            OrderBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            OrderBtn.Font = new Font("Segoe UI", 9F);
            OrderBtn.ForeColor = Color.White;
            OrderBtn.Location = new Point(283, 22);
            OrderBtn.Name = "OrderBtn";
            OrderBtn.ShadowDecoration.CustomizableEdges = customizableEdges16;
            OrderBtn.Size = new Size(180, 45);
            OrderBtn.TabIndex = 1;
            OrderBtn.Text = "Make an Order";
            // 
            // OrderProgressBtn
            // 
            OrderProgressBtn.CustomizableEdges = customizableEdges17;
            OrderProgressBtn.DisabledState.BorderColor = Color.DarkGray;
            OrderProgressBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            OrderProgressBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            OrderProgressBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            OrderProgressBtn.Font = new Font("Segoe UI", 9F);
            OrderProgressBtn.ForeColor = Color.White;
            OrderProgressBtn.Location = new Point(35, 22);
            OrderProgressBtn.Name = "OrderProgressBtn";
            OrderProgressBtn.ShadowDecoration.CustomizableEdges = customizableEdges18;
            OrderProgressBtn.Size = new Size(180, 45);
            OrderProgressBtn.TabIndex = 0;
            OrderProgressBtn.Text = "Order Progress";
            // 
            // StaffDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 22, 33);
            ClientSize = new Size(871, 706);
            Controls.Add(guna2Panel3);
            Controls.Add(guna2Panel2);
            Controls.Add(UCPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StaffDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            guna2Panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel UCPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button OrderBtn;
        private Guna.UI2.WinForms.Guna2Button OrderProgressBtn;
    }
}