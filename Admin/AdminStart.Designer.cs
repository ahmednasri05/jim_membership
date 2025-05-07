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
        private TabPage tabSubscriptionReport;

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
            tabSubscriptionReport = new TabPage();
            tabPage1 = new TabPage();
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
            tabControl.Controls.Add(tabSubscriptionReport);
            tabControl.Controls.Add(tabPage1);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(5, 6, 5, 6);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1371, 900);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // tabUsers
            // 
            tabUsers.Location = new Point(4, 39);
            tabUsers.Margin = new Padding(5, 6, 5, 6);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new Padding(5, 6, 5, 6);
            tabUsers.Size = new Size(1363, 857);
            tabUsers.TabIndex = 0;
            tabUsers.Text = "Users";
            tabUsers.UseVisualStyleBackColor = true;
            tabUsers.Click += tabUsers_Click;
            // 
            // tabTrainers
            // 
            tabTrainers.Location = new Point(4, 39);
            tabTrainers.Margin = new Padding(5, 6, 5, 6);
            tabTrainers.Name = "tabTrainers";
            tabTrainers.Padding = new Padding(5, 6, 5, 6);
            tabTrainers.Size = new Size(1363, 857);
            tabTrainers.TabIndex = 1;
            tabTrainers.Text = "Trainers";
            tabTrainers.UseVisualStyleBackColor = true;
            // 
            // tabMembers
            // 
            tabMembers.Location = new Point(4, 39);
            tabMembers.Margin = new Padding(5, 6, 5, 6);
            tabMembers.Name = "tabMembers";
            tabMembers.Padding = new Padding(5, 6, 5, 6);
            tabMembers.Size = new Size(1363, 857);
            tabMembers.TabIndex = 2;
            tabMembers.Text = "Members";
            tabMembers.UseVisualStyleBackColor = true;
            // 
            // tabBranches
            // 
            tabBranches.Location = new Point(4, 39);
            tabBranches.Margin = new Padding(5, 6, 5, 6);
            tabBranches.Name = "tabBranches";
            tabBranches.Padding = new Padding(5, 6, 5, 6);
            tabBranches.Size = new Size(1363, 857);
            tabBranches.TabIndex = 3;
            tabBranches.Text = "Branches";
            tabBranches.UseVisualStyleBackColor = true;
            // 
            // tabGuests
            // 
            tabGuests.Location = new Point(4, 39);
            tabGuests.Margin = new Padding(5, 6, 5, 6);
            tabGuests.Name = "tabGuests";
            tabGuests.Padding = new Padding(5, 6, 5, 6);
            tabGuests.Size = new Size(1363, 857);
            tabGuests.TabIndex = 3;
            tabGuests.Text = "Guests";
            tabGuests.UseVisualStyleBackColor = true;
            // 
            // tabSubscriptions
            // 
            tabSubscriptions.Location = new Point(4, 39);
            tabSubscriptions.Margin = new Padding(5, 6, 5, 6);
            tabSubscriptions.Name = "tabSubscriptions";
            tabSubscriptions.Padding = new Padding(5, 6, 5, 6);
            tabSubscriptions.Size = new Size(1363, 857);
            tabSubscriptions.TabIndex = 3;
            tabSubscriptions.Text = "Subscription Plans";
            tabSubscriptions.UseVisualStyleBackColor = true;
            // 
            // tabSubscriptionReport
            // 
            tabSubscriptionReport.Location = new Point(4, 39);
            tabSubscriptionReport.Margin = new Padding(5, 6, 5, 6);
            tabSubscriptionReport.Name = "tabSubscriptionReport";
            tabSubscriptionReport.Padding = new Padding(5, 6, 5, 6);
            tabSubscriptionReport.Size = new Size(1363, 857);
            tabSubscriptionReport.TabIndex = 3;
            tabSubscriptionReport.Text = "Subscription Report";
            tabSubscriptionReport.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 39);
            tabPage1.Name = "Log Management";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1363, 857);
            tabPage1.TabIndex = 4;
            tabPage1.Text = "Log Management";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // AdminStart
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 900);
            Controls.Add(tabControl);
            Margin = new Padding(5, 6, 5, 6);
            Name = "AdminStart";
            Text = "Admin Panel";
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TabPage tabPage1;
    }
}
