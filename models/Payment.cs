using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace jim_membership.models
{
    public class Payment
    {
        public int TransactionID { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }

        // Create
        public void Create()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = @"INSERT INTO Payments (TransactionID, Date, Amount)
                               VALUES (@TransactionID, @Date, @Amount)";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating payment: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Read by ID
        public static Payment GetById(int transactionId)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Payments WHERE TransactionID = @TransactionID";
                return ProgramSession.Instance.dbConnection.QueryFirstOrDefault<Payment>(sql, new { TransactionID = transactionId });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching payment by ID: {ex.Message}");
                return null;
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Read all
        public static List<Payment> GetAll()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Payments";
                return ProgramSession.Instance.dbConnection.Query<Payment>(sql).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching all payments: {ex.Message}");
                return new List<Payment>();
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
                string sql = @"UPDATE Payments 
                               SET Date = @Date, Amount = @Amount 
                               WHERE TransactionID = @TransactionID";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating payment: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Delete
        public static void Delete(int transactionId)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "DELETE FROM Payments WHERE TransactionID = @TransactionID";
                ProgramSession.Instance.dbConnection.Execute(sql, new { TransactionID = transactionId });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting payment: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }
    }
}
