namespace lab
{
    partial class frmGirdView
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
            this.dgvSQLVIEM = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPhoneNo = new System.Windows.Forms.TextBox();
            this.comboSearch = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQLVIEM)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSQLVIEM
            // 
            this.dgvSQLVIEM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSQLVIEM.Location = new System.Drawing.Point(22, 13);
            this.dgvSQLVIEM.Name = "dgvSQLVIEM";
            this.dgvSQLVIEM.RowHeadersWidth = 51;
            this.dgvSQLVIEM.RowTemplate.Height = 24;
            this.dgvSQLVIEM.Size = new System.Drawing.Size(601, 448);
            this.dgvSQLVIEM.TabIndex = 0;
            this.dgvSQLVIEM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSQLVIEM_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(178, 474);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(139, 77);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(4, 474);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(139, 77);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(712, 211);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(238, 34);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtPhoneNo
            // 
            this.txtPhoneNo.Location = new System.Drawing.Point(712, 149);
            this.txtPhoneNo.Name = "txtPhoneNo";
            this.txtPhoneNo.Size = new System.Drawing.Size(238, 22);
            this.txtPhoneNo.TabIndex = 5;
            this.txtPhoneNo.TextChanged += new System.EventHandler(this.txtPhoneNo_TextChanged);
            // 
            // comboSearch
            // 
            this.comboSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "NAme",
            "PhoneNO",
            "Gmail",
            "Address"});
            this.comboSearch.FormattingEnabled = true;
            this.comboSearch.Items.AddRange(new object[] {
            "Name",
            "Phone NUmber",
            "Gmail",
            "Address"});
            this.comboSearch.Location = new System.Drawing.Point(712, 91);
            this.comboSearch.Name = "comboSearch";
            this.comboSearch.Size = new System.Drawing.Size(238, 24);
            this.comboSearch.TabIndex = 7;
            this.comboSearch.SelectedIndexChanged += new System.EventHandler(this.comboSearch_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(709, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Choose Title";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmGirdView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 563);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboSearch);
            this.Controls.Add(this.txtPhoneNo);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvSQLVIEM);
            this.Name = "frmGirdView";
            this.Text = "frmGirmView";
            this.Load += new System.EventHandler(this.frmGirdView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQLVIEM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSQLVIEM;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPhoneNo;
        private System.Windows.Forms.ComboBox comboSearch;
        private System.Windows.Forms.Label label1;
    }
}