using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double first;
        string operation;
        private void button1_Click(object sender, EventArgs e)
        {
            if(txtResult.Text=="0")
            {
                txtResult.Text = "1";
            }
            else
            {
                txtResult.Text = txtResult.Text + "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "2";
            }
            else
            {
                txtResult.Text = txtResult.Text + "2";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "3";
            }
            else
            {
                txtResult.Text = txtResult.Text + "3";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "4";
            }
            else
            {
                txtResult.Text = txtResult.Text + "4";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "5";
            }
            else
            {
                txtResult.Text = txtResult.Text + "5";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "6";
            }
            else
            {
                txtResult.Text = txtResult.Text + "6";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "7";
            }
            else
            {
                txtResult.Text = txtResult.Text + "7";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "8";
            }
            else
            {
                txtResult.Text = txtResult.Text + "8";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "9";
            }
            else
            {
                txtResult.Text = txtResult.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {//30+50
            txtResult.Text = txtResult.Text + "0";            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "0")
            {
                txtResult.Text = "0.";
            }
            else
            {
                txtResult.Text = txtResult.Text + ".";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            //firstvalue + second value
             first = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "+";


        }

        private void button17_Click(object sender, EventArgs e)
        {
            double second = Convert.ToDouble(txtResult.Text);
            double result;
            if (operation=="+")
            {
                 result = first + second;
                txtResult.Text = Convert.ToString(result);
            }else if(operation=="-")
            {
                 result = first - second;
                txtResult.Text = Convert.ToString(result);
            }
            else if (operation == "x")
            {
                result = first * second;
                txtResult.Text = Convert.ToString(result);
            }
            else if (operation == "%")
            {
                result = first / second;
                txtResult.Text = Convert.ToString(result);
            }

          
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //firstvalue - second value
            first = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "-";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //firstvalue * second value
            first = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "x";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //firstvalue / second value
            first = Convert.ToDouble(txtResult.Text);
            txtResult.Text = "0";
            operation = "%";
        }
    }
}
