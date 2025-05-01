using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace jim_membership.models
{
    public class Subscription
    {
        public int SubscriptionID { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public int NoOfSessions { get; set; }
        public int InBody { get; set; }
        public int NoOfPrivateSessions { get; set; }
        public int FreezeDuration { get; set; }
        public string Description { get; set; }

        private static readonly string _connectionString = "your_connection_string_here";

        // Create
        public void Create()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = @"INSERT INTO Subscriptions (SubscriptionID, Name, Amount, NoOfSessions, 
                                                           INbody, NoOfPrivateSessions, FreezeDuration, Description)
                               VALUES (@SubscriptionID, @Name, @Amount, @NoOfSessions, 
                                       @InBody, @NoOfPrivateSessions, @FreeDuration, @Description)";
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
        public static Subscription GetById(int subscriptionId)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Subscriptions WHERE SubscriptionID = @SubscriptionID";
                return ProgramSession.Instance.dbConnection.QueryFirstOrDefault<Subscription>(sql, new { SubscriptionID = subscriptionId });
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
        public static List<Subscription> GetAll()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Subscriptions";
                return ProgramSession.Instance.dbConnection.Query<Subscription>(sql).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching all subscriptions: {ex.Message}");
                return new List<Subscription>();
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
                string sql = @"UPDATE Subscriptions 
                               SET Name = @Name, Amount = @Amount, NoOfSessions = @NoOfSessions, 
                                   INbody = @InBody, NoOfPrivateSessions = @NoOfPrivateSessions,
                                   FreezeDuration = @FreezeDuration, Description = @Description
                               WHERE SubscriptionID = @SubscriptionID";
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
        public static void Delete(int subscriptionId)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "DELETE FROM Subscriptions WHERE SubscriptionID = @SubscriptionID";
                ProgramSession.Instance.dbConnection.Execute(sql, new { SubscriptionID = subscriptionId });
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
