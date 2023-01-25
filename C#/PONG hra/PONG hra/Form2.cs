using System;
using System.Windows.Forms;

namespace PONG_hra
{
    public partial class PONG_2 : Form
    {
        bool goup;
        bool godown;
        int bally = 5;
        int ballx = 5;
        int scoreRed = 0;
        int scoreBlue = 0;
        int speed = 5;
        int hraniceOkna;
        int xStred;
        int yStred;
        public PONG_2()

        {
            InitializeComponent();
            hraniceOkna = ClientSize.Height - playerBlue.Height;
            xStred = ClientSize.Width / 2;
            yStred = ClientSize.Height / 2;
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            
        }

        private void gameTicks(object sender, EventArgs e)
        {
            Random newBallSpot = new Random();
            int newSpot = newBallSpot.Next(100,ClientSize.Height-100);
            ball.Top -= bally;
            ball.Left -= ballx;
        }
    }
}
