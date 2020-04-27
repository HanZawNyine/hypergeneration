using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello_World
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sUsername = "ghi";
            string sPassword = "1234";
            if(sUsername==txtUsername.Text||sPassword==txtPassword.Text)
            {
                Form1 frm1 = new Form1();
                frm1.ShowDialog();
            }
            else
            {
                //txtUsername.Clear();
               
                MessageBox.Show("Wrong Userame or Password");
            }
            txtUsername.Clear();
            txtPassword.Clear();

        }
    }
}
