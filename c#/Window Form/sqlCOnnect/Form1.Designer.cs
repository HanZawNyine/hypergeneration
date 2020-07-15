namespace sqlCOnnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wmp1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbList = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.fbD = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.wmp1)).BeginInit();
            this.SuspendLayout();
            // 
            // wmp1
            // 
            this.wmp1.Enabled = true;
            this.wmp1.Location = new System.Drawing.Point(12, 12);
            this.wmp1.Name = "wmp1";
            this.wmp1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp1.OcxState")));
            this.wmp1.Size = new System.Drawing.Size(767, 451);
            this.wmp1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1049, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(248, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbList
            // 
            this.lbList.FormattingEnabled = true;
            this.lbList.ItemHeight = 16;
            this.lbList.Location = new System.Drawing.Point(1049, 175);
            this.lbList.Name = "lbList";
            this.lbList.Size = new System.Drawing.Size(248, 356);
            this.lbList.TabIndex = 2;
            this.lbList.SelectedIndexChanged += new System.EventHandler(this.lbList_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1049, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(248, 67);
            this.button2.TabIndex = 3;
            this.button2.Text = "Choose Floder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 607);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbList);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.wmp1);
            this.Name = "Form1";
            this.Text = "Video Player";
            ((System.ComponentModel.ISupportInitialize)(this.wmp1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmp1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox lbList;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog fbD;
    }
}

