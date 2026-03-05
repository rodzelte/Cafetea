using System;
using System.Windows.Forms;
using Cafetea.StaffControls.UCOrder;
using Cafetea.StaffControls.UCOrderProgress;

namespace Cafetea.StaffControls.Dashboard
{
    public partial class StaffDashboard : Form
    {
        // Panel to hold current UserControl
        private Panel? currentPanel;

        public StaffDashboard()
        {
            InitializeComponent();

            // Optionally, show default control
            ShowUCOrders();
        }

        #region Load Admin Control
        private void LoadAdminControl(UserControl control)
        {
            control.Dock = DockStyle.Fill;

            if (currentPanel != null)
                UCPanel.Controls.Remove(currentPanel); // remove previous control

            currentPanel = new Panel
            {
                Dock = DockStyle.Fill
            };
            currentPanel.Controls.Add(control);

            UCPanel.Controls.Add(currentPanel);
            currentPanel.BringToFront();
        }
        #endregion

        #region Button Clicks
        private void OrderBtn_Click(object sender, EventArgs e)
        {
            ShowUCOrders();
        }

        private void OrderProgressBtn_Click(object sender, EventArgs e)
        {
            ShowUCOrderProgress();
        }
        #endregion

        #region Show Methods
        private void ShowUCOrders()
        {
            LoadAdminControl(new UCOrder.UCOrder());
        }

        private void ShowUCOrderProgress()
        {
            LoadAdminControl(new UCOrderProgress.UCOrderProgress());
        }
        #endregion
    }
}