using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql_Database_Class;
using Excel = Microsoft.Office.Interop.Excel;
namespace trainees_Management_System
{
    public partial class frmOther_rank : Form
    {
        DataSet dst = new DataSet();
        MySqlDB mysql = new MySqlDB();
        string server_pass = "";
        Font font = new Font("Zawgyi-One Regular", 10F, System.Drawing.FontStyle.Bold);
        public frmOther_rank()
        {
            InitializeComponent();
        }

        private void frmOther_rank_Load(object sender, EventArgs e)
        {
            try
            {
                this.WindowState = FormWindowState.Maximized;
                mysql.constring = "Data Source= localhost;Database=engineering_school;User ID=root;Password=" + server_pass + ";charset=utf8";
                dgvOther_rank.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

                //Display Columns Header
                dgvOther_rank.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                dgvOther_rank.ColumnHeadersHeight = 25;
                dgvOther_rank.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvOther_rank.CellPainting += new DataGridViewCellPaintingEventHandler(dgvOther_rank_CellPainting);
                dgvOther_rank.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgvOfficer.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;




                //to get officer name
                mysql.tablename = "other_rank_name";
                mysql.cmdText = "SELECT * FROM other_rank_name";
                mysql.DataBind();
                dst = mysql.dst;

                //to get training information
                mysql.tablename = "training_name";
                mysql.cmdText = "SELECT * FROM training_name WHERE row=2 OR row=3";
                mysql.DataBind();
                dst = mysql.dst;

                //datagridview add columns
                dgvOther_rank.Columns.Add(dst.Tables["other_rank_name"].Columns["other_rank_id"].ToString(), "စဉ်");
                dgvOther_rank.Columns[dst.Tables["other_rank_name"].Columns["other_rank_id"].ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvOther_rank.Columns.Add(dst.Tables["other_rank_name"].Columns["service_no"].ToString(), "ကိုယ်ပိုင်နံပါတ်");
                dgvOther_rank.Columns.Add(dst.Tables["other_rank_name"].Columns["rank"].ToString(), "အဆင့်");
                dgvOther_rank.Columns.Add(dst.Tables["other_rank_name"].Columns["name"].ToString(), "အမည်");
                dgvOther_rank.Columns.Add(dst.Tables["other_rank_name"].Columns["battalion"].ToString(), "တပ်");
                dgvOther_rank.Columns.Add(dst.Tables["other_rank_name"].Columns["edu_level"].ToString(), "ပညာရပ်");
                dst.Tables.Remove("other_rank_name");

                for (int i = 0; i < dst.Tables["training_name"].Rows.Count; i++)
                {
                    dgvOther_rank.Columns.Add(dst.Tables["training_name"].Rows[i]["training_name_id"].ToString(), dst.Tables["training_name"].Rows[i]["training_name"].ToString());
                    Size titleSize = TextRenderer.MeasureText(dst.Tables["training_name"].Rows[i]["training_name"].ToString(), font);
                    if (this.dgvOther_rank.ColumnHeadersHeight < titleSize.Width)
                    {
                        this.dgvOther_rank.ColumnHeadersHeight = titleSize.Width - 20;
                    }
                }

                if (dst.Tables["training_name"].Rows.Count > 0)
                {
                    for (int i = 0; i < dst.Tables["training_name"].Rows.Count; i++)
                    {
                        ComboboxItem item = new ComboboxItem();
                        item.Text = dst.Tables["training_name"].Rows[i]["training_name"].ToString();
                        item.Value = dst.Tables["training_name"].Rows[i]["training_name_id"].ToString();
                        cbotrainningName.Items.Add(item);
                        cboSearchTRaining.Items.Add(item);
                    }
                }
                else
                {
                    MessageBox.Show("သင်တန်းအမည် ထည့်သွင်းထားခြင်းမရှိသေးပါ။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                load_training_info("%");
                load_training_state();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                    default: text_change = '/'; break;
                }
                Myan_date += text_change;

            }

            return Myan_date;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtS_num.Text.Trim() == "")
                    MessageBox.Show("ကိုယ်ပိုင်နံပါတ် ထည့်သွင်းရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else if (cboRank.Text == "")
                    MessageBox.Show("အဆင့် ရွေးချယ်ရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else if (txtName.Text.Trim() == "")
                    MessageBox.Show("အမည် ထည့်သွင်းရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else if (txtBattalion.Text.Trim() == "")
                    MessageBox.Show("တပ်/ဌာန ထည့်သွင်းရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else if (cboService_name. Text.Trim() == "")
                    MessageBox.Show("ကပ/တ ရွေးချယ်ရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else
                {
                    if (dst.Tables.Count != 0) dst.Tables.Clear();

                    string S_num = "";
                    if (cboService_name.Text.ToString() == "ကပ")
                    {
                        S_num = txtS_num.Text.Trim();                        
                    }
                    else
                    {
                        S_num = cboService_name.Text.ToString() + txtS_num.Text.Trim();
                    }


                    //Insert new officer information to table 'officer_name' 
                    mysql.cmdText = "INSERT INTO other_rank_name(service_no,rank,name,battalion,edu_level) VALUES ('" + S_num + "','" + cboRank.Text.Trim() + "','" + txtName.Text.Trim() + "','" + txtBattalion.Text.Trim() + "','" + cboEdu_lvl.Text.Trim() + "')";
                    mysql.insert();
                    tsslInfo.Text = "Success...";

                    if (dst.Tables.Count != 0) dst.Tables.Clear();
                  
                    load_training_info("%");
                    load_training_state();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void load_training_info(string service_no)
        {
            
            dgvOther_rank.Rows.Clear();
            dgvOther_rank.Refresh();
            


            //to get officer name
            mysql.tablename = "other_rank_name";
            mysql.cmdText = "SELECT * FROM other_rank_name WHERE service_no LIKE '" + service_no + "'";
            mysql.DataBind();
            dst = mysql.dst;

            
            if (dst.Tables["other_rank_name"].Rows.Count > 0) dgvOther_rank.Rows.Add(dst.Tables["other_rank_name"].Rows.Count);
            for (int i = 0; i < dst.Tables["other_rank_name"].Rows.Count; i++)
            {
                dgvOther_rank.Rows[i].Tag = dst.Tables["other_rank_name"].Rows[i]["other_rank_id"].ToString();
                dgvOther_rank.Rows[i].Cells["other_rank_id"].Value = Eng_2_Myan((i + 1).ToString());
                dgvOther_rank.Rows[i].Cells["service_no"].Value = dst.Tables["other_rank_name"].Rows[i]["service_no"].ToString();
                dgvOther_rank.Rows[i].Cells["rank"].Value = dst.Tables["other_rank_name"].Rows[i]["rank"].ToString();
                dgvOther_rank.Rows[i].Cells["name"].Value = dst.Tables["other_rank_name"].Rows[i]["name"].ToString();
                dgvOther_rank.Rows[i].Cells["battalion"].Value = dst.Tables["other_rank_name"].Rows[i]["battalion"].ToString();
                dgvOther_rank.Rows[i].Cells["edu_level"].Value = dst.Tables["other_rank_name"].Rows[i]["edu_level"].ToString();

            }

            dst.Tables.Remove("other_rank_name");
        }

        private void btnAdd_Tstate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch_S_num.Text.Trim() == "")
                    MessageBox.Show("ကိုယ်ပိုင်နံပါတ် ထည့်သွင်းရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else if (cbotrainningName.Text == "")
                    MessageBox.Show("သင်တန်းအမည် ရွေးချယ်ရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else if (txtSearch_ORank.Text.Trim() == "")
                    MessageBox.Show("အမည် ရွေးချယ်ရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else if (cboBatch .Text.Trim() == "")
                    MessageBox.Show("သင်တန်းအမှတ်စဉ် ရွေးချယ်ရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else if (txtGrade. Text.Trim() == "")
                    MessageBox.Show("သင်တန်းဆင်းအရည်အချင်း ရွေးချယ်ရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else if (cboSearch_S_name. Text.Trim() == "")
                    MessageBox.Show("ကပ/တ ရွေးချယ်ရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else
                {
                    if (dst.Tables.Count != 0) dst.Tables.Clear();

                    string S_num = "";
                    if (cboSearch_S_name.Text.ToString() == "ကပ")
                    {
                        S_num = txtSearch_S_num.Text.Trim();
                    }
                    else
                    {
                        S_num = cboSearch_S_name.Text.ToString() + txtSearch_S_num.Text.Trim();
                    }

                    //to get other rank name
                    mysql.tablename = "other_rank_name";
                    mysql.cmdText = "SELECT * FROM other_rank_name WHERE service_no LIKE '" + S_num + "'";
                    mysql.DataBind();
                    dst = mysql.dst;
                    string other_rank_id = dst.Tables["other_rank_name"].Rows[0]["other_rank_id"].ToString();
                    //MessageBox.Show(dst.Tables["other_rank_name"].Rows[0]["other_rank_id"].ToString());

                    mysql.tablename = "training_info";
                    mysql.cmdText = "SELECT id FROM training_info WHERE training_name_id='" + (cbotrainningName.SelectedItem as ComboboxItem).Value + "' AND batch='" + cboBatch.Text.Trim() + "'";                    
                    mysql.DataBind();
                    dst = mysql.dst;

                    if (dst.Tables["training_info"].Rows.Count > 0)
                    {

                        //Check other rank already attended this class
                        mysql.tablename = "training_state";
                        //mysql.cmdText = "SELECT * FROM other_rank_training_state WHERE other_rank_id='" + other_rank_id  + "' AND training_info_id='" + dst.Tables["training_info"].Rows[0]["id"] + "'";
                        mysql.cmdText = "SELECT * FROM other_rank_training_state WHERE other_rank_id='" + other_rank_id + "' AND training_name_id='" + (cbotrainningName.SelectedItem as ComboboxItem).Value + "'";
                        mysql.DataBind();
                        if (dst.Tables["training_state"].Rows.Count > 0)
                        {
                            MessageBox.Show("ဤစစ်သည်မှာ ယခုထည့်သွင်းလိုက်သောသင်တန်းအား တက်ရောက်ပြီးဖြစ်ပါသည်။", "သင်တန်းသားဆိုင်ရာ သတင်းပေးချက်");
                            dst.Tables.Remove("training_state");
                            return;
                        }
                        dst.Tables.Remove("training_state");

                        //Insert new officer information to table 'officer_name' 
                        mysql.cmdText = "INSERT INTO other_rank_training_state(other_rank_id,training_name_id,batch,grade,training_info_id) VALUES ('" + other_rank_id + "','" + (cbotrainningName.SelectedItem as ComboboxItem).Value.ToString() + "','" + cboBatch.Text.Trim() + "','" + txtGrade.Text.Trim() + "','" + dst.Tables["training_info"].Rows[0]["id"] + "')";
                        mysql.insert();
                        tsslInfo.Text = "Success...";

                        if (dst.Tables.Count != 0) dst.Tables.Clear();                   
                        load_training_info("%");
                        load_training_state();
                    }
                    else
                    {
                        MessageBox.Show("ယခုရွေးချယ်ထားသော အပတ်စဉ်ဖွင့်လှစ်ထားခြင်းမရှိသေးပါ။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        void load_training_state()
        {
            dst = new DataSet();

            //get training name from table
            mysql.tablename = "other_rank_training";
            mysql.cmdText = "SELECT * FROM other_rank_training_state";
            mysql.DataBind();
            dst = mysql.dst;
            //MessageBox.Show(dst.Tables["other_rank_training"].Rows.Count.ToString());
            if (dst.Tables["other_rank_training"].Rows.Count > 0)
            {
                for (int i = 0; i < dst.Tables["other_rank_training"].Rows.Count; i++)
                {
                    for (int j = 0; j < dgvOther_rank . Rows.Count; j++)
                    {
                        if (dst.Tables["other_rank_training"].Rows[i]["other_rank_id"].ToString() == dgvOther_rank.Rows[j].Tag.ToString())
                        {
                            dgvOther_rank.Rows[j].Cells[dst.Tables["other_rank_training"].Rows[i]["training_name_id"].ToString()].Value = dst.Tables["other_rank_training"].Rows[i]["batch"].ToString();
                        }
                    }

                }

            }
            else
            {
                //MessageBox.Show("သင်တန်းအမည် ထည့်သွင်းထားခြင်းမရှိသေးပါ။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်",MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            dst.Tables.Remove("other_rank_training");

        }

        private void txtSearch_S_num_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dst.Tables.Count != 0) dst.Tables.Clear();
                //to get officer name
                mysql.tablename = "other_rank_name";
                mysql.cmdText = "SELECT * FROM other_rank_name";
                mysql.DataBind();
                dst = mysql.dst;

                string S_num = "";
                if (cboSearch_S_name.Text.ToString() == "ကပ")
                {
                    S_num = txtSearch_S_num.Text.Trim();
                }
                else
                {
                    S_num = cboSearch_S_name.Text.ToString() + txtSearch_S_num.Text.Trim();
                }

                for (int i = 0; i < dst.Tables["other_rank_name"].Rows.Count; i++)
                {
                    if (S_num == dst.Tables["other_rank_name"].Rows[i]["service_no"].ToString())
                    {

                        txtSearch_ORank.Text = dst.Tables["other_rank_name"].Rows[i]["name"].ToString();
                        break;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        bool Search = false; // Searching data and then to show all data
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string S_num = "";
                if (cboIndi_search.Text.ToString() == "ကပ")
                {
                    S_num = txtSn_search.Text.Trim();
                }
                else
                {
                    S_num = cboIndi_search.Text.ToString() + txtSn_search.Text.Trim();
                }

                if (dst.Tables.Count != 0) dst.Tables.Clear();
                load_training_info(S_num);
                load_training_state();
                Search = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        string edit_other_id, edit_training_name_id;
        private void dgvOther_rank_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                edit_other_id = dgvOther_rank . SelectedRows[0].Tag.ToString();
                edit_training_name_id = dgvOther_rank.Columns[e.ColumnIndex].Name.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvOther_rank_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex <6 )
                {
                    mysql.cmdText = "UPDATE other_rank_name SET service_no='" + dgvOther_rank.Rows[e.RowIndex].Cells[1].Value.ToString() +
                        "',rank='" + dgvOther_rank.Rows[e.RowIndex].Cells[2].Value.ToString() +
                        "',name='" + dgvOther_rank.Rows[e.RowIndex].Cells[3].Value.ToString() +
                        "',battalion='" + dgvOther_rank.Rows[e.RowIndex].Cells[4].Value.ToString() +
                        "',edu_level='" + dgvOther_rank.Rows[e.RowIndex].Cells[5].Value.ToString() +
                        "' WHERE other_rank_id='" + dgvOther_rank.Rows[e.RowIndex].Tag + "'";
                    mysql.DataBind();

                    load_training_info("%");
                    load_training_state();
                    MessageBox.Show("Other rank information changing!");
                }
                else
                {
                    mysql.cmdText = "UPDATE other_rank_training_state SET batch='" + dgvOther_rank.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() +
                        "' WHERE other_rank_id='" + dgvOther_rank.Rows[e.RowIndex].Tag + "' AND training_name_id='" + dgvOther_rank.Columns[e.ColumnIndex].Name.ToString() + "'";
                    mysql.DataBind();

                    load_training_info("%");
                    load_training_state();
                    
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("ယခုရွေးချယ်ထားသော အချက်အလက်အား ဖျက်ရန် 'Yes' ကိုနှိပ်ပါ။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (dst.Tables.Count != 0) dst.Tables.Clear();
                    mysql.cmdText = "DELETE FROM other_rank_training_state WHERE other_rank_id='" + dgvOther_rank.SelectedRows[0].Tag + "'";
                    mysql.DataBind();

                    mysql.cmdText = "DELETE FROM other_rank_name WHERE other_rank_id='" + dgvOther_rank.SelectedRows[0].Tag + "'";
                    mysql.DataBind();
                    tsslInfo.Text = "Deleted";

                    load_training_info("%");
                    load_training_state();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvOther_rank_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    int currentMouseOverRow = dgvOther_rank.HitTest(e.X, e.Y).RowIndex;
                    if (currentMouseOverRow < 0)
                    {
                        //contextMenuStrip1.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                        MessageBox.Show("သင်၏ ရွေးချယ်မှူမှားယွင်းနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    dgvOther_rank.Rows[currentMouseOverRow].Selected = true;
                    contextMenuStrip1.Show(dgvOther_rank, new Point(e.X, e.Y));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Search)
            {
                load_training_info("%");
                load_training_state();
                Search = false;
            }
        }

        private void cboSearchTRaining_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvOther_rank.Rows.Count; i++)
            {
                if (dgvOther_rank.Rows[i].Cells[cboSearchTRaining.SelectedIndex + 6].Value == null)
                {
                    dgvOther_rank.Rows[i].Cells[cboSearchTRaining.SelectedIndex + 6].Style.BackColor = Color.Green;
                }
            }
        }

        private void dgvOther_rank_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //check that we are in a header cell
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                e.PaintBackground(e.ClipBounds, true);
                Rectangle rect = this.dgvOther_rank.GetColumnDisplayRectangle(e.ColumnIndex, true);
                Size titleSize = TextRenderer.MeasureText(e.Value.ToString(), font);
                //if (this.dgvOther_rank.ColumnHeadersHeight < titleSize.Width)
                //{
                //    this.dgvOther_rank.ColumnHeadersHeight = titleSize.Width;
                //}

                e.Graphics.TranslateTransform(0, titleSize.Width);
                e.Graphics.RotateTransform(-90.0F);

                e.Graphics.DrawString(e.Value.ToString(), font, Brushes.Black, new PointF(rect.Y - (dgvOther_rank.ColumnHeadersHeight - titleSize.Width), rect.X));

                e.Graphics.RotateTransform(90.0F);
                e.Graphics.TranslateTransform(0, -titleSize.Width);
                e.Handled = true;

            }
        }

        private void dgvOther_rank_Sorted(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dataGridViewRow in dgvOther_rank.Rows.Cast<DataGridViewRow>())
                {
                    dataGridViewRow.Cells[0].Value = Eng_2_Myan((dataGridViewRow.Index + 1).ToString());
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
                mysql.cmdText = "SELECT * FROM training_info WHERE training_name='" + cbotrainningName.Text + "' ORDER BY batch";
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
                    MessageBox.Show("သင်တန်းအမည် ထည့်သွင်းထားခြင်းမရှိသေးပါ။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                dst.Tables.Remove("training_info");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboRank_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvOther_rank.Rows.Clear();
            dgvOther_rank.Refresh();
            


            //to get officer name
            mysql.tablename = "other_rank_name";
            mysql.cmdText = "SELECT * FROM other_rank_name WHERE rank='" + cboRank_Search.Text .Trim () + "'";
            mysql.DataBind();
            dst = mysql.dst;

            
            if (dst.Tables["other_rank_name"].Rows.Count > 0) dgvOther_rank.Rows.Add(dst.Tables["other_rank_name"].Rows.Count);
            for (int i = 0; i < dst.Tables["other_rank_name"].Rows.Count; i++)
            {
                dgvOther_rank.Rows[i].Tag = dst.Tables["other_rank_name"].Rows[i]["other_rank_id"].ToString();
                dgvOther_rank.Rows[i].Cells["other_rank_id"].Value = Eng_2_Myan((i + 1).ToString());
                dgvOther_rank.Rows[i].Cells["service_no"].Value = dst.Tables["other_rank_name"].Rows[i]["service_no"].ToString();
                dgvOther_rank.Rows[i].Cells["rank"].Value = dst.Tables["other_rank_name"].Rows[i]["rank"].ToString();
                dgvOther_rank.Rows[i].Cells["name"].Value = dst.Tables["other_rank_name"].Rows[i]["name"].ToString();
                dgvOther_rank.Rows[i].Cells["battalion"].Value = dst.Tables["other_rank_name"].Rows[i]["battalion"].ToString();
                dgvOther_rank.Rows[i].Cells["edu_level"].Value = dst.Tables["other_rank_name"].Rows[i]["edu_level"].ToString();

            }

            dst.Tables.Remove("other_rank_name");
            load_training_state();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {

                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                //worksheet.PageSetup.CenterHeader = lblTraining.Text;
                //worksheet.PageSetup.LeftHeader = label1.Text + "   " + lblS_date.Text;
                //worksheet.PageSetup.RightHeader = label2.Text + "   " + lblE_date.Text;
                workbook.WebOptions.Encoding = Microsoft.Office.Core.MsoEncoding.msoEncodingUTF8;
                app.StandardFont = "Myanmar3";
                app.StandardFontSize = 10;
                for (int i = 1; i < dgvOther_rank.Columns.Count + 1; i++)
                {
                    //worksheet.Range ["A1"].Style 
                    worksheet.Cells[1, i] = dgvOther_rank.Columns[i - 1].HeaderText.ToString();
                }
                for (int i = 0; i <= dgvOther_rank.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvOther_rank.Columns.Count; j++)
                    {
                        if (dgvOther_rank.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgvOther_rank.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = "";
                        }
                    }
                }


                object misValue = System.Reflection.Missing.Value;
                string caption = "";
                if (cboRank_Search.Text.Trim() != "")
                {
                    caption = "စစ်သည်စာရင်း(" + cboRank_Search.Text.Trim() + ").xls";
                }
                else
                {
                    caption = "စစ်သည်စာရင်း.xls";
                }
                workbook.SaveAs(caption, Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                workbook.Close(true, misValue, misValue);
                app.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

    
}
