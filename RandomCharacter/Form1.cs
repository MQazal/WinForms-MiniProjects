using System;
using System.Linq;
using System.Windows.Forms;
using RandomCharacter.Properties;
using System.Collections.Generic;

namespace RandomCharacter
{
    public partial class Form1 : Form
    {
        Random rand = new Random();

        private enum enCharacters
        {
            Capital,
            Small,
            Special,
            Digit
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panRandom.BackgroundImage = Resources.Shadow;
        }

        private bool IsThereCheckedBox()
        {
            foreach (CheckBox box in panRandom.Controls.OfType<CheckBox>())
            {
                if (box.Checked)
                    return true;
            }
            return false;
        }

        private bool IsFormValid()
        {
            errorProvider1.Clear();
            if (!IsThereCheckedBox())
            {
                errorProvider1.SetError(panRandom, "Select type of random character!");
                return false;
            }
            if (numLettersNumber.Value == 0)
            {
                errorProvider1.SetError(numLettersNumber, "Choose number of characters!");
                return false;
            }
            return true;
        }

        private void UncheckBoxes(CheckBox OptionalCheckedBox = null)
        {
            foreach(CheckBox Box in panRandom.Controls.OfType<CheckBox>())
            {
                if (Box != OptionalCheckedBox)
                    Box.CheckState = CheckState.Unchecked;
            }
        }

        private bool AreBoxesChecked()
        {
            return chboxCapital.Checked && chboxSmall.Checked && chboxSpecial.Checked && chboxDigit.Checked;
        }

        private void CheckBox(object sender, EventArgs e)
        {
            CheckBox Box = (CheckBox)sender;

            if (Box == chboxMix && Box.Checked)
            {
                UncheckBoxes(chboxMix);
                return;
            }

            if (Box != chboxMix && chboxMix.Checked)
            {
                Box.Checked = true;
                chboxMix.Checked = false;
                return;
            }

            if (AreBoxesChecked())
            {
                UncheckBoxes(chboxMix);
                chboxMix.Checked = true;
                return;
            }
        }

        private byte GenerateRandomNumber(byte From, byte To)
        {
            return (byte)rand.Next(From, To + 1);
        }

        private char GenerateRandomCapitalLetter()
        {
            return (char)GenerateRandomNumber((byte)'A', (byte)'Z');
        }

        private char GenerateRandomSmallLetter()
        {
            return (char)GenerateRandomNumber((byte)'a', (byte)'z');
        }

        private char GenerateRandomSpecialLetter()
        {
            switch(GenerateRandomNumber(1,4))
            {
                case 1:
                    return (char)GenerateRandomNumber((byte)'!', (byte)'/');
                case 2:
                    return (char)GenerateRandomNumber((byte)':', (byte)'@');
                case 3:
                    return (char)GenerateRandomNumber((byte)'[', (byte)'`');
            }
            return (char)GenerateRandomNumber((byte)'{', (byte)'~');
        }

        private char GenerateRandomDigit()
        {
            return (char)GenerateRandomNumber((byte)'0', (byte)'9');
        }

        private enCharacters GetLettersType()
        {
            if (chboxCapital.Checked)
                return enCharacters.Capital;

            else if (chboxSmall.Checked)
                return enCharacters.Small;

            else if (chboxSpecial.Checked)
                return enCharacters.Special;

            else
                return enCharacters.Digit;
        }

        private char GenerateRandomCharacter(enCharacters charactersType)
        {
            switch (charactersType)
            {
                case enCharacters.Capital:
                    return GenerateRandomCapitalLetter();

                case enCharacters.Small:
                    return GenerateRandomSmallLetter();

                case enCharacters.Special:
                    return GenerateRandomSpecialLetter();                    
            }
            return GenerateRandomDigit();
        }

        private string GenerateTextInSingleTypeMode()
        {
            string Text = "";
            while (Text.Length != numLettersNumber.Value)
            {
                Text += GenerateRandomCharacter(GetLettersType());
            }
            return Text;
        }

        private string GenerateMixedText()
        {
            string MixedString = "";
            while(MixedString.Length != numLettersNumber.Value)
            {
                enCharacters Type = (enCharacters)GenerateRandomNumber((byte)enCharacters.Capital, (byte)enCharacters.Digit);
                MixedString += GenerateRandomCharacter(Type);
            }
            return MixedString;
        }

        private byte NumberOfCheckedBoxes()
        {
            byte Counter = 0;
            foreach (CheckBox box in panRandom.Controls.OfType<CheckBox>())
            {
                if (box.Checked)
                    Counter++;
            }
            return Counter;
        }

        private bool IsNumberInRange(byte Number, byte From, byte To)
        {
            return (Number >= From && Number <= To);
        }

        private List <enCharacters> FillCharactersTypesList()
        {
            List<enCharacters> charactersList = new List<enCharacters>();

            if (chboxCapital.Checked)
                charactersList.Add(enCharacters.Capital);

            if (chboxSmall.Checked)
                charactersList.Add(enCharacters.Small);

            if (chboxSpecial.Checked)
                charactersList.Add(enCharacters.Special);

            if (chboxDigit.Checked)
                charactersList.Add(enCharacters.Digit);

            return charactersList;
        }

        private string GenerateTextInMultipleTypeMode()
        {
            string Text = "";
            List<enCharacters> TypesList = FillCharactersTypesList();
            while (Text.Length != numLettersNumber.Value)
            {
                Text += GenerateRandomCharacter(TypesList[GenerateRandomNumber(0, Convert.ToByte(TypesList.Count - 1))]);
            }
            return Text;
        }

        private string GenerateRandomText()
        {
            if (chboxMix.Checked)
            {
                return GenerateMixedText();
            }

            if (IsNumberInRange(NumberOfCheckedBoxes(), 2, 3))
            {
                return GenerateTextInMultipleTypeMode();
            }

            return GenerateTextInSingleTypeMode();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            if (!IsFormValid())
            {
                return;
            }
            tbxRandom.Text = GenerateRandomText();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxRandom.Clear();
            UncheckBoxes();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}