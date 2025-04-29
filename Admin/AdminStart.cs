using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jim_membership.Admin
{
    public partial class AdminStart : Form
    {
        public AdminStart()
        {
            InitializeComponent();
            Users.SelectedIndexChanged += tabUsers_SelectedIndexChanged;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tabUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            var form = new UserCrud();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            Userss.Controls.Add(form);
            form.Show();

        }

        private void tabtrainer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
