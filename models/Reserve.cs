using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace jim_membership.models
{
    public class Reserve
    {
        public int memberID { get; set; }
        public int transactionID { get; set; }
        public int sessionNo { get; set; }

        private static readonly string _connectionString = "your_connection_string_here";

        // Create
        public void Create()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = @"INSERT INTO Reserves (ReserveID, TraineeID, CourseID, PaymentStatus)
                               VALUES (@ReserveID, @TraineeID, @CourseID, @PaymentStatus)";
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
                string sql = "SELECT * FROM Reserves WHERE ReserveID = @ReserveID";
                return ProgramSession.Instance.dbConnection.QueryFirstOrDefault<Reserve>(sql, new { ReserveID = reserveId });
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
                string sql = "SELECT * FROM Reserves";
                return ProgramSession.Instance.dbConnection.Query<Reserve>(sql).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching all reserves: {ex.Message}");
                return new List<Reserve>();
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
                ProgramSession.Instance.OpenConnection();
                string sql = @"UPDATE Reserves 
                               SET TraineeID = @TraineeID, CourseID = @CourseID, PaymentStatus = @PaymentStatus 
                               WHERE ReserveID = @ReserveID";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating reserve: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Delete
        public static void Delete(int reserveId)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "DELETE FROM Reserves WHERE ReserveID = @ReserveID";
                ProgramSession.Instance.dbConnection.Execute(sql, new { ReserveID = reserveId });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting reserve: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }
    }
}