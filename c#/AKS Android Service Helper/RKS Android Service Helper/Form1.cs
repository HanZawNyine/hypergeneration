using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Mobile;
using Mobiletool;
using Moobile_Myanmar_Service_Tool;



namespace RKS_Android_Service_Helper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void carbonFiberButton3_Click(object sender, EventArgs e)
        {
            if (iTalk_ComboBox1.SelectedIndex==1)
            {
                textBox1.Clear();
                textBox1.AppendText("Searching Adb Device . . .");

                if (QDCOM.adbConnect())
                {
                    textBox1.AppendText("OK " + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Device : Found" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Reading info . . ." + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Sending Adb Command . . ." + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    Thread.Sleep(1000);
                    progressBar1.Value = 10;
                    textBox1.AppendText("Brand : " + QDCOM.AdbCommand("shell getprop ro.product.manufacturer") + Environment.NewLine);
                    textBox1.AppendText("Model : " + QDCOM.AdbCommand("shell getprop ro.product.model") + Environment.NewLine);
                    progressBar1.Value = 20;
                    textBox1.AppendText("Product Name : " + QDCOM.AdbCommand("shell getprop ro.product.name") + Environment.NewLine);
                    textBox1.AppendText("Android Version : " + QDCOM.AdbCommand("shell getprop ro.build.version.release") + Environment.NewLine);
                    textBox1.AppendText("Build Date : " + QDCOM.AdbCommand("shell getprop ro.build.date") + Environment.NewLine);
                    progressBar1.Value = 30;
                    textBox1.AppendText("CPU Type : " + QDCOM.AdbCommand("shell getprop ro.hardware") + Environment.NewLine);
                    textBox1.AppendText("Chipset : " + QDCOM.AdbCommand("shell getprop ro.board.platform") + Environment.NewLine);
                    progressBar1.Value = 40;
                    textBox1.AppendText("MIUI Version : " + QDCOM.AdbCommand("shell getprop ro.miui.ui.version.name") + Environment.NewLine);
                    progressBar1.Value = 50;
                    textBox1.AppendText("Security Patch : " + QDCOM.AdbCommand("shell getprop ro.build.version.security_patch") + Environment.NewLine);
                    textBox1.AppendText("IMEI (1) : " + QDCOM.AdbCommand("shell getprop ro.ril.miui.imei0") + Environment.NewLine);
                    progressBar1.Value = 60;
                    textBox1.AppendText("IMEI (2) : " + QDCOM.AdbCommand("shell getprop ro.ril.miui.imei1") + Environment.NewLine);
                    progressBar1.Value = 70;
                    textBox1.AppendText("Bootloader : " + QDCOM.AdbCommand("shell getprop ro.secureboot.lockstate") + Environment.NewLine);
                    textBox1.AppendText("Data : " + QDCOM.AdbCommand("shell getprop ro.crypto.state") + Environment.NewLine);
                    progressBar1.Value = 80;
                    textBox1.AppendText("Checking Security . . .");
                    Thread.Sleep(1000);
                    textBox1.AppendText("OK " + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Removing Userlock . . . ");
                    QDCOM.AdbCommand("shell pm uninstall --user 0 com.android.systemui");
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    QDCOM.AdbCommand("reboot");
                    textBox1.AppendText("Device : Reboot" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("The operation completed successfully" + Environment.NewLine);
                    progressBar1.Value = 100;

                }
                else
                {
                    textBox1.AppendText("FAIL! " + Environment.NewLine);
                    textBox1.AppendText("Device : Not Found" + Environment.NewLine);
                }
            }



            if (iTalk_ComboBox1.SelectedIndex == 2)
            {
                textBox1.Clear();
                textBox1.AppendText("Searching Adb Device . . .");

                if (QDCOM.adbConnect())
                {
                    textBox1.AppendText("OK " + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Device : Found" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Reading info . . ." + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Sending Adb Command . . ." + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    Thread.Sleep(1000);
                    progressBar1.Value = 10;
                    textBox1.AppendText("Brand : " + QDCOM.AdbCommand("shell getprop ro.product.manufacturer") + Environment.NewLine);
                    textBox1.AppendText("Model : " + QDCOM.AdbCommand("shell getprop ro.product.model") + Environment.NewLine);
                    progressBar1.Value = 20;
                    textBox1.AppendText("Product Name : " + QDCOM.AdbCommand("shell getprop ro.product.name") + Environment.NewLine);
                    textBox1.AppendText("Android Version : " + QDCOM.AdbCommand("shell getprop ro.build.version.release") + Environment.NewLine);
                    textBox1.AppendText("Build Date : " + QDCOM.AdbCommand("shell getprop ro.build.date") + Environment.NewLine);
                    progressBar1.Value = 30;
                    textBox1.AppendText("CPU Type : " + QDCOM.AdbCommand("shell getprop ro.hardware") + Environment.NewLine);
                    textBox1.AppendText("Chipset : " + QDCOM.AdbCommand("shell getprop ro.board.platform") + Environment.NewLine);
                    progressBar1.Value = 40;
                    textBox1.AppendText("MIUI Version : " + QDCOM.AdbCommand("shell getprop ro.miui.ui.version.name") + Environment.NewLine);
                    progressBar1.Value = 50;
                    textBox1.AppendText("Security Patch : " + QDCOM.AdbCommand("shell getprop ro.build.version.security_patch") + Environment.NewLine);
                    textBox1.AppendText("IMEI (1) : " + QDCOM.AdbCommand("shell getprop ro.ril.miui.imei0") + Environment.NewLine);
                    progressBar1.Value = 60;
                    textBox1.AppendText("IMEI (2) : " + QDCOM.AdbCommand("shell getprop ro.ril.miui.imei1") + Environment.NewLine);
                    progressBar1.Value = 70;
                    textBox1.AppendText("Bootloader : " + QDCOM.AdbCommand("shell getprop ro.secureboot.lockstate") + Environment.NewLine);
                    textBox1.AppendText("Data : " + QDCOM.AdbCommand("shell getprop ro.crypto.state") + Environment.NewLine);
                    progressBar1.Value = 80;
                    textBox1.AppendText("Checking Security . . .");
                    Thread.Sleep(1000);
                    textBox1.AppendText("OK " + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Removing FRP Lock  . . . ");
                    QDCOM.AdbCommand("shell pm uninstall --user 0 com.android.systemui");
                    QDCOM.AdbCommand("shell am start -n com.google.android.gsf.login/");
                    QDCOM.AdbCommand("shell am start -n com.google.android.gsf.login.LoginActivity");
                    QDCOM.AdbCommand("shell content insert --uri content://settings/secure --bind name:s:user_setup_complete --bind value:s:1");
                    QDCOM.AdbCommand("shell content insert --uri content://settings/secure --bind name:s:user_setup_complete --bind value:s:1");
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    QDCOM.AdbCommand("reboot");
                    textBox1.AppendText("Device : Reboot" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("The operation completed successfully" + Environment.NewLine);
                    progressBar1.Value = 100;

                }
                else
                {
                    textBox1.AppendText("FAIL! " + Environment.NewLine);
                    textBox1.AppendText("Device : Not Found" + Environment.NewLine);
                }
            }






        }

        private void carbonFiberButton4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.AppendText("Searching Adb Device . . .");

            if (QDCOM.adbConnect())
            {
                textBox1.AppendText("OK " + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                textBox1.AppendText("Device : Found" + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                textBox1.AppendText("Reading info . . ." + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                textBox1.AppendText("Sending Adb Command . . ." + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                Thread.Sleep(1000);
                progressBar1.Value = 10;
                textBox1.AppendText("Brand : " + QDCOM.AdbCommand("shell getprop ro.product.manufacturer") + Environment.NewLine);
                textBox1.AppendText("Model : " + QDCOM.AdbCommand("shell getprop ro.product.model") + Environment.NewLine);
                progressBar1.Value = 20;
                textBox1.AppendText("Product Name : " + QDCOM.AdbCommand("shell getprop ro.product.name") + Environment.NewLine);
                textBox1.AppendText("Android Version : " + QDCOM.AdbCommand("shell getprop ro.build.version.release") + Environment.NewLine);
                textBox1.AppendText("Build Date : " + QDCOM.AdbCommand("shell getprop ro.build.date") + Environment.NewLine);
                progressBar1.Value = 30;
                textBox1.AppendText("CPU Type : " + QDCOM.AdbCommand("shell getprop ro.hardware") + Environment.NewLine);
                textBox1.AppendText("Chipset : " + QDCOM.AdbCommand("shell getprop ro.board.platform") + Environment.NewLine);
                progressBar1.Value = 40;
                textBox1.AppendText("MIUI Version : " + QDCOM.AdbCommand("shell getprop ro.miui.ui.version.name") + Environment.NewLine);
                progressBar1.Value = 50;
                textBox1.AppendText("Security Patch : " + QDCOM.AdbCommand("shell getprop ro.build.version.security_patch") + Environment.NewLine);
                textBox1.AppendText("IMEI (1) : " + QDCOM.AdbCommand("shell getprop ro.ril.miui.imei0") + Environment.NewLine);
                progressBar1.Value = 60;
                textBox1.AppendText("IMEI (2) : " + QDCOM.AdbCommand("shell getprop ro.ril.miui.imei1") + Environment.NewLine);
                progressBar1.Value = 70;
                textBox1.AppendText("Bootloader : " + QDCOM.AdbCommand("shell getprop ro.secureboot.lockstate") + Environment.NewLine);
                progressBar1.Value = 80;
                textBox1.AppendText("Data : " + QDCOM.AdbCommand("shell getprop ro.crypto.state") + Environment.NewLine);
                progressBar1.Value = 90;
                textBox1.AppendText("The operation completed successfully" + Environment.NewLine);
                progressBar1.Value = 100;

            }
            else
            {
                textBox1.AppendText("FAIL! " + Environment.NewLine);
                textBox1.AppendText("Device : Not Found" + Environment.NewLine);
            }


        }

        private void carbonFiberButton5_Click(object sender, EventArgs e)
        {
            if (flatComboBox1.SelectedIndex == 1)
            {
                textBox1.Clear();
                textBox1.AppendText("Searching Adb Device . . .");
                if (QDCOM.adbConnect())
                {
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("Sending Adb Command . . ." + Environment.NewLine);
                    QDCOM.AdbCommand("reboot");
                    textBox1.AppendText("All OK" + Environment.NewLine);

                }
                else
                {
                    textBox1.AppendText("FAIL !" + Environment.NewLine);
                    textBox1.AppendText("Device : Not Found" + Environment.NewLine);
                }
            }




            if (flatComboBox1.SelectedIndex == 2)
            {
                textBox1.Clear();
                textBox1.AppendText("Searching Adb Device . . .");
                if (QDCOM.adbConnect())
                {
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("Sending Adb Command . . ." + Environment.NewLine);
                    QDCOM.AdbCommand("reboot recovery");
                    textBox1.AppendText("All OK" + Environment.NewLine);

                }
                else
                {
                    textBox1.AppendText("FAIL !" + Environment.NewLine);
                    textBox1.AppendText("Device : Not Found" + Environment.NewLine);
                }
            }



            if (flatComboBox1.SelectedIndex == 3)
            {
                textBox1.Clear();
                textBox1.AppendText("Searching Adb Device . . .");
                if (QDCOM.adbConnect())
                {
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("Sending Adb Command . . ." + Environment.NewLine);
                    QDCOM.AdbCommand("reboot bootloader");
                    textBox1.AppendText("All OK" + Environment.NewLine);

                }
                else
                {
                    textBox1.AppendText("FAIL !" + Environment.NewLine);
                    textBox1.AppendText("Device : Not Found" + Environment.NewLine);
                }
            }

            if (flatComboBox1.SelectedIndex == 4)
            {
                textBox1.Clear();
                textBox1.AppendText("Searching Adb Device . . .");
                if (QDCOM.adbConnect())
                {
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("Sending Adb Command . . ." + Environment.NewLine);
                    QDCOM.AdbCommand("reboot download");
                    textBox1.AppendText("All OK" + Environment.NewLine);

                }
                else
                {
                    textBox1.AppendText("FAIL !" + Environment.NewLine);
                    textBox1.AppendText("Device : Not Found" + Environment.NewLine);
                }
            }


            if (flatComboBox1.SelectedIndex == 5)
            {
                textBox1.Clear();
                textBox1.AppendText("Searching Adb Device . . .");
                if (QDCOM.adbConnect())
                {
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("Sending Adb Command . . ." + Environment.NewLine);
                    QDCOM.AdbCommand("reboot edl");
                    textBox1.AppendText("All OK" + Environment.NewLine);

                }
                else
                {
                    textBox1.AppendText("FAIL !" + Environment.NewLine);
                    textBox1.AppendText("Device : Not Found" + Environment.NewLine);
                }
            }




        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void carbonFiberTheme1_Click(object sender, EventArgs e)
        {
           
        }

        private void carbonFiberButton2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.AppendText("Searching Adb Device . . .");
           
            if(QDCOM.adbConnect())
            {
                textBox1.AppendText("OK " + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                textBox1.AppendText("Device : Found" + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                textBox1.AppendText("Reading info . . ." + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                textBox1.AppendText("Sending Adb Command . . ." + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                Thread.Sleep(1000);
                progressBar1.Value = 10;
                textBox1.AppendText("Brand : " + QDCOM.AdbCommand("shell getprop ro.product.manufacturer") + Environment.NewLine);
                textBox1.AppendText("Model : " + QDCOM.AdbCommand("shell getprop ro.product.model") + Environment.NewLine);
                progressBar1.Value = 20;
                textBox1.AppendText("Product Name : " + QDCOM.AdbCommand("shell getprop ro.product.name") + Environment.NewLine);
                textBox1.AppendText("Android Version : " + QDCOM.AdbCommand("shell getprop ro.build.version.release") + Environment.NewLine);
                textBox1.AppendText("Build Date : " + QDCOM.AdbCommand("shell getprop ro.build.date") + Environment.NewLine);
                progressBar1.Value = 30;
                textBox1.AppendText("CPU Type : " + QDCOM.AdbCommand("shell getprop ro.hardware") + Environment.NewLine);
                textBox1.AppendText("Chipset : " + QDCOM.AdbCommand("shell getprop ro.board.platform") + Environment.NewLine);
                progressBar1.Value = 40;
                textBox1.AppendText("MIUI Version : " + QDCOM.AdbCommand("shell getprop ro.miui.ui.version.name") + Environment.NewLine);
                progressBar1.Value = 50;
                textBox1.AppendText("Security Patch : " + QDCOM.AdbCommand("shell getprop ro.build.version.security_patch") + Environment.NewLine);
                textBox1.AppendText("IMEI (1) : " + QDCOM.AdbCommand("shell getprop ro.ril.miui.imei0") + Environment.NewLine);
                progressBar1.Value = 60;
                textBox1.AppendText("IMEI (2) : " + QDCOM.AdbCommand("shell getprop ro.ril.miui.imei1") + Environment.NewLine);
                progressBar1.Value = 70;
                textBox1.AppendText("Bootloader : " + QDCOM.AdbCommand("shell getprop ro.secureboot.lockstate") + Environment.NewLine);
                progressBar1.Value = 80;
                textBox1.AppendText("Data : " + QDCOM.AdbCommand("shell getprop ro.crypto.state") + Environment.NewLine);
                progressBar1.Value = 90;
                textBox1.AppendText("The operation completed successfully" + Environment.NewLine);
                progressBar1.Value = 100;

            }
            else
            {
                textBox1.AppendText("FAIL! " + Environment.NewLine);
                textBox1.AppendText("Device : Not Found" + Environment.NewLine);
            }    




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Split().Length > 100)
                textBox1.ScrollBars = ScrollBars.Both;
            else
                textBox1.ScrollBars = ScrollBars.None;
        }

        private void carbonFiberButton1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.AppendText("Searching Adb Device . . .");

            if (QDCOM.adbConnect())

            { 
            textBox1.AppendText("OK " + Environment.NewLine);
            textBox1.AppendText("" + Environment.NewLine);
            textBox1.AppendText("Device : Found" + Environment.NewLine);
            textBox1.AppendText("" + Environment.NewLine);
            textBox1.AppendText("Reading info . . ." + Environment.NewLine);
            textBox1.AppendText("" + Environment.NewLine);
            textBox1.AppendText("Sending Adb Command . . ." + Environment.NewLine);
            textBox1.AppendText("" + Environment.NewLine);
            Thread.Sleep(1000);
            progressBar1.Value = 1;
            textBox1.AppendText("Brand : " + QDCOM.AdbCommand("shell getprop ro.product.manufacturer") + Environment.NewLine);
            textBox1.AppendText("Model : " + QDCOM.AdbCommand("shell getprop ro.product.model") + Environment.NewLine);
            progressBar1.Value = 20;
            textBox1.AppendText("Product Name : " + QDCOM.AdbCommand("shell getprop ro.product.name") + Environment.NewLine);
            textBox1.AppendText("Android Version : " + QDCOM.AdbCommand("shell getprop ro.build.version.release") + Environment.NewLine);
            textBox1.AppendText("Build Date : " + QDCOM.AdbCommand("shell getprop ro.build.date") + Environment.NewLine);
            progressBar1.Value = 30;
            textBox1.AppendText("CPU Type : " + QDCOM.AdbCommand("shell getprop ro.hardware") + Environment.NewLine);
            textBox1.AppendText("Chipset : " + QDCOM.AdbCommand("shell getprop ro.board.platform") + Environment.NewLine);
            progressBar1.Value = 40;
            textBox1.AppendText("MIUI Version : " + QDCOM.AdbCommand("shell getprop ro.miui.ui.version.name") + Environment.NewLine);
            progressBar1.Value = 45;
            textBox1.AppendText("Security Patch : " + QDCOM.AdbCommand("shell getprop ro.build.version.security_patch") + Environment.NewLine);
            textBox1.AppendText("IMEI (1) : " + QDCOM.AdbCommand("shell getprop ro.ril.miui.imei0") + Environment.NewLine);
            progressBar1.Value = 50;
            textBox1.AppendText("IMEI (2) : " + QDCOM.AdbCommand("shell getprop ro.ril.miui.imei1") + Environment.NewLine);
            progressBar1.Value = 58;
            textBox1.AppendText("Bootloader : " + QDCOM.AdbCommand("shell getprop ro.secureboot.lockstate") + Environment.NewLine);
            progressBar1.Value = 60;
            textBox1.AppendText("Data : " + QDCOM.AdbCommand("shell getprop ro.crypto.state") + Environment.NewLine);
            progressBar1.Value = 70;
            textBox1.AppendText("Opening Diag Mode . . . ");
            Thread.Sleep(3000);
            progressBar1.Value = 80;
            QDCOM.AdbCommand("shell su -c setprop sys.usb.config diag,adb");
            textBox1.AppendText("OK" + Environment.NewLine);
            progressBar1.Value = 90;
            textBox1.AppendText("" + Environment.NewLine);
            textBox1.AppendText("Qcom Diag Mode : Opened"+Environment.NewLine);
            textBox1.AppendText("" + Environment.NewLine);
            textBox1.AppendText("The operation completed successfully" + Environment.NewLine);
            progressBar1.Value = 100;

        }
            else
            {
                textBox1.AppendText("FAIL! " + Environment.NewLine);
                textBox1.AppendText("Device : Not Found" + Environment.NewLine);
            }



}

        private void iTalk_ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void carbonFiberButton33_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox1.AppendText("Searching Fastboot Device . . . ");
            
            if(fastboot.fastbootconnect())
            {
                textBox1.AppendText("Ok" + Environment.NewLine);
                textBox1.AppendText("Device : Found " + Environment.NewLine);
            
            }
            else
            {
                textBox1.AppendText("FAIL !" + Environment.NewLine);
                textBox1.AppendText("Device : Not Found" + Environment.NewLine);
            }


        }

        private void carbonFiberButton15_Click(object sender, EventArgs e)
        {

            textBox1.Clear();
            textBox1.AppendText("Searching Fastboot Device . . . ");

            if (fastboot.fastbootconnect())
            {
                textBox1.AppendText("OK" + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                progressBar1.Value = 10;
                textBox1.AppendText("Connecting to Fastboot Mode . . . ");
                Thread.Sleep(3000);
                textBox1.AppendText("OK" + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                progressBar1.Value = 20;
                textBox1.AppendText("Device : Found" + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                textBox1.AppendText("Checking Security . . . ");
                Thread.Sleep(2000);
                textBox1.AppendText("OK" + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                progressBar1.Value = 100;
                textBox1.AppendText("Sending Command . . . ");
                Thread.Sleep(2000);
                textBox1.AppendText("OK" + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                textBox1.AppendText("Erasing Userlock . . . ");
                progressBar1.Value = 40;
                fastboot.fasCommand("-w");
                Thread.Sleep(5000);
                textBox1.AppendText("OK" + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                progressBar1.Value = 80;
                textBox1.AppendText("Wipe Data : Done" + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                fastboot.fasCommand("reboot");
                progressBar1.Value = 90;
                textBox1.AppendText("Device : Reboot" + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                textBox1.AppendText("The operation completed successfully" + Environment.NewLine);
                progressBar1.Value = 100;


            }
            else
            {
                textBox1.AppendText("FAIL !" + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                textBox1.AppendText("Device : Not Found" + Environment.NewLine);
            }




        }

        private void flatComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void carbonFiberButton6_Click(object sender, EventArgs e)
        {
            if (flatComboBox2.SelectedIndex==1)
            {
                textBox1.Clear();
                textBox1.AppendText("Searching Fastboot Device . . . ");

                if(fastboot.fastbootconnect())
                {
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 10;
                    textBox1.AppendText("Device : Found" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 20;
                    textBox1.AppendText("Using Method One To Unlock Bootloader" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Checking Security . . . ");
                    Thread.Sleep(2000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 100;
                    textBox1.AppendText("Sending Command . . . ");
                    Thread.Sleep(2000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Unlocking Bootloader . . . ");
                    progressBar1.Value = 40;
                    fastboot.fasCommand("oem unlock");
                    Thread.Sleep(5000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 80;
                    textBox1.AppendText("Bootloader Unlock : Done" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    fastboot.fasCommand("reboot");
                    progressBar1.Value = 90;
                    textBox1.AppendText("Device : Reboot" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("The operation completed successfully" + Environment.NewLine);
                    progressBar1.Value = 100;


                }
                else
                {
                    textBox1.AppendText("FAIL !"+Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Device : Not Found" + Environment.NewLine);
                }
            }



            if (flatComboBox2.SelectedIndex == 2)
            {
                textBox1.Clear();
                textBox1.AppendText("Searching Fastboot Device . . . ");

                if (fastboot.fastbootconnect())
                {
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 10;
                    textBox1.AppendText("Device : Found" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 20;
                    textBox1.AppendText("Using Method Two To Unlock Bootloader" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Checking Security . . . ");
                    Thread.Sleep(2000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 100;
                    textBox1.AppendText("Sending Command . . . ");
                    Thread.Sleep(2000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Unlocking Bootloader . . . ");
                    progressBar1.Value = 40;
                    fastboot.fasCommand("getvar unlocked");
                    Thread.Sleep(5000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 80;
                    textBox1.AppendText("Bootloader Unlock : Done" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    fastboot.fasCommand("reboot");
                    progressBar1.Value = 90;
                    textBox1.AppendText("Device : Reboot" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("The operation completed successfully" + Environment.NewLine);
                    progressBar1.Value = 100;


                }
                else
                {
                    textBox1.AppendText("FAIL !" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Device : Not Found" + Environment.NewLine);
                }
            }



            if (flatComboBox2.SelectedIndex == 3)
            {
                textBox1.Clear();
                textBox1.AppendText("Searching Fastboot Device . . . ");

                if (fastboot.fastbootconnect())
                {
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 10;
                    textBox1.AppendText("Device : Found" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 20;
                    textBox1.AppendText("Using Method Three To Unlock Bootloader" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Checking Security . . . ");
                    Thread.Sleep(2000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 100;
                    textBox1.AppendText("Sending Command . . . ");
                    Thread.Sleep(2000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Unlocking Bootloader . . . ");
                    progressBar1.Value = 40;
                    fastboot.fasCommand("oem unlock-go");
                    Thread.Sleep(5000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 80;
                    textBox1.AppendText("Bootloader Unlock : Done" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    fastboot.fasCommand("reboot");
                    progressBar1.Value = 90;
                    textBox1.AppendText("Device : Reboot" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("The operation completed successfully" + Environment.NewLine);
                    progressBar1.Value = 100;


                }
                else
                {
                    textBox1.AppendText("FAIL !" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Device : Not Found" + Environment.NewLine);
                }
            }



            if (flatComboBox2.SelectedIndex == 4)
            {
                textBox1.Clear();
                textBox1.AppendText("Searching Fastboot Device . . . ");

                if (fastboot.fastbootconnect())
                {
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 10;
                    textBox1.AppendText("Device : Found" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 20;
                    textBox1.AppendText("Using Method Four To Unlock Bootloader" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Checking Security . . . ");
                    Thread.Sleep(2000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 100;
                    textBox1.AppendText("Sending Command . . . ");
                    Thread.Sleep(2000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Unlocking Bootloader . . . ");
                    progressBar1.Value = 40;
                    fastboot.fasCommand("flashing unlock");
                    Thread.Sleep(5000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 80;
                    textBox1.AppendText("Bootloader Unlock : Done" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    fastboot.fasCommand("reboot");
                    progressBar1.Value = 90;
                    textBox1.AppendText("Device : Reboot" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("The operation completed successfully" + Environment.NewLine);
                    progressBar1.Value = 100;


                }
                else
                {
                    textBox1.AppendText("FAIL !" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Device : Not Found" + Environment.NewLine);
                }
            }






        }

        private void carbonFiberButton7_Click(object sender, EventArgs e)
        {

            if (flatComboBox2.SelectedIndex == 1)
            {
                textBox1.Clear();
                textBox1.AppendText("Searching Fastboot Device . . . ");

                if (fastboot.fastbootconnect())
                {
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 10;
                    textBox1.AppendText("Device : Found" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 20;
                    textBox1.AppendText("Using Method One To Unlock FRP & Account" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Checking Security . . . ");
                    Thread.Sleep(3000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 100;
                    textBox1.AppendText("Sending Command . . . ");
                    Thread.Sleep(2000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Removing FRP & Account Lock . . . ");
                    progressBar1.Value = 40;
                    fastboot.fasCommand("erase config");
                    Thread.Sleep(5000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 80;
                    textBox1.AppendText("FRP & Account Unlock : Done" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    fastboot.fasCommand("reboot");
                    progressBar1.Value = 90;
                    textBox1.AppendText("Device : Reboot" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("The operation completed successfully" + Environment.NewLine);
                    progressBar1.Value = 100;


                }
                else
                {
                    textBox1.AppendText("FAIL !" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Device : Not Found" + Environment.NewLine);
                }
            }


            if (flatComboBox2.SelectedIndex == 2)
            {
                textBox1.Clear();
                textBox1.AppendText("Searching Fastboot Device . . . ");

                if (fastboot.fastbootconnect())
                {
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 10;
                    textBox1.AppendText("Device : Found" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 20;
                    textBox1.AppendText("Using Method Two To Unlock FRP & Account" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Checking Security . . . ");
                    Thread.Sleep(3000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 100;
                    textBox1.AppendText("Sending Command . . . ");
                    Thread.Sleep(2000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Unlocking FRP & Account . . . ");
                    progressBar1.Value = 40;
                    fastboot.fasCommand("erse persist");
                    Thread.Sleep(6000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 80;
                    textBox1.AppendText("FRP & Account Unlock : Done" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    fastboot.fasCommand("reboot");
                    progressBar1.Value = 90;
                    textBox1.AppendText("Device : Reboot" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("The operation completed successfully" + Environment.NewLine);
                    progressBar1.Value = 100;


                }
                else
                {
                    textBox1.AppendText("FAIL !" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Device : Not Found" + Environment.NewLine);
                }
            }


            if (flatComboBox2.SelectedIndex == 3)
            {
                textBox1.Clear();
                textBox1.AppendText("Searching Fastboot Device . . . ");

                if (fastboot.fastbootconnect())
                {
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 10;
                    textBox1.AppendText("Device : Found" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 20;
                    textBox1.AppendText("Using Method Three To Unlock FRP & Account" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Checking Security . . . ");
                    Thread.Sleep(3000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 100;
                    textBox1.AppendText("Sending Command . . . ");
                    Thread.Sleep(2000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Unlocking FRP & Account . . . ");
                    progressBar1.Value = 40;
                    fastboot.fasCommand("-i 0x2a96 erase config");
                    fastboot.fasCommand("-i 0x2a96 reboot");
                    Thread.Sleep(6000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 80;
                    textBox1.AppendText("FRP & Account Unlock : Done" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    fastboot.fasCommand("reboot");
                    progressBar1.Value = 90;
                    textBox1.AppendText("Device : Reboot" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("The operation completed successfully" + Environment.NewLine);
                    progressBar1.Value = 100;


                }
                else
                {
                    textBox1.AppendText("FAIL !" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Device : Not Found" + Environment.NewLine);
                }
            }


            if (flatComboBox2.SelectedIndex == 4)
            {
                textBox1.Clear();
                textBox1.AppendText("Searching Fastboot Device . . . ");

                if (fastboot.fastbootconnect())
                {
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 10;
                    textBox1.AppendText("Device : Found" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 20;
                    textBox1.AppendText("Using Method Four To Unlock FRP & Account" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Checking Security . . . ");
                    Thread.Sleep(3000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 100;
                    textBox1.AppendText("Sending Command . . . ");
                    Thread.Sleep(2000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Unlocking FRP & Account . . . ");
                    progressBar1.Value = 40;
                    fastboot.fasCommand("erase config");
                    fastboot.fasCommand("erase persist");
                    fastboot.fasCommand("-w");
                    fastboot.fasCommand("0x2a96 erase config");
                    fastboot.fasCommand("0x2a96 reboot");
                    Thread.Sleep(6000);
                    textBox1.AppendText("OK" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    progressBar1.Value = 80;
                    textBox1.AppendText("FRP & Account Unlock : Done" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    fastboot.fasCommand("reboot");
                    progressBar1.Value = 90;
                    textBox1.AppendText("Device : Reboot" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("The operation completed successfully" + Environment.NewLine);
                    progressBar1.Value = 100;


                }
                else
                {
                    textBox1.AppendText("FAIL !" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Device : Not Found" + Environment.NewLine);
                }
            }






        }

        private void carbonFiberButton11_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.AppendText("Searching Adb Device  ");

            if (QDCOM.adbConnect())
            {
                textBox1.AppendText(" : OK" + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                progressBar1.Value = 10;
                textBox1.AppendText("Device : Found" + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                textBox1.AppendText("Reading Device Info  ");
                Thread.Sleep(2000);
                textBox1.AppendText(" : OK" + Environment.NewLine);
                progressBar1.Value = 20;
                textBox1.AppendText("" + Environment.NewLine);
                textBox1.AppendText("Brand : " + QDCOM.AdbCommand("shell getprop ro.product.manufacturer") + Environment.NewLine);
                progressBar1.Value = 30;
                textBox1.AppendText("Model : " + QDCOM.AdbCommand("shell getprop ro.product.model") + Environment.NewLine);
                progressBar1.Value = 40;
                textBox1.AppendText("Product Name : " + QDCOM.AdbCommand("shell getprop ro.product.name") + Environment.NewLine);
                progressBar1.Value = 50;
                textBox1.AppendText("Android Version : " + QDCOM.AdbCommand("shell getprop ro.build.version.release") + Environment.NewLine);
                progressBar1.Value = 60;
                textBox1.AppendText("Build Date : " + QDCOM.AdbCommand("shell getprop ro.build.date") + Environment.NewLine);
                progressBar1.Value = 70;
                textBox1.AppendText("CPU Type : " + QDCOM.AdbCommand("shell getprop ro.hardware") + Environment.NewLine);
                progressBar1.Value = 80;
                textBox1.AppendText("Chipset : " + QDCOM.AdbCommand("shell getprop ro.board.platform") + Environment.NewLine);
                textBox1.AppendText("Security Patch : " + QDCOM.AdbCommand("shell getprop ro.build.version.security_patch") + Environment.NewLine);
                progressBar1.Value = 90;
                textBox1.AppendText("Build Number : " + QDCOM.AdbCommand("shell getprop ro.product.sw.internal.version") + Environment.NewLine);
                textBox1.AppendText("Data : " + QDCOM.AdbCommand("shell getprop ro.crypto.state") + Environment.NewLine);
                textBox1.AppendText("The operation completed successfully" + Environment.NewLine);
                progressBar1.Value = 100;
            }
            else
            {
                textBox1.AppendText(" : FAIL" + Environment.NewLine);
                textBox1.AppendText("Device : Not Found" + Environment.NewLine);
            }




        }

        private void carbonFiberButton16_Click(object sender, EventArgs e)
        {

        }

        private void carbonFiberButton9_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.AppendText("Searching Adb Device  ");

            if (QDCOM.adbConnect())
            {
                textBox1.AppendText(" : OK" + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                progressBar1.Value = 10;
                textBox1.AppendText("Device : Found" + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                textBox1.AppendText("Reading Device Info  ");
                Thread.Sleep(2000);
                textBox1.AppendText(" : OK" + Environment.NewLine);
                progressBar1.Value = 20;
                textBox1.AppendText("" + Environment.NewLine);
                textBox1.AppendText("Brand : " + QDCOM.AdbCommand("shell getprop ro.product.manufacturer") + Environment.NewLine);
                progressBar1.Value = 30;
                textBox1.AppendText("Model : " + QDCOM.AdbCommand("shell getprop ro.product.model") + Environment.NewLine);
                progressBar1.Value = 40;
                textBox1.AppendText("Product Name : " + QDCOM.AdbCommand("shell getprop ro.product.name") + Environment.NewLine);
                progressBar1.Value = 50;
                textBox1.AppendText("Android Version : " + QDCOM.AdbCommand("shell getprop ro.build.version.release") + Environment.NewLine);
                progressBar1.Value = 60;
                textBox1.AppendText("Build Date : " + QDCOM.AdbCommand("shell getprop ro.build.date") + Environment.NewLine);
                progressBar1.Value = 70;
                textBox1.AppendText("CPU Type : " + QDCOM.AdbCommand("shell getprop ro.hardware") + Environment.NewLine);
                textBox1.AppendText("Chipset : " + QDCOM.AdbCommand("shell getprop ro.board.platform") + Environment.NewLine);
                textBox1.AppendText("Security Patch : " + QDCOM.AdbCommand("shell getprop ro.build.version.security_patch") + Environment.NewLine);
                textBox1.AppendText("Build Number : " + QDCOM.AdbCommand("shell getprop ro.product.sw.internal.version") + Environment.NewLine);
                textBox1.AppendText("Data : " + QDCOM.AdbCommand("shell getprop ro.crypto.state") + Environment.NewLine);
                textBox1.AppendText("Sending Command  ");
                Thread.Sleep(2000);
                textBox1.AppendText(" : OK " + Environment.NewLine);
                progressBar1.Value = 80;
                textBox1.AppendText("" + Environment.NewLine);
                textBox1.AppendText("Removing Userlock  ");
                QDCOM.AdbCommand("shell pm uninstall --user 0 com.android.systemui");
                Thread.Sleep(5000);
                textBox1.AppendText(" : OK" + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                textBox1.AppendText("Userlock  : Removed" + Environment.NewLine);
                progressBar1.Value = 90;
                textBox1.AppendText("" + Environment.NewLine);
                textBox1.AppendText("Device Reboot ");
                QDCOM.AdbCommand("reboot");
                textBox1.AppendText(" : OK " + Environment.NewLine);
                textBox1.AppendText("" + Environment.NewLine);
                textBox1.AppendText("The operation completed successfully" + Environment.NewLine);
                progressBar1.Value = 100;



            }
            else
            {
                textBox1.AppendText(" : FAIL" + Environment.NewLine);
                textBox1.AppendText("Device : Not Found" + Environment.NewLine);
            }



        }

        private void carbonFiberButton36_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (QDCOM.EdlConnect())
            {
                comboBox7.Text = "Qualcomm EDL Port :  " + QDCOM.EdlComNo();
                textBox1.AppendText("Device : Found" + Environment.NewLine);
                textBox1.AppendText("EDL Port No :" + QDCOM.EdlComNo() + Environment.NewLine);
            }
            else
            {
                comboBox7.Text = "Qualcomm EDL Port  :  Not Found";
                textBox1.AppendText("Device : Not Found" + Environment.NewLine);


            }



        }

        private void carbonFiberButton35_Click(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 1)
            {
                textBox1.Clear();
                textBox1.AppendText("Searching Edl Port ");
                if (QDCOM.EdlConnect())
                {
                    textBox1.AppendText(" : Found" + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("EDL Port No : " + QDCOM.EdlComNo() + Environment.NewLine);
                    textBox1.AppendText("" + Environment.NewLine);
                    textBox1.AppendText("Sending Programmer File ");
                    string Format = QDCOM.EdlCommand("-p"+"QDCOM.EdlComNo()"+"-f A37.mbn -b misc wipe.img");
                    if (Format.Contains("Status: 0 The operation completed successfully."))
                    {
                        Thread.Sleep(5000);
                        textBox1.AppendText(" : OK" + Environment.NewLine);
                        textBox1.AppendText("" + Environment.NewLine);
                        textBox1.AppendText("Connecting To EDL Mode ");
                        Thread.Sleep(3000);
                        textBox1.AppendText(" : OK" + Environment.NewLine);
                        textBox1.AppendText("" + Environment.NewLine);
                        textBox1.AppendText("Checking Security ");
                        Thread.Sleep(3000);
                        textBox1.AppendText(" : OK" + Environment.NewLine);
                        textBox1.AppendText("" + Environment.NewLine);
                        textBox1.AppendText("Sending Command  : OK" + Environment.NewLine);
                        textBox1.AppendText("" + Environment.NewLine);
                        textBox1.AppendText("Removing Userlock ");
                        Thread.Sleep(4000);
                        QDCOM.EdlCommand("emmcdl -p " + QDCOM.EdlComNo() + "-f A37.mbn -b misc wipe.img");
                        textBox1.AppendText(" : DONE" + Environment.NewLine);
                        textBox1.AppendText("" + Environment.NewLine);
                        textBox1.AppendText("Factory Reset  : OK" + Environment.NewLine);
                        textBox1.AppendText("" + Environment.NewLine);
                        textBox1.AppendText("Reinstall Phone Battery & Power On " + Environment.NewLine);
                        textBox1.AppendText("" + Environment.NewLine);
                        textBox1.AppendText("The operation completed successfully" + Environment.NewLine);


                    }

                    else
                    {
                        Thread.Sleep(3000);
                        textBox1.AppendText(" : Fail" + Environment.NewLine);
                        textBox1.AppendText("" + Environment.NewLine);
                        textBox1.AppendText("Connecting To EDL Mode   : Fail " + Environment.NewLine);
                        textBox1.AppendText("" + Environment.NewLine);
                        textBox1.AppendText("Cannot Remove              : Userlock" + Environment.NewLine);
                    }


                }
            }






        }

        private void carbonFiberButton12_Click(object sender, EventArgs e)
        {

        }

        private void carbonFiberButton13_Click(object sender, EventArgs e)
        {

        }

        private void carbonFiberButton8_Click(object sender, EventArgs e)
        {

        }
    }
}
