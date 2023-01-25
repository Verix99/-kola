using System;
using System.Windows.Forms;

namespace Benchmark
{
    public partial class Number : Form
    {
        public int level = 1;
        public string cislo;
        public int minNumber;
        public int maxNumber;
        public string labeltext;

        public Number()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (level == 1)
            {

                minNumber = 1;
                maxNumber = 9;
                label2.Text = "Level 1";

            }

            else if (level == 2)
            {
                minNumber = 10;
                maxNumber = 99;
                label2.Text = "Level 2";
            }
            if (level == 3)
            {
                minNumber = 100;
                maxNumber = 999;
                label2.Text = "Level 3";
            }
            if (level == 4)
            {
                minNumber = 1000;
                maxNumber = 9999;
                label2.Text = "Level 4";
            }
            if (level == 5)
            {
                minNumber = 10000;
                maxNumber = 99999;
                label2.Text = "Level " + level;
            }
            if (level == 6)
            {
                minNumber = 100000;
                maxNumber = 999999;
                label2.Text = "Level " + level;
            }
            if (level == 7)
            {
                minNumber = 1000000;
                maxNumber = 9999999;
                label2.Text = "Level " + level;
            }
            if (level == 8)
            {
                minNumber = 10000000;
                maxNumber = 99999999;
                label2.Text = "Level " + level;
            }
            if (level == 9)
            {
                minNumber = 100000000;
                maxNumber = 999999999;
                label2.Text = "Level " + level;
            }
            if (level == 10)
            {
                minNumber = 1000000000;
                maxNumber = 2147000000;
                label2.Text = "Level " + level;
            }

            if (button1.Text == "Začít")
            {
                label1.Show();
                label2.Show();
                button1.Text = "Mám zapamatováno!";
                Random r = new Random();
                int randomNumber = r.Next(minNumber, maxNumber);
                label1.Text = randomNumber.ToString();

            }
            else if (button1.Text == "Mám zapamatováno!")
            {
                textBox1.Text = "Zadejte číslo";
                cislo = label1.Text;
                label1.Hide();
                textBox1.Visible = true;
                button1.Text = "Zkontrolovat";
                level++;
            }
            else if (button1.Text == "Zkontrolovat")
            {
                Random r = new Random();
                int randomNumber = r.Next(minNumber, maxNumber);
                label1.Text = randomNumber.ToString();
                //level++;
                label1.Show();
                textBox1.Visible = false;
                button1.Text = "Mám zapamatováno!";
                if (textBox1.Text != cislo)
                {
                    MessageBox.Show("Máš to špatně, skončil jsi na levelu: " + level);
                    this.Close();
                }

            }

        }



        private void Number_Load(object sender, EventArgs e)
        {
            label2.Text = "";
            label1.Text = "Klikni na tlačítko až budeš připraven začít!";
            label3.Text = "";
            button1.Text = "Začít";
            textBox1.Visible = false;
            this.MinimizeBox = false;
        }



        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar))
            {
                errorProvider1.SetError(label3, "Povoleny jsou jenom čísla!");
                label3.Text = "Povoleny jsou jenom čísla!";
            }
            else
            {
                errorProvider1.SetError(label3, "");
                label3.Text = "";
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
    }
}
