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
        public string Location { get; set; }
        public int AdminID { get; set; }

        private static readonly string _connectionString = "your_connection_string_here";

        // Create
        public void Create()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"INSERT INTO Branches (BranchNo, Location, AdminID)
                               VALUES (@BranchNo, @Location, @AdminID)";
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
                               SET Location = @Location, AdminID = @AdminID 
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
