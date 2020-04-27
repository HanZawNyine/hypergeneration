namespace FbPrivateDownloader
{
    partial class Form1
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
            this.txtPaste = new System.Windows.Forms.TextBox();
            this.btnDwnload = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPaste
            // 
            this.txtPaste.Location = new System.Drawing.Point(12, 23);
            this.txtPaste.Multiline = true;
            this.txtPaste.Name = "txtPaste";
            this.txtPaste.Size = new System.Drawing.Size(774, 33);
            this.txtPaste.TabIndex = 0;
            // 
            // btnDwnload
            // 
            this.btnDwnload.Location = new System.Drawing.Point(937, 20);
            this.btnDwnload.Name = "btnDwnload";
            this.btnDwnload.Size = new System.Drawing.Size(161, 36);
            this.btnDwnload.TabIndex = 1;
            this.btnDwnload.Text = "Download";
            this.btnDwnload.UseVisualStyleBackColor = true;
            this.btnDwnload.Click += new System.EventHandler(this.btnDwnload_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 80);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1235, 464);
            this.webBrowser1.TabIndex = 3;
            this.webBrowser1.Url = new System.Uri("http://www.facebook.com", System.UriKind.Absolute);
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1156, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 35);
            this.button1.TabIndex = 4;
            this.button1.Text = "test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 556);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnDwnload);
            this.Controls.Add(this.txtPaste);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPaste;
        private System.Windows.Forms.Button btnDwnload;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button button1;
    }
}

