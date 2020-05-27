using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Area
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            float l = 0;
            float b = 0;
            float h = 0;
           
            double v;

            l = float.Parse(txtL.Text.ToString());
            b = float.Parse(txtB.Text.ToString());
            h = float.Parse(txtH.Text.ToString());
            v =l * b*h;
            txtV.Text = v.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
