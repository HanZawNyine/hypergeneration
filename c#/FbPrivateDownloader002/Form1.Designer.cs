namespace FbPrivateDownloader002
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
            this.btnReady = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtPaste
            // 
            this.txtPaste.Location = new System.Drawing.Point(38, 12);
            this.txtPaste.Name = "txtPaste";
            this.txtPaste.Size = new System.Drawing.Size(519, 22);
            this.txtPaste.TabIndex = 0;
            // 
            // btnReady
            // 
            this.btnReady.Location = new System.Drawing.Point(634, 12);
            this.btnReady.Name = "btnReady";
            this.btnReady.Size = new System.Drawing.Size(151, 51);
            this.btnReady.TabIndex = 1;
            this.btnReady.Text = "Click";
            this.btnReady.UseVisualStyleBackColor = true;
            this.btnReady.ForeColorChanged += new System.EventHandler(this.btnReady_ForeColorChanged);
            this.btnReady.Click += new System.EventHandler(this.btnReady_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(7, 69);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(778, 360);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // txtChange
            // 
            this.txtChange.Enabled = false;
            this.txtChange.Location = new System.Drawing.Point(38, 41);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(519, 22);
            this.txtChange.TabIndex = 3;
            this.txtChange.TextChanged += new System.EventHandler(this.txtChange_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 437);
            this.Controls.Add(this.txtChange);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnReady);
            this.Controls.Add(this.txtPaste);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPaste;
        private System.Windows.Forms.Button btnReady;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.TextBox txtChange;
    }
}

