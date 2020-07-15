namespace Var_Type
{
    partial class frmVar
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
            this.btnVar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVar
            // 
            this.btnVar.Location = new System.Drawing.Point(264, 259);
            this.btnVar.Name = "btnVar";
            this.btnVar.Size = new System.Drawing.Size(270, 81);
            this.btnVar.TabIndex = 0;
            this.btnVar.Text = "Click Me";
            this.btnVar.UseVisualStyleBackColor = true;
            this.btnVar.Click += new System.EventHandler(this.btnVar_Click);
            // 
            // frmVar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVar);
            this.Name = "frmVar";
            this.Text = "Var";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVar;
    }
}

