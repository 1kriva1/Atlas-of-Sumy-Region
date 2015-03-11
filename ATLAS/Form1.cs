using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATLAS
{
    public enum Directions // enumeration for "move map by buttons"
    {
        Left,
        Right,
        Up,
        Down
    };  
   
    public partial class Atlas_Main : Form
    {
        MyProfile mpr;   // load and save user's info
        ControlController cc; // class that allow to control visible and enabled of different objects
        Study study; // load study information
        Maps maps;        
        MapLegend ml;        
        string location = null; // represent specific region of study
        string thema = null; // thema of study
        string map = null; // category of maps
        bool handID = false; // pointer that define "Hand function" 
        bool layersID = false; // pointer that define checkedBox_map_layers's visible 
        bool Login = false; // pointer that define user's login  
        string[] my_profile; // array for profile data
        public static int bonus{ get; set; }      

        public Atlas_Main()
        {
            InitializeComponent();            
            pictureBox_map_MAIN.Image = new Bitmap(pictureBox_map_MAIN.Width, pictureBox_map_MAIN.Height);
            pictureBox_map_MAIN.MouseWheel += new System.Windows.Forms.MouseEventHandler(pictureBox_map_MAIN_MouseWheel);             
            mpr = new MyProfile();
            cc = new ControlController();
            study = new Study();
            maps = new Maps();               
        }        

        #region Atlas Content
        
        // Open maps content
        private void button_maps_Click(object sender, EventArgs e)
        {
            cc.VisibleChange(panel_content, panel_main);
        }        

        // Back to main content from maps content
        private void button_back_Click(object sender, EventArgs e)
        {
            cc.VisibleChange(panel_content, panel_main);
        }

        // Open study information content and show list of regions
        private void button_study_Click(object sender, EventArgs e)
        {
            panel_main.Height = 542;
            panel_content.Height = 542;
            cc.VisibleChange(panel_study, panel_image, panel_additional, panel_study_content, panel_main, panel_title_map);            
            cc.EnableChange(button_study_inform, button_study_geo, button_study_netur, button_study_history, button_study_admin,
                button_study_demogr, button_study_people, button_study_monum);
        }

        // Back to main content from study content
        private void button_study_back_Click(object sender, EventArgs e)
        {
            panel_main.Height = 475;
            panel_content.Height = 475;
            cc.VisibleChange(panel_study, panel_image, panel_additional, panel_study_content, panel_main, panel_title_map);
            cc.EnableChange(button_study_inform, button_study_geo, button_study_netur, button_study_history, button_study_admin,
                button_study_demogr, button_study_people, button_study_monum);
        }
               
        // Open form, that show all user's screenshots
        private void button_map_screenshots_Click(object sender, EventArgs e)
        {
            ScreenShotsViewer scrViewer = new ScreenShotsViewer();
            scrViewer.Show();
        }

        // Open Quizzes form
        private void button_quizzes_Click(object sender, EventArgs e)
        {
            Quizzes quizzes = new Quizzes();
            quizzes.Show();
        }

        // Open Countour maps tasks form
        private void button_contour_Click(object sender, EventArgs e)
        {
            CountourMapTask countour = new CountourMapTask();
            countour.Show();
        }

        //Open list of games
        private void button_games_Click(object sender, EventArgs e)
        {
            cc.VisibleChange(panel_games, button_game_back, panel_image);
            cc.EnableChange(button_study, button_quizzes, button_maps, button_games, button_contour, button_my_profile);
        }

        //Back to main content from games
        private void button_game_back_Click(object sender, EventArgs e)
        {
            cc.VisibleChange(panel_games, button_game_back, panel_image);
            cc.EnableChange(button_study, button_quizzes, button_maps, button_games, button_contour, button_my_profile);
        }
        #endregion

        #region About Atlas
        // Open information about Atlas
        private void button_about_Click(object sender, EventArgs e)
        {
            AtlasAbout about = new AtlasAbout();
            about.ShowDialog();
        }
        #endregion              

        #region My Profile 

        // Refresh profile data text
        private void InitProfile()
        {
            password_txt.Text = "";
            login_txt.Text = "";
            textBox_acc_name.Text = "";
            textBox_acc_school.Text = "";
            textBox_acc_town.Text = "";
            textBox_acc_year.Text = "";
            textBox_login.Text = "";
            textBox_password.Text = "";
        }  
     
        // Use in order to reupdate profile information when edit is failed
        private void ReUpdateProfile()
        {
            textBox_acc_name.Text = my_profile[0];
            textBox_acc_year.Text = my_profile[1];
            textBox_acc_town.Text = my_profile[2];
            textBox_acc_school.Text = my_profile[3];
            label_acc_bonus_count.Text = my_profile[4];
        }

        // Open My profile menu and load info about user
        private void button_my_profile_Click(object sender, EventArgs e)
        {
            if (panel_study.Visible)
                return;             
            if(Login)
            {
                cc.VisibleOn(label_account_title,label_acc_name,label_acc_school,label_acc_town,label_acc_year,
                    label_acc_bonus,label_acc_bonus_count,pictureBox_acc_bonus,textBox_acc_name,
                    textBox_acc_school,textBox_acc_town,textBox_acc_year,button_acc_edit, button_exit);
                cc.VisibleOff(label1, label2, password_txt, login_txt, button_login, button_regestration, label_login,
                    label_password, textBox_login, textBox_password, panel_title_map);
                cc.VisibleChange(panel_image, panel_profile);                
                cc.EnableChange(button_study, button_maps, button_contour, button_my_profile,button_quizzes, button_games);
                label_acc_bonus_count.Text = bonus.ToString();
            }
            else
            {
                cc.VisibleOn(label1, label2, button_login, button_regestration, password_txt, login_txt);
                cc.VisibleOff(label_login, label_password, textBox_login, textBox_password, button_regestry, button_exit, panel_title_map);
                cc.VisibleChange(panel_image, panel_profile);
                cc.EnableChange(button_study, button_maps, button_contour, button_my_profile);              
            }
            login_txt.Text = "";
            password_txt.Text = "";
        }

        // Login user account
        private void button_login_Click(object sender, EventArgs e)
        {            
            my_profile = mpr.LoadAccount(login_txt.Text, password_txt.Text, ref Login);
            if (Login)
            {
                cc.VisibleChange(label1, label2, login_txt, password_txt, button_acc_edit, label_acc_bonus,
                    label_acc_bonus_count, pictureBox_acc_bonus, label_acc_name, label_acc_school, label_acc_town,
                    label_acc_year, label_account_title, textBox_acc_name, textBox_acc_school, textBox_acc_town,
                    textBox_acc_year, button_login, button_regestration, button_exit);
                ReUpdateProfile();
                bonus = int.Parse(label_acc_bonus_count.Text);
                label_account_title.Text = "Привіт, " + my_profile[0].ToString() + " !";
                MessageBox.Show("Авторизація профілю виконана успішно!", "Вхід", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                MessageBox.Show("Логін або пароль вказані невірно", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label_account_title.Text = "Привіт !";
                password_txt.Text = "";
                login_txt.Text = "";
                cc.VisibleOff(button_acc_edit);
            }            
        }

        // Open regestration menu for account
        private void button_regestration_Click(object sender, EventArgs e)
        {
            cc.VisibleOn(label_account_title, label_acc_name, label_acc_school, label_acc_town, label_acc_year,
                    label_acc_bonus, label_acc_bonus_count, pictureBox_acc_bonus, textBox_acc_name,
                    textBox_acc_school, textBox_acc_town, textBox_acc_year, button_acc_edit, panel_profile, label_login,
                    label_password, textBox_login, textBox_password, button_regestry);
            cc.VisibleOff(label1, label2, password_txt, login_txt, button_login, button_regestration, panel_image, 
                label_acc_bonus, label_acc_bonus_count, pictureBox_acc_bonus, button_acc_edit);
            cc.EnableOn(textBox_acc_name, textBox_acc_school, textBox_acc_town, textBox_acc_year);
            InitProfile();
            label_account_title.Text = "Введіть логін ,пароль та Ваші дані";
        }

        // Regestry user's account
        private void button_regestry_Click(object sender, EventArgs e)
        {
            if (mpr.SaveAccount(textBox_acc_name.Text, textBox_acc_year.Text, textBox_acc_town.Text,
                textBox_acc_school.Text, textBox_login.Text, textBox_password.Text))
                MessageBox.Show("Ваш логін та пароль зареєстровані та збережені!", "Реєстрування", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Помилка при реєстрації", "Реєстрування",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            cc.VisibleOff(label_account_title, label_acc_name, label_acc_school, label_acc_town, label_acc_year,
                    label_acc_bonus, label_acc_bonus_count, pictureBox_acc_bonus, textBox_acc_name,
                    textBox_acc_school, textBox_acc_town, textBox_acc_year, button_acc_edit, panel_profile, label_login,
                    label_password, textBox_login, textBox_password, button_regestry);
            cc.VisibleOn(label1, label2, password_txt, login_txt, button_login, button_regestration, panel_profile);
            cc.EnableOff(textBox_acc_name, textBox_acc_school, textBox_acc_town, textBox_acc_year);
        }

        // Exit from user's account
        private void button_exit_Click(object sender, EventArgs e)
        {
            cc.VisibleOn(label1, label2, button_login, button_regestration, password_txt, login_txt);
            cc.VisibleOff(label_account_title, label_acc_name, label_acc_school, label_acc_town, label_acc_year,
                    label_acc_bonus, label_acc_bonus_count, pictureBox_acc_bonus, textBox_acc_name,
                    textBox_acc_school, textBox_acc_town, textBox_acc_year, button_acc_edit, button_exit);
            InitProfile();
            bonus = 0;
            Login=false;
        }

        // Back to main menu and save all changes in user's information    
        private void button_acc_back_Click(object sender, EventArgs e)
        {
            cc.VisibleChange(panel_image, panel_profile, panel_title_map);
            if(Login)
                cc.EnableChange(button_study, button_quizzes, button_maps, button_games, button_contour, button_my_profile);
            else
                cc.EnableChange(button_study, button_maps, button_contour, button_my_profile);
            cc.VisibleOff(label_account_title, label_acc_name, label_acc_school, label_acc_town, label_acc_year,
                    label_acc_bonus, label_acc_bonus_count, pictureBox_acc_bonus, textBox_acc_name,
                    textBox_acc_school, textBox_acc_town, textBox_acc_year, button_acc_edit, panel_profile, button_regestry);            
        }

        // Allow to change user's information
        private void button_acc_edit_Click(object sender, EventArgs e)
        {
            cc.EnableChange(textBox_acc_name, textBox_acc_year, textBox_acc_town, textBox_acc_school,
                button_acc_back, button_acc_edit);
            cc.VisibleChange(button_acc_confirm, label_password, label_login, textBox_login, textBox_password, button_exit);
            InitProfile();
            textBox_acc_name.Focus();                                    
        }

        // Confirm all changes in user's information
        private void button_acc_confirm_Click(object sender, EventArgs e)
        {
            cc.EnableChange(textBox_acc_name, textBox_acc_year, textBox_acc_town, textBox_acc_school,
                button_acc_back, button_acc_edit);
            cc.VisibleChange(button_acc_confirm, textBox_password, textBox_login, label_login, label_password,button_exit);
            if(mpr.UpdateAccount(textBox_acc_name.Text, textBox_acc_year.Text, textBox_acc_town.Text,
                textBox_acc_school.Text, textBox_login.Text, textBox_password.Text))
                MessageBox.Show("Змінни профілю прийняті!", "Редагування", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                ReUpdateProfile();
                MessageBox.Show("Ви не внесли всі необхідні дані!", "Редагування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
            if (Login)            
                label_account_title.Text = "Привіт, " + textBox_acc_name.Text + " !";                           
            else
                label_account_title.Text = "Привіт !";             
        }
        #endregion

        #region Study         

        //Open common information about specific region
        private void OpenStudyInformation_Click(object sender, EventArgs e)
        {
            cc.EnableChange(button_study_inform, button_study_geo, button_study_netur, button_study_history, button_study_admin,
                button_study_demogr, button_study_people, button_study_monum);
            cc.VisibleChange(button_study_back_list, panel_study);
            cc.VisibleOn(pictureBox_study, button_study_back_list);
            button_study_back.Visible = false;
            PictureBox pict = sender as PictureBox;
            switch (pict.Name)
            {
                case "pictureBox_study_1": location = "Bilopilsky";
                                                 break;
                case "pictureBox_study_2": location = "Burunsky";
                                                 break;
                case "pictureBox_study_3": location = "Velukopusarivsky";
                                                 break;
                case "pictureBox_study_4": location = "Gluhiphsky";
                                                 break;
                case "pictureBox_study_5": location = "Konotopsky";
                                                 break;
                case "pictureBox_study_6": location = "Krasnopilsky";
                                                 break;
                case "pictureBox_study_7": location = "Krolevetsky";
                                                 break;
                case "pictureBox_study_8": location = "Lebedunsky";
                                                 break;
                case "pictureBox_study_9": location = "Lupovodolunsky";
                                                 break;
                case "pictureBox_study_10": location = "Nedrugailivsk";
                                                 break;
                case "pictureBox_study_11": location = "Ohtursky";
                                                 break;
                case "pictureBox_study_12": location = "Putuvlsky";
                                                 break;
                case "pictureBox_study_13": location = "Romensky";
                                                 break;
                case "pictureBox_study_14": location = "SeredunoBydsky";
                                                 break;
                case "pictureBox_study_15": location = "Sumsky";
                                                 break;
                case "pictureBox_study_16": location = "Trostynetsky";
                                                 break;
                case "pictureBox_study_17": location = "Shostkinsky";
                                                 break;
                case "pictureBox_study_18": location = "Yampilsky";
                                                 break;                
            }                       
            pictureBox_study.Image = study.LoadThema(location);
        }

        // Back to list of regions
        private void button_study_back_list_Click(object sender, EventArgs e)
        {
            pictureBox_study.Visible = false;
            cc.VisibleChange(panel_study, button_study_back_list, button_study_back);            
            cc.EnableChange(button_study_inform, button_study_geo, button_study_netur, button_study_history, button_study_admin,
                button_study_demogr, button_study_people, button_study_monum);
        }

        //Open specific thema of study, according to choosen region
        private void OpenThema_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch (button.Name)
            {
                case "button_study_inform": thema = "Common";
                                            break;
                case "button_study_geo": thema = "Geography";
                                         break;
                case "button_study_netur": thema = "Natural";
                                           break;
                case "button_study_history": thema = "History";
                                             break;
                case "button_study_admin": thema = "Administration";
                                           break;
                case "button_study_people": thema = "People";
                                            break;
                case "button_study_monum": thema = "Monument";
                                            break;
                case "button_study_demogr": thema = "Demography";
                                            break;
            }                   
            pictureBox_study.Image = study.LoadThema(location, thema);
        }

        // Change title region statistic
        private void label_title_1_Click(object sender, EventArgs e)
        {
            Label label = sender as Label;
            switch (label.Name)
            {
                case "label_title_1": pictureBox_title_stat.Image = study.LoadStat(label_title_1.Text);
                                      break;
                case "label_title_2": pictureBox_title_stat.Image = study.LoadStat(label_title_2.Text);
                                      break;
                case "label_title_3": pictureBox_title_stat.Image = study.LoadStat(label_title_3.Text);
                                      break;
                case "label_title_4": pictureBox_title_stat.Image = study.LoadStat(label_title_4.Text);
                                      break;
                case "label_title_5": pictureBox_title_stat.Image = study.LoadStat(label_title_5.Text);
                                      break;
                case "label_title_6": pictureBox_title_stat.Image = study.LoadStat(label_title_6.Text);
                                      break;
                case "label_title_7": pictureBox_title_stat.Image = study.LoadStat(label_title_7.Text);
                                      break;
                case "label_title_8": pictureBox_title_stat.Image = study.LoadStat(label_title_8.Text);
                                      break;
                case "label_title_9": pictureBox_title_stat.Image = study.LoadStat(label_title_9.Text);
                                      break;
                case "label_title_10": pictureBox_title_stat.Image = study.LoadStat(label_title_10.Text);
                                       break;
                case "label_title_11": pictureBox_title_stat.Image = study.LoadStat(label_title_11.Text);
                                       break;
                case "label_title_12": pictureBox_title_stat.Image = study.LoadStat(label_title_12.Text);
                                       break;
                case "label_title_13": pictureBox_title_stat.Image = study.LoadStat(label_title_13.Text);
                                       break;
                case "label_title_14": pictureBox_title_stat.Image = study.LoadStat(label_title_14.Text);
                                       break;
                case "label_title_15": pictureBox_title_stat.Image = study.LoadStat(label_title_15.Text);
                                       break;
                case "label_title_16": pictureBox_title_stat.Image = study.LoadStat(label_title_16.Text);
                                       break;
                case "label_title_17": pictureBox_title_stat.Image = study.LoadStat(label_title_17.Text);
                                       break;
                case "label_title_18": pictureBox_title_stat.Image = study.LoadStat(label_title_18.Text);
                                       break;
            }  
        }
        #endregion

        #region Maps

        // Refresh map settings
        private void RefreshMapSettings()
        {
            checkedListBox_map_layers.Visible = false;
            layersID = false;
            handID=false;
            pictureBox_map_MAIN.Cursor = Cursors.Default;              
        }

        // Open maps, according to the selected category
        private void button_natural_Click(object sender, EventArgs e)
        {
            cc.VisibleChange(panel_map_maps, panel_additional, panel_image, panel_content, pictureBox_title_image, panel_title_map);
            Button button = sender as Button;
            switch(button.Text)
            {
                case "Карти природи": map = "Natural";
                                        break;
                case "Економічні карти": map = "Economic";
                                        break;
                case "Соціальні карти": map = "Social";
                                        break;
                case "Історичні карти": map = "History";
                                        break;
                case "Супутникові знімки": map = "Sattelite";
                                        break;
                case "Карти анімації": map = "Animation";
                                        break;
                case "3D карти": map = "3D";
                                        break;
            }            
            string [] mass = maps.LoadMaps(map).ToArray();
            comboBox_map_content.Items.Clear();
            for (int i = 0; i < mass.Length;i++)
            {
                comboBox_map_content.Items.Add(mass[i]); 
            }
            RefreshMapSettings();
            trackBar_map_scale.Value = maps.DefaultMapSetting();
            comboBox_map_content.SelectedIndex = 0;                        
        }

        // Select the desired map, according to category of maps 
        private void comboBox_map_content_SelectedIndexChanged(object sender, EventArgs e)
        {
            trackBar_map_scale.Value = maps.DefaultMapSetting();
            RefreshMapSettings();           
            maps.DrawMap(comboBox_map_content.Items[comboBox_map_content.SelectedIndex].ToString(), map, pictureBox_map_MAIN.Image);
            //if(ml!=null)
            //    ml.LoadLegend(map, comboBox_map_content.SelectedItem.ToString());
            pictureBox_map_MAIN.Refresh();
        }

        // Back from maps to main content
        private void button_map_back_Click(object sender, EventArgs e)
        {
            cc.VisibleChange(panel_map_maps, panel_additional, panel_image, panel_content, pictureBox_title_image, panel_title_map);
            RefreshMapSettings();
            if (ml != null)
                ml.Close();
        }        
        #endregion

        #region Actions on maps

        //Change "Pointer function" to "Hand function"(allow move maps)
        private void button_map_hand_Click(object sender, EventArgs e)
        {            
            handID = handID.Equals(true) ? false : true;
            if (handID)
                pictureBox_map_MAIN.Cursor = Cursors.Hand;
            else
                pictureBox_map_MAIN.Cursor = Cursors.Default;
        }

        // Open/Close checkBox for map layers
        private void button_map_layers_Click(object sender, EventArgs e)
        {
            layersID = layersID.Equals(true) ? false : true;
            if (layersID)
                checkedListBox_map_layers.Visible = true;
            else
                checkedListBox_map_layers.Visible = false;
        }

        #region Mouse Events
        private void pictureBox_map_MAIN_MouseEnter(object sender, EventArgs e)
        {
            if (ml == null)
                pictureBox_map_MAIN.Focus();
        }

        private void pictureBox_map_MAIN_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox_map_MAIN.Focus();
            maps.DownMouse(sender, e);
        }

        //Move map by mouse
        private void pictureBox_map_MAIN_MouseMove(object sender, MouseEventArgs e)
        {            
            maps.MoveMap(sender, e, handID);
            pictureBox_map_MAIN.Refresh();
        }

        private void pictureBox_map_MAIN_MouseUp(object sender, MouseEventArgs e)
        {
            maps.DownX = -1;
            maps.DownY = -1;       
        }

        // Change map's scale by mousewheel
        private void pictureBox_map_MAIN_MouseWheel(object sender, MouseEventArgs e)
        {
            trackBar_map_scale.Value = maps.MapScaling(sender, e, trackBar_map_scale.Value);
            pictureBox_map_MAIN.Refresh();
        }
        #endregion

        // Move map by buttons
        private void ButtonsMoveMap_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            switch(button.Name)
            {
                case "button_map_up": maps.ButtonMoveMap(Directions.Up);
                    break;
                case "button_map_down": maps.ButtonMoveMap(Directions.Down);
                    break;
                case "button_map_right": maps.ButtonMoveMap(Directions.Right);
                    break;
                case "button_map_left": maps.ButtonMoveMap(Directions.Left);
                    break;
            }            
            pictureBox_map_MAIN.Refresh();
        }        

        // Change button's color when mouse down
        private void button_map_up_MouseDown(object sender, MouseEventArgs e)
        {
            cc.ChangeColorMouseDown(sender);
        }

        // Change button's color when mouse up
        private void button_map_up_MouseUp(object sender, MouseEventArgs e)
        {
            cc.ChangeColorMouseUp(sender);
        }        

        // Change map's scale by trackbar
        private void trackBar_map_scale_Scroll(object sender, EventArgs e)
        {
            maps.TrackScale(trackBar_map_scale.Value);
            pictureBox_map_MAIN.Refresh();
        }

        // Make screenshot from map
        private void button_map_screenshot_Click(object sender, EventArgs e)
        {
            maps.MakeMapScreenShot(saveFileDialog_screenshot);
        }

        // Show map's legend(open legend form)
        private void button_map_legend_Click(object sender, EventArgs e)
        {
            if (comboBox_map_content.SelectedItem!=null)
            {
                ml = new MapLegend();
                ml.LoadLegend(map, comboBox_map_content.SelectedItem.ToString());
                ml.Show();
            }            
        }
        #endregion

        #region Games
        private void Open_Game_DoubleClick(object sender, EventArgs e)
        {
            string filename=null;
            PictureBox pict = sender as PictureBox;
            switch(pict.Name)
            {
                case "pictureBox_HandGame": filename = "Games\\HandGame.exe";
                                            break;
                case "pictureBox_OX": filename = "Games\\OX.exe";
                                            break;
                case "pictureBox1_Digits": filename = "Games\\Digits.exe";
                                            break;
                case "pictureBox_MindCount": filename = "Games\\MindCounts.exe";
                                            break;
                case "pictureBox_Viselka": filename = "Games\\Viselka.exe";
                                            break;
                case "pictureBox_Game15": filename = "Games\\Game15.exe";
                                            break;
                case "pictureBox_PictureCards": filename = @"D:\36\ATLAS\Game\PictureCardsE\PictureCardsE\bin\Debug\PictureCardsE.exe";
                                            break;
                case "pictureBox_FlyFighter": filename = "Games\\FlyFighter.exe";
                                            break;
                case "pictureBox_Arcanoid": filename = "Games\\Arcanoid.exe";
                                            break;
                //case "pictureBox_SpaceShooter": filename = "Games\\HandGame.exe";
                //                            break;
            }
            try
            {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = filename;
                start.WindowStyle = ProcessWindowStyle.Normal;
                using (Process proc = Process.Start(start))
                {
                    proc.WaitForExit();
                }
            }
            catch
            {
                MessageBox.Show("Дані тимчасово відсутні!", "Атлас вибачається", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

    }
}
