namespace Cafetea
{
    partial class Dashboard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            logoName = new Label();
            pictureBox1 = new PictureBox();
            panel = new Panel();
            promoBtn = new Button();
            button1 = new Button();
            feedbackBtn = new Button();
            orderBtn = new Button();
            customerBtn = new Button();
            dashboardBtn = new Button();
            panelContainer = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(logoName);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1248, 116);
            panel1.TabIndex = 0;
            // 
            // logoName
            // 
            logoName.AutoSize = true;
            logoName.Font = new Font("Century Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logoName.ForeColor = Color.WhiteSmoke;
            logoName.Location = new Point(142, 53);
            logoName.Name = "logoName";
            logoName.Size = new Size(204, 23);
            logoName.TabIndex = 1;
            logoName.Text = "Cafetea CRM System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(72, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 53);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel
            // 
            panel.BackColor = Color.FromArgb(16, 22, 27);
            panel.Controls.Add(promoBtn);
            panel.Controls.Add(button1);
            panel.Controls.Add(feedbackBtn);
            panel.Controls.Add(orderBtn);
            panel.Controls.Add(customerBtn);
            panel.Controls.Add(dashboardBtn);
            panel.Dock = DockStyle.Top;
            panel.Location = new Point(0, 116);
            panel.Name = "panel";
            panel.Size = new Size(1248, 81);
            panel.TabIndex = 1;
            // 
            // promoBtn
            // 
            promoBtn.FlatAppearance.BorderSize = 0;
            promoBtn.FlatStyle = FlatStyle.Flat;
            promoBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            promoBtn.ForeColor = Color.WhiteSmoke;
            promoBtn.Image = (Image)resources.GetObject("promoBtn.Image");
            promoBtn.Location = new Point(648, 7);
            promoBtn.Name = "promoBtn";
            promoBtn.Size = new Size(145, 65);
            promoBtn.TabIndex = 5;
            promoBtn.Text = "    Promos";
            promoBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            promoBtn.UseVisualStyleBackColor = true;
            promoBtn.Click += promoBtn_Click;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.WhiteSmoke;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(1054, 15);
            button1.Name = "button1";
            button1.Size = new Size(91, 48);
            button1.TabIndex = 4;
            button1.Text = "    Exit";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // feedbackBtn
            // 
            feedbackBtn.FlatAppearance.BorderSize = 0;
            feedbackBtn.FlatStyle = FlatStyle.Flat;
            feedbackBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            feedbackBtn.ForeColor = Color.WhiteSmoke;
            feedbackBtn.Image = (Image)resources.GetObject("feedbackBtn.Image");
            feedbackBtn.Location = new Point(524, 15);
            feedbackBtn.Name = "feedbackBtn";
            feedbackBtn.Size = new Size(142, 48);
            feedbackBtn.TabIndex = 3;
            feedbackBtn.Text = "    Feedback";
            feedbackBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            feedbackBtn.UseVisualStyleBackColor = true;
            feedbackBtn.Click += feedbackBtn_Click;
            // 
            // orderBtn
            // 
            orderBtn.FlatAppearance.BorderSize = 0;
            orderBtn.FlatStyle = FlatStyle.Flat;
            orderBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            orderBtn.ForeColor = Color.WhiteSmoke;
            orderBtn.Image = (Image)resources.GetObject("orderBtn.Image");
            orderBtn.Location = new Point(401, 15);
            orderBtn.Name = "orderBtn";
            orderBtn.Size = new Size(142, 48);
            orderBtn.TabIndex = 2;
            orderBtn.Text = "    Orders";
            orderBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            orderBtn.UseVisualStyleBackColor = true;
            orderBtn.Click += orderBtn_Click;
            // 
            // customerBtn
            // 
            customerBtn.FlatAppearance.BorderSize = 0;
            customerBtn.FlatStyle = FlatStyle.Flat;
            customerBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerBtn.ForeColor = Color.WhiteSmoke;
            customerBtn.Image = (Image)resources.GetObject("customerBtn.Image");
            customerBtn.Location = new Point(270, 15);
            customerBtn.Name = "customerBtn";
            customerBtn.Size = new Size(142, 48);
            customerBtn.TabIndex = 1;
            customerBtn.Text = "    Customer";
            customerBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            customerBtn.UseVisualStyleBackColor = true;
            customerBtn.Click += customerBtn_Click;
            // 
            // dashboardBtn
            // 
            dashboardBtn.FlatAppearance.BorderSize = 0;
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardBtn.ForeColor = Color.WhiteSmoke;
            dashboardBtn.Image = (Image)resources.GetObject("dashboardBtn.Image");
            dashboardBtn.Location = new Point(122, 15);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(142, 48);
            dashboardBtn.TabIndex = 0;
            dashboardBtn.Text = "    Dashboard";
            dashboardBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            dashboardBtn.UseVisualStyleBackColor = true;
            dashboardBtn.Click += dashboardBtn_Click;
            // 
            // panelContainer
            // 
            panelContainer.Location = new Point(44, 197);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1204, 553);
            panelContainer.TabIndex = 2;
            // 
            // Dashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(16, 22, 27);
            ClientSize = new Size(1248, 762);
            Controls.Add(panelContainer);
            Controls.Add(panel);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel;
        private PictureBox pictureBox1;
        private Label logoName;
        private Button dashboardBtn;
        private Button orderBtn;
        private Button customerBtn;
        private Button feedbackBtn;
        private Panel panelContainer;
        private Button button1;
        private Button promoBtn;
    }
}
