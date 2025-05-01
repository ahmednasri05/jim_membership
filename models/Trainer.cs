using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;

namespace jim_membership.models
{
    public class Trainer
    {
        public string NationalID { get; set; }
        public int Salary { get; set; }
        public DateTime StartDate { get; set; }
        public string ContractType { get; set; }
        public DateTime EndDate { get; set; }

        private static readonly string _connectionString = "your_connection_string_here";

        public void Create()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = @"INSERT INTO Trainers (nationalID, Salary, startDate, ContractType, endDate)
                VALUES (@NationalID, @Salary, @StartDate, @ContractType, @EndDate)";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating trainer: {ex.Message}");
                throw;
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        public static Trainer GetById(string nationalID)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Trainers WHERE nationalID = @NationalID";
                return ProgramSession.Instance.dbConnection.QueryFirstOrDefault<Trainer>(sql, new { NationalID = nationalID });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching trainer by ID: {ex.Message}");
                return null;
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        public static List<Trainer> GetAll()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Trainers";
                return ProgramSession.Instance.dbConnection.Query<Trainer>(sql).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching all trainers: {ex.Message}");
                return new List<Trainer>();
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        public void Update()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = @"UPDATE Trainers SET 
                                Salary = @Salary, 
                                startDate = @StartDate, ContractType = @ContractType, 
                                endDate = @EndDate
                               WHERE nationalID = @NationalID";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating trainer: {ex.Message}");
                throw;
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        public static void Delete(string instructorId)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "DELETE FROM Trainers WHERE nationalID = @NationalID";
                ProgramSession.Instance.dbConnection.Execute(sql, new { NationalID = instructorId });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting trainer: {ex.Message}");
                throw;
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }
    }
}
