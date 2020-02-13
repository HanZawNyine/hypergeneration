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
using System.IO;
//using Microsoft.Office.Interop.Excel;
using Excel = Microsoft.Office.Interop.Excel;
using Word = Microsoft.Office.Interop.Word;
//using Microsoft.Office.Interop.Excel;
//using MySql_Database_Class;
using MySql.Data.MySqlClient;
using System.IO;



namespace phone01
{
    public partial class frmData : Form
    {
        public frmData()
        {
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            

            
            //FolderBrowserDialog fbdlBackup = new FolderBrowserDialog();
            ExportDataFromSQLServer();
            NextTable();
            //this.Hide();
            //frmMenu fm = new frmMenu();
            //fm.ShowDialog();
        }





        protected DataTable ExportDataFromSQLServer()
        {
           

            DataTable dataTable = new DataTable();

            using (MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root"))
            {
                connection.Open();

                // Define the query to be performed to export desired data
                MySqlCommand command = new MySqlCommand("select * from phone01.technical", connection);

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);

                dataAdapter.Fill(dataTable);

                var excelApplication = new Excel.Application();

                var excelWorkBook = excelApplication.Application.Workbooks.Add(Type.Missing);

                DataColumnCollection dataColumnCollection = dataTable.Columns;

                for (int i = 1; i <= dataTable.Rows.Count + 1; i++)
                {
                    for (int j = 1; j <= dataTable.Columns.Count; j++)
                    {
                        if (i == 1)
                            excelApplication.Cells[i, j] = dataColumnCollection[j - 1].ToString();
                        else
                            excelApplication.Cells[i, j] = dataTable.Rows[i - 2][j - 1].ToString();
                    }
                }
               //class  CreateFileOrFolder()
                // Save the excel file at specified location
                excelApplication.ActiveWorkbook.SaveCopyAs(@"D:\TechnicalDataExport.xlsx");

                excelApplication.ActiveWorkbook.Saved = true;

                // Close the Excel Application
                excelApplication.Quit();

                connection.Close();

                //Release or clear the COM object
                releaseObject(excelWorkBook);
                releaseObject(excelApplication);


                MessageBox.Show("Your TechnicL data is exported Successfully into Excel File.");
            }
            return dataTable;
        }
        private void releaseObject(object obj)
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
        protected DataTable NextTable()
        {
            
                           DataTable dataTable = new DataTable();

                using (MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root"))
                {
                    connection.Open();

                    // Define the query to be performed to export desired data
                    MySqlCommand command = new MySqlCommand("select * from phone01.customer", connection);

                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);

                    dataAdapter.Fill(dataTable);

                    var excelApplication = new Excel.Application();

                    var excelWorkBook = excelApplication.Application.Workbooks.Add(Type.Missing);

                    DataColumnCollection dataColumnCollection = dataTable.Columns;

                    for (int i = 1; i <= dataTable.Rows.Count + 1; i++)
                    {
                        for (int j = 1; j <= dataTable.Columns.Count; j++)
                        {
                            if (i == 1)
                                excelApplication.Cells[i, j] = dataColumnCollection[j - 1].ToString();
                            else
                                excelApplication.Cells[i, j] = dataTable.Rows[i - 2][j - 1].ToString();
                        }
                    }

                    // Save the excel file at specified location
                    excelApplication.ActiveWorkbook.SaveCopyAs(@"D:\CustomerDataExport.xlsx");

                    excelApplication.ActiveWorkbook.Saved = true;

                    // Close the Excel Application
                    excelApplication.Quit();

                    connection.Close();

                    //Release or clear the COM object
                    releaseObject(excelWorkBook);
                    releaseObject(excelApplication);


                    MessageBox.Show("Your customer  data is exported Successfully into Excel File.");
                }
                return dataTable;
           

                    
        }

    
    }
}
