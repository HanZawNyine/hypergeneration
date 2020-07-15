using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace sqlCOnnect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnHello_Click(object sender, EventArgs e)
        {
            int a = 2;
            MessageBox.Show(a.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Vname;
            //openFileDialog1.OpenFile();
            openFileDialog1.Filter = "mp4 files|*.mp4|mp3|*.mp3|All files|*.*";
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                Vname = openFileDialog1.FileName.ToString();
                wmp1.URL = Vname;
                wmp1.Ctlcontrols.play();
                lbList.Items.Add(Vname);

            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if(fbD.ShowDialog()== DialogResult.OK)
            {
                string path = fbD.SelectedPath;
                var fnames = Directory.GetFiles(path);
               
                foreach(string fname in fnames )
                {
                    lbList.Items.Add(fname);
                    
                }
            }
            //string path = fbD.SelectedPath;
            //lbList.Items.Add(path);
        }

        private void lbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string value = lbList.SelectedItem.ToString();

            wmp1.URL = value;
            wmp1.Ctlcontrols.play();


        }
    }
}
