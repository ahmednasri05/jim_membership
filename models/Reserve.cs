using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace jim_membership.models
{
    public class Reserve
    {    public int memberID { get; set; }
        public int transactionID { get; set; }
        public int sessionNo { get; set; }

        // Create
        public void Create()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = @"INSERT INTO Reserves (memberID, transactionID, sessionNo)
                               VALUES (@memberID, @transactionID, @sessionNo)";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating reserve: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Read all
        public static List<Reserve> GetAll()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                  string sql = "SELECT * FROM Reserves";
                return ProgramSession.Instance.dbConnection.Query<Reserve>(sql).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching reserve by ID: {ex.Message}");
                return null;
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Delete
        public static void Delete(int memberId, int transactionId, int sessionNo)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
               string sql = "DELETE FROM Reserves WHERE memberID = @memberID AND transactionID = @transactionID AND sessionNo = @sessionNo";
                ProgramSession.Instance.dbConnection.Execute(sql, new {  memberID = memberId, transactionID = transactionId, sessionNo = sessionNo  });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching all reserves: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        public static bool ReserveSession(int memberId, int sessionNo)
        {
            try
            {
                  // Check the number of private sessions available for the member
                string checkSql = "SELECT private_sessions_used FROM Subscribes WHERE memberID = @memberID";
                int privateSessionsUsed = ProgramSession.Instance.dbConnection.QueryFirstOrDefault<int>(checkSql, new { memberID = memberId });

                if (privateSessionsUsed <= 1)
                {
                    // Not enough private sessions available
                    return false;
                }

                // Get the transactionID from the Payments table
                string transactionSql = "SELECT TOP 1 transactionID FROM Payments WHERE memberID = @memberID ORDER BY Start_date DESC";
                int transactionId = ProgramSession.Instance.dbConnection.QueryFirstOrDefault<int>(transactionSql, new { memberID = memberId });

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
                ProgramSession.Instance.dbConnection.Execute(updateSql, new { memberID = memberId });

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating reserve: {ex.Message}");
                return false;
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }
    }
}