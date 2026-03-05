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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffDashboard));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            UCStaffPanel = new Guna.UI2.WinForms.Guna2Panel();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            exitBtn = new Button();
            label2 = new Label();
            guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            OrderBtn = new Guna.UI2.WinForms.Guna2Button();
            OrderProgressBtn = new Guna.UI2.WinForms.Guna2Button();
            guna2Panel2.SuspendLayout();
            guna2Panel3.SuspendLayout();
            SuspendLayout();
            // 
            // UCStaffPanel
            // 
            UCStaffPanel.CustomizableEdges = customizableEdges1;
            UCStaffPanel.Location = new Point(0, 208);
            UCStaffPanel.Name = "UCStaffPanel";
            UCStaffPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            UCStaffPanel.Size = new Size(869, 495);
            UCStaffPanel.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            guna2Panel2.Controls.Add(exitBtn);
            guna2Panel2.Controls.Add(label2);
            guna2Panel2.CustomizableEdges = customizableEdges3;
            guna2Panel2.Location = new Point(0, 1);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel2.Size = new Size(869, 71);
            guna2Panel2.TabIndex = 1;
            // 
            // exitBtn
            // 
            exitBtn.FlatAppearance.BorderSize = 0;
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitBtn.ForeColor = Color.WhiteSmoke;
            exitBtn.Image = (Image)resources.GetObject("exitBtn.Image");
            exitBtn.Location = new Point(768, 11);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(91, 48);
            exitBtn.TabIndex = 5;
            exitBtn.Text = "    Exit";
            exitBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
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
            guna2Panel3.CustomizableEdges = customizableEdges9;
            guna2Panel3.Location = new Point(0, 100);
            guna2Panel3.Name = "guna2Panel3";
            guna2Panel3.ShadowDecoration.CustomizableEdges = customizableEdges10;
            guna2Panel3.Size = new Size(869, 86);
            guna2Panel3.TabIndex = 2;
            // 
            // OrderBtn
            // 
            OrderBtn.CustomizableEdges = customizableEdges5;
            OrderBtn.DisabledState.BorderColor = Color.DarkGray;
            OrderBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            OrderBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            OrderBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            OrderBtn.Font = new Font("Segoe UI", 9F);
            OrderBtn.ForeColor = Color.White;
            OrderBtn.Location = new Point(283, 22);
            OrderBtn.Name = "OrderBtn";
            OrderBtn.ShadowDecoration.CustomizableEdges = customizableEdges6;
            OrderBtn.Size = new Size(180, 45);
            OrderBtn.TabIndex = 1;
            OrderBtn.Text = "Make an Order";
            OrderBtn.Click += OrderBtn_Click;
            // 
            // OrderProgressBtn
            // 
            OrderProgressBtn.CustomizableEdges = customizableEdges7;
            OrderProgressBtn.DisabledState.BorderColor = Color.DarkGray;
            OrderProgressBtn.DisabledState.CustomBorderColor = Color.DarkGray;
            OrderProgressBtn.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            OrderProgressBtn.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            OrderProgressBtn.Font = new Font("Segoe UI", 9F);
            OrderProgressBtn.ForeColor = Color.White;
            OrderProgressBtn.Location = new Point(35, 22);
            OrderProgressBtn.Name = "OrderProgressBtn";
            OrderProgressBtn.ShadowDecoration.CustomizableEdges = customizableEdges8;
            OrderProgressBtn.Size = new Size(180, 45);
            OrderProgressBtn.TabIndex = 0;
            OrderProgressBtn.Text = "Order Progress";
            OrderProgressBtn.Click += OrderProgressBtn_Click;
            // 
            // StaffDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 22, 33);
            ClientSize = new Size(871, 706);
            Controls.Add(guna2Panel3);
            Controls.Add(guna2Panel2);
            Controls.Add(UCStaffPanel);
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

        private Guna.UI2.WinForms.Guna2Panel UCStaffPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button OrderBtn;
        private Guna.UI2.WinForms.Guna2Button OrderProgressBtn;
        private Button exitBtn;
    }
}