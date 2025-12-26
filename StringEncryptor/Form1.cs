using System;
using System.Drawing;
using System.Windows.Forms;

namespace StringEncryptor
{
    public partial class Form1 : Form
    {
        private byte Minutes = 1;

        private byte Seconds = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetDefaultText();
            lblMinutes.Visible = false;
            lblSeconds.Visible = false;
            label4.Visible = false;
        }

        private void UpdateTimerLabels(Label lblMinutes, Label lblSeconds)
        {
            lblMinutes.Text = Minutes.ToString();
            lblSeconds.Text = Seconds.ToString();
        }

        private void ProcessTimerTick()
        {
            timer1.Enabled = true;

            if (Seconds == 0)
            {
                if (Minutes == 0)
                {
                    timer1.Enabled = false;
                    Minutes = 1;
                    Seconds = 0;
                }
                else
                {
                    Seconds = 59;
                    Minutes--;
                }
            }
            else
            {
                Seconds--;
            }
            UpdateTimerLabels(lblMinutes, lblSeconds);
        }

        private void ProcessProgressBar(int MinimumValue, int MaximumValue)
        {
            progressBar1.Minimum = MinimumValue;
            progressBar1.Maximum = MaximumValue; // Seconds of Minutes + Seconds = Full Timer -> 100% of Progress Bar
            if (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value += 1;
                lblProgress.Text = ((progressBar1.Value * 100) / progressBar1.Maximum).ToString() + "%";
            }
            else
            {
                progressBar1.Value = 0;
                lblProgress.Text = "0%";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ProcessTimerTick();
            ProcessProgressBar(0, 60);
        }

        private void SetDefaultText()
        {
            tbxOriginal.ForeColor = Color.Gray;
            tbxOriginal.Text = "Enter your text...";
        }

        private void StartTyping(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Text == "Enter your text...")
                box.Clear();
            box.ForeColor = Color.Black;
        }

        private void FinishTyping(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            if (box.Text == "")
                SetDefaultText();
        }

        private byte LetterToASCII(char Letter)
        {
            return (byte)Letter;
        }

        private byte IncreaseASCIIByEncryptionKey(byte ASCII, byte EncryptionKey)
        {
            return (byte)(ASCII + EncryptionKey);
        }

        private char ASCIIToLetter(byte ASCII)
        {
            return (char)ASCII;
        }

        private string EncryptText(string OriginalText, byte EncryptionKey)
        {
            string EncryptedText = default(string);
            for (byte i = 0; i < OriginalText.Length; i++)
            {
                EncryptedText += ASCIIToLetter((byte)IncreaseASCIIByEncryptionKey(LetterToASCII(OriginalText[i]), EncryptionKey));
            }
            return EncryptedText;
        }

        private byte DecreaseASCIIByEncryptionKey(byte ASCII, byte EncryptionKey)
        {
            return (byte)(ASCII - EncryptionKey);
        }

        private string DecryptText(string EncryptedText, byte EncryptionKey)
        {
            string DecryptedText = default(string);
            for (byte i = 0; i < EncryptedText.Length; i++)
            {
                DecryptedText += ASCIIToLetter((byte)DecreaseASCIIByEncryptionKey(LetterToASCII(EncryptedText[i]), EncryptionKey));
            }
            return DecryptedText;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            timer1.Start();
            while (timer1.Enabled)
            {
                Application.DoEvents(); // Allows UI to update and timer to tick
            }
            tbxEncrypted.Text = EncryptText(tbxOriginal.Text, (byte)trkEncryptionKey.Value);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            timer1.Start();
            while (timer1.Enabled)
            {
                Application.DoEvents(); // Allows UI to update and timer to tick
            }
            tbxDecrypted.Text = DecryptText(tbxEncrypted.Text, (byte)trkEncryptionKey.Value);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            SetDefaultText();
            tbxEncrypted.Clear();
            tbxDecrypted.Clear();
        }
    }
}