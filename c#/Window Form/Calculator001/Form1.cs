using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text+"1";
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }
        string FirstValue; 
        string opera;
        private void button5_Click(object sender, EventArgs e)
        {
            FirstValue = textBox1.Text.ToString();
            opera = "+";
            textBox1.Clear();

        }

        private void button10_Click(object sender, EventArgs e)
        {
            FirstValue = textBox1.Text.ToString();
            opera = "-";
            textBox1.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            FirstValue = textBox1.Text.ToString();
            opera = "x";
            textBox1.Clear();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            FirstValue = textBox1.Text.ToString();
            opera = "%";
            textBox1.Clear();
        }
        float Result;
        private void button15_Click(object sender, EventArgs e)
        {
           
          string  SecondValue = textBox1.Text.ToString();
            textBox1.Clear();
            float F = Convert.ToInt64(FirstValue.ToString());
            float S = Convert.ToUInt64(SecondValue.ToString());
            try
            {
                if (opera == "+")
                {
                    Result = F + S;
                }
                else if (opera == "-")
                {
                    Result = F - S;
                }
                else if (opera == "x")
                {
                    Result = F * S;
                }
                else if (opera == "%")
                {
                    Result = F / S;
                }

               
                textBox1.Text = F.ToString();
                textBox1.AppendText(opera.ToString());
                textBox1.AppendText(S.ToString());
                textBox1.AppendText(" = ");
                textBox1.AppendText(Result.ToString());

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
              //  MessageBox.Show("Something Wrong \a\n !!!!!!!!!!!!!!!!!!!!!!!!!!");
            
            


        }

        private void button12_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
           
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0.";
            }
            else
            {
                textBox1.Text = textBox1.Text + ".";
            }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }
    }
}
