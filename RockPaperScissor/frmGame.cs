using RockPaperScissor.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RockPaperScissor
{
    public partial class frmGame : Form
    {
        private Random rand = new Random();

        private byte RandomChoiceSeconds = 10;

        private byte RoundNumber = 0;

        private byte UserWins = 0;

        private byte AIWins = 0;

        private byte DrawTimes = 0;

        private enum enGame
        {
            Rock = 1,
            Paper,
            Scissor
        }

        public enum enWinner
        {
            User,
            AI,
            Draw
        }

        private PictureBox UserBox;

        enGame UserChoice;

        enGame AIChoice;

        public frmGame()
        {
            InitializeComponent();
        }

        private byte GetRandomNumber(byte From, byte To)
        {
            return (byte)rand.Next(From, To + 1);
        }

        private void UpdateRoundsNumber()
        {
            RoundNumber++;
            lblRound.Text = RoundNumber.ToString();
        }

        private void SetDataOfGame()
        {
            lblRounds.Text = Form1.RoundsNumber.ToString();
            lblPlayerData.Text = $"{Form1.PlayerName} win's: {UserWins}";
            lblPlayerChoice.Text = $"{Form1.PlayerName} Choice:";
        }

        private void SetInitialGameState()
        {
            this.BackgroundImage = Resources.game;
            SetDataOfGame();
            AITimer.Enabled = true;
            UpdateRoundsNumber();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            SetInitialGameState();
        }

        private void EnterToUserImage(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            box.Top -= 15;
        }

        private void LeaveUserImage(object sender, EventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            box.Top += 15;
        }

        private void FinishTimer()
        {
            AITimer.Enabled = false;
            RandomChoiceSeconds = 10;
        }

        private void SetDefaultTopOfUserImage()
        {
            if (UserBox == pboxUser1)
            {
                pboxUser1.Top += 15;
            }

            else if (UserBox == pboxUser2)
            {
                pboxUser2.Top += 15;
            }

            else
                pboxUser3.Top += 15;
        }

        private bool IsGameOver()
        {
            return RoundNumber == Form1.RoundsNumber;
        }

        private enWinner WhoIsWinner()
        {
            if (UserWins > AIWins)
            {
                return enWinner.User;
            }

            else if (AIWins > UserWins)
            {
                return enWinner.AI;
            }

            return enWinner.Draw;
        }

        private string GetWinnerName()
        {
            switch (WhoIsWinner())
            {
                case enWinner.User:
                    return Form1.PlayerName;
                case enWinner.AI:
                    return "AI";
            }
            return "Draw";
        }

        private void ShutDownForm()
        {
            foreach(Control control in this.Controls)
            {
                if (control != btnExit)
                    control.Enabled = false;
            }
        }

        private void FinishGame()
        {
            MessageBox.Show($"Game over, winner: {GetWinnerName()}", "Game Over", MessageBoxButtons.OK);
            ShutDownForm();
        }

        private void ResetUserBox()
        {
            if (UserBox != null)
            {
                SetDefaultTopOfUserImage();
                UserBox = null;
            }
        }

        private void ProcessEndOfRound()
        {
            SelectRoundWinner();
            if (IsGameOver())
            {
                FinishGame();
                return;
            }
            ResetUserBox();
            AITimer.Enabled = true;
            UpdateRoundsNumber();
        }

        private void SetTimerValue()
        {
            if (RandomChoiceSeconds == 0)
            {
                FinishTimer();
                ProcessEndOfRound();
            }
            else
                RandomChoiceSeconds--;
        }

        private Image GetRandomImage(byte RandomTag)
        {
            switch(RandomTag)
            {
                case 1:
                    return Resources.Rock;
                case 2:
                    return Resources.Paper;
            }
            return Resources.Scissor;
        }

        private void ProcessRandomChoiceOperation()
        {
            byte RandomTag = GetRandomNumber(1, 3);
            AIChoice = (enGame)RandomTag;
            pboxAI.BackgroundImage = GetRandomImage(RandomTag);
        }

        private void HandleAITimer()
        {
            ProcessRandomChoiceOperation();
            SetTimerValue();
        }

        private void AITimer_Tick(object sender, EventArgs e)
        {
            HandleAITimer();
        }

        private void ClickImage(object sender, MouseEventArgs e)
        {
            PictureBox box = (PictureBox)sender;
            UserChoice = (enGame)Convert.ToByte(box.Tag);
            box.Top -= 15;
            UserBox = box;
        }

        private bool IsUserWin()
        {
            if (UserChoice == enGame.Paper && AIChoice == enGame.Rock)
            {
                return true;
            }

            else if (UserChoice == enGame.Scissor && AIChoice == enGame.Paper)
            {
                return true;
            }

            else if (UserChoice == enGame.Rock && AIChoice == enGame.Scissor)
            {
                return true;
            }

            return false;
        }

        private bool IsDraw()
        {
            return UserChoice == AIChoice;
        }

        private void UpdateDrawLabel()
        {
            DrawTimes++;
            lblDraw.Text = DrawTimes.ToString();
        }

        private void UpdateUserWinsLabel()
        {
            UserWins++;
            lblPlayerData.Text = $"{Form1.PlayerName} win's: {UserWins}";
        }

        private void UpdateAIWinsLabel()
        {
            AIWins++;
            lblAIWin.Text = AIWins.ToString();
        }

        private void SelectRoundWinner()
        {
            if (UserBox == null)
            {
                MessageBox.Show("You don't select any image! AI win", "Message", MessageBoxButtons.OK);
                UpdateAIWinsLabel();
            }

            else if (IsDraw())
            {
                MessageBox.Show("Draw", "Message", MessageBoxButtons.OK);
                UpdateDrawLabel();
            }

            else if (IsUserWin())
            {
                MessageBox.Show("You win", "Message", MessageBoxButtons.OK);
                UpdateUserWinsLabel();
            }

            else
            {
                MessageBox.Show("AI win", "Message", MessageBoxButtons.OK);
                UpdateAIWinsLabel();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 Main = new Form1();
            Main.Show();
            this.Close();
        }
    }
}