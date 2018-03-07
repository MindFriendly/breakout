using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout.Objects
{
    class Obstacle : PictureBox
    {
        public int MaxHits { get; set; }

        public int Hits { get; set; }

        public int PointValue { get; set; }

        private Color Color { get; set; }
    }
}
