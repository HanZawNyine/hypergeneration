using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace L_Khant_000
{
    public partial class frmOreder : Form
    {
        public frmOreder()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost; database=test; user=root;pooling = false; convert zero datetime=True");
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

        private void brnInsert_Click(object sender, EventArgs e)
        {
            string Date = dtpDate.Text.ToString();
            string Customer = txtCustomer.Text.ToString();
            string City = cboCity.Text.ToString();
            string Product = txtProduct.Text.ToString();
            if (Date == "" || Customer == "" || City == "" || Product == "")
            {
                MessageBox.Show("Check Your Input...........................!");
            }
            else
            {
                try
                {
                    con.Open();

                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO test.pre_order (`no`, `order_date`, `customer`, `city`, `product`) VALUES (NULL,@Date,@Customer,@City, @Product);";
                    cmd.Parameters.AddWithValue("@Date", Date);
                    cmd.Parameters.AddWithValue("@Customer", Customer);
                    cmd.Parameters.AddWithValue("@City", City);
                    cmd.Parameters.AddWithValue("@Product", Product);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    DialogResult result = MessageBox.Show("Inserted !!");
                    if (DialogResult.OK == result)
                    {
                        txtCustomer.Clear();
                        //cboAmount.clear();
                        txtProduct.Clear();

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

        private void frmOreder_Load(object sender, EventArgs e)
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
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test.pre_order", con);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "pre_order");
                dgvOreder.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowDatatbase();
            // txtSearch.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
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
                foreach (DataGridViewRow item in this.dgvOreder.SelectedRows)
                {
                    using (MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root"))
                    {
                        MySqlCommand cmd = con.CreateCommand();
                        int id = Convert.ToInt32(dgvOreder.SelectedRows[0].Cells[0].Value);
                        cmd.CommandText = "Delete from test.pre_order where no='" + id.ToString() + "'";

                        dgvOreder.Rows.RemoveAt(this.dgvOreder.SelectedRows[0].Index);
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

        public void DgvCellUpdated()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test.pre_order", con);
                con.Open();

                DataTable changes = ((DataTable)dgvOreder.DataSource).GetChanges();
                if (changes != null)
                {
                    MySqlCommandBuilder mcb = new MySqlCommandBuilder(adapter);
                    adapter.UpdateCommand = mcb.GetUpdateCommand();
                    adapter.Update(changes);
                    ((DataTable)dgvOreder.DataSource).AcceptChanges();

                    MessageBox.Show("Cell Updated");
                    return;
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvOreder_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DgvCellUpdated();
            this.Refresh();
        }

        private void dgvOreder_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgvOreder.Rows[index].Selected = true;
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
                        adapter = new MySqlDataAdapter("SELECT * FROM test.pre_order where no like'" + txt + "'", con);
                        break;
                    case 1:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.pre_order where order_date like'" + txt + "'", con);
                        break;
                    case 2:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.pre_order where customer like'" + txt + "'", con);
                        break;
                    case 3:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.pre_order where city like'" + txt + "'", con);
                        break;
                    case 4:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.pre_order where product like'" + txt + "'", con);
                        break;
                    case 5:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.pre_order where delivery like'" + txt + "'", con);
                        break;

                }
                DataSet ds = new DataSet();
                adapter.Fill(ds, "pre_order");
                dgvOreder.DataSource = ds.Tables[0];
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

        private void dgvOreder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        

        private void createDataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DbCreater();
        }

        public void DbCreater()
        {
            try
            {

                MySqlConnection con = new MySqlConnection("server=localhost; database=test; user=root;pooling = false; convert zero datetime=True");
                MySqlCommand cmd = con.CreateCommand();

                con.Open();
                cmd.CommandText = "create table customer(no INT NOT NULL AUTO_INCREMENT,date VARCHAR(255) NOT NULL,customer_name VARCHAR(255) NOT NULL,number VARCHAR(255) NOT NULL,bought VARCHAR(255) NOT NULL,phone_number VARCHAR(255) NOT NULL,address VARCHAR(255) NOT NULL,facebook_acc VARCHAR(255) NOT NULL,PRIMARY KEY(no )); ";
                cmd.ExecuteNonQuery();
               
                cmd.CommandText = "create table original(no INT NOT NULL AUTO_INCREMENT,date VARCHAR(255) NOT NULL,about VARCHAR(255) NOT NULL,money VARCHAR(255) NOT NULL,PRIMARY KEY(no )); ";
                cmd.ExecuteNonQuery();
                
                cmd.CommandText = "create table pre_order(no INT NOT NULL AUTO_INCREMENT,order_date VARCHAR(255) NOT NULL,customer VARCHAR(255) NOT NULL,city VARCHAR(255) NOT NULL,product VARCHAR(255) NOT NULL,PRIMARY KEY(no )); ";
                cmd.ExecuteNonQuery();
                
                cmd.CommandText = "create table products(no INT NOT NULL AUTO_INCREMENT,date VARCHAR(255) NOT NULL,product_code VARCHAR(255) NOT NULL,product_Number VARCHAR(255) NOT NULL,PRIMARY KEY(no )); ";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "create table product_code(no INT NOT NULL AUTO_INCREMENT,product VARCHAR(255) NOT NULL,whole VARCHAR(255) NOT NULL,price VARCHAR(255) NOT NULL,profit VARCHAR(255) NOT NULL,age VARCHAR(255) NOT NULL,promote VARCHAR(255) NOT NULL,sell VARCHAR(255) NOT NULL,PRIMARY KEY(no )); ";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "create table selling(no INT NOT NULL AUTO_INCREMENT,date VARCHAR(255) NOT NULL,product_code VARCHAR(255) NOT NULL,amount VARCHAR(255) NOT NULL,money VARCHAR(255) NOT NULL,delivery VARCHAR(255) NOT NULL,PRIMARY KEY(no )); ";
                cmd.ExecuteNonQuery();

                con.Close();
                MessageBox.Show("Database Created !\n PLease Click For First Use");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void orderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
