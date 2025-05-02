using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace jim_membership.models
{
    public class TrainerSessionsReport
    {
        public string TrainerID { get; set; }
        public string TrainerName { get; set; }
        public int NoOfSessions { get; set; }

        public List<TrainerSessionsReport> GetTrainerSessionsReport(int noOfSessions)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();

                var parameters = new DynamicParameters();
                parameters.Add("@NoOfSessions", noOfSessions, DbType.Int32);

                var result = ProgramSession.Instance.dbConnection.Query<TrainerSessionsReport>(
                    "TrainerSessionsReport",
                    parameters,
                    commandType: CommandType.StoredProcedure
                ).AsList();

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generating trainer sessions report: {ex.Message}");
                throw;
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }
    }
}
