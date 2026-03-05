using Cafetea.AdminControls;
using Cafetea.Forms;
using Cafetea.Simulator;
using Cafetea.StaffControls.Dashboard;
using Cafetea.StaffControls.UCOrder;


namespace Cafetea
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            try
            {
                using (var conn = Database.Connection.Database.GetConnection())
                {
                    conn.Open();
                    MessageBox.Show("Successfully connected to the database!");
                    Application.Run(new Dashboard());
                    //Application.Run(new SuperAdminControls.ActivationKey());
                    Simulate.RunTimeSimulation(numCustomers: 10, daysBack: 30);
                }
            }
            catch (Exception ex)
            {
                // This will display the actual error (like a wrong password or missing file)
                MessageBox.Show($"Connection Error: {ex.Message}\n\nDetail: {ex.InnerException?.Message}");
            }

          
        }
    }
}