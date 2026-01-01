using GameMemory.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

// Here you set default image in front of button and in the back you get hidden image from list by index that is stored in Tag properity.

namespace GameMemory
{
    public partial class Form1 : Form
    {
        private List<int> ImagesIndexList = new List<int>();

        private Button[] arrButtons;

        private Random rand = new Random();

        private SoundPlayer sound;

        private byte Minutes = 0;

        private byte Seconds = 0;

        private byte DelaySeconds = 0;

        enum enLevel
        {
            Easy,
            Medium,
            Hard
        }

        private Button TempButton1 = null;

        private Button TempButton2 = null;

        private byte Score = 0;

        private bool IsGameRun = false;

        enum enGameOver
        {
            WinByScore,
            LoseByTimeOut
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateButtonsState()
        {
            foreach (Button button in panel_Tools.Controls.OfType<Button>())
            {
                if (button == btnStart || button == btnExit)
                {
                    continue;
                }
                button.Enabled = IsGameRun;
            }
        }

        private void InitializeGameState()
        {
            panel_Images.Enabled = false;
            UpdateButtonsState();
            sound = new SoundPlayer(Resources.Ding_Sound_Effect);
        }

        private void LoadGameImagesList()
        {
            GameList.Images.Add(Resources.QuestionMark); // default/back image
            GameList.Images.Add(Resources.AI);
            GameList.Images.Add(Resources.Virus);
            GameList.Images.Add(Resources.Hack);
            GameList.Images.Add(Resources.Network);
            GameList.Images.Add(Resources.Console);
            GameList.Images.Add(Resources.CS);
            GameList.Images.Add(Resources.C_);
            GameList.Images.Add(Resources.DB);
            GameList.Images.Add(Resources.Desk_App);
            GameList.Images.Add(Resources.DS);
            GameList.Images.Add(Resources.IOT);
            GameList.Images.Add(Resources.Mobile_App);
            GameList.Images.Add(Resources.OS);
        }

        private void InitializeImagesIndexList()
        {
            for (byte i = 1; i < GameList.Images.Count; i++)
            {
                ImagesIndexList.Add(i);
                ImagesIndexList.Add(i);
            }
        }

        private void Swap(int ImageIndex1, int ImageIndex2)
        {
            int Temp = ImagesIndexList[ImageIndex1];
            ImagesIndexList[ImageIndex1] = ImagesIndexList[ImageIndex2];
            ImagesIndexList[ImageIndex2] = Temp;
        }

        private void ShuffleIndexesList()
        {
            for (int i = ImagesIndexList.Count - 1; i > 0; i--)
            {
                int j = rand.Next(i + 1);
                Swap(i, j);
            }
        }

        private void LoadButtonsArray()
        {
            // instaded of manual indexing management use .ToArray() to get new ordered array to store buttons of panel
            arrButtons = panel_Images.Controls.OfType<Button>().OrderBy(button => button.TabIndex).ToArray(); // 1 -> 26 TabIndex
        }

        private void SetButtonsImageToDefault()
        {
            for (byte i = 0; i < arrButtons.Length; i++)
            {
                arrButtons[i].Image = GameList.Images[0];
            }
        }

        private void FillTagByImage(byte buttonIndex)
        {
            int imageIndex = ImagesIndexList.ElementAt(buttonIndex);
            arrButtons[buttonIndex].Tag = imageIndex;
        }

