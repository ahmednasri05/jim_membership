using System;
using System.Windows.Forms;
using jim_membership.models;

namespace jim_membership.Admin
{
    public partial class EditTrainer : Form
    {
        public Trainer Trainer { get; private set; }
        private bool isEditMode;

        public EditTrainer()
        {
            InitializeComponent();
            isEditMode = false;
            Trainer = new Trainer();
            LoadUsers();
        }

        public EditTrainer(Trainer existingTrainer) : this()
        {
            isEditMode = true;
            Trainer = existingTrainer;
            PopulateFields();
        }

        private void LoadUsers()
        {
            try
            {
                var users = User.GetAll();
                userComboBox.DataSource = users;
                userComboBox.DisplayMember = "FullName";
                userComboBox.ValueMember = "NationalID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateFields()
        {
            userComboBox.SelectedValue = Trainer.NationalID;
            txtSalary.Text = Trainer.Salary.ToString();
            dtpStartDate.Value = Trainer.StartDate;
            txtContractType.Text = Trainer.ContractType;
            dtpEndDate.Value = Trainer.EndDate;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                this.DialogResult = DialogResult.None;
                return;
            }

            try
            {
                Trainer.NationalID = (int)userComboBox.SelectedValue;
                Trainer.Salary = int.TryParse(txtSalary.Text, out int salary) ? salary : 0;
                Trainer.StartDate = dtpStartDate.Value;
                Trainer.ContractType = txtContractType.Text;
                Trainer.EndDate = dtpEndDate.Value;

                if (isEditMode)
                {
                    Trainer.Update();
                }
                else
                {
                    Trainer.Create();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving trainer: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }

        private bool ValidateFields()
        {
            if (userComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a user", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtSalary.Text, out _))
            {
                MessageBox.Show("Please enter a valid salary", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtContractType.Text))
            {
                MessageBox.Show("Please enter a contract type", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void EditTrainer_Load(object sender, EventArgs e)
        {
            // Initialization code if needed
        }

        private void EditTrainer_Load_1(object sender, EventArgs e)
        {

        }
    }
}