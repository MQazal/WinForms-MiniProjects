namespace EmployeeManagementSystem
{
    partial class frmAddEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddEmployee));
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxGender = new System.Windows.Forms.GroupBox();
            this.rdbtnFemale = new System.Windows.Forms.RadioButton();
            this.rdbtnMale = new System.Windows.Forms.RadioButton();
            this.gbxPersonal = new System.Windows.Forms.GroupBox();
            this.mskAge = new System.Windows.Forms.MaskedTextBox();
            this.mskID = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbxLName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txbxFName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxContact = new System.Windows.Forms.GroupBox();
            this.txbxEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.mskPhone = new System.Windows.Forms.MaskedTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.gbxTime = new System.Windows.Forms.GroupBox();
            this.mskTimeTo = new System.Windows.Forms.MaskedTextBox();
            this.mskTimeFrom = new System.Windows.Forms.MaskedTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gbxJob = new System.Windows.Forms.GroupBox();
            this.dtpHiring = new System.Windows.Forms.DateTimePicker();
            this.mskSalary = new System.Windows.Forms.MaskedTextBox();
            this.cmbxDepartment = new System.Windows.Forms.ComboBox();
            this.cmbxJob = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gbxNewEmployee = new System.Windows.Forms.GroupBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbxGender.SuspendLayout();
            this.gbxPersonal.SuspendLayout();
            this.gbxContact.SuspendLayout();
            this.gbxTime.SuspendLayout();
            this.gbxJob.SuspendLayout();
            this.gbxNewEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.Gainsboro;
            this.btnInsert.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(1297, 657);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(164, 43);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Insert To List";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Gainsboro;
            this.btnClose.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(1476, 657);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(164, 43);
            this.btnClose.TabIndex = 16;
            this.btnClose.Text = "Close Form";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbxGender
            // 
            this.gbxGender.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.gbxGender.Controls.Add(this.rdbtnFemale);
            this.gbxGender.Controls.Add(this.rdbtnMale);
            this.gbxGender.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxGender.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxGender.Location = new System.Drawing.Point(1165, 77);
            this.gbxGender.Name = "gbxGender";
            this.gbxGender.Size = new System.Drawing.Size(265, 83);
            this.gbxGender.TabIndex = 3;
            this.gbxGender.TabStop = false;
            this.gbxGender.Text = "Gender";
            this.gbxGender.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateGenderSelect);
            // 
            // rdbtnFemale
            // 
            this.rdbtnFemale.AutoSize = true;
            this.rdbtnFemale.Location = new System.Drawing.Point(133, 44);
            this.rdbtnFemale.Name = "rdbtnFemale";
            this.rdbtnFemale.Size = new System.Drawing.Size(96, 29);
            this.rdbtnFemale.TabIndex = 10;
            this.rdbtnFemale.TabStop = true;
            this.rdbtnFemale.Text = "Female";
            this.rdbtnFemale.UseVisualStyleBackColor = true;
            // 
            // rdbtnMale
            // 
            this.rdbtnMale.AutoSize = true;
            this.rdbtnMale.Location = new System.Drawing.Point(28, 45);
            this.rdbtnMale.Name = "rdbtnMale";
            this.rdbtnMale.Size = new System.Drawing.Size(76, 29);
            this.rdbtnMale.TabIndex = 9;
            this.rdbtnMale.TabStop = true;
            this.rdbtnMale.Text = "Male";
            this.rdbtnMale.UseVisualStyleBackColor = true;
            // 
            // gbxPersonal
            // 
            this.gbxPersonal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbxPersonal.Controls.Add(this.mskAge);
            this.gbxPersonal.Controls.Add(this.mskID);
            this.gbxPersonal.Controls.Add(this.label14);
            this.gbxPersonal.Controls.Add(this.dtpBirth);
            this.gbxPersonal.Controls.Add(this.label5);
            this.gbxPersonal.Controls.Add(this.label4);
            this.gbxPersonal.Controls.Add(this.txbxLName);
            this.gbxPersonal.Controls.Add(this.label3);
            this.gbxPersonal.Controls.Add(this.txbxFName);
            this.gbxPersonal.Controls.Add(this.label2);
            this.gbxPersonal.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxPersonal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxPersonal.Location = new System.Drawing.Point(103, 77);
            this.gbxPersonal.Name = "gbxPersonal";
            this.gbxPersonal.Size = new System.Drawing.Size(424, 281);
            this.gbxPersonal.TabIndex = 2;
            this.gbxPersonal.TabStop = false;
            this.gbxPersonal.Text = "Personal Information";
            this.gbxPersonal.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatePersonalData);
            // 
            // mskAge
            // 
            this.mskAge.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskAge.Location = new System.Drawing.Point(67, 179);
            this.mskAge.Mask = "00";
            this.mskAge.Name = "mskAge";
            this.mskAge.Size = new System.Drawing.Size(52, 33);
            this.mskAge.SkipLiterals = false;
            this.mskAge.TabIndex = 3;
            this.mskAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mskID
            // 
            this.mskID.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskID.Location = new System.Drawing.Point(145, 34);
            this.mskID.Mask = "00";
            this.mskID.Name = "mskID";
            this.mskID.Size = new System.Drawing.Size(52, 33);
            this.mskID.TabIndex = 0;
            this.mskID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(8, 187);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 25);
            this.label14.TabIndex = 9;
            this.label14.Text = "Age:";
            // 
            // dtpBirth
            // 
            this.dtpBirth.CustomFormat = "dd/mm/yyyy";
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBirth.Location = new System.Drawing.Point(145, 228);
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.Size = new System.Drawing.Size(218, 33);
            this.dtpBirth.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Date of Birth:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Last Name:";
            // 
            // txbxLName
            // 
            this.txbxLName.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxLName.Location = new System.Drawing.Point(121, 134);
            this.txbxLName.MaxLength = 20;
            this.txbxLName.Name = "txbxLName";
            this.txbxLName.Size = new System.Drawing.Size(215, 33);
            this.txbxLName.TabIndex = 2;
            this.txbxLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "First Name:";
            // 
            // txbxFName
            // 
            this.txbxFName.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbxFName.Location = new System.Drawing.Point(121, 85);
            this.txbxFName.MaxLength = 20;
            this.txbxFName.Name = "txbxFName";
            this.txbxFName.Size = new System.Drawing.Size(215, 33);
            this.txbxFName.TabIndex = 1;
            this.txbxFName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee ID:";
            // 
            // gbxContact
            // 
            this.gbxContact.BackColor = System.Drawing.Color.Silver;
            this.gbxContact.Controls.Add(this.txbxEmail);
            this.gbxContact.Controls.Add(this.label13);
            this.gbxContact.Controls.Add(this.mskPhone);
            this.gbxContact.Controls.Add(this.label12);
            this.gbxContact.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxContact.ForeColor = System.Drawing.Color.Black;
            this.gbxContact.Location = new System.Drawing.Point(580, 393);
            this.gbxContact.Name = "gbxContact";
            this.gbxContact.Size = new System.Drawing.Size(550, 164);
            this.gbxContact.TabIndex = 5;
            this.gbxContact.TabStop = false;
            this.gbxContact.Text = "Contact Information";
            this.gbxContact.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateContactData);
            // 
            // txbxEmail
            // 
            this.txbxEmail.Location = new System.Drawing.Point(80, 111);
            this.txbxEmail.Name = "txbxEmail";
            this.txbxEmail.Size = new System.Drawing.Size(421, 33);
            this.txbxEmail.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 111);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 25);
            this.label13.TabIndex = 4;
            this.label13.Text = "Email:";
            // 
            // mskPhone
            // 
            this.mskPhone.BeepOnError = true;
            this.mskPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mskPhone.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mskPhone.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.mskPhone.Location = new System.Drawing.Point(169, 57);
            this.mskPhone.Mask = "(+\\966) 00-0000000";
            this.mskPhone.Name = "mskPhone";
            this.mskPhone.Size = new System.Drawing.Size(244, 30);
            this.mskPhone.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(157, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Phone Number:";
            // 
            // gbxTime
            // 
            this.gbxTime.BackColor = System.Drawing.Color.MediumTurquoise;
            this.gbxTime.Controls.Add(this.mskTimeTo);
            this.gbxTime.Controls.Add(this.mskTimeFrom);
            this.gbxTime.Controls.Add(this.label11);
            this.gbxTime.Controls.Add(this.label10);
            this.gbxTime.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxTime.Location = new System.Drawing.Point(1165, 198);
            this.gbxTime.Name = "gbxTime";
            this.gbxTime.Size = new System.Drawing.Size(265, 153);
            this.gbxTime.TabIndex = 4;
            this.gbxTime.TabStop = false;
            this.gbxTime.Text = "Time Work";
            this.gbxTime.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateWorkTimes);
            // 
            // mskTimeTo
            // 
            this.mskTimeTo.Location = new System.Drawing.Point(93, 99);
            this.mskTimeTo.Mask = "00:00 PM";
            this.mskTimeTo.Name = "mskTimeTo";
            this.mskTimeTo.Size = new System.Drawing.Size(104, 33);
            this.mskTimeTo.TabIndex = 12;
            // 
            // mskTimeFrom
            // 
            this.mskTimeFrom.Location = new System.Drawing.Point(93, 47);
            this.mskTimeFrom.Mask = "00:00 \\AM";
            this.mskTimeFrom.Name = "mskTimeFrom";
            this.mskTimeFrom.Size = new System.Drawing.Size(104, 33);
            this.mskTimeFrom.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 25);
            this.label11.TabIndex = 3;
            this.label11.Text = "To:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(23, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "From:";
            // 
            // gbxJob
            // 
            this.gbxJob.BackColor = System.Drawing.Color.Khaki;
            this.gbxJob.Controls.Add(this.dtpHiring);
            this.gbxJob.Controls.Add(this.mskSalary);
            this.gbxJob.Controls.Add(this.cmbxDepartment);
            this.gbxJob.Controls.Add(this.cmbxJob);
            this.gbxJob.Controls.Add(this.label9);
            this.gbxJob.Controls.Add(this.label8);
            this.gbxJob.Controls.Add(this.label7);
            this.gbxJob.Controls.Add(this.label6);
            this.gbxJob.Font = new System.Drawing.Font("Segoe UI Symbol", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxJob.ForeColor = System.Drawing.Color.DarkRed;
            this.gbxJob.Location = new System.Drawing.Point(580, 77);
            this.gbxJob.Name = "gbxJob";
            this.gbxJob.Size = new System.Drawing.Size(550, 272);
            this.gbxJob.TabIndex = 6;
            this.gbxJob.TabStop = false;
            this.gbxJob.Text = "Job Information";
            this.gbxJob.Validating += new System.ComponentModel.CancelEventHandler(this.ValidateJobData);
            // 
            // dtpHiring
            // 
            this.dtpHiring.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHiring.Location = new System.Drawing.Point(163, 223);
            this.dtpHiring.Name = "dtpHiring";
            this.dtpHiring.Size = new System.Drawing.Size(200, 33);
            this.dtpHiring.TabIndex = 8;
            // 
            // mskSalary
            // 
            this.mskSalary.ForeColor = System.Drawing.Color.DarkGreen;
            this.mskSalary.Location = new System.Drawing.Point(88, 167);
            this.mskSalary.Mask = "00000 S\\AR";
            this.mskSalary.Name = "mskSalary";
            this.mskSalary.Size = new System.Drawing.Size(107, 33);
            this.mskSalary.TabIndex = 7;
            // 
            // cmbxDepartment
            // 
            this.cmbxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxDepartment.FormattingEnabled = true;
            this.cmbxDepartment.Location = new System.Drawing.Point(141, 102);
            this.cmbxDepartment.Name = "cmbxDepartment";
            this.cmbxDepartment.Size = new System.Drawing.Size(368, 33);
            this.cmbxDepartment.TabIndex = 6;
            // 
            // cmbxJob
            // 
            this.cmbxJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxJob.FormattingEnabled = true;
            this.cmbxJob.Location = new System.Drawing.Point(66, 44);
            this.cmbxJob.Name = "cmbxJob";
            this.cmbxJob.Size = new System.Drawing.Size(358, 33);
            this.cmbxJob.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 25);
            this.label9.TabIndex = 13;
            this.label9.Text = "Date Of Hiring:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 12;
            this.label8.Text = "Salary:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 110);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 25);
            this.label7.TabIndex = 11;
            this.label7.Text = "Department:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Job:";
            // 
            // gbxNewEmployee
            // 
            this.gbxNewEmployee.Controls.Add(this.gbxJob);
            this.gbxNewEmployee.Controls.Add(this.gbxTime);
            this.gbxNewEmployee.Controls.Add(this.gbxContact);
            this.gbxNewEmployee.Controls.Add(this.gbxPersonal);
            this.gbxNewEmployee.Controls.Add(this.gbxGender);
            this.gbxNewEmployee.Font = new System.Drawing.Font("Segoe UI Symbol", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxNewEmployee.ForeColor = System.Drawing.Color.DarkCyan;
            this.gbxNewEmployee.Location = new System.Drawing.Point(132, 45);
            this.gbxNewEmployee.Name = "gbxNewEmployee";
            this.gbxNewEmployee.Size = new System.Drawing.Size(1442, 592);
            this.gbxNewEmployee.TabIndex = 2;
            this.gbxNewEmployee.TabStop = false;
            this.gbxNewEmployee.Text = "New Employee Data Form";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Male Employee.jfif");
            this.imageList1.Images.SetKeyName(1, "Female Employee.jfif");
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // frmAddEmployee
            // 
            this.AcceptButton = this.btnInsert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1730, 741);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.gbxNewEmployee);
            this.Name = "frmAddEmployee";
            this.Text = "frmAddEmployee";
            this.Load += new System.EventHandler(this.frmAddEmployee_Load);
            this.gbxGender.ResumeLayout(false);
            this.gbxGender.PerformLayout();
            this.gbxPersonal.ResumeLayout(false);
            this.gbxPersonal.PerformLayout();
            this.gbxContact.ResumeLayout(false);
            this.gbxContact.PerformLayout();
            this.gbxTime.ResumeLayout(false);
            this.gbxTime.PerformLayout();
            this.gbxJob.ResumeLayout(false);
            this.gbxJob.PerformLayout();
            this.gbxNewEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbxGender;
        private System.Windows.Forms.RadioButton rdbtnFemale;
        private System.Windows.Forms.RadioButton rdbtnMale;
        private System.Windows.Forms.GroupBox gbxPersonal;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbxLName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbxFName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbxContact;
        private System.Windows.Forms.TextBox txbxEmail;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.MaskedTextBox mskPhone;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbxTime;
        private System.Windows.Forms.MaskedTextBox mskTimeTo;
        private System.Windows.Forms.MaskedTextBox mskTimeFrom;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gbxJob;
        private System.Windows.Forms.DateTimePicker dtpHiring;
        private System.Windows.Forms.MaskedTextBox mskSalary;
        private System.Windows.Forms.ComboBox cmbxDepartment;
        private System.Windows.Forms.ComboBox cmbxJob;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbxNewEmployee;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MaskedTextBox mskID;
        private System.Windows.Forms.MaskedTextBox mskAge;
    }
}