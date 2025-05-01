namespace jim_membership.Admin
{
    partial class EditSubscription
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtSubscriptionID;
        private System.Windows.Forms.Label lblSubscriptionID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtNoOfSessions;
        private System.Windows.Forms.Label lblNoOfSessions;
        private System.Windows.Forms.TextBox txtInBody;
        private System.Windows.Forms.Label lblInBody;
        private System.Windows.Forms.TextBox txtPrivateSessions;
        private System.Windows.Forms.Label lblPrivateSessions;
        private System.Windows.Forms.TextBox dtpFreeDuration;
        private System.Windows.Forms.Label lblFreeDuration;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtSubscriptionID = new TextBox();
            lblSubscriptionID = new Label();
            txtName = new TextBox();
            lblName = new Label();
            txtAmount = new TextBox();
            lblAmount = new Label();
            txtNoOfSessions = new TextBox();
            lblNoOfSessions = new Label();
            txtInBody = new TextBox();
            lblInBody = new Label();
            txtPrivateSessions = new TextBox();
            lblPrivateSessions = new Label();
            dtpFreeDuration = new TextBox();
            lblFreeDuration = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtSubscriptionID
            // 
            txtSubscriptionID.Location = new Point(120, 20);
            txtSubscriptionID.Name = "txtSubscriptionID";
            txtSubscriptionID.Size = new Size(200, 23);
            txtSubscriptionID.TabIndex = 1;
            // 
            // lblSubscriptionID
            // 
            lblSubscriptionID.AutoSize = true;
            lblSubscriptionID.Location = new Point(30, 23);
            lblSubscriptionID.Name = "lblSubscriptionID";
            lblSubscriptionID.Size = new Size(90, 15);
            lblSubscriptionID.TabIndex = 0;
            lblSubscriptionID.Text = "Subscription ID:";
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 23);
            txtName.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(30, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(120, 80);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(200, 23);
            txtAmount.TabIndex = 5;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(30, 83);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(54, 15);
            lblAmount.TabIndex = 4;
            lblAmount.Text = "Amount:";
            // 
            // txtNoOfSessions
            // 
            txtNoOfSessions.Location = new Point(120, 110);
            txtNoOfSessions.Name = "txtNoOfSessions";
            txtNoOfSessions.Size = new Size(200, 23);
            txtNoOfSessions.TabIndex = 7;
            // 
            // lblNoOfSessions
            // 
            lblNoOfSessions.AutoSize = true;
            lblNoOfSessions.Location = new Point(30, 113);
            lblNoOfSessions.Name = "lblNoOfSessions";
            lblNoOfSessions.Size = new Size(90, 15);
            lblNoOfSessions.TabIndex = 6;
            lblNoOfSessions.Text = "No. of Sessions:";
            // 
            // txtInBody
            // 
            txtInBody.Location = new Point(120, 140);
            txtInBody.Name = "txtInBody";
            txtInBody.Size = new Size(200, 23);
            txtInBody.TabIndex = 9;
            // 
            // lblInBody
            // 
            lblInBody.AutoSize = true;
            lblInBody.Location = new Point(30, 143);
            lblInBody.Name = "lblInBody";
            lblInBody.Size = new Size(50, 15);
            lblInBody.TabIndex = 8;
            lblInBody.Text = "In Body:";
            // 
            // txtPrivateSessions
            // 
            txtPrivateSessions.Location = new Point(120, 170);
            txtPrivateSessions.Name = "txtPrivateSessions";
            txtPrivateSessions.Size = new Size(200, 23);
            txtPrivateSessions.TabIndex = 11;
            // 
            // lblPrivateSessions
            // 
            lblPrivateSessions.AutoSize = true;
            lblPrivateSessions.Location = new Point(30, 173);
            lblPrivateSessions.Name = "lblPrivateSessions";
            lblPrivateSessions.Size = new Size(93, 15);
            lblPrivateSessions.TabIndex = 10;
            lblPrivateSessions.Text = "Private Sessions:";
            // 
            // dtpFreeDuration
            // 
            dtpFreeDuration.Location = new Point(120, 200);
            dtpFreeDuration.Name = "dtpFreeDuration";
            dtpFreeDuration.Size = new Size(200, 23);
            dtpFreeDuration.TabIndex = 13;
            // 
            // lblFreeDuration
            // 
            lblFreeDuration.AutoSize = true;
            lblFreeDuration.Location = new Point(30, 203);
            lblFreeDuration.Name = "lblFreeDuration";
            lblFreeDuration.Size = new Size(81, 15);
            lblFreeDuration.TabIndex = 12;
            lblFreeDuration.Text = "Freeze Duration:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(120, 230);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(200, 60);
            txtDescription.TabIndex = 15;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(30, 233);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(70, 15);
            lblDescription.TabIndex = 14;
            lblDescription.Text = "Description:";
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(120, 300);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 16;
            btnOK.Text = "OK";
            btnOK.Click += BtnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(220, 300);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            // 
            // EditSubscription
            // 
            ClientSize = new Size(350, 340);
            Controls.Add(lblSubscriptionID);
            Controls.Add(txtSubscriptionID);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblAmount);
            Controls.Add(txtAmount);
            Controls.Add(lblNoOfSessions);
            Controls.Add(txtNoOfSessions);
            Controls.Add(lblInBody);
            Controls.Add(txtInBody);
            Controls.Add(lblPrivateSessions);
            Controls.Add(txtPrivateSessions);
            Controls.Add(lblFreeDuration);
            Controls.Add(dtpFreeDuration);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Name = "EditSubscription";
            Text = "Edit Subscription";
            Load += EditSubscription_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}