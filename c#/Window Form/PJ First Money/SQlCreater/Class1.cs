using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace SQlCreater
{
    class Class1
    {
    }
    public void DbCreate()
    {
        try
        {

            MySqlConnection con = new MySqlConnection("server=localhost; database=test; user=root;pooling = false; convert zero datetime=True");
            MySqlCommand cmd = con.CreateCommand();
            con.Open();
            cmd.CommandText = "create table pre_order(no INT NOT NULL AUTO_INCREMENT,order_date VARCHAR(255) NOT NULL,customer VARCHAR(255) NOT NULL,city VARCHAR(255) NOT NULL,product VARCHAR(255) NOT NULL,PRIMARY KEY(no )); " + "create database if not exists test";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Database Created !\n PLease Click For First Use");

        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);

        }
        return DbCreate();
    }
    public void myMethod()
    {
        MessageBox.Show("Please Uninstall DBCreate001");
        Process p;
        try
        {
            p = new Process();
            p.StartInfo.FileName = "cmd.exe";
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;
            p.StartInfo.UseShellExecute = false;
            p.Start();

            p.StandardInput.WriteLine("start control");
            p.StandardInput.Flush();
            p.StandardInput.Close();
            Console.WriteLine(p.StandardOutput.ReadToEnd());
        }
        catch (Exception ex) { MessageBox.Show(ex.Message); }
    }
}
