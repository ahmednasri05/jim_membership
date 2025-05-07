using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
namespace jim_membership.models
{
    public class Log
    {
        public DateTime CheckInTime { get; set; }
        public string? MemberID { get; set; }
        public string? BranchNo { get; set; }
        public DateTime checkoutTime { get; set; }

        public void Create()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = @"
                INSERT INTO Logs (CheckInTime, MemberID, BranchNo, checkoutTime)
                VALUES (@CheckInTime, @MemberID, @BranchNo, @CheckoutTime)";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
                ProgramSession.Instance.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                throw;
            }
        }

        public static Log? GetLog(DateTime checkInTime, string memberID, string branchNo)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = @"
                SELECT * FROM Logs
                WHERE CheckInTime = @CheckInTime AND MemberID = @MemberID AND BranchNo = @BranchNo";
                var log = ProgramSession.Instance.dbConnection.QuerySingleOrDefault<Log>(sql, new { CheckInTime = checkInTime, MemberID = memberID, BranchNo = branchNo });
                ProgramSession.Instance.CloseConnection();
                return log;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                throw;
            }
        }

        public static void Update(DateTime checkInTime, DateTime checkoutTime, string memberID, string branchNo)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = @"
                UPDATE Logs
                SET 
                CheckInTime = @NewCheckInTime,
                CheckOutTime = @NewCheckOutTime,
                MemberID = @NewMemberID,
                BranchNo = @NewBranchNo
                WHERE 
                CheckInTime = @CheckInTime AND 
                MemberID = @MemberID AND 
                BranchNo = @BranchNo";
                ProgramSession.Instance.dbConnection.Execute(sql, new { CheckoutTime = checkoutTime, CheckInTime = checkInTime, MemberID = memberID, BranchNo = branchNo });
                ProgramSession.Instance.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                throw;
            }
        }

        public static void Delete(DateTime checkInTime, string memberID, string branchNo)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = @"
                DELETE FROM Logs
                WHERE CheckInTime = @CheckInTime AND MemberID = @MemberID AND BranchNo = @BranchNo";
                ProgramSession.Instance.dbConnection.Execute(sql, new { CheckInTime = checkInTime, MemberID = memberID, BranchNo = branchNo });
                ProgramSession.Instance.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                throw;
            }
        }

        public static List<Log> GetAllLogs()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = @"SELECT * FROM Logs";
                var logs = ProgramSession.Instance.dbConnection.Query<Log>(sql).ToList();
                ProgramSession.Instance.CloseConnection();
                return logs;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                throw;
            }
        }

        public static List<Log> GetSortedLogs(string? sortBy)
        {
            try
            {
                string query = "SELECT * FROM Logs";
                if (!string.IsNullOrEmpty(sortBy))
                {
                    // Validate sortBy to prevent SQL injection
                    if (sortBy == "CheckInTime" || sortBy == "checkoutTime")
                    {
                        query += $" ORDER BY {sortBy}";
                    }
                    else
                    {
                        throw new ArgumentException("Invalid sort column.");
                    }
                }

                ProgramSession.Instance.OpenConnection();
                var logs = ProgramSession.Instance.dbConnection.Query<Log>(query).ToList();
                ProgramSession.Instance.CloseConnection();
                return logs;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error fetching sorted logs: {ex.Message}");
            }
        }
    }
}
