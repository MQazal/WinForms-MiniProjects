namespace RandomCharacter
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
            this.label1 = new System.Windows.Forms.Label();
            this.panRandom = new System.Windows.Forms.Panel();
            this.chboxMix = new System.Windows.Forms.CheckBox();
            this.chboxDigit = new System.Windows.Forms.CheckBox();
            this.chboxSpecial = new System.Windows.Forms.CheckBox();
            this.chboxSmall = new System.Windows.Forms.CheckBox();
            this.chboxCapital = new System.Windows.Forms.CheckBox();
            this.tbxRandom = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.numLettersNumber = new System.Windows.Forms.NumericUpDown();
            this.btnExit = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panRandom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLettersNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Berlin Sans FB Demi", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(292, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(603, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Random Password Generator";
            // 
            // panRandom
            // 
            this.panRandom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panRandom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panRandom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panRandom.Controls.Add(this.chboxMix);
            this.panRandom.Controls.Add(this.chboxDigit);
            this.panRandom.Controls.Add(this.chboxSpecial);
            this.panRandom.Controls.Add(this.chboxSmall);
            this.panRandom.Controls.Add(this.chboxCapital);
            this.panRandom.Controls.Add(this.tbxRandom);
            this.panRandom.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panRandom.Location = new System.Drawing.Point(99, 103);
            this.panRandom.Name = "panRandom";
            this.panRandom.Size = new System.Drawing.Size(945, 201);
            this.panRandom.TabIndex = 1;
            // 
            // chboxMix
            // 
            this.chboxMix.AutoSize = true;
            this.chboxMix.BackColor = System.Drawing.Color.Transparent;
            this.chboxMix.ForeColor = System.Drawing.Color.Cyan;
            this.chboxMix.Location = new System.Drawing.Point(823, 138);
            this.chboxMix.Name = "chboxMix";
            this.chboxMix.Size = new System.Drawing.Size(82, 39);
            this.chboxMix.TabIndex = 5;
            this.chboxMix.Text = "Mix";
            this.chboxMix.UseVisualStyleBackColor = false;
            this.chboxMix.CheckedChanged += new System.EventHandler(this.CheckBox);
            // 
            // chboxDigit
            // 
            this.chboxDigit.AutoSize = true;
            this.chboxDigit.BackColor = System.Drawing.Color.Transparent;
            this.chboxDigit.ForeColor = System.Drawing.Color.Cyan;
            this.chboxDigit.Location = new System.Drawing.Point(700, 138);
            this.chboxDigit.Name = "chboxDigit";
            this.chboxDigit.Size = new System.Drawing.Size(94, 39);
            this.chboxDigit.TabIndex = 4;
            this.chboxDigit.Text = "Digit";
            this.chboxDigit.UseVisualStyleBackColor = false;
            this.chboxDigit.CheckedChanged += new System.EventHandler(this.CheckBox);
            // 
            // chboxSpecial
            // 
            this.chboxSpecial.AutoSize = true;
            this.chboxSpecial.BackColor = System.Drawing.Color.Transparent;
            this.chboxSpecial.ForeColor = System.Drawing.Color.Cyan;
            this.chboxSpecial.Location = new System.Drawing.Point(472, 138);
            this.chboxSpecial.Name = "chboxSpecial";
            this.chboxSpecial.Size = new System.Drawing.Size(198, 39);
            this.chboxSpecial.TabIndex = 3;
            this.chboxSpecial.Text = "Special Letter";
            this.chboxSpecial.UseVisualStyleBackColor = false;
            this.chboxSpecial.CheckedChanged += new System.EventHandler(this.CheckBox);
            // 
            // chboxSmall
            // 
            this.chboxSmall.AutoSize = true;
            this.chboxSmall.BackColor = System.Drawing.Color.Transparent;
            this.chboxSmall.ForeColor = System.Drawing.Color.Cyan;
            this.chboxSmall.Location = new System.Drawing.Point(267, 138);
            this.chboxSmall.Name = "chboxSmall";
            this.chboxSmall.Size = new System.Drawing.Size(179, 39);
            this.chboxSmall.TabIndex = 2;
            this.chboxSmall.Text = "Small Letter";
            this.chboxSmall.UseVisualStyleBackColor = false;
            this.chboxSmall.CheckedChanged += new System.EventHandler(this.CheckBox);
            // 
            // chboxCapital
            // 
            this.chboxCapital.AutoSize = true;
            this.chboxCapital.BackColor = System.Drawing.Color.Transparent;
            this.chboxCapital.ForeColor = System.Drawing.Color.Cyan;
            this.chboxCapital.Location = new System.Drawing.Point(40, 138);
            this.chboxCapital.Name = "chboxCapital";
            this.chboxCapital.Size = new System.Drawing.Size(197, 39);
            this.chboxCapital.TabIndex = 1;
            this.chboxCapital.Text = "Capital Letter";
            this.chboxCapital.UseVisualStyleBackColor = false;
            this.chboxCapital.CheckedChanged += new System.EventHandler(this.CheckBox);
            // 
            // tbxRandom
            // 
            this.tbxRandom.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxRandom.Location = new System.Drawing.Point(114, 25);
            this.tbxRandom.MaxLength = 100;
            this.tbxRandom.Name = "tbxRandom";
            this.tbxRandom.ReadOnly = true;
            this.tbxRandom.Size = new System.Drawing.Size(741, 48);
            this.tbxRandom.TabIndex = 0;
            this.tbxRandom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnGenerate.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(99, 326);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(157, 38);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnReset.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(275, 325);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(121, 38);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // numLettersNumber
            // 
            this.numLettersNumber.BackColor = System.Drawing.Color.Silver;
            this.numLettersNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numLettersNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLettersNumber.Location = new System.Drawing.Point(829, 330);
            this.numLettersNumber.Name = "numLettersNumber";
            this.numLettersNumber.Size = new System.Drawing.Size(103, 32);
            this.numLettersNumber.TabIndex = 4;
            this.numLettersNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnExit.Font = new System.Drawing.Font("Lucida Sans", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(422, 326);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(115, 38);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift SemiBold", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(568, 332);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "Characters Number:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 387);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.numLettersNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.panRandom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Random Character Screen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panRandom.ResumeLayout(false);
            this.panRandom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLettersNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panRandom;
        private System.Windows.Forms.TextBox tbxRandom;
        private System.Windows.Forms.CheckBox chboxMix;
        private System.Windows.Forms.CheckBox chboxDigit;
        private System.Windows.Forms.CheckBox chboxSpecial;
        private System.Windows.Forms.CheckBox chboxSmall;
        private System.Windows.Forms.CheckBox chboxCapital;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.NumericUpDown numLettersNumber;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

