using System;
using System.Data.SqlClient;

namespace jim_membership
{
    public class ProgramSession
    {
        // Singleton instance
        private static ProgramSession _instance;

        // Public property to access the Singleton instance
        public static ProgramSession Instance => _instance ??= new ProgramSession();

        // Properties
        public int UserId { get; private set; }
        public SqlConnection dbConnection { get; private set; }

        // Private constructor to prevent external instantiation
        private ProgramSession()
        {
            DotENV.Load();

            // Initialize the database connection
            string connectionString = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING");
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("Database connection string is not set in the .env file.");
            }

            dbConnection = new SqlConnection(connectionString);
        }

        // Method to set the UserId (optional, if needed)
        public void SetUserId(int userId)
        {
            UserId = userId;
        }

        // Method to open the database connection
        public void OpenConnection()
        {
            try
            {
                if (dbConnection.State == System.Data.ConnectionState.Closed)
                {
                    dbConnection.Open();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error opening database connection: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }

        // Method to close the database connection
        public void CloseConnection()
        {
            try
            {
                if (dbConnection.State == System.Data.ConnectionState.Open)
                {
                    dbConnection.Close();
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error closing database connection: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }
        }

        // Dispose method to clean up resources
        public void Dispose()
        {
            try
            {
                CloseConnection();
                dbConnection.Dispose();
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"Error disposing database connection: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error during disposal: {ex.Message}");
            }
        }
    }
}
