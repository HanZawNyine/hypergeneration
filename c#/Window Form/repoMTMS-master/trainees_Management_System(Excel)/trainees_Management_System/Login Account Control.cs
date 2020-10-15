using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql_Database_Class;

namespace trainees_Management_System
{
    public partial class Login_Account_Control : Form
    {
        public Login_Account_Control()
        {
            InitializeComponent();

        }
        string Action = "";
        MySqlDB mysql = new MySqlDB();
        string server_pass = "";
        DataSet dst;

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            CheckAction(Action);
           
        }

        private void CheckAction(string action)
        {
            try
            {
                switch (action)
                {
                    case "Insert":
                        if(CheckAuth() && (txtNewPass.Text == txtConfirmPass.Text))
                        {
                            mysql.cmdText = "insert into auth (uname,pass) values ('" + txtNewUser.Text + "','" + txtNewPass.Text + "')";
                            mysql.insert();
                            Refresh();
                            MessageBox.Show("New account is successfully added", "Login Account");
                        }
                      
                        break;
                    case "Update":
                        if (CheckAuth() && (txtNewPass.Text == txtConfirmPass.Text))
                        {
                            mysql.cmdText = "update auth set uname = '" + txtNewUser.Text + "',pass='" + txtNewPass.Text + "' where uname='" + txtOldUser.Text + "'";
                            mysql.DataBind();
                            Refresh();
                            MessageBox.Show("Account is successfully updated", "Login Account");
                        }
                       
                        break;
                    case "Delete":
                        if(!string.Equals(txtOldUser.Text,""))
                        {
                            mysql.cmdText = "delete from auth where uname='" + txtOldUser.Text + "'";
                            mysql.DataBind();
                            Refresh();
                            MessageBox.Show("Account is successfully removed", "Login Account");
                        }
                       
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Refresh()
        {
            try
            {
                dataGridView1.Rows.Clear();
                dst = new DataSet();

                mysql.cmdText = "select * from auth";
                mysql.tablename = "auth";
                mysql.DataBind();

                dst = mysql.dst;
                int row = dst.Tables["auth"].Rows.Count;
                dataGridView1.Rows.Add(row);

                if (dst.Tables["auth"].Rows.Count > 0)
                {
                    for (int i = 0; i < dst.Tables["auth"].Rows.Count; i++)
                    {
                        dataGridView1.Rows[i].Cells[0].Value = dst.Tables["auth"].Rows[i]["uname"].ToString();
                        dataGridView1.Rows[i].Cells[1].Value = dst.Tables["auth"].Rows[i]["pass"].ToString();
                    }
                }
                dst.Clear();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        
        private void rdoInsert_CheckedChanged(object sender, EventArgs e)
        {
            Action = "Insert";
            txtOldUser.Enabled = false;
            txtOldPass.Enabled = false;
            txtNewUser.Enabled = true;
            txtNewPass.Enabled = true;
            txtConfirmPass.Enabled = true;
        }

        private void rdoUpdate_CheckedChanged(object sender, EventArgs e)
        {
            Action = "Update";
            txtOldUser.Enabled = true;
            txtOldPass.Enabled = false;
            txtNewUser.Enabled = true;
            txtNewPass.Enabled = true;
            txtConfirmPass.Enabled = true;
        }

        private void rdoDelete_CheckedChanged(object sender, EventArgs e)
        {
            Action = "Delete";
            txtOldPass.Enabled = false;
            txtNewUser.Enabled = false;
            txtNewPass.Enabled = false;
            txtConfirmPass.Enabled = false;
        }

        private bool CheckAuth()
        {
            bool val = false;

            foreach (Control c in this.groupBox1.Controls)
            {
                if (c is TextBox)
                { 
                    if(c.Text == "")
                    {
                        val = false;
                    }
                }
            }
            return val;
        }

        private void Login_Account_Control_Load(object sender, EventArgs e)
        {
            mysql.constring = "Data Source= localhost;Database=engineering_school;User ID=root;Password=" + server_pass + ";charset=utf8";
            Refresh();  
        }

        private void txtNewUser_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
