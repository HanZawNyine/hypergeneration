using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FbPrivateDownloader002
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string original;
        //string www;
        string web;
        string reply;

        private void btnReady_Click(object sender, EventArgs e)
        {
            btnReady.Text="Ready";
            original = txtPaste.Text.ToString();
            //reply = txtChange.Text.ToString();
            //www = original.Replace("https://www.facebook.com", "https://m.facebook.com");   
            web = original.Replace("https://web.facebook.com", "https://m.facebook.com");
            //txtPaste.Text = txtChange.Text;
           // MessageBox.Show(txtChange.Text.ToString());
            //SendLinkToIdm(web);
            //webBrowser1.Url = new System.Uri(web);
            // webBrowser1.Url = new System.Uri(txtForShow.Text);
            //original = reply;
            web = txtChange.Text;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           // web = e.Url.ToString();
            //SendLinkToIdm(web);
            //MessageBox.Show(web);
            
        }
        public void SendLinkToIdm(string url)
        {
            try
            {
                bool x_32 = System.IO.Directory.Exists(@"C:\Program Files\Internet Download Manager"); // check if system is 32bit
                bool x_64 = System.IO.Directory.Exists(@"C:\Program Files (x86)\Internet Download Manager"); // check if system is 64bit and you have installed 32bit programs on it 
                if (x_32 == true | x_64 == true) // if any of the above directories exist it means you have idm installed 
                {
                    System.Diagnostics.Process p = new System.Diagnostics.Process(); // Start the child process.                    
                    p.StartInfo.UseShellExecute = false; // Set the useshellExecute to false 
                    p.StartInfo.RedirectStandardOutput = true; // Redirect the output stream of the child process.
                    p.StartInfo.FileName = @"C:\Windows\System32\cmd.exe"; // specify the location of the command line 
                    p.StartInfo.Verb = "runas";
                    p.StartInfo.CreateNoWindow = true; // eliminate the process window
                    if (x_32 == true)
                        p.StartInfo.Arguments = @"/C cd %programfiles%\Internet Download Manager && IDMan.exe /d " + "\"" + url + "\""; // first go to the idm location then execute the command 
                    else
                        p.StartInfo.Arguments = @"/C cd C:\Program Files (x86)\Internet Download Manager && IDMan.exe /d " + "\"" + url + "\"";
                    p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    p.Start(); // now when all is set run the process 
                    p.WaitForExit(); // Waits here for the process to exit.

                }
                else
                    MessageBox.Show("Please install Internet Download Manager " + System.Diagnostics.Process.Start("https://www.internetdownloadmanager.com/download.html")); // open the download page of the idm in the browser
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void txtForShow_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReady_ForeColorChanged(object sender, EventArgs e)
        {

        }

        private void txtChange_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
