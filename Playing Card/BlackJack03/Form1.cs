using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        int card1;
        int card2;
        int card3;
        int card4;
        int card5;
        int card6;
        int card7;
        int card8;
        int card9;
        int card10;
        Random rnd = new Random((int)DateTime.Now.Ticks);
        

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox2.Hide();
            pictureBox7.Hide();
            pictureBox1.Hide();
            pictureBox11.Hide();
            funCard1();
            funCard2();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public void funCard1()
        {
            int CardValue;
            int output;
            int CardValue2;
            int output2;
            int CardValue3;
            int output3;
            card1 = rnd.Next(0, 52);
            card2 = rnd.Next(0, 52);
            card3 = rnd.Next(0, 52);

            if (card1!=card2 || card2!=card3 || card3!=card1)
                  {
                if (card1 < 13)
                {
                    CardValue = card1++;
                    //funCard(card1);
                    //show card1 picture
                    pictureBox4.Image = imageList1.Images[card1];
                }
                else
                {
                    CardValue = card1++;
                    pictureBox4.Image = imageList1.Images[card1];
                    //Show cardvalue picture
                    int result = CardValue / 13;
                    int space = CardValue % 13;
                    if (space == 0)
                    {
                        output = result - 1;


                    }
                    else
                    {
                        output = result;

                    }

                    //funCard(card1);


                }

                if (card2 < 13)
                {
                    pictureBox3.Image = imageList1.Images[card2];
                    CardValue2 = card2++;
                    //show card1 picture
                   
                }
                else
                {
                    pictureBox3.Image = imageList1.Images[card2];
                    CardValue2 = card2++;
                    
                    //Show cardvalue picture
                    int result = CardValue2 / 13;
                    int space = CardValue2 % 13;
                    if (space == 0)
                    {
                        output2 = result - 1;

                    }
                    else
                    {
                        output2 = result;


                    }


                }

                if (card3 < 13)
                {
                    CardValue3 = card3++;
                    //show card1 picture
                    pictureBox5.Image = imageList1.Images[card3];
                }
                else
                {
                    pictureBox5.Image = imageList1.Images[card3];
                    CardValue3 = card3++;
                    //Show cardvalue picture
                    int result = CardValue3 / 13;
                    int space = CardValue3 % 13;
                    if (space == 0)
                    {
                        output3 = result - 1;

                    }
                    else
                    {
                        output3 = result;


                    }


                }
            }
            

            
            

            int CardValue7;
            int output7;
            if (card7 < 13)
            {
                CardValue7 = card7++;
                //show card1 picture
            }
            else
            {
                CardValue7 = card7++;
                //Show cardvalue picture
                int result = CardValue7 / 13;
                int space = CardValue7 % 13;
                if (space == 0)
                {
                    output7 = result - 1;

                }
                else
                {
                    output7 = result;


                }


            }

            int CardValue8;
            int output8;
            if (card8 < 13)
            {
                CardValue8 = card8++;
                //show card1 picture
            }
            else
            {
                CardValue8 = card8++;
                //Show cardvalue picture
                int result = CardValue8 / 13;
                int space = CardValue8 % 13;
                if (space == 0)
                {
                    output8 = result - 1;

                }
                else
                {
                    output8 = result;


                }


            }

            int CardValue9;
            int output9;
            if (card9 < 13)
            {
                CardValue9 = card9++;
                //show card1 picture
            }
            else
            {
                CardValue9 = card9++;
                //Show cardvalue picture
                int result = CardValue9 / 13;
                int space = CardValue9 % 13;
                if (space == 0)
                {
                    output9 = result - 1;

                }
                else
                {
                    output9 = result;
                }


            }

            int CardValue10;
            int output10;
            if (card10 < 13)
            {
                CardValue10 = card10++;
                //show card1 picture
            }
            else
            {
                CardValue10 = card10++;
                //Show cardvalue picture
                int result = CardValue10 / 13;
                int space = CardValue10 % 13;
                if (space == 0)
                {
                    output10 = result - 1;

                }
                else
                {
                    output10 = result;
                }


            }

        }
        public void funCard2()
        {
            int CardValue4;
            int output4;
            int CardValue5;
            int output5;
            int CardValue6;
            int output6;


            card4 = rnd.Next(0, 52);
            card5 = rnd.Next(0, 52);
            card6 = rnd.Next(0, 52);

            if (card4 != card5 || card4 != card6 || card5 != card6)
            {
                

                if (card4 < 13)
                {
                    CardValue4 = card4++;
                    //show card1 picture
                    pictureBox6.Image = imageList1.Images[card4];

                }
                else
                {
                    pictureBox6.Image = imageList1.Images[card4];
                    CardValue4 = card4++;
                    //Show cardvalue picture
                    int result = CardValue4 / 13;
                    int space = CardValue4 % 13;
                    if (space == 0)
                    {
                        output4 = result - 1;


                    }
                    else
                    {
                        output4 = result;


                    }


                }
                if (card5 < 13)
                {
                    pictureBox9.Image = imageList1.Images[card5];
                    CardValue5 = card5++;
                    //show card1 picture
                }
                else
                {
                    pictureBox9.Image = imageList1.Images[card5];
                    CardValue5 = card3++;
                    //Show cardvalue picture
                    int result = CardValue5 / 13;
                    int space = CardValue5 % 13;
                    if (space == 0)
                    {
                        output5 = result - 1;

                    }
                    else
                    {
                        output5 = result;


                    }


                }
                if (card6 < 13)
                {
                    pictureBox8.Image = imageList1.Images[card6];
                    CardValue6 = card6++;
                    //show card1 picture
                }
                else
                {
                    pictureBox8.Image = imageList1.Images[card6];
                    CardValue6 = card6++;
                    //Show cardvalue picture
                    int result = CardValue6 / 13;
                    int space = CardValue6 % 13;
                    if (space == 0)
                    {
                        output6 = result - 1;

                    }
                    else
                    {
                        output6 = result;


                    }


                }
            }         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
        
       // int title;
        
        public void funCard(int card)
        {
            var pb= pictureBox4;
            switch (card)
            {
                case 0: pb.Image = imageList1.Images["0"];  break;
                case 1: pb.Image = imageList1.Images["1"]; break;
                case 2: pb.Image = imageList1.Images["2"]; break;
                case 3: pb.Image = imageList1.Images["3"]; break;
                case 4: pb.Image = imageList1.Images["4"]; break;
                case 5: pb.Image = imageList1.Images["5"]; break;
                case 6: pb.Image = imageList1.Images["6"]; break;
                case 7: pb.Image = imageList1.Images["7"]; break;
                case 8: pb.Image = imageList1.Images["8"]; break;
                case 9: pb.Image = imageList1.Images["9"]; break;
                case 10: pb.Image = imageList1.Images["10"]; break;

                case 11: pb.Image = imageList1.Images["11"]; break;
                case 12: pb.Image = imageList1.Images["12"]; break;
                case 13: pb.Image = imageList1.Images["13"]; break;
                case 14: pb.Image = imageList1.Images["14"]; break;
                case 15: pb.Image = imageList1.Images["15"]; break;
                case 16: pb.Image = imageList1.Images["16"]; break;
                case 17: pb.Image = imageList1.Images["17"]; break;
                case 18: pb.Image = imageList1.Images["18"]; break;
                case 19: pb.Image = imageList1.Images["19"]; break;
                case 20: pb.Image = imageList1.Images["20"]; break;

                case 21: pb.Image = imageList1.Images["21"]; break;

            }
        }
    }
}
