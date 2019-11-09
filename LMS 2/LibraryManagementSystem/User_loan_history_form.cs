using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class User_loan_history_form : Form
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        public User_loan_history_form()
        {
            InitializeComponent();
        }

        private void User_loan_history_form_Load(object sender, EventArgs e)
        {
            Load_basic_info();
        }
        public void Load_basic_info()
        {
            int user_id = 0;
            using (conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string Query = "select * FROM user_registration_tbl WHERE email = @email";
                    cmd = new SqlCommand(Query, conn);


                    if (login_form.getemail != null)
                    {

                        cmd.Parameters.AddWithValue("@email", login_form.getemail);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            user_id = Convert.ToInt32(dr["user_id"]);

                        }

                    }
                    else
                    {

                        cmd.Parameters.AddWithValue("@email", Registration_form.getemail);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            user_id = Convert.ToInt32(dr["user_id"]);

                        }

                    }
                    User_profile_form profile = new User_profile_form();
                    profile.LoanHistory(user_id, user_loan_history_gridview);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
