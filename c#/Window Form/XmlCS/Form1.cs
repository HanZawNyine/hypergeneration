using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XmlCS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); 
            ofd.Filter = "XML|*.xml"; 
            if (ofd.ShowDialog() == DialogResult.OK)
            { 
                XmlDocument xdc = new XmlDocument();
                xdc.Load(ofd.FileName);
                MessageBox.Show(xdc.SelectSingleNode("People/Person/E-Mail").InnerText);
            }
        }
    }
}
