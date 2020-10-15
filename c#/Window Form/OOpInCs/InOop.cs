using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Diagnostics.Tracing;
using System.Diagnostics;

namespace OOpInCs
{
    public class InOop
    {
        public string name;
        public string fathername;
        public string mobile;
        public string dateofbirth;
        public string gender;

        public string errlog;
        StreamWriter errWriter;
        public string errFile = "errlog.log";


        public MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
        public MySqlDataAdapter adapter;
        public DataSet ds = new DataSet();
        public EventLog myLog = new EventLog();
        public InOop()
        {

            
        }

        public void errLog(string errcode)
        {
            if (!File.Exists(errFile))
            {
                File.CreateText(errFile);
            }
            errWriter = new StreamWriter(errFile, append: true);
            errWriter.WriteLine(errcode);
            errWriter.Close();
        }

        public String showErrLog()
        {
            string line;
            StreamReader errReader = new StreamReader(errFile);

            while ((line = errReader.ReadLine()) != null)
            {
                errlog += line + "\n";
            }
            errReader.Close();
            return errlog;
        }




        //mysql search function
        public bool funSearchTitle(string txt, int title)
        {


            try
            {

                //MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                con.Open();
                //MySqlDataAdapter adapte MySqlDataAdapter("SELECT * FROM lab.lab where done like'" + txt + "'", con);

                switch (title)
                {

                    case 0:
                        adapter = new MySqlDataAdapter("SELECT * FROM phone.cs where id like'" + txt + "'", con);
                        break;
                    case 1:
                        adapter = new MySqlDataAdapter("SELECT * FROM phone.cs where name like'" + txt + "'", con);
                        break;
                    case 2:
                        adapter = new MySqlDataAdapter("SELECT * FROM phone.cs where farther like'" + txt + "'", con);
                        break;
                    case 3:
                        adapter = new MySqlDataAdapter("SELECT * FROM phone.cs where mobile like'" + txt + "'", con);
                        break;
                    case 4:
                        adapter = new MySqlDataAdapter("SELECT * FROM phone.cs where date like'" + txt + "'", con);
                        break;
                    case 5:
                        adapter = new MySqlDataAdapter("SELECT * FROM phone.cs where gender like'" + txt + "'", con);
                        break;

                }
                adapter.Fill(ds, "cs");
                con.Close();
                return true;

            }
            catch (Exception ex)
            {
                errLog(ex.Message);
                return false;
            }
        }

        //mysql insert
        public bool insert()
        {


            try
            {

                //MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                con.Open();
                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = "INSERT INTO phone.cs (`id`, `name`, `farther`, `mobile`, `date`, `gender`) VALUES (NULL,@name,@fathername,@mobile,@dateofbirth,@gender)";
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@fathername", fathername);
                cmd.Parameters.AddWithValue("@mobile", mobile);
                cmd.Parameters.AddWithValue("@dateofbirth", dateofbirth);
                cmd.Parameters.AddWithValue("@gender", gender);
                cmd.ExecuteNonQuery();
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                errLog(ex.Message);
                return false;
            }
        }

        //mysql  refresh        
        public bool ShowDatatbase()
        {
            try
            {
                //MySqlConnection con = new MySqlConnection("datasource=localhost;port=3306;username=root");
                MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM phone.cs", con);
                con.Open();

                adapter.Fill(ds, "cs");
                con.Close();
                return true;

            }
            catch (Exception ex)
            {
                errLog(ex.Message);
                return false;
            }

        }

        //mysql update

        public bool Update()
        {
            MySqlCommand cmd = con.CreateCommand();
            return true;
        }

       


    }
}
