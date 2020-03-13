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

namespace WindowsFormsApp1
{
    public partial class Student : Form
    {

        public Student()
        {
            InitializeComponent();
        }
         //string connectionstring = "Data Source=localhost;Initial Catalog=LearningSP;Integrated Security=True;user=root;database=student";
        string connectionstring = @"datasource=localhost;port=3306;username=root;database=student";
        

        private void Form1_Load(object sender, EventArgs e)
        {
            loading();

        }


        private void dgvShowAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            

        }


        private void dgvShowAll_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void dgvShowAll_SelectIndexChanged(object sender, DataGridViewCellStyleContentChangedEventArgs e)
        {
            //= sender as dgvShowAll;
            // list.SelectedIndex = .Value.ToString();
            //Select.CurrentRow.Cells[1]= list.SelectedIndex;


            //if(dgvShowAll.CurrentRow.Cells[1].ColumnIndex)
            // {
            //     dgvShowAll.CurrentRow.Cells[0].Selected=;
            // }

        }
    
        public void loading()
        {

          try
          {
            MySqlConnection con = new MySqlConnection(connectionstring);
            con.Open();
            MySqlDataAdapter adapter = new MySqlDataAdapter("ShowAll", con);

            DataSet ds = new DataSet();
            adapter.Fill(ds, "student");
            dgvShowAll.DataSource = ds.Tables[0];
            //MessageBox.Show("connection is ok");
            con.Close();
           }
          catch (Exception ex)
          {
            MessageBox.Show(ex.Message);
          }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loading();
        }

        private void dgvShowAll_CellEnter(object sender, DataGridViewCellEventArgs e)
        {      
           
        }

        private void dgvShowAll_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           // update();

        }
        
        public void update(int title)
        {   
            for (int i = 0; i < dgvShowAll.Columns.Count; i++)
                 {
                //int i=0;

                    string id = Text.ToString();
                    var id2 = dgvShowAll.Rows[i].Cells[0].Value;

                    string name = Text.ToString();
                    var name2 = dgvShowAll.Rows[i].Cells[1].Value;

                    string age = Text.ToString();
                    var age2 = dgvShowAll.Rows[i].Cells[2].Value;

                    string father_name = Text.ToString();
                    var father_name2 = dgvShowAll.Rows[i].Cells[3].Value;

                    string phone_no = Text.ToString();
                    var phone_no2 = dgvShowAll.Rows[i].Cells[4].Value;
                try
                {
                    

                    MySqlConnection con = new MySqlConnection(connectionstring);
                    MySqlCommand cmd = new MySqlCommand("update", con);                    
                    cmd.CommandType = CommandType.StoredProcedure;

                    switch(title)
                    {
                        case 0:
                            con.Open();
                            cmd.Parameters.AddWithValue("_id", id);
                            cmd.Parameters.AddWithValue("_id2", id2);
                            cmd.ExecuteNonQuery();
                            con.Close();
                        break;
                        case 1:
                            con.Open();
                            cmd.Parameters.AddWithValue("_name", name);
                            cmd.Parameters.AddWithValue("_name2", name2);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            break;
                        case 2:
                            con.Open();
                            cmd.Parameters.AddWithValue("_age", age);
                            cmd.Parameters.AddWithValue("_age2", age2);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            break;
                        case 3:
                            con.Open();
                            cmd.Parameters.AddWithValue("_father_name", father_name);
                            cmd.Parameters.AddWithValue("_father_name2", father_name2);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            break;
                        case 4:
                            con.Open();
                            cmd.Parameters.AddWithValue("_phone_no", phone_no);
                            cmd.Parameters.AddWithValue("_phone_no2", phone_no2);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            break;






                    }
                    

                    

                    

                    



                    MessageBox.Show("your data is updated ===>>> !!!!");

                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void dgvShowAll_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvShowAll_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
        }

        private void dgvShowAll_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            // dgvShowAll.CurrentCell.Value =.ToString();

            //update();
            int select = 0;
            //string txt=
            update(select);
            switch (dgvShowAll.s)
            {
                case 0: select = 0; break;
                case 1: select = 1; break;
                case 2: select = 2; break;
                case 3: select = 3; break;
                case 4: select = 4; break;
                case 5: select = 5; break;
                case 6: select = 6; break;
                case 7: select = 7; break;
                case 8: select = 8; break;

            }
        }
       
    }
}
