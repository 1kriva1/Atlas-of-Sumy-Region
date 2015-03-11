using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace FlyFighter
{
    class Zero// this class contain basic variable and methods
    {
        protected int x, y;        
        protected int min_x, min_y;
        protected int max_x, max_y;
        protected int h, w;
        protected int pad;

        public Zero()
        {

        }
        public Zero(int min_x, int min_y, int max_x, int max_y)
        {
            this.min_x = min_x;
            this.min_y = min_y;
            this.max_x = max_x;
            this.max_y = max_y; 
        }

        public void Init()
        {

        }

        public Point coords()
        {
            return new Point(x, y);            
        }

        public int get_w()
        {
            return w;
        }
        public int get_h()
        {
            return h;
        }
    }
}
