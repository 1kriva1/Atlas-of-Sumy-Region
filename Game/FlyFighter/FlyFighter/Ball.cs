using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;


namespace FlyFighter
{
    class Ball: Zero
    {                   
        int min_step = 5;
        int max_step = 10;
        int sx, sy;

        int frags = 0;
        public int level = 0;

        Random rand = new Random();

        public Ball(int min_x, int min_y, int max_x,  int max_y)
        {
            w = 64;
            h = 64;
            pad = 5;
            this.min_x = min_x;
            this.min_y = min_y;
            this.max_x = max_x;
            this.max_y = max_y; 
        }

        public void Init()
        {
            x = rand.Next(min_x + pad, max_x - pad - w + 1);
            y = rand.Next(min_y + pad, max_y - pad - h + 1);
            sx = rand.Next(min_step, max_step + 1);
            sy = rand.Next(min_step, max_step + 1);
            if (rand.Next(0, 2) == 0) sx = -sx;
            if (rand.Next(0, 2) == 0) sy = -sy;
        }       

        public void move()
        {
            int new_x = x + sx;
            int new_y = y + sy;
            if (new_x < min_x + pad || new_x + w + pad > max_x)
            {
                sx = -sx;
            }
            if (new_y < min_y + pad || new_y + h + pad > max_y)
            {
                sy = -sy;
            }
            x = new_x;
            y = new_y;
        }        

        public bool shot(Point fire_coords)
        {
            int x1 = fire_coords.X - (x+w/2);// fire_coords it is the coord of centers of fire and ball
            int y1 = fire_coords.Y - (y+h/2);
            int d = x1 * x1 + y1 * y1;
            if (d < w * w / 4)
            {
                Init();
                frags++;
                if (frags > 3)
                {
                    level = 1; 
                }               
                return true;
            }
            else 
                return false;
        }      

        public int Get_Frags()
        {
            return frags;
        }
        public int Get_Level()
        {
            return level;
        }
    }
}
