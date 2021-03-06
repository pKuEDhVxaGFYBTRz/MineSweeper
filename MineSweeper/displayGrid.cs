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
        const int ButtonWidth = 35;
        const int ButtonHeight = 35;
        const int Distance = 20;
        const int start_x = 0;
        const int start_y = 0;

        // make the grid block
        public GridBlockGui[,] grid { get; set; }
        public ImageHandler Images { get; set; }

        public DisplayGrid(Panel gamePanel, BackendGrid BGrid, Panel menu, Panel game)
        {

            // load images
            Images = new ImageHandler();

            // initialise display grid
            grid = new GridBlockGui[BGrid.size, BGrid.size];

            // create iterator variables
            int x, y;

            for (x = 0; x < BGrid.size; x++)
            {
                for (y = 0; y < BGrid.size; y++)
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

                    tmpButton.X = x;
                    tmpButton.Y = y;
                    tmpButton.BGrid = BGrid;
                    tmpButton.DGrid = this;
                    tmpButton.Menu = menu;
                    tmpButton.Game = game;


                    //tmpButton.Click()

                    // add button to panel
                    gamePanel.Controls.Add(tmpButton);

                    // add button to array to 2D array so it can be indexed
                    grid[x,y] = tmpButton;
                }
            }
        }
    }
}
