using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Looping
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
                case 0: MessageBox.Show("a"); break;
                case 1: MessageBox.Show("b");break;
                case 2: MessageBox.Show("c"); break;
                case 3: MessageBox.Show("d"); break;
                case 4: MessageBox.Show("e"); break;
            }
                       

        }
    }
}
