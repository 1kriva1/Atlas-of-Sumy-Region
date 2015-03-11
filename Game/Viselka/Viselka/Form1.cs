using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Viselka
{
    public partial class FormViselka : Form
    {
        string abc="АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        string word;
        string word_show;
        static Random rand=new Random();
        int errors = 0;
        int max_errors = 7;
        Button[] key;        

        public FormViselka()
        {
            InitializeComponent();            
        }                

        private void FormViselka_Load(object sender, EventArgs e)
        {
            InitInterface();
            InitGame();
        }

        public void InitInterface()
        {
            InitKeys();
        }

        public void InitGame()
        {
            errors = 0;
            Show_keys();
            ShowPicture(0);
            ChooseWord();
        }
       
        private void InitKeys()
        {
            int size_w = panel.Width / 8;
            int size_h = panel.Height / 4;
            key = new Button[abc.Length];
            int x, y;            
            for(int j=0; j<abc.Length; j++)
            {
                x = j % 8;
                y = j / 8;
                key[j] = new Button(); // create element of massive to button
                panel.Controls.Add(key[j]);
                key[j].Location = new Point(x*size_w, y*size_h);
                key[j].Size = new Size(size_w-4, size_h-2);
                key[j].TabIndex = j;
                key[j].Text = abc.Substring(j, 1);
                key[j].Tag = j;
                key[j].Click += new System.EventHandler(this.buttonKey_Click);                
            }
        }

        private void Show_keys()
        {
            for(int j=0; j<abc.Length; j++)
                key[j].Visible = true;
        }

        private void ShowPicture(int step)
        {
            switch(step)
            {
                case 1: picture_error.Image = Properties.Resources.step_1; break;
                case 2: picture_error.Image = Properties.Resources.step_2; break;
                case 3: picture_error.Image = Properties.Resources.step_3; break;
                case 4: picture_error.Image = Properties.Resources.step_4; break;
                case 5: picture_error.Image = Properties.Resources.step_5; break;
                case 6: picture_error.Image = Properties.Resources.step_6; break;
                case 7: picture_error.Image = Properties.Resources.step_7; break;
                default: picture_error.Image = null; break;
            }
        }

         private void ChooseWord()
         {
             string [] n1 = {Environment.NewLine}; // it is for jump to a new line
             string[] words = Properties.Resources.slova.Split(n1, StringSplitOptions.RemoveEmptyEntries);
             do                
               word = words[rand.Next(0, words.Length)].Trim();                
             while (word.Length<5);
             word_show = new String('*', word.Length);
             label_word.Text = word_show;
         }

        private void buttonKey_Click(object sender, EventArgs e)
        {
            string letter=((Button)sender).Text;
            ((Button)sender).Visible = false;
            if (word.IndexOf(letter) >= 0)
            {
                ShowLetter(letter);
            }
            else
            {
                ShowError();
            }
        }

        private void ShowLetter(string letter)
        {
            string show = "";
            for(int j=0; j<word.Length; j++)
            {
                if (word_show.Substring(j, 1) == "*")
                    if (word.Substring(j, 1) == letter)
                        show += letter;
                    else
                        show += "*";
                else
                    show += word_show.Substring(j, 1); 
            }
            word_show = show;
            label_word.Text = word_show;

            if (word_show.IndexOf("*") == -1)
                ShowWin();
        }

        private void ShowError()
        {
            errors++;
            ShowPicture(errors);
            if(errors>+max_errors)
            ShowLose();
        }

        private void ShowWin()
        {
            MessageBox.Show("Ви розгадали слово!", "Перемога!");
            InitGame();
        }

        private void ShowLose()
        {
            label_word.Text = word;
            MessageBox.Show("Ви не знайшли слово", "Невдача!");
            InitGame();
        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            InitGame();
        }
    }
}
