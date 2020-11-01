using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HanZawNyine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int txtno = int.Parse(textBox1.Text);
                int pointX = 30;
                int pointY = 40;
                panel2.Controls.Clear();
                for (int i = 0; i < txtno; i++)
                {
                    //new text box
                    TextBox a = new TextBox();
                    a.Text = (i + 1).ToString();
                    a.Location = new Point(pointX, pointY);
                    this.Controls.Add(a);
                    this.Show();
                    pointY += 20;
                }
            }
            catch (Exception)
            {
                MessageBox.Show(e.ToString());
            }
            //new label
            //TextBox textBox1 = new TextBox();
            //Label label1 = new Label();
            //label1.Text = "Text";
            //label1.Location = new Point(48, 48);
            //label1.Size = new Size(104, 16);
        }
    }
}
