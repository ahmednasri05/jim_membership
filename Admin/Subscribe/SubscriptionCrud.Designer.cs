using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace jim_membership.Admin
{
    partial class SubscriptionCrud
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            SubscriptionsGridView = new DataGridView();
            AddSubBtn = new Button();
            EditSubBtn = new Button();
            DeleteSubBtn = new Button();
            sortbyComboBox = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)SubscriptionsGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(543, 66);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(394, 80);
            label1.TabIndex = 4;
            label1.Text = "Subscriptions Table";
            label1.Click += label1_Click;
            // 
            // SubscriptionsGridView
            // 
            SubscriptionsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SubscriptionsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SubscriptionsGridView.Location = new Point(5, 442);
            SubscriptionsGridView.Margin = new Padding(5, 6, 5, 6);
            SubscriptionsGridView.MultiSelect = false;
            SubscriptionsGridView.Name = "SubscriptionsGridView";
            SubscriptionsGridView.ReadOnly = true;
            SubscriptionsGridView.RowHeadersVisible = false;
            SubscriptionsGridView.RowHeadersWidth = 72;
            SubscriptionsGridView.RowTemplate.Height = 25;
            SubscriptionsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SubscriptionsGridView.Size = new Size(1493, 716);
            SubscriptionsGridView.TabIndex = 3;
            SubscriptionsGridView.CellContentClick += SubscriptionsGridView_CellContentClick;
            // 
            // AddSubBtn
            // 
            AddSubBtn.Location = new Point(21, 372);
            AddSubBtn.Margin = new Padding(5, 6, 5, 6);
            AddSubBtn.Name = "AddSubBtn";
            AddSubBtn.Size = new Size(197, 46);
            AddSubBtn.TabIndex = 2;
            AddSubBtn.Text = "Add Subscription";
            AddSubBtn.UseVisualStyleBackColor = true;
            AddSubBtn.Click += AddSubBtn_Click;
            // 
            // EditSubBtn
            // 
            EditSubBtn.Location = new Point(1099, 372);
            EditSubBtn.Margin = new Padding(5, 6, 5, 6);
            EditSubBtn.Name = "EditSubBtn";
            EditSubBtn.Size = new Size(129, 46);
            EditSubBtn.TabIndex = 1;
            EditSubBtn.Text = "Edit";
            EditSubBtn.UseVisualStyleBackColor = true;
            EditSubBtn.Click += EditSubBtn_Click;
            // 
            // DeleteSubBtn
            // 
            DeleteSubBtn.Location = new Point(1298, 372);
            DeleteSubBtn.Margin = new Padding(5, 6, 5, 6);
            DeleteSubBtn.Name = "DeleteSubBtn";
            DeleteSubBtn.Size = new Size(129, 46);
            DeleteSubBtn.TabIndex = 0;
            DeleteSubBtn.Text = "Delete";
            DeleteSubBtn.UseVisualStyleBackColor = true;
            DeleteSubBtn.Click += DeleteSubBtn_Click;
            // 
            // sortbyComboBox
            // 
            sortbyComboBox.FormattingEnabled = true;
            sortbyComboBox.Items.AddRange(new object[] { "Name", "amount", "noOfPrivateSessions" });
            sortbyComboBox.Location = new Point(1219, 280);
            sortbyComboBox.Margin = new Padding(5, 6, 5, 6);
            sortbyComboBox.Name = "sortbyComboBox";
            sortbyComboBox.Size = new Size(205, 38);
            sortbyComboBox.TabIndex = 5;
            sortbyComboBox.Text = "sort by";
            sortbyComboBox.SelectedIndexChanged += SortByComboBox;
            sortbyComboBox.Click += SortByComboBox;
            // 
            // button1
            // 
            button1.Location = new Point(241, 372);
            button1.Name = "button1";
            button1.Size = new Size(142, 46);
            button1.TabIndex = 6;
            button1.Text = "Subscribe";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(410, 372);
            button2.Name = "Unsubscribe";
            button2.Size = new Size(149, 46);
            button2.TabIndex = 7;
            button2.Text = "Unsubscribe";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SubscriptionCrud
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1493, 1182);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(sortbyComboBox);
            Controls.Add(DeleteSubBtn);
            Controls.Add(EditSubBtn);
            Controls.Add(AddSubBtn);
            Controls.Add(SubscriptionsGridView);
            Controls.Add(label1);
            Margin = new Padding(5, 6, 5, 6);
            Name = "SubscriptionCrud";
            Text = "Subscriptions";
            Load += SubscriptionCrud_Load;
            ((System.ComponentModel.ISupportInitialize)SubscriptionsGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private DataGridView SubscriptionsGridView;
        private Button AddSubBtn;
        private Button EditSubBtn;
        private Button DeleteSubBtn;
        private ComboBox sortbyComboBox;
        private Button button1;
        private Button button2;
    }
}
