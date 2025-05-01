namespace jim_membership.models
{
    partial class Reservation
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
        /// Required method for Designer support - do not modify the contents of this method with the code editor.  
        /// </summary>  
        private void InitializeComponent()
        {
            SuspendLayout();
            //   
            // Reservation  
            //   
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Reservation";
            Text = "Form2";
            Load += Reservation_Load;
            ResumeLayout(false);
        }

        #endregion

        /// <summary>  
        /// Event handler for the Load event of the Reservation form.  
        /// </summary>  
        private void Reservation_Load(object sender, EventArgs e)
        {
            // Add your initialization code here.  
        }
    }
}
namespace jim_membership.models
{
    partial class Reservation : System.Windows.Forms.Form
    {
        // Existing code remains unchanged
    }
}
