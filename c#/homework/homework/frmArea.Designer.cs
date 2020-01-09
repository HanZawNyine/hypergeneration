namespace homework
{
    partial class frmArea
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
            this.txtradius = new System.Windows.Forms.TextBox();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.lbradius = new System.Windows.Forms.Label();
            this.lbarea = new System.Windows.Forms.Label();
            this.btnsolution = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtradius
            // 
            this.txtradius.Location = new System.Drawing.Point(359, 19);
            this.txtradius.Name = "txtradius";
            this.txtradius.Size = new System.Drawing.Size(398, 22);
            this.txtradius.TabIndex = 0;
            this.txtradius.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtradius_KeyDown);
            // 
            // txtarea
            // 
            this.txtarea.Enabled = false;
            this.txtarea.Location = new System.Drawing.Point(362, 87);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(394, 22);
            this.txtarea.TabIndex = 1;
            // 
            // lbradius
            // 
            this.lbradius.AutoSize = true;
            this.lbradius.Location = new System.Drawing.Point(123, 24);
            this.lbradius.Name = "lbradius";
            this.lbradius.Size = new System.Drawing.Size(84, 17);
            this.lbradius.TabIndex = 2;
            this.lbradius.Text = "Radius(mm)";
            // 
            // lbarea
            // 
            this.lbarea.AutoSize = true;
            this.lbarea.Location = new System.Drawing.Point(123, 87);
            this.lbarea.Name = "lbarea";
            this.lbarea.Size = new System.Drawing.Size(118, 17);
            this.lbarea.TabIndex = 3;
            this.lbarea.Text = "Area(square mm)";
            // 
            // btnsolution
            // 
            this.btnsolution.Location = new System.Drawing.Point(370, 165);
            this.btnsolution.Name = "btnsolution";
            this.btnsolution.Size = new System.Drawing.Size(385, 47);
            this.btnsolution.TabIndex = 4;
            this.btnsolution.Text = "cilck";
            this.btnsolution.UseVisualStyleBackColor = true;
            this.btnsolution.Click += new System.EventHandler(this.btnsolution_Click);
            this.btnsolution.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnsolution_KeyDown);
            // 
            // frmArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsolution);
            this.Controls.Add(this.lbarea);
            this.Controls.Add(this.lbradius);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.txtradius);
            this.Name = "frmArea";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtradius;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.Label lbradius;
        private System.Windows.Forms.Label lbarea;
        private System.Windows.Forms.Button btnsolution;
    }
}

