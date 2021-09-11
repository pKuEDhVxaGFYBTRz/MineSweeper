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

            /* TODO :
             * implement logic to generate a map
             * add logic to generate numbers
             * dynamic grid size based on difficulty settings
            */
        }
    }
}
