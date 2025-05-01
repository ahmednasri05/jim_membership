using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace jim_membership.models
{
    public class Certificate
    {
        public string TrainerID { get; set; }
        public string CertificateName { get; set; }

        // Create
        public void Create()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = @"INSERT INTO Certificates (trainerID, CertificateName)
                               VALUES (@TrainerID, @CertificateName)";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error creating certificate: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Read by ID
        public static Certificate GetById(int trainerID)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Certificates WHERE TrainerID = @trainerID";
                return ProgramSession.Instance.dbConnection.QueryFirstOrDefault<Certificate>(sql, new { TrainerID = trainerID });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching certificate by ID: {ex.Message}");
                return null;
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Read all
        public static List<Certificate> GetAll()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Certificates";
                return ProgramSession.Instance.dbConnection.Query<Certificate>(sql).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching all certificates: {ex.Message}");
                return new List<Certificate>();
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
                string sql = @"UPDATE Certificates 
                               SET CertificateName = @CertificateName 
                               WHERE trainerID = @TrainerID";
                ProgramSession.Instance.dbConnection.Execute(sql, this);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating certificate: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }

        // Delete
        public static void Delete(int certificateId)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "DELETE FROM Certificates WHERE trainerID = @TrainerID";
                ProgramSession.Instance.dbConnection.Execute(sql, new { CertificateID = certificateId });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error deleting certificate: {ex.Message}");
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }
    }
}

