using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;
using System.IO;

namespace PortScanner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            int StartPort = Convert.ToInt32(txtFrom.Text);
            int EndPint = Convert.ToInt32(txtTo.Text);
            progressBar1.Value = 0;
            progressBar1.Maximum = EndPint - StartPort +1;
            

            for(int currport=StartPort; currport<=EndPint; currport++)
            {
                //a++;
                TcpClient tcpportScan = new TcpClient();
                try
                {
                    //MessageBox.Show()''
                    tcpportScan.Connect(txtIP.Text,currport);
                    txtDisplay.AppendText("port" + currport + "open.\r\n");
                   

                }catch
                {
                    txtDisplay.AppendText("port" + currport + "closed.\r\n");
                   
                }
                progressBar1.PerformStep();

               
            }

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FindIP();
            

        }
        public void FindIP()
        {
            try
            {
                IPHostEntry hostname = Dns.GetHostByName(txtDisplay.Text);
                IPAddress[] ip = hostname.AddressList;
                string aa = ip[0].ToString();
                txtDisplay.AppendText(aa+"\r\n");
                txtIP.Clear();
                txtIP.Text = aa;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
