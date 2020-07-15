using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace POS_01
{
    public partial class frmInsert : Form
    {
        public frmInsert()
        {
            InitializeComponent();
        }
        MySqlConnection con = new MySqlConnection("server=localhost; port=3306; database=aa; user=root;");

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        string pass;
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "" || txtFather.Text == "" || txtPhoneNo.Text == "" || txtPassword.Text == "" || txtConfirm.Text == "")
            {
                MessageBox.Show("Check your input");
            }
            else
            {
                if (txtPassword.Text == txtConfirm.Text)
                {
                    pass = txtPassword.Text.ToString();
                    DataInsert();
                    txtName.Clear();
                    txtFather.Clear();
                    txtPassword.Clear();
                    txtConfirm.Clear();
                    txtPhoneNo.Clear();
                }
                else
                {
                    MessageBox.Show("password  can't match !");

                }



            }


        }
        public void DataInsert()
        {
            string Name = txtName.Text.ToString();
            string date = dtpBirth.Text.ToString();
            string father = txtFather.Text.ToString();
            string age = cboAge.Text.ToString();
            string phone = txtPhoneNo.Text.ToString();
            string gender = cboGender.Text.ToString();
            try
            {
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO `bb` (`id`, `name`, `date_of_birth`, `fathername`, `age`," +
                    " `phone_number`, `gender`, `password`) VALUES (NULL, @Name, @Date, @father, @age," +
                    " @Phoneno, @gender, @Password);";

                cmd.Parameters.AddWithValue("@Name", Name);
                cmd.Parameters.AddWithValue("@Date", date);
                cmd.Parameters.AddWithValue("@father", father);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@Phoneno", phone);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.Parameters.AddWithValue("@Password", pass);
                cmd.ExecuteNonQuery();
                con.Close();
                DialogResult result = MessageBox.Show("Data Inserted !");
                if (DialogResult.OK == result)
                {
                    ShowDatabase();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void ShowDatabase()
        {
            try
            {
                MySqlDataAdapter adapter = new MySqlDataAdapter("select * from bb", con);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "bb");
                dgvShow.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {



        }

        private void frmInsert_Load(object sender, EventArgs e)
        {
            ShowDatabase();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            txtConfirm.PasswordChar = '*';
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtPhoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            int index = e.RowIndex;
            dgvShow.Rows[index].Selected = true;

        }
        int id;
        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("", "Are you sure to Delete ?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Data  Deleted ");
                Del();
                ShowDatabase();
            }
            else
            {
                this.Refresh();
            }
            // Del();
        }

        public void Del()
        {
            try
            {
                foreach (DataGridViewRow item in this.dgvShow.SelectedRows)
                {
                    using (MySqlConnection con = new MySqlConnection("datasource = localhost; port=3306; username=root;"))
                    {
                        MySqlCommand cmd = con.CreateCommand();
                        id = Convert.ToInt32(dgvShow.SelectedRows[0].Cells[0].Value);
                        cmd.CommandText = "DELETE FROM aa.bb WHERE id ='" + id.ToString() + "'";
                        dgvShow.Rows.RemoveAt(this.dgvShow.SelectedRows[0].Index);
                        con.Open();
                        cmd.ExecuteNonQuery();
                        //MessageBox.Show("Data Delete");
                        con.Close();

                    }

                }




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvShow_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dtpBirth.Focus();
            }
        }

        private void dtpBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpBirth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtFather.Focus();
            }
        }

        private void txtFather_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                cboAge.Focus();
            }
        }

        private void cboAge_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtPhoneNo.Focus();
            }
        }

        private void txtPhoneNo_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                cboGender.Focus();
            }
        }

        private void cboGender_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void txtConfirm_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                btnInsert.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                txtConfirm.Focus();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
        // int select = 0;

        private void btnSearch_Click_1(object sender, EventArgs e)
        {




        }


        private void button2_Click(object sender, EventArgs e)
        {
            ShowDatabase();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        int select = 0;
        private void btnSearch_Click_2(object sender, EventArgs e)
        {
            string txt = txtSearch.Text.ToString();
            Search(txt, select);
            switch (select)
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

        public void Search(string txt, int title)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource= localhost; port=3306; username=root;");
                con.Open();
                switch (title)
                {
                    case 0: adapter = new MySqlDataAdapter("select * from aa.bb where  id like '" + txt + "'", con); break;
                    case 1: adapter = new MySqlDataAdapter("select * from aa.bb where  name like '" + txt + "'", con); break;
                    case 2: adapter = new MySqlDataAdapter("select * from aa.bb where  date_of_birth like '" + txt + "'", con); break;
                    case 3: adapter = new MySqlDataAdapter("select * from aa.bb where  fathername like '" + txt + "'", con); break;
                    case 4: adapter = new MySqlDataAdapter("select * from aa.bb where  age like '" + txt + "'", con); break;
                    case 5: adapter = new MySqlDataAdapter("select * from aa.bb where  phone_number like '" + txt + "'", con); break;
                    case 6: adapter = new MySqlDataAdapter("select * from aa.bb where  gender like '" + txt + "'", con); break;

                }
                DataSet ds = new DataSet();
                adapter.Fill(ds, "bb");
                dgvShow.DataSource = ds.Tables[0];
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cboSearch_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ShowDatabase();
        }

        private void dgvShow_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            CellUpdate();
        }

        public void CellUpdate()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;");
                MySqlDataAdapter adapter = new MySqlDataAdapter("select * from aa.bb", con);
                con.Open();
                DataTable changes = ((DataTable)dgvShow.DataSource).GetChanges();
                if(changes != null)
                {
                    MySqlCommandBuilder mcb = new MySqlCommandBuilder(adapter);
                    adapter.UpdateCommand = mcb.GetUpdateCommand();
                    adapter.Update(changes);
                    ((DataTable)dgvShow.DataSource).AcceptChanges();
                    MessageBox.Show("Data Update");  
                }
                con.Close();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void createDataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DbCreater();
            ShowDatabase();
        }

        public void DbCreater()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;");
                MySqlCommand cmd = con.CreateCommand();
                con.Open();
                //"INSERT INTO `bb` (`id`, `name`, `date_of_birth`, `fathername`, `age`," +
                //    " `phone_number`, `gender`, `password`) VALUES (NULL, @Name, @Date, @father, @age," +
                //    " @Phoneno, @gender, @Password);";
                cmd.CommandText = "create table aa.bb(id INT NOT NULL AUTO_INCREMENT,name VARCHAR(255) NOT NULL,date_of_birth VARCHAR(255) NOT NULL,fathername VARCHAR(255) NOT NULL,age VARCHAR(255) NOT NULL,phone_number VARCHAR(255) NOT NULL,gender VARCHAR(255) NOT NULL,password VARCHAR(255) NOT NULL, PRIMARY KEY(id));";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Database Created !");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
