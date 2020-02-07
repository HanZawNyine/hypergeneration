namespace WindowsFormsApp5
{
    partial class frmCipher
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
            this.txtPlain = new System.Windows.Forms.TextBox();
            this.txtCipher = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOfile = new System.Windows.Forms.TextBox();
            this.txtIfile = new System.Windows.Forms.TextBox();
            this.btnEncFile = new System.Windows.Forms.Button();
            this.btnDecFile = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // txtPlain
            // 
            this.txtPlain.Font = new System.Drawing.Font("Zawgyi-One", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlain.Location = new System.Drawing.Point(18, 53);
            this.txtPlain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPlain.Multiline = true;
            this.txtPlain.Name = "txtPlain";
            this.txtPlain.Size = new System.Drawing.Size(190, 171);
            this.txtPlain.TabIndex = 0;
            this.txtPlain.TextChanged += new System.EventHandler(this.txtPlain_TextChanged);
            // 
            // txtCipher
            // 
            this.txtCipher.Location = new System.Drawing.Point(313, 53);
            this.txtCipher.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCipher.Multiline = true;
            this.txtCipher.Name = "txtCipher";
            this.txtCipher.Size = new System.Drawing.Size(208, 171);
            this.txtCipher.TabIndex = 1;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(212, 53);
            this.btnEncrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(83, 53);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "==>";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(212, 110);
            this.btnDecrypt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(83, 53);
            this.btnDecrypt.TabIndex = 3;
            this.btnDecrypt.Text = "<==";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Plain Text";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cipher Text";
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(212, 168);
            this.btnClearAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(83, 53);
            this.btnClearAll.TabIndex = 6;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.UseVisualStyleBackColor = true;
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(18, 244);
            this.txtKey.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(503, 22);
            this.txtKey.TabIndex = 7;
            this.txtKey.Text = "hnj890yurt5643as";
            this.txtKey.TextChanged += new System.EventHandler(this.txtKey_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Key";
            // 
            // txtOfile
            // 
            this.txtOfile.Location = new System.Drawing.Point(290, 290);
            this.txtOfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOfile.Name = "txtOfile";
            this.txtOfile.Size = new System.Drawing.Size(157, 22);
            this.txtOfile.TabIndex = 9;
            // 
            // txtIfile
            // 
            this.txtIfile.Location = new System.Drawing.Point(18, 290);
            this.txtIfile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIfile.Name = "txtIfile";
            this.txtIfile.Size = new System.Drawing.Size(152, 22);
            this.txtIfile.TabIndex = 10;
            // 
            // btnEncFile
            // 
            this.btnEncFile.Location = new System.Drawing.Point(20, 318);
            this.btnEncFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEncFile.Name = "btnEncFile";
            this.btnEncFile.Size = new System.Drawing.Size(228, 29);
            this.btnEncFile.TabIndex = 11;
            this.btnEncFile.Text = "Enc File";
            this.btnEncFile.UseVisualStyleBackColor = true;
            this.btnEncFile.Click += new System.EventHandler(this.btnEncFile_Click);
            // 
            // btnDecFile
            // 
            this.btnDecFile.Location = new System.Drawing.Point(290, 318);
            this.btnDecFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDecFile.Name = "btnDecFile";
            this.btnDecFile.Size = new System.Drawing.Size(230, 29);
            this.btnDecFile.TabIndex = 12;
            this.btnDecFile.Text = "Dec File";
            this.btnDecFile.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(535, 53);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(461, 294);
            this.txtOutput.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Input File";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(286, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Output File";
            // 
            // btnBrowse1
            // 
            this.btnBrowse1.Location = new System.Drawing.Point(174, 288);
            this.btnBrowse1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(67, 23);
            this.btnBrowse1.TabIndex = 16;
            this.btnBrowse1.Text = "...";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Location = new System.Drawing.Point(452, 290);
            this.btnBrowse2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(67, 22);
            this.btnBrowse2.TabIndex = 17;
            this.btnBrowse2.Text = "...";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmCipher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 362);
            this.Controls.Add(this.btnBrowse2);
            this.Controls.Add(this.btnBrowse1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnDecFile);
            this.Controls.Add(this.btnEncFile);
            this.Controls.Add(this.txtIfile);
            this.Controls.Add(this.txtOfile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtCipher);
            this.Controls.Add(this.txtPlain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCipher";
            this.Text = "ExportData";
            this.Load += new System.EventHandler(this.frmCipher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlain;
        private System.Windows.Forms.TextBox txtCipher;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOfile;
        private System.Windows.Forms.TextBox txtIfile;
        private System.Windows.Forms.Button btnEncFile;
        private System.Windows.Forms.Button btnDecFile;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.Button btnBrowse2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}