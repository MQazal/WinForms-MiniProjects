namespace EmployeeManagementSystem
{
    partial class frmShowEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShowEmployee));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gbxEmployee = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.mbxToDate = new System.Windows.Forms.MaskedTextBox();
            this.tbxSalary = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.mbxFromDate = new System.Windows.Forms.MaskedTextBox();
            this.tbxHiringDate = new System.Windows.Forms.TextBox();
            this.tbxDepartment = new System.Windows.Forms.TextBox();
            this.tbxJob = new System.Windows.Forms.TextBox();
            this.tbxBirthDate = new System.Windows.Forms.TextBox();
            this.tbxGender = new System.Windows.Forms.TextBox();
            this.tbxAge = new System.Windows.Forms.TextBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pbxEmployee = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Male Employee.jfif");
            this.imageList1.Images.SetKeyName(1, "Female Employee.jfif");
            // 
            // gbxEmployee
            // 
            this.gbxEmployee.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbxEmployee.Controls.Add(this.label14);
            this.gbxEmployee.Controls.Add(this.label13);
            this.gbxEmployee.Controls.Add(this.mbxToDate);
            this.gbxEmployee.Controls.Add(this.tbxSalary);
            this.gbxEmployee.Controls.Add(this.tbxEmail);
            this.gbxEmployee.Controls.Add(this.tbxPhone);
            this.gbxEmployee.Controls.Add(this.mbxFromDate);
            this.gbxEmployee.Controls.Add(this.tbxHiringDate);
            this.gbxEmployee.Controls.Add(this.tbxDepartment);
            this.gbxEmployee.Controls.Add(this.tbxJob);
            this.gbxEmployee.Controls.Add(this.tbxBirthDate);
            this.gbxEmployee.Controls.Add(this.tbxGender);
            this.gbxEmployee.Controls.Add(this.tbxAge);
            this.gbxEmployee.Controls.Add(this.tbxName);
            this.gbxEmployee.Controls.Add(this.tbxID);
            this.gbxEmployee.Controls.Add(this.label12);
            this.gbxEmployee.Controls.Add(this.label11);
            this.gbxEmployee.Controls.Add(this.label10);
            this.gbxEmployee.Controls.Add(this.label9);
            this.gbxEmployee.Controls.Add(this.label8);
            this.gbxEmployee.Controls.Add(this.label7);
            this.gbxEmployee.Controls.Add(this.label6);
            this.gbxEmployee.Controls.Add(this.label5);
            this.gbxEmployee.Controls.Add(this.label4);
            this.gbxEmployee.Controls.Add(this.label3);
            this.gbxEmployee.Controls.Add(this.pbxEmployee);
            this.gbxEmployee.Controls.Add(this.label2);
            this.gbxEmployee.Controls.Add(this.label1);
            this.gbxEmployee.Font = new System.Drawing.Font("Monospac821 BT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxEmployee.Location = new System.Drawing.Point(102, 73);
            this.gbxEmployee.Name = "gbxEmployee";
            this.gbxEmployee.Size = new System.Drawing.Size(1603, 531);
            this.gbxEmployee.TabIndex = 13;
            this.gbxEmployee.TabStop = false;
            this.gbxEmployee.Text = "Employee Data";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1168, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 29);
            this.label14.TabIndex = 27;
            this.label14.Text = "To:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1168, 138);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 29);
            this.label13.TabIndex = 26;
            this.label13.Text = "From:";
            // 
            // mbxToDate
            // 
            this.mbxToDate.BackColor = System.Drawing.SystemColors.Control;
            this.mbxToDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mbxToDate.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbxToDate.Location = new System.Drawing.Point(1248, 176);
            this.mbxToDate.Mask = "00:00 PM";
            this.mbxToDate.Name = "mbxToDate";
            this.mbxToDate.Size = new System.Drawing.Size(124, 26);
            this.mbxToDate.TabIndex = 11;
            // 
            // tbxSalary
            // 
            this.tbxSalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxSalary.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSalary.ForeColor = System.Drawing.Color.DarkGreen;
            this.tbxSalary.Location = new System.Drawing.Point(683, 319);
            this.tbxSalary.Name = "tbxSalary";
            this.tbxSalary.ReadOnly = true;
            this.tbxSalary.Size = new System.Drawing.Size(130, 24);
            this.tbxSalary.TabIndex = 7;
            // 
            // tbxEmail
            // 
            this.tbxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxEmail.Location = new System.Drawing.Point(1145, 397);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.ReadOnly = true;
            this.tbxEmail.Size = new System.Drawing.Size(417, 29);
            this.tbxEmail.TabIndex = 13;
            this.tbxEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxPhone
            // 
            this.tbxPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxPhone.Location = new System.Drawing.Point(1145, 293);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.ReadOnly = true;
            this.tbxPhone.Size = new System.Drawing.Size(417, 29);
            this.tbxPhone.TabIndex = 12;
            this.tbxPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mbxFromDate
            // 
            this.mbxFromDate.BackColor = System.Drawing.SystemColors.Control;
            this.mbxFromDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mbxFromDate.Font = new System.Drawing.Font("Monospac821 BT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mbxFromDate.Location = new System.Drawing.Point(1248, 138);
            this.mbxFromDate.Mask = "00:00 \\AM";
            this.mbxFromDate.Name = "mbxFromDate";
            this.mbxFromDate.Size = new System.Drawing.Size(124, 26);
            this.mbxFromDate.TabIndex = 10;
            // 
            // tbxHiringDate
            // 
            this.tbxHiringDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxHiringDate.Location = new System.Drawing.Point(683, 441);
            this.tbxHiringDate.Name = "tbxHiringDate";
            this.tbxHiringDate.ReadOnly = true;
            this.tbxHiringDate.Size = new System.Drawing.Size(246, 29);
            this.tbxHiringDate.TabIndex = 8;
            this.tbxHiringDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxDepartment
            // 
            this.tbxDepartment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxDepartment.Location = new System.Drawing.Point(683, 186);
            this.tbxDepartment.Name = "tbxDepartment";
            this.tbxDepartment.ReadOnly = true;
            this.tbxDepartment.Size = new System.Drawing.Size(433, 29);
            this.tbxDepartment.TabIndex = 6;
            this.tbxDepartment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxJob
            // 
            this.tbxJob.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxJob.Location = new System.Drawing.Point(683, 74);
            this.tbxJob.Name = "tbxJob";
            this.tbxJob.ReadOnly = true;
            this.tbxJob.Size = new System.Drawing.Size(433, 29);
            this.tbxJob.TabIndex = 5;
            this.tbxJob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxBirthDate
            // 
            this.tbxBirthDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxBirthDate.Location = new System.Drawing.Point(266, 469);
            this.tbxBirthDate.Name = "tbxBirthDate";
            this.tbxBirthDate.ReadOnly = true;
            this.tbxBirthDate.Size = new System.Drawing.Size(246, 29);
            this.tbxBirthDate.TabIndex = 4;
            this.tbxBirthDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxGender
            // 
            this.tbxGender.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxGender.Location = new System.Drawing.Point(266, 368);
            this.tbxGender.Name = "tbxGender";
            this.tbxGender.ReadOnly = true;
            this.tbxGender.Size = new System.Drawing.Size(162, 29);
            this.tbxGender.TabIndex = 9;
            this.tbxGender.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxAge
            // 
            this.tbxAge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxAge.Location = new System.Drawing.Point(266, 266);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.ReadOnly = true;
            this.tbxAge.Size = new System.Drawing.Size(72, 29);
            this.tbxAge.TabIndex = 3;
            this.tbxAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxName
            // 
            this.tbxName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxName.Location = new System.Drawing.Point(266, 174);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(331, 29);
            this.tbxName.TabIndex = 1;
            this.tbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxID
            // 
            this.tbxID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxID.Location = new System.Drawing.Point(266, 83);
            this.tbxID.Name = "tbxID";
            this.tbxID.ReadOnly = true;
            this.tbxID.Size = new System.Drawing.Size(78, 29);
            this.tbxID.TabIndex = 0;
            this.tbxID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1140, 361);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(97, 29);
            this.label12.TabIndex = 25;
            this.label12.Text = "Email:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1140, 259);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 29);
            this.label11.TabIndex = 24;
            this.label11.Text = "Phone Number:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1168, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 29);
            this.label10.TabIndex = 23;
            this.label10.Text = "Work Hours:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(678, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 29);
            this.label9.TabIndex = 22;
            this.label9.Text = "Hiring Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(678, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 29);
            this.label8.TabIndex = 21;
            this.label8.Text = "Salary:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(678, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 29);
            this.label7.TabIndex = 20;
            this.label7.Text = "Department:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(678, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 29);
            this.label6.TabIndex = 19;
            this.label6.Text = "Job:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(261, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Birth Date:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(261, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 29);
            this.label4.TabIndex = 17;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 29);
            this.label3.TabIndex = 16;
            this.label3.Text = "Age:";
            // 
            // pbxEmployee
            // 
            this.pbxEmployee.Location = new System.Drawing.Point(51, 83);
            this.pbxEmployee.Name = "pbxEmployee";
            this.pbxEmployee.Size = new System.Drawing.Size(157, 142);
            this.pbxEmployee.TabIndex = 2;
            this.pbxEmployee.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 29);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Employee ID:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClose.Font = new System.Drawing.Font("MS PGothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Red;
            this.btnClose.Location = new System.Drawing.Point(1514, 621);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(191, 47);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmShowEmployee
            // 
            this.AcceptButton = this.btnClose;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1755, 689);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.gbxEmployee);
            this.Name = "frmShowEmployee";
            this.Text = "frmShowEmployee";
            this.Load += new System.EventHandler(this.frmShowEmployee_Load);
            this.gbxEmployee.ResumeLayout(false);
            this.gbxEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEmployee)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.GroupBox gbxEmployee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pbxEmployee;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbxID;
        private System.Windows.Forms.TextBox tbxBirthDate;
        private System.Windows.Forms.TextBox tbxGender;
        private System.Windows.Forms.TextBox tbxAge;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxJob;
        private System.Windows.Forms.TextBox tbxHiringDate;
        private System.Windows.Forms.TextBox tbxDepartment;
        private System.Windows.Forms.MaskedTextBox mbxToDate;
        private System.Windows.Forms.MaskedTextBox mbxFromDate;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.TextBox tbxSalary;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}