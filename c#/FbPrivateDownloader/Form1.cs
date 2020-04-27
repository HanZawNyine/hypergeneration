using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Web;

namespace FbPrivateDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string original;
        string www;
        string web;

        private void btnDwnload_Click(object sender, EventArgs e)
        {
            original = txtPaste.Text.ToString();
            //www = original.Replace("https://www.facebook.com", "https://m.facebook.com");   
            web = original.Replace("https://web.facebook.com", "https://m.facebook.com");
            //MessageBox.Show(www);
            //MessageBox.Show(web);
            www.Text = webBrowser1.Url.ToString();
            www.Text = webBrowser1.Url.ToString();

        }



        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           // webBrowser1.Document.GetElementById("Button1").Click();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(www);
            MessageBox.Show(web);
        }
    }
}
