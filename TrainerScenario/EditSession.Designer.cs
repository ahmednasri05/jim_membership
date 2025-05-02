namespace jim_membership.TrainerScenario
{
    partial class EditSession
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
            nudDuration = new NumericUpDown();
            nudMaxAtt = new NumericUpDown();
            dtpDate = new DateTimePicker();
            lbMaxNumber = new Label();
            lbSessionNumber = new Label();
            lbTrainerName = new Label();
            txtTime = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            lbDescription = new Label();
            lbType = new Label();
            lbDuration = new Label();
            Time = new Label();
            Date = new Label();
            lbBranchNo = new Label();
            label2 = new Label();
            lbSessionNo = new Label();
            lbBranchNumber = new Label();
            txtType = new TextBox();
            txtDescription = new TextBox();
            ((System.ComponentModel.ISupportInitialize)nudDuration).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxAtt).BeginInit();
            SuspendLayout();
            // 
            // nudDuration
            // 
            nudDuration.Location = new Point(170, 189);
            nudDuration.Name = "nudDuration";
            nudDuration.Size = new Size(199, 23);
            nudDuration.TabIndex = 65;
            // 
            // nudMaxAtt
            // 
            nudMaxAtt.Location = new Point(170, 296);
            nudMaxAtt.Name = "nudMaxAtt";
            nudMaxAtt.Size = new Size(199, 23);
            nudMaxAtt.TabIndex = 64;
            // 
            // dtpDate
            // 
            dtpDate.Location = new Point(170, 122);
            dtpDate.Name = "dtpDate";
            dtpDate.Size = new Size(199, 23);
            dtpDate.TabIndex = 63;
            // 
            // lbMaxNumber
            // 
            lbMaxNumber.Location = new Point(30, 298);
            lbMaxNumber.Name = "lbMaxNumber";
            lbMaxNumber.Size = new Size(121, 23);
            lbMaxNumber.TabIndex = 61;
            lbMaxNumber.Text = "Maximum Attendees";
            // 
            // lbSessionNumber
            // 
            lbSessionNumber.Location = new Point(170, 24);
            lbSessionNumber.Name = "lbSessionNumber";
            lbSessionNumber.Size = new Size(199, 23);
            lbSessionNumber.TabIndex = 60;
            lbSessionNumber.Click += lbSessionNumber_Click;
            // 
            // lbTrainerName
            // 
            lbTrainerName.Location = new Point(170, 56);
            lbTrainerName.Name = "lbTrainerName";
            lbTrainerName.Size = new Size(199, 23);
            lbTrainerName.TabIndex = 59;
            lbTrainerName.Click += lbTrainerName_Click;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(170, 155);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(199, 23);
            txtTime.TabIndex = 56;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(170, 376);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 38);
            btnCancel.TabIndex = 55;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(30, 376);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 38);
            btnSave.TabIndex = 54;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbDescription
            // 
            lbDescription.Location = new Point(30, 259);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(110, 23);
            lbDescription.TabIndex = 53;
            lbDescription.Text = "Desciption";
            // 
            // lbType
            // 
            lbType.Location = new Point(30, 225);
            lbType.Name = "lbType";
            lbType.Size = new Size(110, 23);
            lbType.TabIndex = 52;
            lbType.Text = "Type";
            // 
            // lbDuration
            // 
            lbDuration.Location = new Point(30, 189);
            lbDuration.Name = "lbDuration";
            lbDuration.Size = new Size(110, 23);
            lbDuration.TabIndex = 51;
            lbDuration.Text = "Duration (min)";
            // 
            // Time
            // 
            Time.Location = new Point(30, 155);
            Time.Name = "Time";
            Time.Size = new Size(110, 23);
            Time.TabIndex = 50;
            Time.Text = "Time (24h)";
            // 
            // Date
            // 
            Date.Location = new Point(30, 122);
            Date.Name = "Date";
            Date.Size = new Size(110, 23);
            Date.TabIndex = 49;
            Date.Text = "Date";
            // 
            // lbBranchNo
            // 
            lbBranchNo.Location = new Point(30, 89);
            lbBranchNo.Name = "lbBranchNo";
            lbBranchNo.Size = new Size(110, 23);
            lbBranchNo.TabIndex = 48;
            lbBranchNo.Text = "Branch Number";
            // 
            // label2
            // 
            label2.Location = new Point(30, 56);
            label2.Name = "label2";
            label2.Size = new Size(110, 23);
            label2.TabIndex = 47;
            label2.Text = "Trainer ID - Name";
            // 
            // lbSessionNo
            // 
            lbSessionNo.Location = new Point(30, 24);
            lbSessionNo.Name = "lbSessionNo";
            lbSessionNo.Size = new Size(110, 23);
            lbSessionNo.TabIndex = 46;
            lbSessionNo.Text = "Session Number";
            // 
            // lbBranchNumber
            // 
            lbBranchNumber.Location = new Point(170, 89);
            lbBranchNumber.Name = "lbBranchNumber";
            lbBranchNumber.Size = new Size(199, 23);
            lbBranchNumber.TabIndex = 66;
            lbBranchNumber.Click += lbBranchNumber_Click;
            // 
            // txtType
            // 
            txtType.Location = new Point(170, 222);
            txtType.Name = "txtType";
            txtType.Size = new Size(199, 23);
            txtType.TabIndex = 67;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(170, 256);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(199, 23);
            txtDescription.TabIndex = 68;
            // 
            // EditSession
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 433);
            Controls.Add(txtDescription);
            Controls.Add(txtType);
            Controls.Add(lbBranchNumber);
            Controls.Add(nudDuration);
            Controls.Add(nudMaxAtt);
            Controls.Add(dtpDate);
            Controls.Add(lbMaxNumber);
            Controls.Add(lbSessionNumber);
            Controls.Add(lbTrainerName);
            Controls.Add(txtTime);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lbDescription);
            Controls.Add(lbType);
            Controls.Add(lbDuration);
            Controls.Add(Time);
            Controls.Add(Date);
            Controls.Add(lbBranchNo);
            Controls.Add(label2);
            Controls.Add(lbSessionNo);
            Name = "EditSession";
            Text = "EditSession";
            ((System.ComponentModel.ISupportInitialize)nudDuration).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxAtt).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown nudDuration;
        private NumericUpDown nudMaxAtt;
        private DateTimePicker dtpDate;
        private Label lbMaxNumber;
        private Label lbSessionNumber;
        private Label lbTrainerName;
        private TextBox txtTime;
        private Button btnCancel;
        private Button btnSave;
        private Label lbDescription;
        private Label lbType;
        private Label lbDuration;
        private Label Time;
        private Label Date;
        private Label lbBranchNo;
        private Label label2;
        private Label lbSessionNo;
        private Label lbBranchNumber;
        private TextBox txtType;
        private TextBox txtDescription;
    }
}