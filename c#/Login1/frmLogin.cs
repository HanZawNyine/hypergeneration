using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Login1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = "han";
            string pass = "123";

            string uname = txtUsername.Text.ToString();
            string password = txtPassword.Text.ToString();

            if(user==uname && pass==password)
            {
                MessageBox.Show("login Secuessfully !!!!!!!!!!!!!!!");
                Application.Restart();
                
            }
            else
            {
                MessageBox.Show("Wrong username or password !!");
                Application.Exit();
                
            }

            txtPassword.Clear();

        }
    }
}
