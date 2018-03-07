namespace Breakout
{
    partial class frmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRetry = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblLives = new System.Windows.Forms.Label();
            this.lblScoreCounter = new System.Windows.Forms.Label();
            this.lblLevelCounter = new System.Windows.Forms.Label();
            this.lblLivesCounter = new System.Windows.Forms.Label();
            this.lblTitleB = new System.Windows.Forms.Label();
            this.lblTitleT = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnHelp = new System.Windows.Forms.Button();
            this.gameBoard = new System.Windows.Forms.Panel();
            this.btnResume = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnStart.Location = new System.Drawing.Point(483, 294);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(222, 66);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.BackColor = System.Drawing.Color.Transparent;
            this.btnRetry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRetry.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRetry.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnRetry.ForeColor = System.Drawing.Color.White;
            this.btnRetry.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRetry.Location = new System.Drawing.Point(483, 222);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(222, 66);
            this.btnRetry.TabIndex = 1;
            this.btnRetry.Text = "Retry";
            this.btnRetry.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRetry.UseVisualStyleBackColor = false;
            this.btnRetry.Visible = false;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblScore.Location = new System.Drawing.Point(528, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(65, 24);
            this.lblScore.TabIndex = 2;
            this.lblScore.Text = "Score:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.BackColor = System.Drawing.Color.Black;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblLevel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLevel.Location = new System.Drawing.Point(3, 9);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(60, 24);
            this.lblLevel.TabIndex = 3;
            this.lblLevel.Text = "Level:";
            // 
            // lblLives
            // 
            this.lblLives.AutoSize = true;
            this.lblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblLives.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLives.Location = new System.Drawing.Point(1044, 9);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(58, 24);
            this.lblLives.TabIndex = 4;
            this.lblLives.Text = "Lives:";
            // 
            // lblScoreCounter
            // 
            this.lblScoreCounter.AutoSize = true;
            this.lblScoreCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblScoreCounter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblScoreCounter.Location = new System.Drawing.Point(648, 9);
            this.lblScoreCounter.Name = "lblScoreCounter";
            this.lblScoreCounter.Size = new System.Drawing.Size(20, 24);
            this.lblScoreCounter.TabIndex = 5;
            this.lblScoreCounter.Text = "0";
            // 
            // lblLevelCounter
            // 
            this.lblLevelCounter.AutoSize = true;
            this.lblLevelCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblLevelCounter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLevelCounter.Location = new System.Drawing.Point(123, 9);
            this.lblLevelCounter.Name = "lblLevelCounter";
            this.lblLevelCounter.Size = new System.Drawing.Size(20, 24);
            this.lblLevelCounter.TabIndex = 6;
            this.lblLevelCounter.Text = "0";
            // 
            // lblLivesCounter
            // 
            this.lblLivesCounter.AutoSize = true;
            this.lblLivesCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblLivesCounter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblLivesCounter.Location = new System.Drawing.Point(1164, 9);
            this.lblLivesCounter.Name = "lblLivesCounter";
            this.lblLivesCounter.Size = new System.Drawing.Size(20, 24);
            this.lblLivesCounter.TabIndex = 7;
            this.lblLivesCounter.Text = "0";
            // 
            // lblTitleB
            // 
            this.lblTitleB.AutoSize = true;
            this.lblTitleB.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleB.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.lblTitleB.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitleB.Location = new System.Drawing.Point(369, 138);
            this.lblTitleB.Name = "lblTitleB";
            this.lblTitleB.Size = new System.Drawing.Size(76, 73);
            this.lblTitleB.TabIndex = 8;
            this.lblTitleB.Text = "B";
            // 
            // lblTitleT
            // 
            this.lblTitleT.AutoSize = true;
            this.lblTitleT.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleT.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold);
            this.lblTitleT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitleT.Location = new System.Drawing.Point(720, 138);
            this.lblTitleT.Name = "lblTitleT";
            this.lblTitleT.Size = new System.Drawing.Size(72, 73);
            this.lblTitleT.TabIndex = 9;
            this.lblTitleT.Text = "T";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTitle.Location = new System.Drawing.Point(442, 149);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(227, 55);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "REAKOU";
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnHelp.ForeColor = System.Drawing.Color.White;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHelp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnHelp.Location = new System.Drawing.Point(483, 366);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(222, 66);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "Controls";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // gameBoard
            // 
            this.gameBoard.BackColor = System.Drawing.Color.Transparent;
            this.gameBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gameBoard.Location = new System.Drawing.Point(0, 0);
            this.gameBoard.Name = "gameBoard";
            this.gameBoard.Size = new System.Drawing.Size(1204, 626);
            this.gameBoard.TabIndex = 12;
            // 
            // btnResume
            // 
            this.btnResume.BackColor = System.Drawing.Color.Transparent;
            this.btnResume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResume.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnResume.ForeColor = System.Drawing.Color.White;
            this.btnResume.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnResume.Location = new System.Drawing.Point(484, 438);
            this.btnResume.Name = "btnResume";
            this.btnResume.Size = new System.Drawing.Size(222, 66);
            this.btnResume.TabIndex = 13;
            this.btnResume.Text = "Resume";
            this.btnResume.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnResume.UseVisualStyleBackColor = false;
            this.btnResume.Visible = false;
            this.btnResume.Click += new System.EventHandler(this.btnResume_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.Transparent;
            this.btnQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold);
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnQuit.Location = new System.Drawing.Point(484, 510);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(222, 66);
            this.btnQuit.TabIndex = 14;
            this.btnQuit.Text = "Quit";
            this.btnQuit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Visible = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // frmGame
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.CancelButton = this.btnHelp;
            this.ClientSize = new System.Drawing.Size(1204, 626);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.btnResume);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblTitleT);
            this.Controls.Add(this.lblTitleB);
            this.Controls.Add(this.lblLivesCounter);
            this.Controls.Add(this.lblLevelCounter);
            this.Controls.Add(this.lblScoreCounter);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gameBoard);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Breakout";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label lblScoreCounter;
        private System.Windows.Forms.Label lblLevelCounter;
        private System.Windows.Forms.Label lblLivesCounter;
        private System.Windows.Forms.Label lblTitleB;
        private System.Windows.Forms.Label lblTitleT;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel gameBoard;
        private System.Windows.Forms.Button btnResume;
        private System.Windows.Forms.Button btnQuit;
    }
}

