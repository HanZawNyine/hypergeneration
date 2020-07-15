namespace asdf
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
            this.txtL = new System.Windows.Forms.TextBox();
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtV = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtL
            // 
            this.txtL.Location = new System.Drawing.Point(167, 53);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(468, 22);
            this.txtL.TabIndex = 0;
            this.txtL.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(166, 214);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(468, 22);
            this.txtH.TabIndex = 1;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(166, 125);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(468, 22);
            this.txtB.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(289, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(236, 78);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtV
            // 
            this.txtV.Location = new System.Drawing.Point(167, 272);
            this.txtV.Name = "txtV";
            this.txtV.Size = new System.Drawing.Size(468, 22);
            this.txtV.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtV);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtV;
    }
}

