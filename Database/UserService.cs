using Microsoft.Data.SqlClient;

namespace Cafetea.Database
{
    public static class UserService
    {

        public static string? Login(string username, string password)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                string query = "SELECT Role FROM Users WHERE Username=@username AND Password=@password";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object? result = cmd.ExecuteScalar();

                    return result?.ToString(); // returns role or null
                }
            }
        }

        public static bool Register(string username, string password, string role)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();

                // Check if username exists
                string checkQuery = "SELECT COUNT(*) FROM Users WHERE Username=@username";
                using (SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@username", username);
                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0) return false;
                }

                // Insert new user
                string insertQuery = "INSERT INTO Users (Username, Password, Role) VALUES (@username, @password, @role)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);
                    cmd.ExecuteNonQuery();
                }

                return true;
            }
        }


    }
}