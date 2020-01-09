using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void abourToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      

        private void areaOfCircleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArea frmMenu = new frmArea();
            frmMenu.Show();
        }
    }
}
