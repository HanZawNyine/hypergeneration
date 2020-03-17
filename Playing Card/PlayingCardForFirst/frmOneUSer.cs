using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace PlayingCardForFirst
{
    public partial class frmOneUser : Form
    {
        public frmOneUser()
        {
            InitializeComponent();
        }

        private void frmOneUser_Load(object sender, EventArgs e)
        {
            
        }
        int count1 = 0;
        int count2 = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
           //int card1 = 0;
          int card1= rnd.Next(0,52);
            int card2 = rnd.Next(0, 52);

            //Random rnd2= new Random();
            //int card2 = 0;
            //card2 = rnd2.Next(1, 53);
            
            //Graphics g = Graphics.FromHwnd(this.Handle);
            pbUserOne.Image = ILCollect.Images[card1];
            
            pbUserTwo.Image = ILCollect.Images[card2];
            Application.DoEvents();
            //System.Threading.Thread.Sleep(1000);

            if (card1>card2)
            {
                MessageBox.Show("player one is win");
                 count1++;
                lbCount1.Text = count1.ToString();
            }
            else if(card1<card2)
                {
                MessageBox.Show("Player two is win");
                count2++;

                lbCount2.Text = count2.ToString();

            }
            else if(card1==card2)
            {
                MessageBox.Show("we are equal!!");
                
            }
            
                
            //case 0:

            //System.Threading.Thread.s


        }

        private void pbUserOne_Click(object sender, EventArgs e)
        {

        }
    }
   
}
