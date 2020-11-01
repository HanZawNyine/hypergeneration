using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int txtno = 0;
            try
            {
                string aa = textBox1.Text.ToString();
                int pointX = 30;
                int pointY = 40;
                panel2.Controls.Clear();
                if (textBox1.Text != "")
                {
                    txtno++;
                    for(int i=0;i<txtno;i++)
                    {
                        
                    }
                }
                else
                {
                    MessageBox.Show("Fill Label");
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
              
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
