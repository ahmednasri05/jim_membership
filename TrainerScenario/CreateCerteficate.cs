﻿using jim_membership.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace jim_membership.TrainerScenario
{
    public partial class CreateCerteficate : Form
    {
        public CreateCerteficate()
        {
            InitializeComponent();
            PopulateLabels();
        }

        private void PopulateLabels()
        {
            try
            {
                lbTrainerIDInput.Text = ProgramSession.Instance.UserId;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error populating form labels: {ex.Message}", "Initialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lbTrainerIDInput_Click(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string CertificateDes = txtDescription.Text;

                if (string.IsNullOrWhiteSpace(CertificateDes))
                {
                    MessageBox.Show("Please Insert a Desciprtion", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDescription.Focus();
                    return;
                }

                var Cert = new models.CertificatesModel
                {
                    trainerID = ProgramSession.Instance.UserId,
                    Certificate = CertificateDes
                };

                Cert.Create();
                MessageBox.Show("Session created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                this.DialogResult = DialogResult.OK; // Indicate success if opened as dialog
                this.Close();

            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Error formatting data: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred while saving: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void CreateCerteficate_Load(object sender, EventArgs e)
        {
            PopulateLabels();
        }
    }
}
