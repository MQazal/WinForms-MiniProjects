using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Notepad
{
    public partial class frmNotepad : Form
    {
        enum enAddNewTap
        {
            enAddEmptyDocument,
            enAddTextFileToDocument
        }

        enum enTypographyHierarchy
        {
            enTitle,
            enHeading,
            enSubheading,
            enSubtitle,
            enBody
        }

        public frmNotepad()
        {
            InitializeComponent();
        }

        private void frmNotepad_Load(object sender, EventArgs e)
        {
            PrapareOpenDialog();
            PrapareSaveDialog();
            rtbx1.TextChanged += Rtbx1_TextChanged;
            rtbx1.SelectionChanged += Rtbx1_SelectionChanged;
            cmbxTypoHire.SelectedIndex = (int)enTypographyHierarchy.enBody;
        }

        private void Rtbx1_SelectionChanged(object sender, EventArgs e)
        {
            UpdateLineNumber(rtbx1);
        }

        private void SetLineNumber(RichTextBox Current, ref int LineNumber)
        {
            for (int i = 0; i < Current.Text.Length; i++)
            {
                if (i == Current.SelectionStart)
                {
                    break;
                }

                if (Current.Text[i] == '\n')
                {
                    LineNumber++;
                }
            }
        }

        private void UpdateLineNumber(RichTextBox Current)
        {
            int LineNumber = 1;
            SetLineNumber(Current, ref LineNumber);
            lblLineNumber.Text = $"Line {LineNumber}";
        }

        private int CountDocumentWords()
        {
            int WordsCounter = default(int);
            RichTextBox Box = GetCurrentRichTextBox();
            bool InsideWord = false;

            foreach (char Letter in Box.Text)
            {
                if (!char.IsWhiteSpace(Letter))
                {
                    if (!InsideWord)
                    {
                        WordsCounter++;
                        InsideWord = true;
                    }
                }
                else
                {
                    InsideWord = false;
                }
            }

            return WordsCounter;
        }

        private void UpdateStatusBar(RichTextBox CurrentDocument)
        {
            if (CurrentDocument == null)
            {
                lblLettersNumber.Text = "Empty";
                lblWordsNumber.Text = "Empty";
                lblLinesNumber.Text = "Empty";
                lblLineNumber.Text = "Empty";
                return;
            }

            lblLettersNumber.Text = $"{CurrentDocument.Text.Length.ToString()} Letter(s)";
            lblWordsNumber.Text = $"{CountDocumentWords().ToString()} Word(s)";
            lblLinesNumber.Text = $"{CurrentDocument.Lines.Length.ToString()} Line(s)";
            UpdateLineNumber(CurrentDocument);
        }

        private void Rtbx1_TextChanged(object sender, EventArgs e)
        {
            UpdateStatusBar(rtbx1);
        }

        // File Item

        // Add New Tap Algorithm

        private void StylePage(TabPage page, string Name, string Title)
        {
            page.Name = Name;
            page.Text = Title;
            //page.BackColor = BackColor;
        }

        private void AddControlToPage(TabPage page, Control control)
        {
            page.Controls.Add(control);
        }

        private void StyleAddedControl(Control control, string Name, Color BackColor, DockStyle dock)
        {
            control.Name = Name;
            control.BackColor = BackColor;
            control.Dock = DockStyle.Fill;
        }

        private void AddNewRichBoxToPage(TabPage NewPage, RichTextBox Box)
        {
            AddControlToPage(NewPage, Box);
            StyleAddedControl(Box, "rtbx", Color.LightSteelBlue, DockStyle.Fill);
        }

        private void PrapareOpenDialog()
        {
            OpenFile.InitialDirectory = @"C:\";
            OpenFile.Filter = "Text File|*.txt";
        }

        private string LoadFileContent(string FileName)
        {
            if (string.IsNullOrEmpty(FileName))
                return "";

            string[] Lines = File.ReadAllLines(FileName);
            string FileContent = default(string);
            for (byte i = 0; i < Lines.Length; i++)
            {
                if (i == Lines.Length - 1)
                {
                    FileContent += Lines[i];
                    break;
                }

                else
                    FileContent += Lines[i] + Environment.NewLine;
            }

            return FileContent;
        }

        private byte CalculateLetterFrequency(string Text, char Letter)
        {
            byte FrequencyCounter = 0;
            for (byte i = 0; i < Text.Length; i++)
            {
                if (Text[i] == Letter)
                    FrequencyCounter++;
            }
            return FrequencyCounter;
        }

        private string GetFileName(string FilePath)
        {
            byte Frequency = CalculateLetterFrequency(FilePath, '\\');
            byte Counter = 0;
            string FileName = default(string);

            for (byte i = 0; i < FilePath.Length; i++)
            {
                if (Counter == Frequency)
                {
                    FileName += FilePath[i];
                }
                else
                {
                    if (FilePath[i] == '\\')
                    {
                        Counter++;
                    }
                }
                
            }
            return FileName;
        }

        private string GetPageTitle(enAddNewTap AddMode, string FilePath)
        {
            return AddMode == enAddNewTap.enAddEmptyDocument ? "Untitled" : GetFileName(FilePath);
        }

        private void ConfigureNewPage(TabPage NewPage, string FileName, enAddNewTap AddMode)
        {
            StylePage(NewPage, "tap", GetPageTitle(AddMode, FileName));
            tabs.TabPages.Add(NewPage);
            tabs.SelectedTab = NewPage;
        }

        private void CreateDocumentTab(string FileName, enAddNewTap AddMode)
        {
            TabPage NewPage = new TabPage();
            RichTextBox NewRichBox = new RichTextBox();
            NewRichBox.TextChanged += NewRichBox_TextChanged; // each new Rich Text Box will use this event
            NewRichBox.SelectionChanged += NewRichBox_SelectionChanged;
            AddNewRichBoxToPage(NewPage, NewRichBox);
            NewRichBox.Text = LoadFileContent(FileName);
            NewRichBox.Tag = FileName;
            ConfigureNewPage(NewPage, FileName, AddMode);
        }

        private void NewRichBox_SelectionChanged(object sender, EventArgs e)
        {
            UpdateLineNumber(sender as RichTextBox);
        }

        private void NewRichBox_TextChanged(object sender, EventArgs e)
        {
            UpdateStatusBar(sender as RichTextBox);
        }

        private bool IsFileAddedBefore(string FilePath)
        {
            if (tabs.TabPages.Count == 1 && tabs.SelectedTab.Text == "Untitled")
                return false;

            for (byte i = 0; i < tabs.TabPages.Count; i++)
            {
                if (FilePath == tabs.TabPages[i].Controls[0].Tag.ToString())
                    return true;
            }
            return false;
        }

        private void AddNewDocumentTab(enAddNewTap AddMode = enAddNewTap.enAddEmptyDocument)
        {
            if (AddMode == enAddNewTap.enAddTextFileToDocument)
            {
                if (OpenFile.ShowDialog() != DialogResult.OK)
                    return;

                if (IsFileAddedBefore(OpenFile.FileName))
                {
                    MessageBox.Show("You added this file!");
                    return;
                }
            }
            CreateDocumentTab(OpenFile.FileName, AddMode);
            if (!string.IsNullOrEmpty(OpenFile.FileName))
                OpenFile.FileName = "";
        }

        private void addNewTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDocumentTab();
            if (tabs.TabPages.Count == 1)
            {
                UpdateStatusBar(GetCurrentRichTextBox());
            }
        }

        private void btnAddTab_Click(object sender, EventArgs e)
        {
            AddNewDocumentTab();
            if (tabs.TabPages.Count == 1)
            {
                UpdateStatusBar(GetCurrentRichTextBox());
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDocumentTab(enAddNewTap.enAddTextFileToDocument);
        }

        // Close Tap and Save Algorithm

        private bool IsTabsNumberEqualZero()
        {
            return tabs.TabCount == 0;
        }

        private void UpdateFileContent(string FilePath, string NewText)
        {
            File.WriteAllText(FilePath, NewText);
        }

        private void CloseCurrentTap()
        {
            tabs.TabPages.RemoveAt(tabs.SelectedIndex);
        }

        private bool IsFileContentUpdated(string FilePath, string NewText)
        {
            return File.ReadAllText(FilePath) == NewText;
        }

        private void closeTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsTabsNumberEqualZero())
            {
                MessageBox.Show("Taps number is 0!");
                return;
            }

            if (tabs.SelectedTab.Text == "Untitled")
            {
                CloseCurrentTap();
                return;
            }

            if (!IsFileContentUpdated(tabs.SelectedTab.Controls[0].Tag.ToString(), tabs.SelectedTab.Controls[0].Text))
            {
               if (MessageBox.Show("Do you want to save?", "Before Closing Tab", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
               {
                    UpdateFileContent(tabs.SelectedTab.Controls[0].Tag.ToString(), tabs.SelectedTab.Controls[0].Text);
               }
            }
            AddNewTextFileToRecent();
            CloseCurrentTap();
        }

        private void btnCloseTap_Click(object sender, EventArgs e)
        {
            if (IsTabsNumberEqualZero())
            {
                MessageBox.Show("Taps number is 0!");
                return;
            }

            if (tabs.SelectedTab.Text == "Untitled")
            {
                CloseCurrentTap();
                return;
            }

            if (!IsFileContentUpdated(tabs.SelectedTab.Controls[0].Tag.ToString(), tabs.SelectedTab.Controls[0].Text))
            {
                if (MessageBox.Show("Do you want to save?", "Before Closing Tab", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    UpdateFileContent(tabs.SelectedTab.Controls[0].Tag.ToString(), tabs.SelectedTab.Controls[0].Text);
                }
            }
            AddNewTextFileToRecent();
            CloseCurrentTap();
        }

        private void frmNotepad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tabs.TabPages.Count == 0 || tabs.SelectedTab.Text == "Untitled")
                return;
            if (!IsFileContentUpdated(tabs.SelectedTab.Controls[0].Tag.ToString(), tabs.SelectedTab.Controls[0].Text))
            {
                if (MessageBox.Show("Do you want to save?", "Before Closing Tab", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    UpdateFileContent(tabs.SelectedTab.Controls[0].Tag.ToString(), tabs.SelectedTab.Controls[0].Text);
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (tabs.SelectedTab.Text == "Untitled")
            {
                MessageBox.Show("File is not exist in File Explorer!");
                return;
            }

            UpdateFileContent(tabs.SelectedTab.Controls[0].Tag.ToString(), tabs.SelectedTab.Controls[0].Text);
        }

        // Save As Algorithm

        private void PrapareSaveDialog()
        {
            SaveFile.InitialDirectory = @"C:\";
            SaveFile.Title = "Save File Here";
            SaveFile.Filter = "Text Files|*.txt";
        }

        private void CreateNewTextFileAfterSaveAs(string Path, string Text)
        {
            File.WriteAllText(Path, Text);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (IsTabsNumberEqualZero())
            {
                MessageBox.Show("Taps number equal 0!");
                return;
            }

            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                tabs.SelectedTab.Text = GetPageTitle(enAddNewTap.enAddTextFileToDocument, SaveFile.FileName);
                tabs.SelectedTab.Controls[0].Tag = SaveFile.FileName;
                CreateNewTextFileAfterSaveAs(SaveFile.FileName, tabs.SelectedTab.Controls[0].Text);
            }
        }

        // Recent Files Algorithm

        private void AddNewRecentItem(ToolStripMenuItem RecentMenu)
        {
            ToolStripMenuItem item = new ToolStripMenuItem();
            item.Text = tabs.SelectedTab.Text;
            item.Tag = tabs.SelectedTab.Controls[0].Tag;
            RecentMenu.DropDownItems.Add(item);
        }

        private void AddNewTextFileToRecent()
        {
            if (tabs.SelectedTab.Text == "Untitled")
                return;

            ToolStripMenuItem FileItem = (ToolStripMenuItem)mns.Items["fileToolStripMenuItem"]; // Top Level Item
            ToolStripMenuItem recentMenu = (ToolStripMenuItem)FileItem.DropDownItems["recentToolStripMenuItem"];
            recentMenu.DropDownItems.RemoveByKey("noRecentFilesToolStripMenuItem");
            AddNewRecentItem(recentToolStripMenuItem);
        }

        private void recentToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            ToolStripMenuItem ClickedItem = (ToolStripMenuItem)e.ClickedItem;
            CreateDocumentTab(ClickedItem.Tag.ToString(), enAddNewTap.enAddTextFileToDocument);
        }

        // Exit

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Edit Item

        // Find and Repalce

        private void OpenFindTextForm()
        {
            frmFind Find = new frmFind(this);
            Find.ShowDialog();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFindTextForm();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            OpenFindTextForm();
        }

        public RichTextBox GetCurrentRichTextBox()
        {
            return tabs.TabPages.Count > 0 ? (RichTextBox)tabs.SelectedTab.Controls[0] : null;
        }

        private void OpenReplaceTextForm()
        {
            frmReplace Replace = new frmReplace(this);
            Replace.ShowDialog();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenReplaceTextForm();
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            OpenReplaceTextForm();
        }

        private void OpenGoToLineForm()
        {
            frmGoTo GoTo = new frmGoTo(this);
            GoTo.Show();
        }

        private void goToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenGoToLineForm();
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            OpenGoToLineForm();
        }

        private void InsertTimeAndDate()
        {
            RichTextBox box = GetCurrentRichTextBox();
            box.Text = box.Text.Insert(box.SelectionStart, DateTime.Now.ToString());
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InsertTimeAndDate();
        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateStatusBar(GetCurrentRichTextBox());
        }

        private void statusBarToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (statusBarToolStripMenuItem.Checked)
            {
                statbar.Visible = true;
            }

            else
            {
                statbar.Visible = false;
            }
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetCurrentRichTextBox().SelectAll();
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            RichTextBox Box = GetCurrentRichTextBox();
            Box.SelectionFont = new Font(Box.SelectionFont, FontStyle.Bold);
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            RichTextBox Box = GetCurrentRichTextBox();
            Box.SelectionFont = new Font(Box.SelectionFont, FontStyle.Italic);
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            RichTextBox Box = GetCurrentRichTextBox();
            Box.SelectionFont = new Font(Box.SelectionFont, FontStyle.Underline);
        }

        private void btnStrikeout_Click(object sender, EventArgs e)
        {
            RichTextBox Box = GetCurrentRichTextBox();
            Box.SelectionFont = new Font(Box.SelectionFont, FontStyle.Strikeout);
        }

        private void btnRegualr_Click(object sender, EventArgs e)
        {
            RichTextBox Box = GetCurrentRichTextBox();
            Box.SelectionFont = new Font(Box.SelectionFont, FontStyle.Regular);
        }

        private enTypographyHierarchy GetEnTypography(int Index)
        {
            switch (Index)
            {
                case 0:
                    return enTypographyHierarchy.enTitle;
                case 1:
                    return enTypographyHierarchy.enHeading;
                case 2:
                    return enTypographyHierarchy.enSubheading;
                case 3:
                    return enTypographyHierarchy.enSubtitle;
                default:
                    return enTypographyHierarchy.enBody;
            }
        }

        private byte GetFontSize(enTypographyHierarchy enTypography)
        {
            switch (enTypography)
            {
                case enTypographyHierarchy.enTitle:
                    return 32;
                case enTypographyHierarchy.enHeading:
                    return 26;
                case enTypographyHierarchy.enSubheading:
                    return 20;
                case enTypographyHierarchy.enSubtitle:
                    return 16;
                default:
                    return 12;
            }
        }

        private void SetTypographyFont(enTypographyHierarchy enTypography)
        {
            RichTextBox box = GetCurrentRichTextBox();
            Font currentFont = box.SelectionFont;
            box.SelectionFont = new Font(currentFont.FontFamily, GetFontSize(enTypography), FontStyle.Regular);
        }

        private void cmbxFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetTypographyFont(GetEnTypography(cmbxTypoHire.SelectedIndex));
        }

        private void ChangeFontColor()
        {
            RichTextBox Box = GetCurrentRichTextBox();
            if (Box == null)
                return;

            if (ColorDia.ShowDialog() == DialogResult.OK)
            {
                Box.SelectionColor = ColorDia.Color;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            ChangeFontColor();
        }

        private void HighlightText()
        {
            RichTextBox Box = GetCurrentRichTextBox();
            if (Box == null)
                return;
            if (ColorDia.ShowDialog() == DialogResult.OK)
            {
                Box.SelectionBackColor = ColorDia.Color;
            }
        }

        private void btnHighlight_Click(object sender, EventArgs e)
        {
            HighlightText();
        }

        private void ChangeFontStyle()
        {
            RichTextBox Box = GetCurrentRichTextBox();
            if (Box == null)
                return;
            if (FontDia.ShowDialog() == DialogResult.OK)
            {
                Box.SelectionFont = FontDia.Font;
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            ChangeFontStyle();
        }
    }
}