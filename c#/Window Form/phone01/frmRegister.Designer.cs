namespace phone01
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
            this.lblCustomer = new System.Windows.Forms.Label();
            this.txtCoustomerName = new System.Windows.Forms.TextBox();
            this.lblPhoneNo = new System.Windows.Forms.Label();
            this.txtPHoneNo = new System.Windows.Forms.TextBox();
            this.lblSdCard = new System.Windows.Forms.Label();
            this.cboSdCard = new System.Windows.Forms.ComboBox();
            this.cboSimCard = new System.Windows.Forms.ComboBox();
            this.lblSimCard = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.llblEndDate = new System.Windows.Forms.Label();
            this.lblCoustomerID = new System.Windows.Forms.Label();
            this.lblTechnicalName = new System.Windows.Forms.Label();
            this.txtTechnicalName = new System.Windows.Forms.TextBox();
            this.txtError = new System.Windows.Forms.TextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblDone = new System.Windows.Forms.Label();
            this.cboDone = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(25, 145);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(109, 17);
            this.lblCustomer.TabIndex = 0;
            this.lblCustomer.Text = "Customer Name";
            // 
            // txtCoustomerName
            // 
            this.txtCoustomerName.Location = new System.Drawing.Point(176, 142);
            this.txtCoustomerName.Name = "txtCoustomerName";
            this.txtCoustomerName.Size = new System.Drawing.Size(414, 22);
            this.txtCoustomerName.TabIndex = 1;
            // 
            // lblPhoneNo
            // 
            this.lblPhoneNo.AutoSize = true;
            this.lblPhoneNo.Location = new System.Drawing.Point(27, 194);
            this.lblPhoneNo.Name = "lblPhoneNo";
            this.lblPhoneNo.Size = new System.Drawing.Size(103, 17);
            this.lblPhoneNo.TabIndex = 2;
            this.lblPhoneNo.Text = "Phone Number";
            // 
            // txtPHoneNo
            // 
            this.txtPHoneNo.Location = new System.Drawing.Point(176, 194);
            this.txtPHoneNo.Name = "txtPHoneNo";
            this.txtPHoneNo.Size = new System.Drawing.Size(414, 22);
            this.txtPHoneNo.TabIndex = 3;
            // 
            // lblSdCard
            // 
            this.lblSdCard.AutoSize = true;
            this.lblSdCard.Location = new System.Drawing.Point(27, 329);
            this.lblSdCard.Name = "lblSdCard";
            this.lblSdCard.Size = new System.Drawing.Size(61, 17);
            this.lblSdCard.TabIndex = 4;
            this.lblSdCard.Text = "SD Card";
            this.lblSdCard.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboSdCard
            // 
            this.cboSdCard.FormattingEnabled = true;
            this.cboSdCard.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.cboSdCard.Location = new System.Drawing.Point(175, 322);
            this.cboSdCard.Name = "cboSdCard";
            this.cboSdCard.Size = new System.Drawing.Size(414, 24);
            this.cboSdCard.TabIndex = 5;
            // 
            // cboSimCard
            // 
            this.cboSimCard.FormattingEnabled = true;
            this.cboSimCard.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.cboSimCard.Location = new System.Drawing.Point(174, 256);
            this.cboSimCard.Name = "cboSimCard";
            this.cboSimCard.Size = new System.Drawing.Size(414, 24);
            this.cboSimCard.TabIndex = 7;
            // 
            // lblSimCard
            // 
            this.lblSimCard.AutoSize = true;
            this.lblSimCard.Location = new System.Drawing.Point(26, 263);
            this.lblSimCard.Name = "lblSimCard";
            this.lblSimCard.Size = new System.Drawing.Size(65, 17);
            this.lblSimCard.TabIndex = 6;
            this.lblSimCard.Text = "Sim Card";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(27, 401);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 17);
            this.lblPassword.TabIndex = 8;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(178, 394);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(414, 22);
            this.txtPassword.TabIndex = 9;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(185, 465);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(414, 22);
            this.txtAmount.TabIndex = 11;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(34, 472);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(56, 17);
            this.lblAmount.TabIndex = 10;
            this.lblAmount.Text = "Amount";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(616, 36);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(72, 17);
            this.lblStartDate.TabIndex = 12;
            this.lblStartDate.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(767, 31);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(414, 22);
            this.dtpStartDate.TabIndex = 13;
            this.dtpStartDate.ValueChanged += new System.EventHandler(this.dtpStartDate_ValueChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(764, 100);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(414, 22);
            this.dtpEndDate.TabIndex = 15;
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // llblEndDate
            // 
            this.llblEndDate.AutoSize = true;
            this.llblEndDate.Location = new System.Drawing.Point(613, 105);
            this.llblEndDate.Name = "llblEndDate";
            this.llblEndDate.Size = new System.Drawing.Size(67, 17);
            this.llblEndDate.TabIndex = 14;
            this.llblEndDate.Text = "End Date";
            // 
            // lblCoustomerID
            // 
            this.lblCoustomerID.AutoSize = true;
            this.lblCoustomerID.Location = new System.Drawing.Point(27, 31);
            this.lblCoustomerID.Name = "lblCoustomerID";
            this.lblCoustomerID.Size = new System.Drawing.Size(93, 17);
            this.lblCoustomerID.TabIndex = 16;
            this.lblCoustomerID.Text = "Coustomer ID";
            this.lblCoustomerID.Click += new System.EventHandler(this.lblCoustomerID_Click);
            // 
            // lblTechnicalName
            // 
            this.lblTechnicalName.AutoSize = true;
            this.lblTechnicalName.Location = new System.Drawing.Point(621, 179);
            this.lblTechnicalName.Name = "lblTechnicalName";
            this.lblTechnicalName.Size = new System.Drawing.Size(110, 17);
            this.lblTechnicalName.TabIndex = 17;
            this.lblTechnicalName.Text = "Technical Name";
            // 
            // txtTechnicalName
            // 
            this.txtTechnicalName.Location = new System.Drawing.Point(761, 176);
            this.txtTechnicalName.Name = "txtTechnicalName";
            this.txtTechnicalName.Size = new System.Drawing.Size(414, 22);
            this.txtTechnicalName.TabIndex = 18;
            // 
            // txtError
            // 
            this.txtError.Location = new System.Drawing.Point(761, 232);
            this.txtError.Name = "txtError";
            this.txtError.Size = new System.Drawing.Size(414, 22);
            this.txtError.TabIndex = 20;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(621, 235);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(40, 17);
            this.lblError.TabIndex = 19;
            this.lblError.Text = "Error";
            // 
            // lblDone
            // 
            this.lblDone.AutoSize = true;
            this.lblDone.Location = new System.Drawing.Point(626, 301);
            this.lblDone.Name = "lblDone";
            this.lblDone.Size = new System.Drawing.Size(42, 17);
            this.lblDone.TabIndex = 21;
            this.lblDone.Text = "Done";
            // 
            // cboDone
            // 
            this.cboDone.FormattingEnabled = true;
            this.cboDone.Items.AddRange(new object[] {
            "yes",
            "no"});
            this.cboDone.Location = new System.Drawing.Point(760, 300);
            this.cboDone.Name = "cboDone";
            this.cboDone.Size = new System.Drawing.Size(414, 24);
            this.cboDone.TabIndex = 22;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(760, 362);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(175, 45);
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(951, 362);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(160, 45);
            this.btnInsert.TabIndex = 24;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(174, 33);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(414, 22);
            this.txtCustomerId.TabIndex = 26;
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(174, 82);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(414, 22);
            this.txtOrderID.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Order ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 556);
            this.Controls.Add(this.txtOrderID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCustomerId);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cboDone);
            this.Controls.Add(this.lblDone);
            this.Controls.Add(this.txtError);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtTechnicalName);
            this.Controls.Add(this.lblTechnicalName);
            this.Controls.Add(this.lblCoustomerID);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.llblEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.cboSimCard);
            this.Controls.Add(this.lblSimCard);
            this.Controls.Add(this.cboSdCard);
            this.Controls.Add(this.lblSdCard);
            this.Controls.Add(this.txtPHoneNo);
            this.Controls.Add(this.lblPhoneNo);
            this.Controls.Add(this.txtCoustomerName);
            this.Controls.Add(this.lblCustomer);
            this.Name = "frmRegister";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.TextBox txtCoustomerName;
        private System.Windows.Forms.Label lblPhoneNo;
        private System.Windows.Forms.TextBox txtPHoneNo;
        private System.Windows.Forms.Label lblSdCard;
        private System.Windows.Forms.ComboBox cboSdCard;
        private System.Windows.Forms.ComboBox cboSimCard;
        private System.Windows.Forms.Label lblSimCard;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label llblEndDate;
        private System.Windows.Forms.Label lblCoustomerID;
        private System.Windows.Forms.Label lblTechnicalName;
        private System.Windows.Forms.TextBox txtTechnicalName;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblDone;
        private System.Windows.Forms.ComboBox cboDone;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.Label label1;
    }
}