using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Muntipule_Excel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Diamond();
        }

        public void Diamond()
        {
            try
            {
                MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM test.diamond", con);
                con.Open();
                DataSet ds = new DataSet();
                adapter.Fill(ds, "diamond");
                dataGridView1.DataSource = ds.Tables[0];
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }
        private void btnImport_Click(object sender, EventArgs e)
        {
            System.Data.DataTable dt = new System.Data.DataTable("datable");
            DataSet dsSource = new DataSet("dataSet");
            dt.Reset();

            Microsoft.Office.Interop.Excel.Workbook ExWorkbook;
            Microsoft.Office.Interop.Excel.Worksheet ExWorksheet;
            Microsoft.Office.Interop.Excel.Range ExRange;
            Microsoft.Office.Interop.Excel.Application Exobj = new Microsoft.Office.Interop.Excel.Application();

            openFileDialog1.Filter = "Excel Files |*.xls;*.xlsx;*.xlsm";
            DialogResult result = openFileDialog1.ShowDialog();
            if(result == DialogResult.OK)//test result
            {
                ExWorkbook = Exobj.Workbooks.Open(openFileDialog1.FileName, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value, Missing.Value);
                ExWorksheet = (Microsoft.Office.Interop.Excel.Worksheet)ExWorkbook.Sheets.get_Item(1);
                ExRange = ExWorksheet.UsedRange;

                for(int Cnum = 1; Cnum<=ExRange.Columns.Count;Cnum++)
                {
                    dt.Columns.Add(new DataColumn((ExRange.Cells[1, Cnum] as Microsoft.Office.Interop.Excel.Range).Value2.ToString()));
                }
                dt.AcceptChanges();

                string[] columnNames = new string[dt.Columns.Count];
                for(int i=0;i<dt.Columns.Count;i++)
                {
                    columnNames[0] = dt.Columns[i].ColumnName;
                }
                for(int Rnum=2; Rnum<= ExRange.Rows.Count;Rnum++)
                {
                    DataRow dr = dt.NewRow();
                    for(int Cnum = 1; Cnum<=ExRange.Columns.Count;Cnum++)
                    {
                        if((ExRange.Cells[Rnum,Cnum] as Microsoft.Office.Interop.Excel.Range).Value2 != null)
                        {
                            dr[Cnum - 1] = (ExRange.Cells[Rnum, Cnum] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                        }
                        dt.Rows.Add(dr);
                        dt.AcceptChanges();
                    }
                }

                ExWorkbook.Close(true, Missing.Value,Missing.Value);
                Exobj.Quit();
                dataGridView1.DataSource = dt;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
            app.Visible = true;
            Microsoft.Office.Interop.Excel.Workbook wb = app.Workbooks.Add(1);
            Microsoft.Office.Interop.Excel.Worksheet ws = (Microsoft.Office.Interop.Excel.Worksheet)wb.Worksheets[1];
            ws.Name = "exported from Girdview";
            ws.Rows.HorizontalAlignment = HorizontalAlignment.Center;
            for(int i=1;i<dataGridView1.Columns.Count+1;i++)
            {
                ws.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }

            for(int i=0;i<dataGridView1.Rows.Count -1;i++)
            {
                for(int j=0;j<dataGridView1.Columns.Count;j++)
                {
                    ws.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            ws.Cells.EntireColumn.AutoFit();
            //wb.SaveAs("C:output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            //    Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing,
            //    Type.Missing);
            app.Quit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //string sUrl = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            //ProcessStartInfo sInfo = new ProcessStartInfo(sUrl);
            //Process.Start(sInfo);
        }
    }
}
