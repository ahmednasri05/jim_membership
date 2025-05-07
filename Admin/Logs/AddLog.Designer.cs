namespace jim_membership.Admin.Logs
{
    partial class AddLog
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

        private void InitializeComponent()
        {
            this.memberComboBox = new System.Windows.Forms.ComboBox();
            this.branchComboBox = new System.Windows.Forms.ComboBox();
            this.checkInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.checkOutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // memberComboBox
            this.memberComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.memberComboBox.FormattingEnabled = true;
            this.memberComboBox.Location = new System.Drawing.Point(12, 12);
            this.memberComboBox.Name = "memberComboBox";
            this.memberComboBox.Size = new System.Drawing.Size(260, 21);
            this.memberComboBox.TabIndex = 0;

            // branchComboBox
            this.branchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchComboBox.FormattingEnabled = true;
            this.branchComboBox.Location = new System.Drawing.Point(12, 39);
            this.branchComboBox.Name = "branchComboBox";
            this.branchComboBox.Size = new System.Drawing.Size(260, 21);
            this.branchComboBox.TabIndex = 1;

            // checkInDateTimePicker
            this.checkInDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            this.checkInDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.checkInDateTimePicker.Location = new System.Drawing.Point(12, 66);
            this.checkInDateTimePicker.Name = "checkInDateTimePicker";
            this.checkInDateTimePicker.Size = new System.Drawing.Size(260, 20);
            this.checkInDateTimePicker.TabIndex = 2;

            // checkOutDateTimePicker
            this.checkOutDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            this.checkOutDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.checkOutDateTimePicker.Location = new System.Drawing.Point(12, 92);
            this.checkOutDateTimePicker.Name = "checkOutDateTimePicker";
            this.checkOutDateTimePicker.Size = new System.Drawing.Size(260, 20);
            this.checkOutDateTimePicker.TabIndex = 3;

            // saveButton
            this.saveButton.Location = new System.Drawing.Point(116, 118);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 4;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);

            // cancelButton
            this.cancelButton.Location = new System.Drawing.Point(197, 118);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);

            // AddLog
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 153);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.checkOutDateTimePicker);
            this.Controls.Add(this.checkInDateTimePicker);
            this.Controls.Add(this.branchComboBox);
            this.Controls.Add(this.memberComboBox);
            this.Name = "AddLog";
            this.Text = "Add Log";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox memberComboBox;
        private System.Windows.Forms.ComboBox branchComboBox;
        private System.Windows.Forms.DateTimePicker checkInDateTimePicker;
        private System.Windows.Forms.DateTimePicker checkOutDateTimePicker;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
    }
}