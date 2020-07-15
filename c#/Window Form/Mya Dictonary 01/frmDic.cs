using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mya_Dictonary_01
{
    public partial class frmDic : Form
    {
        public frmDic()
        {
            InitializeComponent();
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {
            a = txtValue.Text.ToString();

            if (lbValue.Items.ToString() == "")
            {

                if (txtValue.Text == "")
                {
                    this.Refresh();
                }
                else
                {
                    Data(a);

                }
            }
            else
            {
                lbValue.Items.Clear();
                if (txtValue.Text == "")
                {
                    this.Refresh();
                }
                else
                {
                    Data(a);

                }
            }
        }

        private void txtValue_Validated(object sender, EventArgs e)
        {
            
        }


        string a; 
        private void button1_Click(object sender, EventArgs e)
        {
           a = txtValue.Text.ToString();

            if (lbValue.Items.ToString() == "" )
            {

                if (txtValue.Text == "")
                {
                    this.Refresh();
                }
                else
                {
                    Data(a);

                }
            }
            else
            {
                lbValue.Items.Clear();
                if (txtValue.Text == "")
                {
                    this.Refresh();
                }
                else
                {
                    Data(a);

                }
            }                     
        }

        private void lbValue_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Data(string value)
        {
            switch (value)
            {
                case "": lbValue.Items.Add(""); break;
                case "က": lbValue.Items.Add(""); break;
            }
        }
    }
}
