using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FlyFighter
{
    class Ship : Zero
    {
        /*int x, y;// coord of the ship
        int min_x, min_y; // coord of region where our ship can move
        int max_x, max_y;
        static int h = 64;
        static int w = 64;
        int pad = 3;*/

        public Ship(int min_x, int min_y, int max_x,  int max_y)
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
            y = max_y - h - pad;
            x = (min_x + max_x - w) / 2;
        }

        public void move(Point coords)
        {
            int new_x = coords.X - w / 2;
            if (new_x < min_x + pad) return;
            if (new_x + w > max_x - pad) return;
            x = new_x;
        }       
        
    }
}
