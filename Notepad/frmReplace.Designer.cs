namespace Notepad
{
    partial class frmReplace
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
            this.tbxOldText = new System.Windows.Forms.TextBox();
            this.tbxNewText = new System.Windows.Forms.TextBox();
            this.btnReplace = new System.Windows.Forms.Button();
            this.btnReplaceAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxOldText
            // 
            this.tbxOldText.BackColor = System.Drawing.Color.Moccasin;
            this.tbxOldText.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxOldText.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxOldText.Location = new System.Drawing.Point(0, 0);
            this.tbxOldText.MaxLength = 100;
            this.tbxOldText.Multiline = true;
            this.tbxOldText.Name = "tbxOldText";
            this.tbxOldText.Size = new System.Drawing.Size(646, 49);
            this.tbxOldText.TabIndex = 0;
            this.tbxOldText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxOldText_MouseClick);
            // 
            // tbxNewText
            // 
            this.tbxNewText.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbxNewText.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxNewText.Location = new System.Drawing.Point(0, 49);
            this.tbxNewText.MaxLength = 100;
            this.tbxNewText.Multiline = true;
            this.tbxNewText.Name = "tbxNewText";
            this.tbxNewText.Size = new System.Drawing.Size(646, 48);
            this.tbxNewText.TabIndex = 1;
            this.tbxNewText.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxNewText_MouseClick);
            // 
            // btnReplace
            // 
            this.btnReplace.AutoSize = true;
            this.btnReplace.BackColor = System.Drawing.Color.MintCream;
            this.btnReplace.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.Location = new System.Drawing.Point(166, 103);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(139, 46);
            this.btnReplace.TabIndex = 2;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnReplaceAll
            // 
            this.btnReplaceAll.AutoSize = true;
            this.btnReplaceAll.BackColor = System.Drawing.Color.MintCream;
            this.btnReplaceAll.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplaceAll.Location = new System.Drawing.Point(337, 103);
            this.btnReplaceAll.Name = "btnReplaceAll";
            this.btnReplaceAll.Size = new System.Drawing.Size(151, 46);
            this.btnReplaceAll.TabIndex = 3;
            this.btnReplaceAll.Text = "Replace All";
            this.btnReplaceAll.UseVisualStyleBackColor = false;
            this.btnReplaceAll.Click += new System.EventHandler(this.btnReplaceAll_Click);
            // 
            // frmReplace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(646, 155);
            this.Controls.Add(this.btnReplaceAll);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.tbxNewText);
            this.Controls.Add(this.tbxOldText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmReplace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replace Text Screen";
            this.Load += new System.EventHandler(this.frmReplace_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxOldText;
        private System.Windows.Forms.TextBox tbxNewText;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.Button btnReplaceAll;
    }
}