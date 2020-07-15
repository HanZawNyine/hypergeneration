namespace WindowsFormsApp1
{
    partial class Student
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
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.dgvShowAll = new System.Windows.Forms.DataGridView();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAll)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvShowAll
            // 
            this.dgvShowAll.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowAll.Location = new System.Drawing.Point(4, 76);
            this.dgvShowAll.Name = "dgvShowAll";
            this.dgvShowAll.RowHeadersWidth = 51;
            this.dgvShowAll.RowTemplate.Height = 24;
            this.dgvShowAll.Size = new System.Drawing.Size(734, 561);
            this.dgvShowAll.TabIndex = 0;
            this.dgvShowAll.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvShowAll_CellBeginEdit);
            this.dgvShowAll.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowAll_CellContentClick);
            this.dgvShowAll.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowAll_CellContentDoubleClick);
            this.dgvShowAll.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowAll_CellDoubleClick);
            this.dgvShowAll.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowAll_CellEndEdit);
            this.dgvShowAll.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvShowAll_CellEnter);
            this.dgvShowAll.EnabledChanged += new System.EventHandler(this.dgvShowAll_EnabledChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(585, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(153, 28);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 653);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvShowAll);
            this.Name = "Student";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowAll)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.DataGridView dgvShowAll;
        private System.Windows.Forms.Button btnRefresh;
    }
}

