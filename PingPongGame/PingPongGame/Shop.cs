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
    public partial class Shop : Form
    {
        int point = 0;
        String ballColor;
        String racketColor;
        public Shop(int totalPoint, String racketColor, String ballColor)
        {
            this.ballColor = ballColor;
            this.racketColor = racketColor;
            InitializeComponent();
            point += totalPoint;
            totalscore.Text = "" + totalPoint;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Menu m = new Menu(point, ballColor,racketColor);
            Hide();
            m.ShowDialog();
            Close();
        }

        private void BallRed_Click(object sender, EventArgs e)
        {
            if(point > 50)
            {
                ballColor = "Red";
            } else
            {
                MessageBox.Show("You don't have enough points for this!", "Not enough points");
            }
        }

        private void BallGreen_Click(object sender, EventArgs e)
        {
            if (point > 75)
            {
                ballColor = "Green";
            }
            else
            {
                MessageBox.Show("You don't have enough points for this!", "Not enough points");
            }
        }

        private void BallCyan_Click(object sender, EventArgs e)
        {
            if (point > 100)
            {
                ballColor = "Cyan";
            }
            else
            {
                MessageBox.Show("You don't have enough points for this!", "Not enough points");
            }
        }

        private void RacketRed_Click(object sender, EventArgs e)
        {
            if (point > 125)
            {
                racketColor = "Red";
            }
            else
            {
                MessageBox.Show("You don't have enough points for this!", "Not enough points");
            }
        }

        private void RacketGreen_Click(object sender, EventArgs e)
        {
            if (point > 150)
            {
                racketColor = "Green";
            }
            else
            {
                MessageBox.Show("You don't have enough points for this!", "Not enough points");
            }
        }

        private void RacketCyan_Click(object sender, EventArgs e)
        {
            if (point > 200)
            {
                racketColor = "Cyan";
            }
            else
            {
                MessageBox.Show("You don't have enough points for this!", "Not enough points");
            }
        }
    }
}
