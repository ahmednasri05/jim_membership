using System;
using System.Windows.Forms;
using jim_membership.models;

namespace jim_membership.Admin
{
    public partial class TrainerCrud : Form
    {
        public TrainerCrud()
        {
            InitializeComponent();
            LoadTrainers();
        }

        private void LoadTrainers()
        {
            try
            {
                var trainers = Trainer.GetAll();
                TrainersGridView.DataSource = trainers;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading trainers: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddTrainerBtn_Click(object sender, EventArgs e)
        {
            var form = new EditTrainer();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadTrainers();
            }
        }

        private void EditTrainerBtn_Click(object sender, EventArgs e)
        {
            if (TrainersGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a trainer to edit", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (Trainer)TrainersGridView.SelectedRows[0].DataBoundItem;
            var form = new EditTrainer(selected);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadTrainers();
            }
        }

        private void DeleteTrainerBtn_Click(object sender, EventArgs e)
        {
            if (TrainersGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a trainer to delete", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (Trainer)TrainersGridView.SelectedRows[0].DataBoundItem;
            Trainer.Delete(selected.NationalID);
            LoadTrainers();
        }

        private void TrainersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Optional: Handle cell click events if needed
        }
    }
}