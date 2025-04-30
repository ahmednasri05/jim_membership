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

        private Button btnLoad = new Button { Text = "Load Reservations", Left = 250, Top = 20, Width = 200, Height = 50 };
        private Button btnReserve = new Button { Text = "Reserve Session", Left = 250, Top = 60, Width = 200, Height = 50 };
        private Button btnDelete = new Button { Text = "Delete Reservation", Left = 250, Top = 100, Width = 200, Height = 50 };

        private DataGridView dgvReserves = new DataGridView { Left = 20, Top = 150, Width = 600, Height = 300 };

        public Reservations()
        {
            this.Text = "Gym Reservation System";
            this.Size = new System.Drawing.Size(800, 600); // larger default

            // Anchors for positioning
            txtMemberID.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtSessionNo.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtTransactionID.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            btnLoad.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnReserve.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Left;

            dgvReserves.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            // Add controls
            this.Controls.Add(txtMemberID);
            this.Controls.Add(txtSessionNo);
            this.Controls.Add(txtTransactionID);
            this.Controls.Add(btnLoad);
            this.Controls.Add(btnReserve);
            this.Controls.Add(btnDelete);
            this.Controls.Add(dgvReserves);

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
                dgvReserves.DataSource = null;
                MessageBox.Show("No reservations found.");
            }
        }

        private void BtnReserve_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtMemberID.Text, out int memberId) && int.TryParse(txtSessionNo.Text, out int sessionNo))
            {
                bool success = Reserve.ReserveSession(memberId, sessionNo);
                MessageBox.Show(success ? "Reserved!" : "Reservation failed.");
                BtnLoad_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please enter valid Member ID and Session No.");
            }
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
                MessageBox.Show("Please enter valid IDs for deletion.");
            }
        }

        private void DgvReserves_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvReserves.SelectedRows.Count > 0)
            {
                var selectedRow = dgvReserves.SelectedRows[0];

                txtMemberID.Text = selectedRow.Cells["memberID"].Value?.ToString();
                txtTransactionID.Text = selectedRow.Cells["transactionID"].Value?.ToString();
                txtSessionNo.Text = selectedRow.Cells["sessionNo"].Value?.ToString();
            }
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // Reservations
            // 
            ClientSize = new Size(1510, 452);
            Name = "Reservations";
            Load += Reservations_Load;
            ResumeLayout(false);

        }

        private void Reservations_Load(object sender, EventArgs e)
        {

        }
    }
}