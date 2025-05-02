using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Windows.Forms;
using jim_membership.models;

namespace jim_membership
{
    public partial class ReservationForm : Form
    {
        private TextBox txtMemberID = new TextBox { PlaceholderText = "Member ID", Dock = DockStyle.Fill, Margin = new Padding(1) };
        private TextBox txtSessionNo = new TextBox { PlaceholderText = "Session ID", Dock = DockStyle.Fill, Margin = new Padding(1) };
        private TextBox txtTransactionID = new TextBox { PlaceholderText = "Transaction ID (for delete)", Dock = DockStyle.Fill, Margin = new Padding(1) };

        private Button btnLoad = new Button { Text = "Load Reservations", Dock = DockStyle.Fill, Margin = new Padding(1) };
        private Button btnReserve = new Button { Text = "Reserve Session", Dock = DockStyle.Fill, Margin = new Padding(1) };
        private Button btnDelete = new Button { Text = "Delete Reservation", Dock = DockStyle.Fill, Margin = new Padding(1) };

        private ComboBox cmbSortSessions = new ComboBox { Dock = DockStyle.Fill, DropDownStyle = ComboBoxStyle.DropDownList, Margin = new Padding(1) };
        private ComboBox cmbSortReservations = new ComboBox { Dock = DockStyle.Fill, DropDownStyle = ComboBoxStyle.DropDownList, Margin = new Padding(1) };

        private DataGridView dgvSessions = new DataGridView { Dock = DockStyle.Top, Height = 350, Margin = new Padding(0, 30, 0, 0) }; 

        private DataGridView dgvReserves = new DataGridView { Dock = DockStyle.Fill };

