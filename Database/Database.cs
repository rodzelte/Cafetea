using System.Configuration;
using System.Data.SqlClient;

namespace Cafetea.Database
{
    public static class Database
    {
        private static string connectionString =
            ConfigurationManager.ConnectionStrings["CafeteaDB"].ConnectionString;

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
