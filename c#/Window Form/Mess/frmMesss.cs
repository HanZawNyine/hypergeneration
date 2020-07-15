using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mess
{
    public partial class frmMesss : Form
    {
        public frmMesss()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Message","caption",MessageBoxButtons.AbortRetryIgnore);
                             
        }

        private void frmMesss_Load(object sender, EventArgs e)
        {

        }
    }
}
