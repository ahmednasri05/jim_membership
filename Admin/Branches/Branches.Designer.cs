namespace jim_membership.Admin
{
    partial class Branches
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
            BranchGridView = new DataGridView();
            DeleteBTn = new Button();
            edit = new Button();
            AddBranch = new Button();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)BranchGridView).BeginInit();
            SuspendLayout();
            // 
            // BranchGridView
            // 
            BranchGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BranchGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BranchGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BranchGridView.Location = new Point(1, 207);
            BranchGridView.MultiSelect = false;
            BranchGridView.Name = "BranchGridView";
            BranchGridView.ReadOnly = true;
            BranchGridView.RowTemplate.Height = 25;
            BranchGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            BranchGridView.Size = new Size(796, 241);
            BranchGridView.TabIndex = 1;
            BranchGridView.CellContentClick += BranchGridView_CellContentClick;
            // 
            // DeleteBTn
            // 
            DeleteBTn.Location = new Point(704, 159);
            DeleteBTn.Name = "DeleteBTn";
            DeleteBTn.Size = new Size(75, 23);
            DeleteBTn.TabIndex = 2;
            DeleteBTn.Text = "delete";
            DeleteBTn.UseVisualStyleBackColor = true;
            DeleteBTn.Click += DeleteBTn_Click;
            // 
            // edit
            // 
            edit.Location = new Point(544, 159);
            edit.Name = "edit";
            edit.Size = new Size(75, 23);
            edit.TabIndex = 3;
            edit.Text = "edit";
            edit.UseVisualStyleBackColor = true;
            edit.Click += edit_Click;
            // 
            // AddBranch
            // 
            AddBranch.Location = new Point(26, 159);
            AddBranch.Name = "AddBranch";
            AddBranch.Size = new Size(92, 23);
            AddBranch.TabIndex = 4;
            AddBranch.Text = "Add branch";
            AddBranch.UseVisualStyleBackColor = true;
            AddBranch.Click += AddBranch_Click;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.MenuHighlight;
            textBox1.Location = new Point(331, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(101, 39);
            textBox1.TabIndex = 5;
            textBox1.Text = "Branches";
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // Branches
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox1);
            Controls.Add(AddBranch);
            Controls.Add(edit);
            Controls.Add(DeleteBTn);
            Controls.Add(BranchGridView);
            Name = "Branches";
            Text = "Branches";
            ((System.ComponentModel.ISupportInitialize)BranchGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView BranchGridView;
        private Button DeleteBTn;
        private Button edit;
        private Button AddBranch;
        private TextBox textBox1;
    }
}