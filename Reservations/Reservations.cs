using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace jim_membership.models
{
    public partial class ReservationForm : Form
    {
        private ComboBox comboBoxSessions;
        private TextBox textBoxTraineeID;
        private Button buttonSubmit;

        public ReservationForm()
        {
            InitializeComponent();
            LoadAvailableSessions();
        }

        private void InitializeComponent()
        {
            comboBoxSessions = new ComboBox();
            textBoxTraineeID = new TextBox();
            buttonSubmit = new Button();
            SuspendLayout();
            // 
            // comboBoxSessions
            // 
            comboBoxSessions.FormattingEnabled = true;
            comboBoxSessions.Location = new Point(121, 137);
            comboBoxSessions.Margin = new Padding(7, 8, 7, 8);
            comboBoxSessions.Name = "comboBoxSessions";
            comboBoxSessions.Size = new Size(480, 49);
            comboBoxSessions.TabIndex = 0;
            comboBoxSessions.SelectedIndexChanged += comboBoxSessions_SelectedIndexChanged;
            // 
            // textBoxTraineeID
            // 
            textBoxTraineeID.Location = new Point(121, 273);
            textBoxTraineeID.Margin = new Padding(7, 8, 7, 8);
            textBoxTraineeID.Name = "textBoxTraineeID";
            textBoxTraineeID.Size = new Size(480, 47);
            textBoxTraineeID.TabIndex = 1;
            // 
            // buttonSubmit
            // 
            buttonSubmit.Location = new Point(121, 410);
            buttonSubmit.Margin = new Padding(7, 8, 7, 8);
            buttonSubmit.Name = "buttonSubmit";
            buttonSubmit.Size = new Size(486, 82);
            buttonSubmit.TabIndex = 2;
            buttonSubmit.Text = "Submit";
            buttonSubmit.UseVisualStyleBackColor = true;
            buttonSubmit.Click += buttonSubmit_Click;
            // 
            // ReservationForm
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1943, 1230);
            Controls.Add(comboBoxSessions);
            Controls.Add(textBoxTraineeID);
            Controls.Add(buttonSubmit);
            Margin = new Padding(7, 8, 7, 8);
            Name = "ReservationForm";
            Text = "Reservation Form";
            Load += ReservationForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private void LoadAvailableSessions()
        {
            // Fetch available sessions
            List<Session> sessions = Reserve.GetAvailableSessions();

            // Bind sessions to the dropdown
            comboBoxSessions.DataSource = sessions;
            comboBoxSessions.DisplayMember = "Description"; // Display session description
            comboBoxSessions.ValueMember = "SessionID"; // Use SessionID as the value
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxTraineeID.Text, out int traineeId) && comboBoxSessions.SelectedValue is int sessionId)
            {
                bool success = Reserve.ReserveSession(traineeId, sessionId);

                if (success)
                {
                    MessageBox.Show("Reservation successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to reserve the session. It might be full.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Trainee ID and select a session.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void comboBoxSessions_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {

        }
    }
}