namespace jim_membership.Admin.Account
{
    partial class MyAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private TextBox txtNationalID;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtUsername;
        private TextBox txtPhoneNumber;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private Button btnDeleteAccount;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed.</param>
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
            components = new System.ComponentModel.Container();
            txtNationalID = new TextBox();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtUsername = new TextBox();
            txtPhoneNumber = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            btnDeleteAccount = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // txtNationalID
            // 
            txtNationalID.BorderStyle = BorderStyle.FixedSingle;
            txtNationalID.Location = new Point(300, 69);
            txtNationalID.Margin = new Padding(6, 7, 6, 7);
            txtNationalID.Name = "txtNationalID";
            txtNationalID.ReadOnly = true;
            txtNationalID.Size = new Size(396, 35);
            txtNationalID.TabIndex = 0;
            txtNationalID.TextChanged += txtNationalID_TextChanged;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(300, 162);
            txtFirstName.Margin = new Padding(6, 7, 6, 7);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.ReadOnly = true;
            txtFirstName.Size = new Size(396, 35);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(300, 254);
            txtLastName.Margin = new Padding(6, 7, 6, 7);
            txtLastName.Name = "txtLastName";
            txtLastName.ReadOnly = true;
            txtLastName.Size = new Size(396, 35);
            txtLastName.TabIndex = 2;
            // 
            // txtUsername
            // 
            txtUsername.BorderStyle = BorderStyle.FixedSingle;
            txtUsername.Location = new Point(300, 346);
            txtUsername.Margin = new Padding(6, 7, 6, 7);
            txtUsername.Name = "txtUsername";
            txtUsername.ReadOnly = true;
            txtUsername.Size = new Size(396, 35);
            txtUsername.TabIndex = 3;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txtPhoneNumber.Location = new Point(300, 438);
            txtPhoneNumber.Margin = new Padding(6, 7, 6, 7);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.ReadOnly = true;
            txtPhoneNumber.Size = new Size(396, 35);
            txtPhoneNumber.TabIndex = 4;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.Control;
            txtAddress.BorderStyle = BorderStyle.FixedSingle;
            txtAddress.Location = new Point(300, 531);
            txtAddress.Margin = new Padding(6, 7, 6, 7);
            txtAddress.Name = "txtAddress";
            txtAddress.ReadOnly = true;
            txtAddress.Size = new Size(396, 35);
            txtAddress.TabIndex = 5;
            // 
            // txtEmail
            // 
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(300, 623);
            txtEmail.Margin = new Padding(6, 7, 6, 7);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(396, 35);
            txtEmail.TabIndex = 6;
            // 
            // btnDeleteAccount
            // 
            btnDeleteAccount.Location = new Point(300, 715);
            btnDeleteAccount.Margin = new Padding(6, 7, 6, 7);
            btnDeleteAccount.Name = "btnDeleteAccount";
            btnDeleteAccount.Size = new Size(400, 69);
            btnDeleteAccount.TabIndex = 7;
            btnDeleteAccount.Text = "Delete Account";
            btnDeleteAccount.UseVisualStyleBackColor = true;
            btnDeleteAccount.Click += btnDeleteAccount_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(28, 28);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(143, 71);
            label1.Name = "label1";
            label1.Size = new Size(113, 30);
            label1.TabIndex = 9;
            label1.Text = "NationalID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(143, 164);
            label2.Name = "label2";
            label2.Size = new Size(113, 30);
            label2.TabIndex = 10;
            label2.Text = "First Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(143, 254);
            label3.Name = "label3";
            label3.Size = new Size(112, 30);
            label3.TabIndex = 11;
            label3.Text = "Last Name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(143, 348);
            label4.Name = "label4";
            label4.Size = new Size(110, 30);
            label4.TabIndex = 12;
            label4.Text = "UserName";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(143, 440);
            label5.Name = "label5";
            label5.Size = new Size(72, 30);
            label5.TabIndex = 13;
            label5.Text = "Phone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(143, 533);
            label6.Name = "label6";
            label6.Size = new Size(87, 30);
            label6.TabIndex = 14;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(143, 625);
            label7.Name = "label7";
            label7.Size = new Size(63, 30);
            label7.TabIndex = 15;
            label7.Text = "Email";
            // 
            // MyAccount
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 923);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNationalID);
            Controls.Add(txtFirstName);
            Controls.Add(txtLastName);
            Controls.Add(txtUsername);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(btnDeleteAccount);
            Margin = new Padding(6, 7, 6, 7);
            Name = "MyAccount";
            Text = "My Account";
            Load += MyAccount_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}