namespace PlayingCardForFirst
{
    partial class frmOneUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOneUser));
            this.ILCollect = new System.Windows.Forms.ImageList(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.lblOne = new System.Windows.Forms.Label();
            this.lbTwo = new System.Windows.Forms.Label();
            this.lbCount1 = new System.Windows.Forms.Label();
            this.lbCount2 = new System.Windows.Forms.Label();
            this.pbUserTwo = new System.Windows.Forms.PictureBox();
            this.pbUserOne = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserOne)).BeginInit();
            this.SuspendLayout();
            // 
            // ILCollect
            // 
            this.ILCollect.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ILCollect.ImageStream")));
            this.ILCollect.TransparentColor = System.Drawing.Color.Transparent;
            this.ILCollect.Images.SetKeyName(0, "AS.png");
            this.ILCollect.Images.SetKeyName(1, "2S.png");
            this.ILCollect.Images.SetKeyName(2, "3S.png");
            this.ILCollect.Images.SetKeyName(3, "4S.png");
            this.ILCollect.Images.SetKeyName(4, "5S.png");
            this.ILCollect.Images.SetKeyName(5, "6S.png");
            this.ILCollect.Images.SetKeyName(6, "7S.png");
            this.ILCollect.Images.SetKeyName(7, "8S.png");
            this.ILCollect.Images.SetKeyName(8, "9S.png");
            this.ILCollect.Images.SetKeyName(9, "10S.png");
            this.ILCollect.Images.SetKeyName(10, "JS.png");
            this.ILCollect.Images.SetKeyName(11, "QS.png");
            this.ILCollect.Images.SetKeyName(12, "KS.png");
            this.ILCollect.Images.SetKeyName(13, "AH.png");
            this.ILCollect.Images.SetKeyName(14, "2H.png");
            this.ILCollect.Images.SetKeyName(15, "3H.png");
            this.ILCollect.Images.SetKeyName(16, "4H.png");
            this.ILCollect.Images.SetKeyName(17, "5H.png");
            this.ILCollect.Images.SetKeyName(18, "6H.png");
            this.ILCollect.Images.SetKeyName(19, "7H.png");
            this.ILCollect.Images.SetKeyName(20, "8H.png");
            this.ILCollect.Images.SetKeyName(21, "9H.png");
            this.ILCollect.Images.SetKeyName(22, "10H.png");
            this.ILCollect.Images.SetKeyName(23, "JH.png");
            this.ILCollect.Images.SetKeyName(24, "QH.png");
            this.ILCollect.Images.SetKeyName(25, "KH.png");
            this.ILCollect.Images.SetKeyName(26, "AD.png");
            this.ILCollect.Images.SetKeyName(27, "2D.png");
            this.ILCollect.Images.SetKeyName(28, "3D.png");
            this.ILCollect.Images.SetKeyName(29, "4D.png");
            this.ILCollect.Images.SetKeyName(30, "5D.png");
            this.ILCollect.Images.SetKeyName(31, "6D.png");
            this.ILCollect.Images.SetKeyName(32, "7D.png");
            this.ILCollect.Images.SetKeyName(33, "8D.png");
            this.ILCollect.Images.SetKeyName(34, "9D.png");
            this.ILCollect.Images.SetKeyName(35, "10D.png");
            this.ILCollect.Images.SetKeyName(36, "JD.png");
            this.ILCollect.Images.SetKeyName(37, "KD.png");
            this.ILCollect.Images.SetKeyName(38, "QD.png");
            this.ILCollect.Images.SetKeyName(39, "AC.png");
            this.ILCollect.Images.SetKeyName(40, "2C.png");
            this.ILCollect.Images.SetKeyName(41, "3C.png");
            this.ILCollect.Images.SetKeyName(42, "4C.png");
            this.ILCollect.Images.SetKeyName(43, "5C.png");
            this.ILCollect.Images.SetKeyName(44, "6C.png");
            this.ILCollect.Images.SetKeyName(45, "7C.png");
            this.ILCollect.Images.SetKeyName(46, "8C.png");
            this.ILCollect.Images.SetKeyName(47, "9C.png");
            this.ILCollect.Images.SetKeyName(48, "10C.png");
            this.ILCollect.Images.SetKeyName(49, "JC.png");
            this.ILCollect.Images.SetKeyName(50, "KC.png");
            this.ILCollect.Images.SetKeyName(51, "QC.png");
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(288, 376);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(205, 35);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Location = new System.Drawing.Point(280, 43);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(76, 17);
            this.lblOne.TabIndex = 4;
            this.lblOne.Text = "user one =";
            // 
            // lbTwo
            // 
            this.lbTwo.AutoSize = true;
            this.lbTwo.Location = new System.Drawing.Point(280, 93);
            this.lbTwo.Name = "lbTwo";
            this.lbTwo.Size = new System.Drawing.Size(73, 17);
            this.lbTwo.TabIndex = 5;
            this.lbTwo.Text = "user two =";
            // 
            // lbCount1
            // 
            this.lbCount1.AutoSize = true;
            this.lbCount1.Location = new System.Drawing.Point(372, 43);
            this.lbCount1.Name = "lbCount1";
            this.lbCount1.Size = new System.Drawing.Size(16, 17);
            this.lbCount1.TabIndex = 6;
            this.lbCount1.Text = "0";
            // 
            // lbCount2
            // 
            this.lbCount2.AutoSize = true;
            this.lbCount2.Location = new System.Drawing.Point(372, 93);
            this.lbCount2.Name = "lbCount2";
            this.lbCount2.Size = new System.Drawing.Size(16, 17);
            this.lbCount2.TabIndex = 7;
            this.lbCount2.Text = "0";
            // 
            // pbUserTwo
            // 
            this.pbUserTwo.ErrorImage = global::PlayingCardForFirst.Properties.Resources.yellow_back;
            this.pbUserTwo.Image = global::PlayingCardForFirst.Properties.Resources.red_back1;
            this.pbUserTwo.Location = new System.Drawing.Point(520, 12);
            this.pbUserTwo.Name = "pbUserTwo";
            this.pbUserTwo.Size = new System.Drawing.Size(255, 399);
            this.pbUserTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserTwo.TabIndex = 2;
            this.pbUserTwo.TabStop = false;
            // 
            // pbUserOne
            // 
            this.pbUserOne.Image = global::PlayingCardForFirst.Properties.Resources.red_back1;
            this.pbUserOne.Location = new System.Drawing.Point(12, 12);
            this.pbUserOne.Name = "pbUserOne";
            this.pbUserOne.Size = new System.Drawing.Size(248, 399);
            this.pbUserOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserOne.TabIndex = 0;
            this.pbUserOne.TabStop = false;
            this.pbUserOne.Click += new System.EventHandler(this.pbUserOne_Click);
            // 
            // frmOneUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbCount2);
            this.Controls.Add(this.lbCount1);
            this.Controls.Add(this.lbTwo);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pbUserTwo);
            this.Controls.Add(this.pbUserOne);
            this.Name = "frmOneUser";
            this.Text = "One User";
            this.Load += new System.EventHandler(this.frmOneUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbUserTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbUserOne;
        private System.Windows.Forms.PictureBox pbUserTwo;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label lbTwo;
        private System.Windows.Forms.Label lbCount1;
        private System.Windows.Forms.Label lbCount2;
        public System.Windows.Forms.ImageList ILCollect;
    }
}

