using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
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
        public DateTime FreeDuration { get; set; }
        public string Description { get; set; }

        private static readonly string _connectionString = "your_connection_string_here";

        // Create
        public void Create()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"INSERT INTO Subscriptions (SubscriptionID, Name, Amount, NoOfSessions, 
                                                           INbody, NoOfPrivateSessions, FreeDuration, Description)
                               VALUES (@SubscriptionID, @Name, @Amount, @NoOfSessions, 
                                       @InBody, @NoOfPrivateSessions, @FreeDuration, @Description)";
                connection.Execute(sql, this);
            }
        }

        // Read by ID
        public static Subscription GetById(int subscriptionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Subscriptions WHERE SubscriptionID = @SubscriptionID";
                return connection.QueryFirstOrDefault<Subscription>(sql, new { SubscriptionID = subscriptionId });
            }
        }

        // Read all
        public static List<Subscription> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Subscriptions";
                return connection.Query<Subscription>(sql).ToList();
            }
        }

        // Update
        public void Update()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"UPDATE Subscriptions 
                               SET Name = @Name, Amount = @Amount, NoOfSessions = @NoOfSessions, 
                                   INbody = @InBody, NoOfPrivateSessions = @NoOfPrivateSessions,
                                   FreeDuration = @FreeDuration, Description = @Description
                               WHERE SubscriptionID = @SubscriptionID";
                connection.Execute(sql, this);
            }
        }

        // Delete
        public static void Delete(int subscriptionId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM Subscriptions WHERE SubscriptionID = @SubscriptionID";
                connection.Execute(sql, new { SubscriptionID = subscriptionId });
            }
        }
    }
}

