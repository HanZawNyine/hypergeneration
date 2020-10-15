using System;
namespace trainees_Management_System
{
    partial class frmMain
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.trainnigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.သငတနအခကအလကToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.သငတနသToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ထညသငရနToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.စစသညToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.excelFileမတဆငထညသငရနToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backupပလပရနToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.အရနသမဆညရနToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.အရဖငအအသပရနToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnTsearch = new System.Windows.Forms.Button();
            this.txt_Tno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbotrainningName = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOfficer = new System.Windows.Forms.Button();
            this.txtOfficer = new System.Windows.Forms.TextBox();
            this.cboOfficer_training = new System.Windows.Forms.ComboBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRanker = new System.Windows.Forms.Button();
            this.txtRanker = new System.Windows.Forms.TextBox();
            this.cboRanker_training = new System.Windows.Forms.ComboBox();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Myanmar3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trainnigToolStripMenuItem,
            this.သငတနသToolStripMenuItem,
            this.backupပလပရနToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1185, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // trainnigToolStripMenuItem
            // 
            this.trainnigToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem1,
            this.သငတနအခကအလကToolStripMenuItem});
            this.trainnigToolStripMenuItem.Name = "trainnigToolStripMenuItem";
            this.trainnigToolStripMenuItem.Size = new System.Drawing.Size(116, 21);
            this.trainnigToolStripMenuItem.Text = "သင်တန်းအမျိုးအစား";
            // 
            // newToolStripMenuItem1
            // 
            this.newToolStripMenuItem1.Name = "newToolStripMenuItem1";
            this.newToolStripMenuItem1.Size = new System.Drawing.Size(249, 22);
            this.newToolStripMenuItem1.Text = "သင်တန်းအမည် ထည့်သွင်းရန်";
            this.newToolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem1_Click);
            // 
            // သငတနအခကအလကToolStripMenuItem
            // 
            this.သငတနအခကအလကToolStripMenuItem.Name = "သငတနအခကအလကToolStripMenuItem";
            this.သငတနအခကအလကToolStripMenuItem.Size = new System.Drawing.Size(249, 22);
            this.သငတနအခကအလကToolStripMenuItem.Text = "သင်တန်းအချက်အလက် ထည့်သွင်းရန်";
            this.သငတနအခကအလကToolStripMenuItem.Click += new System.EventHandler(this.သငတနအခကအလကToolStripMenuItem_Click);
            // 
            // သငတနသToolStripMenuItem
            // 
            this.သငတနသToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ထညသငရနToolStripMenuItem,
            this.စစသညToolStripMenuItem,
            this.excelFileမတဆငထညသငရနToolStripMenuItem});
            this.သငတနသToolStripMenuItem.Name = "သငတနသToolStripMenuItem";
            this.သငတနသToolStripMenuItem.Size = new System.Drawing.Size(83, 21);
            this.သငတနသToolStripMenuItem.Text = "သင်တန်းသား";
            // 
            // ထညသငရနToolStripMenuItem
            // 
            this.ထညသငရနToolStripMenuItem.Name = "ထညသငရနToolStripMenuItem";
            this.ထညသငရနToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.ထညသငရနToolStripMenuItem.Text = "အရာရှိ";
            this.ထညသငရနToolStripMenuItem.Click += new System.EventHandler(this.ထညသငရနToolStripMenuItem_Click);
            // 
            // စစသညToolStripMenuItem
            // 
            this.စစသညToolStripMenuItem.Name = "စစသညToolStripMenuItem";
            this.စစသညToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.စစသညToolStripMenuItem.Text = "စစ်သည်";
            this.စစသညToolStripMenuItem.Click += new System.EventHandler(this.စစသညToolStripMenuItem_Click);
            // 
            // excelFileမတဆငထညသငရနToolStripMenuItem
            // 
            this.excelFileမတဆငထညသငရနToolStripMenuItem.Name = "excelFileမတဆငထညသငရနToolStripMenuItem";
            this.excelFileမတဆငထညသငရနToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.excelFileမတဆငထညသငရနToolStripMenuItem.Text = "Excel file မှ တဆင့်ထည့်သွင်းရန်";
            this.excelFileမတဆငထညသငရနToolStripMenuItem.Click += new System.EventHandler(this.excelFileမတဆငထညသငရနToolStripMenuItem_Click);
            // 
            // backupပလပရနToolStripMenuItem
            // 
            this.backupပလပရနToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.အရနသမဆညရနToolStripMenuItem,
            this.အရဖငအအသပရနToolStripMenuItem});
            this.backupပလပရနToolStripMenuItem.Name = "backupပလပရနToolStripMenuItem";
            this.backupပလပရနToolStripMenuItem.Size = new System.Drawing.Size(107, 21);
            this.backupပလပရနToolStripMenuItem.Text = "backup ပြုလုပ်ရန်";
            // 
            // အရနသမဆညရနToolStripMenuItem
            // 
            this.အရနသမဆညရနToolStripMenuItem.Name = "အရနသမဆညရနToolStripMenuItem";
            this.အရနသမဆညရနToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.အရနသမဆညရနToolStripMenuItem.Text = "Backup file သိမ်းဆည်းရန်";
            this.အရနသမဆညရနToolStripMenuItem.Click += new System.EventHandler(this.အရနသမဆညရနToolStripMenuItem_Click);
            // 
            // အရဖငအအသပရနToolStripMenuItem
            // 
            this.အရဖငအအသပရနToolStripMenuItem.Name = "အရဖငအအသပရနToolStripMenuItem";
            this.အရဖငအအသပရနToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.အရဖငအအသပရနToolStripMenuItem.Text = "Database Restore ပြုလုပ်ရန်";
            this.အရဖငအအသပရနToolStripMenuItem.Click += new System.EventHandler(this.အရဖငအအသပရနToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginAccountsToolStripMenuItem,
            this.usageToolStripMenuItem,
            this.errorLogToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(66, 21);
            this.helpToolStripMenuItem.Text = "အကူအညီ";
            // 
            // loginAccountsToolStripMenuItem
            // 
            this.loginAccountsToolStripMenuItem.Name = "loginAccountsToolStripMenuItem";
            this.loginAccountsToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.loginAccountsToolStripMenuItem.Text = "Login Accounts";
            this.loginAccountsToolStripMenuItem.Click += new System.EventHandler(this.loginAccountsToolStripMenuItem_Click);
            // 
            // usageToolStripMenuItem
            // 
            this.usageToolStripMenuItem.Name = "usageToolStripMenuItem";
            this.usageToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.usageToolStripMenuItem.Text = "Usage";
            this.usageToolStripMenuItem.Click += new System.EventHandler(this.usageToolStripMenuItem_Click);
            // 
            // errorLogToolStripMenuItem
            // 
            this.errorLogToolStripMenuItem.Name = "errorLogToolStripMenuItem";
            this.errorLogToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.errorLogToolStripMenuItem.Text = "Error Log";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutMeToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(55, 21);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // aboutMeToolStripMenuItem
            // 
            this.aboutMeToolStripMenuItem.Name = "aboutMeToolStripMenuItem";
            this.aboutMeToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.aboutMeToolStripMenuItem.Text = "About me";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabControl1.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1185, 141);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage2.ForeColor = System.Drawing.Color.White;
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1177, 109);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "သင်တန်းအမှတ်စဉ် အလိုက်ရှာဖွေရန် ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnTsearch);
            this.groupBox2.Controls.Add(this.txt_Tno);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cbotrainningName);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(174, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(894, 83);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "သင်တန်းအမည်ရွေးရန်";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnTsearch
            // 
            this.btnTsearch.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnTsearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTsearch.FlatAppearance.BorderSize = 0;
            this.btnTsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTsearch.ForeColor = System.Drawing.Color.Black;
            this.btnTsearch.Location = new System.Drawing.Point(736, 35);
            this.btnTsearch.Name = "btnTsearch";
            this.btnTsearch.Size = new System.Drawing.Size(152, 31);
            this.btnTsearch.TabIndex = 4;
            this.btnTsearch.Text = "ရှာရန်";
            this.btnTsearch.UseVisualStyleBackColor = false;
            this.btnTsearch.Click += new System.EventHandler(this.btnTsearch_Click);
            // 
            // txt_Tno
            // 
            this.txt_Tno.Location = new System.Drawing.Point(596, 36);
            this.txt_Tno.Name = "txt_Tno";
            this.txt_Tno.Size = new System.Drawing.Size(100, 27);
            this.txt_Tno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "  အမှတ်စဉ်";
            // 
            // cbotrainningName
            // 
            this.cbotrainningName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotrainningName.FormattingEnabled = true;
            this.cbotrainningName.Location = new System.Drawing.Point(12, 37);
            this.cbotrainningName.Name = "cbotrainningName";
            this.cbotrainningName.Size = new System.Drawing.Size(511, 27);
            this.cbotrainningName.TabIndex = 1;
            this.cbotrainningName.SelectedIndexChanged += new System.EventHandler(this.cbotrainningName_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage3.ForeColor = System.Drawing.Color.White;
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1177, 109);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "အရာရှိသင်တန်းများ အလိုက်ရှာဖွေရန်";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOfficer);
            this.groupBox1.Controls.Add(this.txtOfficer);
            this.groupBox1.Controls.Add(this.cboOfficer_training);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(275, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(679, 80);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "အရာရှိသင်တန်းများ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(401, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "  အမှတ်စဉ်";
            // 
            // btnOfficer
            // 
            this.btnOfficer.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnOfficer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOfficer.FlatAppearance.BorderSize = 0;
            this.btnOfficer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOfficer.ForeColor = System.Drawing.Color.Black;
            this.btnOfficer.Location = new System.Drawing.Point(528, 33);
            this.btnOfficer.Name = "btnOfficer";
            this.btnOfficer.Size = new System.Drawing.Size(127, 31);
            this.btnOfficer.TabIndex = 5;
            this.btnOfficer.Text = "ရှာရန်";
            this.btnOfficer.UseVisualStyleBackColor = false;
            this.btnOfficer.Click += new System.EventHandler(this.btnOfficer_Click);
            // 
            // txtOfficer
            // 
            this.txtOfficer.Location = new System.Drawing.Point(396, 35);
            this.txtOfficer.Name = "txtOfficer";
            this.txtOfficer.Size = new System.Drawing.Size(94, 27);
            this.txtOfficer.TabIndex = 3;
            // 
            // cboOfficer_training
            // 
            this.cboOfficer_training.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboOfficer_training.FormattingEnabled = true;
            this.cboOfficer_training.Location = new System.Drawing.Point(13, 35);
            this.cboOfficer_training.Name = "cboOfficer_training";
            this.cboOfficer_training.Size = new System.Drawing.Size(358, 27);
            this.cboOfficer_training.TabIndex = 1;
            this.cboOfficer_training.SelectedIndexChanged += new System.EventHandler(this.cboOfficer_training_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage4.Controls.Add(this.groupBox3);
            this.tabPage4.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage4.ForeColor = System.Drawing.Color.White;
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1177, 109);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "အခြားအဆင့် သင်တန်းများ အလိုက်ရှာဖွေရန်";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnRanker);
            this.groupBox3.Controls.Add(this.txtRanker);
            this.groupBox3.Controls.Add(this.cboRanker_training);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(290, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(686, 81);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "အခြားအဆင့်သင်တန်းများ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(421, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "  အမှတ်စဉ်";
            // 
            // btnRanker
            // 
            this.btnRanker.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnRanker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRanker.FlatAppearance.BorderSize = 0;
            this.btnRanker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRanker.ForeColor = System.Drawing.Color.Black;
            this.btnRanker.Location = new System.Drawing.Point(525, 34);
            this.btnRanker.Name = "btnRanker";
            this.btnRanker.Size = new System.Drawing.Size(141, 31);
            this.btnRanker.TabIndex = 9;
            this.btnRanker.Text = "ရှာရန်";
            this.btnRanker.UseVisualStyleBackColor = false;
            this.btnRanker.Click += new System.EventHandler(this.btnRanker_Click);
            // 
            // txtRanker
            // 
            this.txtRanker.Location = new System.Drawing.Point(417, 36);
            this.txtRanker.Name = "txtRanker";
            this.txtRanker.Size = new System.Drawing.Size(81, 27);
            this.txtRanker.TabIndex = 8;
            // 
            // cboRanker_training
            // 
            this.cboRanker_training.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRanker_training.FormattingEnabled = true;
            this.cboRanker_training.Location = new System.Drawing.Point(18, 36);
            this.cboRanker_training.Name = "cboRanker_training";
            this.cboRanker_training.Size = new System.Drawing.Size(368, 27);
            this.cboRanker_training.TabIndex = 7;
            this.cboRanker_training.SelectedIndexChanged += new System.EventHandler(this.cboRanker_SelectedIndexChanged);
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myanmar3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMain.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.EnableHeadersVisualStyles = false;
            this.dgvMain.Location = new System.Drawing.Point(5, 195);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myanmar3", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMain.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(1173, 424);
            this.dgvMain.TabIndex = 6;
            this.dgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(5, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1180, 428);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 623);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Myanmar3", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Military Training Management System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem trainnigToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorLogToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnTsearch;
        private System.Windows.Forms.TextBox txt_Tno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbotrainningName;
        private System.Windows.Forms.Button btnOfficer;
        private System.Windows.Forms.TextBox txtOfficer;
        private System.Windows.Forms.ComboBox cboOfficer_training;
        private System.Windows.Forms.Button btnRanker;
        private System.Windows.Forms.TextBox txtRanker;
        private System.Windows.Forms.ComboBox cboRanker_training;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.ToolStripMenuItem သငတနသToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ထညသငရနToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backupပလပရနToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem အရနသမဆညရနToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem အရဖငအအသပရနToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ToolStripMenuItem သငတနအခကအလကToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem စစသညToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excelFileမတဆငထညသငရနToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem loginAccountsToolStripMenuItem;
    }
}

