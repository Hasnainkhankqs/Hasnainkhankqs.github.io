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
    public partial class For_librarian_requests_form : Form
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        int item_id = 0;
        int item_counting;
        public For_librarian_requests_form()
        {
            InitializeComponent();
        }

        private void For_librarian_requests_form_Load(object sender, EventArgs e)
        {
            Requests_History(requests_gridview);
        }

        #region  //Loading All users not pending history to the gridview
        public void Requests_History(DataGridView x)
        {
            using (conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    DateTime now = DateTime.Now;
                    string query = "select R.user_id , R.name , R.email , R.phone_no , C.category_type , I.item_name , L.loan_date , L.due_date ,I.item_id,L.loan_id from user_registration_tbl R join loan_tbl L on R.user_id = L.user_id join item_tbl I on L.item_id = I.item_id join category_tbl C on I.category_name = C.category_id where L.due_date > @now";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@now", now);
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
        #endregion

        private void Request_accept_btn_Click(object sender, EventArgs e)
        {
            //getting quantity of the current clicked row item

            using (conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                item_id = Convert.ToInt32(requests_gridview.CurrentRow.Cells["item_id"].Value);
                string count = "select quantity from item_tbl where item_id = @item_id";
                cmd = new SqlCommand(count, conn);
                cmd.Parameters.AddWithValue("@item_id", item_id);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    item_counting = Convert.ToInt32(dr["quantity"]);

                }
            }// closing of using

            //inserting item id

            //inserting data into approved_tble to allow memeber to take his /her item
            if (item_counting > 0)
            {
                using (conn = new SqlConnection(ConnectionString))
                {
                    int loan_id = Convert.ToInt32(requests_gridview.CurrentRow.Cells["loan_id"].Value);
                    try
                    {

                        conn.Open();
                        int user_id = 0, item_id = 0, category_id = 0;
                        string selectQuery = "select * from loan_tbl where loan_id = @loan_id";
                        cmd = new SqlCommand(selectQuery, conn);
                        cmd.Parameters.AddWithValue("@loan_id", loan_id);
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            user_id = Convert.ToInt32(dr["user_id"]);
                            item_id = Convert.ToInt32(dr["item_id"]);
                            category_id = Convert.ToInt32(dr["category_id"]);
                        }

                        dr.Close();

                        string due_date = "";
                        string insertQuery = "insert into approved_tbl (user_id,item_id,category_id,approved_date,due_date) values (@user_id,@item_id,@category_id,@approved_date,@due_date)";
                        cmd = new SqlCommand(insertQuery, conn);
                        cmd.Parameters.AddWithValue("@user_id", user_id);
                        cmd.Parameters.AddWithValue("@item_id", item_id);
                        cmd.Parameters.AddWithValue("@category_id", category_id);
                        cmd.Parameters.AddWithValue("@approved_date", DateTime.Now.ToString());
                        if (category_id == 1)
                        {
                            due_date = DateTime.Now.AddDays(28).ToString();
                        }
                        else
                        {
                            due_date = DateTime.Now.AddDays(7).ToString();
                        }
                        cmd.Parameters.AddWithValue("@due_date", due_date);
                        cmd.ExecuteNonQuery();


                        string str = "delete loan_tbl where loan_id = @loan_id";
                        cmd = new SqlCommand(str, conn);
                        cmd.Parameters.AddWithValue("@loan_id", loan_id);
                        cmd.ExecuteNonQuery();
                        item_counting--;
                        using (conn = new SqlConnection(ConnectionString))
                        {
                            conn.Open();
                            string counting_test = "update item_tbl set quantity = @quantity where item_id = @item_id";
                            cmd = new SqlCommand(counting_test, conn);
                            cmd.Parameters.AddWithValue("@quantity", item_counting);
                            cmd.Parameters.AddWithValue("@item_id", item_id);
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Success");

                        Requests_History(requests_gridview);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show(ex.Message);
                    }


                }
            }
            else
            {
                MessageBox.Show("item Has been finished");
            }
        }
    } 
}
