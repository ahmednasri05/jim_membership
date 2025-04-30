using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void Create()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = @"INSERT INTO Trainers (instructorID, userid, Salary, Duration, Type, startDate)
                               VALUES (@InstructorID, @UserId, @Salary, @Duration, @Type, @StartDate)";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating trainer: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        public static Trainer GetById(int instructorId)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Trainers WHERE instructorID = @InstructorID";
                return ProgramSession.Instance.dbConnection.QueryFirstOrDefault<Trainer>(sql, new { InstructorID = instructorId });
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
                               userid = @UserId, Salary = @Salary, 
                               Duration = @Duration, Type = @Type, 
                               startDate = @StartDate
                               WHERE instructorID = @InstructorID";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating trainer: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        public static void Delete(int instructorId)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "DELETE FROM Trainers WHERE instructorID = @InstructorID";
                ProgramSession.Instance.dbConnection.Execute(sql, new { InstructorID = instructorId });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting trainer: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }
    }
}
