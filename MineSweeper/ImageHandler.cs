using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MineSweeper
{
    class ImageHandler

    {
        public System.Drawing.Image Bomb { get; set; }
        
        public ImageHandler()
        {
            Bomb = Image.FromFile(@"H:\CompScience\c# basics\MineSweeper\MineSweeper\MineSweeper\images\bomb.png");
        }
    }
}