using System;
using System.Windows.Forms;

namespace Notepad
{
    public partial class frmGoTo : Form
    {
        frmNotepad Document;

        RichTextBox RichBox = new RichTextBox();

        frmFind Find = new frmFind();

        public frmGoTo(frmNotepad notepad)
        {
            InitializeComponent();
            Document = notepad;
            RichBox = Document.GetCurrentRichTextBox();
        }

        private int CountLinesNumber()
        {
            int LinesCounter = default(int);

            for (int i = 0; i < RichBox.Text.Length; i++)
            {
                if (RichBox.Text[i] == '\n' || i == RichBox.Text.Length - 1) // '\n' => new line or RichBox.Text.Length - 1 => last line
                    LinesCounter++;
            }

            return LinesCounter;
        }

        private void PrintLinesNumber()
        {
            tbxLinesNumber.Text = $"{CountLinesNumber()} Line(s)";
        }

        private void frmGoTo_Load(object sender, EventArgs e)
        {
            PrintLinesNumber();
        }

        private void PlaceCursorOnLine(int lineIndex)
        {
            if (lineIndex == 0)
            {
                RichBox.SelectionStart = 0;
                return;
            }

            int LinesCounter = 0;

            for (int i = 0; i < RichBox.Text.Length; i++)
            {
                if (RichBox.Text[i] == '\n')
                {
                    LinesCounter++;

                    if (LinesCounter == lineIndex)
                    {
                        RichBox.SelectionStart = i + 1;
                        break;
                    }
                }
            }
        }

        private void GoToLine()
        {
            bool IsLineExist = false;
            for (int i = 0; i < RichBox.Lines.Length; i++)
            {
                if ((numLineNumber.Value - 1) == i)
                {
                    PlaceCursorOnLine(i);
                    IsLineExist = true;
                    break;
                }
            }

            if (!IsLineExist)
            {
                MessageBox.Show("Line if not found!", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoTo_Click(object sender, EventArgs e)
        {
            GoToLine();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}