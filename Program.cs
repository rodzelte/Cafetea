using Cafetea.Forms;


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
                using (var conn = Cafetea.Database.Database.GetConnection())
                {
                    conn.Open();
                    MessageBox.Show("Successfully connected to the database!");
                }
            }
            catch (Exception ex)
            {
                // This will display the actual error (like a wrong password or missing file)
                MessageBox.Show($"Connection Error: {ex.Message}\n\nDetail: {ex.InnerException?.Message}");
            }

            Application.Run(new MainForm());
        }
    }
}