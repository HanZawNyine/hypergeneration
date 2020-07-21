using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiletool
{
    class fastboot
    {
        private static string fastbot(string cmd)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                FileName = "bin\\fastboot.exe",
                Arguments = cmd,
                RedirectStandardOutput = true
            };
            Process process2 = process;
            process2.Start();
            return process2.StandardOutput.ReadToEnd();
        }
        public static string fatbootcommandRun(string arg)
        {
            return fastboot.fastbot(arg);
        }
        public static string fasCommand(string cmd)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                FileName = "bin\\fastboot.exe",
                Arguments = cmd,
                RedirectStandardOutput = true
            };
            Process process2 = process;
            process2.Start();
            return process2.StandardOutput.ReadToEnd();
        }

        public static bool fastbootconnect()
        {
            string text = fastboot.fastbot("devices");
            if (text.Contains("fastboot"))
            {
                return true;
            }
            return false;
        }
    }
}
