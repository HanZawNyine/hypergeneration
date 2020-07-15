namespace helloworldtuto
{
    partial class frmHelloWorld
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
            this.lblRadius = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.btnArea = new System.Windows.Forms.Button();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRadius
            // 
            this.lblRadius.AutoSize = true;
            this.lblRadius.Location = new System.Drawing.Point(26, 37);
            this.lblRadius.Name = "lblRadius";
            this.lblRadius.Size = new System.Drawing.Size(84, 17);
            this.lblRadius.TabIndex = 0;
            this.lblRadius.Text = "Radius(mm)";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(192, 37);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(334, 22);
            this.txtRadius.TabIndex = 1;
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(191, 182);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(335, 41);
            this.btnArea.TabIndex = 2;
            this.btnArea.Text = "Solution";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(192, 103);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(334, 22);
            this.txtArea.TabIndex = 3;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(26, 103);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(89, 17);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Area(sq mm)";
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lblRadius);
            this.Name = "frmHelloWorld";
            this.Text = "AreaOfCircle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadius;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label lblArea;
    }
}

