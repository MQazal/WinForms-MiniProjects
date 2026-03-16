namespace Notepad
{
    partial class frmFind
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFind));
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.tos = new System.Windows.Forms.ToolStrip();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.btnSearchDown = new System.Windows.Forms.ToolStripButton();
            this.btnOptions = new System.Windows.Forms.ToolStripSplitButton();
            this.MatchCaseItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnClearHighlight = new System.Windows.Forms.ToolStripButton();
            this.tos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxSearch
            // 
            this.tbxSearch.BackColor = System.Drawing.Color.Khaki;
            this.tbxSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbxSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbxSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxSearch.Location = new System.Drawing.Point(0, 0);
            this.tbxSearch.MaxLength = 5000;
            this.tbxSearch.Multiline = true;
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(899, 113);
            this.tbxSearch.TabIndex = 0;
            this.tbxSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbxSearch_MouseClick);
            // 
            // tos
            // 
            this.tos.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tos.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tos.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tos.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSearch,
            this.btnSearchDown,
            this.btnOptions,
            this.btnClearHighlight});
            this.tos.Location = new System.Drawing.Point(0, 78);
            this.tos.Name = "tos";
            this.tos.Size = new System.Drawing.Size(899, 35);
            this.tos.TabIndex = 1;
            this.tos.Text = "Search Tools";
            // 
            // btnSearch
            // 
            this.btnSearch.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 32);
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnSearchDown
            // 
            this.btnSearchDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSearchDown.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchDown.Image")));
            this.btnSearchDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearchDown.Name = "btnSearchDown";
            this.btnSearchDown.Size = new System.Drawing.Size(130, 32);
            this.btnSearchDown.Text = "Search Down";
            this.btnSearchDown.Click += new System.EventHandler(this.btnSearchDown_Click);
            // 
            // btnOptions
            // 
            this.btnOptions.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MatchCaseItem});
            this.btnOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOptions.Image")));
            this.btnOptions.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOptions.Name = "btnOptions";
            this.btnOptions.Size = new System.Drawing.Size(153, 32);
            this.btnOptions.Text = "More Options";
            // 
            // MatchCaseItem
            // 
            this.MatchCaseItem.CheckOnClick = true;
            this.MatchCaseItem.Name = "MatchCaseItem";
            this.MatchCaseItem.Size = new System.Drawing.Size(224, 32);
            this.MatchCaseItem.Text = "Match Case";
            this.MatchCaseItem.CheckedChanged += new System.EventHandler(this.MatchCaseItem_CheckedChanged);
            // 
            // btnClearHighlight
            // 
            this.btnClearHighlight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnClearHighlight.Image = ((System.Drawing.Image)(resources.GetObject("btnClearHighlight.Image")));
            this.btnClearHighlight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClearHighlight.Name = "btnClearHighlight";
            this.btnClearHighlight.Size = new System.Drawing.Size(147, 32);
            this.btnClearHighlight.Text = "Clear Highlight";
            this.btnClearHighlight.Click += new System.EventHandler(this.btnClearHighlight_Click);
            // 
            // frmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(899, 113);
            this.Controls.Add(this.tos);
            this.Controls.Add(this.tbxSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Text Screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFind_FormClosed);
            this.Load += new System.EventHandler(this.frmFind_Load);
            this.tos.ResumeLayout(false);
            this.tos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ToolStrip tos;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStripButton btnSearchDown;
        private System.Windows.Forms.ToolStripSplitButton btnOptions;
        private System.Windows.Forms.ToolStripMenuItem MatchCaseItem;
        private System.Windows.Forms.ToolStripButton btnClearHighlight;
    }
}