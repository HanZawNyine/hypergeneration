namespace BlackJack
{
    partial class frmDealer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDealer));
            this.btnStart = new System.Windows.Forms.Button();
            this.lblDealer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDrawaCard = new System.Windows.Forms.Button();
            this.il = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(448, 264);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(204, 38);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblDealer
            // 
            this.lblDealer.AutoSize = true;
            this.lblDealer.Location = new System.Drawing.Point(445, 51);
            this.lblDealer.Name = "lblDealer";
            this.lblDealer.Size = new System.Drawing.Size(62, 17);
            this.lblDealer.TabIndex = 5;
            this.lblDealer.Text = "Dealer =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(445, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "You     =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(535, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(522, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Total";
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(448, 308);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(204, 38);
            this.btnRestart.TabIndex = 10;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(448, 352);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(204, 38);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDrawaCard
            // 
            this.btnDrawaCard.Location = new System.Drawing.Point(448, 220);
            this.btnDrawaCard.Name = "btnDrawaCard";
            this.btnDrawaCard.Size = new System.Drawing.Size(204, 38);
            this.btnDrawaCard.TabIndex = 12;
            this.btnDrawaCard.Text = "Draw A Card";
            this.btnDrawaCard.UseVisualStyleBackColor = true;
            this.btnDrawaCard.Click += new System.EventHandler(this.btnDrawaCard_Click);
            // 
            // il
            // 
            this.il.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("il.ImageStream")));
            this.il.TransparentColor = System.Drawing.Color.Transparent;
            this.il.Images.SetKeyName(0, "AS.png");
            this.il.Images.SetKeyName(1, "2S.png");
            this.il.Images.SetKeyName(2, "3S.png");
            this.il.Images.SetKeyName(3, "4S.png");
            this.il.Images.SetKeyName(4, "5S.png");
            this.il.Images.SetKeyName(5, "6S.png");
            this.il.Images.SetKeyName(6, "7S.png");
            this.il.Images.SetKeyName(7, "8S.png");
            this.il.Images.SetKeyName(8, "9S.png");
            this.il.Images.SetKeyName(9, "10S.png");
            this.il.Images.SetKeyName(10, "JS.png");
            this.il.Images.SetKeyName(11, "KS.png");
            this.il.Images.SetKeyName(12, "QS.png");
            this.il.Images.SetKeyName(13, "AH.png");
            this.il.Images.SetKeyName(14, "2H.png");
            this.il.Images.SetKeyName(15, "3H.png");
            this.il.Images.SetKeyName(16, "4H.png");
            this.il.Images.SetKeyName(17, "5H.png");
            this.il.Images.SetKeyName(18, "6H.png");
            this.il.Images.SetKeyName(19, "7H.png");
            this.il.Images.SetKeyName(20, "8H.png");
            this.il.Images.SetKeyName(21, "9H.png");
            this.il.Images.SetKeyName(22, "10H.png");
            this.il.Images.SetKeyName(23, "JH.png");
            this.il.Images.SetKeyName(24, "QH.png");
            this.il.Images.SetKeyName(25, "KH.png");
            this.il.Images.SetKeyName(26, "AD.png");
            this.il.Images.SetKeyName(27, "2D.png");
            this.il.Images.SetKeyName(28, "3D.png");
            this.il.Images.SetKeyName(29, "4D.png");
            this.il.Images.SetKeyName(30, "5D.png");
            this.il.Images.SetKeyName(31, "6D.png");
            this.il.Images.SetKeyName(32, "7D.png");
            this.il.Images.SetKeyName(33, "8D.png");
            this.il.Images.SetKeyName(34, "9D.png");
            this.il.Images.SetKeyName(35, "10D.png");
            this.il.Images.SetKeyName(36, "JD.png");
            this.il.Images.SetKeyName(37, "KD.png");
            this.il.Images.SetKeyName(38, "QD.png");
            this.il.Images.SetKeyName(39, "AC.png");
            this.il.Images.SetKeyName(40, "2C.png");
            this.il.Images.SetKeyName(41, "3C.png");
            this.il.Images.SetKeyName(42, "4C.png");
            this.il.Images.SetKeyName(43, "5C.png");
            this.il.Images.SetKeyName(44, "6C.png");
            this.il.Images.SetKeyName(45, "7C.png");
            this.il.Images.SetKeyName(46, "8C.png");
            this.il.Images.SetKeyName(47, "9C.png");
            this.il.Images.SetKeyName(48, "10C.png");
            this.il.Images.SetKeyName(49, "JC.png");
            this.il.Images.SetKeyName(50, "KC.png");
            this.il.Images.SetKeyName(51, "QC.png");
            this.il.Images.SetKeyName(52, "red_back.png");
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(783, 11);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(226, 379);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 14;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::BlackJack.Properties.Resources.red_back;
            this.pictureBox5.Location = new System.Drawing.Point(114, 13);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(206, 378);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(893, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(206, 378);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(681, 12);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(206, 378);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BlackJack.Properties.Resources.red_back;
            this.pictureBox2.Location = new System.Drawing.Point(224, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(206, 378);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlackJack.Properties.Resources.red_back;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 378);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmDealer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 407);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnDrawaCard);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDealer);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmDealer";
            this.Load += new System.EventHandler(this.frmDealer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblDealer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDrawaCard;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.ImageList il;
    }
}