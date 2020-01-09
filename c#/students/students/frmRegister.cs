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

namespace students
{
    
    public partial class frmRegister : Form
    {
        MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");

        public frmRegister()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void lblNationalid_Click(object sender, EventArgs e)
        {

        }

        private void txtNationalid_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblDateofbirth_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtFathername.Focus();
            }
        }

        private void txtFathername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                txtStudentsid.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_3(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
           
            string username    =txtUsername.Text.ToString();
            string fathername  = txtFathername.Text.ToString();
            string studentid   = txtStudentsid.Text.ToString();
            string nationalid  = txtNationalid.Text.ToString();
            string dateofbirth = dtpDateofbirth.Text.ToString();
            string section     = lbSection.Text.ToString();
            string major       = lbMajor.Text.ToString();
            string startdate   = dtpStartdate.Text.ToString();
            string year        = lblYear.Text.ToString();
            string university  = txtUniversity.Text.ToString();
            string phoneno     = txtPhoneno.Text.ToString();
            string gmail       = txtgmail.Text.ToString();
            string adress      = txtAdress.Text.ToString();
            if(username == ""||fathername==""||studentid==""||dateofbirth==""||major==""||year==""||university==""||phoneno=="")
            {
                MessageBox.Show("Check Your Input");
            }
            else
            {
                try {
                    con.Open();
                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = "INSERT INTO schoolidea.students_info(UserName,FatherName,StudentsID,NationalID,DateOfBirth,Section,Major,StartDate,Year,University,PhoneNumber,Gmail,Adress)" +
                        "Values(@username,@fathername,@studentid,@nationalid,@dateofbirth,@section,@major,@startdate,@year," +
                        "@university,@phoneno,@gmail,@adress)";

                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@fathername",fathername);
                    cmd.Parameters.AddWithValue("@studentid", studentid);
                    cmd.Parameters.AddWithValue("@nationalid",nationalid);
                    cmd.Parameters.AddWithValue("@dateofbirth",dateofbirth);
                    cmd.Parameters.AddWithValue("@section", section);
                    cmd.Parameters.AddWithValue("@major", major);
                    cmd.Parameters.AddWithValue("@startdate", startdate);
                    cmd.Parameters.AddWithValue("@year",year);
                    cmd.Parameters.AddWithValue("@university", university);
                    cmd.Parameters.AddWithValue("@phonenoh", phoneno);
                    cmd.Parameters.AddWithValue("@gmail",gmail);
                    cmd.Parameters.AddWithValue("@adress", adress);
                    
                   

                }
                catch
                {
               
                    con.Close();
                }
            }
            
            
        }

        private void txtStartdate_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPhoneno_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStartdate_Click(object sender, EventArgs e)
        {

        }

        private void lblGmail_Click(object sender, EventArgs e)
        {

        }

        private void lblAdress_Click(object sender, EventArgs e)
        {

        }

        private void txtUniversity_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbUniversity_Click(object sender, EventArgs e)
        {

        }
    }
}
