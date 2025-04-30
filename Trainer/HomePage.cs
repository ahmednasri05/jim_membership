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

namespace jim_membership.Trainer
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            LoadSession();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {}

        private void LoadSession()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Session Number");
            dt.Columns.Add("Branch");
            dt.Columns.Add("MAX number of Attendees");
            dt.Columns.Add("Number of Attendees");
            dt.Columns.Add("Date");
            dt.Columns.Add("Time");
            dt.Columns.Add("Duration");
            dt.Columns.Add("Type");
            dt.Columns.Add("Description");

            try
            {
                var session = Session.GetAll();

                foreach (var s in session)
                {
                    dt.Rows.Add(s.SessionID, s.BranchNo, s.MaxNumber, s.Date, s.Duration, s.Type, s.Description);
                }
                this.sessionsDataView.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
