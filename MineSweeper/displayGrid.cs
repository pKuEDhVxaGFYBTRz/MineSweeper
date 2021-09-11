using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    class DisplayGrid
    {
        // constants
        const int ButtonWidth = 40;
        const int ButtonHeight = 40;
        const int Distance = 20;
        const int start_x = 10;
        const int start_y = 10;

        // make the grid block
        public GridBlock grid { get; }

        public DisplayGrid()
        {
            // initialise display grid
                
            GridBlock[,] grid = new GridBlock[8, 8];

            MessageBox.Show("running class");

            // create iterator variables
            int x, y;

            for (x = 0; x < 8; x++)
            {
                for (y = 0; y < 8; y++)
                {
                    GridBlock tmpButton = new GridBlock
                    {
                        Top = start_x + (x * ButtonHeight + Distance),
                        Left = start_y + (y * ButtonWidth + Distance),
                        Width = ButtonWidth,
                        Height = ButtonHeight,
                        Text = "t"
                    };

                    grid[x,y] = tmpButton;
                }
            }
        }
    }
}
