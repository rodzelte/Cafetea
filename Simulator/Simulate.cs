using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using Cafetea.Database.Connection;

namespace Cafetea.Simulator
{
    internal class Simulate
    {
        private static Random random = new Random();

        // Sample data
        private static string[] firstNames = { "John", "Alice", "Bob", "Mary", "Steve", "Emma", "Michael", "Sophia" };
        private static string[] lastNames = { "Doe", "Smith", "Johnson", "Williams", "Brown" };
        private static string[] products = { "Cappuccino", "Blueberry Muffin", "Latte", "Matcha Latte", "Sandwich", "Cake", "Juice" };
        private static string[] feedbackComments = {
            "Excellent service!", "Loved it!", "Could be better.", "Very tasty!", "Not satisfied.", "Amazing experience!"
        };

        public static void RunTimeSimulation(int numCustomers = 5, int daysBack = 14)
        {
            using (SqlConnection conn = Database.Connection.Database.GetConnection())
            {
                conn.Open();

                for (int i = 0; i < numCustomers; i++)
                {
                    var customer = GenerateCustomer();
                    int customerId = InsertCustomer(conn, customer);
                    Console.WriteLine($"Customer: {customer.Name}, Id: {customerId}");

                    int visits = random.Next(1, 6); // 1-5 visits
                    for (int v = 0; v < visits; v++)
                    {
                        // Generate random order date with hours, minutes, and seconds
                        int daysAgo = random.Next(0, daysBack);
                        int hour = random.Next(8, 22);       // business hours
                        int minute = random.Next(0, 60);
                        int second = random.Next(0, 60);

                        DateTime orderDate = DateTime.Now
                            .AddDays(-daysAgo)
                            .Date
                            .AddHours(hour)
                            .AddMinutes(minute)
                            .AddSeconds(second);

                        var order = GenerateOrder(customer);

                        int promoId = GetRandomActivePromoId(conn);
                        if (promoId > 0) order.Total *= (1 - GetPromoDiscount(conn, promoId) / 100);

                        int orderId = InsertOrder(conn, order, customerId, promoId, orderDate);
                        Console.WriteLine($"Order: {order.NameOfOrderPurchase}, Id: {orderId}, Total: {order.Total:C}, Date: {orderDate}");

                        foreach (var item in order.OrderItems)
                            InsertOrderItem(conn, orderId, item);

                        if (order.Status == "Completed")
                        {
                            var feedback = GenerateFeedback(customer);
                            InsertFeedback(conn, feedback, customerId, orderDate);
                            Console.WriteLine($"Feedback: {feedback.StarRating} stars - {feedback.FeedbackDescription}");
                        }

                        Console.WriteLine("---------------------------------------------------\n");
                    }
                }
            }
        }

        #region Generate Data
        private static Customer GenerateCustomer()
        {
            string first = firstNames[random.Next(firstNames.Length)];
            string last = lastNames[random.Next(lastNames.Length)];
            string email = $"{first.ToLower()}.{last.ToLower()}@example.com";
            return new Customer
            {
                Name = $"{first} {last}",
                Email = email,
                Contact = $"09{random.Next(100000000, 999999999)}"
            };
        }

        private static Order GenerateOrder(Customer customer)
        {
            int numItems = random.Next(1, 4);
            List<OrderItem> items = new List<OrderItem>();
            decimal total = 0;

            for (int i = 0; i < numItems; i++)
            {
                string product = products[random.Next(products.Length)];
                decimal price = random.Next(50, 201);
                int qty = random.Next(1, 4);
                items.Add(new OrderItem { ProductName = product, Price = price, Quantity = qty });
                total += price * qty;
            }

            string[] statuses = { "Pending", "Completed", "Cancelled" };
            string status = statuses[random.Next(statuses.Length)];

            return new Order
            {
                Name = $"ORD-{random.Next(1000, 9999)}",
                NameOfPurchaser = customer.Name,
                NameOfOrderPurchase = string.Join(", ", items.ConvertAll(i => i.ProductName)),
                Status = status,
                Total = total,
                OrderItems = items
            };
        }

        private static Feedback GenerateFeedback(Customer customer)
        {
            int stars = random.Next(1, 6);
            string comment = feedbackComments[random.Next(feedbackComments.Length)];
            return new Feedback
            {
                CustomerName = customer.Name,
                StarRating = stars,
                FeedbackDescription = comment,
                Status = "Completed"
            };
        }
        #endregion

