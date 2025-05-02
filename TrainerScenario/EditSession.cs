using jim_membership.models;
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
    public partial class EditSession : Form
    {
        public EditSession(Session selected)
        {
            InitializeComponent();
            PopulateLabels(selected);
        }

        private void PopulateLabels(Session selected)
        {
            try
            {
                lbSessionNumber.Text = selected.sessionNo;
                lbTrainerName.Text = selected.trainerID;
                lbSessionNumber.Text = selected.sessionNo;
                dtpDate.Value = selected.date;
                nudDuration.Value = (int)selected.duration;
                txtDescription.Text = selected.description;
                txtType.Text = selected.Type;
                txtDescription.Text = selected.description;
                nudMaxAtt.Value = selected.maxNumber;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error populating form labels: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbSessionNo.Text = "Error";
                lbTrainerName.Text = "Error";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbSessionNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
