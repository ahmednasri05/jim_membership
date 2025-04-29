namespace jim_membership.Admin
{
    partial class UserCrud
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.Button btnEditClient;
        private System.Windows.Forms.Button btnDeleteClient;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvUsers = new System.Windows.Forms.DataGridView();
            btnAddClient = new System.Windows.Forms.Button();
            btnEditClient = new System.Windows.Forms.Button();
            btnDeleteClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(dgvUsers)).BeginInit();
            SuspendLayout();

            // dgvUsers
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Location = new System.Drawing.Point(12, 50);
            dgvUsers.MultiSelect = false;
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new System.Drawing.Size(900, 400);
            dgvUsers.TabIndex = 0;

            // btnAddClient
            btnAddClient.Location = new System.Drawing.Point(12, 12);
            btnAddClient.Name = "btnAddClient";
            btnAddClient.Size = new System.Drawing.Size(100, 30);
            btnAddClient.TabIndex = 1;
            btnAddClient.Text = "Add Client";
            btnAddClient.UseVisualStyleBackColor = true;

            // btnEditClient
            btnEditClient.Location = new System.Drawing.Point(120, 12);
            btnEditClient.Name = "btnEditClient";
            btnEditClient.Size = new System.Drawing.Size(100, 30);
            btnEditClient.TabIndex = 2;
            btnEditClient.Text = "Edit Client";
            btnEditClient.UseVisualStyleBackColor = true;

            // btnDeleteClient
            btnDeleteClient.Location = new System.Drawing.Point(230, 12);
            btnDeleteClient.Name = "btnDeleteClient";
            btnDeleteClient.Size = new System.Drawing.Size(100, 30);
            btnDeleteClient.TabIndex = 3;
            btnDeleteClient.Text = "Delete";
            btnDeleteClient.UseVisualStyleBackColor = true;

            // UserCrud
            ClientSize = new System.Drawing.Size(924, 461);
            Controls.Add(btnDeleteClient);
            Controls.Add(btnEditClient);
            Controls.Add(btnAddClient);
            Controls.Add(dgvUsers);
            Name = "UserCrud";
            Text = "User Management";
            ((System.ComponentModel.ISupportInitialize)(dgvUsers)).EndInit();
            ResumeLayout(false);
        }
    }
}