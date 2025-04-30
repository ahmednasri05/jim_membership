using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;
using jim_membership.models;
using System.Collections.Generic;

namespace jim_membership.Admin
{
    public partial class EditBranch : Form
    {
        private Branch _branch;
        private bool _isEditMode;
        private List<User> _users;

        public EditBranch()
        {
            InitializeComponent();
            _isEditMode = false;
            LoadUsers();
        }

        public EditBranch(Branch branch) : this()
        {
            _branch = branch;
            _isEditMode = true;
            PopulateFields();
        }

        private void LoadUsers()
        {
            try
            {
                _users = User.GetAll();
                managerComboBox.DataSource = _users;
                managerComboBox.DisplayMember = "FullName";
                managerComboBox.ValueMember = "NationalID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateFields()
        {
            branchNoTextBox.Text = _branch.BranchNo.ToString();
            phoneNumberTextBox.Text = _branch.PhoneNumber.ToString();
            addressTextBox.Text = _branch.Address;
            branchNameTextBox.Text = _branch.BranchName;



        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            try
            {
                if (_isEditMode)
                {
                    _branch.BranchNo = int.Parse(branchNoTextBox.Text);
                    _branch.ManagerID = ((User)managerComboBox.SelectedItem).NationalID;
                    _branch.PhoneNumber = int.Parse(phoneNumberTextBox.Text);
                    _branch.Address = addressTextBox.Text;
                    _branch.BranchName = branchNameTextBox.Text;
                    _branch.Update();
                }
                else
                {
                    var newBranch = new Branch
                    {
                        BranchNo = int.Parse(branchNoTextBox.Text),
                        ManagerID = ((User)managerComboBox.SelectedItem).NationalID,
                        PhoneNumber = int.Parse(phoneNumberTextBox.Text),
                        Address = addressTextBox.Text,
                        BranchName = branchNameTextBox.Text
                    };
                    newBranch.Create();
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving branch: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateFields()
        {
            if (!int.TryParse(branchNoTextBox.Text, out _))
            {
                MessageBox.Show("Please enter a valid Branch Number", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (managerComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a manager", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(phoneNumberTextBox.Text, out _))
            {
                MessageBox.Show("Please enter a valid Phone Number", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                MessageBox.Show("Please enter an address", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(branchNameTextBox.Text))
            {
                MessageBox.Show("Please enter a branch name", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void EditBranch_Load(object sender, EventArgs e)
        {

        }
    }
}