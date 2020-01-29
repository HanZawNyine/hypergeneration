using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helloworldtuto
{
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            double r;
            double a;

            r = double.Parse(txtRadius.Text.ToString());

            a = 3.142 * r * r;
           // a =Text.ToString());
            txtArea.Text = a.ToString();

          // MessageBox.Show(txtArea);
        }
    }
}
