using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PONG_hra
{
    public partial class PongMenu : Form
    {
        public PongMenu()
        {
            InitializeComponent();
        }

        private void LoadGame(object sender, EventArgs e)
        {
            PONG gameWindow = new PONG();

            gameWindow.Show();
        }

       

        private void LoadGame1(object sender, EventArgs e)
        {
            PONG_2 gameWindow = new PONG_2();

            gameWindow.Show();
        }
    }
}
