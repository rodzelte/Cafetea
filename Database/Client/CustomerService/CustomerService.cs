using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using Cafetea.Database.Connection;

namespace Cafetea.Database.Client.CustomerService
{
    public class CustomerService
    {
        public List<CustomerModel> GetAllCustomers()
        {
            List<CustomerModel> customers = new List<CustomerModel>();

            using (SqlConnection conn = Connection.Database.GetConnection())
            {
                conn.Open();
                string query = @"
            SELECT Id, CustomerName, Contact, Email, VisitsCount, LastVisitDate
            FROM Customers
            ORDER BY CustomerName";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customer = new CustomerModel
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Name = !reader.IsDBNull(reader.GetOrdinal("CustomerName"))
                                   ? Convert.ToString(reader["CustomerName"])!
                                   : string.Empty,
                            Contact = !reader.IsDBNull(reader.GetOrdinal("Contact"))
                                      ? Convert.ToString(reader["Contact"])!
                                      : string.Empty,
                            Email = !reader.IsDBNull(reader.GetOrdinal("Email"))
                                    ? Convert.ToString(reader["Email"])!
                                    : string.Empty,
                            VisitsCount = reader["VisitsCount"] != DBNull.Value ? Convert.ToInt32(reader["VisitsCount"]) : 0,
                            LastOrderDate = !reader.IsDBNull(reader.GetOrdinal("LastVisitDate"))
                                            ? (DateTime?)reader.GetDateTime(reader.GetOrdinal("LastVisitDate"))
                                            : null
                        };

                        // Get favorite order per customer (separate query)
                        customer.FavoriteOrder = GetFavoriteOrder(customer.Id);

                        customers.Add(customer);
                    }
                }
            }

            return customers;
        }
        private string GetFavoriteOrder(int customerId)
        {
            using (SqlConnection conn = Connection.Database.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT TOP 1 NameOfOrderPurchase, COUNT(*) AS OrderCount
                    FROM Orders
                    WHERE CustomerId = @CustomerId
                    GROUP BY NameOfOrderPurchase
                    ORDER BY OrderCount DESC";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customerId);

                    var result = cmd.ExecuteScalar();
                    return result != null ? result.ToString() : "-";
                }
            }
        }

        public List<CustomerModel> SearchCustomers(string keyword)
        {
            List<CustomerModel> customers = new List<CustomerModel>();

            using (SqlConnection conn = Connection.Database.GetConnection())
            {
                conn.Open();
                string query = @"
                    SELECT Id, CustomerName, Contact, Email, VisitsCount, LastVisitDate
                    FROM Customers
                    WHERE CustomerName LIKE @Keyword OR Email LIKE @Keyword";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Keyword", "%" + keyword + "%");

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customers.Add(new CustomerModel
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Name = reader.GetString(reader.GetOrdinal("CustomerName")),
                                Contact = reader.IsDBNull(reader.GetOrdinal("Contact")) ? "" : reader.GetString(reader.GetOrdinal("Contact")),
                                Email = reader.IsDBNull(reader.GetOrdinal("Email")) ? "" : reader.GetString(reader.GetOrdinal("Email")),
                                VisitsCount = reader.GetInt32(reader.GetOrdinal("VisitsCount")),
                                LastOrderDate = reader.IsDBNull(reader.GetOrdinal("LastVisitDate")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("LastVisitDate")),
                                FavoriteOrder = GetFavoriteOrder(reader.GetInt32(reader.GetOrdinal("Id")))
                            });
                        }
                    }
                }
            }

            return customers;
        }
    }

    public class CustomerModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Contact { get; set; } = "";
        public string Email { get; set; } = "";
        public int VisitsCount { get; set; }
        public DateTime? LastOrderDate { get; set; }
        public string FavoriteOrder { get; set; } = "-";
    }
}