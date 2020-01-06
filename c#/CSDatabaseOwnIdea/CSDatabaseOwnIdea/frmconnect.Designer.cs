namespace CSDatabaseOwnIdea
{
    partial class frmconnect
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
            this.txtconnection = new System.Windows.Forms.Label();
            this.btnconnected = new System.Windows.Forms.Button();
            this.btndisconnected = new System.Windows.Forms.Button();
            this.btnok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtconnection
            // 
            this.txtconnection.AutoSize = true;
            this.txtconnection.Font = new System.Drawing.Font("Ravie", 72F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtconnection.Location = new System.Drawing.Point(157, 9);
            this.txtconnection.Name = "txtconnection";
            this.txtconnection.Size = new System.Drawing.Size(473, 160);
            this.txtconnection.TabIndex = 0;
            this.txtconnection.Text = "show";
            // 
            // btnconnected
            // 
            this.btnconnected.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnconnected.Location = new System.Drawing.Point(3, 243);
            this.btnconnected.Name = "btnconnected";
            this.btnconnected.Size = new System.Drawing.Size(234, 112);
            this.btnconnected.TabIndex = 1;
            this.btnconnected.Text = "connected";
            this.btnconnected.UseVisualStyleBackColor = false;
           
            // 
            // btndisconnected
            // 
            this.btndisconnected.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btndisconnected.Location = new System.Drawing.Point(560, 241);
            this.btndisconnected.Name = "btndisconnected";
            this.btndisconnected.Size = new System.Drawing.Size(228, 112);
            this.btndisconnected.TabIndex = 2;
            this.btndisconnected.Text = "disconnected";
            this.btndisconnected.UseVisualStyleBackColor = false;
            this.btndisconnected.Click += new System.EventHandler(this.btnconnected_Click);
            // 
            // btnok
            // 
            this.btnok.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnok.Location = new System.Drawing.Point(242, 229);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(316, 137);
            this.btnok.TabIndex = 3;
            this.btnok.Text = "OK";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // frmconnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnok);
            this.Controls.Add(this.btndisconnected);
            this.Controls.Add(this.btnconnected);
            this.Controls.Add(this.txtconnection);
            this.Name = "frmconnect";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtconnection;
        private System.Windows.Forms.Button btnconnected;
        private System.Windows.Forms.Button btndisconnected;
        private System.Windows.Forms.Button btnok;
    }
}

