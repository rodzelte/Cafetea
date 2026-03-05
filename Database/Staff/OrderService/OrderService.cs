using Cafetea.Database.Client.OrderService;
using Cafetea.Database.Connection;
using Microsoft.Data.SqlClient; // Make sure this matches your Database.cs
using System;
using System.Collections.Generic;

namespace Cafetea.Database.Staff.OrderService
{
    internal class OrderService
    {

  
        public class Order
        {
            public int Id { get; set; }
            public string Name { get; set; } = string.Empty;
            public string NameOfPurchaser { get; set; } = string.Empty;
            public string NameOfOrderPurchase { get; set; } = string.Empty;
            public string Status { get; set; } = string.Empty;
            public DateTime OrderDate { get; set; }
            public decimal Total { get; set; }
            public int? PromoCodeId { get; set; }
        }
    

    public List<Order> GetOrders()
        {
            List<Order> orders = new List<Order>();

            using (var conn = Database.Connection.Database.GetConnection())
            {
                conn.Open();

                string query = @"
                    SELECT Id, Name, NameOfPurchaser, NameOfOrderPurchase, Status, OrderDate, Total, PromoCodeId
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
                            NameOfPurchaser = reader["NameOfPurchaser"].ToString() ?? string.Empty,
                            NameOfOrderPurchase = reader["NameOfOrderPurchase"].ToString() ?? string.Empty,
                            Status = reader["Status"].ToString() ?? string.Empty,
                            OrderDate = Convert.ToDateTime(reader["OrderDate"]),
                            Total = Convert.ToDecimal(reader["Total"]),
                            PromoCodeId = reader["PromoCodeId"] != DBNull.Value
                                         ? Convert.ToInt32(reader["PromoCodeId"])
                                         : null
                        });
                    }
                }
            }

            return orders;
        }

        public void CreateOrder(List<(string productName, decimal price, int quantity)> items, string promoCode = "")
        {
            if (items == null || items.Count == 0)
                throw new ArgumentException("Order must contain at least one item.");

            using (var conn = Database.Connection.Database.GetConnection())
            {
                conn.Open();

                // Step 1: Build comma-separated product list
                string orderItems = string.Join(", ", items.ConvertAll(i => i.productName));

                // Step 2: Calculate total price
                decimal total = 0;
                foreach (var i in items)
                    total += i.price * i.quantity;

                // Step 3: Insert order into Orders table
                string insertOrder = @"
                    INSERT INTO Orders (Name, NameOfPurchaser, NameOfOrderPurchase, Status, OrderDate, Total)
                    VALUES (@Name, @Purchaser, @Items, @Status, @Date, @Total);
                    SELECT SCOPE_IDENTITY();";

                using (var cmd = new SqlCommand(insertOrder, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", "Order-" + DateTime.Now.Ticks); // simple order ID
                    cmd.Parameters.AddWithValue("@Purchaser", "Staff"); // Replace with actual customer if needed
                    cmd.Parameters.AddWithValue("@Items", orderItems);
                    cmd.Parameters.AddWithValue("@Status", "Pending");
                    cmd.Parameters.AddWithValue("@Date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@Total", total);

                    // Execute the insert and get the new Order ID
                    int orderId = Convert.ToInt32(cmd.ExecuteScalar());

                    // Optional: Apply promo code logic here
                    if (!string.IsNullOrWhiteSpace(promoCode))
                    {
                        ApplyPromoCode(orderId, promoCode, conn);
                    }
                }
            }
        }

     
        private void ApplyPromoCode(int orderId, string promoCode, SqlConnection conn)
        {
            // Check if promo code exists
            string query = "SELECT Id, DiscountPercentage FROM PromoCodes WHERE Code = @Code";
            using (var cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Code", promoCode);
                using (var reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int promoId = Convert.ToInt32(reader["Id"]);
                        decimal discount = Convert.ToDecimal(reader["DiscountPercentage"]);

                        reader.Close(); // Close reader before executing update

                        // Apply discount to order
                        string updateOrder = @"
                            UPDATE Orders
                            SET PromoCodeId = @PromoId,
                                Total = Total - (Total * @Discount / 100)
                            WHERE Id = @OrderId";
                        using (var updateCmd = new SqlCommand(updateOrder, conn))
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