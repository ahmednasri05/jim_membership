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
    public partial class Members : Form
    {
        public Members()
        {
            InitializeComponent();
            LoadMembers();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public void LoadMembers()
        {
            try
            {
                var members = Member.GetAll();
                MembersGrdiView.DataSource = members;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading users: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void MembersGrdiView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddMemBtn_Click(object sender, EventArgs e)
        {
            var form = new EditMember();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadMembers();
            }
        }

        private void editMemberBtn_Click(object sender, EventArgs e)
        {
            if (MembersGrdiView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a user to edit", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (Member)MembersGrdiView.SelectedRows[0].DataBoundItem;
            var form = new EditMember(selected);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadMembers();
            }
        }

        private void MemberDeletebtn_Click(object sender, EventArgs e)
        {
            if (MembersGrdiView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a member to delete", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (Member)MembersGrdiView.SelectedRows[0].DataBoundItem;
            Member.Delete(selected.NationalID);
            LoadMembers();
        }
    }
}
