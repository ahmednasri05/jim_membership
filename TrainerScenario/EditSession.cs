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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace jim_membership.TrainerScenario
{
    public partial class EditSession : Form
    {
        public EditSession(Session selected)
        {
            InitializeComponent();
            PopulateLabels(selected);
        }

        private void PopulateLabels(Session selected)
        {
            try
            {
                lbSessionNumber.Text = selected.sessionNo;
                lbTrainerName.Text = selected.trainerID;
                lbBranchNumber.Text = selected.BranchNo;
                txtTime.Text = selected.Time.ToString();
                dtpDate.Value = selected.date;
                nudDuration.Value = (int)selected.duration;
                txtType.Text = selected.Type;
                txtDescription.Text = selected.description;
                nudMaxAtt.Value = selected.maxNumber;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error populating form labels: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbSessionNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string branchNumber = lbBranchNo.Text;
                DateTime sessionDate = dtpDate.Value.Date;
                string timeInput = txtTime.Text;
                int duration = (int)nudDuration.Value;
                string sessionType = txtType.Text;
                string description = txtDescription.Text;
                int maxAttendees = (int)nudMaxAtt.Value;

                if (string.IsNullOrWhiteSpace(branchNumber))
                {
                    MessageBox.Show("Please select a Branch Number.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lbBranchNo.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(timeInput))
                {
                    MessageBox.Show("Please enter the Time (HH:mm).", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTime.Focus();
                    return;
                }

                TimeSpan sessionTimeOfDay;
                if (!TimeSpan.TryParse(timeInput, out sessionTimeOfDay)) // Assumes HH:mm or HH:mm:ss format
                {
                    MessageBox.Show("Invalid Time format. Please use 24-hour format (e.g., 14:30).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTime.Focus();
                    txtTime.SelectAll();
                    return;
                }

                if (duration <= 0)
                {
                    MessageBox.Show("Duration must be greater than 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nudDuration.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(sessionType))
                {
                    MessageBox.Show("Please enter the Session Type.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtType.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("Please enter a Description.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescription.Focus();
                    return;
                }

                if (maxAttendees <= 0)
                {
                    MessageBox.Show("Max Attendees must be greater than 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    nudMaxAtt.Focus();
                    return;
                }

                // Create a new session object
                var newSession = new models.Session
                {
                    Type = sessionType,
                    maxNumber = maxAttendees,
                    date = sessionDate,
                    Time = sessionTimeOfDay,
                    //duration = duration,
                    description = description
                };

                newSession.Update();
                MessageBox.Show("Session Updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                this.DialogResult = DialogResult.OK; // Indicate success if opened as dialog
                this.Close();
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Error formatting data: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred while saving: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lbBranchNumber_Click(object sender, EventArgs e)
        {

        }

        private void lbTrainerName_Click(object sender, EventArgs e)
        {

        }
    }
}
