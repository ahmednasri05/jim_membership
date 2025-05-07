using System;
using System.Windows.Forms;
using jim_membership.models;

namespace jim_membership.Admin.Logs
{
    public partial class AddLog : Form
    {
        public AddLog()
        {
            InitializeComponent();
            LoadMembers();
            LoadBranches();
        }

        private void LoadMembers()
        {
            try
            {
                var members = Member.GetAll();
                memberComboBox.DataSource = members;
                memberComboBox.DisplayMember = "FullName";
                memberComboBox.ValueMember = "NationalID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading members: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBranches()
        {
            try
            {
                var branches = Branch.GetAll();
                branchComboBox.DataSource = branches;
                branchComboBox.DisplayMember = "BranchName";
                branchComboBox.ValueMember = "BranchNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading branches: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (memberComboBox.SelectedValue == null || branchComboBox.SelectedValue == null)
                {
                    MessageBox.Show("Please select both a member and a branch.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newLog = new Log
                {
                    MemberID = memberComboBox.SelectedValue.ToString(),
                    BranchNo = branchComboBox.SelectedValue.ToString(), // Corrected to handle as string
                    CheckInTime = checkInDateTimePicker.Value,
                    checkoutTime = checkOutDateTimePicker.Value
                };

                newLog.Create();
                MessageBox.Show("Log added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding log: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}