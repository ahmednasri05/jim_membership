using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
namespace jim_membership.models
{
    public class Subscribe
    {
        public int MemberID { get; set; }
        public int SubscriptionID { get; set; }
        public int TransactionID { get; set; }
        public int SessionUsed { get; set; }
        public int PrivateSessionUsed { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        private static readonly string _connectionString = "your_connection_string_here";

        // Create
        public void Create()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"INSERT INTO Subscribes (MemberID, SubscriptionID, TransactionID, 
                                                       Session_Used, private_session_used, 
                                                       Start_date, End_date)
                               VALUES (@MemberID, @SubscriptionID, @TransactionID, 
                                       @SessionUsed, @PrivateSessionUsed, 
                                       @StartDate, @EndDate)";
                connection.Execute(sql, this);
            }
        }

        // Read by ID
        public static Subscribe GetById(int memberId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Subscribes WHERE MemberID = @MemberID";
                return connection.QueryFirstOrDefault<Subscribe>(sql, new { MemberID = memberId });
            }
        }

        // Read all
        public static List<Subscribe> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Subscribes";
                return connection.Query<Subscribe>(sql).ToList();
            }
        }

        // Update
        public void Update()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"UPDATE Subscribes 
                               SET SubscriptionID = @SubscriptionID,
                                   TransactionID = @TransactionID,
                                   Session_Used = @SessionUsed,
                                   private_session_used = @PrivateSessionUsed,
                                   Start_date = @StartDate,
                                   End_date = @EndDate
                               WHERE MemberID = @MemberID";
                connection.Execute(sql, this);
            }
        }

        // Delete
        public static void Delete(int memberId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM Subscribes WHERE MemberID = @MemberID";
                connection.Execute(sql, new { MemberID = memberId });
            }
        }
    }
}
