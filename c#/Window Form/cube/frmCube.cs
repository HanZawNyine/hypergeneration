using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cube
{
    public partial class frmCube : Form
    {
        public frmCube()
        {
            InitializeComponent();
        }
        

        private void frmCube_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.FixedDialog;
            WindowState = FormWindowState.Maximized;

            //button65.Text = "a";



        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
           
        }

        private void button57_Click(object sender, EventArgs e)
        {
            if(button65.Text=="")
            {
                button65.BackColor = System.Drawing.Color.Black;
                button57.BackColor = System.Drawing.Color.Black;
            }
            else
            {
                MessageBox.Show("you can't choose this item");
            }
        }

        private void button59_Click(object sender, EventArgs e)
        {
            if (button65.Text == "" || button67.Text == "")
            {
                button65.BackColor = System.Drawing.Color.Black;
                button67.BackColor = System.Drawing.Color.Black;
                button59.BackColor = System.Drawing.Color.Black;
            } else if (button65.Text == "a")
            {
                //button65.BackColor = System.Drawing.Color.Black;
                button67.BackColor = System.Drawing.Color.Black;
                button59.BackColor = System.Drawing.Color.Black;
                     }
            else
            {
                MessageBox.Show("ot move");
            }
        }

        private void button73_Click(object sender, EventArgs e)
        {
           
           
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            //button7.BackColor = System.Drawing.Color.Black;
        }

        private void button67_Click(object sender, EventArgs e)
        {

        }
    }
}
