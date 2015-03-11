using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OX
{
    class Logic
    {
        int [,]map=new int[3, 3]; // 0-is empty box; 1- is khrest; 2-is zero;
        public int side { get; private set; }// who is take a step; 1-khrest, 2-zero;//modificator of acseess; can give, but set only in Logic
        bool play; // a logic thing that show the game status
        public int step;  // how many game steps were made 
        public string finish{ get; private set; }
        Random rnd = new Random();

        public Logic()
        {
            Init();
        }

        public void Init()
        {
            for(int x=0; x<3; x++)
                for(int y=0; y<3; y++)
                    map[x, y]=0;
            side = 1; // the game is started by khrest all the time
            play = true;
            step = 0;
        }

        public bool Place(int x, int y)//make a new step of game
        {
            if(!play) return false;
            if (x < 0 || x > 2) return false;
            if (y < 0 || y > 2) return false;
            if (map[x, y] > 0) return false;

            map[x, y] = side;// put 1 or 2 in map
            step++;
            finish = Finish(x, y);
            side = 3 - side; // if(side==1) side=2; else side=1;// change the users
            return true;
        }

        private string Finish(int x, int y)// this function come back string:winx,wino,draw, play;
        {
            bool win = false;
            if (map[x, 0] == side && map[x, 1] == side && map[x, 2] == side)  win = true;
            if (map[0, y] == side && map[1, y] == side && map[2, y] == side)  win = true;
            if (map[0, 0] == side && map[1, 1] == side && map[2, 2] == side)  win = true;
            if (map[0, 2] == side && map[1, 1] == side && map[2, 0] == side)  win = true;

            if (win)
            {
                if (side == 1)
                {
                    play = false;
                    return "winx";
                }
                else
                {
                    play = false;
                    return "wino";
                }
            }

            if (step == 9)
                {
                    play = false;
                    return "draw";
                }    
            
            else return "play";
        }

        public void Comp_random(out int x, out int y)
        {
            int loop=100;

            do
            {
                x = rnd.Next(0, 3);
                y = rnd.Next(0, 3);
            }
            while (map[x, y] > 0 && --loop > 0);
            Place(x, y);
        }

        public void Comp(out int x, out int y)
        {
            x = 0; y = 0;
            if (step == 0)
            {
                int d = rnd.Next(0, 5);
                if (d == 0) { x = 1; y = 1;}
                if (d == 1) { x = 0; y = 0;}
                if (d == 2) { x = 0; y = 2;}
                if (d == 3) { x = 2; y = 0;}
                if (d == 4) { x = 2; y = 2;}
                Place(x, y);
                return;
            }
            if (step ==1)
            {
                x = 1; y = 1;
                if (map[1, 1] == 0)
                    Place(1, 1);
                    
                else
                {
                    int d = rnd.Next(1, 5);
                    if (d == 1) { x = 0; y = 0; }
                    if (d == 2) { x = 0; y = 2; }
                    if (d == 3) { x = 2; y = 0; }
                    if (d == 4) { x = 2; y = 2; }
                }
                Place(x, y);
                return;
            }
            int nr;
            for (int n=0; n < 3; n++)// search in all direction to find function "three"
            {
                if (three(side, map[n, 0], map[n, 1], map[n, 2], out nr))
                {
                    x = n;
                    y = nr;
                    Place(x, y);
                    return;
                }
                if (three(side, map[0, n], map[1, n], map[2, n], out nr))
                {
                    x = nr;
                    y = n;
                    Place(x, y);
                    return;
                }
            }
            if (three(side, map[0, 0], map[1, 1], map[2, 2], out nr))
            {
                x = nr;
                y = nr;
                Place(x, y);
                return;
            }
            if (three(side, map[0, 2], map[1, 1], map[2, 0], out nr))
            {
                x = nr;
                y = 2-nr;
                Place(x, y);
                return;
            }
            if (find_three(side, out x, out y))
                return;
            if (find_three(3-side, out x, out y))
                return;
            
            Comp_random(out x, out y);
        }

        private bool find_three(int s, out int x, out int y)
        {
            int nr;
            x=0;y=0;
            for (int n = 0; n < 3; n++)// search in all direction to find function "three"
            {
                if (three(s, map[n, 0], map[n, 1], map[n, 2], out nr))
                {
                    x = n;
                    y = nr;
                    Place(x, y);
                    return true;
                }
                if (three(s, map[0, n], map[1, n], map[2, n], out nr))
                {
                    x = nr;
                    y = n;
                    Place(x, y);
                    return true;
                }
            }
            if (three(s, map[0, 0], map[1, 1], map[2, 2], out nr))
            {
                x = nr;
                y = nr;
                Place(x, y);
                return true;
            }
            if (three(s, map[0, 2], map[1, 1], map[2, 0], out nr))
            {
                x = nr;
                y = 2 - nr;
                Place(x, y);
                return true;
            }
            return false;
        }

        private bool three(int s, int a, int b, int c, out int nr)// s - which side at this moment; or who is step now
        {
            nr = 0;
            if(a==0 && b==s && c==s)
            {                
                nr = 0;
                return true;
            }
            if (a == s && b == 0 && c == s)
            {
                nr = 1;
                return true;
            }
            if (a == s && b == s && c == 0)
            {                
                nr = 2;
                return true;
            }
            return false;
        }              
    }
}
