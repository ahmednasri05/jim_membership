namespace jim_membership.Admin
{
    partial class Guest
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
            textBox1 = new TextBox();
            GuestsGridView = new DataGridView();
            deleteGuest = new Button();
            editGuest = new Button();
            AddGuest = new Button();
            ((System.ComponentModel.ISupportInitialize)GuestsGridView).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.MenuHighlight;
            textBox1.Location = new Point(338, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(76, 39);
            textBox1.TabIndex = 0;
            textBox1.Text = "Guests";
            // 
            // GuestsGridView
            // 
            GuestsGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GuestsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GuestsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GuestsGridView.Location = new Point(3, 127);
            GuestsGridView.MultiSelect = false;
            GuestsGridView.Name = "GuestsGridView";
            GuestsGridView.ReadOnly = true;
            GuestsGridView.RowTemplate.Height = 25;
            GuestsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GuestsGridView.Size = new Size(795, 321);
            GuestsGridView.TabIndex = 1;
            GuestsGridView.CellContentClick += GuestsGridView_CellContentClick;
            // 
            // deleteGuest
            // 
            deleteGuest.Location = new Point(703, 94);
            deleteGuest.Name = "deleteGuest";
            deleteGuest.Size = new Size(75, 23);
            deleteGuest.TabIndex = 2;
            deleteGuest.Text = "delete";
            deleteGuest.UseVisualStyleBackColor = true;
            deleteGuest.Click += deleteGuest_Click;
            // 
            // editGuest
            // 
            editGuest.Location = new Point(563, 94);
            editGuest.Name = "editGuest";
            editGuest.Size = new Size(75, 23);
            editGuest.TabIndex = 3;
            editGuest.Text = "edit";
            editGuest.UseVisualStyleBackColor = true;
            editGuest.Click += editGuest_Click;
            // 
            // AddGuest
            // 
            AddGuest.Location = new Point(26, 94);
            AddGuest.Name = "AddGuest";
            AddGuest.Size = new Size(75, 23);
            AddGuest.TabIndex = 4;
            if (ProgramSession.Instance.UserRole != "Admin")
            {
                AddGuest.Text = "Invite"; 
            }
            else {
            AddGuest.Text = "Add Guest";
            }
            AddGuest.UseVisualStyleBackColor = true;
            AddGuest.Click += AddGuest_Click;
            // 
            // Guest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddGuest);
            Controls.Add(editGuest);
            Controls.Add(deleteGuest);
            Controls.Add(GuestsGridView);
            Controls.Add(textBox1);
            Name = "Guest";
            Text = "Guest";
            ((System.ComponentModel.ISupportInitialize)GuestsGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView GuestsGridView;
        private Button deleteGuest;
        private Button editGuest;
        private Button AddGuest;
    }
}