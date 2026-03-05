using Cafetea.Database.Connection;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cafetea.Database.Staff.OrderService
{
    public class StaffOrderService
    {
        public class Order
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public int CustomerId { get; set; }
            public string NameOfPurchaser { get; set; } = string.Empty;
            public string Status { get; set; } = string.Empty;
            public DateTime OrderDate { get; set; }
            public decimal Total { get; set; }
            public int? PromoCodeId { get; set; }
        }

        public class OrderItem
        {
            public int Id { get; set; }
            public int OrderId { get; set; }
            public string ProductName { get; set; } = string.Empty;
            public decimal Price { get; set; }
            public int Quantity { get; set; }
            public decimal Total => Price * Quantity;
        }

        // Get all orders
        public List<Order> GetOrders()
        {
            var orders = new List<Order>();

            using (var conn = Database.Connection.Database.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT Id, Name, CustomerId, NameOfPurchaser, Status, OrderDate, Total, PromoCodeId
                    FROM Orders
                    ORDER BY OrderDate DESC";

                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        orders.Add(new Order
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            Name = reader["Name"].ToString() ?? string.Empty,
                            CustomerId = Convert.ToInt32(reader["CustomerId"]),
                            NameOfPurchaser = reader["NameOfPurchaser"].ToString() ?? string.Empty,
                            Status = reader["Status"].ToString() ?? string.Empty,
                            OrderDate = Convert.ToDateTime(reader["OrderDate"]),
                            Total = Convert.ToDecimal(reader["Total"]),
                            PromoCodeId = reader["PromoCodeId"] != DBNull.Value ? Convert.ToInt32(reader["PromoCodeId"]) : null
                        });
                    }
                }
            }

            return orders;
        }

        // Create a new order with individual order items
        public void CreateOrder(
            int customerId,
            string customerName,
            List<(string productName, decimal price, int quantity)> items,
            string promoCode = "")
        {
            if (items == null || items.Count == 0)
                throw new ArgumentException("Order must contain at least one item.");

            using (var conn = Database.Connection.Database.GetConnection())
            {
                conn.Open();
                using var transaction = conn.BeginTransaction();

                try
                {
                    decimal total = items.Sum(i => i.price * i.quantity);

                    // Insert main order
                    string insertOrder = @"
                        INSERT INTO Orders 
                        (Name, NameOfPurchaser, Status, OrderDate, Total, CustomerId)
                        VALUES 
                        (@Name, @PurchaserName, @Status, @Date, @Total, @CustomerId);
                        SELECT SCOPE_IDENTITY();";

                    int orderId;
                    using (var cmd = new SqlCommand(insertOrder, conn, transaction))
                    {
                        cmd.Parameters.AddWithValue("@Name", "Order-" + DateTime.Now.Ticks);
                        cmd.Parameters.AddWithValue("@PurchaserName", customerName);
                        cmd.Parameters.AddWithValue("@Status", "Pending");
                        cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                        cmd.Parameters.AddWithValue("@Total", total);
                        cmd.Parameters.AddWithValue("@CustomerId", customerId);

                        orderId = Convert.ToInt32(cmd.ExecuteScalar());
                    }

                    // Insert individual order items
                    string insertItem = @"
                        INSERT INTO OrderItems (OrderId, ProductName, Price, Quantity)
                        VALUES (@OrderId, @ProductName, @Price, @Quantity)";

                    foreach (var item in items)
                    {
                        using var itemCmd = new SqlCommand(insertItem, conn, transaction);
                        itemCmd.Parameters.AddWithValue("@OrderId", orderId);
                        itemCmd.Parameters.AddWithValue("@ProductName", item.productName);
                        itemCmd.Parameters.AddWithValue("@Price", item.price);
                        itemCmd.Parameters.AddWithValue("@Quantity", item.quantity);
                        itemCmd.ExecuteNonQuery();
                    }

                    // Apply promo if provided
                    if (!string.IsNullOrWhiteSpace(promoCode))
                        ApplyPromoCode(orderId, promoCode, conn, transaction);

                    transaction.Commit();
                }
                catch
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public int CreateCustomer(string name, string email)
        {
            using var conn = Database.Connection.Database.GetConnection();
            conn.Open();
            string sql = "INSERT INTO Customers (CustomerName, Email) OUTPUT INSERTED.Id VALUES (@Name, @Email)";
            using var cmd = new SqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Email", string.IsNullOrWhiteSpace(email) ? DBNull.Value : email);
            return (int)cmd.ExecuteScalar();
        }

        // Apply promo code
        private void ApplyPromoCode(int orderId, string promoCode, SqlConnection conn, SqlTransaction transaction)
        {
            string query = "SELECT Id, DiscountPercent FROM PromoCodes WHERE Code = @Code AND IsActive = 1";

            using (var cmd = new SqlCommand(query, conn, transaction))
            {
                cmd.Parameters.AddWithValue("@Code", promoCode);

                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int promoId = Convert.ToInt32(reader["Id"]);
                        decimal discount = Convert.ToDecimal(reader["DiscountPercent"]);

                        reader.Close();

                        string updateOrder = @"
                            UPDATE Orders
                            SET PromoCodeId = @PromoId,
                                Total = Total - (Total * @Discount / 100)
                            WHERE Id = @OrderId";

                        using (var updateCmd = new SqlCommand(updateOrder, conn, transaction))
                        {
                            updateCmd.Parameters.AddWithValue("@PromoId", promoId);
                            updateCmd.Parameters.AddWithValue("@Discount", discount);
                            updateCmd.Parameters.AddWithValue("@OrderId", orderId);
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }
    }
}