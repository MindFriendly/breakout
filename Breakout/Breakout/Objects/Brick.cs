using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout.Objects
{
    class Brick : PictureBox
    {
        private const int HEIGHT = 40;
        private const int WIDTH = 90;

        public int hits { get; set; }
        public int maxHits { get; set; }
    }
}
