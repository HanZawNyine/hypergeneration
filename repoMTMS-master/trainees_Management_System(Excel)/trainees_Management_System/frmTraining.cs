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


namespace trainees_Management_System
{
    public partial class frmTraining : Form
    {
        string training_name;
        string batch;
        MySqlDB mysql = new MySqlDB();
        DataSet dst = new DataSet();
        string server_pass = "";
        string training_row;
        

        public frmTraining()
        {
            InitializeComponent();
        }

        public frmTraining(string fvp_training_name,string fvp_batch,string row)
        {
            InitializeComponent();
            training_name = fvp_training_name;
            batch = fvp_batch;
            training_row = row;
        }

        private void frmTraining_Load(object sender, EventArgs e)
        {
            try
            {
                mysql.constring = "Data Source= localhost;Database=engineering_school;User ID=root;Password=" + server_pass + ";charset=utf8";
                dgvTrainner.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dgvTrainner.Invalidate();
                dst.Tables.Clear();
                mysql.tablename = "training";
                mysql.cmdText = "SELECT id,training_name_id,training_name,batch,start_date,end_date,trainner_quantity FROM training_info WHERE training_name='" + training_name + "' AND batch='" + batch + "'";
                mysql.DataBind();
                dst = mysql.dst;


                lblTraining.Text = dst.Tables["training"].Rows[0]["training_name"].ToString() + " အမှတ်စဉ်(" + dst.Tables["training"].Rows[0]["batch"].ToString() + ")";
                lblS_date.Text = dst.Tables["training"].Rows[0]["start_date"].ToString();
                lblE_date.Text = dst.Tables["training"].Rows[0]["end_date"].ToString();


                switch (training_row)
                {
                    case "1":
                        rdoOfficer.Checked = true;
                        rdoOtherRank.Enabled = false;
                        break;
                    case "2":
                        rdoOtherRank.Checked = true;
                        rdoOfficer.Enabled = false;
                        break;
                    case "3":
                        rdoOfficer.Checked = true;
                        break;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            
        }

        void officer()
        {

            //datagridview columns adding and set width by ratio 
            dgvTrainner.Columns.Clear();
            dgvTrainner.Columns.Add("no", "စဉ်");
            dgvTrainner.Columns.Add("bc_no", "ပြန်တမ်း၀င်အမှတ်");
            dgvTrainner.Columns.Add("rank", "အဆင့်");
            dgvTrainner.Columns.Add("name", "အမည်");
            dgvTrainner.Columns.Add("battalion", "တပ်");
            dgvTrainner.Columns.Add("remark", "မှတ်ချက်");

            
            if (dst.Tables["training"].Rows.Count > 0)
            {
                search_batch_id = dst.Tables["training"].Rows[0]["training_name_id"].ToString();

                mysql.tablename = "trainner";
                //mysql.cmdText = "SELECT officer_id,training_name_id,batch,grade FROM officer_training_state WHERE training_name_id='" + search_batch_id + "' AND batch='" + batch + "'";
                mysql.cmdText = "SELECT officer_id,training_name_id,batch,grade FROM officer_training_state WHERE training_info_id='" + dst.Tables["training"].Rows[0]["id"].ToString() + "'";
                mysql.DataBind();
                dst = mysql.dst;

                mysql.tablename = "officer";
                mysql.cmdText = "SELECT * FROM officer_name ORDER BY bc_no";
                mysql.DataBind();
                dst = mysql.dst;
                int n = 1;
                if (dst.Tables["trainner"].Rows.Count > 0)
                {
                    dgvTrainner.Rows.Add(dst.Tables["trainner"].Rows.Count);
                    for (int i = 0; i < dst.Tables["officer"].Rows.Count; i++)
                    {
                        for (int j = 0; j < dst.Tables["trainner"].Rows.Count; j++)
                        {
                            if (dst.Tables["officer"].Rows[i]["officer_id"].ToString() == dst.Tables["trainner"].Rows[j]["officer_id"].ToString())
                            {
                                dgvTrainner.Rows[n - 1].Cells["no"].Value = Eng_2_Myan ( n.ToString ());
                                dgvTrainner.Rows[n - 1].Cells["bc_no"].Value = dst.Tables["officer"].Rows[i]["bc_no"].ToString();
                                dgvTrainner.Rows[n - 1].Cells["rank"].Value = dst.Tables["officer"].Rows[i]["rank"].ToString();
                                dgvTrainner.Rows[n - 1].Cells["name"].Value = dst.Tables["officer"].Rows[i]["name"].ToString();
                                dgvTrainner.Rows[n - 1].Cells["battalion"].Value = dst.Tables["officer"].Rows[i]["battalion"].ToString();
                                dgvTrainner.Rows[n - 1].Cells["remark"].Value = dst.Tables["trainner"].Rows[j]["grade"].ToString();
                                n++;
                            }
                        }
                    }
                }
                dst.Tables.Remove("trainner");
                dst.Tables.Remove("officer");
            }
        }

        void Other_rank()
        {
            //datagridview columns adding and set width by ratio 
            dgvTrainner.Columns.Clear();
            dgvTrainner.Columns.Add("no", "စဉ်");
            dgvTrainner.Columns.Add("service_no", "ကိုယ်ပိုင်အမှတ်");
            dgvTrainner.Columns.Add("rank", "အဆင့်");
            dgvTrainner.Columns.Add("name", "အမည်");
            dgvTrainner.Columns.Add("battalion", "တပ်");
            dgvTrainner.Columns.Add("remark", "မှတ်ချက်");


            if (dst.Tables["training"].Rows.Count > 0)
            {
                search_batch_id = dst.Tables["training"].Rows[0]["training_name_id"].ToString();

                mysql.tablename = "trainner";
                mysql.cmdText = "SELECT other_rank_id,training_name_id,batch,grade FROM other_rank_training_state WHERE training_info_id='" + dst.Tables["training"].Rows[0]["id"].ToString() + "'";
                mysql.DataBind();
                dst = mysql.dst;

                mysql.tablename = "other_rank";
                mysql.cmdText = "SELECT * FROM other_rank_name ORDER BY service_no";
                mysql.DataBind();
                dst = mysql.dst;
                int n = 1;
                if (dst.Tables["trainner"].Rows.Count > 0)
                {
                    dgvTrainner.Rows.Add(dst.Tables["trainner"].Rows.Count);
                    for (int i = 0; i < dst.Tables["other_rank"].Rows.Count; i++)
                    {
                        for (int j = 0; j < dst.Tables["trainner"].Rows.Count; j++)
                        {
                            if (dst.Tables["other_rank"].Rows[i]["other_rank_id"].ToString() == dst.Tables["trainner"].Rows[j]["other_rank_id"].ToString())
                            {
                                dgvTrainner.Rows[n - 1].Cells["no"].Value = Eng_2_Myan (n.ToString ());
                                dgvTrainner.Rows[n - 1].Cells["service_no"].Value = dst.Tables["other_rank"].Rows[i]["service_no"].ToString();
                                dgvTrainner.Rows[n - 1].Cells["rank"].Value = dst.Tables["other_rank"].Rows[i]["rank"].ToString();
                                dgvTrainner.Rows[n - 1].Cells["name"].Value = dst.Tables["other_rank"].Rows[i]["name"].ToString();
                                dgvTrainner.Rows[n - 1].Cells["battalion"].Value = dst.Tables["other_rank"].Rows[i]["battalion"].ToString();
                                dgvTrainner.Rows[n - 1].Cells["remark"].Value = dst.Tables["trainner"].Rows[j]["grade"].ToString();
                                n++;
                            }
                        }
                    }
                }
                dst.Tables.Remove("trainner");
                dst.Tables.Remove("other_rank");

            }
        }

        public string search_batch_id { get; set; }

        private void rdoOfficer_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                officer();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void rdoOtherRank_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                Other_rank();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }


       


        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //string file = "";
                //if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
                //{
                //    file = folderBrowserDialog1.SelectedPath + @"\MES.xlsx";
                //}
                //else                
                //{
                //    return;
                //}

                //FileStream outStream = new FileStream(file, FileMode.Create, FileAccess.Write, FileShare.Read);
                //outStream.Dispose();
                //string connectionString = String.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;" +
                //        "Data Source={0};Extended Properties='Excel 12.0;HDR=YES;IMEX=0'", file);
                
                ////FileStream inStream = new FileStream(Application.StartupPath + @"\temp.xlsx", FileMode.Open, FileAccess.Read, FileShare.None);
                

                //using (OleDbConnection cn = new OleDbConnection(connectionString))
                //{
                //    cn.Open();
                //    for (int i = 0; i <= dgvTrainner .Rows .Count ; i++)
                //    {
                //        OleDbCommand cmd1 = new OleDbCommand("INSERT INTO [Sheet1$] " +
                //         "([Column1],[Column2],[Column3],[Column4],[Column5],[Column6]) " +
                //         "VALUES(@value1, @value2, @value3, @value4, @value5, @value6)", cn);
                //        cmd1.Parameters.AddWithValue("@value1", dgvTrainner.Rows[i].Cells[0].Value.ToString () );
                //        cmd1.Parameters.AddWithValue("@value2", dgvTrainner.Rows[i].Cells[1].Value.ToString());
                //        cmd1.Parameters.AddWithValue("@value3", dgvTrainner.Rows[i].Cells[2].Value.ToString());
                //        cmd1.Parameters.AddWithValue("@value4", dgvTrainner.Rows[i].Cells[3].Value.ToString());
                //        cmd1.Parameters.AddWithValue("@value5", dgvTrainner.Rows[i].Cells[4].Value.ToString());
                //        cmd1.Parameters.AddWithValue("@value6", dgvTrainner.Rows[i].Cells[5].Value.ToString());
                //        cmd1.ExecuteNonQuery();
                //    }
                    
                //}


                //using (inStream)
                //{
                //    while (true)
                //    {
                //        int b = inStream.ReadByte();
                //        if (b == -1)
                //            break;
                //        outStream.WriteByte((byte)b);

                //    }
                //    MessageBox.Show("Your output file is ready in " + file + " as Marker_M_Data.xlsx!", "Creating output file Completed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //}
                //inStream.Dispose();
                //outStream.Dispose();
                

                

                









                /*
                 * Function -2 
                 */

                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.PageSetup.CenterHeader = lblTraining.Text;
                worksheet.PageSetup.LeftHeader = label1.Text + "   " + lblS_date.Text;
                worksheet.PageSetup.RightHeader = label2.Text + "   " + lblE_date.Text;
                workbook.WebOptions.Encoding = Microsoft.Office.Core.MsoEncoding.msoEncodingUTF8;
                app.StandardFont = "Myanmar3";
                app.StandardFontSize = 10;
                for (int i = 1; i < dgvTrainner.Columns.Count + 1; i++)
                {
                    //worksheet.Range ["A1"].Style 
                    worksheet.Cells[1, i] = dgvTrainner.Columns[i - 1].HeaderText.ToString ();
                }
                for (int i = 0; i <= dgvTrainner.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dgvTrainner.Columns.Count; j++)
                    {
                        if (dgvTrainner.Rows[i].Cells[j].Value != null)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgvTrainner.Rows[i].Cells[j].Value.ToString();
                        }
                        else
                        {
                            worksheet.Cells[i + 2, j + 1] = "";
                        }
                    }
                }


