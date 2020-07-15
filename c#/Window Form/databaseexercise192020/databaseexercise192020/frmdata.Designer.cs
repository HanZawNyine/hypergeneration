namespace databaseexercise192020
{
    partial class frmdatainsert
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
            this.lbusername = new System.Windows.Forms.Label();
            this.txtusrname = new System.Windows.Forms.TextBox();
            this.txtFathername = new System.Windows.Forms.TextBox();
            this.lbFathername = new System.Windows.Forms.Label();
            this.lbDateofbirth = new System.Windows.Forms.Label();
            this.txtStudentid = new System.Windows.Forms.TextBox();
            this.lbStudentid = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtphonenumber = new System.Windows.Forms.TextBox();
            this.lbphonenumber = new System.Windows.Forms.Label();
            this.dtpDateofbirth = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Location = new System.Drawing.Point(15, 62);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(73, 17);
            this.lbusername.TabIndex = 0;
            this.lbusername.Text = "Username";
            // 
            // txtusrname
            // 
            this.txtusrname.Location = new System.Drawing.Point(141, 59);
            this.txtusrname.Name = "txtusrname";
            this.txtusrname.Size = new System.Drawing.Size(292, 22);
            this.txtusrname.TabIndex = 1;
            // 
            // txtFathername
            // 
            this.txtFathername.Location = new System.Drawing.Point(141, 144);
            this.txtFathername.Name = "txtFathername";
            this.txtFathername.Size = new System.Drawing.Size(292, 22);
            this.txtFathername.TabIndex = 3;
            // 
            // lbFathername
            // 
            this.lbFathername.AutoSize = true;
            this.lbFathername.Location = new System.Drawing.Point(15, 147);
            this.lbFathername.Name = "lbFathername";
            this.lbFathername.Size = new System.Drawing.Size(90, 17);
            this.lbFathername.TabIndex = 2;
            this.lbFathername.Text = "Father Name";
            // 
            // lbDateofbirth
            // 
            this.lbDateofbirth.AutoSize = true;
            this.lbDateofbirth.Location = new System.Drawing.Point(15, 239);
            this.lbDateofbirth.Name = "lbDateofbirth";
            this.lbDateofbirth.Size = new System.Drawing.Size(90, 17);
            this.lbDateofbirth.TabIndex = 4;
            this.lbDateofbirth.Text = "Dtae Of Birth";
            // 
            // txtStudentid
            // 
            this.txtStudentid.Location = new System.Drawing.Point(141, 327);
            this.txtStudentid.Name = "txtStudentid";
            this.txtStudentid.Size = new System.Drawing.Size(292, 22);
            this.txtStudentid.TabIndex = 7;
            // 
            // lbStudentid
            // 
            this.lbStudentid.AutoSize = true;
            this.lbStudentid.Location = new System.Drawing.Point(15, 330);
            this.lbStudentid.Name = "lbStudentid";
            this.lbStudentid.Size = new System.Drawing.Size(74, 17);
            this.lbStudentid.TabIndex = 6;
            this.lbStudentid.Text = "Student ID";
            // 
            // btncancel
            // 
            this.btncancel.Location = new System.Drawing.Point(141, 437);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(113, 44);
            this.btncancel.TabIndex = 8;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(320, 437);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(113, 44);
            this.btnInsert.TabIndex = 9;
            this.btnInsert.Text = "insert";
            this.btnInsert.UseVisualStyleBackColor = true;
           
            // 
            // txtphonenumber
            // 
            this.txtphonenumber.Location = new System.Drawing.Point(141, 390);
            this.txtphonenumber.Name = "txtphonenumber";
            this.txtphonenumber.Size = new System.Drawing.Size(292, 22);
            this.txtphonenumber.TabIndex = 11;
            // 
            // lbphonenumber
            // 
            this.lbphonenumber.AutoSize = true;
            this.lbphonenumber.Location = new System.Drawing.Point(15, 393);
            this.lbphonenumber.Name = "lbphonenumber";
            this.lbphonenumber.Size = new System.Drawing.Size(103, 17);
            this.lbphonenumber.TabIndex = 10;
            this.lbphonenumber.Text = "Phone Number";
            // 
            // dtpDateofbirth
            // 
            this.dtpDateofbirth.Location = new System.Drawing.Point(149, 236);
            this.dtpDateofbirth.Name = "dtpDateofbirth";
            this.dtpDateofbirth.Size = new System.Drawing.Size(283, 22);
            this.dtpDateofbirth.TabIndex = 12;
            // 
            // frmdatainsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 497);
            this.Controls.Add(this.dtpDateofbirth);
            this.Controls.Add(this.txtphonenumber);
            this.Controls.Add(this.lbphonenumber);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtStudentid);
            this.Controls.Add(this.lbStudentid);
            this.Controls.Add(this.lbDateofbirth);
            this.Controls.Add(this.txtFathername);
            this.Controls.Add(this.lbFathername);
            this.Controls.Add(this.txtusrname);
            this.Controls.Add(this.lbusername);
            this.Name = "frmdatainsert";
            this.Text = "Add Your Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.TextBox txtusrname;
        private System.Windows.Forms.TextBox txtFathername;
        private System.Windows.Forms.Label lbFathername;
        private System.Windows.Forms.Label lbDateofbirth;
        private System.Windows.Forms.TextBox txtStudentid;
        private System.Windows.Forms.Label lbStudentid;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtphonenumber;
        private System.Windows.Forms.Label lbphonenumber;
        private System.Windows.Forms.DateTimePicker dtpDateofbirth;
    }
}

