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
    public partial class All_registered_users : Form
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        
        LoadGridViewData user_data = new LoadGridViewData();
        public All_registered_users()
        {
            InitializeComponent();
        }

        private void Registered_users_Load(object sender, EventArgs e)
        {
            Loadusers();

           
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void Loadusers()
        {
            
            
            Registered_user_grid_view.DataSource = user_data.LoadData("user_registration_tbl");
        }

        private void DataGridView1_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataTable changes = ((DataTable)Registered_user_grid_view.DataSource).GetChanges();
                if (changes != null)
                {
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommandBuilder mcb = new SqlCommandBuilder(da);
                    da.UpdateCommand = mcb.GetUpdateCommand();
                    da.Update(changes);
                    ((DataTable)Registered_user_grid_view.DataSource).AcceptChanges();

                    MessageBox.Show("Cell Updated");
                    return;
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string id_no = Registered_user_grid_view.CurrentRow.Cells["user_id"].Value.ToString();
            string key = "user_id = " + id_no;
           bool request  =  user_data.Delete_user("user_registration_tbl",key);
            if (request)
            {
                MessageBox.Show("User has been deleted successfully");
                Loadusers();
            }
            else
            {
                MessageBox.Show("User did not deleted","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        #region edit functionality not working
           private void EditBtn_Click(object sender, EventArgs e)
           {
        /*       conn = new SqlConnection(ConnectionString);
               conn.Open();
               SqlDataAdapter da = new SqlDataAdapter("select user_id , name from user_registration_tbl where ",conn);
               SqlCommandBuilder local = new SqlCommandBuilder(da);

                  local.ConflictOption = ConflictOption.OverwriteChanges;

                   da.UpdateCommand = local.GetUpdateCommand();
                   DataSet ds = new DataSet();
                   DataTable dt = new DataTable();
               // da.Update(ds, "user_registration_tbl");

               da.Fill(ds); //Fill Dataset
               dt = ds.Tables[0];
               da.Update(ds.Tables[0]);
               ds.AcceptChanges();



               Registered_user_grid_view.DataSource = dt;
               Loadusers();
               */
           }
           
        #endregion
    }
}
