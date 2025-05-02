using System;
using System.Windows.Forms;
using System.Xml.Linq;
using jim_membership.models;

namespace jim_membership.Admin
{
    public partial class EditSubscription : Form
    {
        public Subscription Subscription { get; private set; }
        private bool isEditMode;

        public EditSubscription()
        {
            InitializeComponent();
            isEditMode = false;
            Subscription = new Subscription();
        }

        public EditSubscription(Subscription existingSubscription) : this()
        {
            isEditMode = true;
            Subscription = existingSubscription;
            PopulateFields();
        }

        private void PopulateFields()
        {
            txtSubscriptionID.Text = Subscription.SubscriptionID.ToString();
            txtName.Text = Subscription.Name;
            txtAmount.Text = Subscription.Amount.ToString();
            txtNoOfSessions.Text = Subscription.NoOfSessions.ToString();
            txtInBody.Text = Subscription.InBody.ToString();
            txtPrivateSessions.Text = Subscription.NoOfPrivateSessions.ToString();
            dtpFreeDuration.Text = Subscription.FreezeDuration.ToString();
            txtDescription.Text = Subscription.Description;

            if (isEditMode)
            {
                txtSubscriptionID.ReadOnly = true;
            }
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                this.DialogResult = DialogResult.None;
                return;
            }

            try
            {
                Subscription.SubscriptionID = (txtSubscriptionID.Text);
                Subscription.Name = txtName.Text;
                Subscription.Amount = int.Parse(txtAmount.Text);
                Subscription.NoOfSessions = int.Parse(txtNoOfSessions.Text);
                Subscription.InBody = int.Parse(txtInBody.Text);
                Subscription.NoOfPrivateSessions = int.Parse(txtPrivateSessions.Text);
                Subscription.FreezeDuration = int.Parse(dtpFreeDuration.Text);
                Subscription.Description = txtDescription.Text;

                if (isEditMode)
                {
                    Subscription.Update();
                }
                else
                {
                    Subscription.Create();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving subscription: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }

        private bool ValidateFields()
        {
            if (!int.TryParse(txtSubscriptionID.Text, out _))
            {
                MessageBox.Show("Please enter a valid Subscription ID", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter a name", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtAmount.Text, out _))
            {
                MessageBox.Show("Please enter a valid amount", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void EditSubscription_Load(object sender, EventArgs e)
        {

        }

        private void txtPrivateSessions_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSubscriptionID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}