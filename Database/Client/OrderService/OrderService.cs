using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Cafetea.Database.Client.OrderService
    {
    public class Order
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string NameOfPurchaser { get; set; } = string.Empty; // maps to CustomerName
        public string NameOfOrderPurchase { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }
        public decimal Total { get; set; }
        public string CustomerName { get; set; } = string.Empty; // optional, UI-friendly
    }

    internal class OrderService
        {
            // Add a new order
            public void AddOrder(Order order)
            {
                using var conn = Connection.Database.GetConnection();
                conn.Open();

                string sql = @"
                    INSERT INTO Orders (Name, NameOfPurchaser, NameOfOrderPurchase, Status, OrderDate, Total)
                    VALUES (@Name, @Purchaser, @OrderItem, @Status, @OrderDate, @Total)";

                using var cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@CustomerId", order.CustomerId.HasValue ? (object)order.CustomerId.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@Name", order.Name);
                cmd.Parameters.AddWithValue("@Purchaser", order.NameOfPurchaser);
                cmd.Parameters.AddWithValue("@OrderItem", order.NameOfOrderPurchase);
                cmd.Parameters.AddWithValue("@Status", order.Status);
                cmd.Parameters.AddWithValue("@OrderDate", order.OrderDate);
                cmd.Parameters.AddWithValue("@Total", order.Total);

                cmd.ExecuteNonQuery();
            }

        // Get all orders
        public List<Order> GetOrders()
        {
            var orders = new List<Order>();
            using var conn = Connection.Database.GetConnection();
            conn.Open();

            string sql = @"
        SELECT o.*, c.CustomerName
        FROM Orders o
        LEFT JOIN Customers c ON o.CustomerId = c.Id
        ORDER BY o.OrderDate DESC";

            using var cmd = new SqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                orders.Add(new Order
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    CustomerId = reader["CustomerId"] != DBNull.Value ? (int?)reader["CustomerId"] : null,
                    Name = reader["Name"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("Name")) : string.Empty,
                    NameOfPurchaser = reader["CustomerName"] != DBNull.Value
                        ? reader.GetString(reader.GetOrdinal("CustomerName"))
                        : "Walk-In", // default for walk-ins
                    NameOfOrderPurchase = reader["NameOfOrderPurchase"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("NameOfOrderPurchase")) : string.Empty,
                    Status = reader["Status"] != DBNull.Value ? reader.GetString(reader.GetOrdinal("Status")) : string.Empty,
                    OrderDate = reader["OrderDate"] != DBNull.Value ? reader.GetDateTime(reader.GetOrdinal("OrderDate")) : DateTime.MinValue,
                    Total = reader["Total"] != DBNull.Value ? reader.GetDecimal(reader.GetOrdinal("Total")) : 0m
                });
            }

            return orders;
        }

        // Get report: orders today
        public int GetOrdersToday()
            {
                using var conn = Connection.Database.GetConnection();
                conn.Open();

                string sql = "SELECT COUNT(*) FROM Orders WHERE CAST(OrderDate AS DATE) = CAST(GETDATE() AS DATE)";
                using var cmd = new SqlCommand(sql, conn);
                return (int)cmd.ExecuteScalar()!;
            }

            // Get report: orders this week
            public int GetOrdersThisWeek()
            {
                using var conn = Connection.Database.GetConnection();
                conn.Open();

                string sql = @"
                    SELECT COUNT(*) FROM Orders
                    WHERE OrderDate >= DATEADD(DAY, 1 - DATEPART(WEEKDAY, GETDATE()), CAST(GETDATE() AS DATE))";

                using var cmd = new SqlCommand(sql, conn);
                return (int)cmd.ExecuteScalar()!;
            }

            // Get total revenue
            public decimal GetTotalRevenue()
            {
                using var conn = Connection.Database.GetConnection();
                conn.Open();

                string sql = "SELECT ISNULL(SUM(Total), 0) FROM Orders";
                using var cmd = new SqlCommand(sql, conn);
                return (decimal)cmd.ExecuteScalar()!;
            }
        }
    }