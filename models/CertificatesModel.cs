using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace jim_membership.models
{
    public class CertificatesModel
    {
        public string trainerID { get; set; }
        public string Certificate { get; set; }

        // Create
        public void Create()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = @"INSERT INTO Certificates (trainerID, Certificate)
                               VALUES (@trainerID, @Certificate)";
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
        public static CertificatesModel GetById(string trainerID)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Certificates WHERE trainerID = @trainerID";
                return ProgramSession.Instance.dbConnection.QueryFirstOrDefault<CertificatesModel>(sql, new { trainerID = trainerID });
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

        public static List<CertificatesModel> GetByTrainerID(string trainerID)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Certificates WHERE trainerID = @trainerID";
                return ProgramSession.Instance.dbConnection.Query<CertificatesModel>(sql, new { trainerID = trainerID }).ToList();
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
        public static List<CertificatesModel> GetAll()
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "SELECT * FROM Certificates";
                return ProgramSession.Instance.dbConnection.Query<CertificatesModel>(sql).ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching all certificates: {ex.Message}");
                return new List<CertificatesModel>();
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
                               SET Certificate = @Certificate 
                               WHERE Certificate = @trainerID";
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
                string sql = "DELETE FROM Certificates WHERE Certificate = @Certificate";
                ProgramSession.Instance.dbConnection.Execute(sql, new { Certificate = certificateId });
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

        public static void Delete(string certificateId)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();
                string sql = "DELETE FROM Certificates WHERE Certificate = @Certificate";
                ProgramSession.Instance.dbConnection.Execute(sql, new { Certificate = certificateId });
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

