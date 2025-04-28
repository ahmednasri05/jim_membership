using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using System.Text;
using System.Threading.Tasks;

namespace jim_membership.models
{
    public class Member : User
    {
        public int MemberID { get; set; }
        public DateTime FirstJoinDate { get; set; }
        public DateTime InBodyUsed { get; set; }
        public DateTime FreezeDurationUsed { get; set; }
        public bool ActiveSubscription { get; set; }

        private static readonly string _connectionString = "your_connection_string_here";

        public void Create()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"INSERT INTO Members (memberID, nationalID, firstJoinDate, InBodyUsed, freezDurationUsed, ActiveSubscription)
                               VALUES (@MemberID, @NationalID, @FirstJoinDate, @InBodyUsed, @FreezeDurationUsed, @ActiveSubscription)";
                connection.Execute(sql, this);
            }
        }

        public static Member GetById(int memberId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Members WHERE memberID = @MemberID";
                return connection.QueryFirstOrDefault<Member>(sql, new { MemberID = memberId });
            }
        }

        public static List<Member> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Members";
                return connection.Query<Member>(sql).ToList();
            }
        }

        public void Update()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"UPDATE Members SET 
                                nationalID = @NationalID, 
                                firstJoinDate = @FirstJoinDate, 
                                InBodyUsed = @InBodyUsed, 
                                freezDurationUsed = @FreezeDurationUsed, 
                                ActiveSubscription = @ActiveSubscription
                               WHERE memberID = @MemberID";
                connection.Execute(sql, this);
            }
        }

        public static void Delete(int memberId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM Members WHERE memberID = @MemberID";
                connection.Execute(sql, new { MemberID = memberId });
            }
        }
    }
}
