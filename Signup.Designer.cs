namespace jim_membership
{
    partial class Signup
    {

        private Label labelTitle;
        private TextBox txtNationalID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
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
        private Button btnSignup;
        private Button btnCancel;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            txtNationalID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
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
            btnSignup = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.BackColor = Color.Transparent;
            labelTitle.Font = new Font("Brush Script MT", 36F, FontStyle.Italic, GraphicsUnit.Point);
            labelTitle.ForeColor = Color.Black;
            labelTitle.Location = new Point(120, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(300, 90);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Southern Fitness";
            labelTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtNationalID
            // 
            txtNationalID.BackColor = Color.Snow;
            txtNationalID.Location = new Point(150, 120);
            txtNationalID.Name = "txtNationalID";
            txtNationalID.PlaceholderText = "National ID";
            txtNationalID.Size = new Size(200, 23);
            txtNationalID.TabIndex = 1;
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.Snow;
            txtFirstName.Location = new Point(150, 150);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.PlaceholderText = "First Name";
            txtFirstName.Size = new Size(200, 23);
            txtFirstName.TabIndex = 2;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.Snow;
            txtLastName.Location = new Point(150, 180);
            txtLastName.Name = "txtLastName";
            txtLastName.PlaceholderText = "Last Name";
            txtLastName.Size = new Size(200, 23);
            txtLastName.TabIndex = 3;
            // 
            // txtUsername
            // 
            txtUsername.BackColor = Color.Snow;
            txtUsername.Location = new Point(150, 210);
            txtUsername.Name = "txtUsername";
            txtUsername.PlaceholderText = "Username";
            txtUsername.Size = new Size(200, 23);
            txtUsername.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Snow;
            txtPassword.Location = new Point(150, 240);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.PlaceholderText = "Password";
            txtPassword.Size = new Size(200, 23);
            txtPassword.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.Snow;
            txtPhoneNumber.Location = new Point(150, 270);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PlaceholderText = "Phone Number";
            txtPhoneNumber.Size = new Size(200, 23);
            txtPhoneNumber.TabIndex = 6;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = Color.Snow;
            txtAddress.Location = new Point(150, 300);
            txtAddress.Name = "txtAddress";
            txtAddress.PlaceholderText = "Address";
            txtAddress.Size = new Size(200, 23);
            txtAddress.TabIndex = 7;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.BackColor = Color.LightBlue;
            rbMale.Location = new Point(150, 330);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(51, 19);
            rbMale.TabIndex = 8;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = false;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.BackColor = Color.LightBlue;
            rbFemale.Location = new Point(220, 330);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(63, 19);
            rbFemale.TabIndex = 9;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = false;
            rbFemale.CheckedChanged += rbFemale_CheckedChanged;
            // 
            // txtAge
            // 
            txtAge.BackColor = Color.Snow;
            txtAge.Location = new Point(150, 360);
            txtAge.Name = "txtAge";
            txtAge.PlaceholderText = "Age";
            txtAge.Size = new Size(200, 23);
            txtAge.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Snow;
            txtEmail.Location = new Point(150, 390);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(200, 23);
            txtEmail.TabIndex = 11;
            // 
            // txtECName
            // 
            txtECName.BackColor = Color.Snow;
            txtECName.Location = new Point(150, 420);
            txtECName.Name = "txtECName";
            txtECName.PlaceholderText = "Emergency Contact Name";
            txtECName.Size = new Size(200, 23);
            txtECName.TabIndex = 12;
            // 
            // txtECPhoneNumber
            // 
            txtECPhoneNumber.BackColor = Color.Snow;
            txtECPhoneNumber.Location = new Point(150, 450);
            txtECPhoneNumber.Name = "txtECPhoneNumber";
            txtECPhoneNumber.PlaceholderText = "Emergency Contact Phone";
            txtECPhoneNumber.Size = new Size(200, 23);
            txtECPhoneNumber.TabIndex = 13;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = SystemColors.InactiveCaption;
            btnSignup.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignup.ForeColor = Color.White;
            btnSignup.Location = new Point(150, 490);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(90, 40);
            btnSignup.TabIndex = 14;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightGray;
            btnCancel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCancel.Location = new Point(260, 490);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 40);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.login_gym;
            ClientSize = new Size(500, 550);
            Controls.Add(btnCancel);
            Controls.Add(btnSignup);
            Controls.Add(txtECPhoneNumber);
            Controls.Add(txtECName);
            Controls.Add(txtEmail);
            Controls.Add(txtAge);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(txtAddress);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(txtNationalID);
            Controls.Add(labelTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Signup";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Registration";
            Load += Signup_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
    }
}