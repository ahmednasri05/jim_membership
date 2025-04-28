using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
namespace jim_membership.models
{
    public class Reserve
    {
        public int ReserveID { get; set; }
        public int TraineeID { get; set; }
        public int CourseID { get; set; }
        public string PaymentStatus { get; set; }

        private static readonly string _connectionString = "your_connection_string_here";

        // Create
        public void Create()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"INSERT INTO Reserves (ReserveID, TraineeID, CourseID, PaymentStatus)
                               VALUES (@ReserveID, @TraineeID, @CourseID, @PaymentStatus)";
                connection.Execute(sql, this);
            }
        }

        // Read by ID
        public static Reserve GetById(int reserveId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Reserves WHERE ReserveID = @ReserveID";
                return connection.QueryFirstOrDefault<Reserve>(sql, new { ReserveID = reserveId });
            }
        }

        // Read all
        public static List<Reserve> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Reserves";
                return connection.Query<Reserve>(sql).ToList();
            }
        }

        // Update
        public void Update()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"UPDATE Reserves 
                               SET TraineeID = @TraineeID, CourseID = @CourseID, PaymentStatus = @PaymentStatus 
                               WHERE ReserveID = @ReserveID";
                connection.Execute(sql, this);
            }
        }

        // Delete
        public static void Delete(int reserveId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM Reserves WHERE ReserveID = @ReserveID";
                connection.Execute(sql, new { ReserveID = reserveId });
            }
        }
    }
}
