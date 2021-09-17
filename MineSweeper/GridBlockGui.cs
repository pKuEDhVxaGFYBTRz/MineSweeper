using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    class GridBlockGui : Button
    {
        public int X { get; set; }
        public int Y { get; set; }
        public BackendGrid BGrid { get; set; }
        public DisplayGrid DGrid { get; set; }
        public Panel Game { get; set; }
        public Panel Menu { get; set; }

        public GridBlockGui()
        {
            // add callback to event handler
            this.Click += CallbackHandler;
        }

        public void CallbackHandler(object sender, System.EventArgs e)
        {
            this.Enabled = false;

            if (BGrid.grid[X,Y].Value.Equals("bomb"))
            {
                DGrid.grid[X, Y].Image = DGrid.Images.Bomb;

                MessageBox.Show("game over");

                // make the game visible

                Menu.Visible = true;
                Game.Visible = false;

            }
            else
            {
                DGrid.grid[X, Y].Text = BGrid.grid[X, Y].Value;
            }

        }
    }
}
