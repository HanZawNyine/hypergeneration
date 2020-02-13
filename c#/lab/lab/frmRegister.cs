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

namespace lab
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text.ToString();
            string Password = txtPassword.Text.ToString();
            string phoneno = txtPhone_no.Text.ToString();
            string gmail = txtGmail.Text.ToString();
            string address = txtAddress.Text.ToString();


            if (name == "" || phoneno == "" || gmail == "" || address == ""||Password =="")
            {
                MessageBox.Show("Please Check Your Input!");
                txtUsername.Focus();
            }
            else
            {
                try
                {
                    MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                    con.Open();

                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO lab.lab(name,Password,phoneno,gmail,address) VALUES (@name,@Password,@phoneno,@gmail,@address)";
                    cmd.Parameters.AddWithValue("@name",name);
                    cmd.Parameters.AddWithValue("@Password", Password);
                    cmd.Parameters.AddWithValue("@phoneno", phoneno);
                    cmd.Parameters.AddWithValue("@gmail", gmail);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Form Registered !");
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
               // frmLogin fl = new frmLogin();
                //fl.Show();
                this.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void txtPhone_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
