using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Cafetea.Database
{
    public static class Database
    {
        private static readonly string connectionString;

        static Database()
        {
            try
            {
               
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(AppContext.BaseDirectory)
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                connectionString = configuration.GetConnectionString("DefaultConnection")
                    ?? throw new InvalidOperationException("Could not find 'DefaultConnection' in the JSON file.");
            }
            catch (Exception ex)
            {
             
                throw new Exception($"Database Configuration Failed: {ex.Message}", ex);
            }
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }


       



        }
    }