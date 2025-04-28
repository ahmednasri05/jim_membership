using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
namespace jim_membership.models
{
    public class Invite
    {
        public int MemberID { get; set; }
        public int NationalID { get; set; }
        public DateTime InvitationDate { get; set; }

        private static readonly string _connectionString = "your_connection_string_here";

        // Create
        public void Create()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"INSERT INTO Invites (MemberID, NationalID, InvitationDate)
                               VALUES (@MemberID, @NationalID, @InvitationDate)";
                connection.Execute(sql, this);
            }
        }

        // Read by ID
        public static Invite GetById(int memberId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Invites WHERE MemberID = @MemberID";
                return connection.QueryFirstOrDefault<Invite>(sql, new { MemberID = memberId });
            }
        }

        // Read all
        public static List<Invite> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Invites";
                return connection.Query<Invite>(sql).ToList();
            }
        }

        // Update
        public void Update()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"UPDATE Invites 
                               SET NationalID = @NationalID, InvitationDate = @InvitationDate
                               WHERE MemberID = @MemberID";
                connection.Execute(sql, this);
            }
        }

        // Delete
        public static void Delete(int memberId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM Invites WHERE MemberID = @MemberID";
                connection.Execute(sql, new { MemberID = memberId });
            }
        }
    }
}
