using System;
using System.Windows.Forms;
using jim_membership.models;

namespace jim_membership.Admin
{
    public partial class UserCrud : Form
    {
        public UserCrud()
        {
            InitializeComponent();
            LoadUsers();
            WireUpEvents();
        }

        private void WireUpEvents()
        {
            btnAddClient.Click += BtnAddClient_Click;
            btnEditClient.Click += BtnEditClient_Click;
            btnDeleteClient.Click += BtnDeleteClient_Click;
            Load += UserCrud_Load;
        }

        private void LoadUsers()
        {
            try
            {
                var users = User.GetAll();
                dgvUsers.DataSource = users;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAddClient_Click(object sender, EventArgs e)
        {
            var form = new EditUser();
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.User.Create();
                LoadUsers();
            }
        }

        private void BtnEditClient_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (User)dgvUsers.SelectedRows[0].DataBoundItem;
            var form = new EditUser(selected);
            if (form.ShowDialog() == DialogResult.OK)
            {
                form.User.Update();
                LoadUsers();
            }
        }

        private void BtnDeleteClient_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to delete", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (User)dgvUsers.SelectedRows[0].DataBoundItem;
            var confirm = MessageBox.Show(
                $"Are you sure you want to delete {selected.FName} {selected.LName}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    User.Delete(selected.NationalID);
                    LoadUsers();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting user: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void UserCrud_Load(object sender, EventArgs e)
        {
            LoadUsers();
        }
    }
}