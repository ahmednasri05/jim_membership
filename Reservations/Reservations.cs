using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Dapper;
using jim_membership.models;

namespace jim_membership
{
    public partial class Reservations : Form
    {
        private TextBox txtMemberID = new TextBox { Left = 20, Top = 20, Width = 200, PlaceholderText = "Member ID" };
        private TextBox txtSessionNo = new TextBox { Left = 20, Top = 60, Width = 200, PlaceholderText = "Session No" };
        private TextBox txtTransactionID = new TextBox { Left = 20, Top = 100, Width = 200, PlaceholderText = "Transaction ID (for delete)" };

        private Button btnLoad = new Button { Text = "Load Reservations", Left = 250, Top = 20, Width = 150 };
        private Button btnReserve = new Button { Text = "Reserve Session", Left = 250, Top = 60, Width = 150 };
        private Button btnDelete = new Button { Text = "Delete Reservation", Left = 250, Top = 100, Width = 150 };

        private DataGridView dgvReserves = new DataGridView { Left = 20, Top = 150, Width = 740, Height = 380 };

        public Reservations()
        {
            this.Text = "Gym Reservation System";
            this.Size = new System.Drawing.Size(800, 600);

            // Anchoring for responsiveness
            txtMemberID.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtSessionNo.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtTransactionID.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            btnLoad.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnReserve.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            dgvReserves.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Add controls to form
            this.Controls.Add(txtMemberID);
            this.Controls.Add(txtSessionNo);
            this.Controls.Add(txtTransactionID);
            this.Controls.Add(btnLoad);
            this.Controls.Add(btnReserve);
            this.Controls.Add(btnDelete);
            this.Controls.Add(dgvReserves);

            // Event bindings
            btnLoad.Click += BtnLoad_Click;
            btnReserve.Click += BtnReserve_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            var reserves = Reserve.GetAll();
            if (reserves != null && reserves.Count > 0)
            {
                dgvReserves.DataSource = reserves;
            }
            else
            {
                MessageBox.Show("No reservations found.");
            }
        }

        private void BtnReserve_Click(object sender, EventArgs e)
        {
          

                bool success = Reserve.ReserveSession(txtMemberID.Text, txtSessionNo.Text);
                MessageBox.Show(success ? "Reserved!" : "Reservation failed.");
                BtnLoad_Click(sender, e);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMemberID.Text, out int memberId) &&
                int.TryParse(txtTransactionID.Text, out int transactionId) &&
                int.TryParse(txtSessionNo.Text, out int sessionNo))
            {
                Reserve.Delete(memberId, transactionId, sessionNo);
                MessageBox.Show("Deleted!");
                BtnLoad_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please enter valid Member ID, Transaction ID, and Session No.");
            }
        }
    }
}
