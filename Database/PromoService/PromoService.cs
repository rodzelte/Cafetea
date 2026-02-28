using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;

namespace Cafetea.Database
{
    public static class PromoService
    {
        // Model class for promo
        public class PromoModel
        {
            public int Id { get; set; }
            public string? Code { get; set; }
            public string? Description { get; set; }
            public decimal DiscountPercent { get; set; }
            public bool IsActive { get; set; }
        }

        // Add a new promo
        public static bool AddPromo(string code, string description, decimal discountPercent)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                // Check if code already exists
                string checkQuery = "SELECT COUNT(*) FROM PromoCodes WHERE Code=@code";
                using (var checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@code", code);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0) return false;
                }

                // Insert promo
                string insertQuery = @"
                    INSERT INTO PromoCodes (Code, Description, DiscountPercent, IsActive)
                    VALUES (@code, @description, @discountPercent, 1)";
                using (var cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@code", code);
                    cmd.Parameters.AddWithValue("@description", description);
                    cmd.Parameters.AddWithValue("@discountPercent", discountPercent);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
        }

        // Get all promos
        public static List<PromoModel> GetAllPromos()
        {
            var list = new List<PromoModel>();

            using (var conn = Database.GetConnection())
            {
                conn.Open();
                string query = "SELECT Id, Code, Description, DiscountPercent, IsActive FROM PromoCodes";

                using (var cmd = new SqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new PromoModel
                        {
                            Id = (int)reader["Id"],
                            Code = reader["Code"].ToString(),
                            Description = reader["Description"].ToString(),
                            DiscountPercent = (decimal)reader["DiscountPercent"],
                            IsActive = (bool)reader["IsActive"]
                        });
                    }
                }
            }

            return list;
        }

        // Delete a promo by Id
        public static bool DeletePromo(int id)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                // Soft delete: set IsActive = 0
                string query = "UPDATE PromoCodes SET IsActive=0 WHERE Id=@id";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    int rows = cmd.ExecuteNonQuery();
                    return rows > 0;
                }
            }
        }

        // Optional: Get a promo by code
        public static PromoModel? GetPromoByCode(string code)
        {
            using (var conn = Database.GetConnection())
            {
                conn.Open();

                string query = "SELECT TOP 1 Id, Code, Description, DiscountPercent, IsActive FROM PromoCodes WHERE Code=@code";
                using (var cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@code", code);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new PromoModel
                            {
                                Id = (int)reader["Id"],
                                Code = reader["Code"].ToString(),
                                Description = reader["Description"].ToString(),
                                DiscountPercent = (decimal)reader["DiscountPercent"],
                                IsActive = (bool)reader["IsActive"]
                            };
                        }
                    }
                }
            }

            return null;
        }
    }
}