using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZawGyi
{
    public partial class frmZawGyi : Form
    {
        public frmZawGyi()
        {
            InitializeComponent();
        }

        private void frmZawGyi_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        
        }

        private void textBox1_VisibleChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {            
        }
        
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string txt = textBox1.Text.ToString();
            funData(txt);
           
        }

        public void funData(string txt)
        {
            try
            {
                if(txt == "a")
                {
                    listBox1.Items.Add("apple");
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
