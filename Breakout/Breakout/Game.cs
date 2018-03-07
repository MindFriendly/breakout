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
using Breakout.Objects;

namespace Breakout
{
    public partial class frmGame : Form
    {

        #region PROPERTIES

        public int score { get; set; }

        public int lives { get; set; }

        public int level { get; set; }        

        private SoundPlayer bgm { get; set; }

        private Ticker ticker { get; set; }

        private Ball ball { get; set; }

        private Paddle paddle { get; set; }

        #endregion        

        #region FORM INITALIZER

        public frmGame()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Start the background music.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmGame_Load(object sender, EventArgs e)
        {
            bgm = new System.Media.SoundPlayer("C:\\Users\\steve\\School\\CSV13\\breakout\\Breakout\\Breakout\\Assets\\Mars.wav");

            bgm.PlayLooping();
        }

        /// <summary>
        /// Override the default event for pressing the esccape key.
        /// This allows the escape key to be used to pause the game.
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                pauseGame();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }        

        #endregion

        #region FORM CONTROL EVENTS

        /// <summary>
        /// Hide the start screen UI components and start the game.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStart_Click(object sender, EventArgs e)
        {
            hideMenuUI();

            Cursor.Hide();

            initGame();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            unPauseGame();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// The main run of the program. Every tick the ball will move and check for collisions.
        /// The paddle will track the movement of the cursor.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ticker_Tick(object sender, EventArgs e)
        {
            paddle.Left = Cursor.Position.X - (paddle.Width / 2);

            ball.Left += ball.hSpeed;

            ball.Top += ball.vSpeed;

            if (ball.Bottom >= paddle.Top && ball.Bottom <= paddle.Bottom && ball.Left >= paddle.Left && ball.Right <= paddle.Right)
            {
                ball.HitPaddle();

                updateScore(5);
            }

            if (ball.Left <= gameBoard.Left || ball.Right >= gameBoard.Right)
            {
                ball.hSpeed = -ball.hSpeed;
            }

            if (ball.Top <= gameBoard.Top || ball.Bottom >= gameBoard.Bottom)
            {
                ball.vSpeed = -ball.vSpeed;
            }

            if (ball.Bottom >= gameBoard.Bottom)
            {
                ticker.Enabled = false;
            }
        }

        #endregion

        #region CLASS INITIALIZERS        

        /// <summary>
        /// Set the scoreboard and draw the game elements.
        /// </summary>
        private void initGame()
        {           
            bgm.Stop();

            bgm = new System.Media.SoundPlayer("C:\\Users\\steve\\School\\CSV13\\breakout\\Breakout\\Breakout\\Assets\\Map.wav");

            bgm.PlayLooping();

            initScores();

            initBricks();

            initPaddle();

            initBall();

            initTicker();
        }

        /// <summary>
        /// Load all the bricks on the board. There will be 5 rows of 12 bricks per level.
        /// </summary>
        private void initBricks()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        private void initPaddle()
        {
            paddle = new Paddle(gameBoard);

            paddle.Draw();
        }

        /// <summary>
        /// Invoke the ball class to draw it on the game screen and begin its movement.
        /// </summary>
        private void initBall()
        {
            ball = new Ball(gameBoard);

            ball.Draw();
        }

        /// <summary>
        /// Starts the game.
        /// </summary>
        private void initTicker()
        {
            ticker = new Ticker();

            ticker.Tick += new EventHandler(ticker_Tick);

            ticker.Start();
        }

        /// <summary>
        /// Setup the initial score board values with score of 0, level 1 and 5 lives.
        /// </summary>
        private void initScores()
        {
            score = 0;

            level = 1;

            lives = 5;

            lblScoreCounter.Text = score.ToString();

            lblLevelCounter.Text = level.ToString();

            lblLivesCounter.Text = lives.ToString();
        }

        #endregion

        #region HELPER METHODS

        /// <summary>
        /// Hide everything on the loading screen except the score board.
        /// </summary>
        private void hideMenuUI()
        {
            btnStart.Visible = false;

            btnHelp.Visible = false;

            lblTitle.Visible = false;

            lblTitleB.Visible = false;

            lblTitleT.Visible = false;
        }

        private void pauseGame()
        {
            ticker.Stop();

            hideGameElements();

            showPauseUI();

            Cursor.Show();
        }

        private void hideGameElements()
        {
            ball.Visible = false;

            paddle.Visible = false;
        }

        private void showPauseUI()
        {
            btnResume.Visible = true;

            btnResume.Left = btnStart.Left;

            btnResume.Top = btnStart.Top;

            btnQuit.Visible = true;

            btnQuit.Left = btnHelp.Left;

            btnQuit.Top = btnHelp.Top;
        }

        private void unPauseGame()
        {
            showGameElements();

            hidePauseUI();

            Cursor.Hide();

            ticker.Start();
        }

        private void hidePauseUI()
        {
            btnResume.Visible = false;

            btnQuit.Visible = false;
        }

        private void showGameElements()
        {
            ball.Visible = true;

            paddle.Visible = true;

        }

        private void updateScore(int points)
        {
            score += points;
            lblScoreCounter.Text = score.ToString();
        }

        #endregion
    }
}
