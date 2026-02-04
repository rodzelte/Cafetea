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
            panel2 = new Panel();
            feedbackBtn = new Button();
            customerBtn = new Button();
            dashboardBtn = new Button();
            panel3 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
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
            logoName.ForeColor = SystemColors.Control;
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(16, 22, 27);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(feedbackBtn);
            panel2.Controls.Add(customerBtn);
            panel2.Controls.Add(dashboardBtn);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 116);
            panel2.Name = "panel2";
            panel2.Size = new Size(1248, 81);
            panel2.TabIndex = 1;
            // 
            // feedbackBtn
            // 
            feedbackBtn.FlatAppearance.BorderSize = 0;
            feedbackBtn.FlatStyle = FlatStyle.Flat;
            feedbackBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            feedbackBtn.ForeColor = SystemColors.Control;
            feedbackBtn.Image = (Image)resources.GetObject("feedbackBtn.Image");
            feedbackBtn.Location = new Point(418, 15);
            feedbackBtn.Name = "feedbackBtn";
            feedbackBtn.Size = new Size(142, 48);
            feedbackBtn.TabIndex = 2;
            feedbackBtn.Text = "    Orders";
            feedbackBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            feedbackBtn.UseVisualStyleBackColor = true;
            // 
            // customerBtn
            // 
            customerBtn.FlatAppearance.BorderSize = 0;
            customerBtn.FlatStyle = FlatStyle.Flat;
            customerBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerBtn.ForeColor = SystemColors.Control;
            customerBtn.Image = (Image)resources.GetObject("customerBtn.Image");
            customerBtn.Location = new Point(270, 15);
            customerBtn.Name = "customerBtn";
            customerBtn.Size = new Size(142, 48);
            customerBtn.TabIndex = 1;
            customerBtn.Text = "    Customer";
            customerBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            customerBtn.UseVisualStyleBackColor = true;
            // 
            // dashboardBtn
            // 
            dashboardBtn.FlatAppearance.BorderSize = 0;
            dashboardBtn.FlatStyle = FlatStyle.Flat;
            dashboardBtn.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dashboardBtn.ForeColor = SystemColors.Control;
            dashboardBtn.Image = (Image)resources.GetObject("dashboardBtn.Image");
            dashboardBtn.Location = new Point(122, 15);
            dashboardBtn.Name = "dashboardBtn";
            dashboardBtn.Size = new Size(142, 48);
            dashboardBtn.TabIndex = 0;
            dashboardBtn.Text = "    Dashboard";
            dashboardBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            dashboardBtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(16, 22, 33);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 197);
            panel3.Name = "panel3";
            panel3.Size = new Size(1248, 565);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(566, 15);
            button1.Name = "button1";
            button1.Size = new Size(142, 48);
            button1.TabIndex = 3;
            button1.Text = "    Feedback";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.FromArgb(16, 22, 27);
            ClientSize = new Size(1248, 762);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label logoName;
        private Button dashboardBtn;
        private Button feedbackBtn;
        private Button customerBtn;
        private Button button1;
    }
}
