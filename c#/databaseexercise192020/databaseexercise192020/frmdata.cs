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

namespace databaseexercise192020
{
    public partial class frmdatainsert : Form
    {
        
        public frmdatainsert()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string username = txtusrname.Text.ToString();
            string fathername = txtFathername.Text.ToString();
            string dateofbirth = dtpDateofbirth.Text.ToString();
            string studentid = txtStudentid.Text.ToString();
            string phoneno = txtphonenumber.Text.ToString();
            //|| fathername == "" || phoneno == ""
            if (username == "")
            {
                MessageBox.Show("Check your Input");

            }
            else
            {
                try
                {
                    MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                    con.Open();
                    MessageBox.Show("ewr");
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO dtat.data(username,fathername,dateofbirth,phoneno,studentid" +
                                        "VALUES(@username,@fathername,@dateofbirth,@phoneno,@studentid)";

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@fathername", fathername);
                    cmd.Parameters.AddWithValue("@dateofbirth", dateofbirth);
                    cmd.Parameters.AddWithValue("@phoneno", phoneno);
                    cmd.Parameters.AddWithValue("@studentid", studentid);


                    int result = cmd.ExecuteNonQuery();
                    //con.Close();
                    if (result> 0)
                    {
                        MessageBox.Show("Student Register");

                    }
                    else
                    {
                        MessageBox.Show("ERROR!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
    }
}
