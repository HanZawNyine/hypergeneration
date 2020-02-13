using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOpAreaOfCircle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rectangle r = new rectangle();
            double l = 0;
            double w = 0;
            double a = 0;
           l = double.Parse(txtLength.Text.ToString());
            w = double.Parse(txtWidth.Text.ToString());
            
            r.setL(l);
            r.setW(w);
            r.CalArea();

            txtArea.Text = r.getA().ToString();

        }
    }
    class rectangle
    {
        public double l;
        public double w;
        public double a;

        public void setL(double ll)
        {
            l = ll;
        }
        public void setW(double ww)
        {
            w = ww;
        }
        public void setA(double aa)
        {
            a = aa;
        }

        public double getL()
        {
            return l;
        }
        public double getW()
        {
            return w;
        }
        public double getA()
        {
            return a;
        }
        public void CalArea()
        {
            a = l * w;
        }
    }
}
