namespace phone01
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.registerAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvWork = new System.Windows.Forms.DataGridView();
            this.lblDone = new System.Windows.Forms.Label();
            this.lblNo = new System.Windows.Forms.Label();
            this.lblShow = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.restoreDataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.insertToolStripMenuItem,
            this.insertToolStripMenuItem1,
            this.deleteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1134, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem,
            this.customerToolStripMenuItem});
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.showToolStripMenuItem.Text = "Show All";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.allToolStripMenuItem.Text = "Technical";
            this.allToolStripMenuItem.Click += new System.EventHandler(this.allToolStripMenuItem_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(155, 26);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem
            // 
            this.insertToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editDataToolStripMenuItem});
            this.insertToolStripMenuItem.Name = "insertToolStripMenuItem";
            this.insertToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.insertToolStripMenuItem.Text = "Edit";
            this.insertToolStripMenuItem.Click += new System.EventHandler(this.insertToolStripMenuItem_Click);
            // 
            // editDataToolStripMenuItem
            // 
            this.editDataToolStripMenuItem.Name = "editDataToolStripMenuItem";
            this.editDataToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.editDataToolStripMenuItem.Text = "Edit Regster";
            this.editDataToolStripMenuItem.Click += new System.EventHandler(this.editDataToolStripMenuItem_Click);
            // 
            // insertToolStripMenuItem1
            // 
            this.insertToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerAllToolStripMenuItem,
            this.exportDatabaseToolStripMenuItem,
            this.restoreDataBaseToolStripMenuItem});
            this.insertToolStripMenuItem1.Name = "insertToolStripMenuItem1";
            this.insertToolStripMenuItem1.Size = new System.Drawing.Size(59, 24);
            this.insertToolStripMenuItem1.Text = "Insert";
            // 
            // registerAllToolStripMenuItem
            // 
            this.registerAllToolStripMenuItem.Name = "registerAllToolStripMenuItem";
            this.registerAllToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registerAllToolStripMenuItem.Text = "Register All";
            this.registerAllToolStripMenuItem.Click += new System.EventHandler(this.registerAllToolStripMenuItem_Click);
            // 
            // exportDatabaseToolStripMenuItem
            // 
            this.exportDatabaseToolStripMenuItem.Name = "exportDatabaseToolStripMenuItem";
            this.exportDatabaseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportDatabaseToolStripMenuItem.Text = "Export Database";
            this.exportDatabaseToolStripMenuItem.Click += new System.EventHandler(this.exportDatabaseToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coustomerToolStripMenuItem,
            this.technicalToolStripMenuItem});
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(14, 24);
            // 
            // coustomerToolStripMenuItem
            // 
            this.coustomerToolStripMenuItem.Name = "coustomerToolStripMenuItem";
            this.coustomerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            // 
            // technicalToolStripMenuItem
            // 
            this.technicalToolStripMenuItem.Name = "technicalToolStripMenuItem";
            this.technicalToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.technicalToolStripMenuItem.Click += new System.EventHandler(this.technicalToolStripMenuItem_Click);
            // 
            // dgvWork
            // 
            this.dgvWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWork.Location = new System.Drawing.Point(52, 86);
            this.dgvWork.Name = "dgvWork";
            this.dgvWork.RowHeadersWidth = 51;
            this.dgvWork.RowTemplate.Height = 24;
            this.dgvWork.Size = new System.Drawing.Size(1069, 343);
            this.dgvWork.TabIndex = 1;
            this.dgvWork.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWork_CellContentClick);
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Location = new System.Drawing.Point(56, 45);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(42, 17);
            this.lblDone.TabIndex = 3;
            this.lblDone.Text = "Done";
            // 
            // lblNo
            // 
            this.lblNo.AutoSize = true;
            this.lblNo.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblNo.Location = new System.Drawing.Point(97, 45);
            this.lblNo.Name = "lblNo";
            this.lblNo.Size = new System.Drawing.Size(26, 17);
            this.lblNo.TabIndex = 4;
            this.lblNo.Text = "No";
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(123, 43);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(118, 17);
            this.lblShow.TabIndex = 5;
            this.lblShow.Text = "Are Now Showing";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1037, 31);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(84, 27);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // restoreDataBaseToolStripMenuItem
            // 
            this.restoreDataBaseToolStripMenuItem.Name = "restoreDataBaseToolStripMenuItem";
            this.restoreDataBaseToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.restoreDataBaseToolStripMenuItem.Text = "Restore DataBase";
            this.restoreDataBaseToolStripMenuItem.Click += new System.EventHandler(this.restoreDataBaseToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 450);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblShow);
            this.Controls.Add(this.lblNo);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.dgvWork);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWork)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvWork;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.ToolStripMenuItem editDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technicalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportDatabaseToolStripMenuItem;
        private System.Windows.Forms.Label lblNo;
        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ToolStripMenuItem restoreDataBaseToolStripMenuItem;
    }
}