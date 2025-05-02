using System;
using System.Collections.Generic;
using System.Windows.Forms;
using jim_membership.models;

namespace jim_membership.Admin
{
    public partial class SubscriptionCrud : Form
    {
        public SubscriptionCrud()
        {
            InitializeComponent();
            LoadSubscriptions();
            if (ProgramSession.Instance.UserRole != "Admin") {
                AddSubBtn.Visible = false;
                EditSubBtn.Visible = false;
                DeleteSubBtn.Visible = false;
            }
            else {
                button1.Visible = false;
                button2.Visible = false;
            }
        }

        private void LoadSubscriptions()
        {
            try
            {
                var subscriptions = Subscription.GetAll();
                SubscriptionsGridView.DataSource = subscriptions;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading subscriptions: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddSubBtn_Click(object sender, EventArgs e)
        {
            var form = new EditSubscription();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadSubscriptions();
            }
        }

        private void EditSubBtn_Click(object sender, EventArgs e)
        {
            if (SubscriptionsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a subscription to edit", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (Subscription)SubscriptionsGridView.SelectedRows[0].DataBoundItem;
            var form = new EditSubscription(selected);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadSubscriptions();
            }
        }

        private void DeleteSubBtn_Click(object sender, EventArgs e)
        {
            if (SubscriptionsGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a subscription to delete", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selected = (Subscription)SubscriptionsGridView.SelectedRows[0].DataBoundItem;
            Subscription.Delete(selected.SubscriptionID);
            LoadSubscriptions();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubscriptionsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SubscriptionCrud_Load(object sender, EventArgs e)
        {

        }

        private void SortByComboBox(object sender, EventArgs e)
        {
            if (sortbyComboBox.SelectedItem == null)
                return;
            string selected = sortbyComboBox.SelectedItem.ToString();


            if (selected == "Name")
            {
                LoadSubscriptions("Name");
            }
            else if (selected == "amount")
            {
                LoadSubscriptions("amount");
            }
            else if (selected == "noOfFreeSessions")
            {
                LoadSubscriptions("noOfPrivateSessions");
            }

        }
        private void LoadSubscriptions(string value)
        {
            try
            {
                var subscriptions = Subscription.GetAllOrderBy(value);
                SubscriptionsGridView.DataSource = subscriptions;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading subscriptions: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Subscribe.GetById(ProgramSession.Instance.UserId) != null)
            {
                MessageBox.Show("You are already subscribed to a plan", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (SubscriptionsGridView.SelectedRows.Count == 0 || SubscriptionsGridView.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select one subscription to subscribe to", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var selected = (Subscription)SubscriptionsGridView.SelectedRows[0].DataBoundItem;
            var payment = new Payment();
            try {
            payment.Amount = selected.Amount;
            payment.Date = DateTime.Now;
            payment.Create();
            }
            catch (Exception ex) {
                MessageBox.Show($"Error creating payment: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try {
            if (Member.GetById(ProgramSession.Instance.UserId) == null)
            {
                var member = new Member();
                member.NationalID = ProgramSession.Instance.UserId;
                member.FirstJoinDate = DateTime.Now;
                member.InBodyUsed = 0;
                member.FreezeDurationUsed = 0;
                member.ActiveSubscription = true;
                member.Create();
            }
            else
            {
                var member = Member.GetById(ProgramSession.Instance.UserId);
                member.ActiveSubscription = true;
                member.Update();
            }
            var subscription = new Subscribe();
            subscription.MemberID = ProgramSession.Instance.UserId;
            subscription.SubscriptionID = selected.SubscriptionID;
            subscription.TransactionID = payment.TransactionID;
            subscription.SessionUsed = 0;
            subscription.PrivateSessionUsed = 0;
            subscription.StartDate = DateTime.Now;
            subscription.EndDate = DateTime.Now.AddDays(selected.NoOfSessions * 4);
            subscription.Create();
            }
            catch (Exception ex) {
                MessageBox.Show($"Error creating subscription: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("You have successfully subscribed to " + selected.Name, "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var currentsub = Subscribe.GetById(ProgramSession.Instance.UserId);
            if (currentsub == null)
            {
                MessageBox.Show("You are not subscribed to any plan", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Subscribe.Delete(currentsub.MemberID);
            MessageBox.Show("You have successfully unsubscribed from " + currentsub.SubscriptionID, "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
