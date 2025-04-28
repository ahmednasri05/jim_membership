using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
namespace jim_membership.models

{
    public class Trainer : User
    {
        public int InstructorID { get; set; }
        public int UserId { get; set; }
        public int Salary { get; set; }
        public DateTime Duration { get; set; }
        public string Type { get; set; }
        public DateTime StartDate { get; set; }

        private static readonly string _connectionString = "your_connection_string_here";

        public void Create()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"INSERT INTO Trainers (instructorID, userid, Salary, Duration, Type, startDate)
                               VALUES (@InstructorID, @UserId, @Salary, @Duration, @Type, @StartDate)";
                connection.Execute(sql, this);
            }
        }

        public static Trainer GetById(int instructorId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Trainers WHERE instructorID = @InstructorID";
                return connection.QueryFirstOrDefault<Trainer>(sql, new { InstructorID = instructorId });
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
                                userid = @UserId, Salary = @Salary, 
                                Duration = @Duration, Type = @Type, 
                                startDate = @StartDate
                               WHERE instructorID = @InstructorID";
                connection.Execute(sql, this);
            }
        }

        public static void Delete(int instructorId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM Trainers WHERE instructorID = @InstructorID";
                connection.Execute(sql, new { InstructorID = instructorId });
            }
        }
    }
}

