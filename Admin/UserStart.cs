using System;
using System.Windows.Forms;
using jim_membership.Admin.Account;

namespace jim_membership.Admin
{
    public partial class UserStart : Form
    {
        private UserCrud userCrud;
        private TrainerCrud trainerCrud;
        private Members memberCrud;
        private Guest guestCrud;
        private Branches branchCrud;
        private SubscriptionCrud subCrud;

        private MyAccount myAccountCrud;
        // filler comment

        public UserStart()
        {
            InitializeComponent();

        }
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl.SelectedTab == tabTrainers)
            {
                // Initialize Trainer CRUD
                trainerCrud = new TrainerCrud();
                trainerCrud.TopLevel = false;
                trainerCrud.FormBorderStyle = FormBorderStyle.None;
                trainerCrud.Dock = DockStyle.Fill;
                tabTrainers.Controls.Add(trainerCrud);
                trainerCrud.Show();
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
            else if (tabControl.SelectedTab == tabPage1)
            {
                // Initialize Trainer CRUD
                myAccountCrud = new MyAccount();
                myAccountCrud.TopLevel = false;
                myAccountCrud.FormBorderStyle = FormBorderStyle.None;
                myAccountCrud.Dock = DockStyle.Fill;
                tabPage1.Controls.Add(myAccountCrud);
                myAccountCrud.Show();
            }

        }

    }
}