namespace Han_Zaw_Nyine
{
    partial class frmAll
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
            this.lblId = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFather = new System.Windows.Forms.TextBox();
            this.lblFather = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblMoblie = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lbID = new System.Windows.Forms.ListBox();
            this.lbName = new System.Windows.Forms.ListBox();
            this.lbFather = new System.Windows.Forms.ListBox();
            this.lbMobile = new System.Windows.Forms.ListBox();
            this.lbDate = new System.Windows.Forms.ListBox();
            this.lbGender = new System.Windows.Forms.ListBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(23, 16);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(21, 17);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(142, 68);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(246, 22);
            this.txtName.TabIndex = 3;
            this.txtName.Text = "Han Zaw Nyine";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(23, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Name";
            // 
            // txtFather
            // 
            this.txtFather.Location = new System.Drawing.Point(142, 140);
            this.txtFather.Name = "txtFather";
            this.txtFather.Size = new System.Drawing.Size(246, 22);
            this.txtFather.TabIndex = 5;
            this.txtFather.Text = "U Han";
            this.txtFather.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFather
            // 
            this.lblFather.AutoSize = true;
            this.lblFather.Location = new System.Drawing.Point(23, 145);
            this.lblFather.Name = "lblFather";
            this.lblFather.Size = new System.Drawing.Size(49, 17);
            this.lblFather.TabIndex = 4;
            this.lblFather.Text = "Father";
            this.lblFather.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(142, 206);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(246, 22);
            this.txtMobile.TabIndex = 7;
            this.txtMobile.Text = "09448450841";
            // 
            // lblMoblie
            // 
            this.lblMoblie.AutoSize = true;
            this.lblMoblie.Location = new System.Drawing.Point(23, 211);
            this.lblMoblie.Name = "lblMoblie";
            this.lblMoblie.Size = new System.Drawing.Size(49, 17);
            this.lblMoblie.TabIndex = 6;
            this.lblMoblie.Text = "Mobile";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(23, 268);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 8;
            this.lblDate.Text = "Date";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(23, 329);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(56, 17);
            this.lblGender.TabIndex = 10;
            this.lblGender.Text = "Gender";
            // 
            // cboGender
            // 
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Both"});
            this.cboGender.Location = new System.Drawing.Point(137, 329);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(246, 24);
            this.cboGender.TabIndex = 11;
            this.cboGender.Text = "Male";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(144, 271);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(246, 22);
            this.dtp.TabIndex = 12;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(142, 11);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(246, 22);
            this.txtId.TabIndex = 1;
            // 
            // lbID
            // 
            this.lbID.FormattingEnabled = true;
            this.lbID.ItemHeight = 16;
            this.lbID.Location = new System.Drawing.Point(405, 16);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(48, 324);
            this.lbID.TabIndex = 13;
            this.lbID.SelectedIndexChanged += new System.EventHandler(this.lbID_SelectedIndexChanged);
            // 
            // lbName
            // 
            this.lbName.FormattingEnabled = true;
            this.lbName.ItemHeight = 16;
            this.lbName.Location = new System.Drawing.Point(460, 16);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(127, 324);
            this.lbName.TabIndex = 14;
            this.lbName.SelectedIndexChanged += new System.EventHandler(this.lbID_SelectedIndexChanged);
            // 
            // lbFather
            // 
            this.lbFather.FormattingEnabled = true;
            this.lbFather.ItemHeight = 16;
            this.lbFather.Location = new System.Drawing.Point(593, 16);
            this.lbFather.Name = "lbFather";
            this.lbFather.Size = new System.Drawing.Size(128, 324);
            this.lbFather.TabIndex = 15;
            this.lbFather.SelectedIndexChanged += new System.EventHandler(this.lbID_SelectedIndexChanged);
            // 
            // lbMobile
            // 
            this.lbMobile.FormattingEnabled = true;
            this.lbMobile.ItemHeight = 16;
            this.lbMobile.Location = new System.Drawing.Point(727, 16);
            this.lbMobile.Name = "lbMobile";
            this.lbMobile.Size = new System.Drawing.Size(144, 324);
            this.lbMobile.TabIndex = 16;
            this.lbMobile.SelectedIndexChanged += new System.EventHandler(this.lbID_SelectedIndexChanged);
            // 
            // lbDate
            // 
            this.lbDate.FormattingEnabled = true;
            this.lbDate.ItemHeight = 16;
            this.lbDate.Location = new System.Drawing.Point(874, 16);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(179, 324);
            this.lbDate.TabIndex = 17;
            this.lbDate.SelectedIndexChanged += new System.EventHandler(this.lbID_SelectedIndexChanged);
            // 
            // lbGender
            // 
            this.lbGender.FormattingEnabled = true;
            this.lbGender.ItemHeight = 16;
            this.lbGender.Location = new System.Drawing.Point(1059, 15);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(61, 324);
            this.lbGender.TabIndex = 18;
            this.lbGender.SelectedIndexChanged += new System.EventHandler(this.lbID_SelectedIndexChanged);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(18, 378);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(108, 27);
            this.btnInsert.TabIndex = 19;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(142, 378);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(108, 27);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(387, 378);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(108, 27);
            this.btnView.TabIndex = 22;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(260, 378);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(108, 27);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lbGender);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbMobile);
            this.Controls.Add(this.lbFather);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.lblMoblie);
            this.Controls.Add(this.txtFather);
            this.Controls.Add(this.lblFather);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.Name = "frmAll";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.frmAll_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtFather;
        private System.Windows.Forms.Label lblFather;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblMoblie;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.ListBox lbID;
        private System.Windows.Forms.ListBox lbName;
        private System.Windows.Forms.ListBox lbFather;
        private System.Windows.Forms.ListBox lbMobile;
        private System.Windows.Forms.ListBox lbDate;
        private System.Windows.Forms.ListBox lbGender;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
    }
}

