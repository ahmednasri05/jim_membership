namespace jim_membership.Admin
{
    partial class AdminStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Users = new TabControl();
            Userss = new TabPage();
            Trainer = new TabPage();
            Users.SuspendLayout();
            SuspendLayout();
            // 
            // Users
            // 
            Users.Controls.Add(Userss);
            Users.Controls.Add(Trainer);
            Users.Location = new Point(0, 0);
            Users.Name = "Users";
            Users.SelectedIndex = 0;
            Users.Size = new Size(802, 451);
            Users.TabIndex = 0;
            Users.SelectedIndexChanged += tabtrainer_SelectedIndexChanged;
            // 
            // Userss
            // 
            Userss.Location = new Point(4, 24);
            Userss.Name = "Userss";
            Userss.Padding = new Padding(3);
            Userss.Size = new Size(794, 423);
            Userss.TabIndex = 2;
            Userss.Text = "Users";
            Userss.UseVisualStyleBackColor = true;
            // 
            // Trainer
            // 
            Trainer.Location = new Point(4, 24);
            Trainer.Name = "Trainer";
            Trainer.Padding = new Padding(3);
            Trainer.Size = new Size(794, 423);
            Trainer.TabIndex = 3;
            Trainer.Text = "Trainer";
            Trainer.UseVisualStyleBackColor = true;
            // 
            // AdminStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Users);
            Name = "AdminStart";
            Text = "AdminStart";
            Users.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl Users;
        private TabPage Userss;
        private TabPage Trainer;
    }
}