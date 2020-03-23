using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace black_jack_001
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public int[] Deck = new int[52];

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
        int card;
        Random rnd = new Random((int)DateTime.Now.Ticks);
        
        private void button1_Click(object sender, EventArgs e)
        {
            card = rnd.Next(0, 52);
            pictureBox1.Image = Image.FromFile(RCard(card));
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            //MessageBox.Show(RCard(card));           

        }
        public string Card(int card)
        {
            int iface=card%13;
            int isuit=card/13;
            string face="";
            string suit="";
            if (iface == 0)
            {
                isuit--;
            }
            switch (iface)
            {
                
               
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:face = iface.ToString(); break;
                case 11:face = "j"; break;
                case 12:face = "Q"; break;
                //case 13:
                case 0: face = "K"; break;
                case 1: face = "A"; break;
                default: face = "";break;

            }
            switch(isuit)
            {
                case 0:suit = "S";break;
                case 1:suit = "H";break;
                case 2:suit = "D";break;
                case 3:suit = "C";break;
                default:face = "";break;
            }


            //pictureBox1.Image = Image.FromFile("");

            return face +suit;
        }
        string path;
        public string ShowCard(string cd)
        {
            path =Directory.GetCurrentDirectory()+"D:/hypergeneration/Playing Card/cards/" + cd + ".png";
    
            return path;
        }
        public string RCard(int cardno)
        {

            return ShowCard(Card(cardno));
        }
        int top = 0;
        public string Deal()
        {
            //int top = card;
            return Card(Deck[top++]);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            card = rnd.Next(0, 52);

        }
    }
}
