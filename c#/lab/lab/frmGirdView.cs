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

namespace lab
{
    public partial class frmGirdView : Form
    {
        public frmGirdView()
        {
            InitializeComponent();
        }

        private void dgvSQLVIEM_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void frmGirdView_Load(object sender, EventArgs e)
        {
            ShowDatatbase();
        }
        public void ShowDatatbase()
        {
                        try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM lab.lab", con);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "lab");
                dgvSQLVIEM.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ShowDatatbase();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            dgvSQLVIEM.DataSource = null;
        }
    }

}
