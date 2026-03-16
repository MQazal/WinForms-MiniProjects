namespace TimeManager
{
    partial class frmManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManager));
            this.TimeIcons = new System.Windows.Forms.ImageList(this.components);
            this.lblHour = new System.Windows.Forms.Label();
            this.lblMinute = new System.Windows.Forms.Label();
            this.lblSecond = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPMAM = new System.Windows.Forms.Label();
            this.lblShortDayName = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnHoursMode1 = new System.Windows.Forms.Button();
            this.btnHoursMode2 = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnStopWatch = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TimeIcons
            // 
            this.TimeIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TimeIcons.ImageStream")));
            this.TimeIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.TimeIcons.Images.SetKeyName(0, "12 H.png");
            this.TimeIcons.Images.SetKeyName(1, "24 H.png");
            this.TimeIcons.Images.SetKeyName(2, "Clock.png");
            this.TimeIcons.Images.SetKeyName(3, "Stop Watch.png");
            this.TimeIcons.Images.SetKeyName(4, "timer.png");
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Segoe UI Historic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHour.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHour.Location = new System.Drawing.Point(179, 131);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(51, 40);
            this.lblHour.TabIndex = 0;
            this.lblHour.Text = "00";
            // 
            // lblMinute
            // 
            this.lblMinute.AutoSize = true;
            this.lblMinute.Font = new System.Drawing.Font("Segoe UI Historic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinute.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMinute.Location = new System.Drawing.Point(245, 131);
            this.lblMinute.Name = "lblMinute";
            this.lblMinute.Size = new System.Drawing.Size(51, 40);
            this.lblMinute.TabIndex = 1;
            this.lblMinute.Text = "00";
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Font = new System.Drawing.Font("Segoe UI Historic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecond.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSecond.Location = new System.Drawing.Point(304, 131);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(51, 40);
            this.lblSecond.TabIndex = 2;
            this.lblSecond.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(225, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 40);
            this.label3.TabIndex = 3;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(287, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = ":";
            // 
            // lblPMAM
            // 
            this.lblPMAM.AutoSize = true;
            this.lblPMAM.Font = new System.Drawing.Font("Segoe UI Historic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPMAM.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblPMAM.Location = new System.Drawing.Point(378, 163);
            this.lblPMAM.Name = "lblPMAM";
            this.lblPMAM.Size = new System.Drawing.Size(90, 30);
            this.lblPMAM.TabIndex = 5;
            this.lblPMAM.Text = "PM/AM";
            // 
            // lblShortDayName
            // 
            this.lblShortDayName.AutoSize = true;
            this.lblShortDayName.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShortDayName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblShortDayName.Location = new System.Drawing.Point(191, 205);
            this.lblShortDayName.Name = "lblShortDayName";
            this.lblShortDayName.Size = new System.Drawing.Size(134, 32);
            this.lblShortDayName.TabIndex = 6;
            this.lblShortDayName.Text = "Day Name";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI Historic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDate.Location = new System.Drawing.Point(191, 264);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(68, 32);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date";
            // 
            // btnHoursMode1
            // 
            this.btnHoursMode1.BackColor = System.Drawing.Color.PowderBlue;
            this.btnHoursMode1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoursMode1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHoursMode1.ImageIndex = 0;
            this.btnHoursMode1.ImageList = this.TimeIcons;
            this.btnHoursMode1.Location = new System.Drawing.Point(195, 330);
            this.btnHoursMode1.Name = "btnHoursMode1";
            this.btnHoursMode1.Size = new System.Drawing.Size(63, 41);
            this.btnHoursMode1.TabIndex = 8;
            this.btnHoursMode1.UseVisualStyleBackColor = false;
            this.btnHoursMode1.Click += new System.EventHandler(this.btnHoursMode1_Click);
            // 
            // btnHoursMode2
            // 
            this.btnHoursMode2.BackColor = System.Drawing.Color.PowderBlue;
            this.btnHoursMode2.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoursMode2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHoursMode2.ImageIndex = 1;
            this.btnHoursMode2.ImageList = this.TimeIcons;
            this.btnHoursMode2.Location = new System.Drawing.Point(295, 330);
            this.btnHoursMode2.Name = "btnHoursMode2";
            this.btnHoursMode2.Size = new System.Drawing.Size(60, 41);
            this.btnHoursMode2.TabIndex = 9;
            this.btnHoursMode2.UseVisualStyleBackColor = false;
            this.btnHoursMode2.Click += new System.EventHandler(this.btnHoursMode2_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnStopWatch
            // 
            this.btnStopWatch.ImageIndex = 3;
            this.btnStopWatch.ImageList = this.TimeIcons;
            this.btnStopWatch.Location = new System.Drawing.Point(276, 41);
            this.btnStopWatch.Name = "btnStopWatch";
            this.btnStopWatch.Size = new System.Drawing.Size(79, 55);
            this.btnStopWatch.TabIndex = 11;
            this.btnStopWatch.UseVisualStyleBackColor = true;
            this.btnStopWatch.Click += new System.EventHandler(this.btnStopWatch_Click);
            // 
            // btnTimer
            // 
            this.btnTimer.ImageIndex = 4;
            this.btnTimer.ImageList = this.TimeIcons;
            this.btnTimer.Location = new System.Drawing.Point(164, 41);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(75, 55);
            this.btnTimer.TabIndex = 12;
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // frmManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(584, 434);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnStopWatch);
            this.Controls.Add(this.btnHoursMode2);
            this.Controls.Add(this.btnHoursMode1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblShortDayName);
            this.Controls.Add(this.lblPMAM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.lblMinute);
            this.Controls.Add(this.lblHour);
            this.Name = "frmManager";
            this.Text = "Time Manager";
            this.Load += new System.EventHandler(this.frmManager_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList TimeIcons;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.Label lblMinute;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPMAM;
        private System.Windows.Forms.Label lblShortDayName;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnHoursMode1;
        private System.Windows.Forms.Button btnHoursMode2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button btnStopWatch;
        private System.Windows.Forms.Button btnTimer;
    }
}

