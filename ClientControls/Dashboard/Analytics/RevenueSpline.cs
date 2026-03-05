using System;
using Guna.Charts.WinForms;
using Microsoft.Data.SqlClient;
using Cafetea.Database.Connection;

namespace BasicExamples
{
    class RevenueSpline
    {
        public static void Example(GunaChart chart)
        {
            chart.Datasets.Clear();

            // Chart configuration
            chart.Title.Text = "Monthly Revenue";
            chart.YAxes.GridLines.Display = false;

            var dataset = new GunaSplineDataset();
            dataset.PointRadius = 3;
            dataset.PointStyle = PointStyle.Circle;

            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT 
                    DATENAME(MONTH, OrderDate) AS Month,
                    SUM(Total) AS Revenue
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
                        double revenue = reader["Revenue"] == DBNull.Value ? 0 : Convert.ToDouble(reader["Revenue"]);

                        dataset.DataPoints.Add(month, revenue);
                    }
                }
            }

            chart.Datasets.Add(dataset);
            chart.Update();
        }
    }
}