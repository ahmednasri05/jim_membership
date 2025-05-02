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

namespace jim_membership.TrainerScenario
{
    public partial class TrainerHomePage : Form
    {
        public TrainerHomePage()
        {
            InitializeComponent();
            DisplaySessions();
            // WireUpEvents();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if(ToggleButton.Checked)
            {
                dataGridView1.DataSource = Session.GetAll();
            }
            else
            {
                dataGridView1.DataSource = Session.GetAll();
            }

        }

        private void HomeTitle_Click(object sender, EventArgs e)
        {
            DisplaySessions();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DisplaySessions()
        {

            try
            {
                var sessions = Session.GetAll();
                dataGridView1.DataSource = sessions;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error loading sessions: " + e.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void WireUpEvents()
        {
            btnCreateNew.Click += btnCreateNew_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            btnProfile.Click += btnProfile_Click;
        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            var form = new CreateNewSession();
            if (form.ShowDialog() == DialogResult.OK)
            {
                DisplaySessions();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a session to edit", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (Session)dataGridView1.SelectedRows[0].DataBoundItem;
            var form = new EditSession(selected);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DisplaySessions();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a session to delete", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (Session)dataGridView1.SelectedRows[0].DataBoundItem;
            var result = MessageBox.Show($"Are you sure you want to delete {selected.sessionNo}?", "Delete Session",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    Session.Delete(selected.sessionNo);
                    DisplaySessions();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting session: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            var form = new ViewProfile();
        }
    }
}
