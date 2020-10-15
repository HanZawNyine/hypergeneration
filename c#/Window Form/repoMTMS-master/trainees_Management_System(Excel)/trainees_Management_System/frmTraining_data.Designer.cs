namespace trainees_Management_System
{
    partial class frmTraining_data
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTraining_data));
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.txtBatch = new NumericTextBox.NumericTextBox();
            this.txtQty = new NumericTextBox.NumericTextBox();
            this.cbotraining_name = new System.Windows.Forms.ComboBox();
            this.dtpkS_date = new System.Windows.Forms.DateTimePicker();
            this.dtpkE_date = new System.Windows.Forms.DateTimePicker();
            this.lblBatch = new System.Windows.Forms.Label();
            this.lblS_date = new System.Windows.Forms.Label();
            this.lblE_date = new System.Windows.Forms.Label();
            this.lblQty = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTraining_name = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining_name)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(613, 144);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(170, 35);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "စာရင်းသွင်းရန်";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseEnter += new System.EventHandler(this.btnAdd_MouseEnter);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(69, 30);
            this.lblName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(205, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "သင်တန်းအမည်                          :";
            // 
            // txtBatch
            // 
            this.txtBatch.AllowSpace = false;
            this.txtBatch.Location = new System.Drawing.Point(340, 59);
            this.txtBatch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBatch.Name = "txtBatch";
            this.txtBatch.Size = new System.Drawing.Size(153, 27);
            this.txtBatch.TabIndex = 2;
            // 
            // txtQty
            // 
            this.txtQty.AllowSpace = false;
            this.txtQty.Location = new System.Drawing.Point(340, 152);
            this.txtQty.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(153, 27);
            this.txtQty.TabIndex = 3;
            // 
            // cbotraining_name
            // 
            this.cbotraining_name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotraining_name.FormattingEnabled = true;
            this.cbotraining_name.Location = new System.Drawing.Point(340, 27);
            this.cbotraining_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbotraining_name.Name = "cbotraining_name";
            this.cbotraining_name.Size = new System.Drawing.Size(443, 28);
            this.cbotraining_name.TabIndex = 4;
            this.cbotraining_name.SelectedIndexChanged += new System.EventHandler(this.cbotraining_name_SelectedIndexChanged);
            // 
            // dtpkS_date
            // 
            this.dtpkS_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkS_date.Location = new System.Drawing.Point(340, 90);
            this.dtpkS_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpkS_date.Name = "dtpkS_date";
            this.dtpkS_date.Size = new System.Drawing.Size(153, 27);
            this.dtpkS_date.TabIndex = 5;
            // 
            // dtpkE_date
            // 
            this.dtpkE_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkE_date.Location = new System.Drawing.Point(340, 121);
            this.dtpkE_date.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpkE_date.Name = "dtpkE_date";
            this.dtpkE_date.Size = new System.Drawing.Size(153, 27);
            this.dtpkE_date.TabIndex = 6;
            // 
            // lblBatch
            // 
            this.lblBatch.AutoSize = true;
            this.lblBatch.ForeColor = System.Drawing.Color.White;
            this.lblBatch.Location = new System.Drawing.Point(69, 61);
            this.lblBatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(204, 20);
            this.lblBatch.TabIndex = 7;
            this.lblBatch.Text = "အမှတ်စဉ်                                  :";
            // 
            // lblS_date
            // 
            this.lblS_date.AutoSize = true;
            this.lblS_date.ForeColor = System.Drawing.Color.White;
            this.lblS_date.Location = new System.Drawing.Point(69, 92);
            this.lblS_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblS_date.Name = "lblS_date";
            this.lblS_date.Size = new System.Drawing.Size(204, 20);
            this.lblS_date.TabIndex = 8;
            this.lblS_date.Text = "သင်တန်းဖွင့်ပွဲ(ရက်)                   :";
            // 
            // lblE_date
            // 
            this.lblE_date.AutoSize = true;
            this.lblE_date.ForeColor = System.Drawing.Color.White;
            this.lblE_date.Location = new System.Drawing.Point(69, 123);
            this.lblE_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblE_date.Name = "lblE_date";
            this.lblE_date.Size = new System.Drawing.Size(203, 20);
            this.lblE_date.TabIndex = 9;
            this.lblE_date.Text = "သင်တန်းဆင်းပွဲ(ရက်)                :";
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.ForeColor = System.Drawing.Color.White;
            this.lblQty.Location = new System.Drawing.Point(69, 154);
            this.lblQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQty.Name = "lblQty";
            this.lblQty.Size = new System.Drawing.Size(204, 20);
            this.lblQty.TabIndex = 10;
            this.lblQty.Text = "သင်တန်းသားအင်အား                 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.lblQty);
            this.groupBox1.Controls.Add(this.lblE_date);
            this.groupBox1.Controls.Add(this.lblS_date);
            this.groupBox1.Controls.Add(this.lblBatch);
            this.groupBox1.Controls.Add(this.dtpkE_date);
            this.groupBox1.Controls.Add(this.dtpkS_date);
            this.groupBox1.Controls.Add(this.cbotraining_name);
            this.groupBox1.Controls.Add(this.txtQty);
            this.groupBox1.Controls.Add(this.txtBatch);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(11, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(831, 194);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // dgvTraining_name
            // 
            this.dgvTraining_name.AllowUserToAddRows = false;
            this.dgvTraining_name.AllowUserToDeleteRows = false;
            this.dgvTraining_name.AllowUserToResizeRows = false;
            this.dgvTraining_name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTraining_name.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTraining_name.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTraining_name.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTraining_name.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTraining_name.EnableHeadersVisualStyles = false;
            this.dgvTraining_name.Location = new System.Drawing.Point(0, 207);
            this.dgvTraining_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTraining_name.MultiSelect = false;
            this.dgvTraining_name.Name = "dgvTraining_name";
            this.dgvTraining_name.RowHeadersVisible = false;
            this.dgvTraining_name.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myanmar3", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTraining_name.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTraining_name.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTraining_name.Size = new System.Drawing.Size(1046, 253);
            this.dgvTraining_name.TabIndex = 12;
            this.dgvTraining_name.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvTraining_name_CellBeginEdit);
            this.dgvTraining_name.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTraining_name_CellEndEdit);
            this.dgvTraining_name.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvTraining_name_MouseUp);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 451);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1046, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslInfo
            // 
            this.tsslInfo.Name = "tsslInfo";
            this.tsslInfo.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1046, 199);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(857, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(177, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
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
            // frmTraining_data
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 473);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvTraining_name);
            this.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmTraining_data";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Training data";
            this.Load += new System.EventHandler(this.frmTraining_data_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining_name)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblName;
        private NumericTextBox.NumericTextBox txtBatch;
        private NumericTextBox.NumericTextBox txtQty;
        private System.Windows.Forms.ComboBox cbotraining_name;
        private System.Windows.Forms.DateTimePicker dtpkS_date;
        private System.Windows.Forms.DateTimePicker dtpkE_date;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.Label lblS_date;
        private System.Windows.Forms.Label lblE_date;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTraining_name;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}