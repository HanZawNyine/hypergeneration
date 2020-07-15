namespace Digital_Clock
{
    partial class frmClock
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
            this.lblTimeSEC = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTimeSEC
            // 
            this.lblTimeSEC.AutoSize = true;
            this.lblTimeSEC.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeSEC.Location = new System.Drawing.Point(159, 371);
            this.lblTimeSEC.Name = "lblTimeSEC";
            this.lblTimeSEC.Size = new System.Drawing.Size(379, 135);
            this.lblTimeSEC.TabIndex = 0;
            this.lblTimeSEC.Text = "label1";
            this.lblTimeSEC.Click += new System.EventHandler(this.lblTimeSEC_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Time.Location = new System.Drawing.Point(691, 50);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(249, 91);
            this.Time.TabIndex = 1;
            this.Time.Text = "label1";
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // frmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1917, 600);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.lblTimeSEC);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmClock";
            this.Text = "frmClock";
            this.Load += new System.EventHandler(this.frmClock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTimeSEC;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Time;
    }
}