using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Notepad
{
    public partial class frmReplace : Form
    {
        frmNotepad Document;

        RichTextBox RichBox = new RichTextBox();

        frmFind Find = new frmFind();

        List<string> liWords = new List<string>();

        enum enReplaceMechanisms
        {
            enRplaceByWord,
            enReplacAll
        }

        enReplaceMechanisms Mechanism;

        public frmReplace(frmNotepad notepad)
        {
            InitializeComponent();
            Document = notepad;
            RichBox = Document.GetCurrentRichTextBox();
        }

        private List<string> ConvertDocumentToList()
        {
            List<string> list = new List<string>();

            string Word = "";

            for (int i = 0; i < RichBox.Text.Length; i++)
            {
                bool IsValidChar = Find.IsValidTextChar(RichBox.Text[i]);

                if (IsValidChar)
                {
                    Word += RichBox.Text[i];
                }

                if ((!IsValidChar || i == RichBox.Text.Length - 1) && Word.Length > 0)
                {
                    list.Add(Word);
                    Word = "";

                    if (!IsValidChar)
                    {
                        list.Add(Convert.ToString(RichBox.Text[i])); // '  '
                    }
                }
            }

            return list;
        }

        private void frmReplace_Load(object sender, EventArgs e)
        {
            Find.SetTextBoxStyle(tbxOldText, "Type old text here...", Color.Gray, HorizontalAlignment.Center);
            Find.SetTextBoxStyle(tbxNewText, "Type new text here...", Color.Gray, HorizontalAlignment.Center);
            liWords = ConvertDocumentToList();
        }

        private void tbxOldText_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbxOldText.Text == "Type old text here...")
                Find.SetTextBoxStyle(tbxOldText, "", Color.Black, HorizontalAlignment.Left);
        }

        private void tbxNewText_MouseClick(object sender, MouseEventArgs e)
        {
            if (tbxNewText.Text == "Type new text here...")
                Find.SetTextBoxStyle(tbxNewText, "", Color.Black, HorizontalAlignment.Left);
        }

        private void ReplaceTextInList()
        {
            for (int i = 0; i < liWords.Count; i++)
            {
                if (Find.AreStringsEqual(liWords[i], tbxOldText.Text, frmFind.enMatchCase.enMatchCase))
                {
                    if (Mechanism == enReplaceMechanisms.enRplaceByWord)
                    {
                        liWords[i] = tbxNewText.Text;
                        break;
                    }

                    else
                    {
                        liWords[i] = tbxNewText.Text;
                    }
                }
            }
        }

        // Vaildation

        private bool IsDocumentEmpty()
        {
            return string.IsNullOrWhiteSpace(RichBox.Text);
        }

        private bool IsBoxHasDefaultText(TextBox Box, string DefaultText)
        {
            return Box.Text == DefaultText;
        }

        private bool IsBoxEmpty(TextBox Box)
        {
            return string.IsNullOrWhiteSpace(Box.Text);
        }

        private bool IsOldWordExist()
        {
            for (int i = 0; i < liWords.Count; i++)
            {
                if (Find.AreStringsEqual(liWords[i], tbxOldText.Text, frmFind.enMatchCase.enMatchCase))
                {
                    return true;
                }
            }
            return false;
        }

        //

        private void UpdateTextDocument()
        {
            if (IsDocumentEmpty())
            {
                MessageBox.Show($"Oops, document's text is empty.", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsBoxHasDefaultText(tbxOldText, "Type old text here...") || IsBoxHasDefaultText(tbxOldText, "Type new text here..."))
            {
                MessageBox.Show($"Oops, you don't type old or new word.", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsBoxEmpty(tbxOldText) || IsBoxEmpty(tbxNewText))
            {
                MessageBox.Show($"Oops, type old or new word in box.", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!IsOldWordExist())
            {
                MessageBox.Show($"Oops, old word is not exist in document.", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ReplaceTextInList();
            RichBox.Text = "";
            RichBox.Text = string.Join("", liWords);
            liWords = ConvertDocumentToList();
            MessageBox.Show($"{tbxOldText.Text} was replacesd by {tbxNewText.Text} successfully.", "Finish Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            Mechanism = enReplaceMechanisms.enRplaceByWord;
            UpdateTextDocument();
        }

        private void btnReplaceAll_Click(object sender, EventArgs e)
        {
            Mechanism = enReplaceMechanisms.enReplacAll;
            UpdateTextDocument();
        }
    }
}