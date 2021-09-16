using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    // this class doesnt inherit properties from the button class so its better for storing the grid in the back end
    class GridBlock
    {
        public int Value { get; set; }

        public GridBlock()
        {
            // initialised grid block   class
            this.Value = -1;
        }
    }
}
