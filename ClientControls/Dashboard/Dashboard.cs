using BasicExamples;
using Cafetea.AdminControls;

namespace Cafetea


{
    public partial class Dashboard : Form
    {
        // Panel to hold the dashboard charts
        private Panel? dashboardPanel;

        // Notification manager


        public Dashboard()
        {
            InitializeComponent();




            // 1️⃣ Initialize dashboard panel and add Guna charts
            InitializeDashboardPanel();

            // 2️⃣ Show dashboard
            ShowDashboard();

            // 3️⃣ Load chart data
            LoadCharts();

            // 4️⃣ Initialize notification manager

            // Initialize notifications only after form fully shown

        }






        #region Panel Initialization
        private void InitializeDashboardPanel()
        {
            dashboardPanel = new Panel
            {
                Dock = DockStyle.Fill
            };

            // Add Guna charts to the panel
            dashboardPanel.Controls.Add(revenueChart);
            dashboardPanel.Controls.Add(MonthlyDoughnutChart);
            dashboardPanel.Controls.Add(gunaCustomerChart);
            dashboardPanel.Controls.Add(gunaReviewChart);

            // Add the panel to the container
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
            if (dashboardPanel == null) return;

            // Clear container and add dashboard panel
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(dashboardPanel);
            dashboardPanel.BringToFront();

            // Refresh panel to force Guna charts to render
            dashboardPanel.Refresh();

            // Load chart data
            LoadCharts();
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


        private void exitBtn_Click(object sender, EventArgs e)
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

        private void Dashboard_Load(object sender, EventArgs e)
        {

            // 1️⃣ Initialize dashboard panel and add Guna charts
            InitializeDashboardPanel();

            // 2️⃣ Show dashboard
            ShowDashboard();

            // 3️⃣ Load chart data
            LoadCharts();





        }

    }

}