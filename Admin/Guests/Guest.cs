using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using jim_membership.models;
namespace jim_membership.Admin
{
    public partial class Guest : Form
    {
        public Guest()
        {
            InitializeComponent();
            LoadGuests();
            if (ProgramSession.Instance.UserRole != "Admin")
            {
                editGuest.Visible = false; // Hide the Edit button
                deleteGuest.Visible = false; // Hide the Delete button
            }
        }
        public void LoadGuests()
        {
            if (ProgramSession.Instance.UserRole != "Admin")
            {
             try
            {  
                var guests = Invite.GetById(ProgramSession.Instance.UserId);
                GuestsGridView.DataSource = guests;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
            else {
            try
            {  
                var guests = Invite.GetAll();
                GuestsGridView.DataSource = guests;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        }
        private void GuestsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void AddGuest_Click(object sender, EventArgs e)
        {
            var form = new EditGuest();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadGuests();
            }
        }

        private void editGuest_Click(object sender, EventArgs e)
        {
            if (GuestsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a guest to edit", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (Invite)GuestsGridView.SelectedRows[0].DataBoundItem;
            var form = new EditGuest(selected);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadGuests();
            }
        }

        private void deleteGuest_Click(object sender, EventArgs e)
        {
            if (GuestsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a guest to delete", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (Invite)GuestsGridView.SelectedRows[0].DataBoundItem;
            Invite.Delete(selected.MemberID, selected.guestID); //bug here
            LoadGuests();
        }
    }
}
