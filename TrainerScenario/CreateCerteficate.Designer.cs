﻿namespace jim_membership.TrainerScenario
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
            txtDescription = new TextBox();
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
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDescription.Location = new Point(159, 81);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(181, 23);
            txtDescription.TabIndex = 54;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Location = new Point(221, 131);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 38);
            btnCancel.TabIndex = 49;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 131);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 38);
            btnSave.TabIndex = 48;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
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
            lbTrainerIDInput.Location = new Point(159, 30);
            lbTrainerIDInput.Name = "lbTrainerIDInput";
            lbTrainerIDInput.Size = new Size(172, 23);
            lbTrainerIDInput.TabIndex = 57;
            lbTrainerIDInput.Click += lbTrainerIDInput_Click;
            // 
            // CreateCerteficate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(361, 196);
            Controls.Add(lbTrainerIDInput);
            Controls.Add(lbTrainerInfo);
            Controls.Add(txtDescription);
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
        private TextBox txtDescription;
    }
}