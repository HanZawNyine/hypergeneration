using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobile
{
    public class Adb
    {
        public static string Miadb(string cmd)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                FileName = "bin//miadb.exe",
                Arguments = cmd,
                RedirectStandardOutput = true
            };
            Process process2 = process;
            process2.Start();
            return process2.StandardOutput.ReadToEnd();
			
        }
        public static bool Adbfound()
        {
            string text = Adb.AdbCommand("get-state");
            if (text.Contains("device"))
            {
                return true;
            }
            return false;
        }
		
		public static string Sideloadunfo()
        {
            string str = Adb.Miadb("getdevice");
            string str2 = Adb.Miadb("getcodebase");
            string str3 =Adb.Miadb("getregion");
            string str4 = Adb.Miadb("getlanguage");
            string str5 = Adb.Miadb("getversion");
            string str6 = "Product:\t" + str;
            str6 = str6 + Environment.NewLine + "Version:\t" + str2;
            str6 = str6 + Environment.NewLine + "MIUI Ver:\t" + str5;
            str6 = str6 + Environment.NewLine + "Region\t:\t" + str3;
            return str6 + Environment.NewLine + "Language:\t" + str4;
        }

         public static bool Sideloadconnect()
        {
            string text = Adb.AdbCommand("get-state");
            if (text.Contains("sideload"))
            {
                return true;
            }
            return false;
        }

        public static string AdbCommand(string cmd)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                FileName = "adb.exe",
                Arguments = cmd,
                RedirectStandardOutput = true
            };
            Process process2 = process;
            process2.Start();
            return process2.StandardOutput.ReadToEnd();
        }
    }
}
        
    
    