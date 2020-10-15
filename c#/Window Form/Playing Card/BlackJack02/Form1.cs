using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rnd = new Random((int)DateTime.Now.Ticks);
        
        int card1;
        int card2;
        int card3;
        int card4;
        int card5;
        int card6;
        //int deal;
        int result;
        //int c;
        int eg;
        int f;
        int ef = 0;
        int af = 0;
        
       
       
        
       
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox6.Hide();
            pictureBox5.Hide();
            funCard1();
            int x= result;
            funCard2();
            
            int b = result;

            funCard3();
            int c = result;
            funCard4();
            int d = result;
            eg = x + b;
            f = c + d;
           

          
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            funCard5();
            af = result;
            pictureBox5.Show();

            if (eg<13)
            {
                funCard6();
                ef = result;
                pictureBox6.Show();

            }
            else
            {
                pictureBox6.Hide();
            }
            button3.Hide();
           
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            int aa =eg +ef;
            lblDeal.Text = aa.ToString();
            int bb = f + af;
            lbluser.Text = bb.ToString();
            if (aa >= bb)
            {
               DialogResult result= MessageBox.Show("you lose");
                if (result == DialogResult.OK)
                {
                    Application.Restart();

                }
            }
            else
            {
                DialogResult result = MessageBox.Show("you Win");
                if (result == DialogResult.OK)
                {
                    Application.Restart();

                }
            }
           
        }

        public void funCard1()
        {
            card1 = rnd.Next(0,52);
            var helper = card1;
            var pb = pictureBox1;
            if (helper>=13)
            {
                result = helper / 13;
                int sd =helper % 13;
                if (sd == 0)
                {
                    result = result - 1;
                    pb.Image = imageList1.Images[helper];
                }
                else
                {
                    pb.Image = imageList1.Images[helper];                   
                    
                }
            }
            else
            {
                if (helper == 0)
                {
                    result = result - 1;
                    pb.Image = imageList1.Images[helper];
                }
                else
                {
                    pb.Image = imageList1.Images[helper];

                }
            }
            
        }
        public void funCard2()
        {
            card2 = rnd.Next(0, 52);
            var helper = card2;
            var pb = pictureBox2;
            if (helper > 13)
            {
                result = helper / 13;
                int y = helper % 13;
                if (y == 0)
                {
                    result = result - 1;
                    pb.Image = imageList1.Images[helper];
                }
                else
                {
                    pb.Image = imageList1.Images[helper];

                }
            }
            else
            {
                if (helper == 0)
                {
                    result = result - 1;
                    pb.Image = imageList1.Images[helper];
                }
                else
                {
                    pb.Image = imageList1.Images[helper];

                }
            }






        }
        public void funCard3()
        {
            card3 = rnd.Next(0, 52);
            var helper = card3;
            var pb = pictureBox3;
            if (helper > 13)
            {
                result = helper / 13;
                int z = helper % 13;
                if (z == 0)
                {
                    result = result - 1;
                    pb.Image = imageList1.Images[helper];
                }
                else
                {
                    pb.Image = imageList1.Images[helper];

                }
            }
            else
            {
                if (helper == 0)
                {
                    result = result - 1;
                    pb.Image = imageList1.Images[helper];
                }
                else
                {
                    pb.Image = imageList1.Images[helper];

                }
            }






        }
        public void funCard4()
        {
            card4 = rnd.Next(0, 52);
            var helper = card4;
            var pb = pictureBox4;
            if (helper > 13)
            {
                result = helper / 13;
                int v = helper % 13;
                if (v == 0)
                {
                    result = result - 1;
                    pb.Image = imageList1.Images[helper];
                }
                else
                {
                    pb.Image = imageList1.Images[helper];

                }
            }
            else
            {
                if (helper == 0)
                {
                    result = result - 1;
                    pb.Image = imageList1.Images[helper];
                }
                else
                {
                    pb.Image = imageList1.Images[helper];

                }
            }






        }
        public void funCard5()
        {
            card5 = rnd.Next(0, 52);
            var helper = card5;
            var pb = pictureBox5;
            if (helper > 13)
            {
                result = helper / 13;
                int k = helper % 13;
                if (k == 0)
                {
                    result = result - 1;
                    pb.Image = imageList1.Images[helper];
                }
                else
                {
                    pb.Image = imageList1.Images[helper];

                }
            }
            else
            {
                if (helper == 0)
                {
                    result = result - 1;
                    pb.Image = imageList1.Images[helper];
                }
                else
                {
                    pb.Image = imageList1.Images[helper];

                }
            }






        }
        public void funCard6()
        {
            card6 = rnd.Next(0, 52);
            var helper = card6;
            var pb = pictureBox6;
            if (helper > 13)
            {
                result = helper / 13;
                int gh = helper % 13;
                if (gh == 0)
                {
                    result = result - 1;
                    pb.Image = imageList1.Images[helper];
                }
                else
                {
                    pb.Image = imageList1.Images[helper];

                }
            }
            else
            {
                if (helper == 0)
                {
                    result = result - 1;
                    pb.Image = imageList1.Images[helper];
                }
                else
                {
                    pb.Image = imageList1.Images[helper];

                }
            }






        }
        






        private void button4_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
