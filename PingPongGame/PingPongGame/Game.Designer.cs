﻿namespace PingPongGame
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            this.Racket = new System.Windows.Forms.PictureBox();
            this.Ball = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.PlayerScore = new System.Windows.Forms.Label();
            this.gameMode = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // Racket
            // 
            this.Racket.BackColor = System.Drawing.Color.Black;
            this.Racket.Location = new System.Drawing.Point(283, 498);
            this.Racket.Name = "Racket";
            this.Racket.Size = new System.Drawing.Size(364, 22);
            this.Racket.TabIndex = 0;
            this.Racket.TabStop = false;
            // 
            // Ball
            // 
            this.Ball.BackColor = System.Drawing.Color.Black;
            this.Ball.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Ball.Location = new System.Drawing.Point(430, 327);
            this.Ball.Name = "Ball";
            this.Ball.Size = new System.Drawing.Size(55, 55);
            this.Ball.TabIndex = 1;
            this.Ball.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // PlayerScore
            // 
            this.PlayerScore.AutoSize = true;
            this.PlayerScore.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.PlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PlayerScore.ForeColor = System.Drawing.Color.Red;
            this.PlayerScore.Location = new System.Drawing.Point(34, 539);
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.Size = new System.Drawing.Size(36, 26);
            this.PlayerScore.TabIndex = 2;
            this.PlayerScore.Text = "00";
            // 
            // gameMode
            // 
            this.gameMode.AutoSize = true;
            this.gameMode.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.gameMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameMode.ForeColor = System.Drawing.Color.Black;
            this.gameMode.Location = new System.Drawing.Point(819, 539);
            this.gameMode.Name = "gameMode";
            this.gameMode.Size = new System.Drawing.Size(61, 26);
            this.gameMode.TabIndex = 4;
            this.gameMode.Text = "Easy";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.gameMode);
            this.Controls.Add(this.PlayerScore);
            this.Controls.Add(this.Ball);
            this.Controls.Add(this.Racket);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Game";
            this.Text = "Ping Pong";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Racket;
        private System.Windows.Forms.PictureBox Ball;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label PlayerScore;
        private System.Windows.Forms.Label gameMode;
    }
}

