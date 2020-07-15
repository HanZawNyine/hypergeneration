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



namespace homewok1stgen
{
    public partial class frmconnect : Form
    {
        public frmconnect()
        {
            InitializeComponent();
        }
        MySqlConnection connection;
        

        private void btnDisconnected_Click(object sender, EventArgs e)
        {
            connection = new MySqlConnection("datasource=localhost; port=3306;username=root;");
            connection.Close();
            label1.Text = "Disconnected";
            label1.ForeColor = Color.Red;
            
            

            
        }

        private void btnConnected_Click(object sender, EventArgs e)
        {

            connection=new MySqlConnection("datasource=localhost; port=3306;username=root;");
            connection.Open();
            label1.Text = "Connected";
            label1.ForeColor=Color.Green;
            FrmInserttable frminsert = new FrmInserttable();
            frminsert.Show();
            this.Hide();
            
            
        }
    }
}
