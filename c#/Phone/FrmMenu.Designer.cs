namespace Phone
{
    partial class FrmMenu
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
            this.fILEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllCustomersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.technicalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.insertErrorCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewErrorCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvTechnical = new System.Windows.Forms.DataGridView();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnical)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fILEToolStripMenuItem,
            this.technicalToolStripMenuItem,
            this.errorToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(986, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fILEToolStripMenuItem
            // 
            this.fILEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerToolStripMenuItem,
            this.errorToolStripMenuItem,
            this.showAllCustomersToolStripMenuItem});
            this.fILEToolStripMenuItem.Name = "fILEToolStripMenuItem";
            this.fILEToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.fILEToolStripMenuItem.Text = "Customer";
            // 
            // registerToolStripMenuItem
            // 
            this.registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            this.registerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.registerToolStripMenuItem.Text = "Register";
            this.registerToolStripMenuItem.Click += new System.EventHandler(this.registerToolStripMenuItem_Click);
            // 
            // errorToolStripMenuItem
            // 
            this.errorToolStripMenuItem.Name = "errorToolStripMenuItem";
            this.errorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.errorToolStripMenuItem.Text = "Information";
            this.errorToolStripMenuItem.Click += new System.EventHandler(this.errorToolStripMenuItem_Click);
            // 
            // showAllCustomersToolStripMenuItem
            // 
            this.showAllCustomersToolStripMenuItem.Name = "showAllCustomersToolStripMenuItem";
            this.showAllCustomersToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.showAllCustomersToolStripMenuItem.Text = "Show All Customers";
            // 
            // technicalToolStripMenuItem
            // 
            this.technicalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.informationToolStripMenuItem});
            this.technicalToolStripMenuItem.Name = "technicalToolStripMenuItem";
            this.technicalToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.technicalToolStripMenuItem.Text = "Technical";
            // 
            // informationToolStripMenuItem
            // 
            this.informationToolStripMenuItem.Name = "informationToolStripMenuItem";
            this.informationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.informationToolStripMenuItem.Text = "information";
            // 
            // errorToolStripMenuItem1
            // 
            this.errorToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertErrorCodeToolStripMenuItem,
            this.viewErrorCodeToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.errorToolStripMenuItem1.Name = "errorToolStripMenuItem1";
            this.errorToolStripMenuItem1.Size = new System.Drawing.Size(55, 24);
            this.errorToolStripMenuItem1.Text = "Error";
            // 
            // insertErrorCodeToolStripMenuItem
            // 
            this.insertErrorCodeToolStripMenuItem.Name = "insertErrorCodeToolStripMenuItem";
            this.insertErrorCodeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.insertErrorCodeToolStripMenuItem.Text = "insert Error Code";
            // 
            // viewErrorCodeToolStripMenuItem
            // 
            this.viewErrorCodeToolStripMenuItem.Name = "viewErrorCodeToolStripMenuItem";
            this.viewErrorCodeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.viewErrorCodeToolStripMenuItem.Text = "view Error Code";
            // 
            // dgvTechnical
            // 
            this.dgvTechnical.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTechnical.Location = new System.Drawing.Point(0, 119);
            this.dgvTechnical.Name = "dgvTechnical";
            this.dgvTechnical.RowHeadersWidth = 51;
            this.dgvTechnical.RowTemplate.Height = 24;
            this.dgvTechnical.Size = new System.Drawing.Size(985, 443);
            this.dgvTechnical.TabIndex = 1;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 566);
            this.Controls.Add(this.dgvTechnical);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMenu";
            this.Text = "Menu Box";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTechnical)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fILEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllCustomersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem technicalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem insertErrorCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewErrorCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvTechnical;
    }
}