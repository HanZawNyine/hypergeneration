namespace TextAppend
{
    partial class frmTextAppend
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
            this.txtAppend = new System.Windows.Forms.TextBox();
            this.btnAppend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAppend
            // 
            this.txtAppend.Location = new System.Drawing.Point(54, 22);
            this.txtAppend.Multiline = true;
            this.txtAppend.Name = "txtAppend";
            this.txtAppend.Size = new System.Drawing.Size(488, 187);
            this.txtAppend.TabIndex = 0;
            // 
            // btnAppend
            // 
            this.btnAppend.Location = new System.Drawing.Point(55, 246);
            this.btnAppend.Name = "btnAppend";
            this.btnAppend.Size = new System.Drawing.Size(487, 155);
            this.btnAppend.TabIndex = 1;
            this.btnAppend.Text = "Message Box";
            this.btnAppend.UseVisualStyleBackColor = true;
            this.btnAppend.Click += new System.EventHandler(this.btnAppend_Click);
            // 
            // frmTextAppend
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAppend);
            this.Controls.Add(this.txtAppend);
            this.Name = "frmTextAppend";
            this.Text = "TextAppend";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAppend;
        private System.Windows.Forms.Button btnAppend;
    }
}

