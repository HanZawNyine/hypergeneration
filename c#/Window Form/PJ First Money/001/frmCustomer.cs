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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOreder main=new frmOreder();
            main.ShowDialog();
            this.Close();
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            WindowState = FormWindowState.Maximized;
            ShowDatatbase();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Date = dtpDate.Text.ToString();
            string CustomerName = txtCustomerName.Text.ToString();
            string Number = cboNumber.Text.ToString();
            string Bought = txtBought.Text.ToString();
            string PhoneNumber = txtPhoneNumber.Text.ToString();
            string Address = txtAddress.Text.ToString();
            string FbAcc = txtFbAcc.Text.ToString();
            if(Date==""||CustomerName==""||Number==""||Bought==""||PhoneNumber==""||Address==""||FbAcc=="")
            {
                MessageBox.Show("Check Your Input !!");
            }else
            {
                try
                {
                    MySqlConnection con = new MySqlConnection("server=localhost; database=test; user=root;pooling = false; convert zero datetime=True");

                    con.Open();

                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO `customer` (`no`, `date`, `customer_name`, `number`, `bought`, `phone_number`, `address`, `facebook_acc`) VALUES (NULL, @Date, @CustomerName, @Number, @Bought, @PhoneNumber, @Address,@FacebookAcc);";
                    cmd.Parameters.AddWithValue("@Date", Date);
                    cmd.Parameters.AddWithValue("@CustomerName", CustomerName);
                    cmd.Parameters.AddWithValue("@Number", Number);
                    cmd.Parameters.AddWithValue("@Bought", Bought);
                    cmd.Parameters.AddWithValue("@PhoneNumber", PhoneNumber);
                    cmd.Parameters.AddWithValue("@Address", Address);
                    cmd.Parameters.AddWithValue("@FacebookAcc", FbAcc);
                    
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DialogResult result = MessageBox.Show("Inserted !!");
                    if (DialogResult.OK == result)
                    {
                        txtCustomerName.Clear();
                        //cboAmount.clear();
                        txtBought.Clear();
                        txtPhoneNumber.Clear();
                        txtAddress.Clear();
                        txtFbAcc.Clear();
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

        public void ShowDatatbase()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test.customer", con);
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

        private void dgvCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void DgvCellUpdated()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test.customer", con);
                con.Open();

                DataTable changes = ((DataTable)dgvCustomer.DataSource).GetChanges();
                if (changes != null)
                {
                    MySqlCommandBuilder mcb = new MySqlCommandBuilder(adapter);
                    adapter.UpdateCommand = mcb.GetUpdateCommand();
                    adapter.Update(changes);
                    ((DataTable)dgvCustomer.DataSource).AcceptChanges();

                    MessageBox.Show("Cell Updated");
                    return;
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvCustomer_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            DgvCellUpdated();
        }

        private void dgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgvCustomer.Rows[index].Selected = true;
        }

        private void button3_Click(object sender, EventArgs e)
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
                foreach (DataGridViewRow item in this.dgvCustomer.SelectedRows)
                {
                    using (MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root"))
                    {
                        MySqlCommand cmd = con.CreateCommand();
                        int id = Convert.ToInt32(dgvCustomer.SelectedRows[0].Cells[0].Value);
                        cmd.CommandText = "Delete from test.selling where no='" + id.ToString() + "'";

                        dgvCustomer.Rows.RemoveAt(this.dgvCustomer.SelectedRows[0].Index);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowDatatbase(); 
           // txtSearch.Clear();
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
                case 4: select = 4; break;
                case 5: select = 5; break;
                case 6: select = 6; break;
                case 7: select = 7; break;




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
                        adapter = new MySqlDataAdapter("SELECT * FROM test.customer where no like'" + txt + "'", con);
                        break;
                    case 1:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.customer where date like'" + txt + "'", con);
                        break;
                    case 2:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.customer where customer_name like'" + txt + "'", con);
                        break;
                    case 3:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.customer where number like'" + txt + "'", con);
                        break;
                    case 4:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.customer where bought like'" + txt + "'", con);
                        break;
                    case 5:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.customer where phone_number like'" + txt + "'", con);
                        break;
                    case 6:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.customer where address like'" + txt + "'", con);
                        break;
                    case 7:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.customer where facebook_acc like'" + txt + "'", con);
                        break;

                }
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
            this.Refresh();
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmOreder order=new frmOreder();
            order.ShowDialog();
            this.Close();
        }

        private void productsCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

            this.Hide();
            frmOriginal org = new frmOriginal();
            org.ShowDialog();
            this.Close();
        }
    }
}
