using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game15
{
    public partial class Form1 : Form
    {
        Game game;
        public Form1()
        {
            InitializeComponent();
            game = new Game();
            start_game();
        }

        private void start_game()
        {
            game.start();
            for (int n = 0; n < 100; n++)
                game.shift_random();
                refresh();
        }
        
        private void refresh()
        {
            for(int i=1; i<=16;i++)
            {
                int nr = game.get_number(i);
                button (i).Text = nr.ToString();
                button(i).Visible = !(nr == 0);
            }
            finish_game();
        }

        private Button button(int position)
        {
            switch(position)
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
                case 10: return button10; 
                case 11: return button11; 
                case 12: return button12; 
                case 13: return button13; 
                case 14: return button14; 
                case 15: return button15; 
                case 16: return button16; 
                default: return null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int position=Convert.ToInt16(((Button)sender).Tag);
            game.shift(position);
            refresh();
        }

        private void finish_game()
        {
            if(game.finish())
            {
                enabled_buttons(false);
            }
        }

        private void enabled_buttons(bool enabled)
        {
            for (int j = 1; j <= 16; j++)
                button(j).Enabled = enabled;
        }

        private void вийтиЗіГриToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            start_game();
            enabled_buttons(true);
        }
    }
}
