using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_0002
{
    public partial class frmHello : Form
    {
        public frmHello()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            //a=pi*r*r pi = 3.142

            double r =Convert.ToInt32( txtR.Text.ToString());
            double a;
            a = 3.142 * r * r;

            txtA.Text = a.ToString();
           
        }
    }
}
