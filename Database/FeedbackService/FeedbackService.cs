using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using Cafetea.Database.Connection;

namespace Cafetea.Database.FeedbackService
{
    public class Feedback
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }             // nullable for walk-ins
        public string CustomerName { get; set; } = string.Empty;
        public DateTime FeedbackDate { get; set; }
        public string Status { get; set; } = "Pending";
        public int StarRating { get; set; }
        public string FeedbackDescription { get; set; } = string.Empty;
    }

    public class FeedbackService
    {
        // Add new feedback using CustomerId (nullable for walk-ins)
        public void AddFeedback(int? customerId, int starRating, string description)
        {
            using (var conn = Connection.Database.GetConnection())
            {
                string query = @"INSERT INTO Feedbacks 
                                 (CustomerId, StarRating, FeedbackDescription) 
                                 VALUES (@customerId, @rating, @description)";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@customerId", (object)customerId ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@rating", starRating);
                cmd.Parameters.AddWithValue("@description", description);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }

        // Retrieve all feedbacks with CustomerName or "Walk-In" if null
        public List<Feedback> GetAllFeedback()
        {
            var feedbacks = new List<Feedback>();

            using (var conn = Connection.Database.GetConnection())
            {
                string query = @"
                    SELECT f.*, c.CustomerName
                    FROM Feedbacks f
                    LEFT JOIN Customers c ON f.CustomerId = c.Id
                    ORDER BY f.FeedbackDate DESC";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    feedbacks.Add(new Feedback
                    {
                        Id = (int)reader["Id"],
                        CustomerId = reader["CustomerId"] != DBNull.Value ? (int?)reader["CustomerId"] : null,
                        CustomerName = reader["CustomerName"] != DBNull.Value
                                       ? reader["CustomerName"].ToString()
                                       : "Walk-In",
                        FeedbackDate = (DateTime)reader["FeedbackDate"],
                        Status = reader["Status"]?.ToString() ?? "Pending",
                        StarRating = (int)reader["StarRating"],
                        FeedbackDescription = reader["FeedbackDescription"]?.ToString() ?? string.Empty
                    });
                }
            }

            return feedbacks;
        }

        // Mark feedback as Completed
        public void MarkAsCompleted(int id)
        {
            using (var conn = Connection.Database.GetConnection())
            {
                string query = "UPDATE Feedbacks SET Status = 'Completed' WHERE Id = @id";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                conn.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}