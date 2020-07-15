using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstPj000
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

       
        string a = "\0";
        string b = "\0";
        private void Login_Load(object sender, EventArgs e)
        {
           
               
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Uname = txtUname.Text.ToString();
            string Pass = txtPass.Text.ToString();
            string ConPass = txtConPass.Text.ToString();

            if(Pass==ConPass)
            {
                MessageBox.Show("Sign Up Secuessfully !");
                a= Uname;
                b = Pass;
                txtUname.Clear();
                
            }
            else
            {
                MessageBox.Show("Password is not Match !");             
                
            }
            txtPass.Clear();
            txtConPass.Clear();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            string username = txtUsername.Text.ToString();
           string  password = txtPassword.Text.ToString();
            if ( username==a && password==b)
            {
              MessageBox.Show("Login Sucessfully");
                frmMain main = new frmMain();
                main.Show();
                this.Hide();
                
            }
            else
            {
             MessageBox.Show("Try Again ! Or Please Sign Up","Wrong Username & Password");         
                
            }
            txtUsername.Clear();
            txtPassword.Clear();
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
