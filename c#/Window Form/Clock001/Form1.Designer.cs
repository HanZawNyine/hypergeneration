namespace Clock001
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
            this.components = new System.ComponentModel.Container();
            this.lblAll = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDtae = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAll
            // 
            this.lblAll.AutoSize = true;
            this.lblAll.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAll.Font = new System.Drawing.Font("Onyx", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAll.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAll.Location = new System.Drawing.Point(653, 286);
            this.lblAll.Name = "lblAll";
            this.lblAll.Size = new System.Drawing.Size(113, 67);
            this.lblAll.TabIndex = 0;
            this.lblAll.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDate.Font = new System.Drawing.Font("Onyx", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(457, 405);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(153, 89);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "label1";
            // 
            // lblDtae
            // 
            this.lblDtae.AutoSize = true;
            this.lblDtae.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDtae.Font = new System.Drawing.Font("Onyx", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDtae.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDtae.Location = new System.Drawing.Point(650, 518);
            this.lblDtae.Name = "lblDtae";
            this.lblDtae.Size = new System.Drawing.Size(153, 89);
            this.lblDtae.TabIndex = 2;
            this.lblDtae.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1053, 693);
            this.ControlBox = false;
            this.Controls.Add(this.lblDtae);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAll);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Digital Clock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAll;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDtae;
    }
}

