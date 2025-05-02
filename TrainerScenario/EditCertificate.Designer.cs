namespace jim_membership.TrainerScenario
{
    partial class EditCertificate
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
            lbTrainerIDInput = new Label();
            txtDescription = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            lbDescription = new Label();
            lbTrainerID = new Label();
            SuspendLayout();
            // 
            // lbTrainerIDInput
            // 
            lbTrainerIDInput.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lbTrainerIDInput.Location = new Point(104, 18);
            lbTrainerIDInput.Name = "lbTrainerIDInput";
            lbTrainerIDInput.Size = new Size(172, 23);
            lbTrainerIDInput.TabIndex = 63;
            lbTrainerIDInput.Click += lbTrainerIDInput_Click;
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDescription.Location = new Point(104, 66);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(181, 23);
            txtDescription.TabIndex = 62;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancel.Location = new Point(170, 119);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 38);
            btnCancel.TabIndex = 61;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(16, 119);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 38);
            btnSave.TabIndex = 60;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbDescription
            // 
            lbDescription.Location = new Point(12, 69);
            lbDescription.Name = "lbDescription";
            lbDescription.Size = new Size(110, 23);
            lbDescription.TabIndex = 59;
            lbDescription.Text = "Desciption";
            // 
            // lbTrainerID
            // 
            lbTrainerID.Location = new Point(12, 18);
            lbTrainerID.Name = "lbTrainerID";
            lbTrainerID.Size = new Size(110, 23);
            lbTrainerID.TabIndex = 58;
            lbTrainerID.Text = "Trainer ID";
            // 
            // EditCertificate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(343, 176);
            Controls.Add(lbTrainerIDInput);
            Controls.Add(txtDescription);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lbDescription);
            Controls.Add(lbTrainerID);
            Name = "EditCertificate";
            Text = "EditCertificate";
            Load += EditCertificate_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTrainerIDInput;
        private TextBox txtDescription;
        private Button btnCancel;
        private Button btnSave;
        private Label lbDescription;
        private Label lbTrainerID;
    }
}