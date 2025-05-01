namespace jim_membership.Trainer
{
    partial class Home
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
            lbTitle = new Label();
            btSessionCreate = new Button();
            btEditSession = new Button();
            btnDeleteSession = new Button();
            sessionsDataView = new DataGridView();
            sessionBindingSource = new BindingSource(components);
            btnProfile = new Button();
            ((System.ComponentModel.ISupportInitialize)sessionsDataView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sessionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lbTitle
            // 
            lbTitle.Dock = DockStyle.Top;
            lbTitle.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.Location = new Point(0, 0);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(1032, 55);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "Sessions";
            lbTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btSessionCreate
            // 
            btSessionCreate.Location = new Point(52, 82);
            btSessionCreate.Name = "btSessionCreate";
            btSessionCreate.Size = new Size(138, 34);
            btSessionCreate.TabIndex = 1;
            btSessionCreate.Text = "Create New Session";
            btSessionCreate.UseVisualStyleBackColor = true;
            btSessionCreate.Click += button1_Click;
            // 
            // btEditSession
            // 
            btEditSession.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btEditSession.Location = new Point(629, 82);
            btEditSession.Name = "btEditSession";
            btEditSession.Size = new Size(113, 34);
            btEditSession.TabIndex = 2;
            btEditSession.Text = "Edit Session";
            btEditSession.UseVisualStyleBackColor = true;
            btEditSession.Click += button2_Click;
            // 
            // btnDeleteSession
            // 
            btnDeleteSession.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteSession.Location = new Point(763, 82);
            btnDeleteSession.Name = "btnDeleteSession";
            btnDeleteSession.Size = new Size(113, 34);
            btnDeleteSession.TabIndex = 3;
            btnDeleteSession.Text = "Delete Session";
            btnDeleteSession.UseVisualStyleBackColor = true;
            btnDeleteSession.Click += button3_Click;
            // 
            // sessionsDataView
            // 
            sessionsDataView.AllowUserToAddRows = false;
            sessionsDataView.AllowUserToDeleteRows = false;
            sessionsDataView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            sessionsDataView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            sessionsDataView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            sessionsDataView.Location = new Point(12, 131);
            sessionsDataView.MultiSelect = false;
            sessionsDataView.Name = "sessionsDataView";
            sessionsDataView.ReadOnly = true;
            sessionsDataView.RowHeadersVisible = false;
            sessionsDataView.RowTemplate.Height = 25;
            sessionsDataView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            sessionsDataView.Size = new Size(1008, 474);
            sessionsDataView.TabIndex = 4;
            sessionsDataView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // sessionBindingSource
            // 
            sessionBindingSource.DataSource = typeof(models.Session);
            // 
            // btnProfile
            // 
            btnProfile.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnProfile.Location = new Point(895, 82);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(113, 34);
            btnProfile.TabIndex = 5;
            btnProfile.Text = "View Profile";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += button1_Click_1;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1032, 617);
            Controls.Add(btnProfile);
            Controls.Add(sessionsDataView);
            Controls.Add(btnDeleteSession);
            Controls.Add(btEditSession);
            Controls.Add(btSessionCreate);
            Controls.Add(lbTitle);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            ((System.ComponentModel.ISupportInitialize)sessionsDataView).EndInit();
            ((System.ComponentModel.ISupportInitialize)sessionBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lbTitle;
        private Button btSessionCreate;
        private Button btEditSession;
        private Button btnDeleteSession;
        private DataGridView sessionsDataView;
        private BindingSource sessionBindingSource;
        private Button btnProfile;
    }
}