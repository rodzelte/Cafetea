namespace Cafetea.Forms
{
    partial class registerUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            roleDropdown = new ComboBox();
            label1 = new Label();
            signinBtn = new LinkLabel();
            label5 = new Label();
            loginBtn = new Button();
            passwordField = new TextBox();
            usernameField = new TextBox();
            label4 = new Label();
            registerLabel = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(roleDropdown);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(signinBtn);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(loginBtn);
            panel1.Controls.Add(passwordField);
            panel1.Controls.Add(usernameField);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(registerLabel);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 300);
            panel1.TabIndex = 5;
            // 
            // roleDropdown
            // 
            roleDropdown.FormattingEnabled = true;
            roleDropdown.Items.AddRange(new object[] { "Client", "Staff" });
            roleDropdown.Location = new Point(34, 178);
            roleDropdown.Name = "roleDropdown";
            roleDropdown.Size = new Size(225, 23);
            roleDropdown.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(31, 160);
            label1.Name = "label1";
            label1.Size = new Size(35, 15);
            label1.TabIndex = 12;
            label1.Text = "ROLE";
            // 
            // signinBtn
            // 
            signinBtn.AutoSize = true;
            signinBtn.Location = new Point(184, 261);
            signinBtn.Name = "signinBtn";
            signinBtn.Size = new Size(43, 15);
            signinBtn.TabIndex = 10;
            signinBtn.TabStop = true;
            signinBtn.Text = "Sign In";
            signinBtn.LinkClicked += signinBtn_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(31, 261);
            label5.Name = "label5";
            label5.Size = new Size(142, 15);
            label5.TabIndex = 8;
            label5.Text = "Already have an account?";
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(107, 221);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 7;
            loginBtn.Text = "REGISTER";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // passwordField
            // 
            passwordField.Location = new Point(31, 128);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(228, 23);
            passwordField.TabIndex = 6;
            // 
            // usernameField
            // 
            usernameField.Location = new Point(31, 74);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(228, 23);
            usernameField.TabIndex = 5;
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
            // registerLabel
            // 
            registerLabel.AutoSize = true;
            registerLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            registerLabel.ForeColor = Color.WhiteSmoke;
            registerLabel.Location = new Point(29, 24);
            registerLabel.Name = "registerLabel";
            registerLabel.Size = new Size(65, 15);
            registerLabel.TabIndex = 2;
            registerLabel.Text = "REGISTER";
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
            // registerUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 22, 27);
            Controls.Add(panel1);
            Name = "registerUC";
            Size = new Size(293, 303);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private LinkLabel signinBtn;
        private Label label5;
        private Button loginBtn;
        private TextBox passwordField;
        private TextBox usernameField;
        private Label label4;
        private Label registerLabel;
        private Label label3;
        private Label label1;
        private ComboBox roleDropdown;
    }
}
