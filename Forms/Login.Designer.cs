namespace Cafetea.Forms
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            linkLabel2 = new LinkLabel();
            label5 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(107, 24);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(144, 213);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
   
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(124, 32);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(29, 24);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 2;
            label2.Text = "LOGIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(29, 54);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 3;
            label3.Text = "USERNAME / EMAIL";
            // 
            // panel1
            // 
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(37, 277);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 270);
            panel1.TabIndex = 4;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(184, 205);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(48, 15);
            linkLabel2.TabIndex = 10;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Sign Up";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(52, 205);
            label5.Name = "label5";
            label5.Size = new Size(131, 15);
            label5.TabIndex = 8;
            label5.Text = "Don't have an account?";
            // 
            // button1
            // 
            button1.Location = new Point(108, 164);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 7;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(31, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(228, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(31, 74);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(228, 23);
            textBox1.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(29, 110);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 4;
            label4.Text = "PASSWORD";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 22, 27);
            ClientSize = new Size(382, 681);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Panel panel1;
        private LinkLabel linkLabel2;
        private Label label5;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label4;
    }
}