using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATLAS
{
    class MyProfile
    {        
        string[] my_profile; // array that load and store info about user
        static public int ID=0; // current user's id
        SQL sql;
        //string connector = "Server=АНДРЕЙ-ПК;Database=AtlasUsers;Trusted_Connection=True;";
        String fullPath; // path to database        
        string connector;
        
        public MyProfile()
        {
            fullPath = Application.StartupPath.ToString() + @"\QuizzesData\AtlasUsers.mdf";
            connector = @"Data Source=(LocalDB)\v11.0;AttachDbFilename="+fullPath+";Integrated Security=True;";
            sql = new SQL(connector);
            my_profile = new string[5];
        }

        // Load user's info
        public string [] LoadAccount(string login, string password, ref bool LoginState)
        {
            do
            {
                sql.Open();
            }
            while (sql.db_error());
            string query = "SELECT COUNT (*) FROM Users WHERE Login = '" + login +
                "' AND Pass = '" + password + "'";
            string count = "0";
            do count = sql.Scalar(query);
            while (sql.db_error());
            if (count == "0")             
                LoginState = false;                                                                                                                       
            else
            {
                query = "SELECT ID, User_Name, Years, Town, School, Bonus FROM Users WHERE Login = '" + login +
                "' AND Pass = '" + password + "'";
                SqlDataReader read;
                do
                {
                    read = sql.Select(query);
                }
                while (sql.db_error());
                while (read.Read())
                {
                    ID = int.Parse(read["ID"].ToString());
                    my_profile[0] = read["User_Name"].ToString();
                    my_profile[1] = read["Years"].ToString();
                    my_profile[2] = read["Town"].ToString();
                    my_profile[3] = read["School"].ToString();
                    my_profile[4] = read["Bonus"].ToString();
                }                
                LoginState = true;
                do sql.Close();
                while (sql.db_error());
                return my_profile;                
            }
            do sql.Close();
            while (sql.db_error());
            return null;
        }

        //Save user's info
        public bool SaveAccount(string name, string year,string town, string school, string login, string password, string bonus = "0")
        {
            if (login == "" || password == "")
                return false;
            else
            {
                do
                {
                    sql.Open();
                }
                while (sql.db_error());
                if (CheckLogin(login))
                {
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
        }

        // Update user's info
        public bool UpdateAccount(string name, string year, string town, string school, string login, string password)
        {
            if (login == "" || password == "")
                return false;
            else
            {
                do
                {
                    sql.Open();
                }
                while (sql.db_error());
                if (CheckLogin(login))
                {
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
        }

        // Check if login have already existed
        private bool CheckLogin(string login)
        {
            if(ID!=0)
            {
                string logtemp=sql.Scalar("SELECT Login FROM Users WHERE ID="+ID.ToString());
                if (logtemp == login)
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
