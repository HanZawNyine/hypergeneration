using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql_Database_Class;
using MySql.Data.MySqlClient;
using System.IO;

namespace trainees_Management_System
{
    public partial class frmMain : Form
    {
        DataSet dst = new DataSet();
        MySqlDB mysql = new MySqlDB();
        string server_pass = "";


        public frmMain()
        {
            InitializeComponent();
        }   
        

        private void frmMain_Load(object sender, EventArgs e)
        {
            mysql.constring = "Data Source= localhost;Database=;User ID=root;Password=" + server_pass + ";charset=utf8";
            mysql .tablename = "check";
            mysql .cmdText = "SELECT SCHEMA_NAME FROM INFORMATION_SCHEMA.SCHEMATA WHERE SCHEMA_NAME = 'engineering_school'";
            mysql.DataBind();
            dst = mysql.dst;

            if (dst.Tables["check"].Rows.Count > 0)
            {

                mysql.constring = "Data Source= localhost;Database=engineering_school;User ID=root;Password=" + server_pass + ";charset=utf8";
                dgvMain.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            }
            else
            {


                //mysql.cmdText = "DROP DATABASE engineering_school";
                //mysql.DataBind();

                //mysql.constring = "Data Source= localhost;Database=;User ID=root;Password=" + server_pass + ";charset=utf8";
                mysql.cmdText = "CREATE DATABASE engineering_school COLLATE utf8_unicode_ci";
                mysql.DataBind();
                mysql.constring = "Data Source= localhost;Database=engineering_school;User ID=root;Password=" + server_pass + ";charset=utf8";
                using (MySqlConnection con = new MySqlConnection(mysql.constring))
                {

                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup backup = new MySqlBackup(cmd))
                        {
                            cmd.Connection = con;
                            con.Open();
                            // File.Create(fbdlBackup.SelectedPath + "\\MES.sql");
                            backup.ImportFromFile(Application .StartupPath + "\\NewDb.sql");
                            con.Close();
                            //DialogResult result = MessageBox.Show("Database အား restore ပြုလုပ်ပြီးဖြစ်ပါသည်။ Software အား restart ပြုလုပ်မည်ဖြစ်ပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                //Application.Restart();
            }


            try
            {

                string uname = string.Empty;
                string pass = string.Empty;

                frmlogin login = new frmlogin();
                login.ShowDialog();
                string logName = login.txtUname.Text;
                this.WindowState = FormWindowState.Minimized;

                if (login.DialogResult == System.Windows.Forms.DialogResult.Cancel)
                {
                    Environment.Exit(0);
                }
                else
                {
                    mysql.tablename = "auth";
                    mysql.cmdText = "select * from auth where uname = '" + login.txtUname.Text + "'";
                    mysql.DataBind();
                  

                    if (mysql.dst.Tables["auth"].Rows.Count > 0)
                    {                       
                        //string mm = mysql.dst.Tables["setting"].Rows[0]["log"].ToString();
                        pass = mysql.dst.Tables["auth"].Rows[0]["pass"].ToString();
                        if (pass == login.txtpass.Text)
                        {
                            this.WindowState = FormWindowState.Maximized;
                            mysql.tablename = "logs";
                            mysql.AddParams("@uname", logName);
                            mysql.AddParams("@log", DateTime.Now.ToString());
                            mysql.cmdText = "INSERT INTO logs(uname,status,dateTIme) VALUES ('" + logName + "','Successfully Login','" + DateTime.Now.ToString() + "')";
                            mysql.insert();
                            login.Dispose();
                            load_training_name();

                        }
                        else 
                        {
                            this.Hide();
                            WrongAuth(logName);
                        }
                    }
                    else
                    {
                        this.Hide();
                        WrongAuth(logName);
                    }

                }

            }
            catch
            {
                MessageBox.Show("Database Server ချိတ်ဆက်မှုမအောင်မြင်ပါ။ Server အားပြန်လည်စစ်ဆေးရန်။", "System ဆိုင်ရာသတိပေးချက်", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }

        }



        private void WrongAuth(string logName)
        {
           
           
            MessageBox.Show("Wrong Username or Password.!", "Wrong");
            mysql.tablename = "logs";
            mysql.AddParams("@uname", logName);
            mysql.AddParams("@log", DateTime.Now.ToString());
            mysql.cmdText = "INSERT INTO logs(uname,status,dateTIme) VALUES ('" + logName + "','Fails Login','" + DateTime.Now.ToString() + "')";
            mysql.insert();
            Application.Exit();
            Environment.Exit(0);
        }

        private void traineesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        void load_training_name()
        {                       
            dst = new DataSet();
            cboOfficer_training.Items.Clear();
            cbotrainningName.Items.Clear();
            cboRanker_training.Items.Clear();
            //get training name from table
            mysql.tablename = "training_name";
            mysql.cmdText = "SELECT training_name_id,training_name,row FROM training_name";
            mysql.DataBind();
            dst = mysql.dst;
            if (dst.Tables["training_name"].Rows.Count > 0)
            {
                for (int i = 0; i < dst.Tables["training_name"].Rows.Count; i++)
                {
                    ComboboxItem item = new ComboboxItem();
                    item.Text = dst.Tables["training_name"].Rows[i]["training_name"].ToString();
                    item.Value = dst.Tables["training_name"].Rows[i]["row"].ToString();
                    cbotrainningName.Items.Add(item );
                    string row = dst.Tables["training_name"].Rows[i]["row"].ToString();
                    switch (row )
                    {
                        case "1":
                            cboOfficer_training .Items .Add (item);
                            break ;
                        case "2":
                            cboRanker_training.Items.Add(item);
                            break ;
                        case "3":
                            cboOfficer_training.Items.Add(item);
                            cboRanker_training.Items.Add(item);
                            break ;
                    }
                }
            }
            else
            {
                MessageBox.Show("သင်တန်းအမည် ထည့်သွင်းထားခြင်းမရှိသေးပါ။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            dst.Tables.Remove("training_name");
        }  
        
        

        private void usageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usage_Log usageLog = new Usage_Log();
            usageLog.ShowDialog();
        }

        //string row;
        private void cbotrainningName_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Hide();
            load_data_to_gridview(cbotrainningName.SelectedItem.ToString().Trim(), "%");          
        }
        private void cboOfficer_training_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Hide();
            load_data_to_gridview(cboOfficer_training.SelectedItem.ToString().Trim(), "%");
        }
        private void cboRanker_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel1.Hide();
            load_data_to_gridview(cboRanker_training.SelectedItem.ToString().Trim(), "%");
        }


