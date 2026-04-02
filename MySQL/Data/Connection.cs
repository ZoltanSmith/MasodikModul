using MySql.Data.MySqlClient;

namespace MySQL.Data
{
    internal static class Connection
    {
        internal static string connectionString = "server=localhost;" +
                "user=zoli;" +
                "port=34567;" +
                "password=z;" +
                "database=gyakorlo_db";
        
        static MySqlConnection dbConn = new MySqlConnection(connectionString);

        internal static void Connect()
        {
            try
            {
                dbConn.Open();
                MessageBox.Show("Connection successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Connection failed: {ex.Message}");
            }
        }

        internal static void Disconnect()
        {
            if (dbConn.State == System.Data.ConnectionState.Open)
            {
                dbConn.Close();
                //MessageBox.Show("Connection closed.");
            }
        }
    }
}
