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
    public partial class Menu : Form
    {
        int totalPoint = 0;
        String ballColor;
        String racketColor;
        public Menu(int point, String ballColor, String racketColor)
        {
            this.ballColor = ballColor;
            this.racketColor = racketColor;
            InitializeComponent();
            totalPoint += point;
            totalscore.Text = "" + totalPoint;
        }

        private void Easy_Click(object sender, EventArgs e)
        {
            Game g = new Game(5,"Easy",totalPoint,ballColor,racketColor);
            Hide();
            g.ShowDialog();
            Close();

        }

        private void Medium_Click(object sender, EventArgs e)
        {
            Game g = new Game(8,"Medium", totalPoint, ballColor, racketColor);
            Hide();
            g.ShowDialog();
            Close();
        }

        private void Hard_Click(object sender, EventArgs e)
        {
            Game g = new Game(12,"Hard", totalPoint, ballColor, racketColor);
            Hide();
            g.ShowDialog();
            Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Shop s = new Shop(totalPoint, ballColor, racketColor);
            Hide();
            s.ShowDialog();
            Close();
        }
    }
}
