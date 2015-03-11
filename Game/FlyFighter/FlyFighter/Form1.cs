using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlyFighter
{
    public partial class Form1 : Form
    {
        Ship ship;
        Ball ball;
        Fire fire;        

        public Form1()
        {
            InitializeComponent();
            ship = new Ship(0, 0, panel.Size.Width, panel.Size.Height);
            ball = new Ball(0, 0, panel.Size.Width, panel.Size.Height-ship.get_h());
            fire = new Fire(0, 0, panel.Size.Width, panel.Size.Height - ship.get_h());
            ship.Init();
            ball.Init();            

            label_frags.Text = "0";
            label_level.Text = ball.Get_Level().ToString();
            pict_ship.Image = Properties.Resources.Craft_1;
        }

        private void show_ship()
        {
            pict_ship.Location = ship.coords();
        }
        private void show_ball()
        {
            pict_ball.Location = ball.coords();                      
        }
        private void show_fire()
        {
            pict_fire.Location = fire.coords();
        }       
       

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            ship.move(PointToClient(Cursor.Position)); // point to client change coord of cursor
            //from global view of computer screen to view of our program
            show_ship();

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ball.move();
            show_ball();
            if (ball.Get_Frags() > 3)
            {                
                label_level.Text = ball.Get_Level().ToString();
                pict_ship.Image = Properties.Resources.Craft_2;
                pict_ball.Image = Properties.Resources.ufo_spaceship_vector_cartoon1;
            }
            if (fire.is_active())
            {                
                fire.move();
                show_fire();
                if (ball.shot(fire.center_coords())) //we give the coord of fire center to method
                {                    
                    label_frags.Text = ball.Get_Frags().ToString();
                    fire.stop();
                }
            }
            else
                pict_fire.Visible = false;
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            if (fire.is_active()) return;
            fire.Init(new Point(
                ship.coords().X+ship.get_w()/2-fire.get_w()/2, 
                ship.coords().Y-fire.get_h()));
            pict_fire.Visible = true;
        }
    }
}
