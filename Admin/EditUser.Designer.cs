namespace jim_membership.Admin
{
    partial class EditUser
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtECName;
        private System.Windows.Forms.TextBox txtECPhoneNumber;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtNationalID = new TextBox();
            txtFName = new TextBox();
            txtLName = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            txtAge = new TextBox();
            txtEmail = new TextBox();
            txtECName = new TextBox();
            txtECPhoneNumber = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();

            txtNationalID.Location = new Point(30, 20);
            txtNationalID.PlaceholderText = "National ID";
            txtNationalID.Size = new Size(200, 23);

            txtFName.Location = new Point(30, 50);
            txtFName.PlaceholderText = "First Name";
            txtFName.Size = new Size(200, 23);

            txtLName.Location = new Point(30, 80);
            txtLName.PlaceholderText = "Last Name";
            txtLName.Size = new Size(200, 23);

            txtUsername.Location = new Point(30, 110);
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(200, 23);

            txtPassword.Location = new Point(30, 140);
            txtPassword.PlaceholderText = "Password";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(200, 23);

            txtPhoneNumber.Location = new Point(30, 170);
            txtPhoneNumber.PlaceholderText = "Phone Number";
            txtPhoneNumber.Size = new Size(200, 23);

            txtAddress.Location = new Point(30, 200);
            txtAddress.PlaceholderText = "Address";
            txtAddress.Size = new Size(200, 23);

            rbMale.Location = new Point(30, 230);
            rbMale.Text = "Male";
            rbMale.Size = new Size(50, 20);

            rbFemale.Location = new Point(100, 230);
            rbFemale.Text = "Female";
            rbFemale.Size = new Size(60, 20);

            txtAge.Location = new Point(30, 260);
            txtAge.PlaceholderText = "Age";
            txtAge.Size = new Size(200, 23);

            txtEmail.Location = new Point(30, 290);
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(200, 23);

            txtECName.Location = new Point(30, 320);
            txtECName.PlaceholderText = "Emergency Contact Name";
            txtECName.Size = new Size(200, 23);

            txtECPhoneNumber.Location = new Point(30, 350);
            txtECPhoneNumber.PlaceholderText = "Emergency Contact Phone";
            txtECPhoneNumber.Size = new Size(200, 23);

            btnOK.Location = new Point(30, 380);
            btnOK.Text = "OK";
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Size = new Size(75, 23);

            btnCancel.Location = new Point(130, 380);
            btnCancel.Text = "Cancel";
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Size = new Size(75, 23);

            ClientSize = new Size(270, 430);
            Controls.AddRange(new Control[]
            {
        txtNationalID, txtFName, txtLName, txtUsername, txtPassword,
        txtPhoneNumber, txtAddress, rbMale, rbFemale, txtAge,
        txtEmail, txtECName, txtECPhoneNumber, btnOK, btnCancel
            });

            Name = "EditUser";
            Text = "Edit User";
            Load += EditUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
