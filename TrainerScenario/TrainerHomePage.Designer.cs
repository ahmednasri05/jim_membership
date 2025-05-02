namespace jim_membership.TrainerScenario
{
    partial class TrainerHomePage
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
            components = new System.ComponentModel.Container();
            HomeTitle = new Label();
            ToggleButton = new CheckBox();
            btnEdit = new Button();
            btnDelete = new Button();
            btnProfile = new Button();
            btnCreateNew = new Button();
            dataGridView1 = new DataGridView();
            sessionBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sessionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // HomeTitle
            // 
            HomeTitle.Dock = DockStyle.Top;
            HomeTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            HomeTitle.Location = new Point(0, 0);
            HomeTitle.Name = "HomeTitle";
            HomeTitle.Size = new Size(810, 52);
            HomeTitle.TabIndex = 0;
            HomeTitle.Text = "Sessions";
            HomeTitle.TextAlign = ContentAlignment.MiddleCenter;
            HomeTitle.Click += HomeTitle_Click;
            // 
            // ToggleButton
            // 
            ToggleButton.AutoSize = true;
            ToggleButton.Location = new Point(12, 12);
            ToggleButton.Name = "ToggleButton";
            ToggleButton.Size = new Size(115, 19);
            ToggleButton.TabIndex = 1;
            ToggleButton.Text = "View All Sessions";
            ToggleButton.UseVisualStyleBackColor = true;
            ToggleButton.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(152, 72);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 32);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(529, 75);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 32);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnProfile
            // 
            btnProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProfile.Location = new Point(667, 75);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(112, 32);
            btnProfile.TabIndex = 5;
            btnProfile.Text = "View Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnCreateNew
            // 
            btnCreateNew.Location = new Point(12, 72);
            btnCreateNew.Name = "btnCreateNew";
            btnCreateNew.Size = new Size(112, 32);
            btnCreateNew.TabIndex = 6;
            btnCreateNew.Text = "New";
            btnCreateNew.UseVisualStyleBackColor = true;
            btnCreateNew.Click += btnCreateNew_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 113);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(786, 336);
            dataGridView1.TabIndex = 7;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // TrainerHomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 468);
            Controls.Add(dataGridView1);
            Controls.Add(btnCreateNew);
            Controls.Add(btnProfile);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(ToggleButton);
            Controls.Add(HomeTitle);
            Name = "TrainerHomePage";
            Text = "TrainerHomePage";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)sessionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HomeTitle;
        private CheckBox ToggleButton;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnProfile;
        private Button btnCreateNew;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn sessionIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn trainerIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn branchNoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maxNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private BindingSource sessionBindingSource;
    }
}