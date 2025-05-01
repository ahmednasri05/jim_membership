namespace jim_membership.Admin
{
    partial class EditUser
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtNationalID;
        private TextBox txtFName;
        private TextBox txtLName;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private TextBox txtPhoneNumber;
        private TextBox txtAddress;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private TextBox txtAge;
        private TextBox txtEmail;
        private TextBox txtECName;
        private TextBox txtECPhoneNumber;
        private Button btnOK;
        private Button btnCancel;

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
            // 
            // txtNationalID
            // 
            txtNationalID.Location = new Point(30, 21);
            txtNationalID.Name = "txtNationalID";
            txtNationalID.PlaceholderText = "National ID";
            txtNationalID.Size = new Size(200, 23);
            txtNationalID.TabIndex = 0;
            txtNationalID.TextChanged += txtNationalID_TextChanged;
            // 
            // txtFName
            // 
            txtFName.Location = new Point(30, 50);
            txtFName.Name = "txtFName";
            txtFName.PlaceholderText = "First Name";
            txtFName.Size = new Size(200, 23);
            txtFName.TabIndex = 1;
            // 
            // txtLName
            // 
            txtLName.Location = new Point(30, 80);
            txtLName.Name = "txtLName";
            txtLName.PlaceholderText = "Last Name";
            txtLName.Size = new Size(200, 23);
            txtLName.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(30, 110);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 3;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(30, 140);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 4;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(30, 170);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Phone Number";
            txtPhoneNumber.Size = new Size(200, 23);
            txtPhoneNumber.TabIndex = 5;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(30, 200);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address";
            txtAddress.Size = new Size(200, 23);
            txtAddress.TabIndex = 6;
            // 
            // rbMale
            // 
            rbMale.Location = new Point(30, 230);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(50, 20);
            rbMale.TabIndex = 7;
            rbMale.Text = "Male";
            // 
            // rbFemale
            // 
            rbFemale.Location = new Point(100, 230);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(60, 20);
            rbFemale.TabIndex = 8;
            rbFemale.Text = "Female";
            // 
            // txtAge
            // 
            txtAge.Location = new Point(30, 260);
            txtAge.Name = "txtAge";
            txtAge.PlaceholderText = "Age";
            txtAge.Size = new Size(200, 23);
            txtAge.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(30, 290);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtECName
            // 
            txtECName.Location = new Point(30, 320);
            txtECName.Name = "txtECName";
            txtECName.PlaceholderText = "Emergency Contact Name";
            txtECName.Size = new Size(200, 23);
            txtECName.TabIndex = 11;
            // 
            // txtECPhoneNumber
            // 
            txtECPhoneNumber.Location = new Point(30, 350);
            txtECPhoneNumber.Name = "txtECPhoneNumber";
            txtECPhoneNumber.PlaceholderText = "Emergency Contact Phone";
            txtECPhoneNumber.Size = new Size(200, 23);
            txtECPhoneNumber.TabIndex = 12;
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(30, 380);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 13;
            btnOK.Text = "OK";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(130, 380);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 14;
            btnCancel.Text = "Cancel";
            // 
            // EditUser
            // 
            ClientSize = new Size(270, 430);
            Controls.Add(txtNationalID);
            Controls.Add(txtFName);
            Controls.Add(txtLName);
            Controls.Add(txtUsername);
            Controls.Add(txtPassword);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtAddress);
            Controls.Add(rbMale);
            Controls.Add(rbFemale);
            Controls.Add(txtAge);
            Controls.Add(txtEmail);
            Controls.Add(txtECName);
            Controls.Add(txtECPhoneNumber);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Name = "EditUser";
            Text = "Edit User";
            Load += EditUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
