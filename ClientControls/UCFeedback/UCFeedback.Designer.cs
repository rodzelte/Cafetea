namespace Cafetea.AdminControls
{
    partial class UCFeedback
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCFeedback));
            panel5 = new Panel();
            customernameSearch = new TextBox();
            statusCB = new ComboBox();
            daterangeCB = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            panel4 = new Panel();
            pictureBox8 = new PictureBox();
            percentageAllReviewLbl = new Label();
            label19 = new Label();
            panel3 = new Panel();
            pictureBox7 = new PictureBox();
            totalReviewlbl = new Label();
            label18 = new Label();
            panel2 = new Panel();
            pictureBox6 = new PictureBox();
            avgRatingLbl = new Label();
            label17 = new Label();
            label2 = new Label();
            label1 = new Label();
            flowlayoutpanelFeedback = new FlowLayoutPanel();
            feedbackPanel = new Panel();
            ratingLbl = new Label();
            label8 = new Label();
            label6 = new Label();
            feedbackDatelbl = new Label();
            markasReviewbtn = new Button();
            feedbackDescriptionlbl = new Label();
            customerNameFeedbacklbl = new Label();
            panel5.SuspendLayout();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            flowlayoutpanelFeedback.SuspendLayout();
            feedbackPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel5
            // 
            panel5.Controls.Add(customernameSearch);
            panel5.Controls.Add(statusCB);
            panel5.Controls.Add(daterangeCB);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(98, 237);
            panel5.Name = "panel5";
            panel5.Size = new Size(963, 79);
            panel5.TabIndex = 14;
            // 
            // customernameSearch
            // 
            customernameSearch.Location = new Point(669, 29);
            customernameSearch.Name = "customernameSearch";
            customernameSearch.PlaceholderText = "Search";
            customernameSearch.Size = new Size(247, 23);
            customernameSearch.TabIndex = 14;
            // 
            // statusCB
            // 
            statusCB.FormattingEnabled = true;
            statusCB.Items.AddRange(new object[] { "All Feedback", "New", "Reviewed", "Archived" });
            statusCB.Location = new Point(352, 29);
            statusCB.Name = "statusCB";
            statusCB.Size = new Size(281, 23);
            statusCB.TabIndex = 13;
            // 
            // daterangeCB
            // 
            daterangeCB.FormattingEnabled = true;
            daterangeCB.Items.AddRange(new object[] { "All Ratings", "1 Star", "2 Star", "3 Star", "4 Star", "5 Star" });
            daterangeCB.Location = new Point(25, 29);
            daterangeCB.Name = "daterangeCB";
            daterangeCB.Size = new Size(259, 23);
            daterangeCB.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(669, 11);
            label5.Name = "label5";
            label5.Size = new Size(64, 15);
            label5.TabIndex = 12;
            label5.Text = "Customers";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(352, 11);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 11;
            label4.Text = "Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(25, 11);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 10;
            label3.Text = "Date Range";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(98, 112);
            panel1.Name = "panel1";
            panel1.Size = new Size(963, 108);
            panel1.TabIndex = 13;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox8);
            panel4.Controls.Add(percentageAllReviewLbl);
            panel4.Controls.Add(label19);
            panel4.Location = new Point(669, 20);
            panel4.Name = "panel4";
            panel4.Size = new Size(267, 69);
            panel4.TabIndex = 1;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = (Image)resources.GetObject("pictureBox8.Image");
            pictureBox8.Location = new Point(3, 1);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(67, 66);
            pictureBox8.TabIndex = 18;
            pictureBox8.TabStop = false;
            // 
            // percentageAllReviewLbl
            // 
            percentageAllReviewLbl.AutoSize = true;
            percentageAllReviewLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            percentageAllReviewLbl.ForeColor = Color.WhiteSmoke;
            percentageAllReviewLbl.Location = new Point(89, 13);
            percentageAllReviewLbl.Name = "percentageAllReviewLbl";
            percentageAllReviewLbl.Size = new Size(42, 21);
            percentageAllReviewLbl.TabIndex = 17;
            percentageAllReviewLbl.Text = "94%";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label19.ForeColor = Color.WhiteSmoke;
            label19.Location = new Point(89, 34);
            label19.Name = "label19";
            label19.Size = new Size(111, 17);
            label19.TabIndex = 17;
            label19.Text = "Positive Feedback";
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox7);
            panel3.Controls.Add(totalReviewlbl);
            panel3.Controls.Add(label18);
            panel3.Location = new Point(352, 20);
            panel3.Name = "panel3";
            panel3.Size = new Size(281, 69);
            panel3.TabIndex = 1;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = (Image)resources.GetObject("pictureBox7.Image");
            pictureBox7.Location = new Point(2, 1);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(67, 66);
            pictureBox7.TabIndex = 17;
            pictureBox7.TabStop = false;
            // 
            // totalReviewlbl
            // 
            totalReviewlbl.AutoSize = true;
            totalReviewlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalReviewlbl.ForeColor = Color.WhiteSmoke;
            totalReviewlbl.Location = new Point(79, 13);
            totalReviewlbl.Name = "totalReviewlbl";
            totalReviewlbl.Size = new Size(37, 21);
            totalReviewlbl.TabIndex = 16;
            totalReviewlbl.Text = "127";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label18.ForeColor = Color.WhiteSmoke;
            label18.Location = new Point(79, 34);
            label18.Name = "label18";
            label18.Size = new Size(86, 17);
            label18.TabIndex = 16;
            label18.Text = "Total Reviews";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(avgRatingLbl);
            panel2.Controls.Add(label17);
            panel2.Location = new Point(25, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(280, 69);
            panel2.TabIndex = 0;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(1, 1);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(67, 66);
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // avgRatingLbl
            // 
            avgRatingLbl.AutoSize = true;
            avgRatingLbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            avgRatingLbl.ForeColor = Color.WhiteSmoke;
            avgRatingLbl.Location = new Point(74, 13);
            avgRatingLbl.Name = "avgRatingLbl";
            avgRatingLbl.Size = new Size(69, 21);
            avgRatingLbl.TabIndex = 15;
            avgRatingLbl.Text = "4.5 / 5.0";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label17.ForeColor = Color.WhiteSmoke;
            label17.Location = new Point(74, 34);
            label17.Name = "label17";
            label17.Size = new Size(97, 17);
            label17.TabIndex = 15;
            label17.Text = "Average Rating";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.WhiteSmoke;
            label2.Location = new Point(67, 66);
            label2.Name = "label2";
            label2.Size = new Size(190, 15);
            label2.TabIndex = 12;
            label2.Text = "Customer reviews and suggestions";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(56, 35);
            label1.Name = "label1";
            label1.Size = new Size(84, 18);
            label1.TabIndex = 11;
            label1.Text = "Feedback";
            // 
            // flowlayoutpanelFeedback
            // 
            flowlayoutpanelFeedback.AutoScroll = true;
            flowlayoutpanelFeedback.Controls.Add(feedbackPanel);
            flowlayoutpanelFeedback.FlowDirection = FlowDirection.TopDown;
            flowlayoutpanelFeedback.Location = new Point(98, 332);
            flowlayoutpanelFeedback.Name = "flowlayoutpanelFeedback";
            flowlayoutpanelFeedback.Size = new Size(963, 362);
            flowlayoutpanelFeedback.TabIndex = 16;
            flowlayoutpanelFeedback.WrapContents = false;
            // 
            // feedbackPanel
            // 
            feedbackPanel.Controls.Add(ratingLbl);
            feedbackPanel.Controls.Add(label8);
            feedbackPanel.Controls.Add(label6);
            feedbackPanel.Controls.Add(feedbackDatelbl);
            feedbackPanel.Controls.Add(markasReviewbtn);
            feedbackPanel.Controls.Add(feedbackDescriptionlbl);
            feedbackPanel.Controls.Add(customerNameFeedbacklbl);
            feedbackPanel.Location = new Point(3, 3);
            feedbackPanel.Name = "feedbackPanel";
            feedbackPanel.Size = new Size(960, 352);
            feedbackPanel.TabIndex = 0;
            // 
            // ratingLbl
            // 
            ratingLbl.AutoSize = true;
            ratingLbl.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ratingLbl.ForeColor = Color.WhiteSmoke;
            ratingLbl.Location = new Point(802, 56);
            ratingLbl.Name = "ratingLbl";
            ratingLbl.Size = new Size(20, 25);
            ratingLbl.TabIndex = 23;
            ratingLbl.Text = "1";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(818, 56);
            label8.Name = "label8";
            label8.Size = new Size(36, 25);
            label8.TabIndex = 22;
            label8.Text = "/ 5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(786, 25);
            label6.Name = "label6";
            label6.Size = new Size(78, 25);
            label6.TabIndex = 20;
            label6.Text = "Ratings";
            // 
            // feedbackDatelbl
            // 
            feedbackDatelbl.AutoSize = true;
            feedbackDatelbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            feedbackDatelbl.ForeColor = Color.WhiteSmoke;
            feedbackDatelbl.Location = new Point(34, 33);
            feedbackDatelbl.Name = "feedbackDatelbl";
            feedbackDatelbl.Size = new Size(75, 17);
            feedbackDatelbl.TabIndex = 15;
            feedbackDatelbl.Text = "Feb 1, 2026";
            // 
            // markasReviewbtn
            // 
            markasReviewbtn.Location = new Point(34, 94);
            markasReviewbtn.Name = "markasReviewbtn";
            markasReviewbtn.Size = new Size(118, 23);
            markasReviewbtn.TabIndex = 14;
            markasReviewbtn.Text = "MARK AS REVIEW";
            markasReviewbtn.UseVisualStyleBackColor = true;
            // 
            // feedbackDescriptionlbl
            // 
            feedbackDescriptionlbl.AutoSize = true;
            feedbackDescriptionlbl.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            feedbackDescriptionlbl.ForeColor = Color.WhiteSmoke;
            feedbackDescriptionlbl.Location = new Point(34, 62);
            feedbackDescriptionlbl.Name = "feedbackDescriptionlbl";
            feedbackDescriptionlbl.Size = new Size(453, 17);
            feedbackDescriptionlbl.TabIndex = 2;
            feedbackDescriptionlbl.Text = "Excellent service! The cappuccino was perfect and the staff was very friendly.";
            // 
            // customerNameFeedbacklbl
            // 
            customerNameFeedbacklbl.AutoSize = true;
            customerNameFeedbacklbl.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customerNameFeedbacklbl.ForeColor = Color.WhiteSmoke;
            customerNameFeedbacklbl.Location = new Point(34, 16);
            customerNameFeedbacklbl.Name = "customerNameFeedbacklbl";
            customerNameFeedbacklbl.Size = new Size(65, 17);
            customerNameFeedbacklbl.TabIndex = 1;
            customerNameFeedbacklbl.Text = "John Doe";
            // 
            // UCFeedback
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnableAllowFocusChange;
            BackColor = Color.FromArgb(16, 22, 33);
            Controls.Add(flowlayoutpanelFeedback);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UCFeedback";
            Size = new Size(1248, 553);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel1.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            flowlayoutpanelFeedback.ResumeLayout(false);
            feedbackPanel.ResumeLayout(false);
            feedbackPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel5;
        private TextBox customernameSearch;
        private ComboBox statusCB;
        private ComboBox daterangeCB;
        private Label label5;
        private Label label4;
        private Label label3;
        private Panel panel1;
        private Panel panel4;
        private Label percentageAllReviewLbl;
        private Label label19;
        private Panel panel3;
        private Label totalReviewlbl;
        private Label label18;
        private Panel panel2;
        private Label avgRatingLbl;
        private Label label17;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox8;
        private PictureBox pictureBox7;
        private FlowLayoutPanel flowlayoutpanelFeedback;
        private Panel feedbackPanel;
        private Label feedbackDatelbl;
        private Button markasReviewbtn;
        private Label feedbackDescriptionlbl;
        private Label customerNameFeedbacklbl;
        private Label label6;
        private Label label8;
        private Label ratingLbl;
    }
}
