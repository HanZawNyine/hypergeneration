using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Luncher
{
    public partial class frmLiuncher : Form
    {
        public frmLiuncher()
        {
            InitializeComponent();
        }

        private void frmLiuncher_Load(object sender, EventArgs e)
        {

        }

        private void btnNotepad_Click(object sender, EventArgs e)
        {
          Process.Start("notepad.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
           Process.Start("C:\\Program Files (x86)\\Calibre2\\calibre.exe");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Program Files\\WinRAR\\WinRAR.exe");
        }
    }
}
