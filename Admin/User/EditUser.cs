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
            txtUsername.Text = User.Username;
            txtPassword.Text = User.Password;
            txtPhoneNumber.Text = User.PhoneNumber.ToString();
            txtAddress.Text = User.Address;
            rbMale.Checked = User.Gender == 0;
            rbFemale.Checked = User.Gender == 1;
            txtAge.Text = User.Age.ToString();
            txtEmail.Text = User.Email;
            txtECName.Text = User.ECName;
            txtECPhoneNumber.Text = User.ECPhoneNumber.ToString();

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
            // Assign values to User object
            User.FName = txtFName.Text;
            User.LName = txtLName.Text;
            User.Username = txtUsername.Text;
            User.Password = txtPassword.Text;
            if (int.TryParse(txtPhoneNumber.Text, out int phoneNumber))
            {
                User.PhoneNumber = int.Parse(txtPhoneNumber.Text);
            }
            else
            {
                MessageBox.Show("Please enter a valid National ID.");
            }
            User.Address = txtAddress.Text;
            User.Gender = (byte)(rbMale.Checked ? 0 : 1);
            User.Age = int.TryParse(txtAge.Text, out int age) ? age : 0;
            User.Email = txtEmail.Text;
            User.ECName = txtECName.Text;
            if (int.TryParse(txtECPhoneNumber.Text, out int ECPhoneNumber))
            {
                User.ECPhoneNumber = int.Parse(txtECPhoneNumber.Text);
            }
            else
            {
                MessageBox.Show("Please enter a valid National ID.");
            }

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

        private void EditUser_Load(object sender, EventArgs e)
        {

        }
    }
}
