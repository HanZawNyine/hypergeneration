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
    public partial class frmLab : Form
    {
        public frmLab()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            string name = txtUsername.Text.ToString();
            string phoneno = txtPhone_no.Text.ToString();
            string gmail = txtGmail.Text.ToString();
            string address = txtAddress.Text.ToString();


            if (name == "" || phoneno == "" || gmail == "" || address == "")
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
                    cmd.CommandText = "INSERT INTO lab.lab(name,phone_no,gmail,address) VALUES (@name,@phoneno,@gmail,@address)";
                    cmd.Parameters.AddWithValue("@name",name);
                    cmd.Parameters.AddWithValue("@phoneno", phoneno);
                    cmd.Parameters.AddWithValue("@gmail", gmail);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.ExecuteNonQuery();
                    con.Close();
                   

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Application.Exit();
            }
        }
    }
}
