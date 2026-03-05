using BasicExamples;
using Cafetea.AdminControls;
using System;
using System.Windows.Forms;

namespace Cafetea
{
    public partial class Dashboard : Form
    {
        // Panel to hold the dashboard charts (nullable for C# 10)
        private Panel? dashboardPanel;


        public Dashboard()
        {
            InitializeComponent();

            // Initialize dashboard panel and charts
            InitializeDashboardPanel();

            // Show dashboard by default
            ShowDashboard();
        }

        #region Panel Initialization
        private void InitializeDashboardPanel()
        {
            dashboardPanel = new Panel();
            dashboardPanel.Dock = DockStyle.Fill;

            // Add Guna charts to the panel
            dashboardPanel.Controls.Add(revenueChart);
            dashboardPanel.Controls.Add(MonthlyDoughnutChart);
            dashboardPanel.Controls.Add(gunaCustomerChart);
            dashboardPanel.Controls.Add(gunaReviewChart);

            panelContainer.Controls.Add(dashboardPanel);
        }
        #endregion

        #region Load Admin Controls
        public void LoadAdminControl(UserControl control)
        {
            control.Dock = DockStyle.Fill;

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(control);
            control.BringToFront();
        }
        #endregion

        #region Dashboard Button
        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void ShowDashboard()
        {
            if (dashboardPanel == null) return; // safety check

            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(dashboardPanel);
            dashboardPanel.BringToFront();

            LoadCharts(); // refresh chart data
        }
        #endregion

        #region Other Buttons
        private void customerBtn_Click(object sender, EventArgs e)
        {
            LoadAdminControl(new UCCustomer());
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            LoadAdminControl(new UCOrders());
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {
            LoadAdminControl(new UCFeedback());
        }

        private void promoBtn_Click(object sender, EventArgs e)
        {
            LoadAdminControl(new UCPromos());
        }

        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Load Charts
        public void LoadCharts()
        {
            RevenueSpline.Example(revenueChart);
            MonthlyDoughnut.Example(MonthlyDoughnutChart);
            CustomerDoughnutChart.Example(gunaCustomerChart);
            ReviewSplineChart.Example(gunaReviewChart);
        }
        #endregion
    }
}
