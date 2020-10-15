namespace trainees_Management_System
{
    partial class trainning_info
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(trainning_info));
            this.lblTraining_name = new System.Windows.Forms.Label();
            this.txtTraining_name = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkOfficer = new System.Windows.Forms.CheckBox();
            this.chkO_rank = new System.Windows.Forms.CheckBox();
            this.dgvTraining_name = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining_name)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTraining_name
            // 
            this.lblTraining_name.AutoSize = true;
            this.lblTraining_name.Location = new System.Drawing.Point(15, 32);
            this.lblTraining_name.Name = "lblTraining_name";
            this.lblTraining_name.Size = new System.Drawing.Size(104, 19);
            this.lblTraining_name.TabIndex = 0;
            this.lblTraining_name.Text = "သင်တန်းအမည်  :";
            // 
            // txtTraining_name
            // 
            this.txtTraining_name.Location = new System.Drawing.Point(169, 28);
            this.txtTraining_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTraining_name.Name = "txtTraining_name";
            this.txtTraining_name.Size = new System.Drawing.Size(600, 27);
            this.txtTraining_name.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(401, 83);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(118, 29);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "စာရင်းသွင်းရန်";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.groupBox1.Controls.Add(this.chkOfficer);
            this.groupBox1.Controls.Add(this.chkO_rank);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtTraining_name);
            this.groupBox1.Controls.Add(this.lblTraining_name);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(14, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(792, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // chkOfficer
            // 
            this.chkOfficer.AutoSize = true;
            this.chkOfficer.Location = new System.Drawing.Point(169, 86);
            this.chkOfficer.Name = "chkOfficer";
            this.chkOfficer.Size = new System.Drawing.Size(63, 23);
            this.chkOfficer.TabIndex = 6;
            this.chkOfficer.Text = "အရာရှိ";
            this.chkOfficer.UseVisualStyleBackColor = true;
            // 
            // chkO_rank
            // 
            this.chkO_rank.AutoSize = true;
            this.chkO_rank.Location = new System.Drawing.Point(264, 86);
            this.chkO_rank.Name = "chkO_rank";
            this.chkO_rank.Size = new System.Drawing.Size(97, 23);
            this.chkO_rank.TabIndex = 5;
            this.chkO_rank.Text = "အခြားအဆင့်";
            this.chkO_rank.UseVisualStyleBackColor = true;
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
            this.dgvTraining_name.Location = new System.Drawing.Point(14, 158);
            this.dgvTraining_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvTraining_name.MultiSelect = false;
            this.dgvTraining_name.Name = "dgvTraining_name";
            this.dgvTraining_name.ReadOnly = true;
            this.dgvTraining_name.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvTraining_name.RowHeadersVisible = false;
            this.dgvTraining_name.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Myanmar3", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTraining_name.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTraining_name.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTraining_name.Size = new System.Drawing.Size(970, 358);
            this.dgvTraining_name.TabIndex = 7;
            this.dgvTraining_name.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTraining_name_CellMouseUp);
            this.dgvTraining_name.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dgvTraining_name_MouseUp);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(14, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(970, 146);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(828, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(108, 26);
            // 
            // trainning_info
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 526);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTraining_name);
            this.Font = new System.Drawing.Font("Myanmar3", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "trainning_info";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Training Information";
            this.Load += new System.EventHandler(this.trainning_info_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTraining_name)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTraining_name;
        private System.Windows.Forms.TextBox txtTraining_name;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTraining_name;
        private System.Windows.Forms.CheckBox chkOfficer;
        private System.Windows.Forms.CheckBox chkO_rank;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}