using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ATLAS
{
    class MyProfile
    {        
        List<string> my_profile; // array that load and store info about user
        public static int ID = 0; // current user's id (also need in others classes)
        string fullPath { get; set; } // path to database        
        string connector { get; set; } // connection string for sql.Open
        SQL sql;       
                
        public MyProfile()
        {
            //fullPath = Application.StartupPath.ToString() + @"\QuizzesData\AtlasUsers.mdf";
            //connector = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=" + fullPath + ";";
            fullPath = Application.StartupPath.ToString() + @"\QuizzesData\AtlasUsers.accdb";
            connector = "provider=Microsoft.ACE.OLEDB.12.0;data source=" + fullPath;
            sql = new SQL(connector);
            my_profile = new List<string>();
        }

        // Load user's info
        public List<string> LoadAccount(string login, string password, ref bool LoginState)
        {
            do sql.Open();                                
            while (sql.db_error());
            string query = "SELECT COUNT (*) FROM Users WHERE Login = '" + login +
                "' AND Pass = '" + password + "'";
            string count = "0";
            do count = sql.Scalar(query);
            while (sql.db_error());
            if (count == "0") 
            {
                LoginState = false;
                do sql.Close();
                while (sql.db_error());
                return null;
            }                                                                                                                                       
            else
            {
                query = "SELECT ID, User_Name, Years, Town, School, Bonus FROM Users WHERE Login = '" + login +
                "' AND Pass = '" + password + "'";
                OleDbDataReader read;
                do
                {
                    read = sql.Select(query);
                }                
                while (sql.db_error());
                while (read.Read())
                {
                    ID = int.Parse(read["ID"].ToString());
                    my_profile.Add(read["User_Name"].ToString());
                    my_profile.Add(read["Years"].ToString());
                    my_profile.Add(read["Town"].ToString());
                    my_profile.Add(read["School"].ToString());
                    my_profile.Add(read["Bonus"].ToString());                    
                }                
                LoginState = true;
                do sql.Close();
                while (sql.db_error());
                return my_profile;                
            }            
        }

        //Save user's info
        public bool SaveAccount(string name, string year,string town, string school, string login, string password, string bonus = "0")
        {
            if (login != "" || password != "" && CheckLogin(login))
            {
                do sql.Open();
                while (sql.db_error());
                int id;
                id = int.Parse(sql.Scalar("SELECT MAX(ID) FROM Users")) + 1;
                do sql.Exec("INSERT INTO Users (ID, User_Name, Years, Town, School, Login, Pass, Bonus) VALUES ("
                        + id.ToString() + ",\'" + name + "\',\'" + year + "\',\'"
                        + town + "\',\'" + school + "\',\'" + login + "\',\'" + password + "\',\'" + bonus + "\')");
                while (sql.db_error());
                do sql.Close();
                while (sql.db_error());
                return true;
            }
            else
                return false;                       
        }

        // Update user's info
        public bool UpdateAccount(string name, string year, string town, string school, string login, string password)
        {
            if (login != "" || password != "" && CheckLogin(login))
            {
                do sql.Open();                                             
                while (sql.db_error());
                int count;
                do count = sql.Exec("UPDATE Users SET User_Name=\'" + name + "\',Years=\'" + year +
                      "\',Town=\'" + town + "\',School=\'" + school + "\',Login=\'" + login + "\',Pass=\'"
                      + password + "\' WHERE ID= " + ID.ToString());
                while (sql.db_error());
                do sql.Close();
                while (sql.db_error());
                return true;
            }
            else
                return false;
        }

        // Check if login have already existed
        private bool CheckLogin(string login)
        {
            if(ID!=0)
            {
                string logtemp=sql.Scalar("SELECT Login FROM Users WHERE ID="+ID.ToString());
                if (logtemp == login) // if user edit his profile, he can save his previous login
                    return true;
                else return false;
            }
            else
            {
                int id;
                id = int.Parse(sql.Scalar("SELECT COUNT(Login) FROM Users WHERE Login=" + "\'" + login + "\'"));
                if (id != 0)
                {
                    MessageBox.Show("Ім'я логіна вже зайнято", "Реєстрування",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
                else
                    return true;
            }            
        }
    }
}
