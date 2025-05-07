namespace jim_membership.Admin.Logs
{
    partial class LogsCRUD
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
            this.LogsGridView = new System.Windows.Forms.DataGridView();
            this.AddLogBtn = new System.Windows.Forms.Button();
            this.EditLogBtn = new System.Windows.Forms.Button();
            this.DeleteLogBtn = new System.Windows.Forms.Button();
            this.sortByComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.LogsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // LogsGridView
            // 
            this.LogsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogsGridView.Location = new System.Drawing.Point(12, 12);
            this.LogsGridView.Name = "LogsGridView";
            this.LogsGridView.Size = new System.Drawing.Size(650, 290);
            this.LogsGridView.TabIndex = 0;
            this.LogsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.LogsGridView_CellContentClick);
            // 
            // sortByComboBox
            // 
            this.sortByComboBox.Location = new System.Drawing.Point(12, 340);
            this.sortByComboBox.Size = new System.Drawing.Size(150, 21);
            this.sortByComboBox.TabIndex = 4;
            this.sortByComboBox.Items.Clear();
            this.sortByComboBox.Items.AddRange(new object[] {
                "CheckInTime",
                "checkoutTime"});
            this.sortByComboBox.SelectedIndexChanged += new System.EventHandler(this.SortByComboBox_SelectedIndexChanged);
            // 
            // AddLogBtn
            // 
            this.AddLogBtn.Location = new System.Drawing.Point(172, 340);
            this.AddLogBtn.Name = "AddLogBtn";
            this.AddLogBtn.Size = new System.Drawing.Size(75, 23);
            this.AddLogBtn.TabIndex = 1;
            this.AddLogBtn.Text = "Add";
            this.AddLogBtn.UseVisualStyleBackColor = true;
            this.AddLogBtn.Click += new System.EventHandler(this.AddLogBtn_Click);
            // 
            // EditLogBtn
            // 
            this.EditLogBtn.Location = new System.Drawing.Point(253, 340);
            this.EditLogBtn.Name = "EditLogBtn";
            this.EditLogBtn.Size = new System.Drawing.Size(75, 23);
            this.EditLogBtn.TabIndex = 2;
            this.EditLogBtn.Text = "Edit";
            this.EditLogBtn.UseVisualStyleBackColor = true;
            this.EditLogBtn.Click += new System.EventHandler(this.EditLogBtn_Click);
            // 
            // DeleteLogBtn
            // 
            this.DeleteLogBtn.Location = new System.Drawing.Point(334, 340);
            this.DeleteLogBtn.Name = "DeleteLogBtn";
            this.DeleteLogBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteLogBtn.TabIndex = 3;
            this.DeleteLogBtn.Text = "Delete";
            this.DeleteLogBtn.UseVisualStyleBackColor = true;
            this.DeleteLogBtn.Click += new System.EventHandler(this.DeleteLogBtn_Click);
            // 
            // LogCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.DeleteLogBtn);
            this.Controls.Add(this.EditLogBtn);
            this.Controls.Add(this.AddLogBtn);
            this.Controls.Add(this.sortByComboBox);
            this.Controls.Add(this.LogsGridView);
            this.Name = "LogCrud";
            this.Text = "Log Management";
            ((System.ComponentModel.ISupportInitialize)(this.LogsGridView)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView LogsGridView;
        private System.Windows.Forms.Button AddLogBtn;
        private System.Windows.Forms.Button EditLogBtn;
        private System.Windows.Forms.Button DeleteLogBtn;
        private System.Windows.Forms.ComboBox sortByComboBox;
    }
}