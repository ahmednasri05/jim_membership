using System;
using System.Windows.Forms;
using jim_membership.models;

namespace jim_membership.Admin
{
    public partial class SubscriptionsReportForm : Form
    {
        public SubscriptionsReportForm()
        {
            InitializeComponent();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                var startDate = dtpStartDate.Value.Date;
                var endDate = dtpEndDate.Value.Date;

                // Validate date range
                if (startDate > endDate)
                {
                    MessageBox.Show("End date must be after start date.",
                                 "Invalid Date Range",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                    return;
                }

                var report = new SubscriptionsReportResult().GetSubscriptionsReport(startDate, endDate);

                // Update UI with report data
                lblNumOfMembers.Text = report.NumOfMembers.ToString("N0");
                lblNumberOfPayments.Text = report.NumberOfPayments.ToString("N0");
                lblTotalAmountPaid.Text = report.TotalAmountPaid.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating report: {ex.Message}",
                              "Error",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }
    }
}