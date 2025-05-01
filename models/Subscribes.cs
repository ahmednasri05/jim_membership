using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace jim_membership.models
{
    public class Subscribe
    {
        public string MemberID { get; set; }
        public string SubscriptionID { get; set; }
        public string TransactionID { get; set; }
        public int SessionUsed { get; set; }
        public int PrivateSessionUsed { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        // Create
        public void Create()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = @"INSERT INTO Subscribes (MemberID, SubscriptionID, TransactionID, 
                                                       Session_Used, private_session_used, 
                                                       Start_date, End_date)
                               VALUES (@MemberID, @SubscriptionID, @TransactionID, 
                                       @SessionUsed, @PrivateSessionUsed, 
                                       @StartDate, @EndDate)";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating subscription: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Read by ID
        public static Subscribe GetById(int memberId)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Subscribes WHERE MemberID = @MemberID";
                return ProgramSession.Instance.dbConnection.QueryFirstOrDefault<Subscribe>(sql, new { MemberID = memberId });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching subscription by ID: {ex.Message}");
                return null;
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Read all
        public static List<Subscribe> GetAll()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Subscribes";
                return ProgramSession.Instance.dbConnection.Query<Subscribe>(sql).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching all subscriptions: {ex.Message}");
                return new List<Subscribe>();
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
                string sql = @"UPDATE Subscribes 
                               SET SubscriptionID = @SubscriptionID,
                                   TransactionID = @TransactionID,
                                   Session_Used = @SessionUsed,
                                   private_session_used = @PrivateSessionUsed,
                                   Start_date = @StartDate,
                                   End_date = @EndDate
                               WHERE MemberID = @MemberID";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating subscription: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Delete
        public static void Delete(int memberId)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "DELETE FROM Subscribes WHERE MemberID = @MemberID";
                ProgramSession.Instance.dbConnection.Execute(sql, new { MemberID = memberId });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting subscription: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }
    }
}
