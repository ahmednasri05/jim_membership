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
            if (ProgramSession.Instance.UserRole != "Admin")
            {
                memberIDLabel.Visible = false; // Hide the label for the member ID combo box
                memberIDComboBox.Visible = false; // Hide the combo box for the member ID
            }
            else
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
                {    if(ProgramSession.Instance.UserRole == "Admin" && nationalIDTextBox.Text.ToString() == memberIDComboBox.SelectedValue.ToString()) // member cant invite himself
                    {
                        MessageBox.Show("you can,t invite yourself , please enter another nationalID", "Invalid Guest", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    else if(ProgramSession.Instance.UserRole != "Admin" && nationalIDTextBox.Text.ToString() == ProgramSession.Instance.UserId)
                    {
                        MessageBox.Show("you can,t invite yourself , please enter another nationalID", "Invalid Guest", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    var newInvite = new Invite
                    {
                        guestID = (nationalIDTextBox.Text),
                        InvitationDate = invitationDatePicker.Value
                    };

                    if (ProgramSession.Instance.UserRole != "Admin")
                    {
                        newInvite.MemberID = ProgramSession.Instance.UserId;
                    }
                    else
                    {
                        newInvite.MemberID = memberIDComboBox.SelectedValue.ToString();
                    }
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
            if (memberIDComboBox.SelectedValue == null && ProgramSession.Instance.UserRole == "Admin")
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

        private void nationalIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}