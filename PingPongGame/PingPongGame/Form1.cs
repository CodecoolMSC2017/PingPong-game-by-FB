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
    public partial class Form1 : Form
    {

        bool goLeft;
        bool goRight;
        int speed = 5;
        int ballx = 5;
        int bally = 5;
        int score = 0;


        public Form1()
        {
            InitializeComponent();
        }

        public Timer t;

        private void t_Tick(object sender, EventArgs e)
        {

            if (Ball.Location.Y > 0 && Ball.Location.Y < 489){
                Ball.Location = new Point(
                Ball.Location.X + 10,
                Ball.Location.Y + 10);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
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
            PlayerScore.Text = "" + score;
            Ball.Top -= bally;
            Ball.Left -= ballx;

            Console.WriteLine("Client:" + ClientSize.Width);
            Console.WriteLine("Ball:" +(Ball.Right + Ball.Width));


            if (Ball.Top < 0)
            {

                bally = -bally;
                score++;
                
            }
            if(Ball.Top - Ball.Height > ClientSize.Height)
            {
                Ball.Top = ClientSize.Height/2;
                Ball.Left = ClientSize.Width/2;
                bally = -bally;
                // MessageBox.Show("You lost!");
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
