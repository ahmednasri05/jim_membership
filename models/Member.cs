using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

        private static readonly string _connectionString = "Server=localhost;Database=JimMemberShip;Trusted_Connection=True;";

        public void Create()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"INSERT INTO Members (NationalID, FirstJoinDate, InBodyUsed, FreezeDurationUsed, ActiveSubscription)
                           VALUES (@NationalID, @FirstJoinDate, @InBodyUsed, @FreezeDurationUsed, @ActiveSubscription)";
                connection.Execute(sql, this);
            }
        }

        public static Member GetById(int nationalID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Members WHERE NationalID = @NationalID";
                return connection.QueryFirstOrDefault<Member>(sql, new { NationalID = nationalID });
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
                            FirstJoinDate = @FirstJoinDate, 
                            InBodyUsed = @InBodyUsed, 
                            FreezeDurationUsed = @FreezeDurationUsed, 
                            ActiveSubscription = @ActiveSubscription
                           WHERE NationalID = @NationalID";
                connection.Execute(sql, this);
            }
        }

        public static void Delete(int nationalID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM Members WHERE NationalID = @NationalID";
                connection.Execute(sql, new { NationalID = nationalID });
            }
        }
    }
}