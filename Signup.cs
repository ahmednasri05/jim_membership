using jim_membership.models;
namespace jim_membership
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate required fields first
                if (string.IsNullOrWhiteSpace(txtNationalID.Text) ||
                    string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                    string.IsNullOrWhiteSpace(txtLastName.Text) ||
                    string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtPhoneNumber.Text) ||
                    string.IsNullOrWhiteSpace(txtAge.Text) ||
                    string.IsNullOrWhiteSpace(txtECPhoneNumber.Text))
                {
                    MessageBox.Show("Please fill in all required fields", "Validation Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Parse numeric fields with validation
                if (!int.TryParse(txtNationalID.Text, out int nationalId) ||
                    !int.TryParse(txtPhoneNumber.Text, out int phoneNumber) ||
                    !int.TryParse(txtAge.Text, out int age) ||
                    !int.TryParse(txtECPhoneNumber.Text, out int ecPhoneNumber))
                {
                    MessageBox.Show("Please enter valid numbers for numeric fields", "Validation Error",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var newUser = new User
                {
                    NationalID = (txtNationalID.Text),
                    FName = txtFirstName.Text,
                    LName = txtLastName.Text,
                    Username = txtUsername.Text,
                    Password = txtPassword.Text,
                    PhoneNumber = (txtPhoneNumber.Text),
                    Address = txtAddress.Text,
                    Gender = (byte)(rbMale.Checked ? 0 : 1),
                    Age = int.Parse(txtAge.Text),
                    Email = txtEmail.Text,
                    ECName = txtECName.Text,
                    ECPhoneNumber = int.Parse(txtECPhoneNumber.Text)
                };

                newUser.Create();
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Signup_Load_1(object sender, EventArgs e)
        {

        }

        private void rbFemale_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
