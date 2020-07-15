namespace ADB_Tool_001
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.bBrowse = new System.Windows.Forms.ToolStripMenuItem();
            this.partitionBox = new System.Windows.Forms.ComboBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadfastboot = new System.Windows.Forms.ToolStripMenuItem();
            this.loadadb = new System.Windows.Forms.ToolStripMenuItem();
            this.bFlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bbootrecovery = new System.Windows.Forms.ToolStripMenuItem();
            this.fastBootRecoveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bFastbootRebootFastbootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bFastbootRebootEDLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bWipeCacheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bUnlockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bADBRebootSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bADBRebootRecoveryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bADBRebootFastbootToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bADBRebootEDLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stringLineADBshellGetpropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bDebloater = new System.Windows.Forms.ToolStripMenuItem();
            this.serialLabel = new System.Windows.Forms.Label();
            this.codenameLabel = new System.Windows.Forms.Label();
            this.bootloaderLabel = new System.Windows.Forms.Label();
            this.tbOutput = new System.Windows.Forms.TextBox();
            this.bCamera2API = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bBrowse,
            this.aaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // bBrowse
            // 
            this.bBrowse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.loadfastboot,
            this.loadadb,
            this.bFlToolStripMenuItem,
            this.bbootrecovery,
            this.fastBootRecoveryToolStripMenuItem,
            this.bFastbootRebootFastbootToolStripMenuItem,
            this.bFastbootRebootEDLToolStripMenuItem,
            this.bWipeCacheToolStripMenuItem,
            this.bUnlockToolStripMenuItem,
            this.blockToolStripMenuItem,
            this.bADBRebootSystemToolStripMenuItem,
            this.bADBRebootRecoveryToolStripMenuItem,
            this.bADBRebootFastbootToolStripMenuItem,
            this.bADBRebootEDLToolStripMenuItem,
            this.stringLineADBshellGetpropToolStripMenuItem});
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(74, 26);
            this.bBrowse.Text = "B broswe";
            this.bBrowse.Click += new System.EventHandler(this.bBroswe_Click_1);
            // 
            // partitionBox
            // 
            this.partitionBox.FormattingEnabled = true;
            this.partitionBox.Location = new System.Drawing.Point(230, 102);
            this.partitionBox.Name = "partitionBox";
            this.partitionBox.Size = new System.Drawing.Size(360, 24);
            this.partitionBox.TabIndex = 1;
            this.partitionBox.SelectedIndexChanged += new System.EventHandler(this.partitionBox_SelectedIndexChanged_1);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // loadfastboot
            // 
            this.loadfastboot.Name = "loadfastboot";
            this.loadfastboot.Size = new System.Drawing.Size(279, 26);
            this.loadfastboot.Text = "load device";
            this.loadfastboot.Click += new System.EventHandler(this.loadDeviceToolStripMenuItem_Click);
            // 
            // loadadb
            // 
            this.loadadb.Name = "loadadb";
            this.loadadb.Size = new System.Drawing.Size(279, 26);
            this.loadadb.Text = "load adb";
            this.loadadb.Click += new System.EventHandler(this.loadAdbToolStripMenuItem_Click);
            // 
            // bFlToolStripMenuItem
            // 
            this.bFlToolStripMenuItem.Name = "bFlToolStripMenuItem";
            this.bFlToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.bFlToolStripMenuItem.Text = "b flesh";
            this.bFlToolStripMenuItem.Click += new System.EventHandler(this.bFlToolStripMenuItem_Click);
            // 
            // bbootrecovery
            // 
            this.bbootrecovery.Name = "bbootrecovery";
            this.bbootrecovery.Size = new System.Drawing.Size(279, 26);
            this.bbootrecovery.Text = "b boot recovery";
            this.bbootrecovery.Click += new System.EventHandler(this.bBootRecoveryToolStripMenuItem_Click);
            // 
            // fastBootRecoveryToolStripMenuItem
            // 
            this.fastBootRecoveryToolStripMenuItem.Name = "fastBootRecoveryToolStripMenuItem";
            this.fastBootRecoveryToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.fastBootRecoveryToolStripMenuItem.Text = "Fast Boot Recovery";
            this.fastBootRecoveryToolStripMenuItem.Click += new System.EventHandler(this.fastBootRecoveryToolStripMenuItem_Click);
            // 
            // bFastbootRebootFastbootToolStripMenuItem
            // 
            this.bFastbootRebootFastbootToolStripMenuItem.Name = "bFastbootRebootFastbootToolStripMenuItem";
            this.bFastbootRebootFastbootToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.bFastbootRebootFastbootToolStripMenuItem.Text = "bFastbootRebootFastboot";
            this.bFastbootRebootFastbootToolStripMenuItem.Click += new System.EventHandler(this.bFastbootRebootFastbootToolStripMenuItem_Click);
            // 
            // bFastbootRebootEDLToolStripMenuItem
            // 
            this.bFastbootRebootEDLToolStripMenuItem.Name = "bFastbootRebootEDLToolStripMenuItem";
            this.bFastbootRebootEDLToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.bFastbootRebootEDLToolStripMenuItem.Text = "bFastbootRebootEDL";
            this.bFastbootRebootEDLToolStripMenuItem.Click += new System.EventHandler(this.bFastbootRebootEDLToolStripMenuItem_Click);
            // 
            // bWipeCacheToolStripMenuItem
            // 
            this.bWipeCacheToolStripMenuItem.Name = "bWipeCacheToolStripMenuItem";
            this.bWipeCacheToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.bWipeCacheToolStripMenuItem.Text = "bWipeCache";
            this.bWipeCacheToolStripMenuItem.Click += new System.EventHandler(this.bWipeCacheToolStripMenuItem_Click);
            // 
            // bUnlockToolStripMenuItem
            // 
            this.bUnlockToolStripMenuItem.Name = "bUnlockToolStripMenuItem";
            this.bUnlockToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.bUnlockToolStripMenuItem.Text = " bUnlock";
            this.bUnlockToolStripMenuItem.Click += new System.EventHandler(this.bUnlockToolStripMenuItem_Click);
            // 
            // blockToolStripMenuItem
            // 
            this.blockToolStripMenuItem.Name = "blockToolStripMenuItem";
            this.blockToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.blockToolStripMenuItem.Text = "block";
            this.blockToolStripMenuItem.Click += new System.EventHandler(this.blockToolStripMenuItem_Click);
            // 
            // bADBRebootSystemToolStripMenuItem
            // 
            this.bADBRebootSystemToolStripMenuItem.Name = "bADBRebootSystemToolStripMenuItem";
            this.bADBRebootSystemToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.bADBRebootSystemToolStripMenuItem.Text = "bADBRebootSystem";
            this.bADBRebootSystemToolStripMenuItem.Click += new System.EventHandler(this.bADBRebootSystemToolStripMenuItem_Click);
            // 
            // bADBRebootRecoveryToolStripMenuItem
            // 
            this.bADBRebootRecoveryToolStripMenuItem.Name = "bADBRebootRecoveryToolStripMenuItem";
            this.bADBRebootRecoveryToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.bADBRebootRecoveryToolStripMenuItem.Text = "bADBRebootRecovery";
            this.bADBRebootRecoveryToolStripMenuItem.Click += new System.EventHandler(this.bADBRebootRecoveryToolStripMenuItem_Click);
            // 
            // bADBRebootFastbootToolStripMenuItem
            // 
            this.bADBRebootFastbootToolStripMenuItem.Name = "bADBRebootFastbootToolStripMenuItem";
            this.bADBRebootFastbootToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.bADBRebootFastbootToolStripMenuItem.Text = "bADBRebootFastboot";
            this.bADBRebootFastbootToolStripMenuItem.Click += new System.EventHandler(this.bADBRebootFastbootToolStripMenuItem_Click);
            // 
            // bADBRebootEDLToolStripMenuItem
            // 
            this.bADBRebootEDLToolStripMenuItem.Name = "bADBRebootEDLToolStripMenuItem";
            this.bADBRebootEDLToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.bADBRebootEDLToolStripMenuItem.Text = "bADBRebootEDL";
            this.bADBRebootEDLToolStripMenuItem.Click += new System.EventHandler(this.bADBRebootEDLToolStripMenuItem_Click);
            // 
            // stringLineADBshellGetpropToolStripMenuItem
            // 
            this.stringLineADBshellGetpropToolStripMenuItem.Name = "stringLineADBshellGetpropToolStripMenuItem";
            this.stringLineADBshellGetpropToolStripMenuItem.Size = new System.Drawing.Size(279, 26);
            this.stringLineADBshellGetpropToolStripMenuItem.Text = "string line = ADB(\"shell getprop\");";
            // 
            // aaToolStripMenuItem
            // 
            this.aaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bDebloater});
            this.aaToolStripMenuItem.Name = "aaToolStripMenuItem";
            this.aaToolStripMenuItem.Size = new System.Drawing.Size(35, 26);
            this.aaToolStripMenuItem.Text = "aa";
            // 
            // bDebloater
            // 
            this.bDebloater.Name = "bDebloater";
            this.bDebloater.Size = new System.Drawing.Size(224, 26);
            this.bDebloater.Text = "bDebloater";
            this.bDebloater.Click += new System.EventHandler(this.bDebloaterToolStripMenuItem_Click);
            // 
            // serialLabel
            // 
            this.serialLabel.AutoSize = true;
            this.serialLabel.Location = new System.Drawing.Point(52, 102);
            this.serialLabel.Name = "serialLabel";
            this.serialLabel.Size = new System.Drawing.Size(77, 17);
            this.serialLabel.TabIndex = 2;
            this.serialLabel.Text = "serialLabel";
            this.serialLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // codenameLabel
            // 
            this.codenameLabel.AutoSize = true;
            this.codenameLabel.Location = new System.Drawing.Point(52, 140);
            this.codenameLabel.Name = "codenameLabel";
            this.codenameLabel.Size = new System.Drawing.Size(109, 17);
            this.codenameLabel.TabIndex = 3;
            this.codenameLabel.Text = "codenameLabel";
            // 
            // bootloaderLabel
            // 
            this.bootloaderLabel.AutoSize = true;
            this.bootloaderLabel.Location = new System.Drawing.Point(56, 211);
            this.bootloaderLabel.Name = "bootloaderLabel";
            this.bootloaderLabel.Size = new System.Drawing.Size(111, 17);
            this.bootloaderLabel.TabIndex = 4;
            this.bootloaderLabel.Text = "bootloaderLabel";
            // 
            // tbOutput
            // 
            this.tbOutput.Location = new System.Drawing.Point(323, 223);
            this.tbOutput.Name = "tbOutput";
            this.tbOutput.Size = new System.Drawing.Size(226, 22);
            this.tbOutput.TabIndex = 5;
            // 
            // bCamera2API
            // 
            this.bCamera2API.AutoSize = true;
            this.bCamera2API.Location = new System.Drawing.Point(132, 289);
            this.bCamera2API.Name = "bCamera2API";
            this.bCamera2API.Size = new System.Drawing.Size(94, 17);
            this.bCamera2API.TabIndex = 6;
            this.bCamera2API.Text = "bCamera2API";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bCamera2API);
            this.Controls.Add(this.tbOutput);
            this.Controls.Add(this.bootloaderLabel);
            this.Controls.Add(this.codenameLabel);
            this.Controls.Add(this.serialLabel);
            this.Controls.Add(this.partitionBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem bBrowse;
        private System.Windows.Forms.ComboBox partitionBox;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadfastboot;
        private System.Windows.Forms.ToolStripMenuItem loadadb;
        private System.Windows.Forms.ToolStripMenuItem bFlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bbootrecovery;
        private System.Windows.Forms.ToolStripMenuItem fastBootRecoveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bFastbootRebootFastbootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bFastbootRebootEDLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bWipeCacheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bUnlockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bADBRebootSystemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bADBRebootRecoveryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bADBRebootFastbootToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bADBRebootEDLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stringLineADBshellGetpropToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bDebloater;
        private System.Windows.Forms.Label serialLabel;
        private System.Windows.Forms.Label codenameLabel;
        private System.Windows.Forms.Label bootloaderLabel;
        private System.Windows.Forms.TextBox tbOutput;
        private System.Windows.Forms.Label bCamera2API;
    }
}

