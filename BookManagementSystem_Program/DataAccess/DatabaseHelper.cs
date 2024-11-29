using System.Data.SqlClient;

namespace BookManagementSystem.DataAccess
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString =
            "Data Source=localhost;Initial Catalog=BookDB;Integrated Security=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
