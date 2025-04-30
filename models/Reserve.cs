using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;

namespace jim_membership.models
{
    public class Reserve
    {
        public int memberID { get; set; }
        public int transactionID { get; set; }
        public int sessionNo { get; set; }

        private static readonly string _connectionString = "Server=localhost;Database=JimMemberShip;Trusted_Connection=True;";

        // Create
        public void Create()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"INSERT INTO Reserves (memberID, transactionID, sessionNo)
                               VALUES (@memberID, @transactionID, @sessionNo)";
                connection.Execute(sql, this);
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

        // Delete
        public static void Delete(int memberId, int transactionId, int sessionNo)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM Reserves WHERE memberID = @memberID AND transactionID = @transactionID AND sessionNo = @sessionNo";
                connection.Execute(sql, new { memberID = memberId, transactionID = transactionId, sessionNo = sessionNo });
            }
        }

        public static bool ReserveSession(int memberId, int sessionNo)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                // Check the number of private sessions available for the member
                string checkSql = "SELECT private_sessions_used FROM Subscribes WHERE memberID = @memberID";
                int privateSessionsUsed = connection.QueryFirstOrDefault<int>(checkSql, new { memberID = memberId });

                if (privateSessionsUsed <= 1)
                {
                    // Not enough private sessions available
                    return false;
                }

                // Get the transactionID from the Payments table
                string transactionSql = "SELECT TOP 1 transactionID FROM Payments WHERE memberID = @memberID ORDER BY Start_date DESC";
                int transactionId = connection.QueryFirstOrDefault<int>(transactionSql, new { memberID = memberId });

                if (transactionId == 0)
                {
                    // No valid transaction found
                    return false;
                }

                // Reserve the session
                var reserve = new Reserve
                {
                    memberID = memberId,
                    transactionID = transactionId,
                    sessionNo = sessionNo
                };

                reserve.Create();

                // Update the private sessions count
                string updateSql = "UPDATE Subscribes SET private_sessions_used = private_sessions_used - 1 WHERE memberID = @memberID";
                connection.Execute(updateSql, new { memberID = memberId });

                return true;
            }
        }
    }
}