using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clock001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            WindowState = FormWindowState.Maximized;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblAll.Text = DateTime.Now.ToString("hh : mm  : ss");
            // : dd : MM : yy
            lblDate.Text = DateTime.Now.ToString("(dd) dddd  :(MM) MMMM : yyyy");
            lblDtae.Text = DateTime.Now.ToString("dd : MM : yyyy ");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            Exit();
        }

        public void Exit()
        {
            DialogResult result = MessageBox.Show("Are you Sure To exit ?", "Warning !", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
           
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Refresh();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                Exit();
            }
        }
    }
}
