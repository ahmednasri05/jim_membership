using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace jim_membership.models
{
    public class User
    {
        public string NationalID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public byte Gender { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string ECName { get; set; }
        public int ECPhoneNumber { get; set; }


        public void Create()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = @"INSERT INTO Users (nationalID, FName, LName, username, password, phoneNumber, address, gender, age, email, ECName, ECPhoneNumber)
                            VALUES (@NationalID, @FName, @LName, @Username, @Password, @PhoneNumber, @Address, @Gender, @Age, @Email, @ECName, @ECPhoneNumber)";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
                ProgramSession.Instance.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
                throw;
            }
        }

        public static User GetById(string nationalId)
        {
            try
            {

                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Users WHERE nationalID = @NationalID";
                User result = ProgramSession.Instance.dbConnection.QueryFirstOrDefault<User>(sql, new { NationalID = nationalId });
                ProgramSession.Instance.CloseConnection();

                return result;

            }
            catch (Exception ex)
            {
                // Log exception (could be to a log file, event log, or logging framework)
                Console.WriteLine($"Error: {ex.Message}");
                return null;  // Return null if the query fails
            }
        }

        
        public static User GetByEmail(string email)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Users WHERE email = @Email";
                User result = ProgramSession.Instance.dbConnection.QueryFirstOrDefault<User>(sql, new { Email = email });
                ProgramSession.Instance.CloseConnection();

                return result;

            }
            catch (Exception ex)
            {
                // Log exception (could be to a log file, event log, or logging framework)
                Console.WriteLine($"Error: {ex.Message}");
                return null;  // Return null if the query fails
            }
        }
        public static List<User> GetAll()
        {
            ProgramSession.Instance.OpenConnection();
            string sql = "SELECT * FROM Users";
            List<User> result = ProgramSession.Instance.dbConnection.Query<User>(sql).ToList();
            ProgramSession.Instance.CloseConnection();
            return result;
        }

        public void Update()
        {
            ProgramSession.Instance.OpenConnection();
            string sql = @"UPDATE Users SET 
                                FName = @FName, LName = @LName, username = @Username, password = @Password, 
                                phoneNumber = @PhoneNumber, address = @Address, gender = @Gender, 
                                age = @Age, email = @Email, ECName = @ECName, ECPhoneNumber = @ECPhoneNumber
                               WHERE nationalID = @NationalID";
            ProgramSession.Instance.dbConnection.Execute(sql, this);
            ProgramSession.Instance.CloseConnection();

        }

        public static void Delete(string nationalId)
        {
            ProgramSession.Instance.OpenConnection();
            string sql = "DELETE FROM Users WHERE nationalID = @NationalID";
            ProgramSession.Instance.dbConnection.Execute(sql, new { NationalID = nationalId });
            ProgramSession.Instance.CloseConnection();
        }
    }
}
