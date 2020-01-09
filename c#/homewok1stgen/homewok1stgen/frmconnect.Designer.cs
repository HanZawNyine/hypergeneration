namespace homewok1stgen
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
            this.lbnshow = new System.Windows.Forms.Label();
            this.btnDisconnected = new System.Windows.Forms.Button();
            this.btnConnected = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbnshow
            // 
            this.lbnshow.AutoSize = true;
            this.lbnshow.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnshow.Location = new System.Drawing.Point(302, 48);
            this.lbnshow.Name = "lbnshow";
            this.lbnshow.Size = new System.Drawing.Size(0, 51);
            this.lbnshow.TabIndex = 0;
            // 
            // btnDisconnected
            // 
            this.btnDisconnected.Location = new System.Drawing.Point(12, 220);
            this.btnDisconnected.Name = "btnDisconnected";
            this.btnDisconnected.Size = new System.Drawing.Size(329, 108);
            this.btnDisconnected.TabIndex = 1;
            this.btnDisconnected.Text = "Disconnected";
            this.btnDisconnected.UseVisualStyleBackColor = true;
            this.btnDisconnected.Click += new System.EventHandler(this.btnDisconnected_Click);
            // 
            // btnConnected
            // 
            this.btnConnected.Location = new System.Drawing.Point(459, 220);
            this.btnConnected.Name = "btnConnected";
            this.btnConnected.Size = new System.Drawing.Size(329, 108);
            this.btnConnected.TabIndex = 2;
            this.btnConnected.Text = "Connected";
            this.btnConnected.UseVisualStyleBackColor = true;
            this.btnConnected.Click += new System.EventHandler(this.btnConnected_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 91);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // frmconnect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConnected);
            this.Controls.Add(this.btnDisconnected);
            this.Controls.Add(this.lbnshow);
            this.Name = "frmconnect";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnshow;
        private System.Windows.Forms.Button btnDisconnected;
        private System.Windows.Forms.Button btnConnected;
        private System.Windows.Forms.Label label1;
    }
}

