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
        const int ButtonWidth = 35;
        const int ButtonHeight = 35;
        const int Distance = 20;
        const int start_x = 0;
        const int start_y = 0;

        // make the grid block
        public GridBlock grid { get; }

        public DisplayGrid(Panel gamePanel)
        {
            // initialise display grid
            GridBlockGui[,] grid = new GridBlockGui[8, 8];

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
                        //Text = "t",
                        Visible = true
                    };

                    // add button to panel
                    gamePanel.Controls.Add(tmpButton);

                    // add button to array to 2D array so it can be indexed
                    grid[x,y] = tmpButton;
                }
            }
        }
    }
}
