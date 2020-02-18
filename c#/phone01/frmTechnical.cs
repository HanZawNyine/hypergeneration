﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace phone01
{
    public partial class frmTechnical : Form
    {
        public frmTechnical()
        {
            InitializeComponent();
        }

        private void dgvTechnical_CellContent(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM phone01.technical", con);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "technical");
                dgvTechnical.DataSource = ds.Tables[1];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvTechnical_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
