namespace trainees_Management_System
{
    partial class frmExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExcel));
            this.rdoOfficer = new System.Windows.Forms.RadioButton();
            this.rdoOtherRank = new System.Windows.Forms.RadioButton();
            this.rdoTraining = new System.Windows.Forms.RadioButton();
            this.rdoBattalion = new System.Windows.Forms.RadioButton();
            this.cbotrainningName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTrainners = new System.Windows.Forms.DataGridView();
            this.btnExcel_open = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.cboBatch = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainners)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdoOfficer
            // 
            this.rdoOfficer.AutoSize = true;
            this.rdoOfficer.Location = new System.Drawing.Point(233, 18);
            this.rdoOfficer.Name = "rdoOfficer";
            this.rdoOfficer.Size = new System.Drawing.Size(62, 23);
            this.rdoOfficer.TabIndex = 0;
            this.rdoOfficer.TabStop = true;
            this.rdoOfficer.Text = "အရာရှိ";
            this.rdoOfficer.UseVisualStyleBackColor = true;
            this.rdoOfficer.CheckedChanged += new System.EventHandler(this.rdoOfficer_CheckedChanged);
            // 
            // rdoOtherRank
            // 
            this.rdoOtherRank.AutoSize = true;
            this.rdoOtherRank.Location = new System.Drawing.Point(366, 19);
            this.rdoOtherRank.Name = "rdoOtherRank";
            this.rdoOtherRank.Size = new System.Drawing.Size(71, 23);
            this.rdoOtherRank.TabIndex = 1;
            this.rdoOtherRank.TabStop = true;
            this.rdoOtherRank.Text = "စစ်သည်";
            this.rdoOtherRank.UseVisualStyleBackColor = true;
            this.rdoOtherRank.CheckedChanged += new System.EventHandler(this.rdoOtherRank_CheckedChanged);
            // 
            // rdoTraining
            // 
            this.rdoTraining.AutoSize = true;
            this.rdoTraining.Location = new System.Drawing.Point(233, 16);
            this.rdoTraining.Name = "rdoTraining";
            this.rdoTraining.Size = new System.Drawing.Size(117, 23);
            this.rdoTraining.TabIndex = 2;
            this.rdoTraining.TabStop = true;
            this.rdoTraining.Text = "သင်တန်းအလိုက်";
            this.rdoTraining.UseVisualStyleBackColor = true;
            this.rdoTraining.CheckedChanged += new System.EventHandler(this.rdoTraining_CheckedChanged);
            // 
            // rdoBattalion
            // 
            this.rdoBattalion.AutoSize = true;
            this.rdoBattalion.Location = new System.Drawing.Point(366, 16);
            this.rdoBattalion.Name = "rdoBattalion";
            this.rdoBattalion.Size = new System.Drawing.Size(90, 23);
            this.rdoBattalion.TabIndex = 3;
            this.rdoBattalion.TabStop = true;
            this.rdoBattalion.Text = "တပ်အလိုက်";
            this.rdoBattalion.UseVisualStyleBackColor = true;
            this.rdoBattalion.CheckedChanged += new System.EventHandler(this.rdoBattalion_CheckedChanged);
            // 
            // cbotrainningName
            // 
            this.cbotrainningName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotrainningName.FormattingEnabled = true;
            this.cbotrainningName.Location = new System.Drawing.Point(720, 36);
            this.cbotrainningName.Name = "cbotrainningName";
            this.cbotrainningName.Size = new System.Drawing.Size(342, 27);
            this.cbotrainningName.TabIndex = 4;
            this.cbotrainningName.SelectedIndexChanged += new System.EventHandler(this.cbotrainningName_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "သင်တန်းသား အမျိုးအစား    :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "ထည့်သွင်းမည့် အချက်အလက်  :";
            // 
            // dgvTrainners
            // 
            this.dgvTrainners.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrainners.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvTrainners.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrainners.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrainners.ColumnHeadersHeight = 30;
            this.dgvTrainners.EnableHeadersVisualStyles = false;
            this.dgvTrainners.Location = new System.Drawing.Point(1, 166);
            this.dgvTrainners.MultiSelect = false;
            this.dgvTrainners.Name = "dgvTrainners";
            this.dgvTrainners.RowHeadersVisible = false;
            this.dgvTrainners.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myanmar3", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTrainners.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTrainners.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrainners.Size = new System.Drawing.Size(1287, 286);
            this.dgvTrainners.TabIndex = 15;
            // 
            // btnExcel_open
            // 
            this.btnExcel_open.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnExcel_open.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcel_open.FlatAppearance.BorderSize = 0;
            this.btnExcel_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcel_open.ForeColor = System.Drawing.Color.Black;
            this.btnExcel_open.Location = new System.Drawing.Point(1098, 34);
            this.btnExcel_open.Name = "btnExcel_open";
            this.btnExcel_open.Size = new System.Drawing.Size(165, 44);
            this.btnExcel_open.TabIndex = 16;
            this.btnExcel_open.Text = "Open Excel File";
            this.btnExcel_open.UseVisualStyleBackColor = false;
            this.btnExcel_open.Click += new System.EventHandler(this.btnExcel_open_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(1098, 87);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(165, 41);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.rdoBattalion);
            this.groupBox1.Controls.Add(this.rdoTraining);
            this.groupBox1.Location = new System.Drawing.Point(6, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(474, 48);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rdoOtherRank);
            this.groupBox2.Controls.Add(this.rdoOfficer);
            this.groupBox2.Location = new System.Drawing.Point(6, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 51);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // cboBatch
            // 
            this.cboBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBatch.FormattingEnabled = true;
            this.cboBatch.Location = new System.Drawing.Point(962, 101);
            this.cboBatch.Name = "cboBatch";
            this.cboBatch.Size = new System.Drawing.Size(100, 27);
            this.cboBatch.TabIndex = 20;
            this.cboBatch.SelectedIndexChanged += new System.EventHandler(this.cboBatch_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(523, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "အမှတ်စဉ်                        :";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox3.Controls.Add(this.lblName);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.cboBatch);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Controls.Add(this.groupBox1);
            this.groupBox3.Controls.Add(this.btnAdd);
            this.groupBox3.Controls.Add(this.btnExcel_open);
            this.groupBox3.Controls.Add(this.cbotrainningName);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(11, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1269, 152);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(502, 39);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(180, 19);
            this.lblName.TabIndex = 22;
            this.lblName.Text = "သင်တန်းအမည်                     :";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1287, 160);
            this.panel1.TabIndex = 23;
            // 
            // frmExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTrainners);
            this.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmExcel";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel Import";
            this.Load += new System.EventHandler(this.frmExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainners)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rdoOfficer;
        private System.Windows.Forms.RadioButton rdoOtherRank;
        private System.Windows.Forms.RadioButton rdoTraining;
        private System.Windows.Forms.RadioButton rdoBattalion;
        private System.Windows.Forms.ComboBox cbotrainningName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTrainners;
        private System.Windows.Forms.Button btnExcel_open;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ComboBox cboBatch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblName;
    }
}