        private void newToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            trainning_info training_name = new trainning_info();
            training_name.ShowDialog();
        }

        private void သငတနအခကအလကToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTraining_data train_data = new frmTraining_data();
            train_data.ShowDialog();
        }

       
        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string t_value = "";
                if (tabPage2.Focus())
                {
                    t_value = (cbotrainningName.SelectedItem as ComboboxItem).Value.ToString();
                }
                else if (tabPage3.Focus())
                {
                    t_value = (cboOfficer_training.SelectedItem as ComboboxItem).Value.ToString();
                }
                else if (tabPage4.Focus())
                {
                    t_value = (cboRanker_training.SelectedItem as ComboboxItem).Value.ToString();
                }
                frmTraining frm_training = new frmTraining(dgvMain.SelectedRows[0].Cells[0].Value.ToString(), dgvMain.SelectedRows[0].Cells[1].Value.ToString(), t_value);
                frm_training.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }
      

        private void ထညသငရနToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOfficer Officer = new frmOfficer();
            Officer.ShowDialog();
        }

        private void စစသညToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOther_rank Other_Rank = new frmOther_rank();
            Other_Rank.ShowDialog();
        }

        private void excelFileမတဆငထညသငရနToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExcel Excel = new frmExcel();
            Excel.ShowDialog();
        }



        void load_data_to_gridview(string training_name,string batch)
        {
            try
            {
                dgvMain.Columns.Clear();
                dgvMain.Columns.Add("dgv_Name", "သင်တန်းအမည်");
                dgvMain.Columns.Add("Batch", "သင်တန်းအမှတ်စဉ်");
                dgvMain.Columns.Add("S_date", "သင်တန်းဖွင့်ရက်");
                dgvMain.Columns.Add("E_date", "သင်တန်းဆင်းရက်");
                dgvMain.Columns.Add("Qty", "သင်တန်းသားအင်အား");

                //row = cbotrainningName.SelectedValue.ToString();
                dgvMain.Rows.Clear();
                dgvMain.Refresh();           

                dst = new DataSet();

                //select each training info from the table but trainig_name do not include in this table
                mysql.tablename = "training_info";
                mysql.cmdText = "SELECT training_name_id,training_name,batch,start_date,end_date,trainner_quantity FROM training_info WHERE training_name='" + training_name  + "' AND batch LIKE '" + batch+  "' ORDER BY batch";
                mysql.DataBind();
                dst = mysql.dst;
            

                if (dst.Tables["training_info"].Rows.Count > 0)
                {
                    dgvMain.Rows.Add(dst.Tables["training_info"].Rows.Count);


                    for (int j = 0; j < dst.Tables["training_info"].Rows.Count; j++)
                    {


                        dgvMain.Rows[j].Cells["dgv_Name"].Value = dst.Tables["training_info"].Rows[j]["training_name"].ToString();
                        //dgvMain.Rows[i].Cells["Short"].Value = dst.Tables["training_name"].Rows[j]["short_name"].ToString();
                        dgvMain.Rows[j].Cells["Batch"].Value = dst.Tables["training_info"].Rows[j]["batch"].ToString();
                        dgvMain.Rows[j].Cells["S_date"].Value = dst.Tables["training_info"].Rows[j]["start_date"].ToString();
                        dgvMain.Rows[j].Cells["E_date"].Value = dst.Tables["training_info"].Rows[j]["end_date"].ToString();
                        dgvMain.Rows[j].Cells["Qty"].Value = dst.Tables["training_info"].Rows[j]["trainner_quantity"].ToString();


                    }

                }
                else
                {
                    MessageBox.Show("ရွေးချယ်လိုက်သောသင်တန်းအမည်ဖြင့် သင်တန်းဖွင့်လှစ်ထားခြင်းမရှိသေးပါ။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            dst.Tables.Clear();
        }

        private void btnTsearch_Click(object sender, EventArgs e)
        {
            if (txt_Tno.Text != "")
            {
                load_data_to_gridview(cbotrainningName.SelectedItem.ToString().Trim(), txt_Tno.Text.Trim());
            }
            else
            {
                MessageBox.Show("သင်တန်းအမှတ်စဉ်ရွေးချယ်ရန်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }

        private void btnOfficer_Click(object sender, EventArgs e)
        {
            if (txtOfficer. Text != "")
            {
                load_data_to_gridview(cboOfficer_training. SelectedItem.ToString().Trim(), txtOfficer.Text.Trim());
            }
            else
            {
                MessageBox.Show("သင်တန်းအမှတ်စဉ်ရွေးချယ်ရန်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void btnRanker_Click(object sender, EventArgs e)
        {
            if (txtRanker.Text != "")
            {
                load_data_to_gridview(cboRanker_training. SelectedItem.ToString().Trim(), txtRanker.Text.Trim());
            }
            else
            {
                MessageBox.Show("သင်တန်းအမှတ်စဉ်ရွေးချယ်ရန်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void အရနသမဆညရနToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog fbdlBackup = new FolderBrowserDialog();
                if (fbdlBackup.ShowDialog() == DialogResult.OK)
                {
                    using (MySqlConnection con = new MySqlConnection(mysql.constring))
                    {

                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup backup = new MySqlBackup(cmd))
                            {
                                cmd.Connection = con;
                                con.Open();
                                // File.Create(fbdlBackup.SelectedPath + "\\MES.sql");
                                backup.ExportToFile(fbdlBackup.SelectedPath + "\\MES.sql");
                                con.Close();
                                MessageBox.Show("Database အား backup ပြုလုပ်ပြီးဖြစ်ပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void အရဖငအအသပရနToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog opfgRestore = new OpenFileDialog();
                if (opfgRestore.ShowDialog() == DialogResult.OK)
                {
                    mysql.cmdText = "DROP DATABASE engineering_school";
                    mysql.DataBind();

                    mysql.constring = "Data Source= localhost;Database=;User ID=root;Password=" + server_pass + ";charset=utf8";
                    mysql.cmdText = "CREATE DATABASE engineering_school COLLATE utf8_unicode_ci";
                    mysql.DataBind();
                    mysql.constring = "Data Source= localhost;Database=engineering_school;User ID=root;Password=" + server_pass + ";charset=utf8";
                    using (MySqlConnection con = new MySqlConnection(mysql.constring))
                    {

                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup backup = new MySqlBackup(cmd))
                            {
                                cmd.Connection = con;
                                con.Open();
                                // File.Create(fbdlBackup.SelectedPath + "\\MES.sql");
                                backup.ImportFromFile(opfgRestore.FileName );
                                con.Close();
                                DialogResult result =  MessageBox.Show("Database အား restore ပြုလုပ်ပြီးဖြစ်ပါသည်။ Software အား restart ပြုလုပ်မည်ဖြစ်ပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    Application.Restart();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginAccountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login_Account_Control login_acc = new Login_Account_Control();
            login_acc.ShowDialog();
            
        }

  

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                load_training_name();
                dgvMain.Rows.Clear();
                dgvMain.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex.Message );
            }
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                DialogResult confirm = MessageBox.Show("Software ပိတ်မည်။", "သတိပေးခြင်း", MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
                e.Cancel = (confirm == DialogResult.Cancel );
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

     

     

       

        
    }
}
