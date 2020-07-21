using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moobile_Myanmar_Service_Tool
{
    public class QDCOM
    {
        private static string Edl(string cmd)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                FileName = "Qualcomm Programmer Files\\emmcdl.exe",
                Arguments = cmd,
                RedirectStandardOutput = true
            };
            Process process2 = process;
            process2.Start();
            return process2.StandardOutput.ReadToEnd();
        }

        public static string sfk(string cmd)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                FileName = "sfk.exe",
                Arguments = cmd,
                RedirectStandardOutput = true
            };
            Process process2 = process;
            process2.Start();
            return process2.StandardOutput.ReadToEnd();
        }

        public static string Win(string cmd)
        {
            Process process = new Process();
            process.StartInfo = new ProcessStartInfo
            {
                UseShellExecute = false,
                CreateNoWindow = true,
                FileName = "cmd.exe",
                Arguments = cmd,
                RedirectStandardOutput = true
            };
            Process process2 = process;
            process2.Start();
            return process2.StandardOutput.ReadToEnd();
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

        public static bool EdlConnect()
        {
            string text = QDCOM.Edl("-l");
            if (text.Contains("COM"))
            {
                return true;
            }
            return false;
        }

        public static string EdlComNo()
        {
            string result = "Not Detect";
            string text = "";
            string s = QDCOM.Edl("-l");
            StringReader stringReader = new StringReader(s);
            while (stringReader.Peek() != -1)
            {
                text = stringReader.ReadLine();
                if (text.Contains("COM"))
                {
                    string text2 = text.Replace("Qualcomm HS-USB QDLoader 9008", "").Replace(" ", "").Replace("(", "")
                        .Replace(")", "");
                    if (text.Contains("COM"))
                    {
                        result = text2;
                    }
                }
            }
            return result;
        }

        public static string EdlInfo()
        {
            string cmd = "-p " + QDCOM.EdlComNo() + " -info";
            string text = QDCOM.Edl(cmd);
            string text2 = text.Replace("Version 2.15", "");
            return text2.Replace("Status: 0 The operation completed successfully.", "");
        }

        public static string EdlCommand(string arg)
        {
            return QDCOM.Edl(arg);
        }

        public static string EdlBackupByName(string PortNo, string Programmer, string Partition, string OutputFileName)
        {
            string cmd = "-p " + PortNo + " -f " + Programmer + " -d " + Partition + " -o " + OutputFileName;
            return QDCOM.Edl(cmd);
        }

        public static string EdlBackupBySector(string PortNo, bool ufsType, string Programmer, string StartSector, string EndSector, string OutputFileName)
        {
            if (ufsType)
            {
                return " -p " + PortNo + " -MemoryName ufs -f " + Programmer + " -d " + StartSector + " " + EndSector + " -o " + OutputFileName;
            }
            return " -p " + PortNo + " -f " + Programmer + " -d " + StartSector + EndSector + " -o " + OutputFileName;
        }

        public static string EdlRestore(string PortNo, string Programmer, string Partition, string FileName)
        {
            string cmd = " -p " + PortNo + " -f " + Programmer + " -b " + Partition + FileName;
            return QDCOM.Edl(cmd);
        }

        public static string EdlXmlFlash(string PortNo, bool ufsType, string Programmer, string XmlFile)
        {
            string cmd;
            if (ufsType)
            {
                string text = " -p " + PortNo + " -MemoryName ufs  -f " + Programmer + " -x " + XmlFile;
                cmd = text;
            }
            else
            {
                string text2 = " -p " + PortNo + " -f " + Programmer + " -x " + XmlFile;
                cmd = text2;
            }
            return QDCOM.Edl(cmd);
        }

        public static string EdlEraseByName(string PortNo, string Programmer, string Partition)
        {
            string cmd = " -p " + PortNo + " -f " + Programmer + " -e " + Partition;
            return QDCOM.Edl(cmd);
        }

        public static string EdlEraseBySector(string PortNo, bool ufsType, string Programmer, string Startsector, string Endsector)
        {
            string cmd;
            if (ufsType)
            {
                string text = " -p " + PortNo + " -MemoryName ufs -f " + Programmer + " -e " + Startsector + Endsector;
                cmd = text;
            }
            else
            {
                string text2 = " -p " + PortNo + " -f " + Programmer + " -e " + Startsector + Endsector;
                cmd = text2;
            }
            return QDCOM.Edl(cmd);
        }

        public static string MiSLReset()
        {
            return QDCOM.AdbCommand("format-data");
        }

        public static bool adbConnect()
        {
            string text = QDCOM.AdbCommand("get-state");
            if (text.Contains("device"))
            {
                return true;
            }
            return false;
        }

        public static string RunCommand(string arg)
        {
            return QDCOM.AdbCommand(arg);
        }

        public static void DisableMiAccount()
        {
            QDCOM.AdbCommand("pm hide com.miui.cloudservice");
            QDCOM.AdbCommand("pm hide com.xiaomi.finddevice");
            QDCOM.AdbCommand("reboot");
        }

        public static void Ver567Font()
        {
            QDCOM.AdbCommand("push SmartZawgyiPro.ttf data/local/tmp/");
            QDCOM.AdbCommand("shell su -c \"dd if=/data/local/tmp/SmartZawgyiPro.ttf of=/system/fonts/NotoSansMyanmar-Bold.ttf\"");
            QDCOM.AdbCommand("shell su -c \"dd if=/data/local/tmp/SmartZawgyiPro.ttf of=/system/fonts/NotoSansMyanmar-Regular.ttf\"");
            QDCOM.AdbCommand("shell su -c \"dd if=/data/local/tmp/SmartZawgyiPro.ttf of=/system/fonts/NotoSansMyanmarUI-Bold.ttf\"");
            QDCOM.AdbCommand("shell su -c \"dd if=/data/local/tmp/SmartZawgyiPro.ttf of=/system/fonts/NotoSansMyanmarRegular-Bold.ttf\"");
            QDCOM.AdbCommand("shell su -c \"dd if=/data/local/tmp/SmartZawgyiPro.ttf of=/system/fonts/NotoSansMyanmarZawgyiUI-Regular.ttf\"");
            QDCOM.AdbCommand("adb shell su -c \"chmod 644 / system / fonts/*.ttf\"");
        }

        public static bool RootAccess()
        {
            string text = QDCOM.AdbCommand("shell su -v");
            if (text.Contains("not found"))
            {
                return false;
            }
            return true;
        }

        public static bool AdbSLConnect()
        {
            string text = QDCOM.AdbCommand("get-state");
            if (text.Contains("sideload"))
            {
                return true;
            }
            return false;
        }

        public static string SLInfomation()
        {
            string str = QDCOM.RunCommand("getdevice");
            string str2 = QDCOM.RunCommand("getcodebase");
            string str3 = QDCOM.RunCommand("getregion");
            string str4 = QDCOM.RunCommand("getlanguage");
            string str5 = QDCOM.RunCommand("getversion");
            string str6 = "Product:\t" + str;
            str6 = str6 + Environment.NewLine + "Version:\t" + str2;
            str6 = str6 + Environment.NewLine + "MIUI Ver:\t" + str5;
            str6 = str6 + Environment.NewLine + "Region\t:\t" + str3;
            return str6 + Environment.NewLine + "Language:\t" + str4;
        }

        public static bool SlConnectNotXM()
        {
            string text = QDCOM.AdbCommand("getversion");
            if (text.Contains("."))
            {
                return false;
            }
            return true;
        }
    }

}
