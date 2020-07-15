using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace aasdf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtValue.Text == "")
            {
                /// MessageBox.Show("this r")
                this.Refresh();
            }
            else
            {
                string value = txtValue.Text.ToString();
                if (value == "hi")
                {
                    list.Items.Add(value.ToString().PadLeft(95));
                    string a;// = "hi";
                    list.Items.Add(a).GetHashCode();
                    //a.ToString().d

                    
                }
                    
            }
              
        }

        private void txtValue_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
