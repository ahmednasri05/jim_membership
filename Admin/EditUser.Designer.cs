namespace jim_membership.Admin
{
    partial class EditUser
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtNationalID = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // txtNationalID
            this.txtNationalID.Location = new System.Drawing.Point(30, 20);
            this.txtNationalID.Name = "txtNationalID";
            this.txtNationalID.PlaceholderText = "National ID";
            this.txtNationalID.Size = new System.Drawing.Size(200, 23);

            // txtFName
            this.txtFName.Location = new System.Drawing.Point(30, 60);
            this.txtFName.Name = "txtFName";
            this.txtFName.PlaceholderText = "First Name";
            this.txtFName.Size = new System.Drawing.Size(200, 23);

            // txtLName
            this.txtLName.Location = new System.Drawing.Point(30, 100);
            this.txtLName.Name = "txtLName";
            this.txtLName.PlaceholderText = "Last Name";
            this.txtLName.Size = new System.Drawing.Size(200, 23);

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(30, 140);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.Size = new System.Drawing.Size(200, 23);

            // btnOK
            this.btnOK.Location = new System.Drawing.Point(30, 180);
            this.btnOK.Name = "btnOK";
            this.btnOK.Text = "OK";
            this.btnOK.DialogResult = DialogResult.OK;

            // btnCancel
            this.btnCancel.Location = new System.Drawing.Point(130, 180);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Text = "Cancel";
            this.btnCancel.DialogResult = DialogResult.Cancel;

            // UserForm
            this.ClientSize = new System.Drawing.Size(260, 230);
            this.Controls.Add(txtNationalID);
            this.Controls.Add(txtFName);
            this.Controls.Add(txtLName);
            this.Controls.Add(txtEmail);
            this.Controls.Add(btnOK);
            this.Controls.Add(btnCancel);
            this.Name = "UserForm";
            this.Text = "User Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
