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


namespace CSDatabaseOwnIdea
{
    public partial class frmconnect : Form
    {
        public frmconnect()
        {
            InitializeComponent();
        }
        MySqlConnection connection;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new MySqlConnection("DataSource = localhost;port=3306;username=root;");
                connection.Open();
                
                    }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnconnected_Click(object sender, EventArgs e)
        {
            connection.Close();
            txtconnection.Text = "Disconnected";
            Application.Exit();

        }

        private void btnok_Click(object sender, EventArgs e)
        {
            this.Hide();
          frminsertdatabase frminsert= new frminsertdatabase();
            frminsert.Show();
        }
    }
}
