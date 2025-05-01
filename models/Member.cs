using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Text;
using System.Threading.Tasks;

namespace jim_membership.models
{
    public class Member
    {
        public int NationalID { get; set; }
        public DateTime FirstJoinDate { get; set; }
        public int InBodyUsed { get; set; }
        public int FreezeDurationUsed { get; set; }
        public bool ActiveSubscription { get; set; }

        // Create
        public void Create()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = @"INSERT INTO Members (NationalID, FirstJoinDate, InBodyUsed, FreezeDurationUsed, ActiveSubscription)
                               VALUES (@NationalID, @FirstJoinDate, @InBodyUsed, @FreezeDurationUsed, @ActiveSubscription)";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating member: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Read by ID
        public static Member GetById(int nationalID)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Members WHERE NationalID = @NationalID";
                return ProgramSession.Instance.dbConnection.QueryFirstOrDefault<Member>(sql, new { NationalID = nationalID });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching member by ID: {ex.Message}");
                return null;
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Read all
        public static List<Member> GetAll()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Members";
                return ProgramSession.Instance.dbConnection.Query<Member>(sql).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching all members: {ex.Message}");
                return new List<Member>();
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
                string sql = @"UPDATE Members SET  
                               FirstJoinDate = @FirstJoinDate, 
                               InBodyUsed = @InBodyUsed, 
                               FreezeDurationUsed = @FreezeDurationUsed, 
                               ActiveSubscription = @ActiveSubscription
                               WHERE NationalID = @NationalID";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating member: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Delete
        public static void Delete(int nationalID)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "DELETE FROM Members WHERE NationalID = @NationalID";
                ProgramSession.Instance.dbConnection.Execute(sql, new { NationalID = nationalID });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting member: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }
    }
}