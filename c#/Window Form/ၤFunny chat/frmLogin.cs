using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _ၤFunny_chat
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoginHide();       

           
            
        }

        public void SignUpHide()
        {
            label5.Show();
            button4.Show();
            txtConfirm.Show();
            label2.Show();

            button1.Hide();
            progressBar1.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            button3.Hide();
        }

        public void LoginHide()
        {
           
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            label7.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            txtConfirm.Hide();
            button4.Hide();
            //.Hide();
        }

        int a = 0;

        private void button3_Click(object sender, EventArgs e)
        {
            

            if (a == 0)
            {  
                if (txtPassword.Text == "")
                {
                    this.Refresh();
                    //MessageBox.Show("");
                   
                    label4.Show();
                    label4.Text = "Check Password";
                    this.label4.ForeColor = Color.Red; 
                }
                else
                {
                    txtPassword.PasswordChar = '\0';
                    a++;
                }            
                
            }
           else if(a == 1)
            {
                txtPassword.PasswordChar = '*';
                a = 0;
            }
            
            
            
            //txtPassword.PasswordChar.ToString("");
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label4.Hide();
            if (a == 0)
            {
                if (txtPassword.Text == "")
                {
                    if( txtConfirm.Text == "")
                    {
                        this.Refresh();
                        //MessageBox.Show("");


                        label7.Show();
                        label7.Text= "Check Password";
                        this.label7.ForeColor = Color.Red;
                    }
                    
                }
                else
                {
                   txtPassword.PasswordChar = '\0';
                    txtConfirm.PasswordChar = '\0';
                    a++;
                    label7.Hide();

                    
                }

            }
            else if (a == 1)
            {
                txtPassword.PasswordChar = '*';
                txtConfirm.PasswordChar = '*';
                a = 0;
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
           // LoginHide();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            LoginHide();
            SignUpHide();
        }
    }
}
