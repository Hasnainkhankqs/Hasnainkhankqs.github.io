using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Threading;

using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class login_form : Form
    {
        public static string getemail = null;
        
        private string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        private SqlConnection conn = null;
        private SqlCommand cmd = null;

        public login_form()
        {
            InitializeComponent();
        } 
       

        

        private void Login_form_Load(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(ConnectionString))
            {
                User_profile_form profile = new User_profile_form();
                profile.email_lbl.Text = email_txt.Text;
            }
           
        }
       
        public int user_id = 0;
        
        public void Login_btn_Click(object sender, EventArgs e)
        {
            
            using (conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    string Query = "select user_id FROM user_registration_tbl WHERE email = @email and password = @password";
                    cmd = new SqlCommand(Query,conn);
                    
                    cmd.Parameters.AddWithValue("@email",email_txt.Text);
                    cmd.Parameters.AddWithValue("@password",password_txt.Text);

                    /*****************************/

                    getemail = email_txt.Text;
                    
                    /*****************************/

                    var check = cmd.ExecuteScalar();

                    if(check != null)
                    {
                        MessageBox.Show("Login Succesful","Success!!",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

                        string Query2 = "select user_id , type_combo_box FROM user_registration_tbl WHERE email = @email ";
                        cmd = new SqlCommand(Query2, conn);

                        cmd.Parameters.AddWithValue("@email", email_txt.Text);
                        int columnValue = 0;
                        
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {

                            user_id = Convert.ToInt32(dr["user_id"]);
                            columnValue = Convert.ToInt32(dr["type_combo_box"]);
                        }

                        if(columnValue == 1)
                        {
                                th = new Thread(OpenAdminForm);
                                th.SetApartmentState(ApartmentState.STA);
                                th.Start();
                                this.Close();
                            
                        }
                        else if (columnValue == 2)
                        {
                            MessageBox.Show("Librarian");
                            th = new Thread(OpenLibrarianForm);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                            this.Close();
                        }
                        else if (columnValue == 3)
                        {
                            MessageBox.Show("Secretary");
                            
                            th = new Thread(OpenSecrataryForm);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                            this.Close();
                        }
                        else if (columnValue == 4)
                        {
                            MessageBox.Show("Member");
                            th = new Thread(OpenUserProfileForm);
                            th.SetApartmentState(ApartmentState.STA);
                            th.Start();
                            this.Close();

                        }
                        else
                        {
                            MessageBox.Show("Bad Value in user type");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid Password or email address", "Login Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                }// end of try block

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
              
            } // end of using block so connection closed too
           
        }

       



        #region Registration Form link
        // opening registration form
        Thread th;
        private void Register_link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            th = new Thread(OpenRegistrationForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }


        #endregion
      
        #region form opening methods
        private void OpenAdminForm()
        {
            Application.Run(new Admin_panal());
        }
        private void OpenRegistrationForm()
        {
            Application.Run(new Registration_form());
        }
        private void OpenUserProfileForm()
        {
            Application.Run(new User_profile_form());
           
        }
        private void OpenSecrataryForm()
        {
            Application.Run(new Secratary_form());
        }
        private void OpenLibrarianForm()
        {
            Application.Run(new Librarian_form());
        }



        #endregion

    }



}

