using jim_membership.models;

namespace jim_membership.Admin
{
    public partial class EditMember : Form
    {
        public Member Member { get; private set; }
        private bool isEditMode;

        public EditMember()
        {
            InitializeComponent();
            isEditMode = false;
            Member = new Member();
            btnOK.Click += BtnOK_Click;
        }

        public EditMember(Member existingMember) : this()
        {
            isEditMode = true;
            Member = existingMember;

            txtNationalID.Text = Member.NationalID.ToString();
            dtpFirstJoinDate.Value = Member.FirstJoinDate;
            txtInBodyUsed.Text = Member.InBodyUsed.ToString();
            txtFreezeDurationUsed.Text = Member.FreezeDurationUsed.ToString();
            chkActiveSubscription.Checked = Member.ActiveSubscription;

            txtNationalID.ReadOnly = true;
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtNationalID.Text, out int nationalID))
            {
                MessageBox.Show("Please enter a valid National ID.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }
            User user = User.GetById(nationalID);
            // Check if user exists before adding member
            if (user == null)
            {
                MessageBox.Show("User does not exist. Please add the user before adding the member.", "Missing User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.DialogResult = DialogResult.None;
                return;
            }

            // Assign values to Member object
            Member.NationalID = nationalID;
            Member.FirstJoinDate = dtpFirstJoinDate.Value;
            Member.InBodyUsed = int.TryParse(txtInBodyUsed.Text, out int inBody) ? inBody : 0;
            Member.FreezeDurationUsed = int.TryParse(txtFreezeDurationUsed.Text, out int freeze) ? freeze : 0;
            Member.ActiveSubscription = chkActiveSubscription.Checked;

            try
            {
                if (isEditMode)
                {
                    Member.Update();
                }
                else
                {
                    Member.Create();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving member: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.DialogResult = DialogResult.None;
            }
        }

        private void EditMember_Load(object sender, EventArgs e)
        {

        }
    }
}
