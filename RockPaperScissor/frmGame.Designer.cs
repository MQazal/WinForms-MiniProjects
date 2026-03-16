namespace RockPaperScissor
{
    partial class frmGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGame));
            this.panGame = new System.Windows.Forms.Panel();
            this.pboxUser3 = new System.Windows.Forms.PictureBox();
            this.pboxUser2 = new System.Windows.Forms.PictureBox();
            this.pboxUser1 = new System.Windows.Forms.PictureBox();
            this.pboxAI = new System.Windows.Forms.PictureBox();
            this.lblPlayerChoice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GameImages = new System.Windows.Forms.ImageList(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblRound = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
            this.lblAIWin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblPlayerData = new System.Windows.Forms.Label();
            this.lblRounds = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.AITimer = new System.Windows.Forms.Timer(this.components);
            this.panGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUser3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUser2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUser1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAI)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panGame
            // 
            this.panGame.BackColor = System.Drawing.Color.Transparent;
            this.panGame.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panGame.Controls.Add(this.pboxUser3);
            this.panGame.Controls.Add(this.pboxUser2);
            this.panGame.Controls.Add(this.pboxUser1);
            this.panGame.Controls.Add(this.pboxAI);
            this.panGame.Controls.Add(this.lblPlayerChoice);
            this.panGame.Controls.Add(this.label1);
            this.panGame.Location = new System.Drawing.Point(364, 44);
            this.panGame.Name = "panGame";
            this.panGame.Size = new System.Drawing.Size(690, 456);
            this.panGame.TabIndex = 0;
            // 
            // pboxUser3
            // 
            this.pboxUser3.BackgroundImage = global::RockPaperScissor.Properties.Resources.Scissor;
            this.pboxUser3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxUser3.Location = new System.Drawing.Point(553, 259);
            this.pboxUser3.Name = "pboxUser3";
            this.pboxUser3.Size = new System.Drawing.Size(102, 150);
            this.pboxUser3.TabIndex = 18;
            this.pboxUser3.TabStop = false;
            this.pboxUser3.Tag = "3";
            this.pboxUser3.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickImage);
            this.pboxUser3.MouseEnter += new System.EventHandler(this.EnterToUserImage);
            this.pboxUser3.MouseLeave += new System.EventHandler(this.LeaveUserImage);
            // 
            // pboxUser2
            // 
            this.pboxUser2.BackgroundImage = global::RockPaperScissor.Properties.Resources.Paper;
            this.pboxUser2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxUser2.Location = new System.Drawing.Point(409, 259);
            this.pboxUser2.Name = "pboxUser2";
            this.pboxUser2.Size = new System.Drawing.Size(103, 150);
            this.pboxUser2.TabIndex = 17;
            this.pboxUser2.TabStop = false;
            this.pboxUser2.Tag = "2";
            this.pboxUser2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickImage);
            this.pboxUser2.MouseEnter += new System.EventHandler(this.EnterToUserImage);
            this.pboxUser2.MouseLeave += new System.EventHandler(this.LeaveUserImage);
            // 
            // pboxUser1
            // 
            this.pboxUser1.BackgroundImage = global::RockPaperScissor.Properties.Resources.Rock;
            this.pboxUser1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxUser1.Location = new System.Drawing.Point(271, 259);
            this.pboxUser1.Name = "pboxUser1";
            this.pboxUser1.Size = new System.Drawing.Size(104, 150);
            this.pboxUser1.TabIndex = 16;
            this.pboxUser1.TabStop = false;
            this.pboxUser1.Tag = "1";
            this.pboxUser1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClickImage);
            this.pboxUser1.MouseEnter += new System.EventHandler(this.EnterToUserImage);
            this.pboxUser1.MouseLeave += new System.EventHandler(this.LeaveUserImage);
            // 
            // pboxAI
            // 
            this.pboxAI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pboxAI.Location = new System.Drawing.Point(290, 51);
            this.pboxAI.Name = "pboxAI";
            this.pboxAI.Size = new System.Drawing.Size(107, 150);
            this.pboxAI.TabIndex = 15;
            this.pboxAI.TabStop = false;
            // 
            // lblPlayerChoice
            // 
            this.lblPlayerChoice.AutoSize = true;
            this.lblPlayerChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerChoice.Location = new System.Drawing.Point(28, 344);
            this.lblPlayerChoice.Name = "lblPlayerChoice";
            this.lblPlayerChoice.Size = new System.Drawing.Size(36, 32);
            this.lblPlayerChoice.TabIndex = 7;
            this.lblPlayerChoice.Text = "\"\"";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "AI Choice:";
            // 
            // GameImages
            // 
            this.GameImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("GameImages.ImageStream")));
            this.GameImages.TransparentColor = System.Drawing.Color.Transparent;
            this.GameImages.Images.SetKeyName(0, "Rock.jpg");
            this.GameImages.Images.SetKeyName(1, "Paper.jpg");
            this.GameImages.Images.SetKeyName(2, "Scissor.jpg");
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lblRound);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblDraw);
            this.groupBox1.Controls.Add(this.lblAIWin);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblPlayerData);
            this.groupBox1.Controls.Add(this.lblRounds);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(35, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(299, 456);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game";
            // 
            // lblRound
            // 
            this.lblRound.AutoSize = true;
            this.lblRound.Location = new System.Drawing.Point(227, 156);
            this.lblRound.Name = "lblRound";
            this.lblRound.Size = new System.Drawing.Size(30, 32);
            this.lblRound.TabIndex = 10;
            this.lblRound.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(213, 32);
            this.label8.TabIndex = 9;
            this.label8.Text = "Round Number:";
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.Location = new System.Drawing.Point(183, 391);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(30, 32);
            this.lblDraw.TabIndex = 8;
            this.lblDraw.Text = "0";
            // 
            // lblAIWin
            // 
            this.lblAIWin.AutoSize = true;
            this.lblAIWin.Location = new System.Drawing.Point(147, 315);
            this.lblAIWin.Name = "lblAIWin";
            this.lblAIWin.Size = new System.Drawing.Size(30, 32);
            this.lblAIWin.TabIndex = 7;
            this.lblAIWin.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 391);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 32);
            this.label7.TabIndex = 5;
            this.label7.Text = "Draw Times:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 315);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 32);
            this.label6.TabIndex = 4;
            this.label6.Text = "AI\'s wins:";
            // 
            // lblPlayerData
            // 
            this.lblPlayerData.AutoSize = true;
            this.lblPlayerData.Location = new System.Drawing.Point(8, 236);
            this.lblPlayerData.Name = "lblPlayerData";
            this.lblPlayerData.Size = new System.Drawing.Size(34, 32);
            this.lblPlayerData.TabIndex = 3;
            this.lblPlayerData.Text = "\"\"";
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.Location = new System.Drawing.Point(239, 53);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(30, 32);
            this.lblRounds.TabIndex = 2;
            this.lblRounds.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "Rounds Number:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 32);
            this.label3.TabIndex = 0;
            this.label3.Text = "----------------------------";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Location = new System.Drawing.Point(656, 520);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(131, 45);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AITimer
            // 
            this.AITimer.Interval = 1000;
            this.AITimer.Tick += new System.EventHandler(this.AITimer_Tick);
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1099, 589);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panGame);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGame";
            this.Text = "Game Screen";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.panGame.ResumeLayout(false);
            this.panGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUser3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUser2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxUser1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxAI)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panGame;
        private System.Windows.Forms.Label lblPlayerChoice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPlayerData;
        private System.Windows.Forms.Label lblDraw;
        private System.Windows.Forms.Label lblAIWin;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblRound;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ImageList GameImages;
        private System.Windows.Forms.Timer AITimer;
        private System.Windows.Forms.PictureBox pboxAI;
        private System.Windows.Forms.PictureBox pboxUser1;
        private System.Windows.Forms.PictureBox pboxUser3;
        private System.Windows.Forms.PictureBox pboxUser2;
    }
}