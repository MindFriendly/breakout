using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Breakout.Helpers;

namespace Breakout.Objects
{
    class Ball : PictureBox
    {
        #region CONSTANTS

        private const int HEIGHT = 20;

        private const int WIDTH = 20;

        private Color COLOR = Color.White;

        #endregion

        #region PRIVATE PROPERTIES

        private Panel gameBoard { get; set; }

        private SoundPlayer beep { get; set; }

        private SoundPlayer plop { get; set; }

        public int vSpeed { get; set; }

        public int hSpeed { get; set; }

        private bool alive { get; set; }

        #endregion

        /// <summary>
        /// Initialize the game ball and provides a reference to the game screen
        /// </summary>
        /// <param name="game">The game object to draw the ball on.</param>
        public Ball(Panel _gameBoard)
        {
            // Initialize the game ball
            this.gameBoard = _gameBoard;

            this.BackColor = COLOR;

            this.Height = HEIGHT;

            this.Width = WIDTH;

            this.Top = 200;

            this.Left = _gameBoard.Left - (_gameBoard.Left / 2);

            this.vSpeed = 4;

            this.hSpeed = 4;
        }

        /// <summary>
        /// Draws the ball on the screen
        /// </summary>
        public void Draw()
        {
            gameBoard.Controls.Add(this);
        }

        /// <summary>
        /// When the ball collides with the paddle, increase speed and change direction.
        /// </summary>
        public void HitPaddle()
        {
            plop = new SoundPlayer("Z:\\acsv13-imagine\\Steve Mulholland - Breakout\\Breakout\\Breakout\\Assets\\plop.wav");

            plop.Play();

            this.hSpeed += 1;

            this.vSpeed += +1;

            this.vSpeed = -this.vSpeed;
        }

        public void HitWall(Sides side)
        {
            beep = new System.Media.SoundPlayer("Z:\\acsv13-imagine\\Steve Mulholland - Breakout\\Breakout\\Breakout\\Assets\\beep.wav");

            beep.Play();

            switch (side)
            {
                case Sides.TopOrBottom:
                    this.vSpeed = -this.vSpeed;
                    break;
                case Sides.RightOrLeft:
                    this.hSpeed = -this.hSpeed;
                    break;
                default:
                    break;
            }            
        }

        public void Reset()
        {
            this.Top = gameBoard.Bottom - 100;
        }
    }
}
