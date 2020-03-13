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

namespace Han_Zaw_Nyine
{
    public partial class frmAll : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root;database=register");
        MySqlCommand cmd = new MySqlCommand();
        MySqlDataReader dataSearch;

        
        
        public frmAll()
        {
            InitializeComponent();
        }

        private void frmAll_Load(object sender, EventArgs e)
        {
         // cmd.Connection = con;
           // txtId.Enabled = false;
          //  view();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            insert();
            view();

        }


        private void btnView_Click(object sender, EventArgs e)
        {
            view();
        }

        private void lbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox list = sender as ListBox;
            if(list.SelectedIndex !=0)
            {
                lbID.SelectedIndex = list.SelectedIndex;
                lbName.SelectedIndex = list.SelectedIndex;
                lbFather.SelectedIndex = list.SelectedIndex;
                lbMobile.SelectedIndex = list.SelectedIndex;
                lbDate.SelectedIndex = list.SelectedIndex;
                lbGender.SelectedIndex = list.SelectedIndex;

                txtId.Enabled = true;

                txtId.Text = lbID.SelectedItem.ToString();
                txtName.Text = lbName.SelectedItem.ToString();
                txtFather.Text = lbFather.SelectedItem.ToString();
                txtMobile.Text = lbMobile.SelectedItem.ToString();
                dtp.Value = DateTime.Now;
                cboGender.Text = lbGender.SelectedItem.ToString();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            update();
            view();
        }
        public void insert()
        {          
                string id  = txtId.Text.ToString();
                string name = txtName.Text.ToString();
                string father = txtFather.Text.ToString();
                string mobile = txtMobile.Text.ToString();
                string date = dtp.Text.ToString();
                string gender = cboGender.Text.ToString();

                try
                 {
                     con.Open();
                    MySqlCommand cmd = new MySqlCommand("INSERT INTO register.register (`id`, `name`, `father`, `mobile`, `date`, `gender`) VALUES (NULL, @name, @father, @mobile, @date, @gender)");
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@father", father);
                    cmd.Parameters.AddWithValue("@mobile", mobile);
                    cmd.Parameters.AddWithValue("@date", date);
                    cmd.Parameters.AddWithValue("@gender", gender);


                    cmd.CommandType = CommandType.Text;
                    cmd.ExecuteReader();
                    ///con.Close();
                    MessageBox.Show("Data Inserted =====>>> !!!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            
            //txtId.Clear();
            //txtName.Clear();
            //txtMobile.Clear();
            //txtFather.Clear();
            //dtp.Value = DateTime.Now;
            //cboGender.SelectedIndex = -1;

        }
        public void view()
        {
            try
            {
                lbID.Items.Clear();
                lbDate.Items.Clear();
                lbName.Items.Clear();
                lbFather.Items.Clear();
                
                lbMobile.Items.Clear();
                lbGender.Items.Clear();

                con.Open();
                MySqlCommand cmd = new MySqlCommand("select * from register.register", con);

                dataSearch = cmd.ExecuteReader();

                while (dataSearch.Read())
                {
                    lbID.Items.Add(dataSearch["id"].ToString());
                    lbName.Items.Add(dataSearch["name"].ToString());
                    lbFather.Items.Add(dataSearch["father"].ToString());
                    lbMobile.Items.Add(dataSearch["mobile"].ToString());
                    lbDate.Items.Add(dataSearch["date"].ToString());
                    lbGender.Items.Add(dataSearch["gender"].ToString());
                }

                con.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public void update()
        {
            if (txtName.Text != "" & txtFather.Text != "" & txtMobile.Text != "" & dtp.Text != "" & cboGender.Text != "")
            {
                string id2 = txtId.Text.ToString();
                string name2 = txtName.Text.ToString();
                string father2 = txtFather.Text.ToString();
                string mobile2 = txtMobile.Text.ToString();
                string date2 = dtp.Text.ToString();
                string gender2 = cboGender.Text.ToString();

                string id = lbID.Text.ToString();
                string name = lbName.Text.ToString();
                string father = lbFather.Text.ToString();
                string mobile = lbMobile.Text.ToString();
                string date = lbDate.Text.ToString();
                string gender = lbGender.Text.ToString();

                try
                {
                    
                    MySqlCommand cmd = new MySqlCommand("update", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_id", id);
                    cmd.Parameters.AddWithValue("_id2", id2);
                    cmd.Parameters.AddWithValue("_name", name);
                    cmd.Parameters.AddWithValue("_name2", name2);
                    cmd.Parameters.AddWithValue("_father", father);
                    cmd.Parameters.AddWithValue("_father2", father2);
                    cmd.Parameters.AddWithValue("_mobile", mobile);
                    cmd.Parameters.AddWithValue("_mobile2", mobile2);
                    cmd.Parameters.AddWithValue("_date", date);
                    cmd.Parameters.AddWithValue("_date2", date2);
                    cmd.Parameters.AddWithValue("_gender", gender);
                    cmd.Parameters.AddWithValue("_gender2", gender2);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Updated =====>>> !!!");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Check Your Input !!");
            }
            txtId.Clear();
            txtName.Clear();
            txtMobile.Clear();
            txtFather.Clear();
            dtp.Value = DateTime.Now;
            cboGender.SelectedIndex = -1;

        }
        public void delete()
        {
            lbID.Items.Clear();
            lbDate.Items.Clear();
            lbName.Items.Clear();
            lbFather.Items.Clear();
            lbDate.Items.Clear();
            lbGender.Items.Clear();


            string id = lbID.Text.ToString();
            string name = lbName.Text.ToString();
            string father = lbFather.Text.ToString();
            string mobile = lbMobile.Text.ToString();
            string date = lbDate.Text.ToString();
            string gender = lbGender.Text.ToString();

            var result = MessageBox.Show("Are You Sure !", "Delete(Warning)", MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                try
                {
                    MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                    MySqlDataAdapter adapter=new MySqlDataAdapter("delete",con);

                    //MySqlCommand cmd = new MySqlCommand("delete", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("_id", id);
                    cmd.Parameters.AddWithValue("_name", name);
                    cmd.Parameters.AddWithValue("_father", father);
                    cmd.Parameters.AddWithValue("_mobile", mobile);
                    cmd.Parameters.AddWithValue("_date", date);
                    cmd.Parameters.AddWithValue("_gender", gender);
                    con.Open();
                    DataSet ds = new DataSet();
                    //MySqlDataAdapter adapter;
                    adapter.Fill(ds, "register");
                    lbID.DataSource = ds.Tables["_id"];
                    lbName.DataSource = ds.Tables["_name"];
                    lbName.DataSource = ds.Tables["_father"];
                    lbMobile.DataSource = ds.Tables["_mobile"];
                    lbDate.DataSource = ds.Tables["_date"];
                    lbGender.DataSource = ds.Tables["_gender"];


                    //con.Close();
                    //dataSearch = cmd.ExecuteReader();
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Deleted!!");
            }
            else if(result == DialogResult.No)
            {
                MessageBox.Show("Cancel");

            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            delete();
            view();
        }
    }
}
