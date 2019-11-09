using System;
using System.Data;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;


namespace LibraryManagementSystem
{
    public partial class Secratary_form : Form
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        public Secratary_form()
        {
            InitializeComponent();
        }

        private void Secratary_form_Load(object sender, EventArgs e)
        {
            Update_item();
            LoadCategoryy();
            GridviewColor(finished_gridview);
            if (login_form.getemail != null)
            {
                secratray_lbl.Text = login_form.getemail;
            }
            else
            {
                secratray_lbl.Text = Registration_form.getemail;
            }
        }

       
        public void LoadCategoryy()
        {
            using (conn = new SqlConnection(ConnectionString))
            {
                try
                {
                    
                    //Fill the DataTable with records from Table.
                    string Query = "select * from category_tbl";
                    SqlDataAdapter sda = new SqlDataAdapter(Query, conn);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    //Insert the Default Item to DataTable.

                    DataRow row = dt.NewRow();
                    row[0] = 0;
                    row[1] = "Select Category";
                    dt.Rows.InsertAt(row, 0);

                    //Assign DataTable as DataSource

                    Category_combo.DataSource = dt;
                    Category_combo.DisplayMember = "category_type";
                    Category_combo.ValueMember = "category_id";




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Insert_item_btn_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(Category_combo.SelectedValue) != "Select Category")
            {
                if (item_name_txt.Text != "")
                {
                    using (conn = new SqlConnection(ConnectionString))
                    {
                        conn.Open();
                        int quantity = Convert.ToInt32(quantity_txt.Text.Trim());
                        string query = "insert into item_tbl (category_name, item_name,item_added_date,quantity) values  (@category_id ,  @item_name, @date,@quantity)";
                        cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@category_id", Convert.ToInt32(Category_combo.SelectedValue));
                        cmd.Parameters.AddWithValue("@item_name", item_name_txt.Text);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString());
                        cmd.Parameters.AddWithValue("@quantity", quantity);
                        int row = cmd.ExecuteNonQuery();
                        if (row > 0)
                        {
                            MessageBox.Show("Item added successfully", "Item Added", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            Update_item();

                        }
                        else
                        {
                            MessageBox.Show("Not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }  
                }//end of combobox validate
                else
                {
                    MessageBox.Show("Please write item name");
                }
            }
            else
            {
                
                MessageBox.Show("Please Select Any Category");
            }
            
        }
        public void Update_item()
        {
            string updateQuery = "select item_name  , item_id  , quantity from item_tbl where quantity = 0";
            using (conn = new SqlConnection(ConnectionString))
            {
                cmd = new SqlCommand(updateQuery,conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                finished_gridview.DataSource = dt;
            }
        }

 


        private void Finished_gridview_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            item_nam_txt.Text = finished_gridview.Rows[rowIndex].Cells[0].Value.ToString();
            item_id_lbl.Text = finished_gridview.Rows[rowIndex].Cells[1].Value.ToString();
            quantity_update_txt.Text = finished_gridview.Rows[rowIndex].Cells[2].Value.ToString();
        }


        #region //gridview color
        public void GridviewColor(DataGridView x)
        {
            for (int i = 0; i < x.Rows.Count; i++)
            {
                for(int j = 0; j < x.ColumnCount; j++)
                {
                    if (i % 2 == 0)
                    {
                        x.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.LightGray;
                  
                        x.Rows[i].Cells[j].Style.ForeColor = System.Drawing.Color.Black;
                
                    }
                    else
                    {
                        x.Rows[i].Cells[j].Style.BackColor = System.Drawing.Color.DarkGray;
                        
                        x.Rows[i].Cells[j].Style.ForeColor = System.Drawing.Color.Black;
                        
                    }
                }

            }
        }
        #endregion

        private void Update_btn_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(quantity_update_txt.Text) > 0)
            {
                string updateQuery = "update item_tbl set quantity = @newquantity where item_id = @item_id";
                using (conn = new SqlConnection(ConnectionString))
                {
                    try
                    {
                        conn.Open();
                        cmd = new SqlCommand(updateQuery, conn);
                        cmd.Parameters.AddWithValue("@newquantity", quantity_update_txt.Text);
                        cmd.Parameters.AddWithValue("@item_id", item_id_lbl.Text);
                        int retVal = cmd.ExecuteNonQuery();
                        if (retVal != -1)
                        {
                            MessageBox.Show("Quantity updated");
                            Update_item();
                        }
                        else
                        {
                            MessageBox.Show("Quantity did not update");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                } 
               
            }
            else
            {
                MessageBox.Show("Item quantity must be more than 0");
            }
        }

    }
}
