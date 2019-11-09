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
    public partial class For_librarian_pending_form : Form
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        int user_id,item_id;
        string warnningMessage;
        public For_librarian_pending_form()
        {
            InitializeComponent();
        }

        private void For_librarian_pending_form_Load(object sender, EventArgs e)
        {
            //loading due history of all the users
            Due_History(pending_gridview);
        }

        //method for history
        public void Due_History(DataGridView x)
        {
            using (conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    DateTime now = DateTime.Now;
                    string query = "select R.user_id , R.name , R.email , R.phone_no , C.category_type , I.item_name , L.loan_date , L.due_date ,L.loan_id ,I.item_id from user_registration_tbl R join loan_tbl L on R.user_id = L.user_id join item_tbl I on L.item_id = I.item_id join category_tbl C on I.category_name = C.category_id where L.due_date < @now";
                    cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@now", now);
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


        private void SendMsg(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(ConnectionString))
            {
                user_id = Convert.ToInt32(pending_gridview.CurrentRow.Cells["user_id"].Value);
                item_id = Convert.ToInt32(pending_gridview.CurrentRow.Cells["item_id"].Value);
                
                conn.Open();
                string warnningMessage = textarea.Text;
                string query = "insert into pending_message_tbl (user_id,item_id,message) values (@user_id,@item_id,@message)";
                cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user_id", user_id);
                cmd.Parameters.AddWithValue("@item_id", item_id);
                cmd.Parameters.AddWithValue("@message", warnningMessage);
                int val = cmd.ExecuteNonQuery();
                if (val != -1)
                {
                    MessageBox.Show("Message has been sent");

                }
                else
                {
                    MessageBox.Show("Message did not send");
                }
            }
        }



        private void Pending_gridview_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           // int index = pending_gridview.CurrentRow.Index;
            //MessageBox.Show(index.ToString());
        }

        private void Pending_gridview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int user_id = Convert.ToInt32(pending_gridview.Rows[rowIndex].Cells[0].Value);
            int item_id = Convert.ToInt32(pending_gridview.Rows[rowIndex].Cells[9].Value);
            
           

        }
       
    }
}
