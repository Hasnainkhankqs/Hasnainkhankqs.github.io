using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Admin_panal : Form
    {
        public Admin_panal()
        {
            InitializeComponent();
        }

        private void UsersDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            All_registered_users users = new All_registered_users();
            users.Show();
        }

        private void MaybeDeleted_Load(object sender, EventArgs e)
        {
           
            if (login_form.getemail != null)
            {
                admin_name_lbl.Text = login_form.getemail;
            }
            else
            {
                admin_name_lbl.Text = Registration_form.getemail;
            }
        }
    }
}
