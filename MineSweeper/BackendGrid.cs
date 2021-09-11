using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeper
{
    class BackendGrid
    {

        int ButtonWidth = 40;
        int ButtonHeight = 40;
        int Distance = 20;
        int start_x = 10;
        int start_y = 10;

        public GridBlock grid { get; }

        public BackendGrid()
        {
            // initialise backend grid
            GridBlock[,] grid = new GridBlock[8, 8];
        }
    }
}
