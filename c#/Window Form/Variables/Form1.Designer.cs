namespace Variables
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
            this.btnClick = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtV = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtH = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClick
            // 
            this.btnClick.Location = new System.Drawing.Point(270, 372);
            this.btnClick.Name = "btnClick";
            this.btnClick.Size = new System.Drawing.Size(361, 43);
            this.btnClick.TabIndex = 0;
            this.btnClick.Text = "Click Me";
            this.btnClick.UseVisualStyleBackColor = true;
            this.btnClick.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = " Volume Of the Cuboid(V)";
            // 
            // txtV
            // 
            this.txtV.Enabled = false;
            this.txtV.Location = new System.Drawing.Point(270, 304);
            this.txtV.Name = "txtV";
            this.txtV.Size = new System.Drawing.Size(361, 22);
            this.txtV.TabIndex = 2;
            this.txtV.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(270, 167);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(361, 22);
            this.txtB.TabIndex = 4;
            this.txtB.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtB_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Breadth Of the Cuboid(B)";
            // 
            // txtL
            // 
            this.txtL.Location = new System.Drawing.Point(270, 96);
            this.txtL.Name = "txtL";
            this.txtL.Size = new System.Drawing.Size(361, 22);
            this.txtL.TabIndex = 6;
            this.txtL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtL_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(80, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Length Of the Cuboid(L)";
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(270, 231);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(361, 22);
            this.txtH.TabIndex = 8;
            this.txtH.TextChanged += new System.EventHandler(this.txtH_TextChanged);
            this.txtH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtH_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(80, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Height Of the Cuboid(H)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClick);
            this.Name = "Form1";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClick;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtV;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.Label label4;
    }
}

