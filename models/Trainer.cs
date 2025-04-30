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
        public int NationalID { get; set; }
        public int Salary { get; set; }
        public DateTime StartDate { get; set; }
        public string ContractType { get; set; }
        public DateTime EndDate { get; set; }

        private static readonly string _connectionString = "Server=localhost;Database=JimMemberShip;Trusted_Connection=True;";

        public void Create()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"INSERT INTO Trainers (nationalID, Salary, startDate, ContractType, endDate)
                               VALUES (@NationalID, @Salary, @StartDate, @ContractType, @EndDate)";
                connection.Execute(sql, this);
            }
        }

        public static Trainer GetById(int nationalID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Trainers WHERE nationalID = @NationalID";
                return connection.QueryFirstOrDefault<Trainer>(sql, new { NationalID = nationalID });
            }
        }

        public static List<Trainer> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Trainers";
                return connection.Query<Trainer>(sql).ToList();
            }
        }

        public void Update()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"UPDATE Trainers SET 
                                Salary = @Salary, 
                                startDate = @StartDate, ContractType = @ContractType, 
                                endDate = @EndDate
                               WHERE nationalID = @NationalID";
                connection.Execute(sql, this);
            }
        }

        public static void Delete(int nationalID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM Trainers WHERE nationalID = @NationalID";
                connection.Execute(sql, new { NationalID = nationalID });
            }
        }
    }
}

