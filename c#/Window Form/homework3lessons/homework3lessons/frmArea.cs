using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework3lessons
{
    public partial class frmArea : Form
    {
        public frmArea()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            double r;
            double a;
            r =Double.Parse(txtRadius.Text.ToString());
            a = 3.142 * r * r;
            txtArea.Text = a.ToString();
        }

        private void txtRadius_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                btnClick.Focus();
            }
        }
    }
}
