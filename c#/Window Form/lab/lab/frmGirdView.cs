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
    public partial class frmGirdView : Form
    {
        public frmGirdView()
        {
            InitializeComponent();
        }

        private void dgvSQLVIEM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void frmGirdView_Load(object sender, EventArgs e)
        {
            ShowDatatbase();
        }
        public void ShowDatatbase()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM lab.lab", con);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "lab");
                dgvSQLVIEM.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowDatatbase();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            dgvSQLVIEM.DataSource = null;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string txt = txtPhoneNo.Text.ToString();
            funSearchTitle(txt, select);
        }

        MySqlDataAdapter adapter;

        public void funSearchTitle(string txt, int title)
        {

            try
            {

                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                con.Open();
                //MySqlDataAdapter adapter;

                switch (title)
                {

                    case 0:
                        adapter = new MySqlDataAdapter("SELECT * FROM lab.lab where name like'" + txt + "'", con);
                        break;
                    case 1:
                        adapter = new MySqlDataAdapter("SELECT * FROM lab.lab where phone_no like'" + txt + "'", con);
                        break;
                    case 2:
                        adapter = new MySqlDataAdapter("SELECT * FROM lab.lab where gmail like'" + txt + "'", con);
                        break;
                    case 3:
                        adapter = new MySqlDataAdapter("SELECT * FROM lab.lab where Address like'" + txt + "'", con);
                        break;
                }


                DataSet ds = new DataSet();
                adapter.Fill(ds, "lab");
                dgvSQLVIEM.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int select = 0;

        private void comboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboSearch.SelectedIndex)
            {
                case 0: select = 0; label1.Text = "Name"; break;
                case 1: select = 1; label1.Text = "Phone NO"; break;
                case 2: select = 2; label1.Text = "Gmail"; break;
                case 3: select = 3; label1.Text = "Address"; break;

            }
        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