        public ReservationForm()
        {
            this.Text = "Gym Reservation System";
            this.Size = new Size(900, 600);
            this.StartPosition = FormStartPosition.CenterScreen;

            // Populate ComboBoxes
            cmbSortSessions.Items.AddRange(new[] { "Sort by Date", "Sort by Type" });
            cmbSortReservations.Items.AddRange(new[] { "Sort by Member ID", "Sort by Transaction ID" });

            var inputPanel = new TableLayoutPanel
            {
                ColumnCount = 3,
                RowCount = 2,
                Dock = DockStyle.Top,
                AutoSize = true,
                Padding = new Padding(7) // Add padding around the panel
            };


            // Adjust column widths to allocate more space for text boxes
            inputPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40f)); // Wider column for Member ID
            inputPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30f)); // Medium column for Session ID
            inputPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30f)); // Medium column for Transaction ID

            // Increase row height for better spacing
            inputPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50)); // Increased height for text boxes
            inputPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60)); // Increased height for buttons

            // Set minimum size for text boxes to prevent squishing
            txtMemberID.MinimumSize = new Size(200, 30);
            txtSessionNo.MinimumSize = new Size(200, 30);
            txtTransactionID.MinimumSize = new Size(200, 30);

            // Set margin for text boxes
            txtMemberID.Margin = new Padding(5);
            txtSessionNo.Margin = new Padding(5);
            txtTransactionID.Margin = new Padding(5);

            // Set margin for buttons
            btnLoad.Margin = new Padding(5);
            btnReserve.Margin = new Padding(5);
            btnDelete.Margin = new Padding(5);


            inputPanel.Controls.Add(txtMemberID, 0, 0);
            inputPanel.Controls.Add(txtSessionNo, 1, 0);
            inputPanel.Controls.Add(txtTransactionID, 2, 0);
            inputPanel.Controls.Add(btnLoad, 0, 1);
            inputPanel.Controls.Add(btnReserve, 1, 1);
            inputPanel.Controls.Add(btnDelete, 2, 1);



            var sortPanel = new TableLayoutPanel
            {
                ColumnCount = 4,
                Dock = DockStyle.Top,
                Height = 40,
                Padding = new Padding(0, 0, 30, 0) // Add padding around the panel
            };

            sortPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            sortPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));
            sortPanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            sortPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50f));

            sortPanel.Controls.Add(new Label { Text = "Sort Sessions:", AutoSize = true, Anchor = AnchorStyles.Left, TextAlign = ContentAlignment.MiddleLeft }, 0, 0);
            sortPanel.Controls.Add(cmbSortSessions, 1, 0);
            sortPanel.Controls.Add(new Label { Text = "Sort Reservations:", AutoSize = true, Anchor = AnchorStyles.Left, TextAlign = ContentAlignment.MiddleLeft }, 2, 0);
            sortPanel.Controls.Add(cmbSortReservations, 3, 0);



            // Add controls to form
            Controls.Add(dgvReserves);
            Controls.Add(dgvSessions);
            Controls.Add(sortPanel);
            Controls.Add(inputPanel);

            // Event handlers
            btnLoad.Click += BtnLoad_Click;
            btnReserve.Click += BtnReserve_Click;
            btnDelete.Click += BtnDelete_Click;
            cmbSortSessions.SelectedIndexChanged += CmbSortSessions_SelectedIndexChanged;
            cmbSortReservations.SelectedIndexChanged += CmbSortReservations_SelectedIndexChanged;
            dgvSessions.SelectionChanged += DgvSessions_SelectionChanged;

            LoadSessions();
        }

        private void LoadSessions()
        {
            var sessions = Session.GetAll();
            dgvSessions.DataSource = null;
            dgvSessions.AutoGenerateColumns = true;
            dgvSessions.DataSource = sessions;

            if (sessions == null || sessions.Count == 0)
            {
                //MessageBox.Show("No sessions found.");
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            var reserves = Reserve.GetAll();
            dgvReserves.DataSource = null;
            dgvReserves.AutoGenerateColumns = true;

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
            if (txtMemberID.Text == ProgramSession.Instance.UserId)
            {
                bool success = Reserve.ReserveSession(txtMemberID.Text, txtSessionNo.Text);
                MessageBox.Show(success ? "Reserved!" : "Reservation failed.");
                if (success)
                    BtnLoad_Click(sender, e);
            }
            else
            {
                MessageBox.Show("You can only reserve your own sessions!");
            }



            // MessageBox.Show("Please enter valid Member ID and Session ID.");

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (
                int.TryParse(txtTransactionID.Text, out int transactionId) 
                )
            {
                Reserve.Delete(txtMemberID.Text, transactionId, txtSessionNo.Text);
                MessageBox.Show("Deleted!");
                BtnLoad_Click(sender, e);
            }
            else
            {
                MessageBox.Show("Please enter valid Member ID, Transaction ID, and Session ID.");
            }
        }

        private void DgvSessions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSessions.SelectedRows.Count > 0)
            {
                var selectedRow = dgvSessions.SelectedRows[0];
                if (selectedRow.Cells["SessionID"].Value != null)
                {
                    txtSessionNo.Text = selectedRow.Cells["SessionID"].Value.ToString();
                }
            }
        }

        private void CmbSortSessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            var sessions = Session.GetAll();
            if (sessions == null || sessions.Count == 0)
            {
                MessageBox.Show("No sessions to sort.");
                return;
            }

            if (cmbSortSessions.SelectedItem.ToString() == "Sort by Date")
                sessions = sessions.OrderBy(s => s.date).ToList();
            else if (cmbSortSessions.SelectedItem.ToString() == "Sort by Type")
                sessions = sessions.OrderBy(s => s.Type).ToList();

            dgvSessions.DataSource = null;
            dgvSessions.DataSource = sessions;
        }

        private void CmbSortReservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            var reserves = Reserve.GetAll();
            if (reserves == null || reserves.Count == 0)
            {
                MessageBox.Show("No reservations to sort.");
                return;
            }

            if (cmbSortReservations.SelectedItem.ToString() == "Sort by Member ID")
                reserves = reserves.OrderBy(r => r.memberID).ToList();
            else if (cmbSortReservations.SelectedItem.ToString() == "Sort by Transaction ID")
                reserves = reserves.OrderBy(r => r.transactionID).ToList();

            dgvReserves.DataSource = null;
            dgvReserves.DataSource = reserves;
        }
    }
}
