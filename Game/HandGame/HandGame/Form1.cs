using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HandGame
{
    public partial class Form1 : Form
    {
        string user_figure="";
        string comp_figure="";
        Random rand = new Random();
        int win=0, draw=0, lose=0;
        string mode = "show";

        public Form1()
        {
            this.Text = "Камінь ножиці бумага";
            InitializeComponent();
            show_result();
        }

        private void start_game()
        {
            if(mode!="play")
            {
                label_nessege.Text="Вибери свою фігуру!";
                mode="play";
            }
        }

        private void show_user_figure(string figure)
        {
            start_game();
            pictureBox_paper.Visible = figure == "paper";
            pictureBox_stone.Visible = figure == "stone";
            pictureBox_scissors.Visible = figure == "scissors";
            user_figure = figure;

        }

        private void show_comp_figure(string figure)
        {
            comp_paper.Visible = figure == "paper";
            comp_stone.Visible = figure == "stone";
            comp_scissors.Visible = figure == "scissors";
            comp_figure = figure;
        }

        private void panel_stone_MouseEnter(object sender, EventArgs e)
        {
            show_user_figure((((Panel)sender).Tag).ToString());
        }

        private void pictureBox_stone_MouseClick(object sender, MouseEventArgs e)
        {
            if (mode == "play")
                check_result();
            else
                start_game();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(mode=="play")
            comp_figure_show_figure();
        }

        private void comp_figure_show_figure()
        {
            int f=rand.Next(1,4);
            if(f==1) show_comp_figure("stone");
            if (f == 2) show_comp_figure("paper");
            if (f == 3) show_comp_figure("scissors");
        }

        private void show_result()
        {
            label_result.Text = "Перемоги: " + win +
                "  Нічиї: " + draw +
                "  Програші: "+lose;
        }

        private void check_result()
        {
            mode = "show";
            int pob=0;
            int pro = 0;
            int nich = 0;
            if (user_figure == comp_figure)
                nich = 1;
            else
            {
                if (user_figure == "stone")
                    if (comp_figure == "scissors")
                        pob = 1;
                    else
                        pro = 1;
                if (user_figure == "scissors")
                    if (comp_figure == "paper")
                        pob = 1;
                    else
                        pro = 1;
                if (user_figure == "paper")
                    if (comp_figure == "stone")
                        pob = 1;
                    else
                        pro = 1;
            }
            win += pob;
            lose += pro;
            draw += nich;
            if (pob > 0) label_nessege.Text = "Ви перемогли!";
            if (pro > 0) label_nessege.Text = "Ви програли!";
            if (nich > 0) label_nessege.Text = "Нічия...";
            show_result();
        }

        private void trackBar_ValueChanged(object sender, EventArgs e)
        {
            if (trackBar.Value == 1) timer.Interval = 300;
            if (trackBar.Value == 2) timer.Interval = 200;
            if (trackBar.Value == 3) timer.Interval = 100;
            if (trackBar.Value == 4) timer.Interval = 50;
            if (trackBar.Value == 5) timer.Interval = 30;
        } 
    }
}
