using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void button1_Click(object sender, EventArgs e)
        {
            //v=lbh
            double l = Convert.ToDouble( txtL.Text.ToString());
            double b = Convert.ToDouble(txtB.Text.ToString());
            double h = Convert.ToDouble(txtH.Text.ToString());
            double v;
            v = l * b * h;
            txtV.Text = v.ToString();
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtL_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                txtB.Focus();
            }
        }

        private void txtH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnClick.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtH.Focus();
            }
        }
    }
}
