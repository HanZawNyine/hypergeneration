using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_linux
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "1";
            }
            else
            {
                txtName.Text = txtName.Text + "1";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "2";
            }
            else
            {
                txtName.Text = txtName.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "3";
            }
            else
            {
                txtName.Text = txtName.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "4";
            }
            else
            {
                txtName.Text = txtName.Text + "4";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "5";
            }
            else
            {
                txtName.Text = txtName.Text + "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "6";
            }
            else
            {
                txtName.Text = txtName.Text + "6";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "7";
            }
            else
            {
                txtName.Text = txtName.Text + "7";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "8";
            }
            else
            {
                txtName.Text = txtName.Text + "8";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "9";
            }
            else
            {
                txtName.Text = txtName.Text + "9";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.Text = "0";
            }
            else
            {
                txtName.Text = txtName.Text + "0";
            }
        }
        double FirstValue;
        private void button11_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(txtName.Text);
            txtName.Clear();
            operators = "+";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(txtName.Text);
            txtName.Clear();
            operators = "-";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(txtName.Text);
            txtName.Clear();
            operators = "x";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(txtName.Text);
            txtName.Clear();
            operators = "/";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(txtName.Text);
            txtName.Clear();
            operators = "%";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            
            if(txtName.Text=="")
            {
                txtName.Text = "0.";
            }
            else
            {
                txtName.Text = txtName.Text + ".";
            }
        }
        string operators;
        double result;
        private void button17_Click(object sender, EventArgs e)
        {
            double SecondValue = Convert.ToDouble(txtName.Text);
            txtName.Clear();
          
            if(operators == "+")
            {
                result = FirstValue + SecondValue;
            }else if(operators == "-")
            {
                result = FirstValue - SecondValue;
            }
            else if (operators == "x")
            {
                result = FirstValue * SecondValue;
            }
            else if (operators == "/")
            {
                result = FirstValue / SecondValue;
            }
            else if (operators == "%")
            {
                result = FirstValue % SecondValue;
            }

            txtName.Text = result.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            txtName.Clear();
        }
    }
}
