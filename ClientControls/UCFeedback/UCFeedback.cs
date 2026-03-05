using Cafetea.Database.Client.FeedbackService;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Cafetea.AdminControls
{
    public partial class UCFeedback : UserControl
    {
        private FeedbackService feedbackService = new FeedbackService();

        public UCFeedback()
        {
            InitializeComponent();

            // Hide the template panel
            feedbackPanel.Visible = false;

            // Setup ComboBoxes
            daterangeCB.DropDownStyle = ComboBoxStyle.DropDownList;
            statusCB.DropDownStyle = ComboBoxStyle.DropDownList;

            LoadDateRange();
            LoadStatusOptions();

            // Event handlers for filtering
            daterangeCB.SelectedIndexChanged += (s, e) => LoadFeedbacks();
            statusCB.SelectedIndexChanged += (s, e) => LoadFeedbacks();
            customernameSearch.TextChanged += (s, e) => LoadFeedbacks();

            LoadFeedbacks();
        }

        private void LoadDateRange()
        {
            daterangeCB.Items.Clear();
            daterangeCB.Items.AddRange(new[] { "Today", "This Week", "All" });
            daterangeCB.SelectedIndex = 2; // Default: All
        }

        private void LoadStatusOptions()
        {
            statusCB.Items.Clear();
            statusCB.Items.Add("All"); // Default option

            var feedbacks = feedbackService.GetAllFeedback();
            var statusSet = feedbacks.Select(f => f.Status).Where(s => !string.IsNullOrEmpty(s)).Distinct();

            foreach (var status in statusSet)
                statusCB.Items.Add(status);

            statusCB.SelectedIndex = 0; // Default: All
        }

        private void LoadFeedbacks()
        {
            flowlayoutpanelFeedback.Controls.Clear();

            var allFeedback = feedbackService.GetAllFeedback();
            var filtered = allFeedback.AsEnumerable();

            // --- FILTERS ---

            // Customer name search
            if (!string.IsNullOrWhiteSpace(customernameSearch.Text))
                filtered = filtered.Where(f => f.CustomerName.IndexOf(customernameSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0);

            // Status filter
            string selectedStatus = statusCB.SelectedItem?.ToString() ?? "All";
            if (selectedStatus != "All")
                filtered = filtered.Where(f => f.Status == selectedStatus);

            // Date range filter
            DateTime today = DateTime.Today;
            switch (daterangeCB.SelectedItem?.ToString())
            {
                case "Today":
                    filtered = filtered.Where(f => f.FeedbackDate.Date == today);
                    break;
                case "This Week":
                    int diffToMonday = ((int)today.DayOfWeek + 6) % 7; // Monday as start
                    DateTime monday = today.AddDays(-diffToMonday);
                    filtered = filtered.Where(f => f.FeedbackDate.Date >= monday && f.FeedbackDate.Date <= today);
                    break;
            }

            // --- SUMMARY CALCULATIONS ---

            int totalReviews = filtered.Count();
            totalReviewlbl.Text = totalReviews.ToString();

            double avgRating = totalReviews > 0 ? filtered.Average(f => f.StarRating) : 0;
            avgRatingLbl.Text = $"{avgRating:F1}/5";

            int completedReviews = filtered.Count(f => f.Status == "Completed");
            double percentageCompleted = totalReviews > 0 ? (completedReviews * 100.0 / totalReviews) : 0;
            percentageAllReviewLbl.Text = $"{percentageCompleted:F0}%";

            // --- DISPLAY FEEDBACKS ---

            foreach (var feedback in filtered)
            {
                Panel feedbackCard = ClonePanel(feedbackPanel);
                feedbackCard.Tag = feedback.Id;

                // Find controls inside the panel
                var customerLbl = feedbackCard.Controls.Find("customerNameFeedbacklbl", true).FirstOrDefault() as Label;
                var dateLbl = feedbackCard.Controls.Find("feedbackDatelbl", true).FirstOrDefault() as Label;
                var descLbl = feedbackCard.Controls.Find("feedbackDescriptionlbl", true).FirstOrDefault() as Label;
                var ratingLblCopy = feedbackCard.Controls.Find("ratingLbl", true).FirstOrDefault() as Label;
                var reviewBtn = feedbackCard.Controls.Find("markasReviewbtn", true).FirstOrDefault() as Button;

                if (customerLbl != null) customerLbl.Text = feedback.CustomerName;
                if (dateLbl != null) dateLbl.Text = feedback.FeedbackDate.ToString("MM/dd/yyyy");
                if (descLbl != null) descLbl.Text = feedback.FeedbackDescription;
                if (ratingLblCopy != null) ratingLblCopy.Text = $"Rating: {feedback.StarRating}/5";

                if (reviewBtn != null)
                {
                    reviewBtn.Click -= ReviewBtn_Click; // Remove previous handlers

                    if (feedback.Status == "Completed")
                    {
                        reviewBtn.Enabled = false;
                        reviewBtn.Text = "Completed";
                    }
                    else
                    {
                        reviewBtn.Enabled = true;
                        reviewBtn.Text = "Mark as Review";
                        reviewBtn.Tag = feedback.Id;
                        reviewBtn.Click += ReviewBtn_Click;
                    }
                }

                flowlayoutpanelFeedback.Controls.Add(feedbackCard);
            }
        }

        // Event handler for mark as review
        private void ReviewBtn_Click(object? sender, EventArgs e)
        {
            if (sender is Button btn && btn.Tag is int feedbackId)
            {
                feedbackService.MarkAsCompleted(feedbackId);
                LoadFeedbacks(); // Refresh the UI after marking completed
            }
        }

        /// <summary>
        /// Clone a panel including all child controls and appearance.
        /// </summary>
        private Panel ClonePanel(Panel template)
        {
            Panel newPanel = new Panel
            {
                Size = template.Size,
                BorderStyle = template.BorderStyle,
                BackColor = Color.FromArgb(16, 22, 33),
                Margin = template.Margin,
                Padding = template.Padding
            };

            foreach (Control ctrl in template.Controls)
            {
                Control newCtrl;

                if (ctrl is Label lbl)
                {
                    newCtrl = new Label
                    {
                        Name = lbl.Name,
                        Text = lbl.Text,
                        Location = lbl.Location,
                        Size = lbl.Size,
                        Font = lbl.Font,
                        ForeColor = lbl.ForeColor,
                        AutoSize = lbl.AutoSize,
                        TextAlign = lbl.TextAlign
                    };
                }
                else if (ctrl is Button btn)
                {
                    newCtrl = new Button
                    {
                        Name = btn.Name,
                        Text = btn.Text,
                        Size = btn.Size,
                        Location = btn.Location,
                        Font = btn.Font,
                        BackColor = btn.BackColor
                    };
                }
                else
                {
                    newCtrl = new Control
                    {
                        Name = ctrl.Name,
                        Size = ctrl.Size,
                        Location = ctrl.Location,
                        Font = ctrl.Font
                    };
                }

                newPanel.Controls.Add(newCtrl);
            }

            return newPanel;
        }
    }
}