using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SearchComputer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

            //if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    folderBrowserDialog1.SelectedPath = "C:";
            //  //lbVal.Items.Add();
            //}
            Search();

        }

        public void Search()
        {
           

        }
    }
}
