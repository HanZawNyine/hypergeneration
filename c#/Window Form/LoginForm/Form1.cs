using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string User = "hanzaw";
            string Pw = "1234";

            string LUSer = txtUserName.Text.ToString();
            string LPassword = txtPassword.Text.ToString();

            if(LUSer == User || LPassword==Pw)
            {
                MessageBox.Show("Login SucessFully !");
                txtUserName.Clear();
                txtPassword.Clear();
            }
            else
            {
                MessageBox.Show("Wrong !");
            }
        }
    }
}
