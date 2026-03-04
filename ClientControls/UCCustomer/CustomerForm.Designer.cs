namespace Cafetea.ClientControls.UCCustomer
{
    partial class CustomerForm
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
            deleteCsBtn = new Button();
            doneBtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nameCustomerFormlbl = new TextBox();
            emailCsFormlbl = new TextBox();
            SuspendLayout();
            // 
            // deleteCsBtn
            // 
            deleteCsBtn.Location = new Point(214, 167);
            deleteCsBtn.Name = "deleteCsBtn";
            deleteCsBtn.Size = new Size(125, 23);
            deleteCsBtn.TabIndex = 1;
            deleteCsBtn.Text = "Delete Customer";
            deleteCsBtn.UseVisualStyleBackColor = true;
            // 
            // doneBtn
            // 
            doneBtn.Location = new Point(355, 167);
            doneBtn.Name = "doneBtn";
            doneBtn.Size = new Size(75, 23);
            doneBtn.TabIndex = 2;
            doneBtn.Text = "Done";
            doneBtn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(21, 9);
            label1.Name = "label1";
            label1.Size = new Size(83, 21);
            label1.TabIndex = 3;
            label1.Text = "Customer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(73, 62);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 4;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(75, 98);
            label3.Name = "label3";
            label3.Size = new Size(51, 21);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // nameCustomerFormlbl
            // 
            nameCustomerFormlbl.Location = new Point(151, 62);
            nameCustomerFormlbl.Name = "nameCustomerFormlbl";
            nameCustomerFormlbl.Size = new Size(199, 23);
            nameCustomerFormlbl.TabIndex = 6;
            // 
            // emailCsFormlbl
            // 
            emailCsFormlbl.Location = new Point(151, 98);
            emailCsFormlbl.Name = "emailCsFormlbl";
            emailCsFormlbl.Size = new Size(199, 23);
            emailCsFormlbl.TabIndex = 7;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 22, 33);
            ClientSize = new Size(435, 202);
            Controls.Add(emailCsFormlbl);
            Controls.Add(nameCustomerFormlbl);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(doneBtn);
            Controls.Add(deleteCsBtn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button deleteCsBtn;
        private Button doneBtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nameCustomerFormlbl;
        private TextBox emailCsFormlbl;
    }
}