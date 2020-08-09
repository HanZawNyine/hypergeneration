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

namespace AkKH
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            timer1.Start();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            WindowState = FormWindowState.Maximized;
            Diamond();
            UC();
            dataCard();
            eLoad();
        }
        public void Diamond()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test.diamond", con);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "diamond");
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewColumn col in dataGridView1.Columns)
                {
                    //row.Cells[col.Index].Style.BackColor = Color.Green; //doesn't work
                    //col.Cells[row.Index].Style.BackColor = Color.Green; //doesn't work
                    dataGridView1[col.Index, row.Index].Style.BackColor = Color.Black;

                }
            }
        }

        public void UC()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test.uc", con);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "uc");
                dataGridView2.DataSource = ds.Tables[0];
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                foreach (DataGridViewColumn col in dataGridView2.Columns)
                {
                    //row.Cells[col.Index].Style.BackColor = Color.Green; //doesn't work
                    //col.Cells[row.Index].Style.BackColor = Color.Green; //doesn't work
                    dataGridView2[col.Index, row.Index].Style.BackColor = Color.Black;

                }
            }
        }

        public void eLoad()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test.eLoad", con);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "eLoad");
                dataGridView3.DataSource = ds.Tables[0];
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (DataGridViewRow row in dataGridView3.Rows)
            {
                foreach (DataGridViewColumn col in dataGridView3.Columns)
                {
                    //row.Cells[col.Index].Style.BackColor = Color.Green; //doesn't work
                    //col.Cells[row.Index].Style.BackColor = Color.Green; //doesn't work
                    dataGridView3[col.Index, row.Index].Style.BackColor = Color.Black;

                }
            }
        }
        public void dataCard()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test.data", con);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "data");
                dataGridView4.DataSource = ds.Tables[0];
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            foreach (DataGridViewRow row in dataGridView4.Rows)
            {
                foreach (DataGridViewColumn col in dataGridView4.Columns)
                {
                    //row.Cells[col.Index].Style.BackColor = Color.Green; //doesn't work
                    //col.Cells[row.Index].Style.BackColor = Color.Green; //doesn't work
                    dataGridView4[col.Index, row.Index].Style.BackColor = Color.Black;

                }
            }
        }


        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void diamondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDiamond Diam= new frmDiamond();
            Diam.ShowDialog();
            this.Close();
        }

        private void uCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUCcs uc = new frmUCcs();
            uc.ShowDialog();
            this.Close();
        }

        private void eLoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmE_Load eLoad = new frmE_Load();
            eLoad.ShowDialog();
            this.Close();

        }

        private void dataCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDataCard dC = new frmDataCard();
            dC.ShowDialog();
            this.Close();
        }

        public void DbCreater()
        {
            try
            {

                MySqlConnection con = new MySqlConnection("server=localhost; database=test; user=root;pooling = false; convert zero datetime=True");
                MySqlCommand cmd = con.CreateCommand();

                con.Open();
                cmd.CommandText = "create table data(No INT NOT NULL AUTO_INCREMENT,Date VARCHAR(255) NOT NULL,Card_Type VARCHAR(255) NOT NULL,Amount VARCHAR(255) NOT NULL,Rate VARCHAR(255) NOT NULL,Prices VARCHAR(255) NOT NULL,PRIMARY KEY(No )); ";
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                cmd.CommandText = "create table diamond(No INT NOT NULL AUTO_INCREMENT,Date VARCHAR(255) NOT NULL,ID VARCHAR(255) NOT NULL,Server VARCHAR(255) NOT NULL,Cards VARCHAR(255) NOT NULL,Diamond VARCHAR(255) NOT NULL, Fees VARCHAR(255) NOT NULL,Annotate VARCHAR(255) NOT NULL,PRIMARY KEY(No )); ";
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                cmd.CommandText = "create table eload(No INT NOT NULL AUTO_INCREMENT,Date VARCHAR(255) NOT NULL, E_Load VARCHAR(255) NOT NULL, Fees VARCHAR(255) NOT NULL,Annotate VARCHAR(255) NOT NULL,PRIMARY KEY(No )); ";
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                cmd.CommandText = "create table uc(No INT NOT NULL AUTO_INCREMENT,Date VARCHAR(255) NOT NULL,ID VARCHAR(255) NOT NULL, Cards VARCHAR(255) NOT NULL,UC VARCHAR(255) NOT NULL,Fees VARCHAR(255) NOT NULL,Annotate VARCHAR(255) NOT NULL,PRIMARY KEY(No )); ";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Database Created !\n PLease Click For First Time !");
                Diamond();
                UC();
                dataCard();
                eLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void createDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DbCreater();

        }

        private void deleteDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult result= MessageBox.Show("Are you Sure To Delete Database !!!!!!!!!!!!", "Database", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if(result==DialogResult.Yes)
            {
                DelDB();
            }
            else
            {
                Diamond();
                UC();
                dataCard();
                eLoad();
            }
           
        }

        public void DelDB()
        {
            try
            {

                MySqlConnection con = new MySqlConnection("server=localhost; database=test; user=root;pooling = false; convert zero datetime=True");
                MySqlCommand cmd = con.CreateCommand();

                con.Open();
                cmd.CommandText = "DROP TABLE test.data ;";
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                cmd.CommandText = "DROP TABLE test.diamond ;";
                cmd.ExecuteNonQuery();
                con.Close();

                con.Open();
                cmd.CommandText = "DROP TABLE test.eload ;";
                cmd.ExecuteNonQuery();
                con.Close();
                con.Open();
                cmd.CommandText = "DROP TABLE test.uc ;";
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Deleted Database , Please Start Create Again !");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
}

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToString("hh * mm * ss * tt : [ dd : MM{MMMM} : yyyy ]");
        }

        private void exportDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataExportImportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmDataEdit aa = new frmDataEdit();
            aa.ShowDialog();
            this.Close();
        }
    }
}
