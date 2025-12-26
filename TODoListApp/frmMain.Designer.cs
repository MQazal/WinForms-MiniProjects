namespace ToDoListApp
{
    partial class frmMain
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbTask = new System.Windows.Forms.TextBox();
            this.clbTasks = new System.Windows.Forms.CheckedListBox();
            this.btClearBox = new System.Windows.Forms.Button();
            this.btUncheckedBox = new System.Windows.Forms.Button();
            this.btCheckedBox = new System.Windows.Forms.Button();
            this.btDeleteFirstTask = new System.Windows.Forms.Button();
            this.btAddTask = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbPending = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbCompleted = new System.Windows.Forms.Label();
            this.btShowCheckedTasks = new System.Windows.Forms.Button();
            this.DeleteCheckedTasks = new System.Windows.Forms.Button();
            this.btDeleteLastTask = new System.Windows.Forms.Button();
            this.cbTasks = new System.Windows.Forms.ComboBox();
            this.btDeleteIndexByComboBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(691, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 103);
            this.label1.TabIndex = 0;
            this.label1.Text = "To Do List";
            // 
            // tbTask
            // 
            this.tbTask.BackColor = System.Drawing.SystemColors.Menu;
            this.tbTask.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbTask.Font = new System.Drawing.Font("Segoe UI Variable Text", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTask.Location = new System.Drawing.Point(609, 149);
            this.tbTask.MaxLength = 1000;
            this.tbTask.Name = "tbTask";
            this.tbTask.Size = new System.Drawing.Size(501, 46);
            this.tbTask.TabIndex = 1;
            this.tbTask.Enter += new System.EventHandler(this.TypeTask);
            this.tbTask.Leave += new System.EventHandler(this.LeaveTaskBox);
            // 
            // clbTasks
            // 
            this.clbTasks.BackColor = System.Drawing.SystemColors.Menu;
            this.clbTasks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clbTasks.Font = new System.Drawing.Font("Segoe Print", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbTasks.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.clbTasks.FormattingEnabled = true;
            this.clbTasks.Location = new System.Drawing.Point(609, 232);
            this.clbTasks.Name = "clbTasks";
            this.clbTasks.Size = new System.Drawing.Size(501, 272);
            this.clbTasks.TabIndex = 3;
            this.clbTasks.SelectedIndexChanged += new System.EventHandler(this.clbTasks_SelectedIndexChanged);
            // 
            // btClearBox
            // 
            this.btClearBox.BackgroundImage = global::ToDoListApp.Properties.Resources.Clear;
            this.btClearBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btClearBox.Location = new System.Drawing.Point(1000, 557);
            this.btClearBox.Name = "btClearBox";
            this.btClearBox.Size = new System.Drawing.Size(35, 36);
            this.btClearBox.TabIndex = 9;
            this.btClearBox.Tag = "Clear";
            this.btClearBox.UseVisualStyleBackColor = true;
            this.btClearBox.Click += new System.EventHandler(this.btClearBox_Click);
            this.btClearBox.MouseHover += new System.EventHandler(this.ShowButtonFunction);
            // 
            // btUncheckedBox
            // 
            this.btUncheckedBox.BackgroundImage = global::ToDoListApp.Properties.Resources.Unchecked;
            this.btUncheckedBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btUncheckedBox.Location = new System.Drawing.Point(1000, 640);
            this.btUncheckedBox.Name = "btUncheckedBox";
            this.btUncheckedBox.Size = new System.Drawing.Size(35, 33);
            this.btUncheckedBox.TabIndex = 8;
            this.btUncheckedBox.Tag = "UncheckAll";
            this.btUncheckedBox.UseVisualStyleBackColor = true;
            this.btUncheckedBox.Click += new System.EventHandler(this.btUncheckedBox_Click);
            this.btUncheckedBox.MouseHover += new System.EventHandler(this.ShowButtonFunction);
            // 
            // btCheckedBox
            // 
            this.btCheckedBox.BackgroundImage = global::ToDoListApp.Properties.Resources.Checked;
            this.btCheckedBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btCheckedBox.Location = new System.Drawing.Point(917, 640);
            this.btCheckedBox.Name = "btCheckedBox";
            this.btCheckedBox.Size = new System.Drawing.Size(35, 33);
            this.btCheckedBox.TabIndex = 7;
            this.btCheckedBox.Tag = "CheckAll";
            this.btCheckedBox.UseVisualStyleBackColor = true;
            this.btCheckedBox.Click += new System.EventHandler(this.btCheckedBox_Click);
            this.btCheckedBox.MouseHover += new System.EventHandler(this.ShowButtonFunction);
            // 
            // btDeleteFirstTask
            // 
            this.btDeleteFirstTask.BackgroundImage = global::ToDoListApp.Properties.Resources.Trash_logo;
            this.btDeleteFirstTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btDeleteFirstTask.Location = new System.Drawing.Point(917, 557);
            this.btDeleteFirstTask.Name = "btDeleteFirstTask";
            this.btDeleteFirstTask.Size = new System.Drawing.Size(35, 36);
            this.btDeleteFirstTask.TabIndex = 6;
            this.btDeleteFirstTask.Tag = "Delete";
            this.btDeleteFirstTask.UseVisualStyleBackColor = true;
            this.btDeleteFirstTask.Click += new System.EventHandler(this.btDeleteFirstTask_Click);
            this.btDeleteFirstTask.MouseHover += new System.EventHandler(this.ShowButtonFunction);
            // 
            // btAddTask
            // 
            this.btAddTask.BackgroundImage = global::ToDoListApp.Properties.Resources.Add_Icon;
            this.btAddTask.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btAddTask.Location = new System.Drawing.Point(1129, 149);
            this.btAddTask.Name = "btAddTask";
            this.btAddTask.Size = new System.Drawing.Size(34, 35);
            this.btAddTask.TabIndex = 1;
            this.btAddTask.Tag = "Add";
            this.btAddTask.UseVisualStyleBackColor = true;
            this.btAddTask.Click += new System.EventHandler(this.btAddTask_Click);
            this.btAddTask.MouseHover += new System.EventHandler(this.ShowButtonFunction);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(603, 558);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 35);
            this.label2.TabIndex = 10;
            this.label2.Text = "Pending: ";
            // 
            // lbPending
            // 
            this.lbPending.AutoSize = true;
            this.lbPending.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPending.ForeColor = System.Drawing.Color.Navy;
            this.lbPending.Location = new System.Drawing.Point(774, 558);
            this.lbPending.Name = "lbPending";
            this.lbPending.Size = new System.Drawing.Size(31, 35);
            this.lbPending.TabIndex = 11;
            this.lbPending.Tag = "Pending";
            this.lbPending.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkGreen;
            this.label4.Location = new System.Drawing.Point(599, 609);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 35);
            this.label4.TabIndex = 12;
            this.label4.Text = "Completed: ";
            // 
            // lbCompleted
            // 
            this.lbCompleted.AutoSize = true;
            this.lbCompleted.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCompleted.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbCompleted.Location = new System.Drawing.Point(774, 609);
            this.lbCompleted.Name = "lbCompleted";
            this.lbCompleted.Size = new System.Drawing.Size(31, 35);
            this.lbCompleted.TabIndex = 13;
            this.lbCompleted.Tag = "Completed";
            this.lbCompleted.Text = "0";
            // 
            // btShowCheckedTasks
            // 
            this.btShowCheckedTasks.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btShowCheckedTasks.Location = new System.Drawing.Point(1067, 537);
            this.btShowCheckedTasks.Name = "btShowCheckedTasks";
            this.btShowCheckedTasks.Size = new System.Drawing.Size(241, 36);
            this.btShowCheckedTasks.TabIndex = 14;
            this.btShowCheckedTasks.Text = "Show Checked Items";
            this.btShowCheckedTasks.UseVisualStyleBackColor = true;
            this.btShowCheckedTasks.Click += new System.EventHandler(this.btShowCheckedTasks_Click);
            // 
            // DeleteCheckedTasks
            // 
            this.DeleteCheckedTasks.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteCheckedTasks.Location = new System.Drawing.Point(1067, 653);
            this.DeleteCheckedTasks.Name = "DeleteCheckedTasks";
            this.DeleteCheckedTasks.Size = new System.Drawing.Size(269, 50);
            this.DeleteCheckedTasks.TabIndex = 15;
            this.DeleteCheckedTasks.Text = "Delete Checked Tasks";
            this.DeleteCheckedTasks.UseVisualStyleBackColor = true;
            this.DeleteCheckedTasks.Click += new System.EventHandler(this.DeleteCheckedTasks_Click);
            // 
            // btDeleteLastTask
            // 
            this.btDeleteLastTask.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteLastTask.Location = new System.Drawing.Point(1067, 591);
            this.btDeleteLastTask.Name = "btDeleteLastTask";
            this.btDeleteLastTask.Size = new System.Drawing.Size(195, 50);
            this.btDeleteLastTask.TabIndex = 16;
            this.btDeleteLastTask.Text = "Delete Last Task";
            this.btDeleteLastTask.UseVisualStyleBackColor = true;
            this.btDeleteLastTask.Click += new System.EventHandler(this.btDeleteLastTask_Click);
            // 
            // cbTasks
            // 
            this.cbTasks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbTasks.Font = new System.Drawing.Font("Nirmala UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTasks.FormattingEnabled = true;
            this.cbTasks.Location = new System.Drawing.Point(1215, 151);
            this.cbTasks.Name = "cbTasks";
            this.cbTasks.Size = new System.Drawing.Size(353, 38);
            this.cbTasks.TabIndex = 17;
            // 
            // btDeleteIndexByComboBox
            // 
            this.btDeleteIndexByComboBox.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeleteIndexByComboBox.Location = new System.Drawing.Point(1215, 215);
            this.btDeleteIndexByComboBox.Name = "btDeleteIndexByComboBox";
            this.btDeleteIndexByComboBox.Size = new System.Drawing.Size(365, 41);
            this.btDeleteIndexByComboBox.TabIndex = 18;
            this.btDeleteIndexByComboBox.Text = "Delete task you choose";
            this.btDeleteIndexByComboBox.UseVisualStyleBackColor = true;
            this.btDeleteIndexByComboBox.Click += new System.EventHandler(this.btDeleteIndexByComboBox_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(1719, 739);
            this.Controls.Add(this.btDeleteIndexByComboBox);
            this.Controls.Add(this.cbTasks);
            this.Controls.Add(this.btDeleteLastTask);
            this.Controls.Add(this.DeleteCheckedTasks);
            this.Controls.Add(this.btShowCheckedTasks);
            this.Controls.Add(this.lbCompleted);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbPending);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btClearBox);
            this.Controls.Add(this.btUncheckedBox);
            this.Controls.Add(this.btCheckedBox);
            this.Controls.Add(this.btDeleteFirstTask);
            this.Controls.Add(this.clbTasks);
            this.Controls.Add(this.btAddTask);
            this.Controls.Add(this.tbTask);
            this.Controls.Add(this.label1);
            this.Name = "frmMain";
            this.Text = "To Do List";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTask;
        private System.Windows.Forms.Button btAddTask;
        private System.Windows.Forms.CheckedListBox clbTasks;
        private System.Windows.Forms.Button btDeleteFirstTask;
        private System.Windows.Forms.Button btCheckedBox;
        private System.Windows.Forms.Button btUncheckedBox;
        private System.Windows.Forms.Button btClearBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbPending;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbCompleted;
        private System.Windows.Forms.Button btShowCheckedTasks;
        private System.Windows.Forms.Button DeleteCheckedTasks;
        private System.Windows.Forms.Button btDeleteLastTask;
        private System.Windows.Forms.ComboBox cbTasks;
        private System.Windows.Forms.Button btDeleteIndexByComboBox;
    }
}

