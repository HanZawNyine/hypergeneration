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

namespace L_Khant_000
{
    public partial class frmOriginal : Form
    {
        public frmOriginal()
        {
            InitializeComponent();
        }

        private void frmOriginal_Load(object sender, EventArgs e)
        {

            FormBorderStyle = FormBorderStyle.FixedDialog;
            WindowState = FormWindowState.Maximized;
            ShowDatatbase();
        }
        public void ShowDatatbase()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test.original", con);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "original");
                dgvOriginal.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure To Exit ?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Refresh();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOreder main = new frmOreder();
            main.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Refresh();
            ShowDatatbase();
           // this.Refresh();
            //txtSearch.Clear();
        }
        MySqlConnection con = new MySqlConnection("server=localhost; database=test; user=root;pooling = false; convert zero datetime=True");
        private void brnInsert_Click(object sender, EventArgs e)
        {
            string Date = dtpDate.Text.ToString();
            string About = txtAbout.Text.ToString();
            string Money = txtMoney.Text.ToString();

            if(Date==""||About==""||Money=="")
            {
                MessageBox.Show("Check Your Input...........................!");
            }
            else
            {
                try
                {
                    con.Open();

                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO `original` (`no`, `date`, `about`, `money`) VALUES (NULL,@Date,@About, @Money);";
                    cmd.Parameters.AddWithValue("@Date", Date);
                    cmd.Parameters.AddWithValue("@About", About);
                    cmd.Parameters.AddWithValue("@Money", Money);
                   

                    cmd.ExecuteNonQuery();
                    con.Close();
                    DialogResult result = MessageBox.Show("Inserted !!");
                    if (DialogResult.OK == result)
                    {
                        txtAbout.Clear();
                        txtMoney.Clear();                      
                        ShowDatatbase();
                        //txtSearch.Clear();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure To Delete ?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                DelCell();
                this.Refresh();
            }
            else
            {
                this.Refresh();
            }
        }
        public void DgvCellUpdated()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test.original", con);
                con.Open();

                DataTable changes = ((DataTable)dgvOriginal.DataSource).GetChanges();
                if (changes != null)
                {
                    MySqlCommandBuilder mcb = new MySqlCommandBuilder(adapter);
                    adapter.UpdateCommand = mcb.GetUpdateCommand();
                    adapter.Update(changes);
                    ((DataTable)dgvOriginal.DataSource).AcceptChanges();

                    MessageBox.Show("Cell Updated");
                    return;
                }
                con.Close();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvOriginal_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DgvCellUpdated();
            this.Refresh();
        }

        private void dgvOriginal_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgvOriginal.Rows[index].Selected = true;
        }

        public void DelCell()
        {
            try
            {
                foreach (DataGridViewRow item in this.dgvOriginal.SelectedRows)
                {
                    using (MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root"))
                    {
                        ///con.Open();
                        MySqlCommand cmd = con.CreateCommand();
                        int id = Convert.ToInt32(dgvOriginal.SelectedRows[0].Cells[0].Value);
                        cmd.CommandText = "Delete from test.original where no='" + id + "'";

                        dgvOriginal.Rows.RemoveAt(this.dgvOriginal.SelectedRows[0].Index);
                        con.Open();
                        cmd.ExecuteNonQuery();
                       con.Close();

                    }
                    //this.Refresh();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        int select = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            string txt = txtSearch.Text.ToString();
            funSearchTitle(txt, select);
            switch (cboSearch.SelectedIndex)
            {
                case 0: select = 0; break;
                case 1: select = 1; break;
                case 2: select = 2; break;
                case 3: select = 3; break;
               
            }
            txtSearch.Clear();
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
                        adapter = new MySqlDataAdapter("SELECT * FROM test.original where no like'" + txt + "'", con);
                        break;
                    case 1:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.original where date like'" + txt + "'", con);
                        break;
                    case 2:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.original where about like'" + txt + "'", con);
                        break;
                    case 3:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.original where money like'" + txt + "'", con);
                        break;
                    

                }
                DataSet ds = new DataSet();
                adapter.Fill(ds, "original");
                dgvOriginal.DataSource = ds.Tables[0];
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ရငရစရငToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelling selling = new frmSelling();
            selling.ShowDialog();
            this.Close();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Hide();
            frmProduct product = new frmProduct();
            product.ShowDialog();
            this.Close();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCustomer customer = new frmCustomer();
            customer.ShowDialog();
            this.Close();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmOreder order = new frmOreder();
            order.ShowDialog();
            this.Close();
        }

        private void codeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPCoude Pcode = new frmPCoude();
            Pcode.ShowDialog();
            this.Close();
        }

        private void moneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }
    }
}
