using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lgin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //same=0 
            //not same = 1
            string User = txtUser.Text.ToString();
            string Pass = txtPass.Text.ToString();
            int IUser = string.Compare(User, "han");
            int IPass = string.Compare(Pass,"1234");

            if(IUser == 0 && IPass == 0)
            {
                DialogResult result = MessageBox.Show("Login Sucessful !");
                if (result == DialogResult.OK)
                {
                    this.Hide();
                    AreaOfCircle aoc = new AreaOfCircle();
                    aoc.ShowDialog();
                    this.Close();
                }

                txtUser.Clear();
                txtPass.Clear();
            }else
            {
                MessageBox.Show("Wrong Pass");
            }
        

            
           
            
        }
    }
}
