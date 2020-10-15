namespace phone01
{
    partial class frmTechnical
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
            this.dgvTechnical = new System.Windows.Forms.DataGridView();
            this.cboTechnical = new System.Windows.Forms.ComboBox();
            this.lblTechnical = new System.Windows.Forms.Label();
            this.btnTechnical = new System.Windows.Forms.Button();
            this.txtTechnical = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnical)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTechnical
            // 
            this.dgvTechnical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechnical.Location = new System.Drawing.Point(12, 116);
            this.dgvTechnical.Name = "dgvTechnical";
            this.dgvTechnical.RowHeadersWidth = 51;
            this.dgvTechnical.RowTemplate.Height = 24;
            this.dgvTechnical.Size = new System.Drawing.Size(1113, 419);
            this.dgvTechnical.TabIndex = 0;
            this.dgvTechnical.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTechnical_CellContentClick);
            // 
            // cboTechnical
            // 
            this.cboTechnical.FormattingEnabled = true;
            this.cboTechnical.Items.AddRange(new object[] {
            "Order Id",
            "Technical Name",
            "Phone  Password",
            "Amount",
            "Error",
            "StartDate",
            "EndDate",
            "Done"});
            this.cboTechnical.Location = new System.Drawing.Point(144, 21);
            this.cboTechnical.Name = "cboTechnical";
            this.cboTechnical.Size = new System.Drawing.Size(224, 24);
            this.cboTechnical.TabIndex = 1;
            // 
            // lblTechnical
            // 
            this.lblTechnical.AutoSize = true;
            this.lblTechnical.Location = new System.Drawing.Point(37, 25);
            this.lblTechnical.Name = "lblTechnical";
            this.lblTechnical.Size = new System.Drawing.Size(73, 17);
            this.lblTechnical.TabIndex = 2;
            this.lblTechnical.Text = "Search By";
            // 
            // btnTechnical
            // 
            this.btnTechnical.Location = new System.Drawing.Point(668, 22);
            this.btnTechnical.Name = "btnTechnical";
            this.btnTechnical.Size = new System.Drawing.Size(143, 26);
            this.btnTechnical.TabIndex = 3;
            this.btnTechnical.Text = "Search";
            this.btnTechnical.UseVisualStyleBackColor = true;
            this.btnTechnical.Click += new System.EventHandler(this.btnTechnical_Click);
            // 
            // txtTechnical
            // 
            this.txtTechnical.Location = new System.Drawing.Point(399, 22);
            this.txtTechnical.Name = "txtTechnical";
            this.txtTechnical.Size = new System.Drawing.Size(232, 22);
            this.txtTechnical.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(993, 25);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(143, 26);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(832, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(143, 26);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmTechnical
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 551);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtTechnical);
            this.Controls.Add(this.btnTechnical);
            this.Controls.Add(this.lblTechnical);
            this.Controls.Add(this.cboTechnical);
            this.Controls.Add(this.dgvTechnical);
            this.Name = "frmTechnical";
            this.Text = "Technical";
            this.Load += new System.EventHandler(this.frmTechnical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTechnical;
        private System.Windows.Forms.ComboBox cboTechnical;
        private System.Windows.Forms.Label lblTechnical;
        private System.Windows.Forms.Button btnTechnical;
        private System.Windows.Forms.TextBox txtTechnical;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
    }
}