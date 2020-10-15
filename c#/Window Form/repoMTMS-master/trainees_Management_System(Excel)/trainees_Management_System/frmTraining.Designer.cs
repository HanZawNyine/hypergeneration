namespace trainees_Management_System
{
    partial class frmTraining
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraining));
            this.lblTraining = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvTrainner = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoOtherRank = new System.Windows.Forms.RadioButton();
            this.rdoOfficer = new System.Windows.Forms.RadioButton();
            this.lblS_date = new System.Windows.Forms.Label();
            this.lblE_date = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainner)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTraining
            // 
            this.lblTraining.AutoSize = true;
            this.lblTraining.Font = new System.Drawing.Font("Myanmar3", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraining.Location = new System.Drawing.Point(289, 23);
            this.lblTraining.Name = "lblTraining";
            this.lblTraining.Size = new System.Drawing.Size(240, 20);
            this.lblTraining.TabIndex = 0;
            this.lblTraining.Text = "မိုင်းရှင်းယာဉ်အသုံးပြုနည်းသင်တန်း";
            this.lblTraining.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "ဖွင့် ၊";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(690, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "ဆင်း ၊";
            // 
            // dgvTrainner
            // 
            this.dgvTrainner.AllowUserToAddRows = false;
            this.dgvTrainner.AllowUserToDeleteRows = false;
            this.dgvTrainner.AllowUserToResizeRows = false;
            this.dgvTrainner.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTrainner.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTrainner.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTrainner.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTrainner.ColumnHeadersHeight = 30;
            this.dgvTrainner.EnableHeadersVisualStyles = false;
            this.dgvTrainner.Location = new System.Drawing.Point(2, 179);
            this.dgvTrainner.MultiSelect = false;
            this.dgvTrainner.Name = "dgvTrainner";
            this.dgvTrainner.ReadOnly = true;
            this.dgvTrainner.RowHeadersVisible = false;
            this.dgvTrainner.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myanmar3", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTrainner.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTrainner.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTrainner.Size = new System.Drawing.Size(888, 320);
            this.dgvTrainner.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoOtherRank);
            this.groupBox1.Controls.Add(this.rdoOfficer);
            this.groupBox1.Controls.Add(this.lblS_date);
            this.groupBox1.Controls.Add(this.lblE_date);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTraining);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(10, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 117);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // rdoOtherRank
            // 
            this.rdoOtherRank.AutoSize = true;
            this.rdoOtherRank.Location = new System.Drawing.Point(421, 73);
            this.rdoOtherRank.Name = "rdoOtherRank";
            this.rdoOtherRank.Size = new System.Drawing.Size(71, 23);
            this.rdoOtherRank.TabIndex = 6;
            this.rdoOtherRank.TabStop = true;
            this.rdoOtherRank.Text = "စစ်သည်";
            this.rdoOtherRank.UseVisualStyleBackColor = true;
            this.rdoOtherRank.CheckedChanged += new System.EventHandler(this.rdoOtherRank_CheckedChanged);
            // 
            // rdoOfficer
            // 
            this.rdoOfficer.AutoSize = true;
            this.rdoOfficer.Location = new System.Drawing.Point(333, 73);
            this.rdoOfficer.Name = "rdoOfficer";
            this.rdoOfficer.Size = new System.Drawing.Size(62, 23);
            this.rdoOfficer.TabIndex = 5;
            this.rdoOfficer.TabStop = true;
            this.rdoOfficer.Text = "အရာရှိ";
            this.rdoOfficer.UseVisualStyleBackColor = true;
            this.rdoOfficer.CheckedChanged += new System.EventHandler(this.rdoOfficer_CheckedChanged);
            // 
            // lblS_date
            // 
            this.lblS_date.AutoSize = true;
            this.lblS_date.Location = new System.Drawing.Point(62, 77);
            this.lblS_date.Name = "lblS_date";
            this.lblS_date.Size = new System.Drawing.Size(59, 19);
            this.lblS_date.TabIndex = 4;
            this.lblS_date.Text = "6/6/2018";
            // 
            // lblE_date
            // 
            this.lblE_date.AutoSize = true;
            this.lblE_date.Location = new System.Drawing.Point(739, 77);
            this.lblE_date.Name = "lblE_date";
            this.lblE_date.Size = new System.Drawing.Size(59, 19);
            this.lblE_date.TabIndex = 3;
            this.lblE_date.Text = "6/6/2018";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(891, 26);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
            this.printToolStripMenuItem.Text = "Export Excel File";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(2, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 146);
            this.panel1.TabIndex = 16;
            // 
            // frmTraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTrainner);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmTraining";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Training";
            this.Load += new System.EventHandler(this.frmTraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrainner)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTraining;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvTrainner;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblS_date;
        private System.Windows.Forms.Label lblE_date;
        private System.Windows.Forms.RadioButton rdoOtherRank;
        private System.Windows.Forms.RadioButton rdoOfficer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}