using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
namespace Digits
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        int buttons = 9;
        int current;
        int timeLeft;
        int fals=0;
        int max_fals;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void game_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                @"Інформація про гру:
                  
Нажимай на цифри по черзі від одного до девяти", "Інфо");
        }

        private void game_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void start_game_Click(object sender, EventArgs e)
        {
            start_games();
        }

        private void start_games()
        {
            comboBox.Enabled = false;
            if (comboBox.Text == "")
            {
                timeLeft = 10;
                max_fals = 3;
            }
            if (comboBox.Text==1.ToString())
            {
                timeLeft = 10;
                max_fals=3;
            }
            else if (comboBox.Text == 2.ToString())
            {
                timeLeft = 5;
                progress_bar.Maximum = 2;
                max_fals=2;
            }
            else if (comboBox.Text == 3.ToString())
            {
                timeLeft = 3;
                progress_bar.Maximum = 1;
                max_fals = 1;
            }
            progress_bar.Visible=true;
            label_text.Visible = true;
            label.Visible = true;
            progress_bar.Value = 0;
            fals = 0;
            timer.Enabled = true;
            timer.Start();
            picture.Visible = false;
            for (int z = 1; z <= buttons; z++)
                button(z).Enabled = false;
            current = 1;
            for (int j = 1; j <= buttons; j++)
                button(j).Text = j.ToString();

            for (int i = 1; i <= buttons; i++)
                    button(i).Visible = true;

            for (int n = 1; n <= buttons*100;n++)
                swap_buttons();
            
        }

        private void swap_buttons()
        {
            int a = rand.Next(1, 10);
            int b = rand.Next(1, 10);
            string text = button(a).Text;
            button(a).Text = button(b).Text;
            button(b).Text = text;
        }
        private Button button(int num)
        {
            switch (num)
            {
                case 1: return button1;
                case 2: return button2;
                case 3: return button3;
                case 4: return button4;
                case 5: return button5;
                case 6: return button6;
                case 7: return button7;
                case 8: return button8;
                case 9: return button9;
                default: 
                    return null;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nomer = ((Button)sender).Text;
            if (nomer == current.ToString())
            {
                ((Button)sender).ForeColor = Color.Green;
                current++;
                if (current == buttons + 1)
                {
                    picture.Visible = true;
                    comboBox.Enabled = true;
                    progress_bar.Value = 0;
                    MessageBox.Show("Ти переміг!", "Молодець!!!");
                }
            }
            else
                fals++;
            progress_bar.Value = fals;
            if(fals>=max_fals)
            {
                comboBox.Enabled = true;
                MessageBox.Show("Твої спроби закінчились", "Спробуй ще!");
                return;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft = timeLeft - 1;
                label.Text = timeLeft + " секунд";
            }
            else
            {
                
                timer.Stop();
                label.Text = "Час вийшов!";
                for (int u = 1; u <= buttons; u++)
                    button(u).ForeColor = Color.White;
                for (int z = 1; z <= buttons; z++)
                    button(z).Enabled = true;
            }                      
        }
    }
}
