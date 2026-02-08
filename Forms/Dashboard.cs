using Cafetea.AdminControls;

namespace Cafetea
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }


        private void LoadAdminControl(UserControl control)
        {
            control.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(control);
            control.BringToFront();
        }


        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            LoadAdminControl(new UCDashboard());
        }

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


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
