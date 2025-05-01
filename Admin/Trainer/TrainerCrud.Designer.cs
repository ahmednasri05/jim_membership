using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace jim_membership.Admin
{
    partial class TrainerCrud
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
            textBox1 = new TextBox();
            TrainersGridView = new DataGridView();
            AddTrainerBtn = new Button();
            EditTrainerBtn = new Button();
            DeleteTrainerBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)TrainersGridView).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.MenuHighlight;
            textBox1.Location = new Point(345, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(176, 39);
            textBox1.TabIndex = 0;
            textBox1.Text = "Trainers Table";
            // 
            // TrainersGridView
            // 
            TrainersGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            TrainersGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TrainersGridView.Location = new Point(3, 221);
            TrainersGridView.MultiSelect = false;
            TrainersGridView.Name = "TrainersGridView";
            TrainersGridView.ReadOnly = true;
            TrainersGridView.RowHeadersVisible = false;
            TrainersGridView.RowTemplate.Height = 25;
            TrainersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TrainersGridView.Size = new Size(871, 358);
            TrainersGridView.TabIndex = 1;
            TrainersGridView.CellContentClick += TrainersGridView_CellContentClick;
            // 
            // AddTrainerBtn
            // 
            AddTrainerBtn.Location = new Point(12, 186);
            AddTrainerBtn.Name = "AddTrainerBtn";
            AddTrainerBtn.Size = new Size(96, 23);
            AddTrainerBtn.TabIndex = 2;
            AddTrainerBtn.Text = "Add Trainer";
            AddTrainerBtn.UseVisualStyleBackColor = true;
            AddTrainerBtn.Click += AddTrainerBtn_Click;
            // 
            // EditTrainerBtn
            // 
            EditTrainerBtn.Location = new Point(641, 186);
            EditTrainerBtn.Name = "EditTrainerBtn";
            EditTrainerBtn.Size = new Size(75, 23);
            EditTrainerBtn.TabIndex = 3;
            EditTrainerBtn.Text = "Edit";
            EditTrainerBtn.UseVisualStyleBackColor = true;
            EditTrainerBtn.Click += EditTrainerBtn_Click;
            // 
            // DeleteTrainerBtn
            // 
            DeleteTrainerBtn.Location = new Point(757, 186);
            DeleteTrainerBtn.Name = "DeleteTrainerBtn";
            DeleteTrainerBtn.Size = new Size(75, 23);
            DeleteTrainerBtn.TabIndex = 4;
            DeleteTrainerBtn.Text = "Delete";
            DeleteTrainerBtn.UseVisualStyleBackColor = true;
            DeleteTrainerBtn.Click += DeleteTrainerBtn_Click;
            // 
            // Trainers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 591);
            Controls.Add(DeleteTrainerBtn);
            Controls.Add(EditTrainerBtn);
            Controls.Add(AddTrainerBtn);
            Controls.Add(TrainersGridView);
            Controls.Add(textBox1);
            Name = "Trainers";
            Text = "Trainers";
            ((System.ComponentModel.ISupportInitialize)TrainersGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private DataGridView TrainersGridView;
        private Button AddTrainerBtn;
        private Button EditTrainerBtn;
        private Button DeleteTrainerBtn;
    }
}