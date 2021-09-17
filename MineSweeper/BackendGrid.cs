using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    class BackendGrid
    {

        public GridBlock[,] grid { get; }
        public int size { get; set; }
        public int bombs { get; set; }

        public BackendGrid()
        {
            int bombs = 5;
            size = 8;

            Random Rnd = new Random();

            // initialise backend grid
            grid = new GridBlock[size, size];

            // create iterator variables
            int x, y, b, rx, ry, x2, y2, NearbyBombs, CheckX, CheckY;

            // create grid
            for (x = 0; x < 8; x++)
            {
                for (y = 0; y < 8; y++)
                {
                    // create a new grid block 
                    GridBlock block = new GridBlock();
                    grid[x, y] = block;
                }
            }

            // place bombs
            for (b = 0; b < bombs; b++)
            {
                rx = Rnd.Next(0, size);
                ry = Rnd.Next(0, size);

                // prevent duplicate bombs
                if (grid[rx, ry].Value.Equals("bomb"))
                {
                    b--;
                    continue;
                }

                // set value to bomb
                grid[rx, ry].Value = "bomb";
            }

            // add numbers around bombs
            for (x = 0; x < size; x++)
            {
                for (y = 0; y < size; y++)
                {
                    if (grid[x,y].Value == "bomb")
                    {
                        continue;
                    }

                    NearbyBombs = 0;

                    // calculate 3x3 square around cube
                    for (x2 = -1; x2 < 2; x2 ++)
                    {
                        
                        for (y2 = -1; y2 < 2; y2 ++)
                        { 

                            CheckX = x + x2;
                            CheckY = y + y2;

                            // check if square is a bomb
                            try
                            {
                                if (grid[CheckX, CheckY].Value.Equals("bomb"))
                                {
                                    NearbyBombs++;
                                }
                            }

                            catch { continue; }
                        }
                    }

                    grid[x, y].Value = NearbyBombs.ToString();
                }
            }

            /* TODO :
             * implement logic to generate a map
             * add logic to generate numbers
            */
        }
    }
}
