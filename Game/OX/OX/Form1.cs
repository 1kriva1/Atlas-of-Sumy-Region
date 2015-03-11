using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OX
{
    public partial class Form1 : Form
    {
        Logic logic = new Logic();
        Help help = new Help();
        bool use_comp = false;
        
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Enabled = false;
            pictureBox2.Enabled = false;
            pictureBox3.Enabled = false;
            pictureBox4.Enabled = false;
            pictureBox5.Enabled = false;
            pictureBox6.Enabled = false;
            pictureBox7.Enabled = false;
            pictureBox8.Enabled = false;
            pictureBox9.Enabled = false;                        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            make_move((PictureBox)sender);// function that use to all pictureboxes
        }

        public void make_move(PictureBox box)
        {
            int x, y; // coordinates  all boxes
            string tag = box.Tag.ToString();//write coord to string tag from tag
            x = int.Parse(tag.Substring(0, 1));// take coordenates from tag
            y = int.Parse(tag.Substring(1, 1));
            int side = logic.side;
            if (logic.Place(x, y))
            {
                box.Image = side == 1 ?//put the right cartoon
                    Properties.Resources.khrest : 
                    Properties.Resources.zero;
                if (logic.finish != "play")
                {
                    game_over();
                    return;
                }
                if(use_comp)
                    make_comp();                
            }                
        }

        private void game_over()
        {            
            switch (logic.finish)
            {
                case "winx": MessageBox.Show("Крестики перемогли", "Кінець гри"); return;
                case "wino": MessageBox.Show("Бублики перемогли", "Кінець гри"); return;
                case "draw": MessageBox.Show("Нічия", "Кінець гри"); return;
                default: return;
            }
        }

        public void make_comp() 
        {
            int side = logic.side;
            int x, y;
            int step = logic.step;
            logic.Comp(out x, out y);
            picture(x, y).Image = side == 1 ?
                Properties.Resources.khrest :
                Properties.Resources.zero;
            if (logic.finish != "play")
            {
                game_over();
                return;
            }            
        }               

        private void start_game()
        {
            logic.Init();
        }

        private void menu_game_human_Click(object sender, EventArgs e)
        {
            use_comp = false;
            start_game();
            pictureBox1.Image = null;// clear image in start
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;

            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;
        }
               
        private void menu_game_exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menu_help_rules_Click(object sender, EventArgs e)
        {
            help.show_rules();
        }

        private void menu_help_about_Click(object sender, EventArgs e)
        {
            help.show_about();
        }

        private void menu_game_computer_x_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;

            pictureBox1.Image = null;// clear image in start
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            use_comp = true;
            start_game();
            make_comp();
        }

        private void menu_game_computer_o_Click(object sender, EventArgs e)
        {
            pictureBox1.Enabled = true;
            pictureBox2.Enabled = true;
            pictureBox3.Enabled = true;
            pictureBox4.Enabled = true;
            pictureBox5.Enabled = true;
            pictureBox6.Enabled = true;
            pictureBox7.Enabled = true;
            pictureBox8.Enabled = true;
            pictureBox9.Enabled = true;

            pictureBox1.Image = null;// clear image in start
            pictureBox2.Image = null;
            pictureBox3.Image = null;
            pictureBox4.Image = null;
            pictureBox5.Image = null;
            pictureBox6.Image = null;
            pictureBox7.Image = null;
            pictureBox8.Image = null;
            pictureBox9.Image = null;
            use_comp = true;
            start_game();
           
        }

        private PictureBox picture(int x, int y)
        {
            if (x == 0 && y == 0) return pictureBox1;
            if (x == 1 && y == 0) return pictureBox4;
            if (x == 2 && y == 0) return pictureBox7;
            if (x == 0 && y == 1) return pictureBox2;
            if (x == 1 && y == 1) return pictureBox5;
            if (x == 2 && y == 1) return pictureBox8;
            if (x == 0 && y == 2) return pictureBox3;
            if (x == 1 && y == 2) return pictureBox6;
            if (x == 2 && y == 2) return pictureBox9;
            return null;
        }             
    }
}
