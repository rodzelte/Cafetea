using System;
using Guna.Charts.WinForms;
using Microsoft.Data.SqlClient;
using Cafetea.Database.Connection;

namespace BasicExamples
{
    class MonthlyDoughnut
    {
        public static void Example(GunaChart chart)
        {
            chart.Datasets.Clear();

            // Chart configuration
            chart.Title.Text = "Monthly Orders";
            chart.Legend.Position = LegendPosition.Right;
            chart.XAxes.Display = false;
            chart.YAxes.Display = false;

            var dataset = new GunaDoughnutDataset();

            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT 
                    DATENAME(MONTH, OrderDate) AS Month,
                    COUNT(*) AS TotalOrders
                FROM Orders
                WHERE Status = 'Completed'  
                GROUP BY DATENAME(MONTH, OrderDate), MONTH(OrderDate)
                ORDER BY MONTH(OrderDate)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string month = reader["Month"]?.ToString() ?? "Unknown";
                        int orders = reader["TotalOrders"] == DBNull.Value ? 0 : Convert.ToInt32(reader["TotalOrders"]);

                        dataset.DataPoints.Add(month, orders);
                    }
                }
            }

            chart.Datasets.Add(dataset);
            chart.Update();
        }
    }
}