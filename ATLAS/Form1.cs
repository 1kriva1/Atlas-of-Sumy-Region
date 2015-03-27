using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
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
        Maps maps;        
        public static MapLegend ml;
        public static int bonus;
        string location { get; set; } // represent specific region of study
        string thema { get; set; } // thema of study
        string map { get; set; } // category of maps
        string layer { get; set; } // layers of maps
        string path { get; set; } // path to study image
        bool handID = false; // pointer that define "Hand function" 
        bool layersID; // pointer that define checkedBox_map_layers's visible 
        bool Login; // pointer that define user's login 
        bool checkID; // piinter for check update
        List<string> my_profile; // array for profile data 
        Control[] profileObjects;  // contain all textboxes which need for Myprofile settings  

        public Atlas_Main()
        {
            InitializeComponent();            
            pictureBox_map_MAIN.Image = new Bitmap(pictureBox_map_MAIN.Width, pictureBox_map_MAIN.Height);
            pictureBox_map_MAIN.MouseWheel += new System.Windows.Forms.MouseEventHandler(pictureBox_map_MAIN_MouseWheel);
            profileObjects = new Control[] { textBox_acc_name, textBox_acc_year, textBox_acc_town, 
                textBox_acc_school, label_acc_bonus_count };
            my_profile = new List<string>();
            layer = "123";
            mpr = new MyProfile();
            cc = new ControlController();            
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
            cc.VisibleChange(panel_games, button_game_back, panel_image, panel_title_map);
            cc.EnableChange(button_study, button_quizzes, button_maps, button_games, button_contour, button_my_profile);
        }

        //Back to main content from games
        private void button_game_back_Click(object sender, EventArgs e)
        {
            cc.VisibleChange(panel_games, button_game_back, panel_image, panel_title_map);
            cc.EnableChange(button_study, button_quizzes, button_maps, button_games, button_contour, button_my_profile);
        }

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
            cc.RefreshText(password_txt, login_txt, profileObjects, textBox_login, textBox_password);           
        }  
     
        // Use in order to reupdate profile information when edit is failed
        private void ReUpdateProfile()
        {
            for (int i = 0; i < my_profile.Count; i++)
                profileObjects[i].Text = my_profile[i];                
        }

        // Open My profile menu and load info about user
        private void button_my_profile_Click(object sender, EventArgs e)
        {
            if(Login)
            {
                cc.VisibleOn(panel_profile, label_account_title, label_acc_name, label_acc_school, label_acc_town, label_acc_year,
                    label_acc_bonus,label_acc_bonus_count,pictureBox_acc_bonus,textBox_acc_name,
                    textBox_acc_school,textBox_acc_town,textBox_acc_year,button_acc_edit, button_exit);
                cc.VisibleOff(label1, label2, password_txt, login_txt, button_login, button_regestration, label_login,
                    label_password, textBox_login, textBox_password, panel_title_map, panel_image);                                
                cc.EnableChange(button_study, button_maps, button_contour, button_my_profile,button_quizzes, button_games);                
            }
            else
            {
                cc.VisibleOn(label1, label2, button_login, button_regestration, password_txt, login_txt, panel_profile);
                cc.VisibleOff(label_login, label_password, textBox_login, textBox_password, button_regestry, 
                    button_exit, panel_title_map, panel_image);                
                cc.EnableChange(button_study, button_maps, button_contour, button_my_profile);              
            }
            cc.RefreshText(login_txt, password_txt);            
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
                cc.RefreshText(login_txt, password_txt);                
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
            my_profile.Clear();
            bonus = 0;
            Login=false;
        }

        // Back to main menu and save all changes in user's information    
        private void button_acc_back_Click(object sender, EventArgs e)
        {           
            if(Login)
                cc.EnableChange(button_study, button_quizzes, button_maps, button_games, button_contour, button_my_profile);
            else
                cc.EnableChange(button_study, button_maps, button_contour, button_my_profile);
            cc.VisibleOff(label_account_title, label_acc_name, label_acc_school, label_acc_town, label_acc_year,
                    label_acc_bonus, label_acc_bonus_count, pictureBox_acc_bonus, textBox_acc_name,
                    textBox_acc_school, textBox_acc_town, textBox_acc_year, button_acc_edit, panel_profile, button_regestry, panel_profile);
            cc.VisibleChange(panel_image, panel_title_map);
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
            {
                label_account_title.Text = "Привіт, " + textBox_acc_name.Text + " !";
                MessageBox.Show("Змінни профілю прийняті!", "Редагування", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                
            else
            {
                ReUpdateProfile();
                label_account_title.Text = "Привіт !";
                MessageBox.Show("Ви не внесли всі необхідні дані!", "Редагування", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }                      
        }

        #endregion

        #region Study         

        //Open common information about specific region
        private void OpenStudyInformation_Click(object sender, EventArgs e)
        {
            cc.EnableChange(button_study_inform, button_study_geo, button_study_netur, button_study_history, button_study_admin,
                button_study_demogr, button_study_people, button_study_monum);            
            cc.VisibleOn(pictureBox_study, button_study_back_list, button_study_back_list);
            cc.VisibleOff(panel_study, button_study_back);            
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
            thema = "Common";
            path = "Study\\" + thema + "\\" + location + ".tif";     
            pictureBox_study.Image = LoadThema(path);
        }

        // Back to list of regions
        private void button_study_back_list_Click(object sender, EventArgs e)
        {            
            cc.VisibleChange(panel_study, button_study_back_list, button_study_back, pictureBox_study);            
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
                case "button_study_geo":    thema = "Geography";
                                            break;
                case "button_study_netur":  thema = "Natural";
                                            break;
                case "button_study_history": thema = "History";
                                             break;
                case "button_study_admin":  thema = "Administration";
                                            break;
                case "button_study_people": thema = "People";
                                            break;
                case "button_study_monum":  thema = "Monument";
                                            break;
                case "button_study_demogr": thema = "Demography";
                                            break;
            }
            path = "Study\\" + thema + "\\" + location + ".tif";      
            pictureBox_study.Image = LoadThema(path);
        }

        // Change title region statistic
        private void label_title_Click(object sender, EventArgs e)
        {
            string path;
            Label label = sender as Label;
            switch (label.Name)
            {
                case "label_title_1": path = "Title\\" + label_title_1.Text + ".tif";
                                      pictureBox_title_stat.Image = LoadThema(path);
                                      break;
                case "label_title_2": path = "Title\\" + label_title_2.Text + ".tif";
                                      pictureBox_title_stat.Image = LoadThema(path);
                                      break;
                case "label_title_3": path = "Title\\" + label_title_3.Text + ".tif";
                                      pictureBox_title_stat.Image = LoadThema(path);
                                      break;
                case "label_title_4": path = "Title\\" + label_title_4.Text + ".tif";
                                      pictureBox_title_stat.Image = LoadThema(path);
                                      break;
                case "label_title_5": path = "Title\\" + label_title_5.Text + ".tif";
                                      pictureBox_title_stat.Image = LoadThema(path);
                                      break;
                case "label_title_6": path = "Title\\" + label_title_6.Text + ".tif";
                                      pictureBox_title_stat.Image = LoadThema(path);
                                      break;
                case "label_title_7": path = "Title\\" + label_title_7.Text + ".tif";
                                      pictureBox_title_stat.Image = LoadThema(path);
                                      break;
                case "label_title_8": path = "Title\\" + label_title_8.Text + ".tif";
                                      pictureBox_title_stat.Image = LoadThema(path);
                                      break;
                case "label_title_9": path = "Title\\" + label_title_9.Text + ".tif";
                                      pictureBox_title_stat.Image = LoadThema(path);
                                      break;
                case "label_title_10": path = "Title\\" + label_title_10.Text + ".tif";
                                      pictureBox_title_stat.Image = LoadThema(path);
                                       break;
                case "label_title_11": path = "Title\\" + label_title_11.Text + ".tif";
                                       pictureBox_title_stat.Image = LoadThema(path);
                                       break;
                case "label_title_12": path = "Title\\" + label_title_12.Text + ".tif";
                                       pictureBox_title_stat.Image = LoadThema(path);
                                       break;
                case "label_title_13": path = "Title\\" + label_title_13.Text + ".tif";
                                       pictureBox_title_stat.Image = LoadThema(path);
                                       break;
                case "label_title_14": path = "Title\\" + label_title_14.Text + ".tif";
                                       pictureBox_title_stat.Image = LoadThema(path);
                                       break;
                case "label_title_15": path = "Title\\" + label_title_15.Text + ".tif";
                                       pictureBox_title_stat.Image = LoadThema(path);
                                       break;
                case "label_title_16": path = "Title\\" + label_title_16.Text + ".tif";
                                       pictureBox_title_stat.Image = LoadThema(path);
                                       break;
                case "label_title_17": path = "Title\\" + label_title_17.Text + ".tif";
                                       pictureBox_title_stat.Image = LoadThema(path);
                                       break;
                case "label_title_18": path = "Title\\" + label_title_18.Text + ".tif";
                                       pictureBox_title_stat.Image = LoadThema(path);
                                       break;
            }  
        }

        // Load study information
        private Image LoadThema(string path)
        {
            try
            {
                return Image.FromFile(path);
            }
            catch(FileNotFoundException)
            {
                MessageBox.Show("Дані тимчасово відсутні!", "Атлас вибачається", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка!", "Атлас вибачається", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return null;
            }
        }       

        #endregion

        #region Maps

        // Refresh map settings
        private void RefreshMapSettings()
        {
            panel_map_layers.Visible = false;
            layersID = false;
            handID=false;
            pictureBox_map_MAIN.Cursor = Cursors.Default;
            layer = "123";
            checkID = false;
            cc.CheckOn(checkBox1, checkBox2, checkBox3);             
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
                comboBox_map_content.Items.Add(mass[i]);            
            checkID = checkID.Equals(true) ? false : true;
            RefreshMapSettings();
            trackBar_map_scale.Value = maps.DefaultMapSetting();
            comboBox_map_content.SelectedIndex = 0;                        
        }

        // Select the desired map, according to category of maps 
        private void comboBox_map_content_SelectedIndexChanged(object sender, EventArgs e)
        {
            trackBar_map_scale.Value = maps.DefaultMapSetting();            
            RefreshMapSettings();
            checkID = checkID.Equals(true) ? false : true;
            string[] LayersText = maps.LoadLayersText(comboBox_map_content.Items[comboBox_map_content.SelectedIndex].ToString(), map);
            checkBox1.Text = LayersText[0];
            checkBox2.Text = LayersText[1];
            checkBox3.Text = LayersText[2];
            maps.DrawMap(comboBox_map_content.Items[comboBox_map_content.SelectedIndex].ToString(), map, layer, pictureBox_map_MAIN.Image);            
            pictureBox_map_MAIN.Refresh();
        }

        // Back from maps to main content
        private void button_map_back_Click(object sender, EventArgs e)
        {
            cc.VisibleChange(panel_map_maps, panel_additional, panel_image, panel_content, pictureBox_title_image, panel_title_map);
            checkID = checkID.Equals(true) ? false : true;            
            RefreshMapSettings();
            if (ml != null)
                ml.Close();
        }

        // Change layers
        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (checkID)
            {
                CheckBox chbox = sender as CheckBox;
                switch (chbox.Name)
                {
                    case "checkBox1":
                        if (!chbox.Checked)
                            layer = layer.Remove(0, 1);
                        else
                            layer = layer.Insert(0, "1");
                        break;
                    case "checkBox2":
                        if (!chbox.Checked)
                        {
                            if (layer[0] == '2' && layer.Length!=1)
                                layer = layer.Remove((layer.Length / 2 - 1), 1);
                            else
                                layer = layer.Remove((layer.Length / 2), 1);
                        }
                        else
                        {
                            if (layer.Length == 0)
                                layer = layer.Insert(0, "2");
                            else
                            {
                                if (layer[0] == '3')
                                    layer = layer.Insert(0, "2");
                                else
                                    layer = layer.Insert(1, "2");
                            }
                        }
                        break;
                    case "checkBox3":
                        if (!chbox.Checked)
                            layer = layer.Remove((layer.Length - 1), 1);
                        else
                            layer = layer.Insert(layer.Length, "3");
                        break;
                }
                if (layer == "")
                    maps.DrawMap(comboBox_map_content.Items[comboBox_map_content.SelectedIndex].ToString(), map, "0", pictureBox_map_MAIN.Image);
                else                
                    maps.DrawMap(comboBox_map_content.Items[comboBox_map_content.SelectedIndex].ToString(), map, layer, pictureBox_map_MAIN.Image);                
            }
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
                panel_map_layers.Visible = true;
            else
                panel_map_layers.Visible = false;
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
            if (comboBox_map_content.SelectedItem!=null && ml==null)
            {
                ml = new MapLegend();
                ml.LoadLegend(map, comboBox_map_content.SelectedItem.ToString());
                ml.Show();
            }            
        }

        //Return map to it default location
        private void button_replace_Click(object sender, EventArgs e)
        {
            trackBar_map_scale.Value = maps.DefaultMapSetting();
            maps.DrawMap();
        }
        #endregion

        #region Games
        private void Open_Game_DoubleClick(object sender, EventArgs e)
        {
            string filename = "";
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
                case "pictureBox_PictureCards": filename = "Games\\PictureCardsE.exe";
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
            catch(FileNotFoundException)
            {
                MessageBox.Show("Дані тимчасово відсутні!", "Атлас вибачається", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Помилка!", "Атлас вибачається", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        
    }
}
