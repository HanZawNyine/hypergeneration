using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System;
using System.Diagnostics;
using System.Threading;

namespace floor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
           
        }
       // static Task messagePrinterTask;
        public void Lop()
        {
            listBox1.Items.Clear();
            int a = 0;
            do
            {
               
                switch (a)
                {
                    case 0: button1.Focus(); listBox1.Items.Add("I am " + a.ToString()); Cursor.Current = Cursors.WaitCursor; break;
                    case 1: button2.Focus(); listBox1.Items.Add("I am " + a.ToString());  break;
                    case 2: button3.Focus(); listBox1.Items.Add("I am " + a.ToString());  break;
                    case 3: button4.Focus(); listBox1.Items.Add("I am " + a.ToString());  break;
                    case 4: button5.Focus(); listBox1.Items.Add("I am " + a.ToString());  break;
                    case 5: button10.Focus(); listBox1.Items.Add("I am " + a.ToString());  break;
                    case 6: button9.Focus(); listBox1.Items.Add("I am " + a.ToString());  break;
                    case 7: button8.Focus(); listBox1.Items.Add("I am " + a.ToString());  break;
                    case 8: button7.Focus(); listBox1.Items.Add("I am " + a.ToString()); break;
                    case 9: button6.Focus(); listBox1.Items.Add("I am " + a.ToString());  break;
                    case 10: button15.Focus(); listBox1.Items.Add("I am " + a.ToString());  break;
                    case 11: button14.Focus(); listBox1.Items.Add("I am " + a.ToString());  break;
                    case 12: button13.Focus(); listBox1.Items.Add("I am " + a.ToString());  break;
                    case 13: button12.Focus(); listBox1.Items.Add("I am " + a.ToString());  break;
                    case 14: button11.Focus(); listBox1.Items.Add("I am " + a.ToString());  break;
                   //Thread.Sleep(1000);
                }
                
                a = a + 1;
            }
            while (a < 20);
            MessageBox.Show("End Process !");
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button21_Click(object sender, EventArgs e)
        {
         
            this.Enabled = false;//optional, better target a panel or specific controls
            this.UseWaitCursor = true;//from the Form/Window instance
            Application.DoEvents();
        }
    }
}