                object misValue = System.Reflection.Missing.Value;
                               
                workbook.SaveAs(lblTraining.Text + ".xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                workbook.Close(true, misValue, misValue);
                app.Quit();















                /*
                 * Function -1 
                 */
                //Excel.Application xlApp;
                //Excel.Workbook xlWorkBook;
                //Excel.Worksheet xlWorkSheet;
                //object misValue = System.Reflection.Missing.Value;

                //xlApp = new Excel.Application();
                //xlWorkBook = xlApp.Workbooks.Add(misValue);
                //xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
                ////int i = 0;
                ////int j = 0;

                //for (int i = 0; i < dgvTrainner .RowCount ; i++)
                //{
                //    for (int j = 0; j < dgvTrainner .ColumnCount; j++)
                //    {
                //        DataGridViewCell cell = dgvTrainner[j, i];
                //        xlWorkSheet.Cells[i + 1, j + 1] = cell.Value;
                //    }
                //}

                //xlWorkBook.SaveAs("MES.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                //xlWorkBook.Close(true, misValue, misValue);
                //xlApp.Quit();

                //release_Object(xlWorkSheet); 
                //release_Object(xlWorkBook);
                //release_Object(xlApp);

                //MessageBox.Show("Excel file တည်ဆောက်ပြီးပါပြီ။","သင်တန်းဆိုင်ရာ သတင်းပေးချက်", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void release_Object(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dgvTrainner.Rows[0].Cells[1].Value.ToString());
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
