using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using jim_membership.models;

namespace jim_membership.Admin
{
    public partial class Branches : Form
    {
        public Branches()
        {
            InitializeComponent();
            LoadBranches();
            if (ProgramSession.Instance.UserRole != "Admin")
            {
                edit.Visible = false; // Hide the Edit button
                DeleteBTn.Visible = false; // Hide the Delete button
                AddBranch.Visible = false; // Hide the Add button
            }
        }
        public void LoadBranches()
        {
            try
            {
                var Branches = Branch.GetAll();
                BranchGridView.DataSource = Branches;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddBranch_Click(object sender, EventArgs e)
        {
            var form = new EditBranch();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadBranches();
            }
        }

        private void edit_Click(object sender, EventArgs e)
        {

            if (BranchGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a guest to edit", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (Branch)BranchGridView.SelectedRows[0].DataBoundItem;
            var form = new EditBranch(selected);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadBranches();
            }
        }

        private void DeleteBTn_Click(object sender, EventArgs e)
        {
            if (BranchGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a guest to delete", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (Branch)BranchGridView.SelectedRows[0].DataBoundItem;
            Branch.Delete(selected.BranchNo);
            LoadBranches();
        }

        private void BranchGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
