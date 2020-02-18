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

namespace OOpInCs
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            InOop ins = new InOop();
            ins.name = txtName.Text.ToString();
            ins.fathername = txtFatherName.Text.ToString();
            ins.mobile = txtMobile.Text.ToString();
            ins.dateofbirth = dtpDateOFBirth.Text.ToString();
            ins.gender = cboGender.Text.ToString();
            ins.insert();
            MessageBox.Show("registered !");





        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int select = 0;
            InOop ins = new InOop();
            string txt = txtSearch.Text.ToString();
            ins.funSearchTitle(txt, select);
            switch (cboSearch.SelectedIndex)
            {
                case 0: select = 0; break;
                case 1: select = 1; break;
                case 2: select = 2; break;
                case 3: select = 3; break;
                case 4: select = 4; break;
                case 5: select = 5; break;                
            }      
            dgvRegister.DataSource = ins.ds.Tables[0];



        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            InOop ins = new InOop();
            ins.ShowDatatbase();           
            dgvRegister.DataSource = ins.ds.Tables[0];
           

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFatherName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFatherNmae_Click(object sender, EventArgs e)
        {

        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMobile_Click(object sender, EventArgs e)
        {

        }

        private void lblDateOfBirth_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void cboGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvRegister_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dtpDateOFBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmUpdate fU = new frmUpdate();
            fU.ShowDialog();
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
    class InOop
     {
        public string name;
        public string fathername;
        public string mobile;
        public string dateofbirth;
        public string gender;



        
        public MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
        public MySqlDataAdapter adapter;
        public DataSet ds = new DataSet();

        //mysql search function
        public void funSearchTitle(string txt, int title)
        {


            try
            {

                //MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                con.Open();
                //MySqlDataAdapter adapte MySqlDataAdapter("SELECT * FROM lab.lab where done like'" + txt + "'", con);

                switch (title)
                {

                    case 0:
                        adapter = new MySqlDataAdapter("SELECT * FROM phone.cs where id like'" + txt + "'", con);
                        break;
                    case 1:
                        adapter = new MySqlDataAdapter("SELECT * FROM phone.cs where name like'" + txt + "'", con);
                        break;
                    case 2:
                        adapter = new MySqlDataAdapter("SELECT * FROM phone.cs where farther like'" + txt + "'", con);
                        break;
                    case 3:
                        adapter = new MySqlDataAdapter("SELECT * FROM phone.cs where mobile like'" + txt + "'", con);
                        break;
                    case 4:
                        adapter = new MySqlDataAdapter("SELECT * FROM phone.cs where date like'" + txt + "'", con);
                        break;
                    case 5:
                        adapter = new MySqlDataAdapter("SELECT * FROM phone.cs where gender like'" + txt + "'", con);
                        break;      

                }
                adapter.Fill(ds, "cs");
                con.Close();
                
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //mysql insert
        public void insert()
        {


            try
            {

                //MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO phone.cs (`id`, `name`, `farther`, `mobile`, `date`, `gender`) VALUES (NULL,@name,@fathername,@mobile,@dateofbirth,@gender)";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@fathername", fathername);
                cmd.Parameters.AddWithValue("@mobile", mobile);
                cmd.Parameters.AddWithValue("@dateofbirth", dateofbirth);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.ExecuteNonQuery();
                con.Close();               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //mysql  refresh        
        public void ShowDatatbase()
        {
           try
           {
                    //MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM phone.cs", con);
                con.Open();

                adapter.Fill(ds, "cs");
                con.Close();

            }
           catch (Exception ex)
           {
           MessageBox.Show(ex.Message);
           }
       
        }

        //mysql update

        public void Update()
        {
            MySqlCommand cmd = con.CreateCommand();

        }



    }
}
