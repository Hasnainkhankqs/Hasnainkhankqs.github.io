using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
namespace LibraryManagementSystem
{
    class LoadGridViewData
    {
        private string ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        
        public DataTable LoadData(string tblname)
        {
            conn = new SqlConnection(ConnectionString);
            conn.Open();
            string query = "select * from " + tblname;
            SqlDataAdapter sda = new SqlDataAdapter(query, conn);
            DataTable tbl = new DataTable();
            sda.Fill(tbl);
            return tbl;
        }
        #region not useable
        public bool InsertUsers(string tblname , string tbldata)
        {
            try
            {
                conn.Open();
                string str = "insert into " + tblname + " values " + tbldata;
                cmd = new SqlCommand(str,conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {

                return false;
            }
        }
        #endregion
        public bool Delete_user(string tblname, string user_id_key)
        {
            try
            {
                conn = new SqlConnection(ConnectionString);
                conn.Open();
                string str = "delete " + tblname + " where " + user_id_key;
                cmd = new SqlCommand(str, conn);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {

                return false;
            }
        }
        // not working
        public bool Update_user(string tblname, string key , string data)
        {
            try
            {
                conn = new SqlConnection(ConnectionString);
                conn.Open();
                string query = "update " + tblname + " set " + data + " where " + key;
                cmd = new SqlCommand(query,conn);
                cmd.ExecuteNonQuery();
                return true;

            }
            catch
            {

                return false;
            }
        }

    }
}
