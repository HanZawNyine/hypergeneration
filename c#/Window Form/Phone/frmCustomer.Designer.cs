namespace Phone
{
    partial class frmCustomer
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
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblPhoneBrand = new System.Windows.Forms.Label();
            this.cboPhoneBrand = new System.Windows.Forms.ComboBox();
            this.lblPhoneColor = new System.Windows.Forms.Label();
            this.cboPhoneColor = new System.Windows.Forms.ComboBox();
            this.txtPasswordLock = new System.Windows.Forms.TextBox();
            this.lblPasswordLock = new System.Windows.Forms.Label();
            this.lblSimCard = new System.Windows.Forms.Label();
            this.cboSimCard = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboSdCard = new System.Windows.Forms.ComboBox();
            this.lblSdCard = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.cboError = new System.Windows.Forms.ComboBox();
            this.lblError = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(61, 36);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(85, 17);
            this.lblCustomerID.TabIndex = 0;
            this.lblCustomerID.Text = "Customer ID";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(273, 106);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(368, 22);
            this.txtCustomerName.TabIndex = 3;
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(61, 108);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(109, 17);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Customer Name";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(273, 179);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(368, 22);
            this.txtPhoneNumber.TabIndex = 5;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(61, 181);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(103, 17);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblPhoneBrand
            // 
            this.lblPhoneBrand.AutoSize = true;
            this.lblPhoneBrand.Location = new System.Drawing.Point(61, 248);
            this.lblPhoneBrand.Name = "lblPhoneBrand";
            this.lblPhoneBrand.Size = new System.Drawing.Size(91, 17);
            this.lblPhoneBrand.TabIndex = 6;
            this.lblPhoneBrand.Text = "Phone Brand";
            this.lblPhoneBrand.Click += new System.EventHandler(this.lblPhoneBrand_Click);
            // 
            // cboPhoneBrand
            // 
            this.cboPhoneBrand.FormattingEnabled = true;
            this.cboPhoneBrand.Items.AddRange(new object[] {
            "MI",
            "mi note 2",
            "mi note 3",
            "mi note 4",
            "mi note 5",
            "mi note 6",
            "mi note 7",
            "mi note 7 pro",
            "mi note 8",
            "mi note 8 pro",
            "mi note 9",
            "mi note 9 se"});
            this.cboPhoneBrand.Location = new System.Drawing.Point(273, 241);
            this.cboPhoneBrand.Name = "cboPhoneBrand";
            this.cboPhoneBrand.Size = new System.Drawing.Size(368, 24);
            this.cboPhoneBrand.TabIndex = 7;
            // 
            // lblPhoneColor
            // 
            this.lblPhoneColor.AutoSize = true;
            this.lblPhoneColor.Location = new System.Drawing.Point(61, 303);
            this.lblPhoneColor.Name = "lblPhoneColor";
            this.lblPhoneColor.Size = new System.Drawing.Size(86, 17);
            this.lblPhoneColor.TabIndex = 9;
            this.lblPhoneColor.Text = "Phone Color";
            this.lblPhoneColor.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboPhoneColor
            // 
            this.cboPhoneColor.FormattingEnabled = true;
            this.cboPhoneColor.Items.AddRange(new object[] {
            "Orange",
            "Yellow",
            "Red",
            "Green",
            "Blue",
            "Pink"});
            this.cboPhoneColor.Location = new System.Drawing.Point(273, 296);
            this.cboPhoneColor.Name = "cboPhoneColor";
            this.cboPhoneColor.Size = new System.Drawing.Size(368, 24);
            this.cboPhoneColor.TabIndex = 10;
            // 
            // txtPasswordLock
            // 
            this.txtPasswordLock.Location = new System.Drawing.Point(273, 363);
            this.txtPasswordLock.Name = "txtPasswordLock";
            this.txtPasswordLock.Size = new System.Drawing.Size(368, 22);
            this.txtPasswordLock.TabIndex = 12;
            // 
            // lblPasswordLock
            // 
            this.lblPasswordLock.AutoSize = true;
            this.lblPasswordLock.Location = new System.Drawing.Point(61, 365);
            this.lblPasswordLock.Name = "lblPasswordLock";
            this.lblPasswordLock.Size = new System.Drawing.Size(103, 17);
            this.lblPasswordLock.TabIndex = 11;
            this.lblPasswordLock.Text = "Password Lock";
            // 
            // lblSimCard
            // 
            this.lblSimCard.AutoSize = true;
            this.lblSimCard.Location = new System.Drawing.Point(61, 425);
            this.lblSimCard.Name = "lblSimCard";
            this.lblSimCard.Size = new System.Drawing.Size(65, 17);
            this.lblSimCard.TabIndex = 13;
            this.lblSimCard.Text = "Sim Card";
            // 
            // cboSimCard
            // 
            this.cboSimCard.FormattingEnabled = true;
            this.cboSimCard.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cboSimCard.Location = new System.Drawing.Point(273, 425);
            this.cboSimCard.Name = "cboSimCard";
            this.cboSimCard.Size = new System.Drawing.Size(368, 24);
            this.cboSimCard.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.comboBox1.Location = new System.Drawing.Point(273, 486);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(368, 24);
            this.comboBox1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Sim Card";
            // 
            // cboSdCard
            // 
            this.cboSdCard.FormattingEnabled = true;
            this.cboSdCard.Items.AddRange(new object[] {
            "YES",
            "NO"});
            this.cboSdCard.Location = new System.Drawing.Point(273, 567);
            this.cboSdCard.Name = "cboSdCard";
            this.cboSdCard.Size = new System.Drawing.Size(368, 24);
            this.cboSdCard.TabIndex = 18;
            // 
            // lblSdCard
            // 
            this.lblSdCard.AutoSize = true;
            this.lblSdCard.Location = new System.Drawing.Point(61, 567);
            this.lblSdCard.Name = "lblSdCard";
            this.lblSdCard.Size = new System.Drawing.Size(61, 17);
            this.lblSdCard.TabIndex = 17;
            this.lblSdCard.Text = "SD Card";
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(61, 633);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(72, 17);
            this.lblStartDate.TabIndex = 19;
            this.lblStartDate.Text = "Start Date";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(273, 622);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(368, 22);
            this.dtpStartDate.TabIndex = 20;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(273, 687);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(368, 22);
            this.dtpEndDate.TabIndex = 22;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(61, 698);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(67, 17);
            this.lblEndDate.TabIndex = 21;
            this.lblEndDate.Text = "End Date";
            // 
            // cboError
            // 
            this.cboError.FormattingEnabled = true;
            this.cboError.Items.AddRange(new object[] {
            "no power",
            "sim lock",
            "lose key",
            "fb error"});
            this.cboError.Location = new System.Drawing.Point(273, 746);
            this.cboError.Name = "cboError";
            this.cboError.Size = new System.Drawing.Size(368, 24);
            this.cboError.TabIndex = 24;
            this.cboError.SelectedIndexChanged += new System.EventHandler(this.cboError_SelectedIndexChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(61, 753);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(77, 17);
            this.lblError.TabIndex = 23;
            this.lblError.Text = "Error Code";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(61, 821);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(56, 17);
            this.lblAmount.TabIndex = 25;
            this.lblAmount.Text = "Amount";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(273, 949);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 46);
            this.btnCancel.TabIndex = 27;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(516, 949);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(125, 46);
            this.btnRegister.TabIndex = 28;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(280, 814);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(347, 22);
            this.txtAmount.TabIndex = 29;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(276, 723);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(41, 17);
            this.lblCode.TabIndex = 30;
            this.lblCode.Text = "Code";
            // 
            // frmCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(713, 1055);
            this.Controls.Add(this.lblCode);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.cboError);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.cboSdCard);
            this.Controls.Add(this.lblSdCard);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboSimCard);
            this.Controls.Add(this.lblSimCard);
            this.Controls.Add(this.txtPasswordLock);
            this.Controls.Add(this.lblPasswordLock);
            this.Controls.Add(this.cboPhoneColor);
            this.Controls.Add(this.lblPhoneColor);
            this.Controls.Add(this.cboPhoneBrand);
            this.Controls.Add(this.lblPhoneBrand);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.lblCustomerID);
            this.Name = "frmCustomer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblPhoneBrand;
        private System.Windows.Forms.ComboBox cboPhoneBrand;
        private System.Windows.Forms.Label lblPhoneColor;
        private System.Windows.Forms.ComboBox cboPhoneColor;
        private System.Windows.Forms.TextBox txtPasswordLock;
        private System.Windows.Forms.Label lblPasswordLock;
        private System.Windows.Forms.Label lblSimCard;
        private System.Windows.Forms.ComboBox cboSimCard;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSdCard;
        private System.Windows.Forms.Label lblSdCard;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.ComboBox cboError;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblCode;
    }
}

