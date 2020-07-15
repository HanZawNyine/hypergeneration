using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextAppend
{
    public partial class frmTextAppend : Form
    {
        public frmTextAppend()
        {
            InitializeComponent();
        }

        private void btnAppend_Click(object sender, EventArgs e)
        {
            append();
        }

        public void append()
        {
            string aa = "aaaaaaaaaaaaaaaa";
            txtAppend.AppendText(aa);

        }


    }
}
