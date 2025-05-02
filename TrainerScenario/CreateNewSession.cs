using jim_membership.models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jim_membership.TrainerScenario
{
    public partial class CreateNewSession : Form
    {
        public CreateNewSession()
        {
            InitializeComponent();
            LoadBranches();
            LablePopulate();
        }

        private void LoadBranches()
        {
            try
            {
                var branches = models.Branch.GetAll();
                comboBox1.DataSource = branches;
                comboBox1.DisplayMember = "BranchName";
                comboBox1.ValueMember = "BranchNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading branches: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LablePopulate()
        {
            try
            {
                int maxSessionId = Session.GreatestSessionID();
                int nextSessionId = maxSessionId + 1;

                lbSessionNumber.Text = $"{nextSessionId}";
                lbTrainerName.Text = $"{ProgramSession.Instance.UserId}";
            }
            catch (Exception ex)
            {
                // Handle errors during data retrieval or assignment
                MessageBox.Show($"Error populating form labels: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                // Optionally display error state in labels
                lbSessionNo.Text = "Error";
                lbTrainerName.Text = "Error";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                string branchNumber = ((jim_membership.models.Branch)comboBox1.SelectedItem).BranchNo; //((jim_membership.models.Branch)comboBox1.SelectedItem).BranchNo
                DateTime sessionDate = dateTimePicker1.Value.Date;
                string timeInput = textBox5.Text;
                int duration = (int)numericUpDown1.Value;
                string sessionType = textBox7.Text;
                string description = textBox8.Text;
                int maxAttendees = (int)numericUpDown2.Value;

                if (string.IsNullOrWhiteSpace(branchNumber))
                {
                    MessageBox.Show("Please select a Branch Number.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboBox1.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(timeInput))
                {
                    MessageBox.Show("Please enter the Time (HH:mm).", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox5.Focus();
                    return;
                }

                TimeSpan sessionTimeOfDay;
                if (!TimeSpan.TryParse(timeInput, out sessionTimeOfDay)) // Assumes HH:mm or HH:mm:ss format
                {
                    MessageBox.Show("Invalid Time format. Please use 24-hour format (e.g., 14:30).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox5.Focus();
                    textBox5.SelectAll();
                    return;
                }

                if (duration <= 0)
                {
                    MessageBox.Show("Duration must be greater than 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numericUpDown1.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(sessionType))
                {
                    MessageBox.Show("Please enter the Session Type.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox7.Focus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(description))
                {
                    MessageBox.Show("Please enter a Description.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox8.Focus();
                    return;
                }

                if (maxAttendees <= 0)
                {
                    MessageBox.Show("Max Attendees must be greater than 0.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    numericUpDown2.Focus();
                    return;
                }

                // Create a new session object
                var newSession = new models.Session
                {
                    sessionNo = (Session.GreatestSessionID() + 1).ToString(),
                    trainerID = ProgramSession.Instance.UserId,
                    BranchNo = branchNumber,
                    Type = sessionType,
                    maxNumber = maxAttendees,
                    date = sessionDate,
                    Time = sessionTimeOfDay,
                    //duration = duration,
                    description = description
                };

                newSession.Create();
                MessageBox.Show("Session created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


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

        private void CreateNewSession_Load(object sender, EventArgs e)
        {
            LoadBranches();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbTrainerName_Click(object sender, EventArgs e)
        {

        }

        private void lbSessionNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
