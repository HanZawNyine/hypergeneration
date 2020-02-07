namespace phone01
{
    partial class frmExport
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
            this.lblPlainText = new System.Windows.Forms.Label();
            this.lblCyperText = new System.Windows.Forms.Label();
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.txtCyper = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDecrypt = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.lblClearAll = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblKey = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblPlainText
            // 
            this.lblPlainText.AutoSize = true;
            this.lblPlainText.Location = new System.Drawing.Point(66, 27);
            this.lblPlainText.Name = "lblPlainText";
            this.lblPlainText.Size = new System.Drawing.Size(70, 17);
            this.lblPlainText.TabIndex = 0;
            this.lblPlainText.Text = "Plain Text";
            // 
            // lblCyperText
            // 
            this.lblCyperText.AutoSize = true;
            this.lblCyperText.Location = new System.Drawing.Point(580, 25);
            this.lblCyperText.Name = "lblCyperText";
            this.lblCyperText.Size = new System.Drawing.Size(76, 17);
            this.lblCyperText.TabIndex = 1;
            this.lblCyperText.Text = "Cyper Text";
            // 
            // txtPlain
            // 
            this.txtPlain.Location = new System.Drawing.Point(61, 68);
            this.txtPlain.Multiline = true;
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(214, 269);
            this.txtPlain.TabIndex = 2;
            // 
            // txtCyper
            // 
            this.txtCyper.Location = new System.Drawing.Point(486, 68);
            this.txtCyper.Multiline = true;
            this.txtCyper.Name = "txtCyper";
            this.txtCyper.Size = new System.Drawing.Size(214, 269);
            this.txtCyper.TabIndex = 3;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(360, 68);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(106, 88);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "==>>";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Encrypt";
            // 
            // lblDecrypt
            // 
            this.lblDecrypt.AutoSize = true;
            this.lblDecrypt.Location = new System.Drawing.Point(286, 285);
            this.lblDecrypt.Name = "lblDecrypt";
            this.lblDecrypt.Size = new System.Drawing.Size(57, 17);
            this.lblDecrypt.TabIndex = 7;
            this.lblDecrypt.Text = "Decrypt";
            this.lblDecrypt.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(361, 249);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(106, 88);
            this.btnDecrypt.TabIndex = 6;
            this.btnDecrypt.Text = "==>>";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(360, 175);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(106, 60);
            this.btnClearAll.TabIndex = 8;
            this.btnClearAll.Text = "<<==>>";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // lblClearAll
            // 
            this.lblClearAll.AutoSize = true;
            this.lblClearAll.Location = new System.Drawing.Point(293, 197);
            this.lblClearAll.Name = "lblClearAll";
            this.lblClearAll.Size = new System.Drawing.Size(60, 17);
            this.lblClearAll.TabIndex = 9;
            this.lblClearAll.Text = "Clear All";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 394);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(639, 22);
            this.textBox1.TabIndex = 10;
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Location = new System.Drawing.Point(58, 359);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(32, 17);
            this.lblKey.TabIndex = 11;
            this.lblKey.Text = "Key";
            // 
            // frmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 523);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblClearAll);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.lblDecrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtCyper);
            this.Controls.Add(this.txtPlain);
            this.Controls.Add(this.lblCyperText);
            this.Controls.Add(this.lblPlainText);
            this.Name = "frmExport";
            this.Text = "Export";
            this.Load += new System.EventHandler(this.frmExport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPlainText;
        private System.Windows.Forms.Label lblCyperText;
        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.TextBox txtCyper;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDecrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Label lblClearAll;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblKey;
    }
}