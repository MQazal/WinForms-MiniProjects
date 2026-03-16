namespace Notepad
{
    partial class frmGoTo
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
            this.numLineNumber = new System.Windows.Forms.NumericUpDown();
            this.btnGoTo = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxLinesNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numLineNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(216, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Line Number";
            // 
            // numLineNumber
            // 
            this.numLineNumber.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.numLineNumber.Font = new System.Drawing.Font("Lucida Sans Typewriter", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numLineNumber.Location = new System.Drawing.Point(221, 152);
            this.numLineNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLineNumber.Name = "numLineNumber";
            this.numLineNumber.Size = new System.Drawing.Size(124, 43);
            this.numLineNumber.TabIndex = 1;
            this.numLineNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numLineNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnGoTo
            // 
            this.btnGoTo.AutoSize = true;
            this.btnGoTo.BackColor = System.Drawing.Color.LawnGreen;
            this.btnGoTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGoTo.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoTo.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnGoTo.Location = new System.Drawing.Point(157, 217);
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(112, 44);
            this.btnGoTo.TabIndex = 2;
            this.btnGoTo.Text = "Go To";
            this.btnGoTo.UseVisualStyleBackColor = false;
            this.btnGoTo.Click += new System.EventHandler(this.btnGoTo_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Lucida Fax", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnCancel.Location = new System.Drawing.Point(296, 217);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 44);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Sans Typewriter", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total Lines Number:";
            // 
            // tbxLinesNumber
            // 
            this.tbxLinesNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxLinesNumber.Location = new System.Drawing.Point(296, 46);
            this.tbxLinesNumber.Name = "tbxLinesNumber";
            this.tbxLinesNumber.Size = new System.Drawing.Size(174, 34);
            this.tbxLinesNumber.TabIndex = 5;
            this.tbxLinesNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmGoTo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(548, 269);
            this.Controls.Add(this.tbxLinesNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnGoTo);
            this.Controls.Add(this.numLineNumber);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmGoTo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Go To Screen";
            this.Load += new System.EventHandler(this.frmGoTo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numLineNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numLineNumber;
        private System.Windows.Forms.Button btnGoTo;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxLinesNumber;
    }
}