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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQLVIEM)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSQLVIEM
            // 
            this.dgvSQLVIEM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSQLVIEM.Location = new System.Drawing.Point(4, 3);
            this.dgvSQLVIEM.Name = "dgvSQLVIEM";
            this.dgvSQLVIEM.RowHeadersWidth = 51;
            this.dgvSQLVIEM.RowTemplate.Height = 24;
            this.dgvSQLVIEM.Size = new System.Drawing.Size(601, 448);
            this.dgvSQLVIEM.TabIndex = 0;
            this.dgvSQLVIEM.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSQLVIEM_CellContentClick);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(639, 35);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(139, 103);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(657, 201);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(120, 144);
            this.btnclear.TabIndex = 2;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // frmGirdView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvSQLVIEM);
            this.Name = "frmGirdView";
            this.Text = "frmGirmView";
            this.Load += new System.EventHandler(this.frmGirdView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSQLVIEM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSQLVIEM;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnclear;
    }
}