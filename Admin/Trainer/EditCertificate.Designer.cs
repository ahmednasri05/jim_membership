using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace jim_membership.Admin
{
    partial class EditCertificate
    {
        private System.ComponentModel.IContainer components = null;

        private TextBox txtCertificateID;
        private TextBox txtCertificateName;
        private Button btnOK;
        private Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            txtCertificateID = new TextBox();
            txtCertificateName = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtCertificateID
            // 
            txtCertificateID.Location = new Point(30, 20);
            txtCertificateID.Name = "txtCertificateID";
            txtCertificateID.PlaceholderText = "Certificate ID";
            txtCertificateID.Size = new Size(200, 23);
            // 
            // txtCertificateName
            // 
            txtCertificateName.Location = new Point(30, 60);
            txtCertificateName.Name = "txtCertificateName";
            txtCertificateName.PlaceholderText = "Certificate Name";
            txtCertificateName.Size = new Size(200, 23);
            // 
            // btnOK
            // 
            btnOK.DialogResult = DialogResult.OK;
            btnOK.Location = new Point(30, 100);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.Text = "Save";
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(130, 100);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.Text = "Cancel";
            // 
            // EditCertificate
            // 
            ClientSize = new Size(270, 150);
            Controls.Add(txtCertificateID);
            Controls.Add(txtCertificateName);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Name = "EditCertificate";
            Text = "Edit Certificate";
            Load += EditCertificate_Load;
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