        #region Database Operations
        private static int InsertCustomer(SqlConnection conn, Customer customer)
        {
            string sql = @"INSERT INTO Customers (CustomerName, Contact, Email, FavoriteOrder, VisitsCount, LastVisitDate)
                           VALUES (@Name, @Contact, @Email, @FavoriteOrder, @VisitsCount, GETDATE());
                           SELECT SCOPE_IDENTITY();";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Name", customer.Name);
                cmd.Parameters.AddWithValue("@Contact", customer.Contact);
                cmd.Parameters.AddWithValue("@Email", customer.Email);
                cmd.Parameters.AddWithValue("@FavoriteOrder", "Cappuccino");
                cmd.Parameters.AddWithValue("@VisitsCount", random.Next(1, 10));
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private static int InsertOrder(SqlConnection conn, Order order, int customerId, int promoId, DateTime orderDate)
        {
            string sql = @"INSERT INTO Orders (Name, NameOfPurchaser, NameOfOrderPurchase, Status, OrderDate, Total, CustomerId, PromoCodeId)
                           VALUES (@Name, @Purchaser, @Items, @Status, @OrderDate, @Total, @CustomerId, @PromoCodeId);
                           SELECT SCOPE_IDENTITY();";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Name", order.Name);
                cmd.Parameters.AddWithValue("@Purchaser", order.NameOfPurchaser);
                cmd.Parameters.AddWithValue("@Items", order.NameOfOrderPurchase);
                cmd.Parameters.AddWithValue("@Status", order.Status);
                cmd.Parameters.AddWithValue("@OrderDate", orderDate);
                cmd.Parameters.AddWithValue("@Total", order.Total);
                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                cmd.Parameters.AddWithValue("@PromoCodeId", promoId > 0 ? promoId : (object)DBNull.Value);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        private static void InsertOrderItem(SqlConnection conn, int orderId, OrderItem item)
        {
            string sql = @"INSERT INTO OrderItems (OrderId, ProductName, Price, Quantity)
                           VALUES (@OrderId, @ProductName, @Price, @Quantity);";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@OrderId", orderId);
                cmd.Parameters.AddWithValue("@ProductName", item.ProductName);
                cmd.Parameters.AddWithValue("@Price", item.Price);
                cmd.Parameters.AddWithValue("@Quantity", item.Quantity);
                cmd.ExecuteNonQuery();
            }
        }

        private static void InsertFeedback(SqlConnection conn, Feedback feedback, int customerId, DateTime feedbackDate)
        {
            string sql = @"INSERT INTO Feedbacks (CustomerId, FeedbackDate, Status, StarRating, FeedbackDescription)
                           VALUES (@CustomerId, @FeedbackDate, @Status, @Stars, @Comment);";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@CustomerId", customerId);
                cmd.Parameters.AddWithValue("@FeedbackDate", feedbackDate);
                cmd.Parameters.AddWithValue("@Status", feedback.Status);
                cmd.Parameters.AddWithValue("@Stars", feedback.StarRating);
                cmd.Parameters.AddWithValue("@Comment", feedback.FeedbackDescription);
                cmd.ExecuteNonQuery();
            }
        }

        private static int GetRandomActivePromoId(SqlConnection conn)
        {
            string sql = "SELECT TOP 1 Id FROM PromoCodes WHERE IsActive = 1 ORDER BY NEWID();";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToInt32(result) : 0;
            }
        }

        private static decimal GetPromoDiscount(SqlConnection conn, int promoId)
        {
            string sql = "SELECT DiscountPercent FROM PromoCodes WHERE Id = @Id;";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Id", promoId);
                object result = cmd.ExecuteScalar();
                return result != null ? Convert.ToDecimal(result) : 0;
            }
        }
        #endregion

        #region Classes
      
        internal class Customer
        {
            public required string Name { get; set; }
            public required string Email { get; set; }
            public required string Contact { get; set; }
        }

        internal class Order
        {
            public required string Name { get; set; }
            public required string NameOfPurchaser { get; set; }
            public required string NameOfOrderPurchase { get; set; }
            public required string Status { get; set; }
            public required decimal Total { get; set; }
            public required List<OrderItem> OrderItems { get; set; }
        }

        internal class OrderItem
        {
            public required string ProductName { get; set; }
            public required decimal Price { get; set; }
            public required int Quantity { get; set; }
        }

        internal class Feedback
        {
            public required string CustomerName { get; set; }
            public required string Status { get; set; }
            public required int StarRating { get; set; }
            public required string FeedbackDescription { get; set; }
        }
      
        #endregion
    }
}