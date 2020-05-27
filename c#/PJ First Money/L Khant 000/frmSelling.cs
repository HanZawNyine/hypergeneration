using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;

namespace L_Khant_000
{
    public partial class frmSelling : Form
    {
        public frmSelling()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost; database=test; user=root;pooling = false; convert zero datetime=True");

        
        private void brnInsert_Click(object sender, EventArgs e)
        {
            string Date = dtpDate.Text.ToString();
            string ProductCode = txtProductCode.Text.ToString();
            string Amount = cboAmount.Text.ToString();
            string Money = txtmoney.Text.ToString();
            string Delivery = txtDelivery.Text.ToString();
            if (Date == "" || ProductCode == "" || Amount == "" || Money == "" || Delivery == "")
            {
                MessageBox.Show("Check Your Input...........................!");

            }
            else
            {
                try
                {
                    //MySqlConnection con = new MySqlConnection("server=localhost; database=linkhant; user=root;pooling = false; convert zero datetime=True");

                    con.Open();

                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO test.selling(`no`, `date`, `product_code`, `amount`, `money`, `delivery`) VALUES (NULL,@Date, @ProductCode, @Amount, @Money, @Delivery);";
                    cmd.Parameters.AddWithValue("@Date", Date);
                    cmd.Parameters.AddWithValue("@ProductCode", ProductCode);
                    cmd.Parameters.AddWithValue("@Amount", Amount);
                    cmd.Parameters.AddWithValue("@Money", Money);
                    cmd.Parameters.AddWithValue("@Delivery", Delivery);

                    cmd.ExecuteNonQuery();
                    con.Close();
                    DialogResult result = MessageBox.Show("Inserted !!");
                    if (DialogResult.OK == result)
                    {
                        txtProductCode.Clear();
                        //cboAmount.clear();
                        txtmoney.Clear();
                        txtDelivery.Clear();
                        txtSearch.Clear();
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

        private void dgvSelling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        public void ShowDatatbase()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test.selling", con);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "selling");
                dgvSelling.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            WindowState = FormWindowState.Maximized;
            ShowDatatbase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ShowDatatbase();
            txtSearch.Clear();
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
                        adapter = new MySqlDataAdapter("SELECT * FROM test.selling where no like'" + txt + "'", con);
                        break;
                    case 1:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.selling where date like'" + txt + "'", con);
                        break;
                    case 2:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.selling where product_code like'" + txt + "'", con);
                        break;
                    case 3:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.selling where amount like'" + txt + "'", con);
                        break;
                    case 4:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.selling where money like'" + txt + "'", con);
                        break;
                    case 5:
                        adapter = new MySqlDataAdapter("SELECT * FROM test.selling where delivery like'" + txt + "'", con);
                        break;

                }
                DataSet ds = new DataSet();
                adapter.Fill(ds, "selling");
                dgvSelling.DataSource = ds.Tables[0];
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        

        private void dgvSelling_Enter(object sender, EventArgs e)
        {

        }

        private void dgvSelling_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void dgvSelling_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            dgvSelling.Update();
            dgvSelling.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvSelling_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DgvCellUpdated();
            this.Refresh();
        }

        public void DgvCellUpdated()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test.selling", con);
                con.Open();

                DataTable changes = ((DataTable)dgvSelling.DataSource).GetChanges();
                if (changes != null)
                {
                    MySqlCommandBuilder mcb = new MySqlCommandBuilder(adapter);
                    adapter.UpdateCommand = mcb.GetUpdateCommand();
                    adapter.Update(changes);
                    ((DataTable)dgvSelling.DataSource).AcceptChanges();

                    MessageBox.Show("Cell Updated");
                    return;
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvSelling_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgvSelling.Rows[index].Selected = true;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //DELETE FROM `selling` WHERE `selling`.`no` = 6;

            
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
                foreach (DataGridViewRow item in this.dgvSelling.SelectedRows)
                {
                    using (MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root"))
                    {
                        MySqlCommand cmd = con.CreateCommand();
                        int id = Convert.ToInt32(dgvSelling.SelectedRows[0].Cells[0].Value);
                        cmd.CommandText = "Delete from test.selling where no='" + id.ToString() + "'";

                        dgvSelling.Rows.RemoveAt(this.dgvSelling.SelectedRows[0].Index);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
           DialogResult dialogResult = MessageBox.Show("Are You Sure To Exit ?","", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else 
            {
                this.Refresh();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmOreder main = new frmOreder();
            main.ShowDialog();
            this.Close();
        }

        private void ရငရစရငToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Refresh();

        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProduct Pd = new frmProduct();
            Pd.ShowDialog();
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

        private void createDataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateText();
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

        private void restoreDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreMySql();

        }
        public void BackUpMySql()
        {
            string constring = "server=localhost; database=test; user=root;pooling = false; convert zero datetime=True";

            // Important Additional Connection Options
            // constring += "charset=utf8;convertzerodatetime=true;";

            string file = "C:\\Users\\Han Zaw\\Documents\\backup.sql";

            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ExportToFile(file);
                        conn.Close();
                        MessageBox.Show("Export BackUp File in C:\\Users\\Han Zaw\\Documents\\backup.sql");
                    }
                }
            }
        }

        public void RestoreMySql()
        {
            string constring = "server=localhost; database=test; user=root;pooling = false; convert zero datetime=True";

            // Important Additional Connection Options
            // constring += "charset=utf8;convertzerodatetime=true;";

            string file = "C:\\Users\\Han Zaw\\Documents\\backup.sql";

            using (MySqlConnection conn = new MySqlConnection(constring))
            {
                using (MySqlCommand cmd = new MySqlCommand())
                {
                    using (MySqlBackup mb = new MySqlBackup(cmd))
                    {
                        cmd.Connection = conn;
                        conn.Open();
                        mb.ImportFromFile(file);
                        conn.Close();
                        MessageBox.Show("Import BackUp File From C:\\Users\\Han Zaw\\Documents\\backup.sql");
                    }
                }
            }
        }

        private void exportDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackUpMySql();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        public void CreateText()
        {
            string fileName = @"C:\\Users\\Han Zaw\\Documents\\backup.sql";

            try
            {
                // Check if file already exists. If yes, delete it.     
                if (File.Exists(fileName))
                {
                    File.Delete(fileName);
                }

                // Create a new file     
                using (FileStream fs = File.Create(fileName))
                {
                    // Add some text to file    
                    Byte[] title = new UTF8Encoding(true).GetBytes("New Text File");
                    fs.Write(title, 0, title.Length);
                    byte[] author = new UTF8Encoding(true).GetBytes("Mahesh Chand");
                    fs.Write(author, 0, author.Length);
                }

                // Open the stream and read it back.    
                using (StreamReader sr = File.OpenText(fileName))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(s);
                    }
                }
                MessageBox.Show("Create a sql file for BackUp and Restore in C:\\Users\\Han Zaw\\Documents\\backup.sql");
            }
            catch (Exception Ex)
            {
                Console.WriteLine(Ex.ToString());
            }
        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void printDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}


