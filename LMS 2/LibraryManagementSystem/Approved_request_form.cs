using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Approved_request_form : Form
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        public Approved_request_form()
        {
            InitializeComponent();
        }

        private void Approved_request_form_Load(object sender, EventArgs e)
        {
            Load_basic_info();
        }
        public void Approved()
        {
            using (conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                
            }
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
                    
                    Approved(user_id,approved_request_grid_view);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        public void Approved(int user_id, DataGridView x)
        {
            using (conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "select * from approved_tbl where user_id = @user_id";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user_id", user_id);
                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(ds, "1");
                    x.DataSource = ds.Tables["1"];
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }
    }
}
