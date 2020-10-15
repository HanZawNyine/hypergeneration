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
            if (ins.insert())
            {
                MessageBox.Show("registered !");
            }
            else
            {
                MessageBox.Show(ins.showErrLog());
            }





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
    
}
