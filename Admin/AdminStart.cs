using System;
using System.Windows.Forms;

namespace jim_membership.Admin
{
    public partial class AdminStart : Form
    {
        private UserCrud userCrud;
        private TrainerCrud trainerCrud;
        private Members memberCrud;
        private Guest guestCrud;
        private Branches branchCrud;
        private SubscriptionCrud subCrud;

        public AdminStart()
        {
            InitializeComponent();

        }
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Refresh data when tab changes
            if (tabControl.SelectedTab == tabUsers)
            {
                // Initialize User CRUD
                userCrud = new UserCrud();
                userCrud.TopLevel = false;
                userCrud.FormBorderStyle = FormBorderStyle.None;
                userCrud.Dock = DockStyle.Fill;
                tabUsers.Controls.Add(userCrud);
                userCrud.Show();
            }
            else if (tabControl.SelectedTab == tabTrainers)
            {
                // Initialize Trainer CRUD
                trainerCrud = new TrainerCrud();
                trainerCrud.TopLevel = false;
                trainerCrud.FormBorderStyle = FormBorderStyle.None;
                trainerCrud.Dock = DockStyle.Fill;
                tabTrainers.Controls.Add(trainerCrud);
                trainerCrud.Show();
            }
            else if (tabControl.SelectedTab == tabMembers)
            {
                // Initialize Trainer CRUD
                memberCrud = new Members();
                memberCrud.TopLevel = false;
                memberCrud.FormBorderStyle = FormBorderStyle.None;
                memberCrud.Dock = DockStyle.Fill;
                tabMembers.Controls.Add(memberCrud);
                memberCrud.Show();
            }
            else if (tabControl.SelectedTab == tabGuests)
            {
                // Initialize Trainer CRUD
                guestCrud = new Guest();
                guestCrud.TopLevel = false;
                guestCrud.FormBorderStyle = FormBorderStyle.None;
                guestCrud.Dock = DockStyle.Fill;
                tabGuests.Controls.Add(guestCrud);
                guestCrud.Show();
            }
            else if (tabControl.SelectedTab == tabBranches)
            {
                // Initialize Trainer CRUD
                branchCrud = new Branches();
                branchCrud.TopLevel = false;
                branchCrud.FormBorderStyle = FormBorderStyle.None;
                branchCrud.Dock = DockStyle.Fill;
                tabBranches.Controls.Add(branchCrud);
                branchCrud.Show();
            }
            else if (tabControl.SelectedTab == tabSubscriptions)
            {
                // Initialize Trainer CRUD
                subCrud = new SubscriptionCrud();
                subCrud.TopLevel = false;
                subCrud.FormBorderStyle = FormBorderStyle.None;
                subCrud.Dock = DockStyle.Fill;
                tabSubscriptions.Controls.Add(subCrud);
                subCrud.Show();
            }
        }

        private void tabUsers_Click(object sender, EventArgs e)
        {

        }
    }
}