using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PictureCardsE
{
    public partial class Form1 : Form
    {
        string mode = "";
        static int cards = 16;
        int open=0;
        int first_nr, second_nr;
        string[] names = new string[cards + 1];


        public Form1()
        {
            InitializeComponent();
            StartGame();
        }

        private void ShowCards(int nr)
        {
            picture (nr).Image = Image.FromFile(names[nr]);
            picture(nr).Cursor = Cursors.Arrow;
        }

        private void HideCards(int nr)
        {
            picture(nr).Image = Image.FromFile(names[0]);
            picture(nr).Cursor = Cursors.Hand;
        }

        private PictureBox picture(int nr)
        {
            switch (nr)
            {
                case 1:  return pictureBox1; 
                case 2:  return pictureBox2; 
                case 3:  return pictureBox3; 
                case 4:  return pictureBox4; 
                case 5:  return pictureBox5; 
                case 6:  return pictureBox6; 
                case 7:  return pictureBox7; 
                case 8:  return pictureBox8; 
                case 9:  return pictureBox9; 
                case 10: return pictureBox10; 
                case 11: return pictureBox11; 
                case 12: return pictureBox12; 
                case 13: return pictureBox13; 
                case 14: return pictureBox14; 
                case 15: return pictureBox15; 
                case 16: return pictureBox16; 
                default: return null;
            }
        }

        private void startgameЗГриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            mode = "0";
            open = 0;
            InitNames();
            ShuffleCards();
            for (int i = 1; i <= cards; i++)
            {
                HideCards(i);
            }
        }

        private void InitNames()
        {
            int p=1;
            names[0] = "none.png";
            for (int i = 1; i <= cards; i++)
            {
                names[i] = p.ToString() + ".png";
                if (i % 2 == 0)
                    p++;
            }
        }

        private void ShuffleCards()
        {
            Random rand = new Random();
            for (int i = 1; i <= 16; i++)
                swap_names(rand.Next(1,cards), rand.Next(1, cards));
        }

        private void swap_names(int a, int b)
        {
            string name;
            name = names[a];
            names[a] = names[b];
            names[b] = name;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int nr = Convert.ToInt16(((PictureBox)sender).Tag);
            switch (mode)
            {
                case "0": open_0(nr); break;
                case "1": open_1(nr); break;
                case "2": open_2(nr); break;
            }
        }

        private void open_0(int nr)
        {
            if (names[nr] == "") return;
            first_nr = nr;
            ShowCards(nr);
            mode = "1";
        }

        private void open_1(int nr)
        {
            if (names[nr] == "") return;
            if (nr == first_nr) return;
            second_nr = nr;
            ShowCards(nr);
            if (open == cards - 2)
            {
                FinishGame();
            }
            else
            mode = "2";
        }

        private void open_2(int nr)
        {
            if (names[first_nr] == names[second_nr])
            {
                names[first_nr] = "";
                names[second_nr] = "";
                open = open + 2;
            }
            else
            {
                HideCards(first_nr);
                HideCards(second_nr);
                picture(nr).Cursor = Cursors.Arrow;
            }
            mode = "0";
            open_0(nr);
        }

        private void FinishGame()
        {
            mode = "win";
            MessageBox.Show("Ви перемогли!", "Перемога!!!");
        }

        private void вийтиЗГриToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void правилаГриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Необхідно зібрати всі пари фруктів. Відкривши одну картинку, її треба запам'ятати та з'єднати з її парою.", 
                "Довідка", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void проГруToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Гра створена Андрієм Криворуком",
               "Про гру", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
