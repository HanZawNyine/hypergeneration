namespace trainees_Management_System
{
    partial class frmOfficer
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOfficer));
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblBc_no = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblBattalion = new System.Windows.Forms.Label();
            this.txtBc_no = new NumericTextBox.NumericTextBox();
            this.cboRank = new System.Windows.Forms.ComboBox();
            this.txtBattalion = new System.Windows.Forms.TextBox();
            this.dgvOfficer = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboBatch = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd_Tstate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.txtSearch_bc = new NumericTextBox.NumericTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch_Officer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbotrainningName = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboRank_Search = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBc_search = new NumericTextBox.NumericTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSearchTRaining = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfficer)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(745, 121);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(178, 40);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "စာရင်းသွင်းရန်";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            // 
            // lblBc_no
            // 
            this.lblBc_no.AutoSize = true;
            this.lblBc_no.ForeColor = System.Drawing.Color.White;
            this.lblBc_no.Location = new System.Drawing.Point(222, 29);
            this.lblBc_no.Name = "lblBc_no";
            this.lblBc_no.Size = new System.Drawing.Size(165, 19);
            this.lblBc_no.TabIndex = 1;
            this.lblBc_no.Text = "ပြန်တမ်း၀င်အမှတ်  :  ကြည်း-";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(428, 99);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 27);
            this.txtName.TabIndex = 2;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.ForeColor = System.Drawing.Color.White;
            this.lblRank.Location = new System.Drawing.Point(222, 65);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(119, 19);
            this.lblRank.TabIndex = 3;
            this.lblRank.Text = "အဆင့်                 : ";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(222, 102);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(115, 19);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "အမည်                 :";
            // 
            // lblBattalion
            // 
            this.lblBattalion.AutoSize = true;
            this.lblBattalion.ForeColor = System.Drawing.Color.White;
            this.lblBattalion.Location = new System.Drawing.Point(222, 137);
            this.lblBattalion.Name = "lblBattalion";
            this.lblBattalion.Size = new System.Drawing.Size(112, 19);
            this.lblBattalion.TabIndex = 5;
            this.lblBattalion.Text = "တပ်/ဌာန             :";
            // 
            // txtBc_no
            // 
            this.txtBc_no.AllowSpace = false;
            this.txtBc_no.Location = new System.Drawing.Point(428, 26);
            this.txtBc_no.Name = "txtBc_no";
            this.txtBc_no.Size = new System.Drawing.Size(235, 27);
            this.txtBc_no.TabIndex = 6;
            // 
            // cboRank
            // 
            this.cboRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRank.FormattingEnabled = true;
            this.cboRank.Items.AddRange(new object[] {
            "ဗိုလ်",
            "ဗိုလ်ကြီး",
            "ဗိုလ်မှူး",
            "ဒု-မှူးကြီး",
            "ဗိုလ်မှူးကြီး",
            "ဗိုလ်မှူးချုပ်",
            "ဗိုလ်ချုပ်"});
            this.cboRank.Location = new System.Drawing.Point(428, 62);
            this.cboRank.Name = "cboRank";
            this.cboRank.Size = new System.Drawing.Size(235, 27);
            this.cboRank.TabIndex = 7;
            this.cboRank.SelectedIndexChanged += new System.EventHandler(this.cboRank_SelectedIndexChanged);
            // 
            // txtBattalion
            // 
            this.txtBattalion.Location = new System.Drawing.Point(428, 134);
            this.txtBattalion.Name = "txtBattalion";
            this.txtBattalion.Size = new System.Drawing.Size(235, 27);
            this.txtBattalion.TabIndex = 8;
            // 
            // dgvOfficer
            // 
            this.dgvOfficer.AllowDrop = true;
            this.dgvOfficer.AllowUserToAddRows = false;
            this.dgvOfficer.AllowUserToDeleteRows = false;
            this.dgvOfficer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvOfficer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            this.dgvOfficer.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvOfficer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvOfficer.ColumnHeadersHeight = 45;
            this.dgvOfficer.EnableHeadersVisualStyles = false;
            this.dgvOfficer.Location = new System.Drawing.Point(8, 238);
            this.dgvOfficer.MultiSelect = false;
            this.dgvOfficer.Name = "dgvOfficer";
            this.dgvOfficer.RowHeadersVisible = false;
            this.dgvOfficer.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Myanmar3", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvOfficer.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvOfficer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOfficer.Size = new System.Drawing.Size(1344, 221);
            this.dgvOfficer.TabIndex = 9;
            this.dgvOfficer.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvOfficer_CellBeginEdit);
            this.dgvOfficer.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOfficer_CellEndEdit);
            this.dgvOfficer.Scroll += new System.Windows.Forms.ScrollEventHandler(this.dgvOfficer_Scroll);
            this.dgvOfficer.Sorted += new System.EventHandler(this.dgvOfficer_Sorted);
            this.dgvOfficer.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvOfficer_MouseUp);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.txtBattalion);
            this.groupBox1.Controls.Add(this.cboRank);
            this.groupBox1.Controls.Add(this.txtBc_no);
            this.groupBox1.Controls.Add(this.lblBattalion);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblRank);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblBc_no);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1081, 186);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "သင်တန်းသားအမည်စာရင်းထည့်ရန်";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 449);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1354, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslInfo
            // 
            this.tsslInfo.Name = "tsslInfo";
            this.tsslInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox2.Controls.Add(this.cboBatch);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnAdd_Tstate);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtGrade);
            this.groupBox2.Controls.Add(this.txtSearch_bc);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtSearch_Officer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbotrainningName);
            this.groupBox2.Location = new System.Drawing.Point(8, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(957, 188);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            // 
            // cboBatch
            // 
            this.cboBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBatch.FormattingEnabled = true;
            this.cboBatch.Location = new System.Drawing.Point(177, 91);
            this.cboBatch.Name = "cboBatch";
            this.cboBatch.Size = new System.Drawing.Size(125, 27);
            this.cboBatch.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(394, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(213, 19);
            this.label6.TabIndex = 18;
            this.label6.Text = "သင်တန်းတက်ရောက်မှူစာရင်းထည့်ရန်";
            // 
            // btnAdd_Tstate
            // 
            this.btnAdd_Tstate.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAdd_Tstate.FlatAppearance.BorderSize = 0;
            this.btnAdd_Tstate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd_Tstate.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd_Tstate.ForeColor = System.Drawing.Color.Black;
            this.btnAdd_Tstate.Location = new System.Drawing.Point(755, 130);
            this.btnAdd_Tstate.Name = "btnAdd_Tstate";
            this.btnAdd_Tstate.Size = new System.Drawing.Size(189, 38);
            this.btnAdd_Tstate.TabIndex = 17;
            this.btnAdd_Tstate.Text = "စာရင်းသွင်းရန်";
            this.btnAdd_Tstate.UseVisualStyleBackColor = false;
            this.btnAdd_Tstate.Click += new System.EventHandler(this.btnAdd_Tstate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(26, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 19);
            this.label5.TabIndex = 16;
            this.label5.Text = "သင်တန်းဆင်း အဆင့်   :";
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(177, 139);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(125, 27);
            this.txtGrade.TabIndex = 15;
            // 
            // txtSearch_bc
            // 
            this.txtSearch_bc.AllowSpace = false;
            this.txtSearch_bc.Location = new System.Drawing.Point(755, 40);
            this.txtSearch_bc.Name = "txtSearch_bc";
            this.txtSearch_bc.Size = new System.Drawing.Size(189, 27);
            this.txtSearch_bc.TabIndex = 14;
            this.txtSearch_bc.TextChanged += new System.EventHandler(this.txtSearch_bc_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 19);
            this.label4.TabIndex = 13;
            this.label4.Text = "အမှတ်စဉ်                   :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(571, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "အမည်                              :";
            // 
            // txtSearch_Officer
            // 
            this.txtSearch_Officer.Location = new System.Drawing.Point(755, 84);
            this.txtSearch_Officer.Name = "txtSearch_Officer";
            this.txtSearch_Officer.ReadOnly = true;
            this.txtSearch_Officer.Size = new System.Drawing.Size(189, 27);
            this.txtSearch_Officer.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(571, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "ပြန်တမ်း၀င်အမှတ်   ကြည်း- :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "သင်တန်းအမည်           :";
            // 
            // cbotrainningName
            // 
            this.cbotrainningName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotrainningName.FormattingEnabled = true;
            this.cbotrainningName.Location = new System.Drawing.Point(177, 40);
            this.cbotrainningName.Name = "cbotrainningName";
            this.cbotrainningName.Size = new System.Drawing.Size(384, 27);
            this.cbotrainningName.TabIndex = 2;
            this.cbotrainningName.SelectedIndexChanged += new System.EventHandler(this.cbotrainningName_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox3.Controls.Add(this.btnExcel);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cboRank_Search);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtBc_search);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.btnSearch);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(6, 8);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1332, 188);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "ပြန်တမ်း၀င်အမှတ်ဖြင့်ရှာရန်";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 19);
            this.label9.TabIndex = 9;
            this.label9.Text = "အဆင့်       :";
            // 
            // cboRank_Search
            // 
            this.cboRank_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRank_Search.FormattingEnabled = true;
            this.cboRank_Search.Items.AddRange(new object[] {
            "ဗိုလ်",
            "ဗိုလ်ကြီး",
            "ဗိုလ်မှူး",
            "ဒု-မှူးကြီး",
            "ဗိုလ်မှူးကြီး",
            "ဗိုလ်မှူးချုပ်",
            "ဗိုလ်ချုပ်"});
            this.cboRank_Search.Location = new System.Drawing.Point(436, 50);
            this.cboRank_Search.Name = "cboRank_Search";
            this.cboRank_Search.Size = new System.Drawing.Size(207, 27);
            this.cboRank_Search.TabIndex = 8;
            this.cboRank_Search.SelectedIndexChanged += new System.EventHandler(this.cboRank_Search_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(378, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 19);
            this.label7.TabIndex = 7;
            this.label7.Text = "ကြည်း-";
            // 
            // txtBc_search
            // 
            this.txtBc_search.AllowSpace = false;
            this.txtBc_search.Location = new System.Drawing.Point(436, 94);
            this.txtBc_search.Name = "txtBc_search";
            this.txtBc_search.Size = new System.Drawing.Size(207, 27);
            this.txtBc_search.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(198, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 19);
            this.label11.TabIndex = 1;
            this.label11.Text = "ပြန်တမ်း၀င်အမှတ်       :";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(749, 83);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(157, 38);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "ရှာရန်";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1354, 235);
            this.tabControl1.TabIndex = 17;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1346, 203);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "သင်တန်းသားအမည်စာရင်းထည့်ရန်";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1182, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1346, 203);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "သင်တန်းတက်ရောက်မှူစာရင်း";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cboSearchTRaining);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(971, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(367, 188);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "လက်ကျန်သင်တန်းသားများရှာဖွေရန်";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(19, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 19);
            this.label8.TabIndex = 6;
            this.label8.Text = "သင်တန်းအမည်           :";
            // 
            // cboSearchTRaining
            // 
            this.cboSearchTRaining.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSearchTRaining.FormattingEnabled = true;
            this.cboSearchTRaining.Location = new System.Drawing.Point(15, 84);
            this.cboSearchTRaining.Name = "cboSearchTRaining";
            this.cboSearchTRaining.Size = new System.Drawing.Size(346, 27);
            this.cboSearchTRaining.TabIndex = 3;
            this.cboSearchTRaining.SelectedIndexChanged += new System.EventHandler(this.cboSearchTRaining_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1346, 203);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "ပြန်တမ်း၀င်အမှတ်ဖြင့်ရှာရန်";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnExcel.FlatAppearance.BorderSize = 0;
            this.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel.ForeColor = System.Drawing.Color.Black;
            this.btnExcel.Location = new System.Drawing.Point(933, 83);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(157, 38);
            this.btnExcel.TabIndex = 10;
            this.btnExcel.Text = "Excel File ထုတ်ရန်";
            this.btnExcel.UseVisualStyleBackColor = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // frmOfficer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1354, 471);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvOfficer);
            this.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmOfficer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Officer";
            this.Load += new System.EventHandler(this.frmOfficer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOfficer)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblBc_no;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblBattalion;
        private NumericTextBox.NumericTextBox txtBc_no;
        private System.Windows.Forms.ComboBox cboRank;
        private System.Windows.Forms.TextBox txtBattalion;
        private System.Windows.Forms.DataGridView dgvOfficer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslInfo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbotrainningName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSearch_Officer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd_Tstate;
        private NumericTextBox.NumericTextBox txtSearch_bc;
        private System.Windows.Forms.GroupBox groupBox3;
        private NumericTextBox.NumericTextBox txtBc_search;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboSearchTRaining;
        private System.Windows.Forms.ComboBox cboBatch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboRank_Search;
        private System.Windows.Forms.Button btnExcel;
    }
}