using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Threading;
namespace LibraryManagementSystem
{
    public partial class Registration_form : Form
    {

        public static string getemail = null;
        private string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        private SqlConnection conn = null;
        private SqlCommand cmd = null;

        // form initilizationi
        public Registration_form()
        {
            InitializeComponent();
            

        }
        // form loading with populated user type combobox
        private void Registration_form_Load(object sender, EventArgs e)
        {
            Get_user_type_Data();
           
        }

        public int user_id = 0;
        private void Register_Button_Click(object sender, EventArgs e)
        {
            
            // MessageBox.Show(Convert.ToString(user_type_combo.SelectedValue));
            // making name email to lowerCase and deleting extra white spaces between them
            string nameTxt = name_txt_box.Text.ToLower().Trim();
            string emailTxt = email_txt_box.Text.ToLower().Trim();

            if(FormValidation() != false)
            {
                using (conn = new SqlConnection(ConnectionString))
                {
                    #region inserting registered user data to database
                    try
                    {
                      
                        cmd = new SqlCommand("Select user_id from user_registration_tbl where email = @email", conn);
                        cmd.Parameters.AddWithValue("@email", emailTxt);
                        conn.Open();

                        var nId = cmd.ExecuteScalar();

                        if (nId != null)
                        {
                            MessageBox.Show(string.Format("User associated with '' {0} ''email address already Exist",email_txt_box.Text));
                        }
                        else
                        {
                            // Now finally inserting neat and clean data to the server
                            cmd = new SqlCommand("AddUser", conn);
                            cmd.CommandType = CommandType.StoredProcedure;
                            //we can use like this
                            SqlParameter pram = new SqlParameter();
                            pram.ParameterName = "@nameDB";
                            pram.Value = nameTxt;
                            cmd.Parameters.Add(pram);
                            //we can use like this end
                            //or we can use like this
                            cmd.Parameters.AddWithValue("@emailDB", emailTxt);
                            cmd.Parameters.AddWithValue("@phone_noDB", phone_no_txt_box.Text.Trim());
                            cmd.Parameters.AddWithValue("@passwordDB", password_txt_box.Text.Trim());
                            cmd.Parameters.AddWithValue("@type_combo_boxDB", Convert.ToInt32(user_type_combo.SelectedValue));
                            cmd.Parameters.AddWithValue("@genderDB", Getgender());
                            cmd.Parameters.AddWithValue("@user_register_date_timeDB", DateTime.Now.ToString());
                           
                            int row = cmd.ExecuteNonQuery();
                            if (row > 0)
                            {
                            
                                MessageBox.Show("user registerd","Registerd",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
                                ClearFields();

                                int columnValue = 0;
                                columnValue = Convert.ToInt32(user_type_combo.SelectedValue);

                                getemail = email_txt_box.Text;


                                if (columnValue == 1)
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
                                MessageBox.Show("user could not registerd");
                            }

                        } // ending else block


                    } // ending try block

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    #endregion
                } // ending using block that't which is closing connection

            } // ending if condition
        }

        Thread th;

        // link to login form

        #region switching register form window to another form

        private void Loginlabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
           
            th = new Thread(OpenLoginForm);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            this.Close();
        }
        private void OpenLoginForm()
        {
            Application.Run(new login_form());
        }
        #endregion  


        #region make fields clear after inserting data
        private void ClearFields()
        {
            name_txt_box.Text  = phone_no_txt_box.Text = password_txt_box.Text
                = confirm_password_txt_box.Text = "";
            male_radio_btn.TabStop = false;
            female_radio_btn.TabStop = false;

        }
        #endregion

        #region entering digits instead male female
        private int Getgender()
        {
            if (male_radio_btn.Checked)
            {
                return 1;
            }
            else if (female_radio_btn.Checked)
            {
                return 2;
            }
            else
            {
                return 0;
            }
        }
        #endregion

        #region Redgex for name , phone number , email
        public static bool CheckName(string name)
        {
            var reg = new Regex(@"^[A-Za-z ]{3,10}$");
            if (!reg.IsMatch(name))
            {

                return false;
            }
            else
            {

                return true;
            }
        }

        public static bool CheckPhone(string phone)
        {
            var reg = new Regex(@"^[0-9]{11}$");
            if (!reg.IsMatch(phone))
            {

                return false;
            }
            else
            {

                return true;
            }
        }
        // Csharp method
        public bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        public static bool CheckEmail(string email)
        {
            var reg = new Regex(@"^\s*[\w\-\+_]+(\.[\w\-\+_]+)*\@[\w\-\+_]+\.[\w\-\+_]+(\.[\w\-\+_]+)*\s*$");
            if (!reg.IsMatch(email))
            {

                return false;
            }
            else
            {

                return true;
            }
        }
        #endregion

        #region fill combobox with user_type

        public void Get_user_type_Data()
        {
            using (conn = new SqlConnection(ConnectionString))
            {
                try
                {

                    //Fill the DataTable with records from Table.
                    string Query = "select user_type_id, user_type from user_type_tbl";
                    SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    //Insert the Default Item to DataTable.

                    DataRow row = dt.NewRow();
                    row[0] = 0;
                    row[1] = "Select user type";
                    dt.Rows.InsertAt(row, 0);

                    //Assign DataTable as DataSource

                    user_type_combo.DataSource = dt;
                    user_type_combo.DisplayMember = "user_type";
                    user_type_combo.ValueMember = "user_type_id";


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        #endregion

        #region validation
        public bool FormValidation()
        {
           
            // validation for empty form
            if (name_txt_box.Text == "" && email_txt_box.Text == "" && phone_no_txt_box.Text == "" && password_txt_box.Text == "" && confirm_password_txt_box.Text == "" && user_type_combo.Text == "Select user type")
            {
                MessageBox.Show("Form can not be submited empty");
                return false;
            }


            //validation for name
            else if (CheckName(name_txt_box.Text) != true)
            {
                MessageBox.Show("name must be 3 to 10 charchter long with only alphabets");
                return false;
            }
            // Validation for email
            else if (IsValidEmail(email_txt_box.Text) != true)
            {
                MessageBox.Show("Please pass email address in correct format", "Email Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            // validation for phone number
            else if (CheckPhone(phone_no_txt_box.Text) != true)
            {
                MessageBox.Show("Phone number should be 11 digits long");
                return false;
            }
            // validation for password
            else if (password_txt_box.Text.Length < 7)
            {
                MessageBox.Show("Password must be at least 7 charachter long");
                return false;
            }
            else if (confirm_password_txt_box.Text != password_txt_box.Text)
            {
                MessageBox.Show("Password did not matched");
                return false;
            }

            else if (!(male_radio_btn.Checked || female_radio_btn.Checked))
            {
                MessageBox.Show("Please input your gender");
                return false;
            }
            else if (user_type_combo.Text == "Select user type")
            {
                MessageBox.Show("Please Select your user type");
                return false;
            }
            else
            {
                return true;
            }
     
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
