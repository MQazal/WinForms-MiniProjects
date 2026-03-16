namespace Notepad
{
    partial class frmNotepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNotepad));
            this.mns = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noRecentFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.timeDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tos = new System.Windows.Forms.ToolStrip();
            this.btnAddTab = new System.Windows.Forms.ToolStripButton();
            this.btnCloseTap = new System.Windows.Forms.ToolStripButton();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.btnReplace = new System.Windows.Forms.ToolStripButton();
            this.btnGoTo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnBold = new System.Windows.Forms.ToolStripButton();
            this.btnItalic = new System.Windows.Forms.ToolStripButton();
            this.btnUnderline = new System.Windows.Forms.ToolStripButton();
            this.btnStrikeout = new System.Windows.Forms.ToolStripButton();
            this.btnRegualr = new System.Windows.Forms.ToolStripButton();
            this.cmbxTypoHire = new System.Windows.Forms.ToolStripComboBox();
            this.btnFont = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnColor = new System.Windows.Forms.ToolStripButton();
            this.btnHighlight = new System.Windows.Forms.ToolStripButton();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tap1 = new System.Windows.Forms.TabPage();
            this.rtbx1 = new System.Windows.Forms.RichTextBox();
            this.statbar = new System.Windows.Forms.StatusStrip();
            this.lblLinesNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLettersNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLineNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.SaveFile = new System.Windows.Forms.SaveFileDialog();
            this.splitCont = new System.Windows.Forms.SplitContainer();
            this.ColorDia = new System.Windows.Forms.ColorDialog();
            this.FontDia = new System.Windows.Forms.FontDialog();
            this.lblWordsNumber = new System.Windows.Forms.ToolStripStatusLabel();
            this.mns.SuspendLayout();
            this.tos.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tap1.SuspendLayout();
            this.statbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCont)).BeginInit();
            this.splitCont.Panel1.SuspendLayout();
            this.splitCont.Panel2.SuspendLayout();
            this.splitCont.SuspendLayout();
            this.SuspendLayout();
            // 
            // mns
            // 
            this.mns.BackColor = System.Drawing.Color.Linen;
            this.mns.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mns.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.mns.Location = new System.Drawing.Point(0, 0);
            this.mns.Name = "mns";
            this.mns.Size = new System.Drawing.Size(1534, 35);
            this.mns.TabIndex = 0;
            this.mns.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabToolStripMenuItem,
            this.toolStripMenuItem1,
            this.openToolStripMenuItem,
            this.recentToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripMenuItem3,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(60, 31);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // tabToolStripMenuItem
            // 
            this.tabToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewTabToolStripMenuItem,
            this.closeTabToolStripMenuItem});
            this.tabToolStripMenuItem.Image = global::Notepad.Properties.Resources.Tab;
            this.tabToolStripMenuItem.Name = "tabToolStripMenuItem";
            this.tabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.tabToolStripMenuItem.Size = new System.Drawing.Size(306, 32);
            this.tabToolStripMenuItem.Text = "Tab";
            // 
            // addNewTabToolStripMenuItem
            // 
            this.addNewTabToolStripMenuItem.Name = "addNewTabToolStripMenuItem";
            this.addNewTabToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.addNewTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.addNewTabToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.addNewTabToolStripMenuItem.Text = "Add New Tab";
            this.addNewTabToolStripMenuItem.Click += new System.EventHandler(this.addNewTabToolStripMenuItem_Click);
            // 
            // closeTabToolStripMenuItem
            // 
            this.closeTabToolStripMenuItem.Name = "closeTabToolStripMenuItem";
            this.closeTabToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.closeTabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.closeTabToolStripMenuItem.Size = new System.Drawing.Size(303, 32);
            this.closeTabToolStripMenuItem.Text = "Close Tab";
            this.closeTabToolStripMenuItem.Click += new System.EventHandler(this.closeTabToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(303, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(306, 32);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noRecentFilesToolStripMenuItem});
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(306, 32);
            this.recentToolStripMenuItem.Text = "Recent";
            this.recentToolStripMenuItem.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.recentToolStripMenuItem_DropDownItemClicked);
            // 
            // noRecentFilesToolStripMenuItem
            // 
            this.noRecentFilesToolStripMenuItem.ForeColor = System.Drawing.Color.Gray;
            this.noRecentFilesToolStripMenuItem.Name = "noRecentFilesToolStripMenuItem";
            this.noRecentFilesToolStripMenuItem.Size = new System.Drawing.Size(238, 32);
            this.noRecentFilesToolStripMenuItem.Text = "No recent files";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(303, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::Notepad.Properties.Resources.Saa;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(306, 32);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Image = global::Notepad.Properties.Resources.Save_As;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(306, 32);
            this.saveAsToolStripMenuItem.Text = "Save As";
            this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.saveAsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(303, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::Notepad.Properties.Resources.Ex;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(306, 32);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findToolStripMenuItem,
            this.replaceToolStripMenuItem,
            this.goToToolStripMenuItem,
            this.toolStripMenuItem4,
            this.timeDateToolStripMenuItem,
            this.toolStripMenuItem5,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(64, 31);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Image = global::Notepad.Properties.Resources.Fin;
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.findToolStripMenuItem.Text = "Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // replaceToolStripMenuItem
            // 
            this.replaceToolStripMenuItem.Image = global::Notepad.Properties.Resources.rep;
            this.replaceToolStripMenuItem.Name = "replaceToolStripMenuItem";
            this.replaceToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.replaceToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.replaceToolStripMenuItem.Text = "Replace";
            this.replaceToolStripMenuItem.Click += new System.EventHandler(this.replaceToolStripMenuItem_Click);
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.Image = global::Notepad.Properties.Resources.GoTo;
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.goToToolStripMenuItem.Text = "Go To";
            this.goToToolStripMenuItem.Click += new System.EventHandler(this.goToToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(265, 6);
            // 
            // timeDateToolStripMenuItem
            // 
            this.timeDateToolStripMenuItem.Image = global::Notepad.Properties.Resources.TD;
            this.timeDateToolStripMenuItem.Name = "timeDateToolStripMenuItem";
            this.timeDateToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.timeDateToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.timeDateToolStripMenuItem.Text = "Time/Date";
            this.timeDateToolStripMenuItem.Click += new System.EventHandler(this.timeDateToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(265, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Image = global::Notepad.Properties.Resources.Select;
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(268, 32);
            this.selectAllToolStripMenuItem.Text = "Select All";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(71, 31);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(195, 32);
            this.statusBarToolStripMenuItem.Text = "Status Bar";
            this.statusBarToolStripMenuItem.CheckedChanged += new System.EventHandler(this.statusBarToolStripMenuItem_CheckedChanged);
            // 
            // tos
            // 
            this.tos.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tos.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.tos.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddTab,
            this.btnCloseTap,
            this.btnFind,
            this.btnReplace,
            this.btnGoTo,
            this.toolStripSeparator1,
            this.btnBold,
            this.btnItalic,
            this.btnUnderline,
            this.btnStrikeout,
            this.btnRegualr,
            this.cmbxTypoHire,
            this.btnFont,
            this.toolStripSeparator2,
            this.btnColor,
            this.btnHighlight});
            this.tos.Location = new System.Drawing.Point(0, 35);
            this.tos.Name = "tos";
            this.tos.Size = new System.Drawing.Size(1534, 84);
            this.tos.TabIndex = 1;
            this.tos.Text = "toolStrip1";
            // 
            // btnAddTab
            // 
            this.btnAddTab.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTab.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnAddTab.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTab.Image")));
            this.btnAddTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddTab.Name = "btnAddTab";
            this.btnAddTab.Size = new System.Drawing.Size(102, 81);
            this.btnAddTab.Text = "Add Tab";
            this.btnAddTab.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAddTab.Click += new System.EventHandler(this.btnAddTab_Click);
            // 
            // btnCloseTap
            // 
            this.btnCloseTap.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseTap.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnCloseTap.Image = global::Notepad.Properties.Resources.CloseDoc;
            this.btnCloseTap.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCloseTap.Name = "btnCloseTap";
            this.btnCloseTap.Size = new System.Drawing.Size(112, 81);
            this.btnCloseTap.Text = "Close Tab";
            this.btnCloseTap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCloseTap.ToolTipText = "Close Tab";
            this.btnCloseTap.Click += new System.EventHandler(this.btnCloseTap_Click);
            // 
            // btnFind
            // 
            this.btnFind.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnFind.Image = global::Notepad.Properties.Resources.Fin;
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(57, 81);
            this.btnFind.Text = "Find";
            this.btnFind.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnReplace
            // 
            this.btnReplace.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnReplace.Image = global::Notepad.Properties.Resources.rep;
            this.btnReplace.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(89, 81);
            this.btnReplace.Text = "Replace";
            this.btnReplace.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // btnGoTo
            // 
            this.btnGoTo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoTo.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnGoTo.Image = global::Notepad.Properties.Resources.GoTo;
            this.btnGoTo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGoTo.Name = "btnGoTo";
            this.btnGoTo.Size = new System.Drawing.Size(76, 81);
            this.btnGoTo.Text = "Go To";
            this.btnGoTo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnGoTo.Click += new System.EventHandler(this.btnGoTo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 84);
            // 
            // btnBold
            // 
            this.btnBold.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnBold.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBold.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBold.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnBold.Image = ((System.Drawing.Image)(resources.GetObject("btnBold.Image")));
            this.btnBold.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(52, 81);
            this.btnBold.ToolTipText = "Bold";
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItalic.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItalic.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnItalic.Image = ((System.Drawing.Image)(resources.GetObject("btnItalic.Image")));
            this.btnItalic.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(52, 81);
            this.btnItalic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnItalic.ToolTipText = "Italic";
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUnderline.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnderline.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnUnderline.Image = ((System.Drawing.Image)(resources.GetObject("btnUnderline.Image")));
            this.btnUnderline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(52, 81);
            this.btnUnderline.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUnderline.ToolTipText = "Underline";
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // btnStrikeout
            // 
            this.btnStrikeout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnStrikeout.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStrikeout.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnStrikeout.Image = ((System.Drawing.Image)(resources.GetObject("btnStrikeout.Image")));
            this.btnStrikeout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnStrikeout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnStrikeout.Name = "btnStrikeout";
            this.btnStrikeout.Size = new System.Drawing.Size(68, 81);
            this.btnStrikeout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnStrikeout.ToolTipText = "Strikeout";
            this.btnStrikeout.Click += new System.EventHandler(this.btnStrikeout_Click);
            // 
            // btnRegualr
            // 
            this.btnRegualr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRegualr.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegualr.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnRegualr.Image = ((System.Drawing.Image)(resources.GetObject("btnRegualr.Image")));
            this.btnRegualr.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnRegualr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRegualr.Name = "btnRegualr";
            this.btnRegualr.Size = new System.Drawing.Size(68, 81);
            this.btnRegualr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRegualr.ToolTipText = "Regular";
            this.btnRegualr.Click += new System.EventHandler(this.btnRegualr_Click);
            // 
            // cmbxTypoHire
            // 
            this.cmbxTypoHire.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cmbxTypoHire.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTypoHire.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.cmbxTypoHire.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbxTypoHire.Items.AddRange(new object[] {
            "Title",
            "Heading",
            "Subheading",
            "Subtitle",
            "Body"});
            this.cmbxTypoHire.Name = "cmbxTypoHire";
            this.cmbxTypoHire.Size = new System.Drawing.Size(121, 84);
            this.cmbxTypoHire.SelectedIndexChanged += new System.EventHandler(this.cmbxFontSize_SelectedIndexChanged);
            // 
            // btnFont
            // 
            this.btnFont.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFont.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFont.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnFont.Image = ((System.Drawing.Image)(resources.GetObject("btnFont.Image")));
            this.btnFont.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnFont.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(68, 81);
            this.btnFont.ToolTipText = "Font";
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 84);
            // 
            // btnColor
            // 
            this.btnColor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnColor.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColor.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnColor.Image = ((System.Drawing.Image)(resources.GetObject("btnColor.Image")));
            this.btnColor.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnColor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(68, 81);
            this.btnColor.ToolTipText = "Color";
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnHighlight
            // 
            this.btnHighlight.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHighlight.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighlight.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnHighlight.Image = ((System.Drawing.Image)(resources.GetObject("btnHighlight.Image")));
            this.btnHighlight.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHighlight.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHighlight.Name = "btnHighlight";
            this.btnHighlight.Size = new System.Drawing.Size(68, 81);
            this.btnHighlight.ToolTipText = "Highlight";
            this.btnHighlight.Click += new System.EventHandler(this.btnHighlight_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tap1);
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Font = new System.Drawing.Font("Lucida Sans Typewriter", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.Location = new System.Drawing.Point(0, 0);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1530, 463);
            this.tabs.TabIndex = 1;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // tap1
            // 
            this.tap1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.tap1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tap1.Controls.Add(this.rtbx1);
            this.tap1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tap1.Location = new System.Drawing.Point(4, 35);
            this.tap1.Name = "tap1";
            this.tap1.Padding = new System.Windows.Forms.Padding(3);
            this.tap1.Size = new System.Drawing.Size(1522, 424);
            this.tap1.TabIndex = 0;
            this.tap1.Text = "Untitled";
            // 
            // rtbx1
            // 
            this.rtbx1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.rtbx1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbx1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbx1.Font = new System.Drawing.Font("Lucida Sans Typewriter", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbx1.Location = new System.Drawing.Point(3, 3);
            this.rtbx1.Name = "rtbx1";
            this.rtbx1.Size = new System.Drawing.Size(1512, 414);
            this.rtbx1.TabIndex = 0;
            this.rtbx1.Tag = "M";
            this.rtbx1.Text = "";
            // 
            // statbar
            // 
            this.statbar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.statbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statbar.Font = new System.Drawing.Font("Lucida Sans Typewriter", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.statbar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblLettersNumber,
            this.lblLinesNumber,
            this.lblLineNumber,
            this.lblWordsNumber});
            this.statbar.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.statbar.Location = new System.Drawing.Point(0, 0);
            this.statbar.Name = "statbar";
            this.statbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statbar.Size = new System.Drawing.Size(1530, 21);
            this.statbar.TabIndex = 1;
            this.statbar.Text = "Status Bar";
            // 
            // lblLinesNumber
            // 
            this.lblLinesNumber.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblLinesNumber.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.lblLinesNumber.Name = "lblLinesNumber";
            this.lblLinesNumber.Size = new System.Drawing.Size(113, 15);
            this.lblLinesNumber.Text = "0 Line(s)";
            // 
            // lblLettersNumber
            // 
            this.lblLettersNumber.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblLettersNumber.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.lblLettersNumber.Name = "lblLettersNumber";
            this.lblLettersNumber.Size = new System.Drawing.Size(135, 15);
            this.lblLettersNumber.Text = "0 Letter(s)";
            // 
            // lblLineNumber
            // 
            this.lblLineNumber.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblLineNumber.BorderStyle = System.Windows.Forms.Border3DStyle.Raised;
            this.lblLineNumber.Name = "lblLineNumber";
            this.lblLineNumber.Size = new System.Drawing.Size(80, 15);
            this.lblLineNumber.Text = "Line 1";
            // 
            // OpenFile
            // 
            this.OpenFile.DefaultExt = "txt";
            this.OpenFile.Title = "Choose Text File";
            // 
            // SaveFile
            // 
            this.SaveFile.DefaultExt = "txt";
            // 
            // splitCont
            // 
            this.splitCont.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitCont.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitCont.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitCont.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitCont.IsSplitterFixed = true;
            this.splitCont.Location = new System.Drawing.Point(0, 119);
            this.splitCont.Name = "splitCont";
            this.splitCont.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitCont.Panel1
            // 
            this.splitCont.Panel1.Controls.Add(this.tabs);
            // 
            // splitCont.Panel2
            // 
            this.splitCont.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitCont.Panel2.Controls.Add(this.statbar);
            this.splitCont.Size = new System.Drawing.Size(1534, 493);
            this.splitCont.SplitterDistance = 467;
            this.splitCont.SplitterWidth = 1;
            this.splitCont.TabIndex = 2;
            // 
            // ColorDia
            // 
            this.ColorDia.AnyColor = true;
            this.ColorDia.FullOpen = true;
            this.ColorDia.ShowHelp = true;
            // 
            // FontDia
            // 
            this.FontDia.AllowSimulations = false;
            this.FontDia.FontMustExist = true;
            this.FontDia.ShowEffects = false;
            // 
            // lblWordsNumber
            // 
            this.lblWordsNumber.Name = "lblWordsNumber";
            this.lblWordsNumber.Size = new System.Drawing.Size(109, 15);
            this.lblWordsNumber.Text = "0 Word(s)";
            // 
            // frmNotepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1534, 612);
            this.Controls.Add(this.splitCont);
            this.Controls.Add(this.tos);
            this.Controls.Add(this.mns);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.mns;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmNotepad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad Screen";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmNotepad_FormClosing);
            this.Load += new System.EventHandler(this.frmNotepad_Load);
            this.mns.ResumeLayout(false);
            this.mns.PerformLayout();
            this.tos.ResumeLayout(false);
            this.tos.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tap1.ResumeLayout(false);
            this.statbar.ResumeLayout(false);
            this.statbar.PerformLayout();
            this.splitCont.Panel1.ResumeLayout(false);
            this.splitCont.Panel2.ResumeLayout(false);
            this.splitCont.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitCont)).EndInit();
            this.splitCont.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip tos;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem timeDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.ToolStripButton btnCloseTap;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeTabToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog SaveFile;
        private System.Windows.Forms.MenuStrip mns;
        private System.Windows.Forms.ToolStripMenuItem noRecentFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.RichTextBox rtbx1;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tap1;
        private System.Windows.Forms.ToolStripButton btnReplace;
        private System.Windows.Forms.ToolStripButton btnGoTo;
        private System.Windows.Forms.StatusStrip statbar;
        private System.Windows.Forms.ToolStripStatusLabel lblLinesNumber;
        private System.Windows.Forms.ToolStripStatusLabel lblLettersNumber;
        private System.Windows.Forms.ToolStripStatusLabel lblLineNumber;
        private System.Windows.Forms.SplitContainer splitCont;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton btnBold;
        private System.Windows.Forms.ToolStripButton btnItalic;
        private System.Windows.Forms.ToolStripButton btnUnderline;
        private System.Windows.Forms.ToolStripButton btnStrikeout;
        private System.Windows.Forms.ToolStripButton btnRegualr;
        private System.Windows.Forms.ToolStripComboBox cmbxTypoHire;
        private System.Windows.Forms.ToolStripButton btnColor;
        private System.Windows.Forms.ColorDialog ColorDia;
        private System.Windows.Forms.ToolStripButton btnHighlight;
        private System.Windows.Forms.ToolStripButton btnFont;
        private System.Windows.Forms.FontDialog FontDia;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnAddTab;
        private System.Windows.Forms.ToolStripStatusLabel lblWordsNumber;
    }
}

