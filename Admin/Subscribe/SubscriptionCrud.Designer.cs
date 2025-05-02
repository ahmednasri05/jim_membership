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
            ((System.ComponentModel.ISupportInitialize)SubscriptionsGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(317, 33);
            label1.Name = "label1";
            label1.Size = new Size(230, 40);
            label1.TabIndex = 4;
            label1.Text = "Subscriptions Table";
            label1.Click += label1_Click;
            // 
            // SubscriptionsGridView
            // 
            SubscriptionsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            SubscriptionsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SubscriptionsGridView.Location = new Point(3, 221);
            SubscriptionsGridView.MultiSelect = false;
            SubscriptionsGridView.Name = "SubscriptionsGridView";
            SubscriptionsGridView.ReadOnly = true;
            SubscriptionsGridView.RowHeadersVisible = false;
            SubscriptionsGridView.RowTemplate.Height = 25;
            SubscriptionsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SubscriptionsGridView.Size = new Size(871, 358);
            SubscriptionsGridView.TabIndex = 3;
            SubscriptionsGridView.CellContentClick += SubscriptionsGridView_CellContentClick;
            // 
            // AddSubBtn
            // 
            AddSubBtn.Location = new Point(12, 186);
            AddSubBtn.Name = "AddSubBtn";
            AddSubBtn.Size = new Size(115, 23);
            AddSubBtn.TabIndex = 2;
            AddSubBtn.Text = "Add Subscription";
            AddSubBtn.UseVisualStyleBackColor = true;
            AddSubBtn.Click += AddSubBtn_Click;
            // 
            // EditSubBtn
            // 
            EditSubBtn.Location = new Point(641, 186);
            EditSubBtn.Name = "EditSubBtn";
            EditSubBtn.Size = new Size(75, 23);
            EditSubBtn.TabIndex = 1;
            EditSubBtn.Text = "Edit";
            EditSubBtn.UseVisualStyleBackColor = true;
            EditSubBtn.Click += EditSubBtn_Click;
            // 
            // DeleteSubBtn
            // 
            DeleteSubBtn.Location = new Point(757, 186);
            DeleteSubBtn.Name = "DeleteSubBtn";
            DeleteSubBtn.Size = new Size(75, 23);
            DeleteSubBtn.TabIndex = 0;
            DeleteSubBtn.Text = "Delete";
            DeleteSubBtn.UseVisualStyleBackColor = true;
            DeleteSubBtn.Click += DeleteSubBtn_Click;
            // 
            // sortbyComboBox
            // 
            sortbyComboBox.FormattingEnabled = true;
            sortbyComboBox.Items.AddRange(new object[] { "Name", "amount", "noOfPrivateSessions" });
            sortbyComboBox.Location = new Point(711, 140);
            sortbyComboBox.Name = "sortbyComboBox";
            sortbyComboBox.Size = new Size(121, 23);
            sortbyComboBox.TabIndex = 5;
            sortbyComboBox.Text = "sort by";
            sortbyComboBox.SelectedIndexChanged += SortByComboBox;
            sortbyComboBox.Click += SortByComboBox;
            // 
            // SubscriptionCrud
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 591);
            Controls.Add(sortbyComboBox);
            Controls.Add(DeleteSubBtn);
            Controls.Add(EditSubBtn);
            Controls.Add(AddSubBtn);
            Controls.Add(SubscriptionsGridView);
            Controls.Add(label1);
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
    }
}
