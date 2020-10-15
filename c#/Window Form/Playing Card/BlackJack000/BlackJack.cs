using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack000
{
    public partial class BlackJack : Form
    {
        Card c = new Card();
        Random rd = new Random((int)DateTime.Now.Ticks);
       //int cardno=r

        public BlackJack()
        {
            InitializeComponent();
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            //string result= "";
            //for(int i=0;i<52;i++)
            //{
            //     result += c.Deck[i].ToString() + "-";
            //}
            //MessageBox.Show(result);
            int card = rd.Next(0, 53);
            string cardface = c.ChooseCard(card);
            MessageBox.Show(card.ToString() + "-" + cardface);
        }

        private void btnShuffle_Click(object sender, EventArgs e)
        {
            MessageBox.Show(c.Deal());
        }
    }
}
