using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace jim_membership.models
{
    public class Invite
    {
        public int MemberID { get; set; }
        public int NationalID { get; set; }
        public DateTime InvitationDate { get; set; }

        // Create
        public void Create()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = @"INSERT INTO Invites (MemberID, NationalID, InvitationDate)
                               VALUES (@MemberID, @NationalID, @InvitationDate)";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating invite: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Read by ID
        public static Invite GetById(int memberId)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Invites WHERE MemberID = @MemberID";
                return ProgramSession.Instance.dbConnection.QueryFirstOrDefault<Invite>(sql, new { MemberID = memberId });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching invite by ID: {ex.Message}");
                return null;
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Read all
        public static List<Invite> GetAll()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Invites";
                return ProgramSession.Instance.dbConnection.Query<Invite>(sql).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching all invites: {ex.Message}");
                return new List<Invite>();
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
                string sql = @"UPDATE Invites 
                               SET NationalID = @NationalID, InvitationDate = @InvitationDate
                               WHERE MemberID = @MemberID";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating invite: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Delete
        public static void Delete(int memberId)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "DELETE FROM Invites WHERE MemberID = @MemberID";
                ProgramSession.Instance.dbConnection.Execute(sql, new { MemberID = memberId });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting invite: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }
    }
}
