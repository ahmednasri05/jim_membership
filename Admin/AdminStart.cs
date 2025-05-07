using System;
using System.Windows.Forms;
using jim_membership.Admin.Logs;

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
        private SubscriptionsReportForm subReport;

        private LogsCRUD LogsReport;

        public AdminStart()
        {
            InitializeComponent();
            userCrud = new UserCrud();
            userCrud.TopLevel = false;
            userCrud.FormBorderStyle = FormBorderStyle.None;
            userCrud.Dock = DockStyle.Fill;
            tabUsers.Controls.Add(userCrud);
            userCrud.Show();
            trainerCrud = new TrainerCrud();
            trainerCrud.TopLevel = false;
            trainerCrud.FormBorderStyle = FormBorderStyle.None;
            trainerCrud.Dock = DockStyle.Fill;
            tabTrainers.Controls.Add(trainerCrud);
            trainerCrud.Show();
            memberCrud = new Members();
            memberCrud.TopLevel = false;
            memberCrud.FormBorderStyle = FormBorderStyle.None;
            memberCrud.Dock = DockStyle.Fill;
            tabMembers.Controls.Add(memberCrud);
            memberCrud.Show();
            guestCrud = new Guest();
            guestCrud.TopLevel = false;
            guestCrud.FormBorderStyle = FormBorderStyle.None;
            guestCrud.Dock = DockStyle.Fill;
            tabGuests.Controls.Add(guestCrud);
            guestCrud.Show();
            branchCrud = new Branches();
            branchCrud.TopLevel = false;
            branchCrud.FormBorderStyle = FormBorderStyle.None;
            branchCrud.Dock = DockStyle.Fill;
            tabBranches.Controls.Add(branchCrud);
            branchCrud.Show();
            subCrud = new SubscriptionCrud();
            subCrud.TopLevel = false;
            subCrud.FormBorderStyle = FormBorderStyle.None;
            subCrud.Dock = DockStyle.Fill;
            tabSubscriptions.Controls.Add(subCrud);
            subCrud.Show();
            subReport = new SubscriptionsReportForm();
            subReport.TopLevel = false;
            subReport.FormBorderStyle = FormBorderStyle.None;
            subReport.Dock = DockStyle.Fill;
            tabSubscriptionReport.Controls.Add(subReport);
            subReport.Show();
            LogsReport = new LogsCRUD();
            LogsReport.TopLevel = false;
            LogsReport.FormBorderStyle = FormBorderStyle.None;
            LogsReport.Dock = DockStyle.Fill;
            tabPage1.Controls.Add(LogsReport);
            LogsReport.Show();
            
        }
        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Refresh data when tab changes
            if (tabControl.SelectedTab == tabUsers)
            {
                userCrud.LoadUsers();


            }
            else if (tabControl.SelectedTab == tabTrainers)
            {
                // Initialize Trainer CRUD
                trainerCrud.LoadTrainers();


            }
            else if (tabControl.SelectedTab == tabMembers)
            {
                // Initialize Trainer CRUD
                memberCrud.LoadMembers();


            }
            else if (tabControl.SelectedTab == tabGuests)
            {
                // Initialize Trainer CRUD
                guestCrud.LoadGuests();

            }
            else if (tabControl.SelectedTab == tabBranches)
            {
                // Initialize Trainer CRUD
                branchCrud.LoadBranches();

            }
            else if (tabControl.SelectedTab == tabSubscriptions)
            {
                // Initialize Trainer CRUD
                subCrud.LoadSubscriptions();

            }
             else if (tabControl.SelectedTab == tabPage1)
            {
                // Initialize Trainer CRUD
                LogsReport.LoadLogs();
            }
            else if (tabControl.SelectedTab == tabSubscriptionReport)
            {
                // Initialize Trainer CRUD
                

            }
        }

        private void tabUsers_Click(object sender, EventArgs e)
        {

        }
    }
}