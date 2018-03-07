using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout.Objects
{
    class Bar : Obstacle
    {
        private const int HEIGHT = 40;

        private const int WIDTH = 90;

        private const int MAXHITS = -1;

        private const int HITS = -1;

        private const int POINTVAL = 10;

        private Color FILL = Color.Black;

        private BorderStyle BORDER = BorderStyle.Fixed3D;

        public Bar()
        {
            this.Height = HEIGHT;

            this.Width = WIDTH;

            this.MaxHits = MAXHITS;

            this.Hits = HITS;

            this.PointValue = POINTVAL;

            this.BackColor = FILL;

            this.BorderStyle = BORDER;
        }
    }
}
