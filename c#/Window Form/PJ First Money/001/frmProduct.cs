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
    public partial class frmProduct : Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            WindowState = FormWindowState.Maximized;
            ShowDatatbase();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOreder main = new frmOreder();
            main.ShowDialog();
            this.Close();
            
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string Date = dtpDate.Text.ToString();
            string ProductCode = txtProductCode.Text.ToString();
            string ProductNumber = txtProductNumber.Text.ToString();

            if (Date == "" || ProductCode == "" || ProductNumber == "" )
            {
                MessageBox.Show("Check Your Input...........................!");

            }
            else
            {
                try
                {
                    MySqlConnection con = new MySqlConnection("server=localhost; database=test; user=root;pooling = false; convert zero datetime=True");

                    con.Open();

                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO test.products(`no`, `date`, `product_code`, `product_number`) VALUES (NULL,@Date, @ProductCode, @ProductNumber);";
                    cmd.Parameters.AddWithValue("@Date", Date);
                    cmd.Parameters.AddWithValue("@ProductCode", ProductCode);
                    cmd.Parameters.AddWithValue("@ProductNumber", ProductNumber);                    

                    cmd.ExecuteNonQuery();
                    con.Close();
                    DialogResult result = MessageBox.Show("Inserted !!");
                    if (DialogResult.OK == result)
                    {
                        txtProductCode.Clear();
                        //cboAmount.clear();
                        txtProductCode.Clear();
                        txtProductNumber.Clear();
                        ShowDatatbase();


                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }

        public void ShowDatatbase()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test.products", con);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "products");
                dgvProduct.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int select = 0;
        private void btnSearch_Click(object sender, EventArgs e)
        {

            string txt = txtSearch.Text.ToString();
            funSearchTitle(txt, select);
            switch (cboSearch.SelectedIndex)
            {
                case 0: select = 0; break;
                case 1: select = 1; break;
                case 2: select = 2; break;
             
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDatatbase();
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
                        adapter = new MySqlDataAdapter("SELECT * FROM test.products where no like'" + txt + "'", con);
                        break;
                    case 1:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.products where product_code like'" + txt + "'", con);
                        break;
                    case 2:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.products where product_number like'" + txt + "'", con);
                        break;
                    

                }
                DataSet ds = new DataSet();
                adapter.Fill(ds, "products");
                dgvProduct.DataSource = ds.Tables[0];
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void DgvCellUpdated()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test.products", con);
                con.Open();

                DataTable changes = ((DataTable)dgvProduct.DataSource).GetChanges();
                if (changes != null)
                {
                    MySqlCommandBuilder mcb = new MySqlCommandBuilder(adapter);
                    adapter.UpdateCommand = mcb.GetUpdateCommand();
                    adapter.Update(changes);
                    ((DataTable)dgvProduct.DataSource).AcceptChanges();

                    MessageBox.Show("Cell Updated");
                    return;
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProduct_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DgvCellUpdated();
        }

        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgvProduct.Rows[index].Selected = true;
        }

        public void DelCell()
        {
            try
            {
                foreach (DataGridViewRow item in this.dgvProduct.SelectedRows)
                {
                    using (MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root"))
                    {
                        MySqlCommand cmd = con.CreateCommand();
                        int id = Convert.ToInt32(dgvProduct.SelectedRows[0].Cells[0].Value);
                        cmd.CommandText = "Delete from test.products where no='" + id.ToString() + "'";

                        dgvProduct.Rows.RemoveAt(this.dgvProduct.SelectedRows[0].Index);
                        con.Open();
                        cmd.ExecuteNonQuery();

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void button3_Click(object sender, EventArgs e)
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

        private void ရငရစရငToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSelling selling = new frmSelling();
            selling.ShowDialog();
            this.Close();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
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
            frmPCoude pc = new frmPCoude();
            pc.ShowDialog();
            this.Close();
        }

        private void moneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOriginal org = new frmOriginal();
            org.ShowDialog();
            this.Close();
        }
    }
}
