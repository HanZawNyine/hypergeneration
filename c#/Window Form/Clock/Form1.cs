using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();         
            WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            lblTime.Text = DateTime.Now.ToString("hh:mm:ss ");
           lblYear.Text = DateTime.Now.ToString("MM(MMMM) : dd(dddd): yyyy");
             lblSS.Text = DateTime.Now.ToString("tt");

        }

        private void lblYear_Click(object sender, EventArgs e)
        {

        }

        private void lblSS_Click(object sender, EventArgs e)
        {

        }
    }
}
