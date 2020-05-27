using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;
using MySql_Database_Class;


namespace trainees_Management_System
{
    public partial class frmExcel : Form
    {

        DataSet dst = new DataSet();
         mysql = new MySqlDB();
        string server_pass = "";


        public frmExcel()
        {
            InitializeComponent();
        }

        private void btnExcel_open_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    filename = openFileDialog1.FileName;

                    OleDbConnection OdbCon;                    
                    OleDbDataAdapter dptExcel;
                    OdbCon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + filename + "';Extended Properties=Excel 12.0;");
                    dptExcel = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", OdbCon);
                    dptExcel.TableMappings.Add("Table", "Testtable");
                    dst = new DataSet();

                    
                    dptExcel.Fill(dst);

                    
                    dgvTrainners.DataSource = dst.Tables["Testtable"];
                    
                    OdbCon.Close();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdoOfficer.Checked == true)
                {
                    if (rdoTraining.Checked == true)
                    {
                        Insert_officer_each_training();
                    }
                    else if (rdoBattalion.Checked == true)
                    {
                        Insert_officer_each_battalion();
                    }
                }
                else
                {
                    if (rdoTraining.Checked == true)
                    {
                        Insert_other_each_training();
                    }
                    else if (rdoBattalion.Checked == true)
                    {
                        Insert_other_each_battalion();
                    }
                }
                MessageBox.Show("စာရင်းများ ထည့်သွင်းပြီးပါပြီ။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            
        }

        

        private void frmExcel_Load(object sender, EventArgs e)
        {
            mysql.constring = "Data Source= localhost;Database=engineering_school;User ID=root;Password=" + server_pass + ";charset=utf8";
            dgvTrainners.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dgvTrainners.Invalidate();
            //dgvOfficer.AutoSizeRowsMode = DataGridViewAutoSizeRowMode.RowHeader;
            this.WindowState = FormWindowState.Maximized;

            
        }

        private void rdoOfficer_CheckedChanged(object sender, EventArgs e)
        {
           
                
                if (rdoOfficer.Checked == true)
                {
                    load_training_name(1);
                }
            

            
        }

        private void rdoOtherRank_CheckedChanged(object sender, EventArgs e)
        {
               if (rdoOtherRank . Checked == true)
                {
                    load_training_name(2);
                }
            
        }

        void load_training_name(int t_row)
        {
           try
            {
                    dst.Tables.Clear();
                    cbotrainningName.Items.Clear();
                    dst.Tables.Clear();
                    //to get training information
                    mysql.tablename = "training_name";
                    mysql.cmdText = "SELECT * FROM training_name WHERE row='" + t_row.ToString() + "' OR row=3";
                    mysql.DataBind();
                    dst = mysql.dst;

                    if (dst.Tables["training_name"].Rows.Count > 0)
                    {
                        for (int i = 0; i < dst.Tables["training_name"].Rows.Count; i++)
                        {
                            ComboboxItem item = new ComboboxItem();
                            item.Text = dst.Tables["training_name"].Rows[i]["training_name"].ToString();
                            item.Value = dst.Tables["training_name"].Rows[i]["training_name_id"].ToString();
                            cbotrainningName.Items.Add(item);
                        }
                    }
                    else
                    {
                        MessageBox.Show("သင်တန်းအမည် ထည့်သွင်းထားခြင်းမရှိသေးပါ။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbotrainningName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cboBatch.Items.Clear();
                mysql.tablename = "training_info";
                mysql.cmdText = "SELECT * FROM training_info WHERE training_name='"+ cbotrainningName.Text  + "' ORDER BY batch";
                mysql.DataBind();
                dst = mysql.dst;


                if (dst.Tables["training_info"].Rows.Count > 0)
                {
                    for (int i = 0; i < dst.Tables["training_info"].Rows.Count; i++)
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = dst.Tables["training_info"].Rows[i]["batch"].ToString();
                        item.Value = dst.Tables["training_info"].Rows[i]["id"].ToString();
                        cboBatch.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("သင်တန်းအမည် ထည့်သွင်းထားခြင်းမရှိသေးပါ။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dst.Tables.Remove("training_info");

            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show((cboBatch.SelectedItem as ComboboxItem).Value.ToString());
        }

        void Insert_officer_each_training()
        {
            dst.Tables.Clear();
            string officer_id = "";
            //for checking the training state
            mysql.tablename = "training_info";
            mysql.cmdText = "SELECT id FROM training_info WHERE training_name_id='" + (cbotrainningName.SelectedItem as ComboboxItem).Value + "' AND batch='" + cboBatch.Text.Trim() + "'";
            mysql.DataBind();
            dst = mysql.dst;

            for (int i = 0; i < dgvTrainners.Rows.Count; i++)
            {

            officer_training:
                if (dgvTrainners.Rows[i].Cells["ပြန်တမ်း၀င်အမှတ်"].Value == null) return;
                string bc = "ကြည်း-" + Eng_2_Myan ( dgvTrainners.Rows[i].Cells["ပြန်တမ်း၀င်အမှတ်"].Value.ToString());
                
                if (bc == "") return;
                
                mysql.tablename = "officer_bc";
                mysql.cmdText = "SELECT * FROM officer_name WHERE bc_no='" + bc + "'";
                mysql.DataBind();
                dst = mysql.dst;

                
                

                if (dst.Tables["officer_bc"].Rows.Count > 0)
                {
                    

                    mysql.cmdText = "UPDATE officer_name SET rank='" + dgvTrainners.Rows[i].Cells["အဆင့်"].Value.ToString() + "',battalion='" + dgvTrainners.Rows[i].Cells["တပ်"].Value.ToString() + "' WHERE bc_no='" + bc + "'";
                    mysql.DataBind();

                    officer_id = dst.Tables["officer_bc"].Rows[0]["officer_id"].ToString();
                    if (dst.Tables["training_info"].Rows.Count > 0)
                    {
                        //Check officer already attended this class
                        mysql.tablename = "training_state";
                        //mysql.cmdText = "SELECT * FROM officer_training_state WHERE officer_id='" + officer_id + "' AND training_info_id='" + dst.Tables["training_info"].Rows[0]["id"] + "'";
                        mysql.cmdText = "SELECT * FROM officer_training_state WHERE officer_id='" + officer_id + "' AND training_name_id='" + (cbotrainningName.SelectedItem as ComboboxItem).Value + "'";
                        mysql.DataBind();
                        if (dst.Tables["training_state"].Rows.Count > 0)
                        {
                            dst.Tables.Remove("training_state");
                            dgvTrainners.Rows[i].Cells["ပြန်တမ်း၀င်အမှတ်"].Style.BackColor = Color.Yellow;
                            goto NextOne;
                        }
                        dst.Tables.Remove("training_state");
                    }

                    mysql.cmdText = "INSERT INTO officer_training_state(officer_id,training_name_id,batch,grade,training_info_id) VALUES ('" + dst.Tables["officer_bc"].Rows[0]["officer_id"].ToString() + "','" + (cbotrainningName.SelectedItem as ComboboxItem).Value.ToString() + "','" + cboBatch.Text.Trim() + "','" + "" + "','" + (cboBatch.SelectedItem as ComboboxItem).Value.ToString() + "')";
                    mysql.insert();
                }
                else 
                {
                    //DialogResult result =  MessageBox.Show(dgvTrainners.Rows[i].Cells["ပြန်တမ်း၀င်အမှတ်"].Value.ToString() + "၊ " + dgvTrainners.Rows[i].Cells["အဆင့်"].Value.ToString() + " " +dgvTrainners.Rows[i].Cells["အမည်"].Value.ToString() + "အား စာရင်းသွင်းထားခြင်းမရှိသေးပါ။\nစာရင်းသွင်းလိုပါသလား။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်",MessageBoxButtons.YesNo ,MessageBoxIcon.Question );
                    //if (result == DialogResult .Yes)
                    //{                        
                        //Insert new officer information to table 'officer_name' 
                        mysql.cmdText = "INSERT INTO officer_name(bc_no,rank,name,battalion) VALUES ('" + bc + "','" + dgvTrainners.Rows[i].Cells["အဆင့်"].Value.ToString() + "','" + dgvTrainners.Rows[i].Cells["အမည်"].Value.ToString() + "','" + dgvTrainners.Rows[i].Cells["တပ်"].Value.ToString() + "')";
                        mysql.insert();
                        dgvTrainners.Rows[i].Cells["ပြန်တမ်း၀င်အမှတ်"].Style.BackColor = Color.Red;
                        goto officer_training;
                    //}
                }

            NextOne:
                dst.Tables.Remove("officer_bc");
            
            }
        }

        void 
            Insert_officer_each_battalion()
        {

            for (int i = 0; i < dgvTrainners.Rows.Count; i++)
            {
                if (dgvTrainners.Rows[i].Cells["ပြန်တမ်း၀င်အမှတ်"].Value == null) return;
                string bc = "ကြည်း-" + Eng_2_Myan(dgvTrainners.Rows[i].Cells["ပြန်တမ်း၀င်အမှတ်"].Value.ToString());
                dst.Tables.Clear();
                
                for (int j = 6; j < dgvTrainners.Columns.Count; j++)
                {
                NewTrain:
                    string t_name = dgvTrainners.Columns[j].HeaderText.ToString();
                    string batch = dgvTrainners.Rows[i].Cells[j].Value.ToString();
                    if (batch != "")
                    {
                        batch = Eng_2_Myan (dgvTrainners.Rows[i].Cells[j].Value.ToString());
                        mysql.tablename = "off_training";
                        mysql.cmdText = "SELECT * FROM training_name WHERE training_name='" + t_name + "'";
                        mysql.DataBind();
                        dst = mysql.dst;


                        if (dst.Tables["off_training"].Rows.Count == 0)
                        {
                            mysql.cmdText = "INSERT INTO training_name(training_name,row) VALUES ('" + t_name + "','" + 1 + "')";
                            mysql.insert();
                            dgvTrainners.Columns[j].HeaderCell.Style.BackColor = Color.Red;
                            dgvTrainners.Rows[i].Cells[j].Style.BackColor = Color.Red;

                            dst.Tables.Remove("off_training"); ;

                            mysql.tablename = "off_training";
                            mysql.cmdText = "SELECT * FROM training_name WHERE training_name='" + t_name + "'";
                            mysql.DataBind();
                            dst = mysql.dst;
                        }


                        mysql.tablename = "training_info";
                        mysql.cmdText = "SELECT * FROM training_info WHERE training_name='" + t_name + "' AND batch='" + batch + "'";
                        mysql.DataBind();
                        dst = mysql.dst;




                    officer_battalion: 

                        if (dst.Tables["training_info"].Rows.Count > 0)
                        {
                            mysql.tablename = "officer_bc";
                            mysql.cmdText = "SELECT * FROM officer_name WHERE bc_no='" + bc + "'";
                            mysql.DataBind();
                            dst = mysql.dst;

                            if (dst.Tables["officer_bc"].Rows.Count > 0)
                            {
                                mysql.cmdText = "UPDATE officer_name SET rank='" + dgvTrainners.Rows[i].Cells["အဆင့်"].Value.ToString() + "',battalion='" + dgvTrainners.Rows[i].Cells["တပ်"].Value.ToString() + "' WHERE bc_no='" + bc + "'";
                                mysql.DataBind();
                                //Check officer already attended this class
                                mysql.tablename = "training_state";
                                //mysql.cmdText = "SELECT * FROM officer_training_state WHERE officer_id='" + dst.Tables["officer_bc"].Rows[0]["officer_id"].ToString() + "' AND training_info_id='" + dst.Tables["training_info"].Rows[0]["id"] + "'";
                                mysql.cmdText = "SELECT * FROM officer_training_state WHERE officer_id='" + dst.Tables["officer_bc"].Rows[0]["officer_id"].ToString() + "' AND training_name_id='" + (cbotrainningName.SelectedItem as ComboboxItem).Value + "'";
                                mysql.DataBind();
                                if (dst.Tables["training_state"].Rows.Count > 0)
                                {
                                    dst.Tables.Remove("training_state");
                                    dgvTrainners.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                                    goto NextOne1;
                                }
                                dst.Tables.Remove("training_state");

                                mysql.cmdText = "INSERT INTO officer_training_state(officer_id,training_name_id,batch,grade,training_info_id) VALUES ('" + dst.Tables["officer_bc"].Rows[0]["officer_id"].ToString() + "','" + dst.Tables["training_info"].Rows[0]["training_name_id"] + "','" + batch  + "','" + "" + "','" + dst.Tables["training_info"].Rows[0]["id"] + "')";
                                mysql.insert();
                            }
                            else
                            {
                                //DialogResult result = MessageBox.Show(dgvTrainners.Rows[i].Cells["ပြန်တမ်း၀င်အမှတ်"].Value.ToString() + "၊ " + dgvTrainners.Rows[i].Cells["အဆင့်"].Value.ToString() + " " + dgvTrainners.Rows[i].Cells["အမည်"].Value.ToString() + "အား စာရင်းသွင်းထားခြင်းမရှိသေးပါ။\nစာရင်းသွင်းလိုပါသလား။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                //if (result == DialogResult.Yes)
                                //{
                                    //Insert new officer information to table 'officer_name' 
                                    mysql.cmdText = "INSERT INTO officer_name(bc_no,rank,name,battalion) VALUES ('" + bc + "','" + dgvTrainners.Rows[i].Cells["အဆင့်"].Value.ToString() + "','" + dgvTrainners.Rows[i].Cells["အမည်"].Value.ToString() + "','" + dgvTrainners.Rows[i].Cells["တပ်"].Value.ToString() + "')";
                                    mysql.insert();
                                    dgvTrainners.Rows[i].Cells["ပြန်တမ်း၀င်အမှတ်"].Style.BackColor = Color.Red ;
                                    dst.Tables.Remove("officer_bc");
                                    goto officer_battalion;
                                //}
                            }
                        }
                        else
                        {
                           
                            mysql.cmdText = "INSERT INTO training_info(training_name_id,training_name,batch,start_date,end_date,trainner_quantity) VALUES ('" + Convert.ToInt32(dst.Tables["off_training"].Rows[0]["training_name_id"]) + "','" + dst.Tables["off_training"].Rows[0]["training_name"] + "','" + batch + "',' ',' ',' ')";
                            mysql.insert();
                            dst.Tables.Clear();
                            dgvTrainners.Columns[j].HeaderCell.Style.BackColor = Color.Red;
                            dgvTrainners.Rows[i].Cells[j].Style.BackColor = Color.Red;
                            goto NewTrain;
                        }
                        //dst.Tables.Remove("training_info");
                        //dst.Tables.Remove("off_training");
                        //dst.Tables.Remove("officer_bc");
                    NextOne1:
                        dst.Tables.Clear();
                    }

                }


            }
        }

        

        void Insert_other_each_training()
        {
            dst.Tables.Clear();
            
            //for checking the training state
            mysql.tablename = "training_info";
            mysql.cmdText = "SELECT id FROM training_info WHERE training_name_id='" + (cbotrainningName.SelectedItem as ComboboxItem).Value + "' AND batch='" + cboBatch.Text.Trim() + "'";
            mysql.DataBind();
            dst = mysql.dst;

            for (int i = 0; i < dgvTrainners.Rows.Count; i++)
            {
            rank_training:
                if (dgvTrainners.Rows[i].Cells["ကိုယ်ပိုင်အမှတ်"].Value == null) return;
                string sn = "";
                if (dgvTrainners.Rows[i].Cells[1].Value.ToString().Trim() == "")
                {
                    sn = Eng_2_Myan(dgvTrainners.Rows[i].Cells["ကိုယ်ပိုင်အမှတ်"].Value.ToString());
                }
                else
                {
                    sn = "တ-" + Eng_2_Myan(dgvTrainners.Rows[i].Cells["ကိုယ်ပိုင်အမှတ်"].Value.ToString());
                }
                if (sn == "") return;
                //dst.Tables.Clear();
                mysql.tablename = "other_sn";
                mysql.cmdText = "SELECT * FROM other_rank_name WHERE service_no='" + sn + "'";
                mysql.DataBind();
                dst = mysql.dst;
                 
                if (dst.Tables["other_sn"].Rows.Count > 0)
                {
                    mysql.cmdText = "UPDATE other_rank__name SET rank='" + dgvTrainners.Rows[i].Cells["အဆင့်"].Value.ToString() + "',battalion='" + dgvTrainners.Rows[i].Cells["တပ်"].Value.ToString() + "' WHERE service_no='" + sn + "'";
                    mysql.DataBind();
                    if (dst.Tables["training_info"].Rows.Count > 0)
                    {
                        //Check other rank already attended this class
                        mysql.tablename = "training_state";
                        //mysql.cmdText = "SELECT * FROM other_rank_training_state WHERE other_rank_id='" + dst.Tables["other_sn"].Rows[0]["other_rank_id"].ToString() + "' AND training_info_id='" + dst.Tables["training_info"].Rows[0]["id"] + "'";
                        mysql.cmdText = "SELECT * FROM other_rank_training_state WHERE other_rank_id='" + dst.Tables["other_sn"].Rows[0]["other_rank_id"].ToString() + "' AND training_name_id='" + (cbotrainningName.SelectedItem as ComboboxItem).Value + "'";
                        mysql.DataBind();
                        if (dst.Tables["training_state"].Rows.Count > 0)
                        {
                            dst.Tables.Remove("training_state");
                            dgvTrainners.Rows[i].Cells["ကိုယ်ပိုင်အမှတ်"].Style.BackColor = Color.Yellow;
                            goto NextOne2;
                        }
                        dst.Tables.Remove("training_state");
                    }

                    mysql.cmdText = "INSERT INTO other_rank_training_state(other_rank_id,training_name_id,batch,grade,training_info_id) VALUES ('" + dst.Tables["other_sn"].Rows[0]["other_rank_id"].ToString() + "','" + (cbotrainningName.SelectedItem as ComboboxItem).Value.ToString() + "','" + cboBatch.Text.Trim() + "','" + "" + "','" + (cboBatch.SelectedItem as ComboboxItem).Value.ToString() + "')";
                    mysql.insert();
                }
                else
                {
                    //DialogResult result = MessageBox.Show(dgvTrainners.Rows[i].Cells["ကိုယ်ပိုင်အမှတ်"].Value.ToString() + "၊ " + dgvTrainners.Rows[i].Cells["အဆင့်"].Value.ToString() + " " + dgvTrainners.Rows[i].Cells["အမည်"].Value.ToString() + "အား စာရင်းသွင်းထားခြင်းမရှိသေးပါ။\nစာရင်းသွင်းလိုပါသလား။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    //if (result == DialogResult.Yes)
                    //{

                        //Insert new officer information to table 'officer_name' 
                        dgvTrainners.Rows[i].Cells["ကိုယ်ပိုင်အမှတ်"].Style.BackColor = Color.Red;
                        mysql.cmdText = "INSERT INTO other_rank_name(service_no,rank,name,battalion,edu_level) VALUES ('" + sn + "','" + dgvTrainners.Rows[i].Cells["အဆင့်"].Value.ToString() + "','" + dgvTrainners.Rows[i].Cells["အမည်"].Value.ToString() + "','" + dgvTrainners.Rows[i].Cells["တပ်"].Value.ToString() + "','" + dgvTrainners.Rows[i].Cells["ပညာရပ်"].Value.ToString() + "')";
                        mysql.insert();
                        goto rank_training ;
                    //}
                }
            NextOne2:
                dst.Tables.Remove("other_sn");
                
            }
        }

        void Insert_other_each_battalion()
        {
            for (int i = 0; i < dgvTrainners.Rows.Count; i++)
            {
                if (dgvTrainners.Rows[i].Cells["ကိုယ်ပိုင်အမှတ်"].Value == null) return;
                string sn = "";
                if (dgvTrainners.Rows[i].Cells[1].Value.ToString().Trim() == "")
                {
                    sn = Eng_2_Myan(dgvTrainners.Rows[i].Cells["ကိုယ်ပိုင်အမှတ်"].Value.ToString());
                }
                else
                {
                    sn = "တ-" + Eng_2_Myan(dgvTrainners.Rows[i].Cells["ကိုယ်ပိုင်အမှတ်"].Value.ToString());
                }
                if (sn == "") return;
                dst.Tables.Clear();
               

                for (int j = 7; j < dgvTrainners.Columns.Count; j++)
                {
                NewTrain_other:
                    string t_name = dgvTrainners.Columns[j].HeaderText.ToString();
                    string batch = dgvTrainners.Rows[i].Cells[j].Value.ToString();
                    if (batch != "")
                    {
                        batch = Eng_2_Myan(dgvTrainners.Rows[i].Cells[j].Value.ToString());
                        mysql.tablename = "other_training";
                        mysql.cmdText = "SELECT * FROM training_name WHERE training_name='" + t_name + "'";
                        mysql.DataBind();
                        dst = mysql.dst;

                        if (dst.Tables["other_training"].Rows.Count == 0)
                        {
                            mysql.cmdText = "INSERT INTO training_name(training_name,row) VALUES ('" + t_name + "','" + 2 + "')";
                            mysql.insert();
                            dgvTrainners.Columns[j].HeaderCell.Style.BackColor = Color.Red;
                            dgvTrainners.Rows[i].Cells[j].Style.BackColor = Color.Red;

                            dst.Tables.Remove("other_training"); ;

                            mysql.tablename = "other_training";
                            mysql.cmdText = "SELECT * FROM training_name WHERE training_name='" + t_name + "'";
                            mysql.DataBind();
                            dst = mysql.dst;
                        }

                    rank_battalion:
                        mysql.tablename = "training_info";
                        mysql.cmdText = "SELECT * FROM training_info WHERE training_name='" + t_name + "' AND batch='" + batch + "'";
                        mysql.DataBind();
                        dst = mysql.dst;

                        if (dst.Tables["training_info"].Rows.Count > 0)
                        {

                            mysql.tablename = "other_sn";
                            mysql.cmdText = "SELECT * FROM other_rank_name WHERE service_no='" + sn + "'";
                            mysql.DataBind();
                            dst = mysql.dst;

                            if (dst.Tables["other_sn"].Rows.Count > 0)
                            {
                                    mysql.cmdText = "UPDATE other_rank__name SET rank='" + dgvTrainners.Rows[i].Cells["အဆင့်"].Value.ToString() + "',battalion='" + dgvTrainners.Rows[i].Cells["တပ်"].Value.ToString() + "' WHERE service_no='" + sn + "'";
                                    mysql.DataBind();
                                    //Check other rank already attended this class
                                    mysql.tablename = "training_state";
                                    //mysql.cmdText = "SELECT * FROM other_rank_training_state WHERE other_rank_id='" + dst.Tables["other_sn"].Rows[0]["other_rank_id"].ToString() + "' AND training_info_id='" + dst.Tables["training_info"].Rows[0]["id"] + "'";
                                    mysql.cmdText = "SELECT * FROM other_rank_training_state WHERE other_rank_id='" + dst.Tables["other_sn"].Rows[0]["other_rank_id"].ToString() + "' AND training_name_id='" + (cbotrainningName.SelectedItem as ComboboxItem).Value + "'";
                                    mysql.DataBind();
                                    if (dst.Tables["training_state"].Rows.Count > 0)
                                    {
                                        dst.Tables.Remove("training_state");
                                        dgvTrainners.Rows[i].Cells[j].Style.BackColor = Color.Yellow;
                                        goto NextOne3;
                                    }
                                    dst.Tables.Remove("training_state");
                                
                                mysql.cmdText = "INSERT INTO other_rank_training_state(other_rank_id,training_name_id,batch,grade,training_info_id) VALUES ('" + dst.Tables["other_sn"].Rows[0]["other_rank_id"].ToString() + "','" + dst.Tables["training_info"].Rows[0]["training_name_id"] + "','" + batch  + "','" + "" + "','" + dst.Tables["training_info"].Rows[0]["id"] + "')";
                                mysql.insert();
                            }
                            else
                            {
                                //DialogResult result = MessageBox.Show(dgvTrainners.Rows[i].Cells["ကိုယ်ပိုင်အမှတ်"].Value.ToString() + "၊ " + dgvTrainners.Rows[i].Cells["အဆင့်"].Value.ToString() + " " + dgvTrainners.Rows[i].Cells["အမည်"].Value.ToString() + "အား စာရင်းသွင်းထားခြင်းမရှိသေးပါ။\nစာရင်းသွင်းလိုပါသလား။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                //if (result == DialogResult.Yes)
                                //{
                                    //Insert new officer information to table 'officer_name' 
                                    mysql.cmdText = "INSERT INTO other_rank_name(service_no,rank,name,battalion,edu_level) VALUES ('" + sn + "','" + dgvTrainners.Rows[i].Cells["အဆင့်"].Value.ToString() + "','" + dgvTrainners.Rows[i].Cells["အမည်"].Value.ToString() + "','" + dgvTrainners.Rows[i].Cells["တပ်"].Value.ToString() + "','" + dgvTrainners.Rows[i].Cells["ပညာရပ်"].Value.ToString() + "')";
                                    mysql.insert();
                                    dgvTrainners.Rows[i].Cells["ကိုယ်ပိုင်အမှတ်"].Style.BackColor = Color.Red;
                                    dst.Tables.Remove("other_sn");
                                    goto rank_battalion;
                                //}
                            }
                        }
                        else
                        {
                            mysql.cmdText = "INSERT INTO training_info(training_name_id,training_name,batch,start_date,end_date,trainner_quantity) VALUES ('" + Convert.ToInt32(dst.Tables["other_training"].Rows[0]["training_name_id"]) + "','" + dst.Tables["other_training"].Rows[0]["training_name"] + "','" + batch + "',' ',' ',' ')";
                            mysql.insert();
                            dst.Tables.Clear();
                            dgvTrainners.Columns[j].HeaderCell.Style.BackColor = Color.Red;
                            dgvTrainners.Rows[i].Cells[j].Style.BackColor = Color.Red;
                            goto NewTrain_other;
                        }
                    NextOne3:
                        dst.Tables.Remove("training_info");
                        dst.Tables.Clear();
                    }

                }


            }
        }

        private void rdoTraining_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoTraining.Checked == true)
            {
                cbotrainningName.Enabled = true;
                cboBatch.Enabled = true;
            }
        }

        private void rdoBattalion_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoBattalion.Checked == true)
            {
                cbotrainningName.Enabled = false;
                cboBatch.Enabled = false;
            }
        }

        //Convert Eng Number to Myan Number
        string Eng_2_Myan(string text)
        {
            string Myan_date = "";
            text.ToArray();
            char text_change;
            for (int i = 0; i < text.Length; i++)
            {
                switch (text[i])
                {
                    case '1': text_change = '၁'; break;
                    case '2': text_change = '၂'; break;
                    case '3': text_change = '၃'; break;
                    case '4': text_change = '၄'; break;
                    case '5': text_change = '၅'; break;
                    case '6': text_change = '၆'; break;
                    case '7': text_change = '၇'; break;
                    case '8': text_change = '၈'; break;
                    case '9': text_change = '၉'; break;
                    case '0': text_change = '၀'; break;
                    case '/': text_change = '/'; break;
                    default: text_change = text[i]; break;
                }
                Myan_date += text_change;

            }

            return Myan_date;
        }
    }
}