        private void FillButtonsTags()
        {
            ShuffleIndexesList();
            for (byte i = 0; i < arrButtons.Length; i++)
            {
                FillTagByImage(i);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeGameState();
            LoadGameImagesList();
            InitializeImagesIndexList();
            LoadButtonsArray();
            SetButtonsImageToDefault();
            FillButtonsTags();
            this.BackgroundImage = Resources.BackGround2;
        }

        private bool IsRepeatClickOnSameButton(Button ClickedButton)
        {
            return TempButton1 != null && ClickedButton == TempButton1;
        }

        private void PlayClickSound()
        {
            if (btnSound.Tag.ToString() == "On")
                sound.Play();
            else
                sound.Stop();
        }

        private void FillTempButtons(Button ClickedButton)
        {
            if (TempButton1 == null)
                TempButton1 = ClickedButton;
            else
                TempButton2 = ClickedButton;
        }

        private bool AreTempButtonsEmpty()
        {
            return (TempButton1 == null) || (TempButton2 == null);
        }

        private bool ArePicturesSimilar()
        {
            // Compare integer indices stored in Tag
            return (int)TempButton1.Tag == (int)TempButton2.Tag;
        }

        private void UpdateScore()
        {
            Score++;
            tbxScore.Text = Score.ToString();
        }

        private void SetButtonToDefaultImage(Button UsedButton)
        {
            UsedButton.Image = GameList.Images[0]; // Question mark
        }

        private void EmptyTempButtons()
        {
            TempButton1 = null;
            TempButton2 = null;
        }

        private void ProcessSelectedButtons(bool AreButtonsEqual)
        {
            if (AreButtonsEqual)
            {
                UpdateScore();
                TempButton1.Enabled = false;
                TempButton2.Enabled = false;
            }
            else
            {
                SetButtonToDefaultImage(TempButton1);
                SetButtonToDefaultImage(TempButton2);
            }
            EmptyTempButtons();
        }

        private void SetSecondsDelay()
        {
            if (DelaySeconds == 0)
            {
                DelayTimer.Enabled = false;
                ProcessSelectedButtons(false);
            }
            else
                DelaySeconds--;
        }

        private void DelayTimer_Tick(object sender, EventArgs e)
        {
            SetSecondsDelay();
        }

        private void CompareSelectedButtons()
        {
            if (ArePicturesSimilar())
                ProcessSelectedButtons(true);
            else
            {
                // Delay time to show second button's picture
                DelaySeconds = 1;
                DelayTimer.Enabled = true;
            }
        }

        private void HandleButtonSelection(Button ClickedButton)
        {
            FillTempButtons(ClickedButton);
            if (AreTempButtonsEmpty())
                return;
            else
                CompareSelectedButtons();
        }

        private bool IsUserWin()
        {
            return Score == GameList.Images.Count - 1;
        }

        private void ClickButton(object sender, EventArgs e)
        {
            PlayClickSound();
            Button button = (Button)sender;
            if (IsRepeatClickOnSameButton(button))
            {
                MessageBox.Show("You cannot click same button!", "Game Error", MessageBoxButtons.OK);
                return;
            }
            int imageIndex = (int)button.Tag;
            button.Image = GameList.Images[imageIndex];
            HandleButtonSelection(button);
            if (IsUserWin())
                FinishGame(enGameOver.WinByScore);
        }

        private enLevel GetDifficultyLevel(int IndexLevel)
        {
            switch (IndexLevel)
            {
                case 0:
                    return enLevel.Easy;
                case 1:
                    return enLevel.Medium; 
            }
            return enLevel.Hard;
        }

        private void SetTimerLevelValue(enLevel level)
        {
            switch (level)
            {
                case enLevel.Easy:
                    Minutes = 10;
                    break;
                case enLevel.Medium:
                    Minutes = 3;
                    break;
                case enLevel.Hard:
                    Minutes = 2;
                    break;
            }
        }

        private void ShowTimerLevel()
        {
            tbxMinute.Text = Minutes.ToString();
            tbxSecond.Text = Seconds.ToString();
        }

        private void ChangeLevel(object sender, EventArgs e)
        {
            SetTimerLevelValue(GetDifficultyLevel(cmboxDifficultyLevel.SelectedIndex));
            ShowTimerLevel();
        }

        private void UpdateTimerLevelValue()
        {
            if (Seconds == 0 && Minutes == 0)
                FinishGame(enGameOver.LoseByTimeOut);

            else if (Seconds == 0)
            {
                Minutes--;
                Seconds = 59;
            }

            else
                Seconds--;
        }

        private void HandleTimerTick()
        {
            UpdateTimerLevelValue();
            ShowTimerLevel();
        }

        private void GameLevelTimer_Tick(object sender, EventArgs e)
        {
            HandleTimerTick();
        }

        private void FinishGame(enGameOver Mode)
        {
            GameLevelTimer.Enabled = false;
            if (Mode == enGameOver.WinByScore)
                MessageBox.Show("Congratulations!", "Game Over", MessageBoxButtons.OK);
            else
                MessageBox.Show("Game over, time out!", "Game Over", MessageBoxButtons.OK);
            ResetGame();
        }

        private void StartGame()
        {
            if (cmboxDifficultyLevel.SelectedIndex == -1)
            {
                errorProvider1.SetError(cmboxDifficultyLevel, "Please Select Difficulty Level!");
                return;
            }

            errorProvider1.Clear();
            IsGameRun = true;
            UpdateButtonsState();
            GameLevelTimer.Enabled = true;
            panel_Images.Enabled = true;
            btnStart.Enabled = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            GameLevelTimer.Enabled = false;
            panel_Images.Enabled = false;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            GameLevelTimer.Enabled = true;
            panel_Images.Enabled = true;
        }

        private void ToggleSoundState()
        {
            if (btnSound.Tag.ToString() == "On")
            {
                btnSound.Tag = "Off";
                btnSound.Text = "Sound: Off";
                btnSound.ImageIndex = 4;
            }
            else
            {
                btnSound.Tag = "On";
                btnSound.Text = "Sound: On";
                btnSound.ImageIndex = 3;
            }
        }

        private void btnSound_Click(object sender, EventArgs e)
        {
            ToggleSoundState();
        }

        private void EnableButtons()
        {
            foreach (Button button in arrButtons)
            {
                button.Enabled = true;
            }
        }

        private void ResetIndexesList()
        {
            ImagesIndexList.Clear();
            InitializeImagesIndexList();
        }

        private void ResetImages()
        {
            ResetIndexesList();
            EnableButtons();
            SetButtonsImageToDefault();
            FillButtonsTags();
        }

        private void ResetDifficultyLevelBox()
        {
            cmboxDifficultyLevel.SelectedIndex = -1;
        }

        private void ResetTimer()
        {
            GameLevelTimer.Enabled = false;
            Minutes = 0;
            Seconds = 0;
            tbxMinute.Clear();
            tbxSecond.Clear();
        }

        private void ResetScore()
        {
            Score = 0;
            tbxScore.Text = Score.ToString();
        }

        private void ResetGame()
        {
            IsGameRun = false;
            ResetImages();
            InitializeGameState();
            ResetDifficultyLevelBox();
            ResetTimer();
            ResetScore();
            btnStart.Enabled = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}