namespace paing
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
            this.hellobtt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // hellobtt
            // 
            this.hellobtt.Location = new System.Drawing.Point(266, 136);
            this.hellobtt.Name = "hellobtt";
            this.hellobtt.Size = new System.Drawing.Size(217, 102);
            this.hellobtt.TabIndex = 0;
            this.hellobtt.Text = "hello";
            this.hellobtt.UseVisualStyleBackColor = true;
            this.hellobtt.Click += new System.EventHandler(this.hellobtt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hellobtt);
            this.Name = "Form1";
            this.Text = "hello";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button hellobtt;
    }
}

