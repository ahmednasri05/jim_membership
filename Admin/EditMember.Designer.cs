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
            txtNationalID = new System.Windows.Forms.TextBox();
            txtInBodyUsed = new System.Windows.Forms.TextBox();
            txtFreezeDurationUsed = new System.Windows.Forms.TextBox();
            dtpFirstJoinDate = new System.Windows.Forms.DateTimePicker();
            chkActiveSubscription = new System.Windows.Forms.CheckBox();
            btnOK = new System.Windows.Forms.Button();
            btnCancel = new System.Windows.Forms.Button();
            SuspendLayout();

            // txtNationalID
            txtNationalID.Location = new System.Drawing.Point(30, 20);
            txtNationalID.PlaceholderText = "National ID";
            txtNationalID.Size = new System.Drawing.Size(200, 23);

            // txtInBodyUsed
            txtInBodyUsed.Location = new System.Drawing.Point(30, 50);
            txtInBodyUsed.PlaceholderText = "In Body Used";
            txtInBodyUsed.Size = new System.Drawing.Size(200, 23);

            // txtFreezeDurationUsed
            txtFreezeDurationUsed.Location = new System.Drawing.Point(30, 80);
            txtFreezeDurationUsed.PlaceholderText = "Freeze Duration Used";
            txtFreezeDurationUsed.Size = new System.Drawing.Size(200, 23);

            // dtpFirstJoinDate
            dtpFirstJoinDate.Location = new System.Drawing.Point(30, 110);
            dtpFirstJoinDate.Size = new System.Drawing.Size(200, 23);

            // chkActiveSubscription
            chkActiveSubscription.Location = new System.Drawing.Point(30, 140);
            chkActiveSubscription.Text = "Active Subscription";
            chkActiveSubscription.Size = new System.Drawing.Size(200, 23);

            // btnOK
            btnOK.Location = new System.Drawing.Point(30, 170);
            btnOK.Text = "OK";
            btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnOK.Size = new System.Drawing.Size(75, 23);

            // btnCancel
            btnCancel.Location = new System.Drawing.Point(130, 170);
            btnCancel.Text = "Cancel";
            btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            btnCancel.Size = new System.Drawing.Size(75, 23);

            // EditMember Form setup
            ClientSize = new System.Drawing.Size(270, 220);
            Controls.AddRange(new System.Windows.Forms.Control[]
            {
                txtNationalID, txtInBodyUsed, txtFreezeDurationUsed, dtpFirstJoinDate,
                chkActiveSubscription, btnOK, btnCancel
            });

            Name = "EditMember";
            Text = "Edit Member";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
