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
    public partial class Usage_Log : Form
    {
        public Usage_Log()
        {
            InitializeComponent();
        }

        string passserver = "";

        MySqlDB mysql = new MySqlDB();
        private void Usage_Log_Load(object sender, EventArgs e)
        {
            mysql.constring = "Data Source= localhost;Database=engineering_school;User ID=root;Password=" + passserver;
            mysql.tablename = "log";
            mysql.cmdText = "select * from logs";
            mysql.DataBind();

            dataGridView1.Rows.Clear();

            int count = mysql.dst.Tables["log"].Rows.Count;
            dataGridView1.Rows.Add(count);
            for (int i = 0; i < count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = mysql.dst.Tables["log"].Rows[i]["uname"].ToString();
                dataGridView1.Rows[i].Cells[1].Value = mysql.dst.Tables["log"].Rows[i]["dateTime"].ToString();
                dataGridView1.Rows[i].Cells[2].Value = mysql.dst.Tables["log"].Rows[i]["status"].ToString();
            }
        }

        private void btnEixt_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
