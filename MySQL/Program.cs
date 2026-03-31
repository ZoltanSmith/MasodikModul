using MySql.Data.MySqlClient;

namespace MySQL
{
    internal static class Program
    {
        static MySqlConnection dbConn;
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            DatabaseConnection();
            Application.Run(new Form1());
            dbConn?.Close();
        }

        static void DatabaseConnection()
        {
            string connectionString = "server=localhost;" +
                "user=zoli;" +
                "port=34567;" +
                "password=z;" +
                "database=gyakorlo_db";
            dbConn = new MySqlConnection(connectionString);
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
    }
}