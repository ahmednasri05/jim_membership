using jim_membership.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jim_membership.Admin.Logs
{
    public partial class LogsCRUD : Form
    {
        public LogsCRUD()
        {
            InitializeComponent();
            LoadLogs();
        }

        public void LoadLogs(string? sortBy = null)
        {
            try
            {
                var logs = Log.GetSortedLogs(sortBy);
                LogsGridView.DataSource = logs;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading logs: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddLogBtn_Click(object sender, EventArgs e)
        {
            // Open the AddLog form
            var addLogForm = new AddLog();
            if (addLogForm.ShowDialog() == DialogResult.OK)
            {
                LoadLogs(); // Refresh the logs after adding a new log
            }
        }

        private void EditLogBtn_Click(object sender, EventArgs e)
        {
            if (LogsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a log to edit", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (Log)LogsGridView.SelectedRows[0].DataBoundItem;
            selected.checkoutTime = DateTime.Now.AddHours(2); 

            if (string.IsNullOrEmpty(selected.MemberID) || string.IsNullOrEmpty(selected.BranchNo))
            {
                MessageBox.Show("MemberID or BranchNo is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Log.Update(selected.checkoutTime, selected.CheckInTime, selected.MemberID, selected.BranchNo);
                LoadLogs();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error editing log: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteLogBtn_Click(object sender, EventArgs e)
        {
            if (LogsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a log to delete", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (Log)LogsGridView.SelectedRows[0].DataBoundItem;

            if (string.IsNullOrEmpty(selected.MemberID) || string.IsNullOrEmpty(selected.BranchNo))
            {
                MessageBox.Show("MemberID or BranchNo is missing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Log.Delete(selected.CheckInTime, selected.MemberID, selected.BranchNo);
            LoadLogs();
        }

        private void LogsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell content click if needed
        }
 
        private void SortByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sortByComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid sorting option.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedSort = sortByComboBox.SelectedItem?.ToString() ?? "";
            LoadLogs(selectedSort);
        }

        private void LogsCRUD_Load(object sender, EventArgs e)
        {

        }
    }
}
