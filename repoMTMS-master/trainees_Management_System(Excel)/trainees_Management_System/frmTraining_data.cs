using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql_Database_Class;

namespace trainees_Management_System
{
    public partial class frmTraining_data : Form
    {

        MySqlDB mysql = new MySqlDB();
        string server_pass = "";
        DataSet dst = new DataSet();


        public frmTraining_data()
        {
            InitializeComponent();
        }

        private void frmTraining_data_Load(object sender, EventArgs e)
        {
            try
            {                
                this.WindowState = FormWindowState.Maximized;
                mysql.constring = "Data Source= localhost;Database=engineering_school;User ID=root;Password=" + server_pass + ";charset=utf8";
                dgvTraining_name.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                if (dst.Tables.Count != 0) dst.Tables.Clear();
                load_training_name("%");
                if (dst.Tables["training_name"].Rows.Count <= 0)
                {
                    MessageBox.Show("သင်တန်းအမည် ထည့်သွင်းထားခြင်းမရှိသေးပါ။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်",MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                for (int i = 0; i < dst.Tables["training_name"].Rows.Count; i++)
                {

                    cbotraining_name.Items.Add(dst.Tables["training_name"].Rows[i]["training_name"].ToString());

                }
                load_training_info("%");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        void load_training_name(string training_name_filter)
        {
            
            //to get training name from table
            mysql.tablename = "training_name";
            mysql.cmdText = "SELECT * FROM training_name WHERE training_name LIKE '" +training_name_filter + "'";
            mysql.DataBind();
            dst = mysql.dst;
            
        }

        void load_training_info(string training_name_filter)
        {
            
            //to get training information
            mysql.tablename = "training_info";
            mysql.cmdText = "SELECT * FROM training_info WHERE training_name LIKE '"+ training_name_filter + "' ORDER BY training_name_id,batch";
            mysql.DataBind();
            dst = mysql.dst;

            //clear the datagridview
            dgvTraining_name.Rows.Clear();
            dgvTraining_name.Refresh();
            

            //datagridview columns adding and set width by ratio 
            dgvTraining_name.Columns.Clear();
            dgvTraining_name.Columns.Add("trainingName", "သင်တန်းအမည်");
            dgvTraining_name.Columns.Add("Batch", "သင်တန်းအမှတ်စဉ်");
            dgvTraining_name.Columns.Add("S_date", "သင်တန်းဖွင့်ပွဲ");
            dgvTraining_name.Columns.Add("E_date", "သင်တန်းဆင်းပွဲ");
            dgvTraining_name.Columns.Add("Qty", "သင်တန်းသားအင်အား");

            dgvTraining_name.Columns[0].FillWeight = 200;
            dgvTraining_name.Columns[1].FillWeight = 90;
            dgvTraining_name.Columns[2].FillWeight = 90;
            dgvTraining_name.Columns[3].FillWeight = 90;
            dgvTraining_name.Columns[4].FillWeight = 100;

            if (dst.Tables["training_info"].Rows.Count <= 0)
            {
                MessageBox.Show("သင်တန်းဆိုင်ရာအချက်အလက်များ ထည့်သွင်းထားခြင်းမရှိသေးပါ။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                return;
            }
            else
            {
                dgvTraining_name.Rows.Add(dst.Tables["training_info"].Rows.Count);
            }
            for (int i = 0; i < dst.Tables["training_info"].Rows.Count; i++)
            {
                
                dgvTraining_name.Rows[i].Tag  = dst.Tables["training_info"].Rows[i]["id"].ToString();
                dgvTraining_name.Rows[i].Cells["trainingName"].Value = dst.Tables["training_info"].Rows[i]["training_name"].ToString();
                dgvTraining_name.Rows[i].Cells["Batch"].Value = dst.Tables["training_info"].Rows[i]["batch"].ToString();
                dgvTraining_name.Rows[i].Cells["S_date"].Value = dst.Tables["training_info"].Rows[i]["start_date"].ToString();
                dgvTraining_name.Rows[i].Cells["E_date"].Value = dst.Tables["training_info"].Rows[i]["end_date"].ToString();
                dgvTraining_name.Rows[i].Cells["Qty"].Value = dst.Tables["training_info"].Rows[i]["trainner_quantity"].ToString();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbotraining_name.SelectedItem.ToString() == "")
                    MessageBox.Show("သင်တန်းအမည် ရွေးချယ်ရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else if (txtBatch.Text == "")
                    MessageBox.Show("သင်တန်းအမှတ်စဉ် ထည့်သွင်းရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else if (dtpkS_date.Text.Trim() == dtpkE_date.Text.Trim())
                    MessageBox.Show("သင်တန်းဖွင့်ပွဲ(ရက်) နှင့် သင်တန်းဆင်းပွဲ(ရက်) တူညီနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else if (txtQty.Text == "")
                    MessageBox.Show("သင်တန်းသားအင်အား ထည့်သွင်းရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else
                {
                    if (dst.Tables.Count != 0) dst.Tables.Clear();
                    load_training_name(cbotraining_name.SelectedItem.ToString());


                   
                    //add new training information                    
                    mysql.cmdText = "INSERT INTO training_info(training_name_id,training_name,batch,start_date,end_date,trainner_quantity) VALUES ('" + Convert .ToInt32 ( dst.Tables["training_name"].Rows[0]["training_name_id"]) + "','" + cbotraining_name.SelectedItem.ToString() + "','" + txtBatch.Text.Trim() + "','" + Eng_2_Myan (dtpkS_date.Text.Trim()) + "','" + Eng_2_Myan (dtpkE_date.Text.Trim()) + "','" + txtQty.Text.Trim() + "')";
                    mysql.insert();
                    tsslInfo.Text = "Success";
                    load_training_info(cbotraining_name.SelectedItem.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void cbotraining_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (dst.Tables.Count != 0) dst.Tables.Clear();
                load_training_info(cbotraining_name.SelectedItem.ToString());              
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            tsslInfo.Text = "Ready!";
        }

        private void btnEdit_MouseEnter(object sender, EventArgs e)
        {
            tsslInfo.Text = "Ready!";
        }

        private void btnDelete_MouseEnter(object sender, EventArgs e)
        {
            tsslInfo.Text = "Ready";
        }


       
        int c, r, b, s, end, q;
        private void dgvTraining_name_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //MessageBox.Show(e.ColumnIndex.ToString());
                //MessageBox.Show(dgvTraining_name[e.ColumnIndex, e.RowIndex].Value.ToString());

                if (e.ColumnIndex < 1)
                {
                    MessageBox.Show("သင်တန်းအမည်အား ြပြင်ဆင်၍မရပါ။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                    return;
                }
                if (dst.Tables.Count != 0) dst.Tables.Clear();
                c = e.ColumnIndex;
                r= e.RowIndex ;
                //b for batch, s for start_date, e for end_date, q for trainner_quantity, where id is in the datagridview Tag
                switch (c)
                {
                    case 1:
                        {
                            b = c;
                            s = c + 1;
                            end = c + 2;
                            q = c + 3;
                            break;
                        }
                    case 2:
                        {
                            b = c - 1;
                            s = c;
                            end = c + 1;
                            q = c + 2;
                            break;
                        }
                    case 3:
                        {
                            b = c - 2;
                            s = c - 1;
                            end = c;
                            q = c + 1;
                            break;
                        }
                    case 4:
                        {
                            b = c - 3;
                            s = c - 2;
                            end = c - 1;
                            q = c;
                            break;
                        }
                }

                int row1 = e.RowIndex;

                //MessageBox.Show(dgvTraining_name.Rows[row1].Tag.ToString());
                var dgv = dgvTraining_name;
                if (dst.Tables.Count != 0) dst.Tables.Clear();
                
                
                //mysql.cmdText = "UPDATE training_info SET batch=,start_date,end_date,trainner_quantity) VALUES ('" + Convert.ToInt32(dgv[b, r].Value.ToString()) + "','" + dgv[s, r].Value.ToString() + "','" + dgv[end, r].Value.ToString() + "','" + Convert.ToInt32(dgv[q, r].Value.ToString()) + "') WHERE id='"+ dgv .Rows [row1 ].Tag +"'";
                mysql.cmdText = "UPDATE training_info SET batch='" + dgv[b, r].Value.ToString() + "',start_date='" + dgv[s, r].Value.ToString() + "',end_date='" + dgv[end, r].Value.ToString() + "',trainner_quantity='" + dgv[q, r].Value.ToString()+ "' WHERE id='" + dgv.Rows[row1].Tag + "'";
                mysql.DataBind();

                //load_training_info("%");
                if (cbotraining_name .Text == "")
                {
                    load_training_info("%");
                }
                else
                {
                    load_training_info(dgvTraining_name.SelectedRows[0].Cells["trainingName"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
            
        }

        string batch, s_date, e_date,Qty;
        private void dgvTraining_name_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            batch = dgvTraining_name.SelectedRows[0].Cells["Batch"].Value.ToString();
            s_date  = dgvTraining_name.SelectedRows[0].Cells["S_date"].Value.ToString();
            e_date = dgvTraining_name.SelectedRows[0].Cells["E_date"].Value.ToString();
            Qty = dgvTraining_name.SelectedRows[0].Cells["Qty"].Value.ToString();            
        }

        private void dgvTraining_name_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    int currentMouseOverRow = dgvTraining_name.HitTest(e.X, e.Y).RowIndex;
                    if (currentMouseOverRow < 0)
                    {
                        //contextMenuStrip1.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                        MessageBox.Show("သင်၏ ရွေးချယ်မှူမှားယွင်းနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    dgvTraining_name.Rows[currentMouseOverRow].Selected = true;
                    contextMenuStrip1.Show(dgvTraining_name, new Point(e.X, e.Y));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("ယခုရွေးချယ်ထားသော အချက်အလက်အား ဖျက်ရန်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (dst.Tables.Count != 0) dst.Tables.Clear();
                    mysql.cmdText = "DELETE FROM training_info WHERE id='" + dgvTraining_name.SelectedRows[0].Tag + "'";
                    mysql.DataBind();
                    mysql.cmdText = "DELETE FROM officer_training_state WHERE training_info_id='" + dgvTraining_name.SelectedRows[0].Tag + "'";
                    mysql.DataBind();
                    mysql.cmdText = "DELETE FROM other_rank_training_state WHERE training_info_id='" + dgvTraining_name.SelectedRows[0].Tag + "'";
                    mysql.DataBind();
                    tsslInfo.Text = "Deleted";
                    if (cbotraining_name.SelectedItem == null)
                    {
                        load_training_info("%");
                    }
                    else
                    {
                        load_training_info(cbotraining_name.SelectedItem.ToString());
                    }
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        string Eng_2_Myan(string text)
        {
            string Myan_date = "";
            text .ToArray ();
            char text_change;
            for (int i = 0; i < text .Length ; i++)
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
                    default: text_change = '/'; break;
                }
                Myan_date += text_change;
                
            }

            return Myan_date;
        }

       

       

        
    }
}
