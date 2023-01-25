using System;
using System.Windows.Forms;

namespace PONG_hra
{
    public partial class PONG : Form
    {
        bool goup; // boolean to be used to detect player up position
        bool godown; // boolean to be used to detect player down position
        int speed = 5; // integer called speed holding value of 5
        int ballx = 5 ; // horizontal X speed value for the ball object 
        int bally = 5; // vertical Y speed value for the ball object
        int score = 0; // score for the player
        int cpuPoint = 0; // score for the CPU
        public PONG()
        {
            InitializeComponent();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
        }

        private void gamerTick(object sender, EventArgs e)
        {
            playerScore.Text = "" + score;
            cpuLabel.Text = "" + cpuPoint;

            ball.Top -= bally;
            ball.Left -= ballx;

            cpu.Top += speed;
            if (score < 5)
            {
                if (cpu.Top < 0 || cpu.Top > 455)
                {
                    speed = -speed;
                }
            }
            else
            {
                //cpu.Top = ball.Top + 30;
                cpu.Top = ball.Top - ball.Width;
            }
            if (ball.Left < 0)
            {
                ball.Left = 434;
                ballx = -ballx;
                ballx -= 2;
                cpuPoint++;
            }
            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = 434;
                ballx = -ballx;
                ballx += 2;
                score++;
            }
            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                bally = -bally;
            }
            if (ball.Bounds.IntersectsWith(player.Bounds) || ball.Bounds.IntersectsWith(cpu.Bounds))
            {
                ballx = -ballx;
            }
            if (goup == true && player.Top > 0)
            {
                
                player.Top -= 8;
            }
            if (godown == true && player.Top < 455)
            {
             
                player.Top += 8;

            }
            if (score > 10)
            {
                gameTimer.Stop();
                MessageBox.Show("Vyhrál jsi tuto hru");

            }
            if (cpuPoint> 10)
            {
                gameTimer.Stop();
                MessageBox.Show("Počítač nad tebou vyhrál");
            }
        }

        private void PONG_Load(object sender, EventArgs e)
        {

        }
    }
}
