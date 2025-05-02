namespace jim_membership.Admin
{
    partial class EditSubscription
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtSubscriptionID;
        private Label lblSubscriptionID;
        private TextBox txtName;
        private Label lblName;
        private TextBox txtAmount;
        private Label lblAmount;
        private TextBox txtNoOfSessions;
        private Label lblNoOfSessions;
        private TextBox txtInBody;
        private Label lblInBody;
        private TextBox txtPrivateSessions;
        private Label lblPrivateSessions;
        private TextBox dtpFreeDuration;
        private Label lblFreeDuration;
        private TextBox txtDescription;
        private Label lblDescription;
        private Button btnOK;
        private Button btnCancel;

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
            txtSubscriptionID.Location = new Point(195, 20);
            txtSubscriptionID.Name = "txtSubscriptionID";
            txtSubscriptionID.Size = new Size(200, 35);
            txtSubscriptionID.TabIndex = 1;
            txtSubscriptionID.TextChanged += txtSubscriptionID_TextChanged;
            // 
            // lblSubscriptionID
            // 
            lblSubscriptionID.AutoSize = true;
            lblSubscriptionID.Location = new Point(30, 23);
            lblSubscriptionID.Name = "lblSubscriptionID";
            lblSubscriptionID.Size = new Size(159, 30);
            lblSubscriptionID.TabIndex = 0;
            lblSubscriptionID.Text = "Subscription ID:";
            // 
            // txtName
            // 
            txtName.Location = new Point(120, 50);
            txtName.Name = "txtName";
            txtName.Size = new Size(200, 35);
            txtName.TabIndex = 3;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(30, 53);
            lblName.Name = "lblName";
            lblName.Size = new Size(74, 30);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(120, 83);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(200, 35);
            txtAmount.TabIndex = 5;
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(30, 83);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(93, 30);
            lblAmount.TabIndex = 4;
            lblAmount.Text = "Amount:";
            // 
            // txtNoOfSessions
            // 
            txtNoOfSessions.Location = new Point(195, 113);
            txtNoOfSessions.Name = "txtNoOfSessions";
            txtNoOfSessions.Size = new Size(200, 35);
            txtNoOfSessions.TabIndex = 7;
            // 
            // lblNoOfSessions
            // 
            lblNoOfSessions.AutoSize = true;
            lblNoOfSessions.Location = new Point(30, 113);
            lblNoOfSessions.Name = "lblNoOfSessions";
            lblNoOfSessions.Size = new Size(160, 30);
            lblNoOfSessions.TabIndex = 6;
            lblNoOfSessions.Text = "No. of Sessions:";
            // 
            // txtInBody
            // 
            txtInBody.Location = new Point(120, 140);
            txtInBody.Name = "txtInBody";
            txtInBody.Size = new Size(200, 35);
            txtInBody.TabIndex = 9;
            // 
            // lblInBody
            // 
            lblInBody.AutoSize = true;
            lblInBody.Location = new Point(30, 143);
            lblInBody.Name = "lblInBody";
            lblInBody.Size = new Size(88, 30);
            lblInBody.TabIndex = 8;
            lblInBody.Text = "In Body:";
            // 
            // txtPrivateSessions
            // 
            txtPrivateSessions.Location = new Point(195, 173);
            txtPrivateSessions.Name = "txtPrivateSessions";
            txtPrivateSessions.Size = new Size(200, 35);
            txtPrivateSessions.TabIndex = 11;
            txtPrivateSessions.TextChanged += txtPrivateSessions_TextChanged;
            // 
            // lblPrivateSessions
            // 
            lblPrivateSessions.AutoSize = true;
            lblPrivateSessions.Location = new Point(30, 178);
            lblPrivateSessions.Name = "lblPrivateSessions";
            lblPrivateSessions.Size = new Size(165, 30);
            lblPrivateSessions.TabIndex = 10;
            lblPrivateSessions.Text = "Private Sessions:";
            // 
            // dtpFreeDuration
            // 
            dtpFreeDuration.Location = new Point(195, 214);
            dtpFreeDuration.Name = "dtpFreeDuration";
            dtpFreeDuration.Size = new Size(200, 35);
            dtpFreeDuration.TabIndex = 13;
            // 
            // lblFreeDuration
            // 
            lblFreeDuration.AutoSize = true;
            lblFreeDuration.Location = new Point(24, 214);
            lblFreeDuration.Name = "lblFreeDuration";
            lblFreeDuration.Size = new Size(165, 30);
            lblFreeDuration.TabIndex = 12;
            lblFreeDuration.Text = "Freeze Duration:";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(159, 241);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(199, 34);
            txtDescription.TabIndex = 15;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(30, 244);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(123, 30);
            lblDescription.TabIndex = 14;
            lblDescription.Text = "Description:";
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(120, 300);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 45);
            btnOK.TabIndex = 16;
            btnOK.Text = "OK";
            btnOK.Click += BtnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(220, 300);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 45);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Cancel";
            // 
            // EditSubscription
            // 
            ClientSize = new Size(435, 357);
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