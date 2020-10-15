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
    public partial class trainning_info : Form
    {
        public trainning_info()
        {
            InitializeComponent();
        }
        DataSet dst;
        string server_pass = "";
        MySqlDB mysql = new MySqlDB();

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtTraining_name.Text == "")
                {
                    MessageBox.Show("သင်တန်းအမည် အပြည့်အစုံထည့်သွင်းရပါမည်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                    return;
                }
                int row_chk = 0;
                if ((chkOfficer.Checked == true) && (chkO_rank.Checked == true))
                    row_chk = 3;
                else if (chkO_rank.Checked == true)
                    row_chk = 2;
                else if (chkOfficer.Checked == true)
                    row_chk = 1;
                else
                {
                    MessageBox.Show("အရာရှိ(သို့မဟုတ်)အခြားအဆင့် ရွေးချယ်ရန်။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်");
                }
                mysql.cmdText = "INSERT INTO training_name(training_name,row) VALUES ('" + txtTraining_name.Text.Trim() + "','" + row_chk + "')";
                mysql.insert();
                load_training_name();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void trainning_info_Load(object sender, EventArgs e)
        {
            
            mysql.constring = "Data Source= localhost;Database=engineering_school;User ID=root;Password=" + server_pass + ";charset=utf8";
            dgvTraining_name.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));


            load_training_name();

            
        }

        void load_training_name()
        {

            try
            {

                dst = new DataSet();

                //clear the datagridview
                dgvTraining_name.Rows.Clear();
                dgvTraining_name.Refresh();

                //to get training name from table
                mysql.tablename = "training_name";
                mysql.cmdText = "SELECT * FROM training_name";
                mysql.DataBind();
                dst = mysql.dst;

                //datagridview columns adding and set width by ratio 
                dgvTraining_name.Columns.Clear();
                dgvTraining_name.Columns.Add("no", "စဉ်");
                dgvTraining_name.Columns.Add("trainingName", "သင်တန်းအမည်");
                dgvTraining_name.Columns.Add("row", "မှတ်ချက်");

                dgvTraining_name.Columns[0].FillWeight = 30;
                dgvTraining_name.Columns[1].FillWeight = 200;
                dgvTraining_name.Columns[0].FillWeight = 100;

                //to set data from database table to datagridview
                if (dst.Tables["training_name"].Rows.Count > 0)
                {
                    dgvTraining_name.Rows.Add(dst.Tables["training_name"].Rows.Count);
                    for (int i = 0; i < dst.Tables["training_name"].Rows.Count; i++)
                    {
                        dgvTraining_name.Rows[i].Tag = dst.Tables["training_name"].Rows[i]["training_name_id"].ToString();
                        dgvTraining_name.Rows[i].Cells["no"].Value = Eng_2_Myan ((i + 1).ToString());
                        dgvTraining_name.Rows[i].Cells["trainingName"].Value = dst.Tables["training_name"].Rows[i]["training_name"].ToString();
                        switch (dst.Tables["training_name"].Rows[i]["row"].ToString())
                        {
                            case "1":
                                dgvTraining_name.Rows[i].Cells["row"].Value = "အရာရှိ";
                                break;
                            case "2":
                                dgvTraining_name.Rows[i].Cells["row"].Value = "အခြားအဆင့်";
                                break;
                            case "3":
                                dgvTraining_name.Rows[i].Cells["row"].Value = "အရာရှိ/အခြားအဆင့်";
                                break;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("သင်တန်းအမည် ထည့်သွင်းထားခြင်းမရှိသေးပါ။", "သင်တန်းဆိုင်ရာ သတင်းပေးချက်", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                //clear table in the dateset
                dst.Tables.Clear();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        //Convert Eng Number to Myanmar Number
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

       

        private void dgvTraining_name_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Right)
            //{
            //    dgvTraining_name.Rows[e.RowIndex].Selected = true;
            //    contextMenuStrip1.Show( ,e.Location);
            //}
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
                    mysql.cmdText = "DELETE FROM training_name WHERE training_name_id='" + dgvTraining_name.SelectedRows[0].Tag.ToString() + "'";
                    mysql.DataBind();

                    mysql.cmdText = "DELETE FROM officer_training_state WHERE training_name_id='" + dgvTraining_name.SelectedRows[0].Tag.ToString()+ "'";
                    mysql.DataBind();

                    mysql.cmdText = "DELETE FROM other_rank_training_state WHERE training_name_id='" + dgvTraining_name.SelectedRows[0].Tag.ToString() + "'";
                    mysql.DataBind();

                    mysql.cmdText = "DELETE FROM training_info WHERE training_name_id='" + dgvTraining_name.SelectedRows[0].Tag.ToString() + "'";
                    mysql.DataBind();

                    load_training_name();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
