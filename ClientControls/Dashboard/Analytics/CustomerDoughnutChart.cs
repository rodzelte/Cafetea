using System;
using Guna.Charts.WinForms;
using Microsoft.Data.SqlClient;
using Cafetea.Database.Connection;

namespace BasicExamples
{
    class CustomerDoughnutChart
    {
        public static void Example(GunaChart chart)
        {
            chart.Datasets.Clear();

            // Chart configuration
            chart.Title.Text = "Top Customers";
            chart.Legend.Position = LegendPosition.Right;
            chart.XAxes.Display = false;
            chart.YAxes.Display = false;

            var dataset = new GunaDoughnutDataset();

            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT TOP 5 CustomerName, VisitsCount
                FROM Customers
                ORDER BY VisitsCount DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string customer = reader["CustomerName"]?.ToString() ?? "Unknown";
                        int visits = reader["VisitsCount"] == DBNull.Value ? 0 : Convert.ToInt32(reader["VisitsCount"]);

                        dataset.DataPoints.Add(customer, visits);
                    }
                }
            }

            chart.Datasets.Add(dataset);
            chart.Update();
        }
    }
}