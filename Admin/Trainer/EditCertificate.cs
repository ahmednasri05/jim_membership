using System;
using System.Windows.Forms;
using jim_membership.models;

namespace jim_membership.Admin
{
    public partial class EditCertificate : Form
    {
        private bool isEditMode = false;
        private Certificate certificate;

        public EditCertificate()
        {
            InitializeComponent();
            certificate = new Certificate();
            btnOK.Click += BtnOK_Click;
        }

        public EditCertificate(string trainerID) : this()
        {
            certificate = Certificate.GetById(trainerID);
            if (certificate == null)
            {
                MessageBox.Show("Certificate not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
            txtCertificateID.Text = certificate.TrainerID.ToString();
            txtCertificateID.ReadOnly = true;
            txtCertificateName.Text = certificate.CertificateName;
            isEditMode = true;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
          
            if (string.IsNullOrWhiteSpace(txtCertificateName.Text))
            {
                MessageBox.Show("Certificate name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }

            certificate.TrainerID = txtCertificateID.Text;
            certificate.CertificateName = txtCertificateName.Text;

            try
            {
                if (isEditMode)
                    certificate.Update();
                else
                    certificate.Create();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving certificate: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }

        private void EditCertificate_Load(object sender, EventArgs e)
        {
        }
    }
}
