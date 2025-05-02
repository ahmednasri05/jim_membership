using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace jim_membership.models
{
    public class Branch
    {
        public string BranchNo { get; set; }
        public string ManagerID { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string BranchName { get; set; }

        public override string ToString() => $"{BranchNo} - {BranchName}";

        // Create
        public void Create()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = @"INSERT INTO Branches (BranchNo, ManagerID, PhoneNumber, Address, BranchName)
                           VALUES (@BranchNo, @ManagerID, @PhoneNumber, @Address, @BranchName)";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating branch: {ex.Message}");
                throw;
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Read by ID
        public static Branch GetById(int branchNo)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Branches WHERE BranchNo = @BranchNo";
                return ProgramSession.Instance.dbConnection.QueryFirstOrDefault<Branch>(sql, new { BranchNo = branchNo });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching branch by ID: {ex.Message}");
                return null;
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Read all
        public static List<Branch> GetAll()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Branches";
                return ProgramSession.Instance.dbConnection.Query<Branch>(sql).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching all branches: {ex.Message}");
                return new List<Branch>();
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
                string sql = @"UPDATE Branches 
                           SET ManagerID = @ManagerID, 
                               PhoneNumber = @PhoneNumber, 
                               Address = @Address, 
                               BranchName = @BranchName
                           WHERE BranchNo = @BranchNo";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating branch: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Delete
        public static void Delete(string branchNo)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "DELETE FROM Branches WHERE BranchNo = @BranchNo";
                ProgramSession.Instance.dbConnection.Execute(sql, new { BranchNo = branchNo });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting branch: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }
    }
}
