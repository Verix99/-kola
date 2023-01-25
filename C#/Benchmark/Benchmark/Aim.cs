using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Benchmark
{
    public partial class Aim : Form
    {
        public Stopwatch stopky = new Stopwatch();
        Random rand = new Random();
        public int i = 0;
        public Aim()
        {
            InitializeComponent();
        }

        private void Aim_Load(object sender, EventArgs e)
        {
            pictureBox1.Hide();
            label2.Hide();
            stopky.Stop();
            label3.Hide();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1.Hide();
            label1.Text = "Start";
            button1.Hide();
            pictureBox1.Show();
            label2.Show();
            label4.Hide();
            if (label1.Text == "Start")
            {
                stopky.Start();
            }
        }

        private void TimerEvent(object sender, EventArgs e)
        {

        }
        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            i++;
            label4.Hide();
            label2.Text = "Count:" + i;
            int x = rand.Next(10, this.ClientSize.Width - pictureBox1.Width);
            int y = rand.Next(10, this.ClientSize.Height - pictureBox1.Height);
            pictureBox1.Location = new Point(x, y);
            if (label2.Text == "Count:30")
            {
                stopky.Stop();
                label3.Show();
                
                long k;
                k = stopky.ElapsedMilliseconds;
                long ok = k / 30;
                string okg = ok.ToString();
                label3.Text = okg + "ms";
               
                

                pictureBox1.Hide();
            }
        }

        
    }
}
