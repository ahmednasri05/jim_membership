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
    public partial class EditGuest : Form
    {
        private Invite _invite;
        private bool _isEditMode;

        public EditGuest()
        {
            InitializeComponent();
            _isEditMode = false;
            LoadMembers();
        }

        public EditGuest(Invite invite) : this()
        {
            _invite = invite;
            _isEditMode = true;
            PopulateFields();
        }

        private void LoadMembers()
        {
            try
            {
                var members = Member.GetAll();
                memberIDComboBox.DataSource = members;
                memberIDComboBox.DisplayMember = "FullName";
                memberIDComboBox.ValueMember = "NationalID";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading members: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateFields()
        {
            memberIDComboBox.SelectedValue = _invite.MemberID;
            nationalIDTextBox.Text = _invite.guestID.ToString();
            invitationDatePicker.Value = _invite.InvitationDate;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            try
            {
                if (_isEditMode)
                {
                    _invite.MemberID = memberIDComboBox.SelectedValue.ToString();
                    _invite.guestID = (nationalIDTextBox.Text);
                    _invite.InvitationDate = invitationDatePicker.Value;
                    _invite.Update();
                }
                else
                {
                    var newInvite = new Invite
                    {
                        MemberID = memberIDComboBox.SelectedValue.ToString(),
                        guestID = (nationalIDTextBox.Text),
                        InvitationDate = invitationDatePicker.Value
                    };
                    newInvite.Create();
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving guest: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateFields()
        {
            if (memberIDComboBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid member", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(nationalIDTextBox.Text, out _))
            {
                MessageBox.Show("Please enter a valid National ID", "Validation Error",
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

        private void EditGuest_Load(object sender, EventArgs e)
        {

        }

        private void memberIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}