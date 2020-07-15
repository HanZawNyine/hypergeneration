namespace phone01
{
    partial class frmTechnicalfrm
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnical)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTechnical
            // 
            this.dgvTechnical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechnical.Location = new System.Drawing.Point(2, 12);
            this.dgvTechnical.Name = "dgvTechnical";
            this.dgvTechnical.RowHeadersWidth = 51;
            this.dgvTechnical.RowTemplate.Height = 24;
            this.dgvTechnical.Size = new System.Drawing.Size(1123, 403);
            this.dgvTechnical.TabIndex = 0;
            this.dgvTechnical.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTechnical_CellContentClick);
            // 
            // frmTechnicalfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 450);
            this.Controls.Add(this.dgvTechnical);
            this.Name = "frmTechnicalfrm";
            this.Text = "frmTechnical";
            this.Load += new System.EventHandler(this.frmTechnical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnical)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTechnical;
    }
}