using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }

        private void btnsolution_Click(object sender, EventArgs e)
        {
            double r;
            double a;
            r = double.Parse( txtradius.Text.ToString());
            a = 3.1415 * r * r;
            txtarea.Text = a.ToString();
        }

        private void txtradius_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

        private void btnsolution_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnsolution.Focus();
            }
        }
    }
}
