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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            Boolean status = false;
            try
            {
                string username = txtUname.Text.ToString();
                string password = txtPassword.Text.ToString();

                string sU = "";
                string sP = "";

               
                MySqlConnection con;

                con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                con.Open();
                //MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM lab.lab", con);                            


                string query = "SELECT * FROM lab.lab";
                MySqlCommand cmd = new MySqlCommand(query, con);
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    sU = reader.GetString("name").ToString();
                    sP = reader.GetString("Password").ToString();
                    if (sU == username && sP == password)
                    {
                        status = true;
                    }

                    cboUswername.Items.Add(sU);
                    cnoPassword.Items.Add(sP);

                }
                con.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            if(status)
            {
                MessageBox.Show("Login Sucessful");

                frmGirdView fv = new frmGirdView();
               
                fv.ShowDialog();
                this.Close();
                



            }
            else
            {
                MessageBox.Show("login Fail !");
            }
            

        }

        private void cboUswername_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            frmRegister fg = new frmRegister();
            fg.ShowDialog();
            this.Close();

        }

    }
}
