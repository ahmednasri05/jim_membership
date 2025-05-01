using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace jim_membership.Admin
{
    partial class EditMember
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.TextBox txtNationalID;
        private System.Windows.Forms.TextBox txtInBodyUsed;
        private System.Windows.Forms.TextBox txtFreezeDurationUsed;
        private System.Windows.Forms.DateTimePicker dtpFirstJoinDate;
        private System.Windows.Forms.CheckBox chkActiveSubscription;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtNationalID = new TextBox();
            txtInBodyUsed = new TextBox();
            txtFreezeDurationUsed = new TextBox();
            dtpFirstJoinDate = new DateTimePicker();
            chkActiveSubscription = new CheckBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtNationalID
            // 
            txtNationalID.Location = new Point(30, 20);
            txtNationalID.Name = "txtNationalID";
            txtNationalID.PlaceholderText = "National ID";
            txtNationalID.Size = new Size(200, 23);
            txtNationalID.TabIndex = 0;
            // 
            // txtInBodyUsed
            // 
            txtInBodyUsed.Location = new Point(30, 50);
            txtInBodyUsed.Name = "txtInBodyUsed";
            txtInBodyUsed.PlaceholderText = "In Body Used";
            txtInBodyUsed.Size = new Size(200, 23);
            txtInBodyUsed.TabIndex = 1;
            // 
            // txtFreezeDurationUsed
            // 
            txtFreezeDurationUsed.Location = new Point(30, 80);
            txtFreezeDurationUsed.Name = "txtFreezeDurationUsed";
            txtFreezeDurationUsed.PlaceholderText = "Freeze Duration Used";
            txtFreezeDurationUsed.Size = new Size(200, 23);
            txtFreezeDurationUsed.TabIndex = 2;
            // 
            // dtpFirstJoinDate
            // 
            dtpFirstJoinDate.Location = new Point(30, 110);
            dtpFirstJoinDate.Name = "dtpFirstJoinDate";
            dtpFirstJoinDate.Size = new Size(200, 23);
            dtpFirstJoinDate.TabIndex = 3;
            // 
            // chkActiveSubscription
            // 
            chkActiveSubscription.Location = new Point(30, 140);
            chkActiveSubscription.Name = "chkActiveSubscription";
            chkActiveSubscription.Size = new Size(200, 23);
            chkActiveSubscription.TabIndex = 4;
            chkActiveSubscription.Text = "Active Subscription";
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(30, 170);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 5;
            btnOK.Text = "OK";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(130, 170);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            // 
            // EditMember
            // 
            ClientSize = new Size(270, 220);
            Controls.Add(txtNationalID);
            Controls.Add(txtInBodyUsed);
            Controls.Add(txtFreezeDurationUsed);
            Controls.Add(dtpFirstJoinDate);
            Controls.Add(chkActiveSubscription);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Name = "EditMember";
            Text = "Edit Member";
            Load += EditMember_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
