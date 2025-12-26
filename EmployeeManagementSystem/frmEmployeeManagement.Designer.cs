namespace EmployeeManagementSystem
{
    partial class frmEmployeeManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeManagement));
            this.livwEmployess = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tWatch = new System.Windows.Forms.Timer(this.components);
            this.mskHour = new System.Windows.Forms.MaskedTextBox();
            this.mskMinute = new System.Windows.Forms.MaskedTextBox();
            this.mskSecond = new System.Windows.Forms.MaskedTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txbxAMPM = new System.Windows.Forms.TextBox();
            this.mstManagement = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAboutUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // livwEmployess
            // 
            this.livwEmployess.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.livwEmployess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.livwEmployess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14});
            this.livwEmployess.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.livwEmployess.FullRowSelect = true;
            this.livwEmployess.GridLines = true;
            this.livwEmployess.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.livwEmployess.HideSelection = false;
            this.livwEmployess.LargeImageList = this.imageList1;
            this.livwEmployess.Location = new System.Drawing.Point(86, 128);
            this.livwEmployess.Name = "livwEmployess";
            this.livwEmployess.Size = new System.Drawing.Size(1681, 515);
            this.livwEmployess.SmallImageList = this.imageList1;
            this.livwEmployess.TabIndex = 12;
            this.livwEmployess.UseCompatibleStateImageBehavior = false;
            this.livwEmployess.View = System.Windows.Forms.View.Details;
            this.livwEmployess.SelectedIndexChanged += new System.EventHandler(this.SelectEmployee);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "First Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Last Name";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Age";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 70;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Birth Date";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Job";
            this.columnHeader6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader6.Width = 400;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Department";
            this.columnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader7.Width = 370;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Salary SAR";
            this.columnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader8.Width = 140;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Hiring Date";
            this.columnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader9.Width = 200;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Gender";
            this.columnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader10.Width = 130;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Work From";
            this.columnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader11.Width = 160;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Work To";
            this.columnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader12.Width = 160;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Phone Number";
            this.columnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader13.Width = 300;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Email Address";
            this.columnHeader14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader14.Width = 400;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Male Employee.jfif");
            this.imageList1.Images.SetKeyName(1, "Female Employee.jfif");
            // 
            // tWatch
            // 
            this.tWatch.Enabled = true;
            this.tWatch.Interval = 1000;
            this.tWatch.Tick += new System.EventHandler(this.tWatch_Tick);
            // 
            // mskHour
            // 
            this.mskHour.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskHour.ForeColor = System.Drawing.Color.DarkGreen;
            this.mskHour.Location = new System.Drawing.Point(1445, 662);
            this.mskHour.Name = "mskHour";
            this.mskHour.ReadOnly = true;
            this.mskHour.Size = new System.Drawing.Size(71, 39);
            this.mskHour.TabIndex = 19;
            this.mskHour.Text = "00";
            this.mskHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskMinute
            // 
            this.mskMinute.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskMinute.ForeColor = System.Drawing.Color.DarkGreen;
            this.mskMinute.Location = new System.Drawing.Point(1522, 662);
            this.mskMinute.Name = "mskMinute";
            this.mskMinute.ReadOnly = true;
            this.mskMinute.Size = new System.Drawing.Size(70, 39);
            this.mskMinute.TabIndex = 20;
            this.mskMinute.Text = "00";
            this.mskMinute.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskSecond
            // 
            this.mskSecond.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskSecond.ForeColor = System.Drawing.Color.DarkGreen;
            this.mskSecond.Location = new System.Drawing.Point(1598, 662);
            this.mskSecond.Name = "mskSecond";
            this.mskSecond.ReadOnly = true;
            this.mskSecond.Size = new System.Drawing.Size(69, 39);
            this.mskSecond.TabIndex = 21;
            this.mskSecond.Text = "00";
            this.mskSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft YaHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.Color.DarkCyan;
            this.lblDate.Location = new System.Drawing.Point(80, 83);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(134, 31);
            this.lblDate.TabIndex = 22;
            this.lblDate.Text = "Date Now";
            // 
            // txbxAMPM
            // 
            this.txbxAMPM.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxAMPM.Location = new System.Drawing.Point(1673, 662);
            this.txbxAMPM.Name = "txbxAMPM";
            this.txbxAMPM.ReadOnly = true;
            this.txbxAMPM.Size = new System.Drawing.Size(56, 39);
            this.txbxAMPM.TabIndex = 23;
            this.txbxAMPM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mstManagement
            // 
            this.mstManagement.BackColor = System.Drawing.Color.Lavender;
            this.mstManagement.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mstManagement.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.mstManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.addNewEmployeeToolStripMenuItem,
            this.showEmployeeToolStripMenuItem,
            this.updateEmployeeToolStripMenuItem,
            this.deleteEmployeeToolStripMenuItem,
            this.clearListToolStripMenuItem,
            this.searchAboutUserToolStripMenuItem});
            this.mstManagement.Location = new System.Drawing.Point(0, 0);
            this.mstManagement.Name = "mstManagement";
            this.mstManagement.Size = new System.Drawing.Size(1809, 38);
            this.mstManagement.TabIndex = 25;
            this.mstManagement.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.fileToolStripMenuItem.Image = global::EmployeeManagementSystem.Properties.Resources.File;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(100, 34);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Image = global::EmployeeManagementSystem.Properties.Resources.Logout;
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(166, 36);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // addNewEmployeeToolStripMenuItem
            // 
            this.addNewEmployeeToolStripMenuItem.Image = global::EmployeeManagementSystem.Properties.Resources.User;
            this.addNewEmployeeToolStripMenuItem.Name = "addNewEmployeeToolStripMenuItem";
            this.addNewEmployeeToolStripMenuItem.Size = new System.Drawing.Size(244, 34);
            this.addNewEmployeeToolStripMenuItem.Text = "Add New Employee";
            this.addNewEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addNewEmployeeToolStripMenuItem_Click);
            // 
            // showEmployeeToolStripMenuItem
            // 
            this.showEmployeeToolStripMenuItem.Image = global::EmployeeManagementSystem.Properties.Resources.Users_Icon;
            this.showEmployeeToolStripMenuItem.Name = "showEmployeeToolStripMenuItem";
            this.showEmployeeToolStripMenuItem.Size = new System.Drawing.Size(208, 34);
            this.showEmployeeToolStripMenuItem.Text = "Show Employee";
            this.showEmployeeToolStripMenuItem.Click += new System.EventHandler(this.showEmployeeToolStripMenuItem_Click);
            // 
            // updateEmployeeToolStripMenuItem
            // 
            this.updateEmployeeToolStripMenuItem.Image = global::EmployeeManagementSystem.Properties.Resources.Update_User;
            this.updateEmployeeToolStripMenuItem.Name = "updateEmployeeToolStripMenuItem";
            this.updateEmployeeToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
            this.updateEmployeeToolStripMenuItem.Text = "Update Employee";
            this.updateEmployeeToolStripMenuItem.Click += new System.EventHandler(this.updateEmployeeToolStripMenuItem_Click);
            // 
            // deleteEmployeeToolStripMenuItem
            // 
            this.deleteEmployeeToolStripMenuItem.Image = global::EmployeeManagementSystem.Properties.Resources.Delete_User;
            this.deleteEmployeeToolStripMenuItem.Name = "deleteEmployeeToolStripMenuItem";
            this.deleteEmployeeToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
            this.deleteEmployeeToolStripMenuItem.Text = "Delete Employee";
            this.deleteEmployeeToolStripMenuItem.Click += new System.EventHandler(this.deleteEmployeeToolStripMenuItem_Click);
            // 
            // clearListToolStripMenuItem
            // 
            this.clearListToolStripMenuItem.Image = global::EmployeeManagementSystem.Properties.Resources.Clear_Users;
            this.clearListToolStripMenuItem.Name = "clearListToolStripMenuItem";
            this.clearListToolStripMenuItem.Size = new System.Drawing.Size(172, 34);
            this.clearListToolStripMenuItem.Text = "Clear List";
            this.clearListToolStripMenuItem.Click += new System.EventHandler(this.clearListToolStripMenuItem_Click);
            // 
            // searchAboutUserToolStripMenuItem
            // 
            this.searchAboutUserToolStripMenuItem.Image = global::EmployeeManagementSystem.Properties.Resources.Find_User;
            this.searchAboutUserToolStripMenuItem.Name = "searchAboutUserToolStripMenuItem";
            this.searchAboutUserToolStripMenuItem.Size = new System.Drawing.Size(256, 34);
            this.searchAboutUserToolStripMenuItem.Text = "Search About User";
            this.searchAboutUserToolStripMenuItem.Click += new System.EventHandler(this.searchAboutUserToolStripMenuItem_Click);
            // 
            // frmEmployeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1809, 714);
            this.Controls.Add(this.txbxAMPM);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.mskSecond);
            this.Controls.Add(this.mskMinute);
            this.Controls.Add(this.mskHour);
            this.Controls.Add(this.livwEmployess);
            this.Controls.Add(this.mstManagement);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "frmEmployeeManagement";
            this.Text = "frmEmployeeManagement";
            this.Load += new System.EventHandler(this.frmEmployeeManagement_Load);
            this.mstManagement.ResumeLayout(false);
            this.mstManagement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.ListView livwEmployess;
        public System.Windows.Forms.ColumnHeader columnHeader1;
        public System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ColumnHeader columnHeader3;
        public System.Windows.Forms.ColumnHeader columnHeader4;
        public System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.ColumnHeader columnHeader6;
        public System.Windows.Forms.ColumnHeader columnHeader7;
        public System.Windows.Forms.ColumnHeader columnHeader8;
        public System.Windows.Forms.ColumnHeader columnHeader9;
        public System.Windows.Forms.ColumnHeader columnHeader10;
        public System.Windows.Forms.ColumnHeader columnHeader11;
        public System.Windows.Forms.ColumnHeader columnHeader12;
        public System.Windows.Forms.ColumnHeader columnHeader13;
        public System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer tWatch;
        private System.Windows.Forms.MaskedTextBox mskHour;
        private System.Windows.Forms.MaskedTextBox mskMinute;
        private System.Windows.Forms.MaskedTextBox mskSecond;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txbxAMPM;
        private System.Windows.Forms.MenuStrip mstManagement;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchAboutUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}