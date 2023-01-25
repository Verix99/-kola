﻿using System;
using System.Windows.Forms;

namespace kalkulačka_úkol
{
    public partial class kalkulačka : Form
    {
        private Button btn;
        bool operandPerformed = false;
        string operand = "";
        double result = 0;

        public kalkulačka()
        {
            InitializeComponent();
        }



        private void NumEvent(object sender, EventArgs e)
        {
            if (txtResult.Text == "0" || operandPerformed)
            {
                txtResult.Clear();
            }
            Button btn = (Button)sender;
            txtResult.Text += btn.Text;
            operandPerformed = false;
        }

        private void OperandEvent(object sender, EventArgs e)
        {
            operandPerformed = true;
            Button btn = (Button)sender;
            string newOperand = btn.Text;

            lbResult.Text = lbResult.Text + " " + txtResult.Text + " " + newOperand;

            switch (operand)
            {
                case "+": txtResult.Text = (result + double.Parse(txtResult.Text)).ToString(); break;
                case "-": txtResult.Text = (result - double.Parse(txtResult.Text)).ToString(); break;
                case "*": txtResult.Text = (result * double.Parse(txtResult.Text)).ToString(); break;
                case "/": txtResult.Text = (result / double.Parse(txtResult.Text)).ToString(); break;
                default: break;
            }
            result = Double.Parse(txtResult.Text);
            operand = newOperand;
        }

        private void bCE_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        private void bC_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            lbResult.Text = "";
            result = 0;
            operand = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            lbResult.Text = "";
            operandPerformed = true;

            switch (operand)
            {
                case "+": txtResult.Text = (result + double.Parse(txtResult.Text)).ToString(); break;
                case "-": txtResult.Text = (result - double.Parse(txtResult.Text)).ToString(); break;
                case "*": txtResult.Text = (result * double.Parse(txtResult.Text)).ToString(); break;
                case "/": txtResult.Text = (result / double.Parse(txtResult.Text)).ToString(); break;
                default: break;
            }
            result = Double.Parse(txtResult.Text);
            txtResult.Text = result.ToString();
            result = 0;
            operand = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!operandPerformed && !txtResult.Text.Contains(",")) 
            {
                txtResult.Text += ",";
            }

           else if (operandPerformed)
            {
                txtResult.Text = "0";
            }

            if (!txtResult.Text.Contains(","))
            {
                txtResult.Text += ",";
            }
            operandPerformed = false;
        }
    }
}

