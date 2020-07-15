namespace L_Khant_000
{
    partial class frmOreder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOreder));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.cboCity = new System.Windows.Forms.ComboBox();
            this.txtCustomer = new System.Windows.Forms.TextBox();
            this.txtProduct = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.brnInsert = new System.Windows.Forms.Button();
            this.dgvOreder = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cboSearch = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ရငရစရငToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ရငရစရငToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moneyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOreder)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 431);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Product";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 36);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customer";
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(252, 96);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(491, 41);
            this.dtpDate.TabIndex = 4;
            // 
            // cboCity
            // 
            this.cboCity.FormattingEnabled = true;
            this.cboCity.Items.AddRange(new object[] {
            "pathein",
            "ngwe_saung",
            "chaung_tha"});
            this.cboCity.Location = new System.Drawing.Point(252, 332);
            this.cboCity.Name = "cboCity";
            this.cboCity.Size = new System.Drawing.Size(490, 44);
            this.cboCity.TabIndex = 5;
            // 
            // txtCustomer
            // 
            this.txtCustomer.Location = new System.Drawing.Point(252, 220);
            this.txtCustomer.Name = "txtCustomer";
            this.txtCustomer.Size = new System.Drawing.Size(490, 41);
            this.txtCustomer.TabIndex = 6;
            // 
            // txtProduct
            // 
            this.txtProduct.Location = new System.Drawing.Point(253, 431);
            this.txtProduct.Name = "txtProduct";
            this.txtProduct.Size = new System.Drawing.Size(490, 41);
            this.txtProduct.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(57, 548);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 61);
            this.button1.TabIndex = 8;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // brnInsert
            // 
            this.brnInsert.Location = new System.Drawing.Point(488, 551);
            this.brnInsert.Name = "brnInsert";
            this.brnInsert.Size = new System.Drawing.Size(254, 58);
            this.brnInsert.TabIndex = 12;
            this.brnInsert.Text = "Insert(PreOreder)";
            this.brnInsert.UseVisualStyleBackColor = true;
            this.brnInsert.Click += new System.EventHandler(this.brnInsert_Click);
            // 
            // dgvOreder
            // 
            this.dgvOreder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOreder.Location = new System.Drawing.Point(910, 178);
            this.dgvOreder.Name = "dgvOreder";
            this.dgvOreder.RowHeadersWidth = 51;
            this.dgvOreder.RowTemplate.Height = 24;
            this.dgvOreder.Size = new System.Drawing.Size(560, 289);
            this.dgvOreder.TabIndex = 13;
            this.dgvOreder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOreder_CellClick);
            this.dgvOreder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOreder_CellContentClick);
            this.dgvOreder.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOreder_RowValidated);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(910, 552);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 58);
            this.button2.TabIndex = 15;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(1309, 552);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(161, 57);
            this.button4.TabIndex = 22;
            this.button4.Text = "Delete";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cboSearch
            // 
            this.cboSearch.FormattingEnabled = true;
            this.cboSearch.Items.AddRange(new object[] {
            "no",
            "oreder_date",
            "customer",
            "city",
            "product"});
            this.cboSearch.Location = new System.Drawing.Point(910, 96);
            this.cboSearch.Name = "cboSearch";
            this.cboSearch.Size = new System.Drawing.Size(178, 44);
            this.cboSearch.TabIndex = 23;
            this.cboSearch.Text = "Search By";
            this.cboSearch.SelectedIndexChanged += new System.EventHandler(this.cboSearch_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1107, 97);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(187, 41);
            this.txtSearch.TabIndex = 24;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1309, 97);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(161, 46);
            this.btnSearch.TabIndex = 25;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Zawgyi-One", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ရငရစရငToolStripMenuItem,
            this.productsCodeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1700, 40);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // ရငရစရငToolStripMenuItem
            // 
            this.ရငရစရငToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ရငရစရငToolStripMenuItem1,
            this.productsToolStripMenuItem,
            this.customersToolStripMenuItem,
            this.orderToolStripMenuItem});
            this.ရငရစရငToolStripMenuItem.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ရငရစရငToolStripMenuItem.Name = "ရငရစရငToolStripMenuItem";
            this.ရငရစရငToolStripMenuItem.Size = new System.Drawing.Size(68, 36);
            this.ရငရစရငToolStripMenuItem.Text = "Lists";
            // 
            // ရငရစရငToolStripMenuItem1
            // 
            this.ရငရစရငToolStripMenuItem1.Font = new System.Drawing.Font("Adobe Caslon Pro", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ရငရစရငToolStripMenuItem1.Name = "ရငရစရငToolStripMenuItem1";
            this.ရငရစရငToolStripMenuItem1.Size = new System.Drawing.Size(204, 36);
            this.ရငရစရငToolStripMenuItem1.Text = "ရောင်းရစာရင်း";
            this.ရငရစရငToolStripMenuItem1.Click += new System.EventHandler(this.ရငရစရငToolStripMenuItem1_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(204, 36);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Font = new System.Drawing.Font("Adobe Caslon Pro Bold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(204, 36);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(204, 36);
            this.orderToolStripMenuItem.Text = "Order";
            this.orderToolStripMenuItem.Click += new System.EventHandler(this.orderToolStripMenuItem_Click);
            // 
            // productsCodeToolStripMenuItem
            // 
            this.productsCodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codeToolStripMenuItem,
            this.moneyToolStripMenuItem});
            this.productsCodeToolStripMenuItem.Font = new System.Drawing.Font("Zawgyi-One", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsCodeToolStripMenuItem.Name = "productsCodeToolStripMenuItem";
            this.productsCodeToolStripMenuItem.Size = new System.Drawing.Size(105, 36);
            this.productsCodeToolStripMenuItem.Text = "Products";
            // 
            // codeToolStripMenuItem
            // 
            this.codeToolStripMenuItem.Name = "codeToolStripMenuItem";
            this.codeToolStripMenuItem.Size = new System.Drawing.Size(173, 36);
            this.codeToolStripMenuItem.Text = "Code";
            this.codeToolStripMenuItem.Click += new System.EventHandler(this.codeToolStripMenuItem_Click);
            // 
            // moneyToolStripMenuItem
            // 
            this.moneyToolStripMenuItem.Name = "moneyToolStripMenuItem";
            this.moneyToolStripMenuItem.Size = new System.Drawing.Size(173, 36);
            this.moneyToolStripMenuItem.Text = "Original";
            this.moneyToolStripMenuItem.Click += new System.EventHandler(this.moneyToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1090, 548);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(172, 120);
            this.button3.TabIndex = 27;
            this.button3.Text = "print";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // frmOreder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1700, 1012);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cboSearch);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvOreder);
            this.Controls.Add(this.brnInsert);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtProduct);
            this.Controls.Add(this.txtCustomer);
            this.Controls.Add(this.cboCity);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "frmOreder";
            this.Text = "Oreder";
            this.Load += new System.EventHandler(this.frmOreder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOreder)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.ComboBox cboCity;
        private System.Windows.Forms.TextBox txtCustomer;
        private System.Windows.Forms.TextBox txtProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button brnInsert;
        private System.Windows.Forms.DataGridView dgvOreder;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cboSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ရငရစရငToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ရငရစရငToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsCodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moneyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}