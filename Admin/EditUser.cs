using System;
using System.Windows.Forms;
using jim_membership.models;

namespace jim_membership.Admin
{
    public partial class EditUser : Form
    {
        public User User { get; private set; }
        private bool isEditMode;

        public EditUser()
        {
            InitializeComponent();
            isEditMode = false;
            User = new User();
            btnOK.Click += BtnOK_Click;
        }

        public EditUser(User existingUser) : this()
        {
            isEditMode = true;
            User = existingUser;

            // Pre-fill the fields
            txtNationalID.Text = User.NationalID.ToString();
            txtFName.Text = User.FName;
            txtLName.Text = User.LName;
            txtEmail.Text = User.Email;

            // Prevent editing ID in edit mode
            txtNationalID.ReadOnly = true;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNationalID.Text) ||
                string.IsNullOrWhiteSpace(txtFName.Text) ||
                string.IsNullOrWhiteSpace(txtLName.Text))
            {
                MessageBox.Show("Please fill out all required fields.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }

            if (int.TryParse(txtNationalID.Text, out int nationalId))
            {
                User.NationalID = int.Parse(txtNationalID.Text);
            }
            else
            {
                MessageBox.Show("Please enter a valid National ID.");
            }
            User.FName = txtFName.Text;
            User.LName = txtLName.Text;
            User.Email = txtEmail.Text;

            try
            {
                if (isEditMode)
                {
                    User.Update();
                }
                else
                {
                    User.Create();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving user: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }
    }
}
