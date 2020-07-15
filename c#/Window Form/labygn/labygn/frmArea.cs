using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labygn
{
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }

        private void btnclick_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello world!");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double r;
            double a;
            r =Double.Parse( txtradius.Text.ToString());
            
            a = 3.142 * r * r;
            txtarea.Text = a.ToString();
            

        }

        private void frmArea_Load(object sender, EventArgs e)
        {

        }

        private void lbformula_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("*3.142*%f*%f=%f",r,r,a);
        }
    }
}
