using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace jim_membership.models
{
    public class Session
    {
        public string sessionNo { get; set; }
        public string trainerID { get; set; }
        public string BranchNo { get; set; }
        public string Type { get; set; }
        public int maxNumber { get; set; }
        public DateTime date { get; set; }
        public TimeSpan duration { get; set; }
        public TimeSpan Time { get; set; }

        public string description { get; set; }

        // Create
        public void Create()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = @"INSERT INTO Sessions (SessionID, TrainerID, BranchNo, Type, MaxNumber, Date, Duration, Description)
                               VALUES (@SessionID, @TrainerID, @BranchNo, @Type, @MaxNumber, @Date, @Duration, @Description)";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating session: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Read by ID
        public static Session GetById(int sessionId)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Sessions WHERE SessionID = @SessionID";
                return ProgramSession.Instance.dbConnection.QueryFirstOrDefault<Session>(sql, new { SessionID = sessionId });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching session by ID: {ex.Message}");
                return null;
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Read all
        public static List<Session> GetAll()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Sessions";
                return ProgramSession.Instance.dbConnection.Query<Session>(sql).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching all sessions: {ex.Message}");
                return new List<Session>();
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Update
        public void Update()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = @"UPDATE Sessions 
                               SET TrainerID = @TrainerID, BranchNo = @BranchNo, Type = @Type, 
                                   MaxNumber = @MaxNumber, Date = @Date, Duration = @Duration, Description = @Description
                               WHERE SessionID = @SessionID";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating session: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Delete
        public static void Delete(int sessionId)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "DELETE FROM Sessions WHERE SessionID = @SessionID";
                ProgramSession.Instance.dbConnection.Execute(sql, new { SessionID = sessionId });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting session: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }
    }
}
