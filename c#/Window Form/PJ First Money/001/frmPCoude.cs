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
    public partial class frmPCoude : Form
    {
        public frmPCoude()
        {
            InitializeComponent();
        }

        private void frmPCoude_Load(object sender, EventArgs e)
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
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test.product_code", con);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "product_code");
                dgvProduct.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            string Product = txtProduct.Text.ToString();
            string Whole = txtWhole.Text.ToString();
            string Price = txtPrice.Text.ToString();
            string Profit = txtProfit.Text.ToString();
            string Age = txtAge.Text.ToString();
            string Promote = txtPromote.Text.ToString();
            string Sell = txtSell.Text.ToString();
            if(Product==""||Whole==""||Price==""||Profit==""||Age==""||Promote==""||Sell=="")
            {
                MessageBox.Show("Check Your Input...........................!");
            }
            else
            {
                MySqlConnection con = new MySqlConnection("server=localhost; database=test; user=root;pooling = false; convert zero datetime=True");

                con.Open();

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO test.product_code (`no`, `product`, `whole`, `price`, `profit`, `age`, `promote`, `sell`) VALUES (NULL,@Product,@Whole, @Price, @Profit,@Age,@Promote,@Sell);";
                cmd.Parameters.AddWithValue("@Product",Product);
                cmd.Parameters.AddWithValue("@Whole", Whole);
                cmd.Parameters.AddWithValue("@Price", Price);
                cmd.Parameters.AddWithValue("@Profit", Profit);
                cmd.Parameters.AddWithValue("@Age", Age);
                cmd.Parameters.AddWithValue("@Promote", Promote);
                cmd.Parameters.AddWithValue("@Sell", Sell);
                
                cmd.ExecuteNonQuery();
                con.Close();
                DialogResult result = MessageBox.Show("Inserted !!");
                if (DialogResult.OK == result)
                {
                    txtProduct.Clear();
                    //cboAmount.clear();
                    txtPrice.Clear();
                    txtAge.Clear();
                    txtProfit.Clear();
                    txtPromote.Clear();
                    txtSell.Clear();
                    txtWhole.Clear();
                    ShowDatatbase();
                    //txtSearch.Clear();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ShowDatatbase();
           // txtSearch.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOreder main = new frmOreder();
            main.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
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
                            cmd.CommandText = "Delete from test.product_code where no='" + id.ToString() + "'";

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

        private void dgvProduct_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DgvCellUpdated();
            this.Refresh();

        }
        public void DgvCellUpdated()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test.product_code", con);
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

        private void dgvProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgvProduct.Rows[index].Selected = true;
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
                case 3: select = 3; break;
                case 4: select = 4; break;
                case 5: select = 5; break;
                case 6: select = 6; break;
                case 7: select = 7; break;
               // case 5: select = 5; break;



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
                        adapter = new MySqlDataAdapter("SELECT * FROM test.product_code where no like'" + txt + "'", con);
                        break;
                    case 1:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.product_code where product like'" + txt + "'", con);
                        break;
                    case 2:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.product_code where whole like'" + txt + "'", con);
                        break;
                    case 3:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.product_code where price like'" + txt + "'", con);
                        break;
                    case 4:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.product_code where profit like'" + txt + "'", con);
                        break;
                    case 5:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.product_code where age like'" + txt + "'", con);
                        break;
                    case 6:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.product_code where prmote like'" + txt + "'", con);
                        break;
                    case 7:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.product_code where sell like'" + txt + "'", con);
                        break;

                }
                DataSet ds = new DataSet();
                adapter.Fill(ds, "product_code");
                dgvProduct.DataSource = ds.Tables[0];
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
            this.Refresh();
        }

        private void moneyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOriginal org = new frmOriginal();
            org.ShowDialog();
            this.Close();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
