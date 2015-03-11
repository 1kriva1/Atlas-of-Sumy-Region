using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game15
{
    class Game
    {
        public static int size = 4;
        int[,] map = new int[size, size];
        int space_x, space_y;
        Random rnd;

        public Game()
        {            
            rnd = new Random();
        }

        public void start()
        {
            for (int y = 0; y < size; y++)
                for (int x = 0; x < size; x++)
                    map[x, y] = y * size + x + 1;
            space_x = size - 1;
            space_y = size - 1;
            map[space_x, space_y] = 0;
        }

        public int shift(int position)
        {
            int x, y;
            position_to_coords(position, out x, out y);

            if(Math.Abs(x-space_x)+Math.Abs(y-space_y)==1)
            {
                int number = map[x, y];
                map[x, y] = map[space_x, space_y];
                map[space_x, space_y] = number;
                int space_pos = space_y * size + space_x * size;
                space_x = x;
                space_y = y;
                return space_pos;
            }           

            return 0;
        }

        private void position_to_coords(int position, out int x, out int y)
        {
            x = (position - 1) % 4;
            y = (position - 1) / 4;
        }

        public bool finish()
        {
            if(space_x == size-1 && space_y == size-1)
            {
                for (int y = 0; y < size; y++)
                    for (int x = 0; x < size; x++)
                        if (map[x, y] != y * size + x + 1)
                            return (x == size - 1) && (y == size - 1);
            }
            return false;
        }

        public int get_number(int position)
        {
            int x, y;
            position_to_coords(position, out x, out y);
            return map[x, y];
        }

        public void shift_random()
        {
            int loop = 100;
            while(true)
            {
                loop--;
                if (loop <= 0) break;
                int step = rnd.Next(0, 4);
                int step_x = 0, step_y = 0, x, y;
                switch (step)
                {
                    case 0: step_x = -1; break;
                    case 1: step_x = 1; break;
                    case 2: step_y = -1; break;
                    case 3: step_y = 1; break;
                }

                x = space_x + step_x;
                y = space_y + step_y;
                if (x >= 0 && x < size && y >= 0 && y < size)
                {
                    shift(y * 4 + x + 1);
                    break;
                }
            }           
        }
    }
}
