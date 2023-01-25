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
    public partial class Reaction : Form
    {
        public int nahodnycislo;
        public int nevim = 0;
        public Stopwatch stopky = new Stopwatch();

        public Reaction()
        {
            InitializeComponent();
        }

        

        private void Reaction_Load(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            if (label1.Text == "Klikni až budeš připraven")
            {
                this.BackColor = Color.Red;
                label1.Text = "Až bude zelená klikni!";
                System.Random rnd = new System.Random();
                nahodnycislo = rnd.Next(2, 6);
                timer1.Start();
                label2.Hide();
            }
            else if (label1.Text == "KLIKEJ!!!")
            {
                stopky.Stop();
                label1.Text = stopky.ElapsedMilliseconds.ToString() + "ms";
                label2.Hide();

            }

            
            

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            nevim++;
            if (nevim == nahodnycislo)
            {
                this.BackColor = Color.LimeGreen;
                label1.Text = "KLIKEJ!!!";
                stopky.Start();
                label2.Hide();
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
    }
}
