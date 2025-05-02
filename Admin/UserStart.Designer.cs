namespace jim_membership.Admin
{
    partial class UserStart
    {
        private System.ComponentModel.IContainer components = null;

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
            tabSubscriptions = new TabPage();
            tabGuests = new TabPage();
            tabBranches = new TabPage();
            tabTrainers = new TabPage();
            tabControl = new TabControl();
            tabControl.SuspendLayout();
            SuspendLayout();
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
            tabSubscriptions.Click += tabSubscriptions_Click;
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
            // tabControl
            // 
            tabControl.Controls.Add(tabTrainers);
            tabControl.Controls.Add(tabBranches);
            tabControl.Controls.Add(tabGuests);
            tabControl.Controls.Add(tabSubscriptions);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(5, 6, 5, 6);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1371, 900);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // UserStart
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 900);
            Controls.Add(tabControl);
            Margin = new Padding(5, 6, 5, 6);
            Name = "UserStart";
            Text = "User Panel";
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        private TabPage tabSubscriptions;
        private TabPage tabGuests;
        private TabPage tabBranches;
        private TabPage tabTrainers;
        private TabControl tabControl;
    }
}
