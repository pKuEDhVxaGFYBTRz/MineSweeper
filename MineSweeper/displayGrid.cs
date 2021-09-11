using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    // this class is similar to backend grid however it uses GridBlockGui to create buttons that can be clicked
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
                
            GridBlockGui[,] grid = new GridBlockGui[8, 8];

            MessageBox.Show("running class");

            // create iterator variables
            int x, y;

            for (x = 0; x < 8; x++)
            {
                for (y = 0; y < 8; y++)
                {
                    // create a new grid block 
                    GridBlockGui tmpButton = new GridBlockGui
                    {
                        Top = start_x + (x * ButtonHeight + Distance),
                        Left = start_y + (y * ButtonWidth + Distance),
                        Width = ButtonWidth,
                        Height = ButtonHeight,
                        Text = "t"
                    };

                    // add button to array to 2D array so it can be indexed
                    grid[x,y] = tmpButton;
                }
            }
        }
    }
}
