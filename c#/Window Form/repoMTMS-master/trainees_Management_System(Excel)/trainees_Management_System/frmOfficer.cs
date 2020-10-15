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
using System.IO;
using System.Data.OleDb;
//using DataGridViewAutoFilter;;
namespace trainees_Management_System
{
    public partial class frmOfficer : Form
    {

        DataSet dst = new DataSet();
        MySqlDB mysql = new MySqlDB();
        string server_pass = "";
        Font font = new Font("Zawgyi-One Regular", 10F, System.Drawing.FontStyle.Bold);

        public frmOfficer()
        {
            InitializeComponent();
        }

        private void frmOfficer_Load(object sender, EventArgs e)
        {
            try
            {
                mysql.constring = "Data Source= localhost;Database=engineering_school;User ID=root;Password=" + server_pass + ";charset=utf8";
                //dgvOfficer.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


                //Display Columns Header
                dgvOfficer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
                dgvOfficer.ColumnHeadersHeight = 25;
                dgvOfficer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvOfficer.CellPainting += new DataGridViewCellPaintingEventHandler(dgvOfficer_CellPainting);
                dgvOfficer.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //dgvOfficer.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
                

                dgvOfficer.Invalidate();
                //dgvOfficer.AutoSizeRowsMode = DataGridViewAutoSizeRowMode.RowHeader;
                this.WindowState = FormWindowState.Maximized;

                if (dst.Tables.Count != 0) dst.Tables.Clear();
                dgvOfficer.Columns.Clear();
                dgvOfficer.Rows.Clear();
                dgvOfficer.Refresh();
                cbotrainningName.Items.Clear();

                //to get training information
                mysql.tablename = "training_name";
                mysql.cmdText = "SELECT * FROM training_name WHERE row=1 OR row=3";
                mysql.DataBind();
                dst = mysql.dst;

                //to get officer name
                mysql.tablename = "officer_name";
                mysql.cmdText = "SELECT * FROM officer_name";
                mysql.DataBind();
                dst = mysql.dst;

                //datagridview add columns
                dgvOfficer.Columns.Add(dst.Tables["officer_name"].Columns["officer_id"].ToString(), "စဉ်");
                dgvOfficer.Columns[dst.Tables["officer_name"].Columns["officer_id"].ToString()].SortMode = DataGridViewColumnSortMode.NotSortable;
                dgvOfficer.Columns.Add(dst.Tables["officer_name"].Columns["bc_no"].ToString(), "ပြန်တမ်း၀င်အမှတ်");
                dgvOfficer.Columns.Add(dst.Tables["officer_name"].Columns["rank"].ToString(), "အဆင့်");
                dgvOfficer.Columns.Add(dst.Tables["officer_name"].Columns["name"].ToString(), "အမည်");
                dgvOfficer.Columns.Add(dst.Tables["officer_name"].Columns["battalion"].ToString(), "တပ်");               
                dst.Tables.Remove("officer_name");
                for (int i = 0; i < dst.Tables["training_name"].Rows.Count; i++)
                {
                    
                    dgvOfficer.Columns.Add(dst.Tables["training_name"].Rows[i]["training_name_id"].ToString(), dst.Tables["training_name"].Rows[i]["training_name"].ToString());
                    Size titleSize = TextRenderer.MeasureText(dst.Tables["training_name"].Rows[i]["training_name"].ToString(), font);
                    if (this.dgvOfficer.ColumnHeadersHeight < titleSize.Width)
                    {
                        this.dgvOfficer.ColumnHeadersHeight = titleSize.Width - 20;
                    }
                }

                //get training name from table to combobox

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

                load_officer_info("%");
                load_training_state();
                //DataTable dt = new DataTable();
                //foreach (DataGridViewColumn col in dgvOfficer.Columns)
                //{
                //    dt.Columns.Add(col.Name);
                //}

                //foreach (DataGridViewRow row in dgvOfficer.Rows)
                //{
                //    DataRow dRow = dt.NewRow();
                //    foreach (DataGridViewCell cell in row.Cells)
                //    {
                //        dRow[cell.ColumnIndex] = cell.Value;
                //    }
                //    dt.Rows.Add(dRow);
                //}
                //DataView dv;
                //dv = new DataView(dt ,"rank = 'ဗိုလ်' ", "rank Desc", DataViewRowState.CurrentRows );
                //dgvOfficer.DataSource = dv;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


        void dgvOfficer_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //check that we are in a header cell
            if (e.RowIndex == -1 && e.ColumnIndex >= 0)
            {
                e.PaintBackground(e.ClipBounds, true);
                Rectangle rect = this.dgvOfficer.GetColumnDisplayRectangle(e.ColumnIndex, true);
                Size titleSize = TextRenderer.MeasureText(e.Value.ToString(), font);
                //if (this.dgvOfficer.ColumnHeadersHeight < titleSize.Width)
                //{
                //    this.dgvOfficer.ColumnHeadersHeight = titleSize.Width;
                //}

                e.Graphics.TranslateTransform(0, titleSize.Width);
                e.Graphics.RotateTransform(-90.0F);

                e.Graphics.DrawString(e.Value.ToString(), font, Brushes.Black, new PointF(rect.Y - (dgvOfficer.ColumnHeadersHeight - titleSize.Width), rect.X));

                e.Graphics.RotateTransform(90.0F);
                e.Graphics.TranslateTransform(0, -titleSize.Width);
                e.Handled = true;
            
            }
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtBc_no.Text.Trim () == "")
                    MessageBox.Show("ပြန်တမ်း၀င်အမှတ် ထည့်သွင်းရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else if(cboRank .Text == "")
                    MessageBox.Show("အဆင့် ရွေးချယ်ရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else if(txtName .Text.Trim () == "")
                    MessageBox.Show("အမည် ထည့်သွင်းရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else if (txtBattalion.Text.Trim() == "")
                    MessageBox.Show("တပ်/ဌာန ထည့်သွင်းရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else
                {
                    if (dst.Tables.Count != 0) dst.Tables.Clear();

                    string bc = "ကြည်း-"+ txtBc_no.Text .Trim ();
                    //Insert new officer information to table 'officer_name' 
                    mysql.cmdText = "INSERT INTO officer_name(bc_no,rank,name,battalion) VALUES ('" +bc+"','" +cboRank.Text .Trim ()+"','" +txtName.Text .Trim ()+"','" +txtBattalion.Text .Trim ()+"')";
                    mysql.insert();
                    tsslInfo.Text = "Success...";                   
                    
                    
                    load_officer_info("%");
                    load_training_state();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void load_officer_info(string bc_no)
        {

            dgvOfficer.Rows.Clear();
            dgvOfficer.Refresh();
            //to get officer name
            mysql.tablename = "officer_name";
            mysql.cmdText = "SELECT * FROM officer_name WHERE bc_no LIKE '" +bc_no +"'" ;
            mysql.DataBind();
            dst = mysql.dst;

           
            if(dst.Tables["officer_name"].Rows .Count > 0 ) dgvOfficer.Rows.Add(dst.Tables["officer_name"].Rows.Count);
            for (int i = 0; i < dst.Tables["officer_name"].Rows .Count ; i++)
            {
                dgvOfficer.Rows[i].Tag = dst.Tables["officer_name"].Rows[i]["officer_id"].ToString();
                dgvOfficer.Rows[i].Cells["officer_id"].Value = Eng_2_Myan (( i + 1).ToString ());
                dgvOfficer .Rows [i].Cells ["bc_no"].Value = dst .Tables ["officer_name"].Rows [i]["bc_no"].ToString ();
                dgvOfficer.Rows[i].Cells["rank"].Value = dst.Tables["officer_name"].Rows[i]["rank"].ToString();
                dgvOfficer.Rows[i].Cells["name"].Value = dst.Tables["officer_name"].Rows[i]["name"].ToString();
                dgvOfficer.Rows[i].Cells["battalion"].Value = dst.Tables["officer_name"].Rows[i]["battalion"].ToString();

            }
            dst.Tables.Remove("officer_name");

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


        private void btnAdd_MouseEnter(object sender, EventArgs e)
        {
            tsslInfo.Text = "Ready...";
        }

        void load_training_state()
        {
            dst = new DataSet();

            //get training name from table
            mysql.tablename = "officer_training_state";
            mysql.cmdText = "SELECT * FROM officer_training_state";
            mysql.DataBind();
            dst = mysql.dst;

            if (dst.Tables["officer_training_state"].Rows.Count > 0)
            {
                for (int i = 0; i < dst.Tables ["officer_training_state"].Rows.Count ; i++)
			    {
                    for (int j = 0; j < dgvOfficer .Rows .Count ; j++)
                    {
                        if (dst.Tables["officer_training_state"].Rows[i]["officer_id"].ToString() == dgvOfficer.Rows[j].Tag.ToString())
                        {
                            dgvOfficer.Rows[j].Cells[dst.Tables["officer_training_state"].Rows[i]["training_name_id"].ToString()].Value = dst.Tables["officer_training_state"].Rows[i]["batch"].ToString();
                            break;
                        }
                    }
                    
			    }
                
            }
            else
            {
                //MessageBox.Show("သင်တန်းအမည် ထည့်သွင်းထားခြင်းမရှိသေးပါ။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်",MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            dst.Tables.Remove("officer_training_state");


        }

        private void cbotrainningName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show((cbotrainningName.SelectedItem as ComboboxItem).Text.ToString(), (cbotrainningName.SelectedItem as ComboboxItem).Value.ToString());
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

        private void btnAdd_Tstate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch_bc .Text.Trim() == "")
                    MessageBox.Show("ပြန်တမ်း၀င်အမှတ် ထည့်သွင်းရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else if (cbotrainningName.Text == "")
                    MessageBox.Show("သင်တန်းအမည် ရွေးချယ်ရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else if (txtSearch_Officer.Text.Trim() == "")
                    MessageBox.Show("အမည် ရွေးချယ်ရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else if (cboBatch.Text.Trim() == "")
                    MessageBox.Show("သင်တန်းအမှတ်စဉ် ရွေးချယ်ရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else if (txtSearch_bc.Text.Trim() == "")
                    MessageBox.Show("ပြန်တမ်း၀င်အမှတ် ရွေးချယ်ရန်ကျန်ရှိနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                else
                {
                    if (dst.Tables.Count != 0) dst.Tables.Clear();

                    string bc = "ကြည်း-" + txtSearch_bc.Text.Trim();


                    //to get officer name
                    mysql.tablename = "officer_name";
                    mysql.cmdText = "SELECT * FROM officer_name WHERE bc_no LIKE '" + bc + "'";
                    mysql.DataBind();
                    dst = mysql.dst;
                    string officer_id = dst.Tables["officer_name"].Rows[0]["officer_id"].ToString();
                    //MessageBox.Show(dst.Tables["officer_name"].Rows[0]["officer_id"].ToString());

                    mysql.tablename = "training_info";
                    mysql.cmdText = "SELECT id FROM training_info WHERE training_name_id='" + (cbotrainningName.SelectedItem as ComboboxItem).Value + "' AND batch='" + cboBatch .Text .Trim ()  + "'";
                    mysql.DataBind();
                    dst = mysql.dst;
                    

                    if (dst.Tables["training_info"].Rows.Count > 0)
                    {
                        //Check officer already attended this class
                        mysql.tablename = "training_state";
                        //mysql.cmdText = "SELECT * FROM officer_training_state WHERE officer_id='" + officer_id + "' AND training_info_id='" + dst.Tables["training_info"].Rows[0]["id"] + "'";
                        mysql.cmdText = "SELECT * FROM officer_training_state WHERE officer_id='" + officer_id + "' AND training_name_id='" + (cbotrainningName.SelectedItem as ComboboxItem).Value + "'";
                        mysql.DataBind();
                        if (dst.Tables["training_state"].Rows.Count > 0)
                        {
                            MessageBox.Show("ဤအရာရှိမှာ ယခုထည့်သွင်းလိုက်သောသင်တန်းအား တက်ရောက်ပြီးဖြစ်ပါသည်။", "သင်တန်းသားဆိုင်ရာ သတင်းပေးချက်");
                            dst.Tables.Remove("training_state");
                            return;
                        }
                        dst.Tables.Remove("training_state");

                        //Insert new officer information to table 'officer_name' 
                        mysql.cmdText = "INSERT INTO officer_training_state(officer_id,training_name_id,batch,grade,training_info_id) VALUES ('" + officer_id + "','" + (cbotrainningName.SelectedItem as ComboboxItem).Value.ToString() + "','" + cboBatch.Text.Trim() + "','" + txtGrade.Text.Trim() + "','"+ dst .Tables ["training_info"].Rows[0]["id"] +"')";
                        mysql.insert();
                        tsslInfo.Text = "Success...";

                        if (dst.Tables.Count != 0) dst.Tables.Clear();                        
                        load_officer_info("%");
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

        private void txtSearch_bc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (dst.Tables.Count != 0) dst.Tables.Clear();
                //to get officer name
                mysql.tablename = "officer_name";
                mysql.cmdText = "SELECT * FROM officer_name";
                mysql.DataBind();
                dst = mysql.dst;
                
                

                for (int i = 0; i < dst.Tables["officer_name"].Rows.Count ; i++)
                {
                    if ("ကြည်း-"+txtSearch_bc.Text.Trim() == dst.Tables["officer_name"].Rows[i]["bc_no"].ToString())
                    {
                        
                        txtSearch_Officer.Text = dst.Tables["officer_name"].Rows[i]["name"].ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        bool Search = false;// Searching data and then to show all data
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (dst.Tables.Count != 0) dst.Tables.Clear();

                load_officer_info("ကြည်း-" + txtBc_search.Text.Trim());
                load_training_state();
                Search = true ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        string edit_off_id, edit_training_name_id;
        private void dgvOfficer_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            try
            {
                edit_off_id = dgvOfficer.SelectedRows[0].Tag.ToString();
                edit_training_name_id = dgvOfficer.Columns[e.ColumnIndex].Name.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dgvOfficer_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex < 5)
                {
                    mysql.cmdText = "UPDATE officer_name SET bc_no='" + dgvOfficer.Rows[e.RowIndex].Cells[1].Value.ToString() + 
                        "',rank='" +  dgvOfficer.Rows[e.RowIndex].Cells[2].Value.ToString() + 
                        "',name='" + dgvOfficer.Rows[e.RowIndex].Cells[3].Value.ToString() + 
                        "',battalion='" + dgvOfficer.Rows[e.RowIndex].Cells[4].Value.ToString() +
                        "' WHERE officer_id='" + dgvOfficer.Rows[e.RowIndex].Tag +"'";
                    mysql.DataBind();

                    load_officer_info("%");
                    load_training_state();
                    MessageBox.Show("officer information changing");

                }
                else 
                {
                    mysql.cmdText = "UPDATE officer_training_state SET batch='" + dgvOfficer .Rows[e.RowIndex ].Cells[e.ColumnIndex].Value .ToString () +
                        "' WHERE officer_id='" + dgvOfficer .Rows [e.RowIndex].Tag + "' AND training_name_id='" + dgvOfficer .Columns [e.ColumnIndex ].Name .ToString ()+ "'" ;
                    mysql.DataBind();

                    load_officer_info("%");
                    load_training_state();
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }
        }

        private void dgvOfficer_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Right)
                {
                    int currentMouseOverRow = dgvOfficer . HitTest(e.X, e.Y).RowIndex;
                    if (currentMouseOverRow < 0)
                    {
                        //contextMenuStrip1.MenuItems.Add(new MenuItem(string.Format("Do something to row {0}", currentMouseOverRow.ToString())));
                        MessageBox.Show("သင်၏ ရွေးချယ်မှူမှားယွင်းနေပါသည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    dgvOfficer.Rows[currentMouseOverRow].Selected = true;
                    contextMenuStrip1.Show(dgvOfficer, new Point(e.X, e.Y));
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
                DialogResult result = MessageBox.Show("ယခုရွေးချယ်ထားသော အချက်အလက်အား ဖျက်ရန် 'Yes' ကိုနှိပ်ပါ။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (dst.Tables.Count != 0) dst.Tables.Clear();
                    mysql.cmdText = "DELETE FROM officer_training_state WHERE officer_id='" +  dgvOfficer.SelectedRows[0].Tag + "'";
                    mysql.DataBind();

                    mysql.cmdText = "DELETE FROM officer_name WHERE officer_id='" + dgvOfficer.SelectedRows[0].Tag + "'";
                    mysql.DataBind();
                    tsslInfo.Text = "Deleted";
                    load_officer_info("%");
                    load_training_state();
                    
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
                load_officer_info("%");
                load_training_state();
                Search = false;
            }
        }

        private void cboSearchTRaining_SelectedIndexChanged(object sender, EventArgs e)
        {
            //dgvOfficer.DefaultCellStyle.BackColor = Color.Red;
            for (int i = 0; i < dgvOfficer.Rows.Count; i++)
            {
                if (dgvOfficer.Rows[i].Cells[cboSearchTRaining .SelectedIndex + 5].Value == null)
                {
                    dgvOfficer.Rows[i].Cells[cboSearchTRaining.SelectedIndex + 5].Style.BackColor = Color.Green ;
                }
            }
        }

        private void dgvOfficer_Scroll(object sender, ScrollEventArgs e)
        {
            if (e.Type == ScrollEventType.EndScroll)
            {
                MessageBox.Show("OK");
            }
        }

        private void dgvOfficer_Sorted(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow dataGridViewRow in dgvOfficer.Rows.Cast<DataGridViewRow>())
                {
                    dataGridViewRow.Cells[0].Value = Eng_2_Myan((dataGridViewRow.Index + 1).ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cboRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboRank_Search_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                dgvOfficer.Rows.Clear();
                dgvOfficer.Refresh();
                //to get officer name
                mysql.tablename = "officer_name";
                mysql.cmdText = "SELECT * FROM officer_name WHERE rank='" + cboRank_Search.Text.Trim() + "'";
                mysql.DataBind();
                dst = mysql.dst;


                if (dst.Tables["officer_name"].Rows.Count > 0) dgvOfficer.Rows.Add(dst.Tables["officer_name"].Rows.Count);
                for (int i = 0; i < dst.Tables["officer_name"].Rows.Count; i++)
                {
                    dgvOfficer.Rows[i].Tag = dst.Tables["officer_name"].Rows[i]["officer_id"].ToString();
                    dgvOfficer.Rows[i].Cells["officer_id"].Value = Eng_2_Myan((i + 1).ToString());
                    dgvOfficer.Rows[i].Cells["bc_no"].Value = dst.Tables["officer_name"].Rows[i]["bc_no"].ToString();
                    dgvOfficer.Rows[i].Cells["rank"].Value = dst.Tables["officer_name"].Rows[i]["rank"].ToString();
                    dgvOfficer.Rows[i].Cells["name"].Value = dst.Tables["officer_name"].Rows[i]["name"].ToString();
                    dgvOfficer.Rows[i].Cells["battalion"].Value = dst.Tables["officer_name"].Rows[i]["battalion"].ToString();

                }
                dst.Tables.Remove("officer_name");
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
                for (int i = 1; i < dgvOfficer.Columns.Count + 1; i++)
                {
                    //worksheet.Range ["A1"].Style 
                    worksheet.Cells[1, i] = dgvOfficer.Columns[i - 1].HeaderText.ToString();
                }
                for (int i = 0; i <= dgvOfficer.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvOfficer.Columns.Count; j++)
                    {
                        if (dgvOfficer.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgvOfficer.Rows[i].Cells[j].Value.ToString();
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
                    caption = "အရာရှိစာရင်း(" + cboRank_Search.Text.Trim() + ").xls";
                }
                else
                {
                    caption = "အရာရှိစာရင်း.xls";
                }
                workbook.SaveAs(caption , Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                workbook.Close(true, misValue, misValue);
                app.Quit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

      

        

        


        
    }

    public class ComboboxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}


