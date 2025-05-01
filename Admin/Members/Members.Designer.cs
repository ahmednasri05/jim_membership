namespace jim_membership.Admin
{
    partial class Members
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
            MembersGrdiView = new DataGridView();
            AddMemBtn = new Button();
            editMemberBtn = new Button();
            MemberDeletebtn = new Button();
            ((System.ComponentModel.ISupportInitialize)MembersGrdiView).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.MenuHighlight;
            textBox1.Location = new Point(345, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 39);
            textBox1.TabIndex = 0;
            textBox1.Text = "Members Table";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // MembersGrdiView
            // 
            MembersGrdiView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MembersGrdiView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MembersGrdiView.Location = new Point(3, 221);
            MembersGrdiView.MultiSelect = false;
            MembersGrdiView.Name = "MembersGrdiView";
            MembersGrdiView.ReadOnly = true;
            MembersGrdiView.RowHeadersVisible = false;
            MembersGrdiView.RowTemplate.Height = 25;
            MembersGrdiView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MembersGrdiView.Size = new Size(871, 358);
            MembersGrdiView.TabIndex = 1;
            MembersGrdiView.CellContentClick += MembersGrdiView_CellContentClick;
            // 
            // AddMemBtn
            // 
            AddMemBtn.Location = new Point(12, 186);
            AddMemBtn.Name = "AddMemBtn";
            AddMemBtn.Size = new Size(96, 23);
            AddMemBtn.TabIndex = 2;
            AddMemBtn.Text = "Add Member";
            AddMemBtn.UseVisualStyleBackColor = true;
            AddMemBtn.Click += AddMemBtn_Click;
            // 
            // editMemberBtn
            // 
            editMemberBtn.Location = new Point(641, 186);
            editMemberBtn.Name = "editMemberBtn";
            editMemberBtn.Size = new Size(75, 23);
            editMemberBtn.TabIndex = 3;
            editMemberBtn.Text = "edit";
            editMemberBtn.UseVisualStyleBackColor = true;
            editMemberBtn.Click += editMemberBtn_Click;
            // 
            // MemberDeletebtn
            // 
            MemberDeletebtn.Location = new Point(757, 186);
            MemberDeletebtn.Name = "MemberDeletebtn";
            MemberDeletebtn.Size = new Size(75, 23);
            MemberDeletebtn.TabIndex = 4;
            MemberDeletebtn.Text = "delete";
            MemberDeletebtn.UseVisualStyleBackColor = true;
            MemberDeletebtn.Click += MemberDeletebtn_Click;
            // 
            // Members
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 591);
            Controls.Add(MemberDeletebtn);
            Controls.Add(editMemberBtn);
            Controls.Add(AddMemBtn);
            Controls.Add(MembersGrdiView);
            Controls.Add(textBox1);
            Name = "Members";
            Text = "Members";
            ((System.ComponentModel.ISupportInitialize)MembersGrdiView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView MembersGrdiView;
        private Button AddMemBtn;
        private Button editMemberBtn;
        private Button MemberDeletebtn;
    }
}