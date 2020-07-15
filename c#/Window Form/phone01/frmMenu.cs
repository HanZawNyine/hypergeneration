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

namespace phone01
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTechnical ft = new frmTechnical();
            ft.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer fc = new frmCustomer();
            fc.ShowDialog();
        }

        private void errorCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dgvWork_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            string a = cboDone.Text.ToString();
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT  * FROM phone01.technical where done like '"+a+"'", con);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "technical");
                dgvWork.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cboDone_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void techicalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void errorCodeToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void insertToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registerAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegister fr = new frmRegister();
            fr.ShowDialog();
        }

        private void technicalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exportDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {

            
        }
    }
}
