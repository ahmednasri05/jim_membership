namespace jim_membership.TrainerScenario
{
    partial class ViewProfile
    {
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
            dgvCert = new DataGridView();
            btnCreateNew = new Button();
            btnDelete = new Button();
            label1 = new Label();
            lbNationalID = new Label();
            lbName = new Label();
            lbUsername = new Label();
            lbEmail = new Label();
            lbAddress = new Label();
            lbPhoneNumber = new Label();
            lbNumberInput = new Label();
            lbAddressInput = new Label();
            lbEmailInput = new Label();
            lbUsernameInput = new Label();
            lbNameInput = new Label();
            lbNationalIDInput = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvCert).BeginInit();
            SuspendLayout();
            // 
            // dgvCert
            // 
            dgvCert.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCert.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCert.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCert.Location = new Point(7, 348);
            dgvCert.MultiSelect = false;
            dgvCert.Name = "dgvCert";
            dgvCert.RowHeadersVisible = false;
            dgvCert.RowTemplate.Height = 25;
            dgvCert.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCert.Size = new Size(420, 318);
            dgvCert.TabIndex = 12;
            dgvCert.CellContentClick += dgvCert_CellContentClick_1;
            // 
            // btnCreateNew
            // 
            btnCreateNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCreateNew.Location = new Point(12, 283);
            btnCreateNew.Name = "btnCreateNew";
            btnCreateNew.Size = new Size(112, 32);
            btnCreateNew.TabIndex = 11;
            btnCreateNew.Text = "New";
            btnCreateNew.UseVisualStyleBackColor = true;
            btnCreateNew.Click += btnCreateNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDelete.Location = new Point(296, 283);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 32);
            btnDelete.TabIndex = 9;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ImageAlign = ContentAlignment.MiddleRight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(434, 52);
            label1.TabIndex = 13;
            label1.Text = "Profile";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbNationalID
            // 
            lbNationalID.ImageAlign = ContentAlignment.MiddleLeft;
            lbNationalID.Location = new Point(66, 61);
            lbNationalID.Name = "lbNationalID";
            lbNationalID.Size = new Size(100, 22);
            lbNationalID.TabIndex = 14;
            lbNationalID.Text = "National ID";
            lbNationalID.TextAlign = ContentAlignment.MiddleLeft;
            lbNationalID.Click += label2_Click;
            // 
            // lbName
            // 
            lbName.ImageAlign = ContentAlignment.MiddleLeft;
            lbName.Location = new Point(66, 93);
            lbName.Name = "lbName";
            lbName.Size = new Size(100, 22);
            lbName.TabIndex = 15;
            lbName.Text = "Name";
            lbName.TextAlign = ContentAlignment.MiddleLeft;
            lbName.Click += label2_Click_1;
            // 
            // lbUsername
            // 
            lbUsername.ImageAlign = ContentAlignment.MiddleLeft;
            lbUsername.Location = new Point(66, 128);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(100, 22);
            lbUsername.TabIndex = 16;
            lbUsername.Text = "Username";
            lbUsername.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbEmail
            // 
            lbEmail.ImageAlign = ContentAlignment.MiddleLeft;
            lbEmail.Location = new Point(66, 162);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(100, 22);
            lbEmail.TabIndex = 17;
            lbEmail.Text = "Email";
            lbEmail.TextAlign = ContentAlignment.MiddleLeft;
            lbEmail.Click += label4_Click;
            // 
            // lbAddress
            // 
            lbAddress.ImageAlign = ContentAlignment.MiddleLeft;
            lbAddress.Location = new Point(66, 193);
            lbAddress.Name = "lbAddress";
            lbAddress.Size = new Size(100, 22);
            lbAddress.TabIndex = 18;
            lbAddress.Text = "Address";
            lbAddress.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbPhoneNumber
            // 
            lbPhoneNumber.ImageAlign = ContentAlignment.MiddleLeft;
            lbPhoneNumber.Location = new Point(66, 228);
            lbPhoneNumber.Name = "lbPhoneNumber";
            lbPhoneNumber.Size = new Size(100, 22);
            lbPhoneNumber.TabIndex = 19;
            lbPhoneNumber.Text = "number";
            lbPhoneNumber.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbNumberInput
            // 
            lbNumberInput.ImageAlign = ContentAlignment.MiddleLeft;
            lbNumberInput.Location = new Point(202, 228);
            lbNumberInput.Name = "lbNumberInput";
            lbNumberInput.Size = new Size(165, 22);
            lbNumberInput.TabIndex = 25;
            lbNumberInput.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbAddressInput
            // 
            lbAddressInput.ImageAlign = ContentAlignment.MiddleLeft;
            lbAddressInput.Location = new Point(202, 193);
            lbAddressInput.Name = "lbAddressInput";
            lbAddressInput.Size = new Size(165, 22);
            lbAddressInput.TabIndex = 24;
            lbAddressInput.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbEmailInput
            // 
            lbEmailInput.ImageAlign = ContentAlignment.MiddleLeft;
            lbEmailInput.Location = new Point(202, 162);
            lbEmailInput.Name = "lbEmailInput";
            lbEmailInput.Size = new Size(165, 22);
            lbEmailInput.TabIndex = 23;
            lbEmailInput.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbUsernameInput
            // 
            lbUsernameInput.ImageAlign = ContentAlignment.MiddleLeft;
            lbUsernameInput.Location = new Point(202, 128);
            lbUsernameInput.Name = "lbUsernameInput";
            lbUsernameInput.Size = new Size(165, 22);
            lbUsernameInput.TabIndex = 22;
            lbUsernameInput.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbNameInput
            // 
            lbNameInput.ImageAlign = ContentAlignment.MiddleLeft;
            lbNameInput.Location = new Point(202, 93);
            lbNameInput.Name = "lbNameInput";
            lbNameInput.Size = new Size(165, 22);
            lbNameInput.TabIndex = 21;
            lbNameInput.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lbNationalIDInput
            // 
            lbNationalIDInput.ImageAlign = ContentAlignment.MiddleLeft;
            lbNationalIDInput.Location = new Point(202, 61);
            lbNationalIDInput.Name = "lbNationalIDInput";
            lbNationalIDInput.Size = new Size(165, 22);
            lbNationalIDInput.TabIndex = 20;
            lbNationalIDInput.TextAlign = ContentAlignment.MiddleLeft;
            lbNationalIDInput.Click += lbNationalIDInput_Click;
            // 
            // ViewProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 678);
            Controls.Add(lbNumberInput);
            Controls.Add(lbAddressInput);
            Controls.Add(lbEmailInput);
            Controls.Add(lbUsernameInput);
            Controls.Add(lbNameInput);
            Controls.Add(lbNationalIDInput);
            Controls.Add(lbPhoneNumber);
            Controls.Add(lbAddress);
            Controls.Add(lbEmail);
            Controls.Add(lbUsername);
            Controls.Add(lbName);
            Controls.Add(lbNationalID);
            Controls.Add(label1);
            Controls.Add(dgvCert);
            Controls.Add(btnCreateNew);
            Controls.Add(btnDelete);
            Name = "ViewProfile";
            Text = "ViewProfile";
            Load += ViewProfile_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCert).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCert;
        private Button btnCreateNew;
        private Button btnDelete;
        private Button btnEdit;
        private Label label1;
        private Label lbNationalID;
        private Label lbName;
        private Label lbUsername;
        private Label lbEmail;
        private Label lbAddress;
        private Label lbPhoneNumber;
        private Label lbNumberInput;
        private Label lbAddressInput;
        private Label lbEmailInput;
        private Label lbUsernameInput;
        private Label lbNameInput;
        private Label lbNationalIDInput;
    }
}