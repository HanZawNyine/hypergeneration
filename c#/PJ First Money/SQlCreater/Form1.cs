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
using System.Diagnostics;


namespace SQlCreater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbCreate();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            FormBorderStyle = FormBorderStyle.FixedDialog;
            WindowState = FormWindowState.Maximized;
            
            
           
            



        }
        public void DbCreate()
        {
            try
            {

                MySqlConnection con = new MySqlConnection("server=localhost; database=test; user=root;pooling = false; convert zero datetime=True");
                MySqlCommand cmd = con.CreateCommand();
                con.Open();
                cmd.CommandText = "create table pre_order(no INT NOT NULL AUTO_INCREMENT,order_date VARCHAR(255) NOT NULL,customer VARCHAR(255) NOT NULL,city VARCHAR(255) NOT NULL,product VARCHAR(255) NOT NULL,PRIMARY KEY(no )); " + "create database if not exists test";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Database Created !\n PLease Click For First Use");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public void myMethod()
        {
            MessageBox.Show("Please Uninstall DBCreate001");
            Process p;
            try
            {
                p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.RedirectStandardInput = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.UseShellExecute = false;
                p.Start();

                p.StandardInput.WriteLine("start control");
                p.StandardInput.Flush();
                p.StandardInput.Close();
                Console.WriteLine(p.StandardOutput.ReadToEnd());
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            DbCreate();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myMethod();
        }
    }
}
