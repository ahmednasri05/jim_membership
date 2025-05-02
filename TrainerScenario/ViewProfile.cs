using jim_membership.models;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jim_membership.TrainerScenario
{
    public partial class ViewProfile : Form
    {
        public ViewProfile()
        {
            InitializeComponent();
            PopulateLabels();
            DisplayCertificates();
        }

        private void PopulateLabels()
        {
            try
            {
                var tr = Trainer.GetById(ProgramSession.Instance.UserId);
                var ur = User.GetById(ProgramSession.Instance.UserId);

                lbNationalIDInput.Text = ProgramSession.Instance.UserId;
                lbNameInput.Text = ur.FName + " " + ur.LName;
                lbUsernameInput.Text = ur.Username;
                lbNumberInput.Text = ur.PhoneNumber;
                lbAddressInput.Text = ur.Address;
                lbEmailInput.Text = ur.Email;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error populating form labels: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ViewProfile_Load(object sender, EventArgs e)
        {
            PopulateLabels();
            DisplayCertificates();
        }

        private void lbNationalIDInput_Click(object sender, EventArgs e)
        {

        }

        private void DisplayCertificates()
        {

            try
            {
                var UserCerteficates = CertificatesModel.GetByTrainerID(ProgramSession.Instance.UserId);
                dgvCert.DataSource = UserCerteficates;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error loading sessions: " + e.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCreateNew_Click(object sender, EventArgs e)
        {
            var form = new CreateCerteficate();
            if (form.ShowDialog() == DialogResult.OK)
            {
                DisplayCertificates();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvCert.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a session to edit", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (models.CertificatesModel)dgvCert.SelectedRows[0].DataBoundItem;
            var form = new EditCertificate(selected);
            if (form.ShowDialog() == DialogResult.OK)
            {
                DisplayCertificates();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvCert.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a session to delete", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (models.CertificatesModel)dgvCert.SelectedRows[0].DataBoundItem;
            var result = MessageBox.Show($"Are you sure you want to delete {selected.trainerID} - {selected.Certificate}?", "Delete Session",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                try
                {
                    models.CertificatesModel.Delete(selected.Certificate);
                    DisplayCertificates();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting session: " + ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvCert_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvCert_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
