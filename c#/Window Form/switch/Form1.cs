using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @switch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch(cboChoose.SelectedIndex)
            {
                case 0: MessageBox.Show("1"); break;
                case 1: MessageBox.Show("2"); break;
                case 2: MessageBox.Show("3"); break;
            }
        }
    }
}
