using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBroswer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          string Address=  txtAddress.Text.ToString();
            webBrowser1.Navigate(Address);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Search = txtSearch.Text.ToString();
            string GoogleSearch = "https://www.google.com/search?q=" + txtSearch.Text.ToString() + "&oq=apple&aqs=chrome..69i57j0l7.1475j0j7&sourceid=chrome&ie=UTF-8";
            string BingSearch = "https://www.bing.com/search?q=" + txtSearch.Text.ToString() + "&go=Search&qs=ds&form=QBRE";
            //txtAddress.Text = GoogleSearch.ToString();
            string vim = "";

            switch(cboEngine.SelectedIndex)
            {
                case 0:
                    vim = GoogleSearch; break;
                case 1: vim = BingSearch; break;
            }



         
            txtAddress.Text = vim.ToString();
            webBrowser1.Navigate(vim);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();
        }
    }
}
