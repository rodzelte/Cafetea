using Cafetea.Database.Connection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Cafetea.Database.Staff.ProgressService
{
    internal class OrderProgressService
    {
        public class OrderProgress
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string NameOfPurchaser { get; set; } = string.Empty;
            public string NameOfOrderPurchase { get; set; } = string.Empty;
            public string Status { get; set; } = string.Empty;
            public decimal Total { get; set; }
            public DateTime OrderDate { get; set; }
        }

        // Get all orders that are not completed
        public List<OrderProgress> GetPendingOrders()
        {
            var orders = new List<OrderProgress>();

            using var conn = Database.Connection.Database.GetConnection();
            conn.Open();

            string sql = @"
                SELECT Id, Name, NameOfPurchaser, NameOfOrderPurchase, Status, Total, OrderDate
                FROM Orders
                WHERE Status <> 'Completed'
                ORDER BY OrderDate DESC";

            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                orders.Add(new OrderProgress
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    Name = reader["Name"].ToString() ?? string.Empty,
                    NameOfPurchaser = reader["NameOfPurchaser"].ToString() ?? string.Empty,
                    NameOfOrderPurchase = reader["NameOfOrderPurchase"].ToString() ?? string.Empty,
                    Status = reader["Status"].ToString() ?? string.Empty,
                    Total = Convert.ToDecimal(reader["Total"]),
                    OrderDate = Convert.ToDateTime(reader["OrderDate"])
                });
            }

            return orders;
        }

        // Mark order as completed
        public void MarkAsCompleted(int orderId)
        {
            using var conn = Database.Connection.Database.GetConnection();
            conn.Open();

            string sql = "UPDATE Orders SET Status = 'Completed' WHERE Id = @OrderId";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@OrderId", orderId);
            cmd.ExecuteNonQuery();
        }
    }
}