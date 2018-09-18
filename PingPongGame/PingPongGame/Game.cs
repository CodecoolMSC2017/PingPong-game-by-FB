using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPongGame
{
    public partial class Game : Form
    {
        bool stopped = false;
        bool goLeft;
        bool goRight;
        int speed;
        int ballx = 5;
        int bally = 5;
        int score = 0;
        int totalScore = 0;
        String ballColor;
        String racketColor;


        public Game(int speed, String mode, int totalScore, String ballColor, String racketColor)
        {
            this.speed = speed;
            InitializeComponent();
            this.gameMode.Text = mode;
            gameTimer.Interval -= speed;
            ballx = speed;
            bally = speed;
            this.totalScore = totalScore;
            this.racketColor = racketColor;
            SetBackColor(Racket, racketColor);
            this.ballColor = ballColor;
            SetBackColor(Ball, ballColor);
        }

        private void SetBackColor(PictureBox picBox, String color)
        {
            switch(color)
            {
                case "Black":
                    picBox.BackColor = Color.Black;
                    break;
                case "Red" :
                    picBox.BackColor = Color.Red;
                    break;
                case "Green":
                    picBox.BackColor = Color.Green;
                    break;
                case "Cyan":
                    picBox.BackColor = Color.Cyan;
                    break;

            }
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                Application.Exit();
            }

            if(e.KeyCode == Keys.Space)
            {
                stopped = !stopped;
            }

            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine(gameTimer.Interval);
            if (stopped)
            {
                return;
            }
            PlayerScore.Text = "" + score;
            Ball.Top -= bally;
            Ball.Left -= ballx;


            if (Ball.Top < 0)
            {

                bally = -bally;
                
                
            }
            if(Ball.Top - Ball.Height > ClientSize.Height)
            {
                Menu m = new Menu(score + totalScore,ballColor,racketColor);
                Hide();
                gameTimer.Enabled = false;

                m.ShowDialog();
                Close();
            }

            if (Ball.Left + Ball.Width-50  < 0)
            {
                ballx = -ballx;
            }
            if(Ball.Left + Ball.Width > ClientSize.Width)
            {
                ballx = -ballx;
            }
            if (Ball.Bounds.IntersectsWith(Racket.Bounds))
            {
                bally = -bally;
                score++;
                if(score % 10 == 0)
                {
                    if(bally > 0)
                    {
                        bally += 1;
                    }
                    else
                    {
                        bally -= 1;
                    }

                    if (ballx > 0)
                    {
                        ballx += 1;
                    }
                    else
                    {
                        ballx -= 1;
                    }
                }
            }

            if(goLeft == true && Racket.Left > 0)
            {
                Racket.Left -= 8;
            }
            if (goRight == true && Racket.Left + Racket.Width < 925)
            {
                Racket.Left += 8;
            }


        }
    }
}
