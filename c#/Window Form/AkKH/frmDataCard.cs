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
    public partial class frmDataCard : Form
    {
        public frmDataCard()
        {
            InitializeComponent();
        }
        public void Diamond()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test.data", con);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "data");
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

        private void frmDataCard_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            WindowState = FormWindowState.Maximized;
            Diamond();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void Insert()
        {
            string Date = dateTimePicker1.Text.ToString();
            string Card_Type = txtCardType.Text.ToString();
            string Amount = txtAmount.Text.ToString();
            string Rate = txtRate.Text.ToString();
            string Prices = txtPrices.Text.ToString();
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost; database=test; user=root;pooling = false; convert zero datetime=True");
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO `data` (`No`, `Date`, `Card_Type`, `Amount`, `Rate`, `Prices`) VALUES (NULL,@Date,@Card_Type,@Amount,@Rate,@Prices);";
                cmd.Parameters.AddWithValue("@Date", Date);
                cmd.Parameters.AddWithValue("@Card_Type", Card_Type);
                cmd.Parameters.AddWithValue("@Amount", Amount);
                cmd.Parameters.AddWithValue("@Rate", Rate);
                cmd.Parameters.AddWithValue("@Prices", Prices);


                cmd.ExecuteNonQuery();
                DialogResult result = MessageBox.Show("Inserted !!");
                if (DialogResult.OK == result)
                {
                    txtAmount.Clear();
                    txtCardType.Clear();
                    txtPrices.Clear();
                    txtRate.Clear();
                    txtSearch.Clear();
                    dateTimePicker1.Value = DateTime.Now;
                }
                Diamond();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            if (txtAmount.Text == "" || txtCardType.Text == ""||txtPrices.Text==""||txtRate.Text=="")
            {
                MessageBox.Show("Check Input Data !");

            }
            else
            {
                Insert();
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
                        adapter = new MySqlDataAdapter("SELECT * FROM test.data where No like'%" + txt + "%'", con);
                        break;
                    case 1:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.data where Date like'%" + txt + "%'", con);
                        break;
                    case 2:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.data where Card_Type like'%" + txt + "%'", con);
                        break;
                    case 3:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.data where Amount like'%" + txt + "%'", con);
                        break;
                    case 4:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.data where Rate like'%" + txt + "%'", con);
                        break;
                    case 5:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.data where Prices like'%" + txt + "%'", con);
                        break;
                   
                }
                DataSet ds = new DataSet();
                adapter.Fill(ds, "data");
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                        cmd.CommandText = "Delete from test.data where no='" + id.ToString() + "'";

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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dataGridView1.Rows[index].Selected = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Diamond();
        }

        public void DgvCellUpdated()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test.data", con);
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

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DgvCellUpdated();
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
