using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Breakout.Objects
{
    class Paddle : PictureBox
    {
        private const int HEIGHT = 50;
        private const int WIDTH = 300;
        private Color COLOR = Color.White;

        private Panel gameBoard;

        /// <summary>
        /// Initialize the paddle's properties.
        /// </summary>
        /// <param name="_gameBoard">The game object to draw the paddle on.</param>
        public Paddle(Panel _gameBoard)
        {
            this.gameBoard = _gameBoard;

            this.BackColor = COLOR;
            this.Height = HEIGHT;
            this.Width = WIDTH;
            this.Top = gameBoard.Bottom - (gameBoard.Bottom / 10);
        }

        /// <summary>
        /// Draw the paddle on the board.
        /// </summary>
        public void Draw()
        {
            gameBoard.Controls.Add(this);
        }
    }
}
