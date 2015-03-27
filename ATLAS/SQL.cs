using System;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATLAS
{
    class SQL
    {        
        OleDbConnection sc;
        public string error { get; private set; } 
        public string query { get; private set; }
        string connector;

        public SQL(string connector)
        {
            sc = new OleDbConnection(connector);            
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
                OleDbCommand cmd = sc.CreateCommand();
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
                OleDbCommand cmd = sc.CreateCommand();
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
        public OleDbDataReader Select(string query)
        {
            error = "";
            try
            {
                OleDbCommand cmd = sc.CreateCommand();
                cmd.CommandText = query;
                OleDbDataReader read = cmd.ExecuteReader();
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
