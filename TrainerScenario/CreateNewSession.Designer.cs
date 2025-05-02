namespace jim_membership.TrainerScenario
{
    partial class CreateNewSession
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
            lbSessionNo = new Label();
            label2 = new Label();
            lbBranchNo = new Label();
            Date = new Label();
            Time = new Label();
            lbDuration = new Label();
            lbType = new Label();
            lbDescription = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            textBox5 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            lbTrainerName = new Label();
            lbSessionNumber = new Label();
            lbMaxNumber = new Label();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // lbSessionNo
            // 
            lbSessionNo.Location = new Point(30, 32);
            lbSessionNo.Name = "lbSessionNo";
            lbSessionNo.Size = new Size(110, 23);
            lbSessionNo.TabIndex = 0;
            lbSessionNo.Text = "Session Number";
            lbSessionNo.Click += label1_Click;
            // 
            // label2
            // 
            label2.Location = new Point(30, 64);
            label2.Name = "label2";
            label2.Size = new Size(110, 23);
            label2.TabIndex = 2;
            label2.Text = "Trainer ID - Name";
            // 
            // lbBranchNo
            // 
            lbBranchNo.Location = new Point(30, 97);
            lbBranchNo.Name = "lbBranchNo";
            lbBranchNo.Size = new Size(110, 23);
            lbBranchNo.TabIndex = 3;
            lbBranchNo.Text = "Branch Number";
            lbBranchNo.Click += label3_Click;
            // 
            // Date
            // 
            Date.Location = new Point(30, 130);
            Date.Name = "Date";
            Date.Size = new Size(110, 23);
            Date.TabIndex = 4;
            Date.Text = "Date";
            // 
            // Time
            // 
            Time.Location = new Point(30, 163);
            Time.Name = "Time";
            Time.Size = new Size(110, 23);
            Time.TabIndex = 5;
            Time.Text = "Time (24h)";
            // 
            // lbDuration
            // 
            lbDuration.Location = new Point(30, 197);
            lbDuration.Name = "lbDuration";
            lbDuration.Size = new Size(110, 23);
            lbDuration.TabIndex = 6;
            lbDuration.Text = "Duration (min)";
            // 
            // lbType
            // 
            lbType.Location = new Point(30, 233);
            lbType.Name = "lbType";
            lbType.Size = new Size(110, 23);
            lbType.TabIndex = 7;
            lbType.Text = "Type";
            // 
            // lbDescription
            // 
            lbDescription.Location = new Point(30, 267);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(110, 23);
            lbDescription.TabIndex = 8;
            lbDescription.Text = "Desciption";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(30, 384);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 38);
            btnSave.TabIndex = 11;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(170, 384);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 38);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(170, 163);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(199, 23);
            textBox5.TabIndex = 15;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(170, 230);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(199, 23);
            textBox7.TabIndex = 17;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(170, 267);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(199, 23);
            textBox8.TabIndex = 18;
            // 
            // lbTrainerName
            // 
            lbTrainerName.Location = new Point(170, 64);
            lbTrainerName.Name = "lbTrainerName";
            lbTrainerName.Size = new Size(199, 23);
            lbTrainerName.TabIndex = 38;
            // 
            // lbSessionNumber
            // 
            lbSessionNumber.Location = new Point(170, 32);
            lbSessionNumber.Name = "lbSessionNumber";
            lbSessionNumber.Size = new Size(199, 23);
            lbSessionNumber.TabIndex = 39;
            // 
            // lbMaxNumber
            // 
            lbMaxNumber.Location = new Point(30, 306);
            lbMaxNumber.Name = "lbMaxNumber";
            lbMaxNumber.Size = new Size(121, 23);
            lbMaxNumber.TabIndex = 40;
            lbMaxNumber.Text = "Maximum Attendees";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(170, 94);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(199, 23);
            comboBox1.TabIndex = 42;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(170, 130);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(199, 23);
            dateTimePicker1.TabIndex = 43;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(170, 304);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(199, 23);
            numericUpDown1.TabIndex = 44;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(170, 197);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(199, 23);
            numericUpDown2.TabIndex = 45;
            // 
            // CreateNewSession
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(381, 443);
            Controls.Add(numericUpDown2);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(lbMaxNumber);
            Controls.Add(lbSessionNumber);
            Controls.Add(lbTrainerName);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox5);
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
            Name = "CreateNewSession";
            Text = "CreateNewSession";
            Load += CreateNewSession_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbSessionNo;
        private Label label2;
        private Label lbBranchNo;
        private Label Date;
        private Label Time;
        private Label lbDuration;
        private Label lbType;
        private Label lbDescription;
        private Button btnSave;
        private Button btnCancel;
        private TextBox textBox5;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label lbTrainerName;
        private Label lbSessionNumber;
        private Label lbMaxNumber;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
    }
}