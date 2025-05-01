namespace jim_membership.Admin
{
    partial class EditTrainer
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.TextBox txtContractType;
        private System.Windows.Forms.Label contractTypeLabel;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label endDateLabel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            userLabel = new Label();
            userComboBox = new ComboBox();
            salaryLabel = new Label();
            txtSalary = new TextBox();
            contractTypeLabel = new Label();
            txtContractType = new TextBox();
            startDateLabel = new Label();
            dtpStartDate = new DateTimePicker();
            endDateLabel = new Label();
            dtpEndDate = new DateTimePicker();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(30, 20);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(33, 15);
            userLabel.TabIndex = 0;
            userLabel.Text = "User:";
            // 
            // userComboBox
            // 
            userComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            userComboBox.FormattingEnabled = true;
            userComboBox.Location = new Point(120, 20);
            userComboBox.Name = "userComboBox";
            userComboBox.Size = new Size(200, 23);
            userComboBox.TabIndex = 1;
            // 
            // salaryLabel
            // 
            salaryLabel.AutoSize = true;
            salaryLabel.Location = new Point(30, 50);
            salaryLabel.Name = "salaryLabel";
            salaryLabel.Size = new Size(41, 15);
            salaryLabel.TabIndex = 2;
            salaryLabel.Text = "Salary:";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(120, 50);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(200, 23);
            txtSalary.TabIndex = 3;
            // 
            // contractTypeLabel
            // 
            contractTypeLabel.AutoSize = true;
            contractTypeLabel.Location = new Point(30, 80);
            contractTypeLabel.Name = "contractTypeLabel";
            contractTypeLabel.Size = new Size(83, 15);
            contractTypeLabel.TabIndex = 4;
            contractTypeLabel.Text = "Contract Type:";
            // 
            // txtContractType
            // 
            txtContractType.Location = new Point(120, 80);
            txtContractType.Name = "txtContractType";
            txtContractType.Size = new Size(200, 23);
            txtContractType.TabIndex = 5;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Location = new Point(30, 110);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(61, 15);
            startDateLabel.TabIndex = 6;
            startDateLabel.Text = "Start Date:";
            // 
            // dtpStartDate
            // 
            dtpStartDate.Location = new Point(120, 110);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(200, 23);
            dtpStartDate.TabIndex = 7;
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Location = new Point(30, 140);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(57, 15);
            endDateLabel.TabIndex = 8;
            endDateLabel.Text = "End Date:";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Location = new Point(120, 140);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(200, 23);
            dtpEndDate.TabIndex = 9;
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(120, 170);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 10;
            btnOK.Text = "OK";
            btnOK.Click += BtnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(220, 170);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Cancel";
            // 
            // EditTrainer
            // 
            ClientSize = new Size(350, 220);
            Controls.Add(userLabel);
            Controls.Add(userComboBox);
            Controls.Add(salaryLabel);
            Controls.Add(txtSalary);
            Controls.Add(contractTypeLabel);
            Controls.Add(txtContractType);
            Controls.Add(startDateLabel);
            Controls.Add(dtpStartDate);
            Controls.Add(endDateLabel);
            Controls.Add(dtpEndDate);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Name = "EditTrainer";
            Text = "Edit Trainer";
            Load += EditTrainer_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}