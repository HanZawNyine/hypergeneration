using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double FirstValue;
        string operation;


        private void button1_Click(object sender, EventArgs e)
        {
            if (txtC.Text.ToString() == "")
            {
                txtC.Text = "1";
            }
            else
            {
                txtC.Text = txtC.Text + "1";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (txtC.Text.ToString() == "")
            {
                txtC.Text = "2";
            }
            else
            {
                txtC.Text = txtC.Text + "2";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (txtC.Text.ToString() == "")
            {
                txtC.Text = "3";
            }
            else
            {
                txtC.Text = txtC.Text + "3";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (txtC.Text.ToString() == "")
            {
                txtC.Text = "4";
            }
            else
            {
                txtC.Text = txtC.Text + "4";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtC.Text.ToString() == "")
            {
                txtC.Text = "5";
            }
            else
            {
                txtC.Text = txtC.Text + "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (txtC.Text.ToString() == "")
            {
                txtC.Text = "6";
            }
            else
            {
                txtC.Text = txtC.Text + "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (txtC.Text.ToString() == "")
            {
                txtC.Text = "7";
            }
            else
            {
                txtC.Text = txtC.Text + "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (txtC.Text.ToString() == "")
            {
                txtC.Text = "8";
            }
            else
            {
                txtC.Text = txtC.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (txtC.Text.ToString() == "")
            {
                txtC.Text = "9";
            }
            else
            {
                txtC.Text = txtC.Text + "9";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
                txtC.Text = txtC.Text + "0";
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(txtC.Text);
            txtC.Text = " ";
            operation = "+";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double SecondValue;
            SecondValue = Convert.ToDouble(txtC.Text);
            double result;
            if(operation=="+")
            {
                result = FirstValue + SecondValue;
                txtC.Text = Convert.ToString(result);
            }else if(operation=="-")
            {
                result = FirstValue - SecondValue;
                txtC.Text = Convert.ToString(result);
            }
            else if (operation == "x")
            {
                result = FirstValue * SecondValue;
                txtC.Text = Convert.ToString(result);
            }
            else if (operation == "%")
            {
                result = FirstValue / SecondValue;
                txtC.Text = Convert.ToString(result);
            }



        }

        private void button11_Click(object sender, EventArgs e)
        {

            FirstValue = Convert.ToDouble(txtC.Text);
            txtC.Text = " ";
            operation = "-";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(txtC.Text);
            txtC.Text = " ";
            operation = "x";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FirstValue = Convert.ToDouble(txtC.Text);
            txtC.Text = " ";
            operation = "%";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            txtC.Clear();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
