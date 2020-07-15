namespace students
{
    partial class frmRegister
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtFathername = new System.Windows.Forms.TextBox();
            this.lblFathername = new System.Windows.Forms.Label();
            this.txtStudentsid = new System.Windows.Forms.TextBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.lblSection = new System.Windows.Forms.Label();
            this.lblDateofbirth = new System.Windows.Forms.Label();
            this.txtNationalid = new System.Windows.Forms.TextBox();
            this.lblNationalid = new System.Windows.Forms.Label();
            this.dtpDateofbirth = new System.Windows.Forms.DateTimePicker();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lblMajor = new System.Windows.Forms.Label();
            this.lbSection = new System.Windows.Forms.ListBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.lbMajor = new System.Windows.Forms.ListBox();
            this.lbUniversity = new System.Windows.Forms.Label();
            this.txtUniversity = new System.Windows.Forms.TextBox();
            this.lblStartdate = new System.Windows.Forms.Label();
            this.txtgmail = new System.Windows.Forms.TextBox();
            this.lblPhoneno = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.lblAdress = new System.Windows.Forms.Label();
            this.txtPhoneno = new System.Windows.Forms.TextBox();
            this.lblGmail = new System.Windows.Forms.Label();
            this.lbYear = new System.Windows.Forms.ListBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.dtpStartdate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(32, 29);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(73, 17);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(145, 24);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(285, 22);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtUsername_KeyDown);
            // 
            // txtFathername
            // 
            this.txtFathername.Location = new System.Drawing.Point(145, 83);
            this.txtFathername.Name = "txtFathername";
            this.txtFathername.Size = new System.Drawing.Size(285, 22);
            this.txtFathername.TabIndex = 3;
            this.txtFathername.TextChanged += new System.EventHandler(this.lblDateofbirth_Click);
            this.txtFathername.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFathername_KeyDown);
            // 
            // lblFathername
            // 
            this.lblFathername.AutoSize = true;
            this.lblFathername.Location = new System.Drawing.Point(32, 88);
            this.lblFathername.Name = "lblFathername";
            this.lblFathername.Size = new System.Drawing.Size(90, 17);
            this.lblFathername.TabIndex = 2;
            this.lblFathername.Text = "Father Name";
            this.lblFathername.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtStudentsid
            // 
            this.txtStudentsid.Location = new System.Drawing.Point(145, 138);
            this.txtStudentsid.Name = "txtStudentsid";
            this.txtStudentsid.Size = new System.Drawing.Size(285, 22);
            this.txtStudentsid.TabIndex = 5;
            this.txtStudentsid.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(32, 143);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(81, 17);
            this.lblStudentId.TabIndex = 4;
            this.lblStudentId.Text = "Students ID";
            this.lblStudentId.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblSection
            // 
            this.lblSection.AutoSize = true;
            this.lblSection.Location = new System.Drawing.Point(32, 302);
            this.lblSection.Name = "lblSection";
            this.lblSection.Size = new System.Drawing.Size(55, 17);
            this.lblSection.TabIndex = 10;
            this.lblSection.Text = "Section";
            this.lblSection.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblDateofbirth
            // 
            this.lblDateofbirth.AutoSize = true;
            this.lblDateofbirth.Location = new System.Drawing.Point(32, 261);
            this.lblDateofbirth.Name = "lblDateofbirth";
            this.lblDateofbirth.Size = new System.Drawing.Size(90, 17);
            this.lblDateofbirth.TabIndex = 8;
            this.lblDateofbirth.Text = "Date Of Birth";
            this.lblDateofbirth.Click += new System.EventHandler(this.lblDateofbirth_Click);
            // 
            // txtNationalid
            // 
            this.txtNationalid.Location = new System.Drawing.Point(145, 197);
            this.txtNationalid.Name = "txtNationalid";
            this.txtNationalid.Size = new System.Drawing.Size(285, 22);
            this.txtNationalid.TabIndex = 7;
            this.txtNationalid.Text = "14/";
            this.txtNationalid.TextChanged += new System.EventHandler(this.txtNationalid_TextChanged);
            // 
            // lblNationalid
            // 
            this.lblNationalid.AutoSize = true;
            this.lblNationalid.Location = new System.Drawing.Point(32, 202);
            this.lblNationalid.Name = "lblNationalid";
            this.lblNationalid.Size = new System.Drawing.Size(77, 17);
            this.lblNationalid.TabIndex = 6;
            this.lblNationalid.Text = "National ID";
            this.lblNationalid.Click += new System.EventHandler(this.lblNationalid_Click);
            // 
            // dtpDateofbirth
            // 
            this.dtpDateofbirth.Location = new System.Drawing.Point(153, 261);
            this.dtpDateofbirth.Name = "dtpDateofbirth";
            this.dtpDateofbirth.Size = new System.Drawing.Size(287, 22);
            this.dtpDateofbirth.TabIndex = 12;
            this.dtpDateofbirth.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblMajor
            // 
            this.lblMajor.AutoSize = true;
            this.lblMajor.Location = new System.Drawing.Point(32, 347);
            this.lblMajor.Name = "lblMajor";
            this.lblMajor.Size = new System.Drawing.Size(43, 17);
            this.lblMajor.TabIndex = 13;
            this.lblMajor.Text = "Major";
            // 
            // lbSection
            // 
            this.lbSection.FormattingEnabled = true;
            this.lbSection.ItemHeight = 16;
            this.lbSection.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.lbSection.Location = new System.Drawing.Point(153, 302);
            this.lbSection.Name = "lbSection";
            this.lbSection.Size = new System.Drawing.Size(286, 20);
            this.lbSection.TabIndex = 15;
            // 
            // lbMajor
            // 
            this.lbMajor.FormattingEnabled = true;
            this.lbMajor.ItemHeight = 16;
            this.lbMajor.Items.AddRange(new object[] {
            "Choose Major",
            "Myanmar",
            "English",
            "Mathematics",
            "Chemistry",
            "Physics",
            "Zoology"});
            this.lbMajor.Location = new System.Drawing.Point(155, 344);
            this.lbMajor.Name = "lbMajor";
            this.lbMajor.Size = new System.Drawing.Size(286, 20);
            this.lbMajor.TabIndex = 16;
            // 
            // lbUniversity
            // 
            this.lbUniversity.AutoSize = true;
            this.lbUniversity.Location = new System.Drawing.Point(32, 472);
            this.lbUniversity.Name = "lbUniversity";
            this.lbUniversity.Size = new System.Drawing.Size(70, 17);
            this.lbUniversity.TabIndex = 17;
            this.lbUniversity.Text = "University";
            this.lbUniversity.Click += new System.EventHandler(this.lbUniversity_Click);
            // 
            // txtUniversity
            // 
            this.txtUniversity.Location = new System.Drawing.Point(156, 469);
            this.txtUniversity.Name = "txtUniversity";
            this.txtUniversity.Size = new System.Drawing.Size(285, 22);
            this.txtUniversity.TabIndex = 18;
            this.txtUniversity.TextChanged += new System.EventHandler(this.txtUniversity_TextChanged);
            // 
            // lblStartdate
            // 
            this.lblStartdate.AutoSize = true;
            this.lblStartdate.Location = new System.Drawing.Point(32, 383);
            this.lblStartdate.Name = "lblStartdate";
            this.lblStartdate.Size = new System.Drawing.Size(72, 17);
            this.lblStartdate.TabIndex = 19;
            this.lblStartdate.Text = "Start Date";
            this.lblStartdate.Click += new System.EventHandler(this.lblStartdate_Click);
            // 
            // txtgmail
            // 
            this.txtgmail.Location = new System.Drawing.Point(158, 545);
            this.txtgmail.Name = "txtgmail";
            this.txtgmail.Size = new System.Drawing.Size(284, 22);
            this.txtgmail.TabIndex = 22;
            this.txtgmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblPhoneno
            // 
            this.lblPhoneno.AutoSize = true;
            this.lblPhoneno.Location = new System.Drawing.Point(32, 512);
            this.lblPhoneno.Name = "lblPhoneno";
            this.lblPhoneno.Size = new System.Drawing.Size(103, 17);
            this.lblPhoneno.TabIndex = 21;
            this.lblPhoneno.Text = "Phone Number";
            this.lblPhoneno.Click += new System.EventHandler(this.lblPhoneno_Click);
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(159, 583);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.Size = new System.Drawing.Size(285, 22);
            this.txtAdress.TabIndex = 26;
            this.txtAdress.TextChanged += new System.EventHandler(this.textBox1_TextChanged_3);
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(32, 583);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(52, 17);
            this.lblAdress.TabIndex = 25;
            this.lblAdress.Text = "Adress";
            this.lblAdress.Click += new System.EventHandler(this.lblAdress_Click);
            // 
            // txtPhoneno
            // 
            this.txtPhoneno.Location = new System.Drawing.Point(157, 507);
            this.txtPhoneno.Name = "txtPhoneno";
            this.txtPhoneno.Size = new System.Drawing.Size(282, 22);
            this.txtPhoneno.TabIndex = 24;
            this.txtPhoneno.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblGmail
            // 
            this.lblGmail.AutoSize = true;
            this.lblGmail.Location = new System.Drawing.Point(32, 545);
            this.lblGmail.Name = "lblGmail";
            this.lblGmail.Size = new System.Drawing.Size(44, 17);
            this.lblGmail.TabIndex = 23;
            this.lblGmail.Text = "Gmail";
            this.lblGmail.Click += new System.EventHandler(this.lblGmail_Click);
            // 
            // lbYear
            // 
            this.lbYear.FormattingEnabled = true;
            this.lbYear.ItemHeight = 16;
            this.lbYear.Items.AddRange(new object[] {
            "Choose Your Educate",
            "First Year",
            "Second Year",
            "Third Year",
            "Fourth Year"});
            this.lbYear.Location = new System.Drawing.Point(158, 427);
            this.lbYear.Name = "lbYear";
            this.lbYear.Size = new System.Drawing.Size(286, 20);
            this.lbYear.TabIndex = 28;
            this.lbYear.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(32, 418);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(38, 17);
            this.lblYear.TabIndex = 27;
            this.lblYear.Text = "Year";
            this.lblYear.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(146, 654);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 41);
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(325, 654);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 41);
            this.btnOk.TabIndex = 31;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // dtpStartdate
            // 
            this.dtpStartdate.Location = new System.Drawing.Point(156, 383);
            this.dtpStartdate.Name = "dtpStartdate";
            this.dtpStartdate.Size = new System.Drawing.Size(287, 22);
            this.dtpStartdate.TabIndex = 32;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 707);
            this.Controls.Add(this.dtpStartdate);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtAdress);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.txtPhoneno);
            this.Controls.Add(this.lblGmail);
            this.Controls.Add(this.txtgmail);
            this.Controls.Add(this.lblPhoneno);
            this.Controls.Add(this.lblStartdate);
            this.Controls.Add(this.txtUniversity);
            this.Controls.Add(this.lbUniversity);
            this.Controls.Add(this.lbMajor);
            this.Controls.Add(this.lbSection);
            this.Controls.Add(this.lblMajor);
            this.Controls.Add(this.dtpDateofbirth);
            this.Controls.Add(this.lblSection);
            this.Controls.Add(this.lblDateofbirth);
            this.Controls.Add(this.txtNationalid);
            this.Controls.Add(this.lblNationalid);
            this.Controls.Add(this.txtStudentsid);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.txtFathername);
            this.Controls.Add(this.lblFathername);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUsername);
            this.Name = "frmRegister";
            this.Text = "Students Register";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtFathername;
        private System.Windows.Forms.Label lblFathername;
        private System.Windows.Forms.TextBox txtStudentsid;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.Label lblSection;
        private System.Windows.Forms.Label lblDateofbirth;
        private System.Windows.Forms.TextBox txtNationalid;
        private System.Windows.Forms.Label lblNationalid;
        private System.Windows.Forms.DateTimePicker dtpDateofbirth;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lblMajor;
        private System.Windows.Forms.ListBox lbSection;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ListBox lbMajor;
        private System.Windows.Forms.Label lbUniversity;
        private System.Windows.Forms.TextBox txtUniversity;
        private System.Windows.Forms.Label lblStartdate;
        private System.Windows.Forms.TextBox txtgmail;
        private System.Windows.Forms.Label lblPhoneno;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox txtPhoneno;
        private System.Windows.Forms.Label lblGmail;
        private System.Windows.Forms.ListBox lbYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.DateTimePicker dtpStartdate;
    }
}

