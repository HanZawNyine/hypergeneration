namespace HelloWorld
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
            this.btnHellloWorld = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnHellloWorld
            // 
            this.btnHellloWorld.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnHellloWorld.Location = new System.Drawing.Point(244, 106);
            this.btnHellloWorld.Name = "btnHellloWorld";
            this.btnHellloWorld.Size = new System.Drawing.Size(270, 69);
            this.btnHellloWorld.TabIndex = 0;
            this.btnHellloWorld.Text = "Hello World";
            this.btnHellloWorld.UseVisualStyleBackColor = false;
            this.btnHellloWorld.Click += new System.EventHandler(this.btnHellloWorld_Click);
            // 
            // frmHelloWorld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlText;
            this.ClientSize = new System.Drawing.Size(753, 311);
            this.Controls.Add(this.btnHellloWorld);
            this.Name = "frmHelloWorld";
            this.Text = "Hello World";
            this.Load += new System.EventHandler(this.frmHelloWorld_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHellloWorld;
    }
}

