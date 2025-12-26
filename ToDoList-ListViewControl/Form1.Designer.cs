namespace ProgressPersentageApp
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
            this.tbMajorTask = new System.Windows.Forms.TextBox();
            this.btAddMajorTask = new System.Windows.Forms.Button();
            this.tvTasks = new System.Windows.Forms.TreeView();
            this.btCrossOutTask = new System.Windows.Forms.Button();
            this.btClearTree = new System.Windows.Forms.Button();
            this.btCheckTree = new System.Windows.Forms.Button();
            this.btUncheckTree = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbPercentage = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPending = new System.Windows.Forms.Label();
            this.lbCompleted = new System.Windows.Forms.Label();
            this.cbMajorTasks = new System.Windows.Forms.ComboBox();
            this.tbSubTask = new System.Windows.Forms.TextBox();
            this.btAddSubTask = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btDeleteTask = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbMinutes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSeconds = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.SuspendLayout();
            // 
            // tbMajorTask
            // 
            this.tbMajorTask.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMajorTask.Location = new System.Drawing.Point(428, 156);
            this.tbMajorTask.Name = "tbMajorTask";
            this.tbMajorTask.Size = new System.Drawing.Size(417, 36);
            this.tbMajorTask.TabIndex = 1;
            this.tbMajorTask.Tag = "MajorT";
            this.tbMajorTask.Enter += new System.EventHandler(this.TypeInBox);
            this.tbMajorTask.Leave += new System.EventHandler(this.LeaveBox);
            // 
            // btAddMajorTask
            // 
            this.btAddMajorTask.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAddMajorTask.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAddMajorTask.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddMajorTask.Location = new System.Drawing.Point(865, 147);
            this.btAddMajorTask.Name = "btAddMajorTask";
            this.btAddMajorTask.Size = new System.Drawing.Size(46, 45);
            this.btAddMajorTask.TabIndex = 1;
            this.btAddMajorTask.Text = "+";
            this.btAddMajorTask.UseVisualStyleBackColor = false;
            this.btAddMajorTask.Click += new System.EventHandler(this.btAddMajorTask_Click);
            // 
            // tvTasks
            // 
            this.tvTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvTasks.CheckBoxes = true;
            this.tvTasks.Font = new System.Drawing.Font("Lucida Sans", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvTasks.HotTracking = true;
            this.tvTasks.Location = new System.Drawing.Point(428, 223);
            this.tvTasks.Name = "tvTasks";
            this.tvTasks.Size = new System.Drawing.Size(590, 358);
            this.tvTasks.TabIndex = 2;
            // 
            // btCrossOutTask
            // 
            this.btCrossOutTask.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCrossOutTask.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCrossOutTask.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCrossOutTask.Location = new System.Drawing.Point(1062, 364);
            this.btCrossOutTask.Name = "btCrossOutTask";
            this.btCrossOutTask.Size = new System.Drawing.Size(279, 48);
            this.btCrossOutTask.TabIndex = 3;
            this.btCrossOutTask.Text = "Cross out checked task(s)";
            this.btCrossOutTask.UseVisualStyleBackColor = false;
            this.btCrossOutTask.Click += new System.EventHandler(this.btCrossOutTask_Click);
            // 
            // btClearTree
            // 
            this.btClearTree.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btClearTree.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btClearTree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClearTree.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClearTree.Location = new System.Drawing.Point(1062, 608);
            this.btClearTree.Name = "btClearTree";
            this.btClearTree.Size = new System.Drawing.Size(104, 46);
            this.btClearTree.TabIndex = 4;
            this.btClearTree.Text = "Clear";
            this.btClearTree.UseVisualStyleBackColor = false;
            this.btClearTree.Click += new System.EventHandler(this.btClearTree_Click);
            // 
            // btCheckTree
            // 
            this.btCheckTree.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCheckTree.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCheckTree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCheckTree.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheckTree.Location = new System.Drawing.Point(1062, 494);
            this.btCheckTree.Name = "btCheckTree";
            this.btCheckTree.Size = new System.Drawing.Size(135, 40);
            this.btCheckTree.TabIndex = 5;
            this.btCheckTree.Text = "Check All";
            this.btCheckTree.UseVisualStyleBackColor = false;
            this.btCheckTree.Click += new System.EventHandler(this.btCheckTree_Click);
            // 
            // btUncheckTree
            // 
            this.btUncheckTree.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btUncheckTree.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btUncheckTree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btUncheckTree.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUncheckTree.Location = new System.Drawing.Point(1062, 550);
            this.btUncheckTree.Name = "btUncheckTree";
            this.btUncheckTree.Size = new System.Drawing.Size(140, 46);
            this.btUncheckTree.TabIndex = 6;
            this.btUncheckTree.Text = "Uncheck All";
            this.btUncheckTree.UseVisualStyleBackColor = false;
            this.btUncheckTree.Click += new System.EventHandler(this.btUncheckTree_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(428, 608);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(483, 38);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(711, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Do List";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPercentage
            // 
            this.lbPercentage.AutoSize = true;
            this.lbPercentage.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercentage.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbPercentage.Location = new System.Drawing.Point(928, 608);
            this.lbPercentage.Name = "lbPercentage";
            this.lbPercentage.Size = new System.Drawing.Size(43, 29);
            this.lbPercentage.TabIndex = 9;
            this.lbPercentage.Text = "0%";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(444, 665);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 35);
            this.label3.TabIndex = 10;
            this.label3.Text = "Pending:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(444, 716);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 35);
            this.label4.TabIndex = 11;
            this.label4.Text = "Completed:";
            // 
            // lbPending
            // 
            this.lbPending.AutoSize = true;
            this.lbPending.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPending.Location = new System.Drawing.Point(613, 665);
            this.lbPending.Name = "lbPending";
            this.lbPending.Size = new System.Drawing.Size(31, 35);
            this.lbPending.TabIndex = 12;
            this.lbPending.Text = "0";
            // 
            // lbCompleted
            // 
            this.lbCompleted.AutoSize = true;
            this.lbCompleted.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompleted.ForeColor = System.Drawing.Color.Crimson;
            this.lbCompleted.Location = new System.Drawing.Point(613, 716);
            this.lbCompleted.Name = "lbCompleted";
            this.lbCompleted.Size = new System.Drawing.Size(31, 35);
            this.lbCompleted.TabIndex = 13;
            this.lbCompleted.Text = "0";
            // 
            // cbMajorTasks
            // 
            this.cbMajorTasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMajorTasks.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbMajorTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMajorTasks.FormattingEnabled = true;
            this.cbMajorTasks.Location = new System.Drawing.Point(1062, 223);
            this.cbMajorTasks.Name = "cbMajorTasks";
            this.cbMajorTasks.Size = new System.Drawing.Size(426, 37);
            this.cbMajorTasks.TabIndex = 14;
            // 
            // tbSubTask
            // 
            this.tbSubTask.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSubTask.Location = new System.Drawing.Point(1062, 285);
            this.tbSubTask.Name = "tbSubTask";
            this.tbSubTask.Size = new System.Drawing.Size(417, 36);
            this.tbSubTask.TabIndex = 15;
            this.tbSubTask.Tag = "SubT";
            this.tbSubTask.Enter += new System.EventHandler(this.TypeInBox);
            this.tbSubTask.Leave += new System.EventHandler(this.LeaveBox);
            // 
            // btAddSubTask
            // 
            this.btAddSubTask.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btAddSubTask.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btAddSubTask.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddSubTask.Location = new System.Drawing.Point(1498, 276);
            this.btAddSubTask.Name = "btAddSubTask";
            this.btAddSubTask.Size = new System.Drawing.Size(47, 45);
            this.btAddSubTask.TabIndex = 16;
            this.btAddSubTask.Text = "+";
            this.btAddSubTask.UseVisualStyleBackColor = false;
            this.btAddSubTask.Click += new System.EventHandler(this.btAddSubTask_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simple Bold Jut Out", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(1145, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 40);
            this.label2.TabIndex = 17;
            this.label2.Text = "Choose Major Task";
            // 
            // btDeleteTask
            // 
            this.btDeleteTask.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btDeleteTask.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btDeleteTask.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteTask.Location = new System.Drawing.Point(1062, 429);
            this.btDeleteTask.Name = "btDeleteTask";
            this.btDeleteTask.Size = new System.Drawing.Size(249, 48);
            this.btDeleteTask.TabIndex = 18;
            this.btDeleteTask.Text = "Delete checked task(s)";
            this.btDeleteTask.UseVisualStyleBackColor = false;
            this.btDeleteTask.Click += new System.EventHandler(this.btDeleteTask_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbMinutes
            // 
            this.lbMinutes.AutoSize = true;
            this.lbMinutes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMinutes.Font = new System.Drawing.Font("Urdu Typesetting", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMinutes.Location = new System.Drawing.Point(66, 41);
            this.lbMinutes.Name = "lbMinutes";
            this.lbMinutes.Size = new System.Drawing.Size(45, 66);
            this.lbMinutes.TabIndex = 19;
            this.lbMinutes.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Urdu Typesetting", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(115, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 66);
            this.label5.TabIndex = 20;
            this.label5.Text = ":";
            // 
            // lbSeconds
            // 
            this.lbSeconds.AutoSize = true;
            this.lbSeconds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbSeconds.Font = new System.Drawing.Font("Urdu Typesetting", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSeconds.Location = new System.Drawing.Point(155, 41);
            this.lbSeconds.Name = "lbSeconds";
            this.lbSeconds.Size = new System.Drawing.Size(45, 66);
            this.lbSeconds.TabIndex = 21;
            this.lbSeconds.Text = "0";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1682, 750);
            this.Controls.Add(this.lbSeconds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbMinutes);
            this.Controls.Add(this.btDeleteTask);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btAddSubTask);
            this.Controls.Add(this.tbSubTask);
            this.Controls.Add(this.cbMajorTasks);
            this.Controls.Add(this.lbCompleted);
            this.Controls.Add(this.lbPending);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbPercentage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btUncheckTree);
            this.Controls.Add(this.btCheckTree);
            this.Controls.Add(this.btClearTree);
            this.Controls.Add(this.btCrossOutTask);
            this.Controls.Add(this.tvTasks);
            this.Controls.Add(this.btAddMajorTask);
            this.Controls.Add(this.tbMajorTask);
            this.Name = "Form1";
            this.Text = "frm_To-Do-List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbMajorTask;
        private System.Windows.Forms.Button btAddMajorTask;
        private System.Windows.Forms.TreeView tvTasks;
        private System.Windows.Forms.Button btCrossOutTask;
        private System.Windows.Forms.Button btClearTree;
        private System.Windows.Forms.Button btCheckTree;
        private System.Windows.Forms.Button btUncheckTree;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbPercentage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPending;
        private System.Windows.Forms.Label lbCompleted;
        private System.Windows.Forms.ComboBox cbMajorTasks;
        private System.Windows.Forms.TextBox tbSubTask;
        private System.Windows.Forms.Button btAddSubTask;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btDeleteTask;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbMinutes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSeconds;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

