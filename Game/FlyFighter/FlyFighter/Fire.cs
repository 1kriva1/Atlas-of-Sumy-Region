using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FlyFighter
{
    class Fire : Zero
    {
        bool active;
        int step = 15;

        public Fire(int min_x, int min_y, int max_x, int max_y)
        {
            w = 11;
            h = 11;
            pad = 5;
            this.min_x = min_x;
            this.min_y = min_y;
            this.max_x = max_x;
            this.max_y = max_y; 
        }

        public void Init(Point coords)
        {
            x = coords.X;
            y = coords.Y;
            active = true;
        }

        public void stop()
        {
            active = false;
        }

        public void move()
        {
            if (!active) return;
            int new_y=y-step;
            if (new_y <= min_y)
            {
                stop();
                return;
            }
            y = new_y;
        }

        public bool is_active()
        {
            return active;
        }

        public Point center_coords()
        {
            return new Point(x + w / 2, y + h / 2);
        }
    }
}
