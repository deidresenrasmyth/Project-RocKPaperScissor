namespace ScissorsRockPaper
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnPlayAgaing = new System.Windows.Forms.Button();
            this.lblYou = new System.Windows.Forms.Label();
            this.lblPc = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.imgRockUser = new System.Windows.Forms.PictureBox();
            this.imgScissorsUser = new System.Windows.Forms.PictureBox();
            this.imgPaperUser = new System.Windows.Forms.PictureBox();
            this.imgSystemRock = new System.Windows.Forms.PictureBox();
            this.imgSystemScissors = new System.Windows.Forms.PictureBox();
            this.imgPaperSystem = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgRockUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScissorsUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaperUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSystemRock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSystemScissors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaperSystem)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Enabled = false;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(331, 254);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(120, 40);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.BtnPlay_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // btnPlayAgaing
            // 
            this.btnPlayAgaing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayAgaing.Location = new System.Drawing.Point(331, 254);
            this.btnPlayAgaing.Name = "btnPlayAgaing";
            this.btnPlayAgaing.Size = new System.Drawing.Size(120, 40);
            this.btnPlayAgaing.TabIndex = 15;
            this.btnPlayAgaing.Text = "Play again";
            this.btnPlayAgaing.UseVisualStyleBackColor = true;
            this.btnPlayAgaing.Visible = false;
            this.btnPlayAgaing.Click += new System.EventHandler(this.BtnPlayAgaing_Click);
            // 
            // lblYou
            // 
            this.lblYou.AutoSize = true;
            this.lblYou.Font = new System.Drawing.Font("Verdana", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYou.Location = new System.Drawing.Point(37, 432);
            this.lblYou.Name = "lblYou";
            this.lblYou.Size = new System.Drawing.Size(143, 65);
            this.lblYou.TabIndex = 16;
            this.lblYou.Text = "You";
            this.lblYou.Visible = false;
            // 
            // lblPc
            // 
            this.lblPc.AutoSize = true;
            this.lblPc.Font = new System.Drawing.Font("Verdana", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPc.Location = new System.Drawing.Point(612, 432);
            this.lblPc.Name = "lblPc";
            this.lblPc.Size = new System.Drawing.Size(107, 65);
            this.lblPc.TabIndex = 17;
            this.lblPc.Text = "PC";
            this.lblPc.Visible = false;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(12, 9);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 48);
            this.lblResult.TabIndex = 18;
            this.lblResult.Visible = false;
            this.lblResult.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.Location = new System.Drawing.Point(313, 122);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(157, 32);
            this.lblStart.TabIndex = 19;
            this.lblStart.Text = "Lets Play !";
            // 
            // imgRockUser
            // 
            this.imgRockUser.Image = global::ScissorsRockPaper.Properties.Resources.imagem_11;
            this.imgRockUser.Location = new System.Drawing.Point(48, 191);
            this.imgRockUser.Name = "imgRockUser";
            this.imgRockUser.Size = new System.Drawing.Size(116, 103);
            this.imgRockUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRockUser.TabIndex = 14;
            this.imgRockUser.TabStop = false;
            this.imgRockUser.WaitOnLoad = true;
            this.imgRockUser.Click += new System.EventHandler(this.ImgNameUser_Click);
            // 
            // imgScissorsUser
            // 
            this.imgScissorsUser.Image = global::ScissorsRockPaper.Properties.Resources.imagem_3;
            this.imgScissorsUser.Location = new System.Drawing.Point(48, 325);
            this.imgScissorsUser.Name = "imgScissorsUser";
            this.imgScissorsUser.Size = new System.Drawing.Size(116, 103);
            this.imgScissorsUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgScissorsUser.TabIndex = 13;
            this.imgScissorsUser.TabStop = false;
            this.imgScissorsUser.WaitOnLoad = true;
            this.imgScissorsUser.Click += new System.EventHandler(this.ImgScissorsUser_Click);
            // 
            // imgPaperUser
            // 
            this.imgPaperUser.BackColor = System.Drawing.Color.Transparent;
            this.imgPaperUser.Image = global::ScissorsRockPaper.Properties.Resources.imagem_2;
            this.imgPaperUser.Location = new System.Drawing.Point(48, 62);
            this.imgPaperUser.Name = "imgPaperUser";
            this.imgPaperUser.Size = new System.Drawing.Size(116, 103);
            this.imgPaperUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPaperUser.TabIndex = 12;
            this.imgPaperUser.TabStop = false;
            this.imgPaperUser.Click += new System.EventHandler(this.ImgPaperUser_Click);
            // 
            // imgSystemRock
            // 
            this.imgSystemRock.Image = global::ScissorsRockPaper.Properties.Resources.imagem_1;
            this.imgSystemRock.Location = new System.Drawing.Point(602, 189);
            this.imgSystemRock.Name = "imgSystemRock";
            this.imgSystemRock.Size = new System.Drawing.Size(117, 105);
            this.imgSystemRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSystemRock.TabIndex = 11;
            this.imgSystemRock.TabStop = false;
            this.imgSystemRock.Visible = false;
            this.imgSystemRock.WaitOnLoad = true;
            // 
            // imgSystemScissors
            // 
            this.imgSystemScissors.Image = global::ScissorsRockPaper.Properties.Resources.imagem_31;
            this.imgSystemScissors.Location = new System.Drawing.Point(602, 325);
            this.imgSystemScissors.Name = "imgSystemScissors";
            this.imgSystemScissors.Size = new System.Drawing.Size(117, 103);
            this.imgSystemScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSystemScissors.TabIndex = 10;
            this.imgSystemScissors.TabStop = false;
            this.imgSystemScissors.Visible = false;
            this.imgSystemScissors.WaitOnLoad = true;
            this.imgSystemScissors.Click += new System.EventHandler(this.ImgSystemScissors_Click);
            // 
            // imgPaperSystem
            // 
            this.imgPaperSystem.Image = global::ScissorsRockPaper.Properties.Resources.imagem_21;
            this.imgPaperSystem.Location = new System.Drawing.Point(602, 52);
            this.imgPaperSystem.Name = "imgPaperSystem";
            this.imgPaperSystem.Size = new System.Drawing.Size(117, 102);
            this.imgPaperSystem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPaperSystem.TabIndex = 9;
            this.imgPaperSystem.TabStop = false;
            this.imgPaperSystem.Visible = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(283, 52);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 32);
            this.lblTitle.TabIndex = 20;
            this.lblTitle.Text = "Pick One and ....!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(782, 506);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblPc);
            this.Controls.Add(this.lblYou);
            this.Controls.Add(this.btnPlayAgaing);
            this.Controls.Add(this.imgRockUser);
            this.Controls.Add(this.imgScissorsUser);
            this.Controls.Add(this.imgPaperUser);
            this.Controls.Add(this.imgSystemRock);
            this.Controls.Add(this.imgSystemScissors);
            this.Controls.Add(this.imgPaperSystem);
            this.Controls.Add(this.btnPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Rock paper scissors!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgRockUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgScissorsUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaperUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSystemRock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSystemScissors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPaperSystem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox imgSystemRock;
        private System.Windows.Forms.PictureBox imgSystemScissors;
        private System.Windows.Forms.PictureBox imgPaperSystem;
        private System.Windows.Forms.PictureBox imgRockUser;
        private System.Windows.Forms.PictureBox imgScissorsUser;
        private System.Windows.Forms.PictureBox imgPaperUser;
        private System.Windows.Forms.Button btnPlayAgaing;
        private System.Windows.Forms.Label lblYou;
        private System.Windows.Forms.Label lblPc;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblTitle;
    }
}

