using System;
using Guna.Charts.WinForms;
using Microsoft.Data.SqlClient;
using Cafetea.Database.Connection;

namespace BasicExamples
{
    class ReviewSplineChart
    {
        public static void Example(GunaChart chart)
        {
            chart.Datasets.Clear();

            // Chart configuration
            chart.Title.Text = "Customer Reviews";
            chart.YAxes.GridLines.Display = false;

            var dataset = new GunaSplineDataset();
            dataset.PointRadius = 3;
            dataset.PointStyle = PointStyle.Circle;

            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query = @"
                SELECT 
                    DATENAME(MONTH, FeedbackDate) AS Month,
                    AVG(StarRating) AS AvgRating
                FROM Feedbacks
                GROUP BY DATENAME(MONTH, FeedbackDate), MONTH(FeedbackDate)
                ORDER BY MONTH(FeedbackDate)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string month = reader["Month"]?.ToString() ?? "Unknown";
                        double rating = reader["AvgRating"] == DBNull.Value ? 0 : Convert.ToDouble(reader["AvgRating"]);

                        dataset.DataPoints.Add(month, rating);
                    }
                }
            }

            chart.Datasets.Add(dataset);
            chart.Update();
        }
    }
}