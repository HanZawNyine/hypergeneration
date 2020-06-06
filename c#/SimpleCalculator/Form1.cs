using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double FirstNumber;
        string Operation;
        private void button1_Click(object sender, EventArgs e)
        {
            FirstNumber = Convert.ToDouble(txtInput.Text);
            txtInput.Text = "0";
            Operation = "+";

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "0")
            {
                txtInput.Text = "1";
            }
            else
            {
                txtInput.Text = txtInput.Text + "1";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "0")
            {
                txtInput.Text = "2";
            }
            else
            {
                txtInput.Text = txtInput.Text + "2";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "0")
            {
                txtInput.Text = "3";
            }
            else
            {
                txtInput.Text = txtInput.Text + "3";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "0")
            {
                txtInput.Text = "4";
            }
            else
            {
                txtInput.Text = txtInput.Text + "4";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "0")
            {
                txtInput.Text = "5";
            }
            else
            {
                txtInput.Text = txtInput.Text + "5";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "0")
            {
                txtInput.Text = "6";
            }
            else
            {
                txtInput.Text = txtInput.Text + "6";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "0")
            {
                txtInput.Text = "7";
            }
            else
            {
                txtInput.Text = txtInput.Text + "7";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "0")
            {
                txtInput.Text = "8";
            }
            else
            {
                txtInput.Text = txtInput.Text + "8";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtInput.Text == "0")
            {
                txtInput.Text = "9";
            }
            else
            {
                txtInput.Text = txtInput.Text + "9";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
                txtInput.Text = "0";
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(txtInput.Text);
            Result = (FirstNumber + SecondNumber);
            txtInput.Text = Convert.ToString(Result);
            FirstNumber = Result;

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void Output_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
