using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
namespace jim_membership.models
{
    public class Session
    {
        public int SessionID { get; set; }
        public int TrainerID { get; set; }
        public int BranchNo { get; set; }
        public string Type { get; set; }
        public int MaxNumber { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Duration { get; set; }
        public string Description { get; set; }

        private static readonly string _connectionString = "your_connection_string_here";

        // Create
        public void Create()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"INSERT INTO Sessions (SessionID, TrainerID, BranchNo, Type, MaxNumber, Date, Duration, Description)
                               VALUES (@SessionID, @TrainerID, @BranchNo, @Type, @MaxNumber, @Date, @Duration, @Description)";
                connection.Execute(sql, this);
            }
        }

        // Read by ID
        public static Session GetById(int sessionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Sessions WHERE SessionID = @SessionID";
                return connection.QueryFirstOrDefault<Session>(sql, new { SessionID = sessionId });
            }
        }

        // Read all
        public static List<Session> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Sessions";
                return connection.Query<Session>(sql).ToList();
            }
        }

        // Update
        public void Update()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"UPDATE Sessions 
                               SET TrainerID = @TrainerID, BranchNo = @BranchNo, Type = @Type, 
                                   MaxNumber = @MaxNumber, Date = @Date, Duration = @Duration, Description = @Description
                               WHERE SessionID = @SessionID";
                connection.Execute(sql, this);
            }
        }

        // Delete
        public static void Delete(int sessionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM Sessions WHERE SessionID = @SessionID";
                connection.Execute(sql, new { SessionID = sessionId });
            }
        }
    }
}
