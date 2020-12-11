
namespace HanZaw000101001
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Text";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(74, 33);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(364, 22);
            this.txtRadius.TabIndex = 1;
            this.txtRadius.TextChanged += new System.EventHandler(this.txtRadius_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(74, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(364, 50);
            this.button1.TabIndex = 4;
            this.button1.Text = "Answer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // frmArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 149);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.label1);
            this.Name = "frmArea";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmArea_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.Button button1;
    }
}

