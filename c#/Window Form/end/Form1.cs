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

namespace end
{
    public partial class Form1 : Form
    {

        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
        
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string Name = txtName.Text.ToString();
            string Gmail = txtGmail.Text.ToString();
            try
            {
                
                con.Open();
                MySqlCommand cmd = con.CreateCommand();

                cmd.CommandText = "INSERT INTO phone01.end (`name`, `gmail`) VALUES (@Name,@Gmail);";
                cmd.Parameters.AddWithValue("@Name", Name);               
                cmd.Parameters.AddWithValue("@Gmail", Gmail);

                
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Form Registered !");

                txtGmail.Clear();
                txtName.Clear();


            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        MySqlDataAdapter adapter;


        }



}
