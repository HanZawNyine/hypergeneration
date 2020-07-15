using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double FirstValue;
        string Operator;
        private void button1_Click(object sender, EventArgs e)
        {
            FirstValue =Convert.ToDouble (txtValue.Text.ToString());
            Operator = "+";
            txtValue.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(txtValue.Text.ToString());
            Operator = "-";
            txtValue.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(txtValue.Text.ToString());
            Operator = "x";
            txtValue.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(txtValue.Text.ToString());
            Operator = "%";
            txtValue.Clear();
        }
        double result;
        private void button2_Click(object sender, EventArgs e)
        {
            double SecondValue = Convert.ToDouble(txtValue.Text.ToString());
            
            if(Operator == "+")
            {
                result = FirstValue + SecondValue;
            }else if(Operator == "-")
            {
                result = FirstValue - SecondValue;
            }
            else if (Operator == "x")
            {
                result = FirstValue * SecondValue;
            }
            else if (Operator == "%")
            {
                result = FirstValue / SecondValue;
            }
            else
            {
                MessageBox.Show("Eroor !");
            }

            txtValue.Text = result.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(txtValue.Text =="")
            {
                txtValue.Text = "1";
            }
            else
            {
                txtValue.Text = txtValue.Text + "1";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "")
            {
                txtValue.Text = "2";
            }
            else
            {
                txtValue.Text = txtValue.Text + "2";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "")
            {
                txtValue.Text = "3";
            }
            else
            {
                txtValue.Text = txtValue.Text + "3";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "")
            {
                txtValue.Text = "4";
            }
            else
            {
                txtValue.Text = txtValue.Text + "4";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "")
            {
                txtValue.Text = "5";
            }
            else
            {
                txtValue.Text = txtValue.Text + "5";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "")
            {
                txtValue.Text = "6";
            }
            else
            {
                txtValue.Text = txtValue.Text + "6";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "")
            {
                txtValue.Text = "7";
            }
            else
            {
                txtValue.Text = txtValue.Text + "7";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "")
            {
                txtValue.Text = "8";
            }
            else
            {
                txtValue.Text = txtValue.Text + "8";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "")
            {
                txtValue.Text = "9";
            }
            else
            {
                txtValue.Text = txtValue.Text + "9";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "")
            {
                txtValue.Text = "0";
            }
            else
            {
                txtValue.Text = txtValue.Text + ".";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtValue.Text == "")
            {
                txtValue.Text = "0.";
            }
            else
            {
                txtValue.Text = txtValue.Text + ".";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtValue.Clear();
        }
    }
}
