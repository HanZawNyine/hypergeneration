using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Var_Type
{
    public partial class frmVar : Form
    {
        public frmVar()
        {
            InitializeComponent();
        }

        private void btnVar_Click(object sender, EventArgs e)
        {
            int a = 10;
            MessageBox.Show(a.ToString());
        }
    }
}
