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

namespace phone01
{
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void dgvTechnical_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
        
        public void ShowDatatbase()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM phone01.customer", con);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "customer");
                dgvCustomer.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmTechnical_Load(object sender, EventArgs e)
        {
            ShowDatatbase();
        }

        int select = 0;

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            string txt = txtCustomer.Text.ToString();
            funSearchTitle(txt, select);
            switch (cboCustomer.SelectedIndex)
            {
                case 0: select = 0; break;
                case 1: select = 1; break;
                case 2: select = 2; break;
                case 3: select = 3; break;
                case 4: select = 4; break;
                case 5: select = 5; break;
                case 6: select = 6; break;
                case 7: select = 7; break;
                case 8: select = 8; break;
                case 9: select = 9; break;
                case 10: select =10; break;


            }
        }
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
        MySqlDataAdapter adapter;

        public void funSearchTitle(string txt, int title)
        {


            try
            {

              
                con.Open();
                //MySqlDataAdapter adapte MySqlDataAdapter("SELECT * FROM lab.lab where done like'" + txt + "'", con);

                switch (title)
                {

                    case 0:
                        adapter = new MySqlDataAdapter("SELECT * FROM phone01.customer where customer_id like'" + txt + "'", con);
                        break;
                    case 1:
                        adapter = new MySqlDataAdapter("SELECT * FROM phone01.customer where customer_name like'" + txt + "'", con);
                        break;
                    case 2:
                        adapter = new MySqlDataAdapter("SELECT * FROM phone01.customer where phoneno like'" + txt + "'", con);
                        break;
                    case 3:
                        adapter = new MySqlDataAdapter("SELECT * FROM phone01.customer where sim_card like'" + txt + "'", con);
                        break;
                    case 4:
                        adapter = new MySqlDataAdapter("SELECT * FROM phone01.customer where sd_card like'" + txt + "'", con);
                        break;
                    case 5:
                        adapter = new MySqlDataAdapter("SELECT * FROM phone01.customer where password like'" + txt + "'", con);
                        break;
                    case 6:
                        adapter = new MySqlDataAdapter("SELECT * FROM phone01.customer where amount like'" + txt + "'", con);
                        break;
                    case 7:
                        adapter = new MySqlDataAdapter("SELECT * FROM phone01.customer where error like'" + txt + "'", con);
                        break;
                    case 8:
                        adapter = new MySqlDataAdapter("SELECT * FROM phone01.customer where start_date like'" + txt + "'", con);
                        break;
                    case 9:
                        adapter = new MySqlDataAdapter("SELECT * FROM phone01.customer where end_date like'" + txt + "'", con);
                        break;
                }




                DataSet ds = new DataSet();
                adapter.Fill(ds, "lab");
                dgvCustomer.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("are you sure --!");
            string txt = txtCustomer.Text.ToString();
            funDelete(txt, select);

            switch (cboCustomer.SelectedIndex)
            {
                case 0: select = 0; break;
                case 1: select = 1; break;
                case 2: select = 2; break;
                case 3: select = 3; break;
                case 4: select = 4; break;
                case 5: select = 5; break;
                case 6: select = 6; break;
                case 7: select = 7; break;
                case 8: select = 8; break;
                case 9: select = 9; break;
                case 10: select = 10; break;


            }

        }
        public void funDelete(string txt, int title)
        {

            try
            {


                con.Open();
                //MySqlDataAdapter adapte MySqlDataAdapter("SELECT * FROM lab.lab where done like'" + txt + "'", con);

                switch (title)
                {

                    case 0:
                        adapter = new MySqlDataAdapter("DELETE FROM phone01.customer where customer_id like'" + txt + "'", con);
                        break;
                    case 1:
                        adapter = new MySqlDataAdapter("DELETE FROM phone01.customer where customer_name like'" + txt + "'", con);
                        break;
                    case 2:
                        adapter = new MySqlDataAdapter("DELETE FROM phone01.customer where phoneno like'" + txt + "'", con);
                        break;
                    case 3:
                        adapter = new MySqlDataAdapter("Delete FROM phone01.customer where sim_card like'" + txt + "'", con);
                        break;
                    case 4:
                        adapter = new MySqlDataAdapter("delete FROM phone01.customer where sd_card like'" + txt + "'", con);
                        break;
                    case 5:
                        adapter = new MySqlDataAdapter("delete FROM phone01.customer where password like'" + txt + "'", con);
                        break;
                    case 6:
                        adapter = new MySqlDataAdapter("delete FROM phone01.customer where amount like'" + txt + "'", con);
                        break;
                    case 7:
                        adapter = new MySqlDataAdapter("delete FROM phone01.customer where error like'" + txt + "'", con);
                        break;
                    case 8:
                        adapter = new MySqlDataAdapter("delete FROM phone01.customer where start_date like'" + txt + "'", con);
                        break;
                    case 9:
                        adapter = new MySqlDataAdapter("delete FROM phone01.customer where end_date like'" + txt + "'", con);
                        break;
                }




                DataSet ds = new DataSet();
                adapter.Fill(ds, "lab");
                dgvCustomer.DataSource = ds.Tables["customer"];
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

        private void btnrefresh_Click_1(object sender, EventArgs e)
        {
            ShowDatatbase();
        }
    }

}
