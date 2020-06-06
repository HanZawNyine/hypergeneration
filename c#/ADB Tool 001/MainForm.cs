using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ADB_Tool_001
{
    public partial class MainForm : Form
    {
        string imagefile = "";
        int camera2button = 0;

        public MainForm()
        {
            InitializeComponent();
            partitionBox.SelectedIndex = 5;
            serialLabel.Text = "";
            codenameLabel.Text = "";
            bootloaderLabel.Text = "";
            ((ToolStripDropDownMenu)(loadfastboot.Owner)).ShowCheckMargin = false;
            ((ToolStripDropDownMenu)(loadadb.Owner)).ShowImageMargin = false;
            WriteFiles();
        }
        public void WriteFiles()
        {
            File.WriteAllBytes(Path.GetTempPath() + "\\adb.exe", Properties.Resources.adb);
            File.WriteAllBytes(Path.GetTempPath() + "\\fastboot.exe", Properties.Resources.fastboot);
            File.WriteAllBytes(System.IO.Path.GetTempPath() + "\\AdbWinApi.dll", Properties.Resources.AdbWinApi);
            File.WriteAllBytes(System.IO.Path.GetTempPath() + "\\AdbWinUsbApi.dll", Properties.Resources.AdbWinUsbApi);
        }


        #region Interface
        public bool Fastboot_Check()
        {
            tbOutput.Text = "Getting device info...";
            tbOutput.Update();
            Cursor.Current = Cursors.WaitCursor;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = Path.GetTempPath() + "\\fastboot.exe";
            process.StartInfo = startInfo;

            startInfo.Arguments = "devices";
            process.Start();
            string line = process.StandardOutput.ReadLine();
            if (line == null)
            {
                tbOutput.Text = "No device found!";
                serialLabel.Text = "";
                codenameLabel.Text = "";
                bootloaderLabel.Text = "";
                process.Close();
                return false;
            }

            string serial = line.Remove(line.Length - 9);
            serialLabel.Text = serial;
            process.Close();

            startInfo.Arguments = "getvar product";
            process.Start();
            //codenameLabel.Text = process.StandardError.ReadLine().Substring(9);
            string code = process.StandardError.ReadLine().Substring(9);
            process.Close();
            codenameLabel.Text = code;

            startInfo.Arguments = "oem device-info";
            process.Start();
            string info = process.StandardError.ReadToEnd();
            string stt = "";
            if (info.Contains("unlocked: true")) stt = "unlocked";
            if (info.Contains("unlocked: false")) stt = "locked";
            bootloaderLabel.Text = stt;
            process.Close();
            tbOutput.Text = "Device found!";
            tbOutput.Update();
            tbOutput.Text += Environment.NewLine + "Serial Number: " + serial;
            tbOutput.Text += Environment.NewLine + "Code Name: " + code;
            tbOutput.Text += Environment.NewLine + "Bootloader: " + stt;
            return true;
        }


        public bool ADB_Check()
        {
            tbOutput.Text = "Getting device info...";
            tbOutput.Update();
            Cursor.Current = Cursors.WaitCursor;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = Path.GetTempPath() + "\\adb.exe";
            process.StartInfo = startInfo;

            startInfo.Arguments = "get-serialno";
            process.Start();
            string line = process.StandardError.ReadToEnd();
            if (line.Contains("no devices"))
            {
                tbOutput.Text = "No device found!";
                serialLabel.Text = "";
                codenameLabel.Text = "";
                bootloaderLabel.Text = "";
                return false;
            }
            if (line.Contains("unauthorized"))
            {
                tbOutput.Text = "Device unauthorised!\r\nPlease allow USB debugging!";
                serialLabel.Text = "";
                codenameLabel.Text = "";
                bootloaderLabel.Text = "";
                return false;
            }
            //serialLabel.Text = process.StandardOutput.ReadToEnd();
            string serial = process.StandardOutput.ReadToEnd();
            serialLabel.Text = serial;
            process.Close();

            startInfo.Arguments = "shell getprop ro.product.name";
            process.Start();
            //codenameLabel.Text = process.StandardOutput.ReadToEnd();
            string code = process.StandardOutput.ReadToEnd();
            codenameLabel.Text = code;
            process.Close();

            startInfo.Arguments = "shell getprop ro.boot.flash.locked";
            process.Start();
            string bl = process.StandardOutput.ReadToEnd();
            string stt = "";
            if (bl.Contains("0")) stt = "unlocked";
            if (bl.Contains("1")) stt = "locked";
            bootloaderLabel.Text = stt;
            process.Close();
            tbOutput.Text = "Device found!";
            tbOutput.Update();
            tbOutput.Text += Environment.NewLine + "Serial Number: " + serial;
            tbOutput.Text += "Code Name: " + code;
            tbOutput.Text += "Bootloader: " + stt;
            return true;
        }


        public string Fastboot(string[] args)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!Fastboot_Check()) return null;
            tbOutput.Text = "Please wait...";
            tbOutput.Update();
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = Path.GetTempPath() + "\\fastboot.exe";
            process.StartInfo = startInfo;
            string ret = "";

            string line;
            foreach (string s in args)
            {
                startInfo.Arguments = s;
                process.Start();
                line = process.StandardError.ReadToEnd();
                if (line.Length > 0)
                    ret += line;

                line = process.StandardOutput.ReadToEnd();
                if (line.Length > 0)
                    ret += line;
                process.Close();
            }
            return ret;
        }

        public string Fastboot(string arg)
        {
            return Fastboot(new string[] { arg });
        }

        public string ADB(string[] args)
        {
            Cursor.Current = Cursors.WaitCursor;
            if (!ADB_Check()) return null;
            tbOutput.Text = "Please wait...";
            tbOutput.Update();
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = System.IO.Path.GetTempPath() + "\\adb.exe";
            process.StartInfo = startInfo;
            string ret = "";

            string line;
            foreach (string s in args)
            {
                startInfo.Arguments = s;
                process.Start();
                line = process.StandardOutput.ReadToEnd();
                if (line.Length > 0)
                    ret += line;
                process.Close();
            }
            return ret;
        }

        public string ADB(string arg)
        {
            return ADB(new string[] { arg });
        }

        public void Uninstall(agg app)
        {
            tbOutput.AppendText("Uninstalling " + app.AppName + "...\r\n");
            tbOutput.Update();
            Cursor.Current = Cursors.WaitCursor;
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.UseShellExecute = false;
            startInfo.CreateNoWindow = true;
            startInfo.RedirectStandardError = true;
            startInfo.RedirectStandardOutput = true;
            startInfo.FileName = Path.GetTempPath() + "\\adb.exe";
            process.StartInfo = startInfo;
            startInfo.Arguments = "shell pm uninstall --user 0 " + app.PackageName;
            process.Start();
            tbOutput.AppendText("Result: " + process.StandardOutput.ReadToEnd() + "\r\n");
            tbOutput.Update();
            process.Close();
        }
        #endregion

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void bBroswe_Click(object sender, EventArgs e)
        {
            imageBrowser.FileName = "";
            if (imageBrowser.ShowDialog() == DialogResult.OK)
            {
                imagefile = imageBrowser.FileName;
            }
            if (partitionBox.SelectedItem.ToString() == "recovery" && imagefile.Length > 0)
                bBootRecovery.Enabled = true;
            if (partitionBox.SelectedItem.ToString() != "recovery" || imagefile.Length == 0)
                bBootRecovery.Enabled = false;
        }

        private void PartitionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            imageBrowser.FileName = "";
            if (imageBrowser.ShowDialog() == DialogResult.OK)
            {
                imagefile = imageBrowser.FileName;
            }
            if (partitionBox.SelectedItem.ToString() == "recovery" && imagefile.Length > 0)
                bBootRecovery.Enabled = true;
            if (partitionBox.SelectedItem.ToString() != "recovery" || imagefile.Length == 0)
                bBootRecovery.Enabled = false;
        }

        private void about_Click(object sender, EventArgs e)
        {
            AboutDialog dlg = new AboutDialog();
            dlg.ShowDialog();
        }
        #endregion
        private void bBroswe_Click_1(object sender, EventArgs e)
        {
            imageBrowser.FileName = "";
            if (imageBrowser.ShowDialog() == DialogResult.OK)
            {
                imagefile = imageBrowser.FileName;
            }
            if (partitionBox.SelectedItem.ToString() == "recovery" && imagefile.Length > 0)
                bbootrecovery.Enabled = true;
            if (partitionBox.SelectedItem.ToString() != "recovery" || imagefile.Length == 0)
                bbootrecovery.Enabled = false;
        }

        private void partitionBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (partitionBox.SelectedItem.ToString() == "recovery" && imagefile.Length > 0)
                bbootrecovery.Enabled = true;
            if (partitionBox.SelectedItem.ToString() != "recovery" || imagefile.Length == 0)
                bbootrecovery.Enabled = false;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //AboutDialog dlg = new AboutDialog();
            //dlg.ShowDialog();
        }

        private void loadDeviceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fastboot_Check();
        }

        private void loadAdbToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADB_Check();
        }

        private void bFlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (imagefile.Length == 0) return;
            string line = Fastboot("flash " + partitionBox.SelectedItem.ToString() + " " + imagefile);
            if (line != null) tbOutput.Text = line;
        }

        private void bBootRecoveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line = Fastboot("boot " + imagefile);
            if (line != null) tbOutput.Text = line;
        }

        private void fastBootRecoveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line = Fastboot("reboot");
            if (line != null) tbOutput.Text = line;
        }

        private void bFastbootRebootFastbootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line = Fastboot("reboot bootloader");
            if (line != null) tbOutput.Text = line;
        }

        private void bFastbootRebootEDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line = Fastboot("oem edl");
            if (line != null) tbOutput.Text = line;
        }

        private void bWipeCacheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line = Fastboot("erase cache");
            if (line != null) tbOutput.Text = line;
        }

        private void bUnlockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line = Fastboot("oem unlock");
            if (line != null) tbOutput.Text = line;
        }

        private void blockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line = Fastboot("oem lock");
            if (line != null) tbOutput.Text = line;
        }

        private void bADBRebootSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line = ADB("reboot");
            if (line != null) tbOutput.Text = "Rebooting...";
        }

        private void bADBRebootRecoveryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line = ADB("reboot recovery");
            if (line != null) tbOutput.Text = "Rebooting...";
        }

        private void bADBRebootFastbootToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line = ADB("reboot bootloader");
            if (line != null) tbOutput.Text = "Rebooting...";
        }

        private void bADBRebootEDLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line = ADB("reboot edl");
            if (line != null) tbOutput.Text = "Rebooting...";
        }

        private void bDebloaterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string region = ADB("shell getprop ro.miui.region");
            if (region == null || region.Length < 2)
                region = ADB("shell getprop ro.miui.region2");
            if (region == null) return;
            tbOutput.Text = "";
            bDebloater dlg = new bDebloater(region.Trim());
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                foreach (object selected in dlg.appListBox.CheckedItems)
                {
                    foreach (App app in dlg.Apps)
                    {
                        if (app.UIName == selected.ToString())
                            Uninstall(app);
                    }
                }
            }
            if (tbOutput.Text.Length > 0)
                tbOutput.AppendText("Done!");
        }

        private void bCamera2APIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (camera2button % 2 == 0)
            {
                string line = ADB(new string[] { "shell setprop persist.camera.HAL3.enabled 1", "shell setprop persist.camera.eis.enable 1" });
                if (line != null)
                {
                    tbOutput.Text = "Enabled!";
                    bCamera2API.Text = "Disable camera2 API (TWRP only)";
                    camera2button++;
                }
            }
            else
            {
                string line = ADB(new string[] { "shell setprop persist.camera.HAL3.enabled 0", "shell setprop persist.camera.eis.enable 0" });
                if (line != null)
                {
                    tbOutput.Text = "Disabled!";
                    bCamera2API.Text = "Enable camera2 API (TWRP only)";
                    camera2button++;
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process[] proc1 = System.Diagnostics.Process.GetProcessesByName("adb");
            foreach (System.Diagnostics.Process p in proc1)
                p.Kill();
            System.Diagnostics.Process[] proc2 = System.Diagnostics.Process.GetProcessesByName("fastboot");
            foreach (System.Diagnostics.Process p in proc2)
                p.Kill();
            System.Threading.Thread.Sleep(100);
            File.Delete(System.IO.Path.GetTempPath() + "\\adb.exe");
            File.Delete(System.IO.Path.GetTempPath() + "\\fastboot.exe");
            File.Delete(System.IO.Path.GetTempPath() + "\\AdbWinApi.dll");
            File.Delete(System.IO.Path.GetTempPath() + "\\AdbWinUsbApi.dll");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
