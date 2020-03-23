using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace BlackJack000
{
   public class Card
    {
        public int[] Deck = new int[52];
        public int top = 0;
        
        //public string Name
        //{
        //    get { return Name; }
        //    set { Name = value; }
        //}
        //public Card()
        //{
        //    makeNewDeck();
        //}
        public string ChooseCard(int cardno)
        {    
            //
            string face = "";
            string suit = "";
            //string cardface = "";
            int isuit = cardno / 13;
            int iface = cardno % 13;
            if (iface == 0)
            {
               isuit--;
            }

            switch (iface)
            {           
                case 2:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10: face = iface.ToString();break;
                case 11: face = "J"; break;
                case 12: face = "Q"; break;
                case 0:  face = "K";  break;
                case 1: face = "A"; break;
                default: face= "";break;

            }
            switch(isuit)
            {
                case 0: suit = "S"; break;
                case 1: suit = "H";break;
                case 2:suit = "D";break;
                case 3:suit = "C";break;
               // default: suit = ""; break;
            }
            return face+isuit;
        }

        //public void makeNewDeck()
        //{
        //    for(int i=0;i<52;i++)
        //    {
        //        Deck[i] = i++;
        //    }
        //    top = 0;
        //}
        public void shuffle()
        {
            int temp = 0;
            for (int j= 0; j <100; j++)
            {
                for (int i = 0; i < 52; i++)
                {   Random rd = new Random((int)DateTime.Now.Ticks);
                    int card = rd.Next(0, 52);
                    if (i != card)
                    {
                        temp = Deck[i];
                        Deck[i] = Deck[card];
                        Deck[card] = temp;
                    }
                }
            }
            top = 0;
            //return shuffle;
        }
        //public string ShowDeck()
        //{
        //    string result = "";
        //    for (int i = 0; i < 52; i++)
        //    {
        //        result += Deck[i].ToString();
        //    }
        //    return result;
        //    //MessageBox.Show()
        //}
        public string Deal()
        {
            return ChooseCard(Deck[top++]);
        }
        public string ShowCard(string cd)
        {
            string path = Directory.GetCurrentDirectory()+"\\cards\\"+cd+".png";
            
            return path;
        }

    }
}
