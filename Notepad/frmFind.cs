using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Notepad
{
    public partial class frmFind : Form
    {
        frmNotepad Document;

        RichTextBox RichBox = new RichTextBox();

        public enum enMatchCase
        {
            enMatchCase,
            enIgnoreCase
        }

        enMatchCase IsMatchCase;

        enum enSearchMechanisms
        {
            enSingleLetterSearch,
            enSingleWordSearch,
            enMultiWordsSearch
        }

        enum enSearchDirection
        {
            enSearchEntireDocument,
            enSearchDown
        }

        enSearchDirection Direction;

        enum enReplaceMechanisms
        {
            enReplaceByWord,
            enReplaceAll
        }

        enReplaceMechanisms Replace;

        public frmFind(frmNotepad Current)
        {
            InitializeComponent();
            Document = Current;
            RichBox = Document.GetCurrentRichTextBox();
        }

        public frmFind()
        {

        }

        public void SetTextBoxStyle(TextBox Box, string DefaultString, Color DefaulttTextColor, HorizontalAlignment alignment)
        {
            Box.Text = DefaultString;
            Box.ForeColor = DefaulttTextColor;
            Box.TextAlign = alignment;
        }

        private void frmFind_Load(object sender, EventArgs e)
        {
            IsMatchCase = enMatchCase.enIgnoreCase;
            SetTextBoxStyle(tbxSearch, "Search Here...", Color.Gray, HorizontalAlignment.Center);
        }

        private bool IsNumberBetween(byte Number, byte From, byte To)
        {
            return (Number >= From) && (Number <= To);
        }

        private bool IsUpper(char Letter)
        {
            return IsNumberBetween((byte)Letter, (byte)'A', (byte)'Z');
        }

        private bool IsLower(char Letter)
        {
            return IsNumberBetween((byte)Letter, (byte)'a', (byte)'z');
        }

        private bool IsDigit(char Letter)
        {
            return IsNumberBetween((byte)Letter, (byte)'0', (byte)'9');
        }

        private bool IsPunct(char Letter)
        {
            return IsNumberBetween((byte)Letter, 33, 47) || IsNumberBetween((byte)Letter, 58, 64)
                || IsNumberBetween((byte)Letter, 91, 96) || IsNumberBetween((byte)Letter, 123, 126);
        }

        public bool IsValidTextChar(char Letter)
        {
            return IsUpper(Letter) || IsLower(Letter) || IsDigit(Letter) || IsPunct(Letter);
        }

        private char ToUpper(char Letter)
        {
            return IsLower(Letter) ? Convert.ToChar(Letter - 32) : Letter;
        }

        private string ToUpperString(string Text)
        {
            string CapitalString = default(string);
            foreach (char Letter in Text)
            {
                CapitalString += ToUpper(Letter);
            }
            return CapitalString;
        }

        public bool AreStringsEqual(string UserText, string SearchText, enMatchCase Mode)
        {
            return Mode == enMatchCase.enMatchCase ? UserText == SearchText : ToUpperString(UserText) == ToUpperString(SearchText);
        }

        private bool IsFoundLetterHighlighted(Color HighlightColor)
        {
            return RichBox.SelectionBackColor.ToArgb() == HighlightColor.ToArgb();
        }

        private void HighlightFoundLetter(Color HighlightColor)
        {
            RichBox.SelectionBackColor = HighlightColor;
        }

        private bool IsFoundWordHighlighted(Color HighlightColor)
        {
            return RichBox.SelectionBackColor.ToArgb() == HighlightColor.ToArgb();
        }

        private void HighlightFoundWord(Color HighlightColor)
        {
            RichBox.SelectionBackColor = HighlightColor;
        }

        private bool IsWordHasDash(string Word)
        {
            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] == '-')
                    return true;
            }
            return false;
        }
        
        private void SearchByOneLetter(enMatchCase IsMatchCase)
        {
            int FoundCounter = 0;
            for (int i = 0; i < RichBox.Text.Length; i++)
            {
                if (AreStringsEqual(RichBox.Text[i].ToString(), tbxSearch.Text, IsMatchCase))
                {
                    RichBox.Select(i, 1);
                    if (Direction == enSearchDirection.enSearchDown)
                    {
                        if (!IsFoundLetterHighlighted(Color.Yellow))
                        {
                            HighlightFoundLetter(Color.Yellow);
                            FoundCounter++;
                            break;
                        }
                        else
                            continue;
                    }
                    HighlightFoundLetter(Color.Yellow);
                    FoundCounter++;
                }
            }

            if (FoundCounter == 0)
                MessageBox.Show($"Cannot find {tbxSearch.Text}", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SearchAboutUncrossedOutWord(string CurrentFullWord, int IndexToStart, ref int Counter)
        {
            string Word = "";
            int FirstLetterIndex = IndexToStart;

            for (int i = 0; i < CurrentFullWord.Length; i++)
            {
                if (CurrentFullWord[i] != '-')
                {
                    Word += CurrentFullWord[i];
                    if (Word.Length > 1)
                    {
                        IndexToStart++;
                    }
                }

                if ((CurrentFullWord[i] == '-' || i == CurrentFullWord.Length - 1) && Word.Length > 0)
                {
                    if (AreStringsEqual(Word, tbxSearch.Text, IsMatchCase))
                    {
                        RichBox.Select(FirstLetterIndex, Word.Length);
                        HighlightFoundWord(Color.Yellow);
                        Counter++;
                    }
                    // update first index
                    IndexToStart += 2; // index of '-' and first letter after '-'
                    FirstLetterIndex = IndexToStart;
                    Word = "";
                }
            }
        }

        private void SearchByOneWord(enMatchCase IsMatchCase)
        {
            string Word = default(string);
            int StartIndex = default(int);
            int FoundCounter = 0;

            for (int i = 0; i < RichBox.Text.Length; i++)
            {
                bool IsValidChar = IsValidTextChar(RichBox.Text[i]);

                if (IsValidChar)
                {
                    Word += RichBox.Text[i];
                    if (Word.Length == 1)
                    {
                        StartIndex = i;
                    }
                }

                if ((!IsValidChar || i == RichBox.Text.Length - 1) && Word.Length > 0)
                {
                    if (AreStringsEqual(Word, tbxSearch.Text, IsMatchCase))
                    {
                        RichBox.Select(StartIndex, Word.Length);
                        if (Direction == enSearchDirection.enSearchDown)
                        {
                            if (!IsFoundWordHighlighted(Color.Yellow))
                            {
                                HighlightFoundWord(Color.Yellow);
                                FoundCounter++;
                                break;
                            }
                            else
                                continue;
                        }
                        HighlightFoundWord(Color.Yellow);
                        FoundCounter++;
                    }

                    else if (AreStringsEqual(Word.Remove(Word.Length - 1), tbxSearch.Text, IsMatchCase))
                    {
                        RichBox.Select(StartIndex, Word.Length - 1);
                        if (Direction == enSearchDirection.enSearchDown)
                        {
                            if (!IsFoundWordHighlighted(Color.Yellow))
                            {
                                HighlightFoundWord(Color.Yellow);
                                FoundCounter++;
                                break;
                            }
                            else
                                continue;
                        }
                        HighlightFoundWord(Color.Yellow);
                        FoundCounter++;
                    }

                    else if (IsWordHasDash(Word))
                    {
                        SearchAboutUncrossedOutWord(Word, StartIndex, ref FoundCounter);
                    }

                    Word = "";
                }
            }

            if (FoundCounter == 0)
                MessageBox.Show($"Cannot find {tbxSearch.Text}", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private List <string> SplitSearchWordsIntoList()
        {
            List<string> liWords = new List<string>();
            string Word = default(string);
            for (int i = 0; i < tbxSearch.Text.Length; i++)
            {
                bool IsValidLetter = IsValidTextChar(tbxSearch.Text[i]);

                if (IsValidLetter)
                {
                    Word += tbxSearch.Text[i];
                }

                if ((!IsValidLetter || i == tbxSearch.Text.Length - 1) && Word.Length > 0)
                {
                    liWords.Add(Word);
                    Word = "";
                }
            }
                return liWords;
        }

        private bool IsUserWordEqualAnySearchWords(string UserWord, List <string>SerachWords)
        {
            foreach (string Word in SerachWords)
            {
                if (UserWord == Word || UserWord.Remove(UserWord.Length - 1) == Word)
                    return true;
            }
            return false;
        }

        private void SearchByMultiWords(enMatchCase IsMatchCase)
        {
            if (Direction == enSearchDirection.enSearchDown)
            {
                MessageBox.Show($"Sorry, cannot search.{Environment.NewLine}Please use normal search with multiple words.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // each document's word will be compared by all search words

            List<string> liSearchWords = new List<string>();
            liSearchWords = SplitSearchWordsIntoList();

            string Word = default(string);
            int StartIndex = default(int);
            int FoundCounter = 0;

            for (int i = 0; i < RichBox.Text.Length; i++)
            {
                bool IsValidChar = IsValidTextChar(RichBox.Text[i]);

                if (IsValidChar)
                {
                    Word += RichBox.Text[i];
                    if (Word.Length == 1)
                    {
                        StartIndex = i;
                    }
                }

                if ((!IsValidChar || i == RichBox.Text.Length - 1) && Word.Length > 0)
                {
                    if (IsUserWordEqualAnySearchWords(Word, liSearchWords))
                    {
                        RichBox.Select(StartIndex, Word.Length);
                        HighlightFoundWord(Color.Yellow);
                        FoundCounter++;
                    }

                    Word = "";
                }
            }

            if (FoundCounter == 0)
                MessageBox.Show($"Cannot find {tbxSearch.Text}", "Failed Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool CheckBoxWordsNumber(TextBox Box)
        {
            return (Box.Text.Length != 0) && (Box.Text.Length <= Box.MaxLength);
        }

        private bool IsProcessValid(TextBox Box)
        {
            return (RichBox.Text.Length != 0) && CheckBoxWordsNumber(Box) && tbxSearch.Text != "Search Here...";
        }

        private bool IsThereOneWordInSerachBox()
        {
            for (int i = 0; i < tbxSearch.Text.Length; i++)
            {
                if (tbxSearch.Text[i] != ' ')
                    continue;
                else
                    return false;
            }
            return true;
        }

        private enSearchMechanisms SelectNumberOfSearchWords()
        {
            if (tbxSearch.Text.Length == 1)
                return enSearchMechanisms.enSingleLetterSearch;

            else if (IsThereOneWordInSerachBox())
                return enSearchMechanisms.enSingleWordSearch;

            else
                return enSearchMechanisms.enMultiWordsSearch;
        }

        private void SearchAboutText(enSearchMechanisms Mechanism)
        {
            switch (Mechanism)
            {
                case enSearchMechanisms.enSingleLetterSearch:
                    SearchByOneLetter(IsMatchCase);
                    break;

                case enSearchMechanisms.enSingleWordSearch:
                    SearchByOneWord(IsMatchCase);
                    break;

                default:
                    SearchByMultiWords(IsMatchCase);
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!IsProcessValid(tbxSearch))
            {
                MessageBox.Show("Document Text or Search box is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Direction = enSearchDirection.enSearchEntireDocument;

            SearchAboutText(SelectNumberOfSearchWords());
        }

        private void ClearHighlightAfterSearch()
        {
            RichBox.SelectAll();
            RichBox.SelectionBackColor = RichBox.BackColor;
            RichBox.Select(RichBox.SelectionStart, 0);
        }

        private void btnClearHighlight_Click(object sender, EventArgs e)
        {
            ClearHighlightAfterSearch();
        }

        private enMatchCase SelectMatchCaseState(CheckState State)
        {
            return State == CheckState.Checked ? enMatchCase.enMatchCase : enMatchCase.enIgnoreCase;
        }

        private void MatchCaseItem_CheckedChanged(object sender, EventArgs e)
        {
            IsMatchCase = SelectMatchCaseState(MatchCaseItem.CheckState);
        }

        private void frmFind_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClearHighlightAfterSearch();
        }

        private void btnSearchDown_Click(object sender, EventArgs e)
        {
            if (!IsProcessValid(tbxSearch))
            {
                MessageBox.Show("Document Text or Search box is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Direction = enSearchDirection.enSearchDown;

            SearchAboutText(SelectNumberOfSearchWords());
        }

        private void tbxSearch_MouseClick(object sender, MouseEventArgs e)
        {
            SetTextBoxStyle(tbxSearch, "", Color.Black, HorizontalAlignment.Left);
        }
    }
}