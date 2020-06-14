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

namespace PhotoViewer
{
    public partial class frmViewer : Form
    {
        public frmViewer()
        {
            InitializeComponent();
        }

        private void btnBroswe_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if(result==DialogResult.OK)
            {
                string FileName = openFileDialog1.FileName;
                Image image = Image.FromFile(FileName);
                pictureBox1.Image = image;

            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void cboSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

         switch (cboSelect.SelectedItem.ToString())
            {
                case "Normal": pictureBox1.SizeMode = PictureBoxSizeMode.Normal; break;
                case "SketchImage": pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; break;
                case "AutoSize": pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize; break;
                case "CenterImage": pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage; break;
                case "Zoom": pictureBox1.SizeMode = PictureBoxSizeMode.Zoom; break;

            }

        }
    }
}
