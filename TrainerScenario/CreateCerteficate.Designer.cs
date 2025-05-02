namespace jim_membership.TrainerScenario
{
    partial class CreateCerteficate
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
            lbTrainerInfo = new Label();
            textBox8 = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            lbDescription = new Label();
            lbTrainerID = new Label();
            lbTrainerIDInput = new Label();
            SuspendLayout();
            // 
            // lbTrainerInfo
            // 
            lbTrainerInfo.Location = new Point(410, 94);
            lbTrainerInfo.Name = "lbTrainerInfo";
            lbTrainerInfo.Size = new Size(110, 23);
            lbTrainerInfo.TabIndex = 56;
            // 
            // textBox8
            // 
            textBox8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox8.Location = new Point(154, 81);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(119, 23);
            textBox8.TabIndex = 54;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Location = new Point(154, 131);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 38);
            btnCancel.TabIndex = 49;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 131);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 38);
            btnSave.TabIndex = 48;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lbDescription
            // 
            lbDescription.Location = new Point(12, 81);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(110, 23);
            lbDescription.TabIndex = 47;
            lbDescription.Text = "Desciption";
            // 
            // lbTrainerID
            // 
            lbTrainerID.Location = new Point(12, 30);
            lbTrainerID.Name = "lbTrainerID";
            lbTrainerID.Size = new Size(110, 23);
            lbTrainerID.TabIndex = 41;
            lbTrainerID.Text = "Trainer ID";
            // 
            // lbTrainerIDInput
            // 
            lbTrainerIDInput.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbTrainerIDInput.Location = new Point(154, 30);
            lbTrainerIDInput.Name = "lbTrainerIDInput";
            lbTrainerIDInput.Size = new Size(110, 23);
            lbTrainerIDInput.TabIndex = 57;
            // 
            // CreateCerteficate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 196);
            Controls.Add(lbTrainerIDInput);
            Controls.Add(lbTrainerInfo);
            Controls.Add(textBox8);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lbDescription);
            Controls.Add(lbTrainerID);
            Name = "CreateCerteficate";
            Text = "CreateCerteficate";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTrainerInfo;
        private TextBox textBox8;
        private Button btnCancel;
        private Button btnSave;
        private Label lbDescription;
        private Label lbTrainerID;
        private Label lbTrainerIDInput;
    }
}