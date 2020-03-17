using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BlackJack
{
    public partial class frmDealer : Form
    {
        
        public frmDealer()
        {
            InitializeComponent();
            
        }
        Random rnd = new Random((int)DateTime.Now.Ticks);
        int card1;
        int card2;
        int card3;
        int card4;
        int card5=0;
        int card6=0;
        int deal;
        int user;
        int count1=0;
        int count2 = 0;
        

        private void frmDealer_Load(object sender, EventArgs e)
        {
            pictureBox6.Hide();
            pictureBox5.Hide();
            funLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (result == DialogResult.OK)
            {
                funLoad();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int result = 0;
           DialogResult result= MessageBox.Show("Are you Sure !","",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
               if(result==DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                MessageBox.Show("error");

            }
        }

        private void btnDrawaCard_Click(object sender, EventArgs e)
        {
            card6 = rnd.Next(0, 52);
            pictureBox6.Image = il.Images[card6];
            Application.DoEvents();            
            pictureBox6.Show();
            int min = 15;
            if ((card1 + card2) <= min)
            {
                card5 = rnd.Next(0, 52);
                pictureBox5.Image = il.Images[card5];
                Application.DoEvents();
                pictureBox5.Show();

            }
            btnDrawaCard.Hide();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
           // funCount();
            funStart();
            //funCount();


        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
        DialogResult result;

        public void funStart()
        {
            funCount();
            
            pictureBox1.Image = il.Images[card1];
            pictureBox2.Image = il.Images[card2];
            pictureBox5.Image = il.Images[card5];
            Application.DoEvents();



            int max = 21;
            //funShow();
            if (deal > max)
            {
                count2++;
                //label3.Text = count2.ToString();
                 result = MessageBox.Show("You Win ! deal out");
                if (result == DialogResult.OK)
                {
                    Application.Restart();
                    //repeat();
                    
                    //pictureBox5.Image = il.Images[card5];

                }
                //funShow();
            }
            else if (user > max)
            {
                 result = MessageBox.Show("You lose ! You out");
                count1++;
                
                if (result == DialogResult.OK)
                {
                    Application.Restart();//repeat();
                }

            }
            else if (user < deal || deal < max)
            {

                count1++;
               // label2.Text = count1.ToString();
                 result = MessageBox.Show("You Lose");
                if (result == DialogResult.OK)
                {
                    Application.Restart();//repeat();
                }

            }
            else if (deal < user || user < max)
            {

                count2++;
                
                 result = MessageBox.Show("You win !! ");
                if (result == DialogResult.OK)
                {
                    Application.Restart();//repeat();
                }

            }
            

        }
        public void funLoad()
        {
            
            card1 = rnd.Next(0, 52);
            card2 = rnd.Next(0, 52);
            card3 = rnd.Next(0, 52);
            card4 = rnd.Next(0, 52);
            Application.DoEvents();

            pictureBox3.Image = il.Images[card3];
            pictureBox4.Image = il.Images[card4];
        }
        
      public void repeat()
        {
            pictureBox5.Hide();
            pictureBox1.Image = il.Images[52];
            pictureBox2.Image = il.Images[52];
            btnDrawaCard.Show();
            funLoad();
        }

        public  void funCount()
        {
            int jkl;
            int gty;
            int fgh;
            int ddd;
            int eee;
            int ttt;

            if (card1 > 13)
            {
                
                int result = card1 / 13;
                int y = card1 % 13;
                if (y == 0)
                {
                    result = result - 1;
                    pictureBox1.Image = il.Images[card1];
                   // jkl = result;
                }
                else
                {
                    pictureBox1.Image = il.Images[card1];
                    //jkl = result;

                }
                jkl = result;
            }
            else
            {
                jkl=card1;
            }
            if (card2 > 13)
            {
                //int gty;
                int fff = card2 / 13;
                int aaf = card2 % 13;
                if (aaf == 0)
                {
                    fff = fff - 1;
                    pictureBox1.Image = il.Images[card2];
                }
                else
                {
                    pictureBox1.Image = il.Images[card2];

                }
                 gty = fff;
            }
            else
            {
                gty = card2;
            }
            if (card3 > 13)
            {
                int zzz = card3 / 13;
                int jjj = card3 % 13;
                if (jjj == 0)
                {
                    zzz = zzz - 1;
                    pictureBox1.Image = il.Images[card3];
                }
                else
                {
                    pictureBox1.Image = il.Images[card3];

                }
                fgh = zzz;
            }
            else
            {
                fgh = card3;
            }
            if(card4>13)
            {
                int kkk = card4 / 13;
                int lll = card4 % 13;
                if (lll == 0)
                {
                    kkk = kkk - 1;
                    pictureBox1.Image = il.Images[card4];
                }
                else
                {
                    pictureBox1.Image = il.Images[card4];

                }
                ddd = kkk;
            }
            else
            {
                ddd = card4;
            }
            if(card5>13)
            {
                int iii = card5 / 13;
                int yyy = card5 % 13;
                if (yyy == 0)
                {
                    yyy = yyy - 1;
                    pictureBox1.Image = il.Images[card5];
                }
                else
                {
                    pictureBox1.Image = il.Images[card5];

                }
                eee = yyy;
            }
            else
            {
                eee = card5;
            }
            if(card6>13)
            {
                int ggg = card6 / 13;
                int hhh = card6 % 13;
                if (hhh == 0)
                {
                    ggg = ggg - 1;
                    pictureBox1.Image = il.Images[card6];
                }
                else
                {
                    pictureBox1.Image = il.Images[card6];

                }
               ttt = ggg;


            }
            else
            {
                ttt = card6;
            }
            deal = jkl + gty + fgh;
            user = ddd + eee + ttt;
           label2.Text = deal.ToString();
            label3.Text = user.ToString();
        }

    }
}
