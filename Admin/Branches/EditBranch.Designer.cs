namespace jim_membership.Admin
{
    partial class EditBranch
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            branchNoLabel = new Label();
            branchNoTextBox = new TextBox();
            managerLabel = new Label();
            managerComboBox = new ComboBox();
            phoneNumberLabel = new Label();
            phoneNumberTextBox = new TextBox();
            addressLabel = new Label();
            addressTextBox = new TextBox();
            branchNameLabel = new Label();
            branchNameTextBox = new TextBox();
            saveButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // branchNoLabel
            // 
            branchNoLabel.AutoSize = true;
            branchNoLabel.Location = new Point(32, 28);
            branchNoLabel.Name = "branchNoLabel";
            branchNoLabel.Size = new Size(66, 15);
            branchNoLabel.TabIndex = 0;
            branchNoLabel.Text = "Branch No:";
            // 
            // branchNoTextBox
            // 
            branchNoTextBox.Location = new Point(104, 25);
            branchNoTextBox.Name = "branchNoTextBox";
            branchNoTextBox.Size = new Size(200, 23);
            branchNoTextBox.TabIndex = 1;
            // 
            // managerLabel
            // 
            managerLabel.AutoSize = true;
            managerLabel.Location = new Point(44, 68);
            managerLabel.Name = "managerLabel";
            managerLabel.Size = new Size(57, 15);
            managerLabel.TabIndex = 2;
            managerLabel.Text = "Manager:";
            // 
            // managerComboBox
            // 
            managerComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            managerComboBox.FormattingEnabled = true;
            managerComboBox.Location = new Point(104, 65);
            managerComboBox.Name = "managerComboBox";
            managerComboBox.Size = new Size(200, 23);
            managerComboBox.TabIndex = 3;
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.Location = new Point(12, 108);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(91, 15);
            phoneNumberLabel.TabIndex = 4;
            phoneNumberLabel.Text = "Phone Number:";
            // 
            // phoneNumberTextBox
            // 
            phoneNumberTextBox.Location = new Point(104, 105);
            phoneNumberTextBox.Name = "phoneNumberTextBox";
            phoneNumberTextBox.Size = new Size(200, 23);
            phoneNumberTextBox.TabIndex = 5;
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(48, 148);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(52, 15);
            addressLabel.TabIndex = 6;
            addressLabel.Text = "Address:";
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(104, 145);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(200, 23);
            addressTextBox.TabIndex = 7;
            // 
            // branchNameLabel
            // 
            branchNameLabel.AutoSize = true;
            branchNameLabel.Location = new Point(24, 188);
            branchNameLabel.Name = "branchNameLabel";
            branchNameLabel.Size = new Size(82, 15);
            branchNameLabel.TabIndex = 8;
            branchNameLabel.Text = "Branch Name:";
            // 
            // branchNameTextBox
            // 
            branchNameTextBox.Location = new Point(104, 185);
            branchNameTextBox.Name = "branchNameTextBox";
            branchNameTextBox.Size = new Size(200, 23);
            branchNameTextBox.TabIndex = 9;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(104, 225);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 10;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(229, 225);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 11;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // EditBranch
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 265);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(branchNameTextBox);
            Controls.Add(branchNameLabel);
            Controls.Add(addressTextBox);
            Controls.Add(addressLabel);
            Controls.Add(phoneNumberTextBox);
            Controls.Add(phoneNumberLabel);
            Controls.Add(managerComboBox);
            Controls.Add(managerLabel);
            Controls.Add(branchNoTextBox);
            Controls.Add(branchNoLabel);
            Name = "EditBranch";
            Text = "Edit Branch";
            Load += EditBranch_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label branchNoLabel;
        private TextBox branchNoTextBox;
        private Label managerLabel;
        private ComboBox managerComboBox;
        private Label phoneNumberLabel;
        private TextBox phoneNumberTextBox;
        private Label addressLabel;
        private TextBox addressTextBox;
        private Label branchNameLabel;
        private TextBox branchNameTextBox;
        private Button saveButton;
        private Button cancelButton;
    }
}
