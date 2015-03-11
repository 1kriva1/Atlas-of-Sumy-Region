using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATLAS
{
    public partial class Quizzes : Form
    {
        /*
          type(Quizzes or Foto-Quizzes); 
          territory - quizzess will be only about this territory; 
          thema - quizzess will be only about this thema 
        */
        public static string type, territory, thema; 
        string connector;
        string answer; // right answer         
        SQL sql;
        ControlController cc;        
        List<string> questions = new List<string>();
        List<string> answers = new List<string>();
        List<string> rightAnswer = new List<string>();
        List<string> pictures = new List<string>();
        string[] AnswerArray; // answers for concrete question
        Random rnd;  // for choose random question 
        int RightAnswerCount;
        String fullPath; // path to database

        public Quizzes()
        {
            fullPath = Application.StartupPath.ToString() + @"\QuizzesData";
            InitializeComponent();
            Init();
            RightAnswerCount = 0;
            rnd = new Random();
            cc = new ControlController();            
        }

        #region Quizzes settings

        // Initialize first view of Quizzes and refresh all changes
        private void Init()
        {
            type = "";
            territory = "";
            thema = "";
            label1.Text = type;
            label2.Text = territory;
            label3.Text = thema;
            button_refresh.Visible = false;
        }
        
        private void pictureBox_type_quizzes_Click(object sender, EventArgs e)
        {            
            type = "Питання";                      
            label1.Text = type;
            cc.EnableChange(pictureBox_type_foto, pictureBox_type_quizzes);
            cc.VisibleOn(pictureBox_territory_all, pictureBox_territory_sep, pictureBox_mode_all, pictureBox_mode_sep,
                label_territory, label_mode, label_territory, button_refresh);            
        }

        private void pictureBox_type_foto_Click(object sender, EventArgs e)
        {                     
            type = "Зображення";
            label1.Text = type;
            label3.Text = "Всі теми";
            cc.EnableChange(pictureBox_type_quizzes, pictureBox_type_foto);
            cc.VisibleOn(pictureBox_territory_all, pictureBox_territory_sep, label_territory, button_refresh);            
        }

        private void pictureBox_territory_all_Click(object sender, EventArgs e)
        {                     
            territory = "Вся область";
            label2.Text = territory;            
            if (comboBox_territory.Visible)
                comboBox_territory.Visible = false;                        
            if (type == "Зображення")
                button_start.Visible = true;
        }

        private void pictureBox_territory_sep_Click(object sender, EventArgs e)
        {                              
            comboBox_territory.Visible = true;                  
        }

        private void comboBox_territory_SelectedIndexChanged(object sender, EventArgs e)
        {
            territory = comboBox_territory.SelectedItem.ToString();
            label2.Text = territory;
            if (type == "Зображення")
                button_start.Visible = true;
        }

        private void pictureBox_mode_all_Click(object sender, EventArgs e)
        {                     
            thema = "Всі теми";
            label3.Text = thema;
            button_start.Visible = true;
            if (comboBox_mode.Visible)
                comboBox_mode.Visible = false;                        
        }

        private void pictureBox_mode_sep_Click(object sender, EventArgs e)
        {                       
            comboBox_mode.Visible = true;
        }        

        private void comboBox_mode_SelectedIndexChanged(object sender, EventArgs e)
        {
            thema = comboBox_mode.SelectedItem.ToString();
            label3.Text = thema;
            button_start.Visible = true;
        }

        // Refresh all settings in quizzes
        private void button_refresh_Click(object sender, EventArgs e)
        {            
            cc.EnableChange(pictureBox_type_quizzes, pictureBox_type_foto);
            if (button_start.Visible)
                button_start.Visible = false;
            if (type == "Питання")            
                cc.VisibleOff(pictureBox_territory_all, pictureBox_territory_sep, pictureBox_mode_all, pictureBox_mode_sep,
                    label_territory, label_mode, comboBox_mode, comboBox_territory);                                      
            else            
                cc.VisibleOff(pictureBox_territory_all, pictureBox_territory_sep, label_territory, comboBox_territory);                                          
            Init();
        }        

        // Start quizzes
        private void button_start_Click(object sender, EventArgs e)
        {
            cc.VisibleOff(label_title, label1, label2, label3, label_type, label_stat_type,
               label_stat_teritory, label_stat_mode, label_territory, button_start, button_refresh, comboBox_territory,
               label_mode, pictureBox_type_quizzes, pictureBox_type_foto, pictureBox_territory_all,
                   pictureBox_territory_sep, pictureBox_mode_all, pictureBox_mode_sep, comboBox_mode);
            cc.EnableOn(pictureBox_type_quizzes, pictureBox_type_foto);
            if (type == "Питання")
                connector = @"Data Source=(LocalDB)\v11.0;AttachDbFilename="+fullPath+@"\Quizzes.mdf;Integrated Security=True;";
            else
                connector = @"Data Source=(LocalDB)\v11.0;AttachDbFilename="+fullPath+@"\Photo.mdf;Integrated Security=True;";
            sql = new SQL(connector);                      
            if (type == "Питання")
            {
                cc.VisibleChange(label_question, label_answer_1, label_answer_2, label_answer_3, label_answer_4,
               label_result, button_next, button_finish);
               LoadQuizzesData();
            }                
            else
            {
                cc.VisibleChange(pictureBox_photo, label_photo_answ1, label_photo_answ2, label_photo_answ3, label_photo_answ4,
                    label_photo_result,button_next,button_finish,label_question);
                LoadPicturesData();
            }                          
        }
        #endregion

        #region Load 

        // Load all questions and answers from data base for quizzes
        private void LoadQuizzesData()
        {
            do
            {
                sql.Open();
            }
            while (sql.db_error());
            string query;
            if (thema == "Всі теми" && territory != "Вся область")
                query = "SELECT Question, Answers,RightAnswer FROM Quizzes WHERE Location = '" + territory + "'";
            else if (territory == "Вся область" && thema != "Всі теми")
                query = "SELECT Question, Answers,RightAnswer FROM Quizzes WHERE Thema = '" + thema + "'";
            else if (territory == "Вся область" && thema == "Всі теми")
                query = "SELECT Question, Answers, RightAnswer FROM Quizzes";
            else
                query = "SELECT Question, Answers,RightAnswer FROM Quizzes WHERE Location = '" + territory + "'" + " AND Thema = '" + thema + "'";
            SqlDataReader read;
            do
            {
                read = sql.Select(query);
            }
            while (sql.db_error());
            questions.Clear();
            answers.Clear();
            rightAnswer.Clear();
            while (read.Read())
            {
                questions.Add(read["Question"].ToString());
                answers.Add(read["Answers"].ToString());
                rightAnswer.Add(read["RightAnswer"].ToString());
            }
            do 
            {
                sql.Close();
            }
            while (sql.db_error());
            LoadQuestion();
        }

        // Load all questions, answers, pictures from data base for foto-quizzes 
        private void LoadPicturesData()
        {
            do
            {
                sql.Open();
            }
            while (sql.db_error());
            string query;
            if (territory == "Вся область")
                query = "SELECT Question, Answer, RightAnswer, Picture_1 FROM Pictures";
            else
                query = "SELECT Question, Answer, RightAnswer, Picture_1 FROM Pictures WHERE Location = '" + territory + "'";
            SqlDataReader read;
            do 
            {
                read = sql.Select(query);
            }
            while (sql.db_error());
            questions.Clear();
            answers.Clear();
            rightAnswer.Clear();
            pictures.Clear();
            while (read.Read())
            {
                questions.Add(read["Question"].ToString());
                answers.Add(read["Answer"].ToString());
                rightAnswer.Add(read["RightAnswer"].ToString());
                pictures.Add(read["Picture_1"].ToString());
            }
            do
            {
                sql.Close();
            }
            while (sql.db_error());
            LoadPicture();
        }
       
        private bool UpdateBonus()
        {
            connector = @"Data Source=(LocalDB)\v11.0;AttachDbFilename="+fullPath+@"\AtlasUsers.mdf;Integrated Security=True;";
            sql = new SQL(connector);
            do
            {
                sql.Open();
            }
            while (sql.db_error());
            int count;
            do count = sql.Exec("UPDATE Users SET Bonus=\'" + Atlas_Main.bonus + "\' WHERE ID= " + MyProfile.ID.ToString());
            while (sql.db_error());
            do sql.Close();
            while (sql.db_error());
            return true;
        }
 
        //Generate new foto-quizzes question
        private void LoadPicture()
        {
            int index = rnd.Next(0, (questions.Count));
            label_question.Text = questions[index].ToString();
            AnswerArray = answers[index].ToString().Split('*');
            label_photo_answ1.Text = AnswerArray[0].ToString();
            label_photo_answ2.Text = AnswerArray[1].ToString();
            label_photo_answ3.Text = AnswerArray[2].ToString();
            label_photo_answ4.Text = AnswerArray[3].ToString();
            answer = rightAnswer[index].ToString();
            Image imageTemp = Image.FromFile("FotoQuizzes\\" + pictures[index] + ".jpg");
            pictureBox_photo.Width = imageTemp.Width;
            pictureBox_photo.Height = imageTemp.Height;
            pictureBox_photo.Image = imageTemp;
        }

        //Generate new quizzes question
        private void LoadQuestion()
        {            
            int index = rnd.Next(0, (questions.Count));
            label_question.Text = questions[index].ToString();
            AnswerArray = answers[index].ToString().Split('*');
            label_answer_1.Text = AnswerArray[0].ToString();
            label_answer_2.Text = AnswerArray[1].ToString();
            label_answer_3.Text = AnswerArray[2].ToString();
            label_answer_4.Text = AnswerArray[3].ToString();
            answer = rightAnswer[index].ToString();
        }
        #endregion

        #region Actions in Quizzes

        // Next question
        private void button_next_Click(object sender, EventArgs e)
        {
            if (type == "Питання")
                LoadQuestion();
            else
                LoadPicture();
            button_next.Enabled = false;
            label_result.Text = "---";
            label_photo_result.Text = "---";
        }

        // Finish quizzes
        private void FinishGame()
        {
            cc.VisibleOn(label_title, label_type, label_stat_type, label_stat_teritory, label_stat_mode,
                label1, label2, label3, pictureBox_type_quizzes, pictureBox_type_foto);
            if (type == "Питання")
                cc.VisibleOff(label_question, label_answer_1, label_answer_2, label_answer_3, label_answer_4,
               label_result, button_next, button_finish);
            else
                cc.VisibleOff(pictureBox_photo, label_photo_answ1, label_photo_answ2, label_photo_answ3, label_photo_answ4,
                    label_photo_result, button_next, button_finish, label_question);
            Init();
        }
        
        private void button_finish_Click(object sender, EventArgs e)
        {
            UpdateBonus();
            FinishGame();
        }

        // Add bonuses when user answer on quizzes
        private void BonusControl()
        {
            switch (RightAnswerCount)
            {
                case 5: Atlas_Main.bonus++;
                        MessageBox.Show("Вітаємо, Ви правильно підряд відповіли на 5 питань. Ваші бонуси збільшились на 1!",
                        "Перемога", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                case 10: Atlas_Main.bonus += 2;
                         MessageBox.Show("Вітаємо, Ви правильно підряд відповіли на 10 питань. Ваші бонуси збільшились на 2!",
                            "Перемога", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         break;
                case 15: Atlas_Main.bonus += 3;
                         MessageBox.Show("Вітаємо, Ви правильно підряд відповіли на 15 питань. Ваші бонуси збільшились на 3!",
                            "Перемога", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         break;
                case 20: Atlas_Main.bonus += 4;
                         MessageBox.Show("Вітаємо, Ви правильно підряд відповіли на 20 питань. Ваші бонуси збільшились на 4!",
                            "Перемога", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         break;
                case 25: Atlas_Main.bonus += 5;
                         MessageBox.Show("Вітаємо, Ви правильно підряд відповіли на 25 питань. Ваші бонуси збільшились на 5! Треба відпочити",
                            "Перемога", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         FinishGame();
                         break;
            }
        }

        // Choose answer in quizzes
        private void label_answer_DoubleClick(object sender, EventArgs e)
        {
            int num = 0;
            Label label = sender as Label;
            switch(label.Name)
            {
                case "label_answer_1": num = 1;
                                       break;
                case "label_answer_2": num = 2;
                                       break;
                case "label_answer_3": num = 3;
                                       break;
                case "label_answer_4": num = 4;
                                       break;
            }            
            if (num.ToString() == answer) 
            {
                RightAnswerCount++;
                label_result.Text = "Правильно!";
            }                          
            else
            {
                RightAnswerCount = 0;
                label_result.Text = "Не правильно!\r\nПравильна відповідь: " + AnswerArray[Convert.ToInt32(answer) - 1].ToString();
            }
            BonusControl();
            button_next.Enabled = true;
        }

        // Choose answer in foto-quizzes
        private void label_photo_answ_DoubleClick(object sender, EventArgs e)
        {
            int num = 0;
            Label label = sender as Label;
            switch (label.Name)
            {
                case "label_photo_answ1": num = 1;
                    break;
                case "label_photo_answ2": num = 2;
                    break;
                case "label_photo_answ3": num = 3;
                    break;
                case "label_photo_answ4": num = 4;
                    break;
            }   
            if (num.ToString() == answer)  
            {
                 RightAnswerCount++;
                 label_photo_result.Text = "Правильно!"; 
            }        
                           
            else
            {
                RightAnswerCount = 0;
                label_photo_result.Text = "Не правильно!\r\nПравильна відповідь: " + AnswerArray[Convert.ToInt32(answer) - 1].ToString();
            }
            BonusControl();            
            button_next.Enabled = true;
        }
        #endregion

    }
}
