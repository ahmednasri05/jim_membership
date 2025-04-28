using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
namespace jim_membership.models

{
    public class Payment
    {
        public int TransactionID { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }

        private static readonly string _connectionString = "your_connection_string_here";

        // Create
        public void Create()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"INSERT INTO Payments (TransactionID, Date, Amount)
                               VALUES (@TransactionID, @Date, @Amount)";
                connection.Execute(sql, this);
            }
        }

        // Read by ID
        public static Payment GetById(int transactionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Payments WHERE TransactionID = @TransactionID";
                return connection.QueryFirstOrDefault<Payment>(sql, new { TransactionID = transactionId });
            }
        }

        // Read all
        public static List<Payment> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Payments";
                return connection.Query<Payment>(sql).ToList();
            }
        }

        // Update
        public void Update()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"UPDATE Payments 
                               SET Date = @Date, Amount = @Amount 
                               WHERE TransactionID = @TransactionID";
                connection.Execute(sql, this);
            }
        }

        // Delete
        public static void Delete(int transactionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM Payments WHERE TransactionID = @TransactionID";
                connection.Execute(sql, new { TransactionID = transactionId });
            }
        }
    }
}
