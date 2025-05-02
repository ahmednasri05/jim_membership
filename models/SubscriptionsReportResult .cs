using Dapper;
using System;
using System.Data;
using System.Data.SqlClient;

namespace jim_membership.models
{
    public class SubscriptionsReportResult
    {
        public int NumOfMembers { get; set; }
        public int NumberOfPayments { get; set; }
        public decimal TotalAmountPaid { get; set; }

        public SubscriptionsReportResult GetSubscriptionsReport(DateTime startDate, DateTime endDate)
        {
            try
            {
                ProgramSession.Instance.OpenConnection();

                var parameters = new DynamicParameters();
                parameters.Add("@StartDate", startDate, DbType.Date);
                parameters.Add("@EndDate", endDate, DbType.Date);

                var result = ProgramSession.Instance.dbConnection.QuerySingle<SubscriptionsReportResult>(
                    "SubscriptionsReport",
                    parameters,
                    commandType: CommandType.StoredProcedure
                );

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error generating subscriptions report: {ex.Message}");
                throw;
            }
            finally
            {
                ProgramSession.Instance.CloseConnection();
            }
        }
    }
}