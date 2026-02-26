namespace Cafetea.Forms
{
    partial class loginUC
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
            registerBtn = new LinkLabel();
            label5 = new Label();
            loginBtn = new Button();
            passwordField = new TextBox();
            usernameField = new TextBox();
            label4 = new Label();
            loginLabel = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // registerBtn
            // 
            registerBtn.AutoSize = true;
            registerBtn.Location = new Point(180, 229);
            registerBtn.Name = "registerBtn";
            registerBtn.Size = new Size(48, 15);
            registerBtn.TabIndex = 18;
            registerBtn.TabStop = true;
            registerBtn.Text = "Sign Up";
            registerBtn.LinkClicked += registerBtn_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(43, 229);
            label5.Name = "label5";
            label5.Size = new Size(131, 15);
            label5.TabIndex = 17;
            label5.Text = "Don't have an account?";
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(110, 192);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(75, 23);
            loginBtn.TabIndex = 16;
            loginBtn.Text = "LOGIN";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // passwordField
            // 
            passwordField.Location = new Point(33, 131);
            passwordField.Name = "passwordField";
            passwordField.Size = new Size(228, 23);
            passwordField.TabIndex = 15;
            passwordField.TextChanged += passwordField_TextChanged;
            // 
            // usernameField
            // 
            usernameField.Location = new Point(33, 77);
            usernameField.Name = "usernameField";
            usernameField.Size = new Size(228, 23);
            usernameField.TabIndex = 14;
            usernameField.TextChanged += usernameField_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(31, 113);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 13;
            label4.Text = "PASSWORD";
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginLabel.ForeColor = Color.WhiteSmoke;
            loginLabel.Location = new Point(31, 27);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new Size(45, 15);
            loginLabel.TabIndex = 11;
            loginLabel.Text = "LOGIN";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(31, 57);
            label3.Name = "label3";
            label3.Size = new Size(113, 15);
            label3.TabIndex = 12;
            label3.Text = "USERNAME / EMAIL";
            // 
            // loginUC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 22, 27);
            Controls.Add(registerBtn);
            Controls.Add(label5);
            Controls.Add(loginBtn);
            Controls.Add(passwordField);
            Controls.Add(usernameField);
            Controls.Add(label4);
            Controls.Add(loginLabel);
            Controls.Add(label3);
            Name = "loginUC";
            Size = new Size(293, 270);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel registerBtn;
        private Label label5;
        private Button loginBtn;
        private TextBox passwordField;
        private TextBox usernameField;
        private Label label4;
        private Label loginLabel;
        private Label label3;
    }
}
