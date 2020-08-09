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
    public partial class frmUCcs : Form
    {
        public frmUCcs()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            if (txtID.Text == "" || txtFees.Text == "" || txtUC.Text == "" || txtCards.Text == "")
            {
                MessageBox.Show("Check Input Data !");

            }
            else
            {
                Insert();
            }
        }
        public void Insert()
        {
            string Date = dtpDate.Text.ToString();
            string ID = txtID.Text.ToString();
            //string Server = txtServer.Text.ToString();
            string Crads = txtCards.Text.ToString();
            string UC = txtUC.Text.ToString();
            string Fees = txtFees.Text.ToString();
            string Annotate = comboBox1.Text.ToString();
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost; database=test; user=root;pooling = false; convert zero datetime=True");
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO `uc` (`No`, `Date`, `ID`, `Cards`, `UC`, `Fees`, `Annotate`) VALUES (NULL, @Date, @ID, @Cards, @UC, @Fees,@Annotate);";
                cmd.Parameters.AddWithValue("@Date", Date);
                cmd.Parameters.AddWithValue("@ID", ID);
                //cmd.Parameters.AddWithValue("@Server", Server);
                cmd.Parameters.AddWithValue("@Cards", Crads);
               cmd.Parameters.AddWithValue("@UC", UC);
                cmd.Parameters.AddWithValue("@Fees", Fees);
                cmd.Parameters.AddWithValue("@Annotate", Annotate);

                cmd.ExecuteNonQuery();
                DialogResult result = MessageBox.Show("Inserted !!");
                if (DialogResult.OK == result)
                {
                    //comboBox1.Items.c
                    txtCards.Clear();
                    txtUC.Clear();
                    txtFees.Clear();
                  //  txtID.Clear();
                    txtID.Clear();
                    dtpDate.Value = DateTime.Now;
                }
                Diamond();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Diamond()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test.uc", con);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "uc");
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

        private void button3_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            Diamond();
        }

        private void frmUCcs_Load(object sender, EventArgs e)
        {
            Diamond();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            WindowState = FormWindowState.Maximized;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dataGridView1.Rows[index].Selected = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DgvCellUpdated();
        }
        public void DgvCellUpdated()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test.uc", con);
                con.Open();

                DataTable changes = ((DataTable)dataGridView1.DataSource).GetChanges();
                if (changes != null)
                {
                    MySqlCommandBuilder mcb = new MySqlCommandBuilder(adapter);
                    adapter.UpdateCommand = mcb.GetUpdateCommand();
                    adapter.Update(changes);
                    ((DataTable)dataGridView1.DataSource).AcceptChanges();

                    MessageBox.Show("Cell Updated");
                    return;
                }


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

        public void DelCell()
        {
            try
            {
                foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
                {
                    using (MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root"))
                    {
                        MySqlCommand cmd = con.CreateCommand();
                        int id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                        cmd.CommandText = "Delete from test.uc where no='" + id.ToString() + "'";

                        dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            DialogResult result = MessageBox.Show("Are You Sure To Delete !", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                DelCell();
            }
            else
            {
                Diamond();
            }
        }
        int select = 0;
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            string txt = txtSearch.Text.ToString();
            funSearchTitle(txt, select);
            switch (cboSearch.SelectedIndex)
            {
                case 0: select = 0; break;
                case 1: select = 1; break;
                case 2: select = 2; break;
                case 3: select = 3; break;
                case 4: select = 4; break;
                case 5: select = 5; break;
                case 6: select = 6; break;
               
            }
        }
        MySqlDataAdapter adapter;
        public void funSearchTitle(string txt, int title)
        {

            try
            {

                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                con.Open();

                switch (title)
                {

                    case 0:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.uc where No like'%" + txt + "%'", con);
                        break;
                    case 1:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.uc where Date like'%" + txt + "%'", con);
                        break;
                    case 2:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.uc where ID like'%" + txt + "%'", con);
                        break;
                    case 3:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.uc where Cards like'%" + txt + "%'", con);
                        break;
                    case 4:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.uc where UC like'%" + txt + "%'", con);
                        break;
                    case 5:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.uc where Fees like'%" + txt + "%'", con);
                        break;
                    case 6:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.uc where Annotate like'%" + txt + "%'", con);
                        break;
                  

                }
                DataSet ds = new DataSet();
                adapter.Fill(ds, "diamond");
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMain m = new frmMain();
            m.ShowDialog();
            this.Close();
        }
    }
}
