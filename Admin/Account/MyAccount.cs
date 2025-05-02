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

namespace jim_membership.Admin.Account
{
    public partial class MyAccount : Form
    {
        public MyAccount()
        {
            InitializeComponent();
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                // Fetch user data from the database using the current session's UserId
                var user = User.GetById(ProgramSession.Instance.UserId);

                if (user != null)
                {
                    txtNationalID.Text = user.NationalID;
                    txtFirstName.Text = user.FName;
                    txtLastName.Text = user.LName;
                    txtUsername.Text = user.Username;
                    txtPhoneNumber.Text = user.PhoneNumber;
                    txtAddress.Text = user.Address;
                    txtEmail.Text = user.Email;
                }
                else
                {
                    MessageBox.Show("User data could not be loaded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Are you sure you want to delete your account? This action cannot be undone.", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    User.Delete(ProgramSession.Instance.UserId);
                    MessageBox.Show("Account deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting account: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void MyAccount_Load(object sender, EventArgs e)
        {

        }

        private void txtNationalID_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
