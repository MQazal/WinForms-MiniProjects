namespace TimeManager
{
    partial class frmTimer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTimer));
            this.btnManager = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.TimeIcons = new System.Windows.Forms.ImageList(this.components);
            this.btnReset = new System.Windows.Forms.Button();
            this.nmHour = new System.Windows.Forms.NumericUpDown();
            this.nmMinute = new System.Windows.Forms.NumericUpDown();
            this.nmSecond = new System.Windows.Forms.NumericUpDown();
            this.notifyFinishTimer = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nmHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSecond)).BeginInit();
            this.SuspendLayout();
            // 
            // btnManager
            // 
            this.btnManager.Image = global::TimeManager.Properties.Resources.Clock;
            this.btnManager.Location = new System.Drawing.Point(243, 83);
            this.btnManager.Name = "btnManager";
            this.btnManager.Size = new System.Drawing.Size(71, 61);
            this.btnManager.TabIndex = 0;
            this.btnManager.UseVisualStyleBackColor = true;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnStart
            // 
            this.btnStart.ImageIndex = 1;
            this.btnStart.ImageList = this.TimeIcons;
            this.btnStart.Location = new System.Drawing.Point(185, 296);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(56, 50);
            this.btnStart.TabIndex = 3;
            this.btnStart.Tag = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // TimeIcons
            // 
            this.TimeIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("TimeIcons.ImageStream")));
            this.TimeIcons.TransparentColor = System.Drawing.Color.Transparent;
            this.TimeIcons.Images.SetKeyName(0, "Clock.png");
            this.TimeIcons.Images.SetKeyName(1, "Start2.png");
            this.TimeIcons.Images.SetKeyName(2, "reset.png");
            this.TimeIcons.Images.SetKeyName(3, "pause3.png");
            // 
            // btnReset
            // 
            this.btnReset.ImageIndex = 2;
            this.btnReset.ImageList = this.TimeIcons;
            this.btnReset.Location = new System.Drawing.Point(312, 296);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(60, 50);
            this.btnReset.TabIndex = 4;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // nmHour
            // 
            this.nmHour.BackColor = System.Drawing.Color.Silver;
            this.nmHour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmHour.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmHour.Location = new System.Drawing.Point(95, 204);
            this.nmHour.Name = "nmHour";
            this.nmHour.Size = new System.Drawing.Size(105, 39);
            this.nmHour.TabIndex = 0;
            this.nmHour.Tag = "0";
            this.nmHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmHour.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TypingValues);
            // 
            // nmMinute
            // 
            this.nmMinute.BackColor = System.Drawing.Color.Silver;
            this.nmMinute.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmMinute.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmMinute.Location = new System.Drawing.Point(238, 204);
            this.nmMinute.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nmMinute.Name = "nmMinute";
            this.nmMinute.Size = new System.Drawing.Size(105, 39);
            this.nmMinute.TabIndex = 1;
            this.nmMinute.Tag = "0";
            this.nmMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmMinute.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TypingValues);
            // 
            // nmSecond
            // 
            this.nmSecond.BackColor = System.Drawing.Color.Silver;
            this.nmSecond.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nmSecond.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmSecond.Location = new System.Drawing.Point(386, 204);
            this.nmSecond.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nmSecond.Name = "nmSecond";
            this.nmSecond.Size = new System.Drawing.Size(105, 39);
            this.nmSecond.TabIndex = 2;
            this.nmSecond.Tag = "0";
            this.nmSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmSecond.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TypingValues);
            // 
            // notifyFinishTimer
            // 
            this.notifyFinishTimer.Text = "notifyIcon1";
            this.notifyFinishTimer.Visible = true;
            // 
            // frmTimer
            // 
            this.AcceptButton = this.btnStart;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(584, 434);
            this.Controls.Add(this.nmSecond);
            this.Controls.Add(this.nmMinute);
            this.Controls.Add(this.nmHour);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnManager);
            this.Name = "frmTimer";
            this.Text = "frmTimer";
            this.Load += new System.EventHandler(this.frmTimer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmMinute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmSecond)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ImageList TimeIcons;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.NumericUpDown nmHour;
        private System.Windows.Forms.NumericUpDown nmMinute;
        private System.Windows.Forms.NumericUpDown nmSecond;
        private System.Windows.Forms.NotifyIcon notifyFinishTimer;
    }
}