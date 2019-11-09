using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace LibraryManagementSystem
{
    public partial class Message_from_librarian_form : Form
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        int user_id;
        public Message_from_librarian_form()
        {
            InitializeComponent();
        }

        private void Message_from_librarian_form_Load(object sender, EventArgs e)
        {
            Load_basic_info();
            

        }
        public void Loadmessages(DataGridView x)
        {
           
                using (conn = new SqlConnection(ConnectionString))
                {
                    try
                    {
                        conn.Open();

                    string query = "select * from pending_message_tbl where user_id = @user_id";
                        cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user_id",user_id);
                        DataSet ds = new DataSet();
                        DataTable dt = new DataTable();
                        //ds.Tables["Loan History"];
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(ds, "1");
                        x.DataSource = ds.Tables["1"];
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }// ending of using 
            
        }
        public void Load_basic_info()
        {
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

                    Loadmessages(message_grid_view);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
        //protected void GrdView_RowDataBound(object sender, GridViewRowEventArgs e)
        //{

        //    if (e.Row.RowType == DataControlRowType.DataRow)
        //    {
        //        grdListings.Columns[0].ItemStyle.Width = 50;
        //    }
        //}
    }
}
