using jim_membership.models;

namespace jim_membership.Admin
{
    partial class SubscriptionsReportForm
    {
        private System.ComponentModel.IContainer components = null;

        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Button btnGenerateReport;
        private Label lblNumOfMembers;
        private Label lblNumberOfPayments;
        private Label lblTotalAmountPaid;
        private Label label1;
        private Label label2;
        private Label label3;

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
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            btnGenerateReport = new Button();
            lblNumOfMembers = new Label();
            lblNumberOfPayments = new Label();
            lblTotalAmountPaid = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();

            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(12, 12);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(120, 23);
            dtpStartDate.TabIndex = 0;

            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(150, 12);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(120, 23);
            dtpEndDate.TabIndex = 1;

            // 
            // btnGenerateReport
            // 
            btnGenerateReport.Location = new Point(300, 12);
            btnGenerateReport.Name = "btnGenerateReport";
            btnGenerateReport.Size = new Size(120, 23);
            btnGenerateReport.TabIndex = 2;
            btnGenerateReport.Text = "Generate Report";
            btnGenerateReport.UseVisualStyleBackColor = true;
            btnGenerateReport.Click += btnGenerateReport_Click;

            // 
            // lblNumOfMembers
            // 
            lblNumOfMembers.AutoSize = true;
            lblNumOfMembers.Location = new Point(150, 50);
            lblNumOfMembers.Name = "lblNumOfMembers";
            lblNumOfMembers.Size = new Size(13, 15);
            lblNumOfMembers.TabIndex = 3;
            lblNumOfMembers.Text = "0";

            // 
            // lblNumberOfPayments
            // 
            lblNumberOfPayments.AutoSize = true;
            lblNumberOfPayments.Location = new Point(150, 80);
            lblNumberOfPayments.Name = "lblNumberOfPayments";
            lblNumberOfPayments.Size = new Size(13, 15);
            lblNumberOfPayments.TabIndex = 4;
            lblNumberOfPayments.Text = "0";

            // 
            // lblTotalAmountPaid
            // 
            lblTotalAmountPaid.AutoSize = true;
            lblTotalAmountPaid.Location = new Point(150, 110);
            lblTotalAmountPaid.Name = "lblTotalAmountPaid";
            lblTotalAmountPaid.Size = new Size(28, 15);
            lblTotalAmountPaid.TabIndex = 5;
            lblTotalAmountPaid.Text = "0.00";

            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 50);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 6;
            label1.Text = "Number of Members:";

            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 80);
            label2.Name = "label2";
            label2.Size = new Size(125, 15);
            label2.TabIndex = 7;
            label2.Text = "Number of Payments:";

            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 110);
            label3.Name = "label3";
            label3.Size = new Size(104, 15);
            label3.TabIndex = 8;
            label3.Text = "Total Amount Paid:";

            // 
            // SubscriptionsReportForm
            // 
            ClientSize = new Size(450, 150);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTotalAmountPaid);
            Controls.Add(lblNumberOfPayments);
            Controls.Add(lblNumOfMembers);
            Controls.Add(btnGenerateReport);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Name = "SubscriptionsReportForm";
            Text = "Subscriptions Report";
            ResumeLayout(false);
            PerformLayout();
        }
    }
}