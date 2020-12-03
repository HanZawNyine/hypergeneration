using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Claculator101010
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if(txtResult.Text =="")
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
            if (txtResult.Text == "")
            {
                txtResult.Text = "2";
            }
            else
            {
                txtResult.Text = txtResult.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
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
            if (txtResult.Text == "")
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
            if (txtResult.Text == "")
            {
                txtResult.Text = "5";
            }
            else
            {
                txtResult.Text = txtResult.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                txtResult.Text = "6";
            }
            else
            {
                txtResult.Text = txtResult.Text + "6";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                txtResult.Text = "7";
            }
            else
            {
                txtResult.Text = txtResult.Text + "7";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                txtResult.Text = "8";
            }
            else
            {
                txtResult.Text = txtResult.Text + "8";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                txtResult.Text = "9";
            }
            else
            {
                txtResult.Text = txtResult.Text + "9";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
            else
            {
                txtResult.Text = txtResult.Text + "0";
            }
        }

        string Operators;
        Double FirstNumber;
        private void button16_Click(object sender, EventArgs e)
        {
            Operators = "+";
            FirstNumber =Convert.ToDouble(txtResult.Text);
            txtResult.Clear();
           // MessageBox.Show(FirstNumber);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Operators = "-";
            FirstNumber = Convert.ToDouble(txtResult.Text);
            txtResult.Clear();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Operators = "x";
            FirstNumber = Convert.ToDouble(txtResult.Text);
            txtResult.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Operators = "%";
            FirstNumber = Convert.ToDouble(txtResult.Text);
            txtResult.Clear();
        }

        //  A + B
        // first +  Second Number
        Double Result;
        private void button4_Click(object sender, EventArgs e)
        {
            Double SecondNumber = Convert.ToDouble(txtResult.Text);
            
            if(Operators == "+")
            {
                Result = FirstNumber + SecondNumber;
            }else if(Operators == "-")
            {
                Result = FirstNumber - SecondNumber;
            }
            else if (Operators == "x")
            {
                Result = FirstNumber * SecondNumber;
            }
            else if (Operators == "%")
            {
                Result = FirstNumber / SecondNumber;
            }
            else
            {
                MessageBox.Show("Error");
            }

            txtResult.Text= Result.ToString();
        }
    }
}
