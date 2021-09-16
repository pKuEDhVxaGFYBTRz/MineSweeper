using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    class BackendGrid
    {

        public GridBlock grid { get; }

        public BackendGrid()
        {
            // initialise backend grid
            GridBlock[,] grid = new GridBlock[8, 8];

            // create iterator variables
            int x, y;

            for (x = 0; x < 8; x++)
            {
                for (y = 0; y < 8; y++)
                {
                    // create a new grid block 
                    GridBlock block = new GridBlock();
                    grid[x, y] = block;
                }
            }

            /* TODO :
             * implement logic to generate a map
             * add logic to generate numbers
             * dynamic grid size based on difficulty settings
            */
        }
    }
}
