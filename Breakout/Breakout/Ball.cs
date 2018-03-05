using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout
{
    class Ball
    {
        private const int LENGTH = 10;
        private const int WIDTH = 10;
        private const int STARTX = 10;
        private const int STARTY = 10;
        private const int INTERVAL = 1000;
        private System.Drawing.Color COLOR = Color.White;

        private System.Drawing.SolidBrush brush { get; set; }

        private System.Drawing.Graphics formGraphics { get; set; }
        private Rectangle self { get; set; }

        private bool live { get; set; }

        public Ball(Breakout.frmMain game)
        {
            brush = new System.Drawing.SolidBrush(COLOR);
            formGraphics = game.CreateGraphics();
            self = new Rectangle(STARTX, STARTY, LENGTH, WIDTH);
            live = true;
        }

        public void Draw()
        {            
            formGraphics.FillRectangle(brush, self);
            brush.Dispose();
            //formGraphics.Dispose();
        }

        internal void Move()
        {
            int currentX = self.X;
            int currentY = self.Y;

            do
            {
                currentX += 10;
                System.Threading.Thread.Sleep(INTERVAL);
                Point newX = new Point(currentX);
                self.X = 10;
                self.Y = self.Y + 10;

            } while (live);
            
        }
    }
}
