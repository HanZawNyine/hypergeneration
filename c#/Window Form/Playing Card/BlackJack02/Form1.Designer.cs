namespace BlackJack02
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.lblDeal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(213, 433);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(122, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 433);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(764, 9);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(213, 433);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(859, 9);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(213, 433);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(973, 9);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(213, 433);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(230, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(213, 433);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(478, 380);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(252, 58);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(478, 316);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(252, 58);
            this.button2.TabIndex = 7;
            this.button2.Text = "Start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(478, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(252, 58);
            this.button3.TabIndex = 8;
            this.button3.Text = "Draw A Card";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Deal =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "User =";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Location = new System.Drawing.Point(579, 111);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(16, 17);
            this.lbluser.TabIndex = 11;
            this.lbluser.Text = "0";
            // 
            // lblDeal
            // 
            this.lblDeal.AutoSize = true;
            this.lblDeal.Location = new System.Drawing.Point(579, 64);
            this.lblDeal.Name = "lblDeal";
            this.lblDeal.Size = new System.Drawing.Size(16, 17);
            this.lblDeal.TabIndex = 12;
            this.lblDeal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(555, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Total";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "AS.png");
            this.imageList1.Images.SetKeyName(1, "2S.png");
            this.imageList1.Images.SetKeyName(2, "3S.png");
            this.imageList1.Images.SetKeyName(3, "4S.png");
            this.imageList1.Images.SetKeyName(4, "5S.png");
            this.imageList1.Images.SetKeyName(5, "6S.png");
            this.imageList1.Images.SetKeyName(6, "7S.png");
            this.imageList1.Images.SetKeyName(7, "8S.png");
            this.imageList1.Images.SetKeyName(8, "9S.png");
            this.imageList1.Images.SetKeyName(9, "10S.png");
            this.imageList1.Images.SetKeyName(10, "JS.png");
            this.imageList1.Images.SetKeyName(11, "KS.png");
            this.imageList1.Images.SetKeyName(12, "QS.png");
            this.imageList1.Images.SetKeyName(13, "AH.png");
            this.imageList1.Images.SetKeyName(14, "2H.png");
            this.imageList1.Images.SetKeyName(15, "3H.png");
            this.imageList1.Images.SetKeyName(16, "4H.png");
            this.imageList1.Images.SetKeyName(17, "5H.png");
            this.imageList1.Images.SetKeyName(18, "6H.png");
            this.imageList1.Images.SetKeyName(19, "7H.png");
            this.imageList1.Images.SetKeyName(20, "8H.png");
            this.imageList1.Images.SetKeyName(21, "9H.png");
            this.imageList1.Images.SetKeyName(22, "10H.png");
            this.imageList1.Images.SetKeyName(23, "JH.png");
            this.imageList1.Images.SetKeyName(24, "KH.png");
            this.imageList1.Images.SetKeyName(25, "QH.png");
            this.imageList1.Images.SetKeyName(26, "AD.png");
            this.imageList1.Images.SetKeyName(27, "2D.png");
            this.imageList1.Images.SetKeyName(28, "3D.png");
            this.imageList1.Images.SetKeyName(29, "4D.png");
            this.imageList1.Images.SetKeyName(30, "5D.png");
            this.imageList1.Images.SetKeyName(31, "6D.png");
            this.imageList1.Images.SetKeyName(32, "7D.png");
            this.imageList1.Images.SetKeyName(33, "8D.png");
            this.imageList1.Images.SetKeyName(34, "9D.png");
            this.imageList1.Images.SetKeyName(35, "10D.png");
            this.imageList1.Images.SetKeyName(36, "JD.png");
            this.imageList1.Images.SetKeyName(37, "QD.png");
            this.imageList1.Images.SetKeyName(38, "KD.png");
            this.imageList1.Images.SetKeyName(39, "AC.png");
            this.imageList1.Images.SetKeyName(40, "2C.png");
            this.imageList1.Images.SetKeyName(41, "3C.png");
            this.imageList1.Images.SetKeyName(42, "4C.png");
            this.imageList1.Images.SetKeyName(43, "5C.png");
            this.imageList1.Images.SetKeyName(44, "6C.png");
            this.imageList1.Images.SetKeyName(45, "7C.png");
            this.imageList1.Images.SetKeyName(46, "8C.png");
            this.imageList1.Images.SetKeyName(47, "9C.png");
            this.imageList1.Images.SetKeyName(48, "10C.png");
            this.imageList1.Images.SetKeyName(49, "JC.png");
            this.imageList1.Images.SetKeyName(50, "QC.png");
            this.imageList1.Images.SetKeyName(51, "KC.png");
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(478, 162);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(251, 59);
            this.button4.TabIndex = 14;
            this.button4.Text = "Restart";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1208, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDeal);
            this.Controls.Add(this.lbluser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Shan Koe Mee";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.Label lblDeal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button4;
    }
}

