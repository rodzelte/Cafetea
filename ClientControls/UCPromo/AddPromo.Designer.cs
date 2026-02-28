namespace Cafetea.ClientControls.UCPromo
{
    partial class AddPromo
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
            label2 = new Label();
            label1 = new Label();
            addPromoBtn = new Button();
            label3 = new Label();
            label4 = new Label();
            discountCB = new ComboBox();
            label5 = new Label();
            codeTb = new TextBox();
            descriptionTb = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(28, 51);
            label2.Name = "label2";
            label2.Size = new Size(258, 15);
            label2.TabIndex = 10;
            label2.Text = "Manage discount codes and promotional offers";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(28, 24);
            label1.Name = "label1";
            label1.Size = new Size(88, 18);
            label1.TabIndex = 9;
            label1.Text = "Promotions";
            // 
            // addPromoBtn
            // 
            addPromoBtn.Location = new Point(107, 326);
            addPromoBtn.Name = "addPromoBtn";
            addPromoBtn.Size = new Size(117, 23);
            addPromoBtn.TabIndex = 11;
            addPromoBtn.Text = "Add Promo";
            addPromoBtn.UseVisualStyleBackColor = true;
            addPromoBtn.Click += addPromoBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(66, 134);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 14;
            label3.Text = "Code";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(66, 188);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 15;
            label4.Text = "Description";
            // 
            // discountCB
            // 
            discountCB.FormattingEnabled = true;
            discountCB.Location = new Point(66, 268);
            discountCB.Name = "discountCB";
            discountCB.Size = new Size(121, 23);
            discountCB.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(66, 250);
            label5.Name = "label5";
            label5.Size = new Size(116, 15);
            label5.TabIndex = 17;
            label5.Text = "Discount Percentage";
            // 
            // codeTb
            // 
            codeTb.Location = new Point(66, 152);
            codeTb.Name = "codeTb";
            codeTb.Size = new Size(220, 23);
            codeTb.TabIndex = 18;
            codeTb.TextChanged += codeTb_TextChanged;
            // 
            // descriptionTb
            // 
            descriptionTb.Location = new Point(66, 206);
            descriptionTb.Name = "descriptionTb";
            descriptionTb.Size = new Size(220, 23);
            descriptionTb.TabIndex = 19;
            descriptionTb.TextChanged += descriptionTb_TextChanged;
            // 
            // AddPromo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(16, 22, 33);
            ClientSize = new Size(355, 396);
            Controls.Add(descriptionTb);
            Controls.Add(codeTb);
            Controls.Add(label5);
            Controls.Add(discountCB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(addPromoBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddPromo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPromo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button addPromoBtn;
        private Label label3;
        private Label label4;
        private ComboBox discountCB;
        private Label label5;
        private TextBox codeTb;
        private TextBox descriptionTb;
    }
}