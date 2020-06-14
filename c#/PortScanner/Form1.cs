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
//using System.Net.Sockets;

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
            //Cursor.Current = Cursors.WaitCursor;

            for(int currport=StartPort; currport<=EndPint; currport++)
            {
                //a++;
                TcpClient tcpportScan = new TcpClient();
                try
                {
                    tcpportScan.Connect(txtIP.Text,currport);
                    txtDisplay.AppendText("port" + currport + "open.\r\n");
                    //MessageBox.Show("port" + currport + "\nopen.\n");

                }catch
                {
                    txtDisplay.AppendText("port" + currport + "closed.\r\n");
                    //MessageBox.Show("port" + currport + "closed.");
                }
                progressBar1.PerformStep();

               // Cursor.Current = Cursors.Arrow;
            }

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
