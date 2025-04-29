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
        public int NationalID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public byte Gender { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string ECName { get; set; }
        public int ECPhoneNumber { get; set; }

        private static readonly string _connectionString = "Server=localhost;Database=JimMemberShip;Trusted_Connection=True;";

        public void Create()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"INSERT INTO Users (nationalID, FName, LName, username, password, phoneNumber, address, gender, age, email, ECName, ECPhoneNumber)
                               VALUES (@NationalID, @FName, @LName, @Username, @Password, @PhoneNumber, @Address, @Gender, @Age, @Email, @ECName, @ECPhoneNumber)";
                connection.Execute(sql, this);
            }
        }

        public static User GetById(int nationalId)
        {
            try
            {
                using (var connection = new SqlConnection(_connectionString))
                {
                    string sql = "SELECT * FROM Users WHERE nationalID = @NationalID";
                    connection.Open();  // Make sure the connection is explicitly opened
                    return connection.QueryFirstOrDefault<User>(sql, new { NationalID = nationalId });
                }
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
                using (var connection = new SqlConnection(_connectionString))
                {
                    string sql = "SELECT * FROM Users WHERE email = @Email";
                    connection.Open();  // Make sure the connection is explicitly opened
                    return connection.QueryFirstOrDefault<User>(sql, new { Email = email });
                }
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
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Users";
                return connection.Query<User>(sql).ToList();
            }
        }

        public void Update()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"UPDATE Users SET 
                                FName = @FName, LName = @LName, username = @Username, password = @Password, 
                                phoneNumber = @PhoneNumber, address = @Address, gender = @Gender, 
                                age = @Age, email = @Email, ECName = @ECName, ECPhoneNumber = @ECPhoneNumber
                               WHERE nationalID = @NationalID";
                connection.Execute(sql, this);
            }
        }

        public static void Delete(int nationalId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM Users WHERE nationalID = @NationalID";
                connection.Execute(sql, new { NationalID = nationalId });
            }
        }
    }
}
