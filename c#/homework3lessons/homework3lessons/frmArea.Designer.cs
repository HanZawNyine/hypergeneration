namespace homework3lessons
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
            this.lbnRadius = new System.Windows.Forms.Label();
            this.lbnArea = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbnRadius
            // 
            this.lbnRadius.AutoSize = true;
            this.lbnRadius.Location = new System.Drawing.Point(93, 35);
            this.lbnRadius.Name = "lbnRadius";
            this.lbnRadius.Size = new System.Drawing.Size(84, 17);
            this.lbnRadius.TabIndex = 0;
            this.lbnRadius.Text = "Radius(mm)";
            // 
            // lbnArea
            // 
            this.lbnArea.AutoSize = true;
            this.lbnArea.Location = new System.Drawing.Point(92, 87);
            this.lbnArea.Name = "lbnArea";
            this.lbnArea.Size = new System.Drawing.Size(120, 17);
            this.lbnArea.TabIndex = 1;
            this.lbnArea.Text = "Area(Square mm)";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(370, 28);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(347, 22);
            this.txtRadius.TabIndex = 2;
            this.txtRadius.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRadius_KeyDown);
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(370, 84);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(347, 22);
            this.txtArea.TabIndex = 3;
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(375, 177);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(346, 53);
            this.btnClick.TabIndex = 4;
            this.btnClick.Text = "Click";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.btnClick_Click);
            // 
            // frmArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClick);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.lbnArea);
            this.Controls.Add(this.lbnRadius);
            this.Name = "frmArea";
            this.Text = "Area Of Circle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbnRadius;
        private System.Windows.Forms.Label lbnArea;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnClick;
    }
}

