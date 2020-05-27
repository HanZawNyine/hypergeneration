using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace printf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ShowDatatbase();
        }
       // database create
        public void DbCreater()
        {
            try
            {

                MySqlConnection con = new MySqlConnection("server=localhost; database=test; user=root;pooling = false; convert zero datetime=True");
                MySqlCommand cmd = con.CreateCommand();

                con.Open();
                cmd.CommandText = "create table testing(no INT NOT NULL AUTO_INCREMENT,date VARCHAR(255) NOT NULL,customer_name VARCHAR(255) NOT NULL,number VARCHAR(255) NOT NULL,bought VARCHAR(255) NOT NULL,phone_number VARCHAR(255) NOT NULL,address VARCHAR(255) NOT NULL,facebook_acc VARCHAR(255) NOT NULL,PRIMARY KEY(no )); ";
                cmd.ExecuteNonQuery();





                con.Close();
                MessageBox.Show("Database Created !\n PLease Click For First Use");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        //dgv show all
        public void ShowDatatbase()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test.testing", con);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "testing");
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insert
            try
            {
                MySqlConnection con = new MySqlConnection("server=localhost; database=test; user=root;pooling = false; convert zero datetime=True");

                con.Open();

                MySqlCommand cmd = con.CreateCommand();
                
                cmd.CommandText = "INSERT INTO test.testing (`no`, `date`, `customer_name`, `number`, `bought`, `phone_number`, `address`, `facebook_acc`) VALUES (NULL, 'wrewr', 'wRewwre', 'ewre', 'eraef', 'ewrew', 'werew', 'awtewr');";
                
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Inserted !!");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ShowDatatbase();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DbCreater();
            ShowDatatbase();
        }
    }
}
