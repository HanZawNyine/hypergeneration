using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPGoldPrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalGoldPrice();
        }
        public  void  CalGoldPrice()
        {
        
           GoldPrice gp = new GoldPrice();
            gp.setK(double.Parse(txtKyat.Text.ToString()));
            gp.setP( double.Parse(txtPae.Text.ToString()));
            gp.setY(double.Parse(txtYway.Text.ToString()));
            gp.setPK( double.Parse(txtPPk.Text.ToString())) ;
            //gp.totalPrice;

            //gp.totalPrice = gp.ppk * (gp.kyat + (gp.pae / 16) + (gp.yway / 16 / 8));
            txtTotalPrice.Text =gp.Formula().ToString();

            GoldPiece gt = new GoldPiece();
            gt.settype("ring");
            MessageBox.Show(gt.gettype());

        }
    }
    class GoldPiece : GoldPrice
    {
        string type;
        public void settype(string s)
        {
            type = s;
        }
        public string gettype()
        {
            return type;
        }
    }
    class GoldPrice
    {
         double kyat;
         double pae;
         double yway;
         double ppk;
         double totalPrice;
        public  void setK(double kk)
        {
            kyat = kk;

        }
        public void setP(double pp)
        {
            pae = pp;
        }
        public void setY(double yy)
        {
            yway = yy;
        }
        public void setPK(double pk)
        {
            ppk = pk;
        }
        public double getK()
        {
            return kyat;
        }
       public double getP()
        {
            return pae;
        }
        public double getY()
        {
            return yway;
        }
        public double getPk()
        {
            return ppk;
        }

        public double Formula()
        {
            totalPrice =ppk * (kyat + (pae / 16) + (yway / 16 / 8));
            return totalPrice;
        }
    }

}
