namespace jim_membership.Admin
{
    partial class AdminStart
    {
        private System.ComponentModel.IContainer components = null;
        private TabControl tabControl;
        private TabPage tabUsers;
        private TabPage tabTrainers;
        private TabPage tabMembers;
        private TabPage tabBranches;
        private TabPage tabGuests;
        private TabPage tabSubscriptions;

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
            tabControl = new TabControl();
            tabUsers = new TabPage();
            tabTrainers = new TabPage();
            tabMembers = new TabPage();
            tabBranches = new TabPage();
            tabGuests = new TabPage();
            tabSubscriptions = new TabPage();

            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabUsers);
            tabControl.Controls.Add(tabTrainers);
            tabControl.Controls.Add(tabMembers);
            tabControl.Controls.Add(tabBranches);
            tabControl.Controls.Add(tabGuests);
            tabControl.Controls.Add(tabSubscriptions);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 450);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // tabUsers
            // 
            tabUsers.Location = new Point(4, 24);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new Padding(3);
            tabUsers.Size = new Size(792, 422);
            tabUsers.TabIndex = 0;
            tabUsers.Text = "Users";
            tabUsers.UseVisualStyleBackColor = true;
            tabUsers.Click += tabUsers_Click;
            // 
            // tabTrainers
            // 
            tabTrainers.Location = new Point(4, 24);
            tabTrainers.Name = "tabTrainers";
            tabTrainers.Padding = new Padding(3);
            tabTrainers.Size = new Size(792, 422);
            tabTrainers.TabIndex = 1;
            tabTrainers.Text = "Trainers";
            tabTrainers.UseVisualStyleBackColor = true;
            // 
            // tabMembers
            // 
            tabMembers.Location = new Point(4, 24);
            tabMembers.Name = "tabMembers";
            tabMembers.Padding = new Padding(3);
            tabMembers.Size = new Size(792, 422);
            tabMembers.TabIndex = 2;
            tabMembers.Text = "Members";
            tabMembers.UseVisualStyleBackColor = true;
            // 
            // tabBranches
            // 
            tabBranches.Location = new Point(4, 24);
            tabBranches.Name = "tabBranches";
            tabBranches.Padding = new Padding(3);
            tabBranches.Size = new Size(792, 422);
            tabBranches.TabIndex = 3;
            tabBranches.Text = "Branches";
            tabBranches.UseVisualStyleBackColor = true;
            // 
            // tabGuests
            // 
            tabGuests.Location = new Point(4, 24);
            tabGuests.Name = "tabGuests";
            tabGuests.Padding = new Padding(3);
            tabGuests.Size = new Size(792, 422);
            tabGuests.TabIndex = 3;
            tabGuests.Text = "Guests";
            tabGuests.UseVisualStyleBackColor = true;

            tabSubscriptions.Location = new Point(4, 24);
            tabSubscriptions.Name = "tabSubscriptions";
            tabSubscriptions.Padding = new Padding(3);
            tabSubscriptions.Size = new Size(792, 422);
            tabSubscriptions.TabIndex = 3;
            tabSubscriptions.Text = "Subscription Plans";
            tabSubscriptions.UseVisualStyleBackColor = true;

            // 
            // AdminStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl);
            Name = "AdminStart";
            Text = "Admin Panel";
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }
    }
}
