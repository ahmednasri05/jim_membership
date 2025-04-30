using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
namespace jim_membership.models
{
    public class Certificate
    {
        public int TrainerID { get; set; }
        public string CertificateName { get; set; }

        private static readonly string _connectionString = "Server=localhost;Database=JimMemberShip;Trusted_Connection=True;";

        // Create
        public void Create()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"INSERT INTO Certificates (trainerID, CertificateName)
                               VALUES (@TrainerID, @CertificateName)";
                connection.Execute(sql, this);
            }
        }

        // Read by ID
        public static Certificate GetById(int trainerID)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Certificates WHERE TrainerID = @trainerID";
                return connection.QueryFirstOrDefault<Certificate>(sql, new { TrainerID = trainerID });
            }
        }

        // Read all
        public static List<Certificate> GetAll()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "SELECT * FROM Certificates";
                return connection.Query<Certificate>(sql).ToList();
            }
        }

        // Update
        public void Update()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = @"UPDATE Certificates 
                               SET CertificateName = @CertificateName 
                               WHERE trainerID = @TrainerID";
                connection.Execute(sql, this);
            }
        }

        // Delete
        public static void Delete(int certificateId)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                string sql = "DELETE FROM Certificates WHERE trainerID = @TrainerID";
                connection.Execute(sql, new { CertificateID = certificateId });
            }
        }
    }
}

