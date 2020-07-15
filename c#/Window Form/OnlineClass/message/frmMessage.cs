using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace message
{
    public partial class frmMessage : Form
    {
        public frmMessage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            DialogResult result= MessageBox.Show("Are you sure to exit ?", "Exit",MessageBoxButtons.OKCancel);

            if(result==DialogResult.OK)
            {
                Application.Exit();
            }
            else if(result==DialogResult.Cancel)
            {
                MessageBox.Show("this is cancel");
            }
            else
            {
                Application.Restart();
            }
        }

        private void frmMessage_Load(object sender, EventArgs e)
        {
           
        }

        

     


    }
}
