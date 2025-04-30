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
        public int BranchNo { get; set; }
        public string Location { get; set; }
        public int AdminID { get; set; }

        // Create
        public void Create()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = @"INSERT INTO Branches (BranchNo, Location, AdminID)
                               VALUES (@BranchNo, @Location, @AdminID)";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating branch: {ex.Message}");
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
                               SET Location = @Location, AdminID = @AdminID 
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
        public static void Delete(int branchNo)
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
