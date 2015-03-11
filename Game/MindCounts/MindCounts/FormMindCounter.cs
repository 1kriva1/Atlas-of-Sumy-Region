using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MindCounts
{
    public partial class FormMindCounter : Form
    {
        Random rand=new Random();
        int min_num=1;
        int max_num=20;
        int answer;
        int progress = 0;
        int max_progress = 3;
        string mode = "";
        int timerCounter = 10;
        int max_time = 10;
        
        public FormMindCounter()
        {
            InitializeComponent();
        }

        public void play_game(string modes)
        {
            button_plus.Enabled = true;
            button_minus.Enabled = true;
            button_multy.Enabled = true;
            button_divide.Enabled = true;
            textBox_level.Enabled = true;
            textBox_answer.Enabled = true;
            textBox_answer.Text = "";
                                    
            mode = modes;
            int a, b;
            max_num = Convert.ToInt16(textBox_level.Text);
            progressBar.Minimum = 0;
            progressBar.Maximum = 3;
            a = rand.Next(min_num,max_num);
            b = rand.Next(min_num, max_num);
            textBox_answer.Focus();
            clock.Tick += new EventHandler(clock_Tick); 
            clock.Start();
            if (mode == "plus")
            {
                answer = a + b;
                label_question.Text = a + "+" + b +"=";
            }
            if (mode == "minus")
            {
                if (a < b)
                {
                    int x = a;
                    a = b;
                    b = x;
                }
                answer = a - b;
                label_question.Text = a + "-" + b + "=";
            }
            if (mode == "multy")
            {
                answer = a*b;
                label_question.Text = a + "*" + b + "=";
            }
            if (mode == "divide")
            {
                answer = a;
                label_question.Text = a*b + ":" + b + "=";
            }                       
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            play_game("plus");
            button_plus.Enabled = false;
            button_minus.Enabled = false;
            button_multy.Enabled = false;
            button_divide.Enabled = false;
            textBox_level.Enabled = false;
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            play_game("minus");
            button_plus.Enabled = false;
            button_minus.Enabled = false;
            button_multy.Enabled = false;
            button_divide.Enabled = false;
            textBox_level.Enabled = false;
        }

        private void button_multy_Click(object sender, EventArgs e)
        {
            play_game("multy");
            button_plus.Enabled = false;
            button_minus.Enabled = false;
            button_multy.Enabled = false;
            button_divide.Enabled = false;
            textBox_level.Enabled = false;
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            play_game("divide");
            button_plus.Enabled = false;
            button_minus.Enabled = false;
            button_multy.Enabled = false;
            button_divide.Enabled = false;
            textBox_level.Enabled = false;
        }

        private void textBox_answer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (Convert.ToString(answer) == textBox_answer.Text)
                {
                    progress++;
                    progressBar.Value = progress;
                    play_game(mode);
                    textBox_answer.Text = "";
                    label_time.Text = (max_time).ToString();
                    timerCounter = max_time;
                }
                else
                {
                    textBox_answer.Text = answer.ToString();
                    progressBar.Value = 0;
                    textBox_answer.Enabled = false;
                }

                if (progress == max_progress)
                {
                    clock.Stop();
                    progress = 0;
                    progressBar.Value = 0;
                    textBox_answer.Text = "";
                    label_question.Text = "";
                    MessageBox.Show("You win!","Congratulation");
                    
                }
            }
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            label_time.Text = (timerCounter--).ToString();
            if (timerCounter == 0)
            {
                clock.Stop();
                MessageBox.Show("Time left", "Time!");                
            }
        }
    }
}
