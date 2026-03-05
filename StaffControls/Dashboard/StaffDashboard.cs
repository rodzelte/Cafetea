using Cafetea.AdminControls;
using Cafetea.StaffControls.UCOrder;
using Cafetea.StaffControls.UCOrderProgress;
using System;
using System.Windows.Forms;

namespace Cafetea.StaffControls.Dashboard
{
    public partial class StaffDashboard : Form
    {
        public StaffDashboard()
        {
            InitializeComponent();
            ShowDashboard();
        }

        #region Load Controls
        public void LoadAdminControl(UserControl control)
        {
            control.Dock = DockStyle.Fill;

            UCStaffPanel.Controls.Clear();
            UCStaffPanel.Controls.Add(control);
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
            LoadAdminControl(new UCStaffOrder());
        }
        #endregion



        private void OrderProgressBtn_Click(object sender, EventArgs e)
        {
            LoadAdminControl(new UCOrderProgress.UCOrderProgress());
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            LoadAdminControl(new UCStaffOrder());
        }
    }
}