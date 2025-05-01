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
    }
}
