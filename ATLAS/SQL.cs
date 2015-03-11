using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATLAS
{
    class SQL
    {        
        SqlConnection sc;
        public string error { get; private set; } 
        public string query { get; private set; }
        string connector;

        public SQL(string connector)
        {
            sc = new SqlConnection(connector);            
            this.connector = connector;
        }

        // Open data base
        public bool Open()
        {
            error = "";
            this.query = "CONNECT" + connector;
            try
            {
                sc.Open();
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }

        // Close data base
        public bool Close()
        {
            error = "";
            this.query = "DISCONNECT";
            try
            {
                sc.Close();
                return true;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return false;
            }
        }


        public string Scalar(string query)
        {
            error = "";
            this.query = query;
            try
            {
                SqlCommand cmd = sc.CreateCommand();
                cmd.CommandText = query;
                string scalar = cmd.ExecuteScalar().ToString();
                return scalar;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return "";
            }
        }

        public int Exec(string query)
        {
            error = "";
            this.query = query;
            try
            {
                SqlCommand cmd = sc.CreateCommand();
                cmd.CommandText = query;
                int rows = cmd.ExecuteNonQuery();
                return rows;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return -1;
            }
        }

        // Select information from data base
        public SqlDataReader Select(string query)
        {
            error = "";
            try
            {
                SqlCommand cmd = sc.CreateCommand();
                cmd.CommandText = query;
                SqlDataReader read = cmd.ExecuteReader();
                return read;
            }
            catch (Exception ex)
            {
                error = ex.Message;
                return null;
            }
        }

        // Call when we have some errors
        public bool db_error()
        {
            if (error != "")
            {
                DialogResult dr = MessageBox.Show(error + "\n" + query, "Ошибка базы данных", MessageBoxButtons.AbortRetryIgnore);
                if (dr == DialogResult.Abort)
                {
                    Application.Exit();
                    return false;
                }
                if (dr == DialogResult.Retry)
                    return true;
                if (dr == DialogResult.Ignore)
                    return false;
            }
            return false;
        }       
    }
}
