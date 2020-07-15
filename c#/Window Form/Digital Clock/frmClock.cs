using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Digital_Clock
{
    public partial class frmClock : Form
    {
        public frmClock()
        {
            InitializeComponent();
        }

        private void frmClock_Load(object sender, EventArgs e)
        {
            timer1.Start();
            WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTimeSEC.Text = DateTime.Now.ToString("dddd(dd) :  MMMM(MM) :  yyyy");
            Time.Text = DateTime.Now.ToString("hh : mm : ss : tt");
        }

        private void Time_Click(object sender, EventArgs e)
        {

        }

        private void lblTimeSEC_Click(object sender, EventArgs e)
        {

        }
    }
}
