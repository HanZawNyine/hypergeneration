using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lgin
{
    public partial class AreaOfCircle : Form
    {
        public AreaOfCircle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int r = Convert.ToInt32( txtR.Text.ToString());
            double pi = 3.142;
            double a;

            a = pi * r * r;

            txtA.Text = a.ToString();

        }
    }
}
