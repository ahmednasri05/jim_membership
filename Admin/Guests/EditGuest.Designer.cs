namespace jim_membership.Admin
{
    partial class EditGuest
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
            memberIDLabel = new Label();
            memberIDComboBox = new ComboBox();
            nationalIDLabel = new Label();
            nationalIDTextBox = new TextBox();
            invitationDateLabel = new Label();
            invitationDatePicker = new DateTimePicker();
            saveButton = new Button();
            cancelButton = new Button();
            SuspendLayout();
            // 
            // memberIDLabel
            // 
            memberIDLabel.AutoSize = true;
            memberIDLabel.Location = new Point(32, 38);
            memberIDLabel.Name = "memberIDLabel";
            memberIDLabel.Size = new Size(69, 15);
            memberIDLabel.TabIndex = 0;
            memberIDLabel.Text = "Member ID:";
            // 
            // memberIDComboBox
            // 
            memberIDComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            memberIDComboBox.FormattingEnabled = true;
            memberIDComboBox.Location = new Point(104, 38);
            memberIDComboBox.Name = "memberIDComboBox";
            memberIDComboBox.Size = new Size(200, 23);
            memberIDComboBox.TabIndex = 1;
            memberIDComboBox.SelectedIndexChanged += memberIDComboBox_SelectedIndexChanged;
            // 
            // nationalIDLabel
            // 
            nationalIDLabel.AutoSize = true;
            nationalIDLabel.Location = new Point(32, 82);
            nationalIDLabel.Name = "nationalIDLabel";
            nationalIDLabel.Size = new Size(69, 15);
            nationalIDLabel.TabIndex = 2;
            nationalIDLabel.Text = "National ID:";
            // 
            // nationalIDTextBox
            // 
            nationalIDTextBox.Location = new Point(104, 79);
            nationalIDTextBox.Name = "nationalIDTextBox";
            nationalIDTextBox.Size = new Size(200, 23);
            nationalIDTextBox.TabIndex = 3;
            // 
            // invitationDateLabel
            // 
            invitationDateLabel.AutoSize = true;
            invitationDateLabel.Location = new Point(12, 126);
            invitationDateLabel.Name = "invitationDateLabel";
            invitationDateLabel.Size = new Size(87, 15);
            invitationDateLabel.TabIndex = 4;
            invitationDateLabel.Text = "Invitation Date:";
            // 
            // invitationDatePicker
            // 
            invitationDatePicker.Location = new Point(104, 120);
            invitationDatePicker.Name = "invitationDatePicker";
            invitationDatePicker.Size = new Size(200, 23);
            invitationDatePicker.TabIndex = 5;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(104, 170);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(75, 23);
            saveButton.TabIndex = 6;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += saveButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.Location = new Point(229, 170);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(75, 23);
            cancelButton.TabIndex = 7;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = true;
            cancelButton.Click += cancelButton_Click;
            // 
            // EditGuest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 211);
            Controls.Add(cancelButton);
            Controls.Add(saveButton);
            Controls.Add(invitationDatePicker);
            Controls.Add(invitationDateLabel);
            Controls.Add(nationalIDTextBox);
            Controls.Add(nationalIDLabel);
            Controls.Add(memberIDComboBox);
            Controls.Add(memberIDLabel);
            Name = "EditGuest";
            Text = "Edit Guest";
            Load += EditGuest_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label memberIDLabel;
        private ComboBox memberIDComboBox;
        private Label nationalIDLabel;
        private TextBox nationalIDTextBox;
        private Label invitationDateLabel;
        private DateTimePicker invitationDatePicker;
        private Button saveButton;
        private Button cancelButton;
    }
}