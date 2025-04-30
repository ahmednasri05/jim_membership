using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
namespace jim_membership.models
{
    public class Branch
    {
        public int BranchNo { get; set; }
        public int ManagerID { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public string BranchName { get; set; }

        private static readonly string _connectionString = "Server=localhost;Database=JimMemberShip;Trusted_Connection=True;";

        // Create
        public void Create()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"INSERT INTO Branches (BranchNo, ManagerID, PhoneNumber, Address, BranchName)
                           VALUES (@BranchNo, @ManagerID, @PhoneNumber, @Address, @BranchName)";
                connection.Execute(sql, this);
            }
        }

        // Read by ID
        public static Branch GetById(int branchNo)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Branches WHERE BranchNo = @BranchNo";
                return connection.QueryFirstOrDefault<Branch>(sql, new { BranchNo = branchNo });
            }
        }

        // Read all
        public static List<Branch> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Branches";
                return connection.Query<Branch>(sql).ToList();
            }
        }

        // Update
        public void Update()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"UPDATE Branches 
                           SET ManagerID = @ManagerID, 
                               PhoneNumber = @PhoneNumber, 
                               Address = @Address, 
                               BranchName = @BranchName
                           WHERE BranchNo = @BranchNo";
                connection.Execute(sql, this);
            }
        }

        // Delete
        public static void Delete(int branchNo)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM Branches WHERE BranchNo = @BranchNo";
                connection.Execute(sql, new { BranchNo = branchNo });
            }
        }
    }
}
