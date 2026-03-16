using System;
using System.Windows.Forms;
using MathGame.Properties;
using System.Linq;


namespace MathGame
{
    public partial class frmQuiz : Form
    {
        public readonly Form1 QuizInfo;

        public frmQuiz(Form1 Quiz)
        {
            InitializeComponent();
            QuizInfo = Quiz;
        }

        private byte Minutes = 0;

        private byte Seconds = 0;

        private byte QuestionsCounter = 0;

        private byte TrueQuestionsCounter = 0;

        private byte FalseQuestionsCounter = 0;

        RadioButton[] arrRadio = new RadioButton[4];

        private void LoadMultipleChoiceControlsArray()
        {
            arrRadio[0] = rbtnChoice1;
            arrRadio[1] = rbtnChoice2;
            arrRadio[2] = rbtnChoice3;
            arrRadio[3] = rbtnChoice4;
        }

        private enum enLevel
        {
            Easy,
            Medium,
            Hard
        }

        private enum enQuestionsType
        {
            TrueFalse,
            FillInBlank,
            MultipleChoice
        }

        private enum enOperation
        {
            Addition,
            Subtraction,
            Multiplication,
            Divison,
            Mix
        }

        private struct stQuestionInfo
        {
            public enLevel Level;
            public enQuestionsType Type;
            public sbyte Number1;
            public enOperation Operation;
            public sbyte Number2;
        }

        stQuestionInfo Question;

        private Random rand = new Random();

        private void PrepareTrueFalseMode()
        {
            msboxA.Visible = false;
            foreach (RadioButton radio in panQuestions.Controls.OfType<RadioButton>())
            {
                if (radio != rbtnTrue && radio != rbtnFalse)
                    radio.Visible = false;
            }
        }

        private void PrepareFillInBlankMode()
        {
            foreach (RadioButton radio in panQuestions.Controls.OfType<RadioButton>())
            {
                radio.Visible = false;
            }
            msboxA.Focus();
        }

        private void PrepareMultipleChoiceMode()
        {
            LoadMultipleChoiceControlsArray();
            rbtnTrue.Visible = false;
            rbtnFalse.Visible = false;
            msboxA.Visible = false;
        }

        private void ConfigureQuizControls(enQuestionsType Type)
        {
            switch (Type)
            {
                case enQuestionsType.TrueFalse:
                    PrepareTrueFalseMode();
                    return;

                case enQuestionsType.FillInBlank:
                    PrepareFillInBlankMode();
                    return;
            }
            PrepareMultipleChoiceMode();
        }

        private void SetInitialGameState()
        {
            panQuestions.Visible = false;
            ConfigureQuizControls(GetQuestionsType());
            this.BackgroundImage = Resources.GreenBoard;
            ShowQuizInformation();
            SetInitialTimerValues();
            btnStart.Enabled = true;
            btnCheck.Enabled = false;
        }

        private void frmQuiz_Load(object sender, EventArgs e)
        {
            SetInitialGameState();
        }

        private void StartQuiz()
        {
            panQuestions.Visible = true;
            lblResult.Text = "In Progress";
            QuizTimer.Enabled = true;
            GenerateQuestion();
            btnStart.Enabled = false;
            btnCheck.Enabled = true;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            StartQuiz();
        }

        public void ShowQuizInformation(frmResults results = null)
        {
            if (results != null)
            {
                results.lblLevel.Text = QuizInfo.Quiz.QuizLevel;
                results.lblOperation.Text = QuizInfo.Quiz.OperationType;
                results.lblQsType.Text = QuizInfo.Quiz.QuestionsType;
                results.lblQsNumber.Text = QuizInfo.Quiz.QuestionsNumber.ToString();
                results.lblTime.Text = QuizInfo.Quiz.QuizTime.ToString() + " Minute(s)";
                return;
            }
            lblLevel.Text = QuizInfo.Quiz.QuizLevel;
            lblOperation.Text = QuizInfo.Quiz.OperationType;
            lblQsType.Text = QuizInfo.Quiz.QuestionsType;
            lblQsNumber.Text = QuizInfo.Quiz.QuestionsNumber.ToString();
            lblTime.Text = QuizInfo.Quiz.QuizTime.ToString() + " Minute(s)";
        }

        private void UpdateTimerLabels()
        {
            lblMinutes.Text = Minutes.ToString();
            lblSeconds.Text = Seconds.ToString();
        }

        private void SetInitialTimerValues()
        {
            Minutes = QuizInfo.Quiz.QuizTime;
            Minutes--;
            Seconds = 59;
        }

        private void DisableAllControlsExceptExit()
        {
            foreach (Control control in this.Controls)
            {
                if (control != btnExit)
                    control.Enabled = false;
            }
        }

        private void EndQuizDueToTimeOut()
        {
            MessageBox.Show(
                "The quiz is not completed!\nTime is finished!",
                "Game Finished",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
            DisableAllControlsExceptExit();
        }

        private void SetTimerValues()
        {
            if (Seconds == 0 && Minutes == 0)
            {
                QuizTimer.Enabled = false;
                EndQuizDueToTimeOut();
            }

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
            UpdateTimerLabels();
            SetTimerValues();
        }

        private void QuizTimer_Tick(object sender, EventArgs e)
        {
            HandleTimerTick();
        }

        RadioButton radio;

        private enLevel GetQuizLevel()
        {
            switch (QuizInfo.Quiz.QuizLevel)
            {
                case "Easy":
                    return enLevel.Easy;
                case "Medium":
                    return enLevel.Medium;
            }
            return enLevel.Hard;
        }

        private enOperation GetOperationEnum()
        {
            switch (QuizInfo.Quiz.OperationType)
            {
                case "Addition (+)":
                    return enOperation.Addition;
                case "Subtraction (-)":
                    return enOperation.Subtraction;
                case "Multiplication (*)":
                    return enOperation.Multiplication;
                case "Division (/)":
                    return enOperation.Divison;
            }
            return enOperation.Mix;
        }

        private enQuestionsType GetQuestionsType()
        {
            switch (QuizInfo.Quiz.QuestionsType)
            {
                case "True/False":
                    return enQuestionsType.TrueFalse;
                case "Fill in Blank":
                    return enQuestionsType.FillInBlank;
            }
            return enQuestionsType.MultipleChoice;
        }

        private sbyte GetRandomNumber(sbyte From, byte To)
        {
            return (sbyte)rand.Next(From, To + 1);
        }

        private sbyte GenerateNumberInLevel(enLevel QuizLevel)
        {
            switch (QuizLevel)
            {
                case enLevel.Easy:
                    return GetRandomNumber(0, 30);
                case enLevel.Medium:
                    return GetRandomNumber(50, 100);
            }
            return GetRandomNumber(100, 255);
        }

        private enOperation SelectRandomOperation()
        {
            sbyte Random = GetRandomNumber((sbyte)enOperation.Addition, (byte)enOperation.Divison);
            switch (Random)
            {
                case 0:
                    return enOperation.Addition;
                case 1:
                    return enOperation.Subtraction;
                case 2:
                    return enOperation.Multiplication;

            }
            return enOperation.Divison;
        }

        private void HandleDivisionByZero(ref sbyte divisor)
        {
            if (divisor == 0)
                divisor = 1;
        }

        private stQuestionInfo FillQuestionStructure()
        {
            stQuestionInfo NewQuestion;
            NewQuestion.Level = GetQuizLevel();
            NewQuestion.Type = GetQuestionsType();
            NewQuestion.Number1 = GenerateNumberInLevel(NewQuestion.Level);
            NewQuestion.Operation = GetOperationEnum();
            if (NewQuestion.Operation == enOperation.Mix)
            {
                NewQuestion.Operation = SelectRandomOperation();
            }
            NewQuestion.Number2 = GenerateNumberInLevel(NewQuestion.Level);
            if (NewQuestion.Operation == enOperation.Divison)
            {
                HandleDivisionByZero(ref NewQuestion.Number2);
            }
            return NewQuestion;
        }

        private char GetOperationLetter(enOperation operation)
        {
            switch (operation)
            {
                case enOperation.Addition:
                    return '+';
                case enOperation.Subtraction:
                    return '-';
                case enOperation.Multiplication:
                    return '*';
            }
            return '/';
        }

        private float GetSystemAnswer(sbyte Number1, sbyte Number2, enOperation operation)
        {
            switch (operation)
            {
                case enOperation.Addition:
                    return Number1 + Number2;
                case enOperation.Subtraction:
                    return Number1 - Number2;
                case enOperation.Multiplication:
                    return Number1 * Number2;
            }
            return Number1 / Number2;
        }

        private float ProcessAnswerInTrueFalseMode()
        {
            sbyte Flag = GetRandomNumber(0, 1);
            if (Flag == 1) // true
            {
                rbtnTrue.Tag = Flag;
                return GetSystemAnswer(Question.Number1, Question.Number2, Question.Operation);
            }
            rbtnFalse.Tag = Flag;
            return GenerateNumberInLevel(Question.Level);
        }

        private void SetMaskFormat(float QuestionAnswer, string DefaultFormat = "0000")
        {
            if (Question.Operation == enOperation.Subtraction && QuestionAnswer < 0)
            {
                msboxA.Mask = "-0000";
                return;
            }
            msboxA.Mask = DefaultFormat;
        }

        private void ProcessAnswerInFillInBlankMode()
        {
            float Answer = GetSystemAnswer(Question.Number1, Question.Number2, Question.Operation);
            SetMaskFormat(Answer);
            msboxA.Tag = Answer;
        }

        private sbyte GetRandomNumberInMultipleChoiceMode()
        {
            if (Question.Operation == enOperation.Multiplication)
                return GetRandomNumber(127, 255);

            else if (Question.Operation == enOperation.Subtraction)
                return GetRandomNumber(-128, 128);

            else
                return GenerateNumberInLevel(Question.Level);
        }

        private void ProcessAnswerInMultipleChoiceMode()
        {
            sbyte RandomIndex = GetRandomNumber(0, 3);
            arrRadio[RandomIndex].Text = GetSystemAnswer(Question.Number1, Question.Number2, Question.Operation).ToString();
            arrRadio[RandomIndex].Tag = true;
            for (byte i = 0; i < arrRadio.Length; i++)
            {
                if (i != RandomIndex)
                    arrRadio[i].Text = GetRandomNumberInMultipleChoiceMode().ToString();
            }
        }

        private void ShowQuestion()
        {
            tbxQuestion.Text = $"{Environment.NewLine}Q({QuestionsCounter}): {Question.Number1} {GetOperationLetter(Question.Operation)} {Question.Number2} = ";
        }

        private void ProcessShowAnswer()
        {
            switch (Question.Type)
            {
                case enQuestionsType.TrueFalse:
                    tbxQuestion.Text += ProcessAnswerInTrueFalseMode().ToString();
                    return;

                case enQuestionsType.FillInBlank:
                    ProcessAnswerInFillInBlankMode();
                    return;
            }
            ProcessAnswerInMultipleChoiceMode();
        }

        private void GenerateQuestion()
        {
            if (QuestionsCounter <= QuizInfo.Quiz.QuestionsNumber)
            {
                QuestionsCounter++;
                Question = FillQuestionStructure();
                ShowQuestion();
                ProcessShowAnswer();
            }
        }

        private void ChooseTrueOrFalse(object sender, EventArgs e)
        {
            radio = (RadioButton)sender;
        }

        private bool CheckAnswerInTrueFalseMode()
        {
            return radio.Tag != null;
        }

        private bool CheckAnswerOfFill_InBlankMode()
        {
            return (float)msboxA.Tag == Convert.ToSingle(msboxA.Text);
        }

        private bool CheckAnswerInMultipleChoiceMode()
        {
            for (byte i = 0; i < arrRadio.Length; i++)
            {
                if (arrRadio[i].Checked)
                {
                    if (arrRadio[i].Tag == null) // wrong answer
                        return false;
                    else
                        return true;
                }
            }
            return false;
        }

        private bool CheckUserAnswer()
        {
            switch (Question.Type)
            {
                case enQuestionsType.TrueFalse:
                    return CheckAnswerInTrueFalseMode();

                case enQuestionsType.FillInBlank:
                    return CheckAnswerOfFill_InBlankMode();
            }
            return CheckAnswerInMultipleChoiceMode();
        }

        private void ClearControlsInTrueFalseMode()
        {
            rbtnTrue.Checked = false;
            rbtnTrue.Tag = null;
            rbtnFalse.Checked = false;
            rbtnFalse.Tag = null;
            radio = null;
        }

        private void ClearControlInFillInBlankMode(Control FillingControlName)
        {
            FillingControlName.Tag = null;
            FillingControlName.Text = "";
        }

        private void ClearControlsInMultipleChoiceMode()
        {
            for (byte i = 0; i < arrRadio.Length; i++)
            {
                if (arrRadio[i].Checked)
                    arrRadio[i].Checked = false;

                if (arrRadio[i].Tag != null)
                    arrRadio[i].Tag = null;
            }
        }

        private void ClearControlAfterAnswer()
        {
            switch (Question.Type)
            {
                case enQuestionsType.TrueFalse:
                    ClearControlsInTrueFalseMode();
                    return;

                case enQuestionsType.FillInBlank:
                    ClearControlInFillInBlankMode(msboxA);
                    return;
            }
            ClearControlsInMultipleChoiceMode();
        }

        private void UpdateTrueQuestionsNumber()
        {
            TrueQuestionsCounter++;
            lblTrueQs.Text = TrueQuestionsCounter.ToString();
        }

        private void UpdateFalseQuestionsNumber()
        {
            FalseQuestionsCounter++;
            lblFalseQs.Text = FalseQuestionsCounter.ToString();
        }

        private void UpdateQuestionsNumber()
        {
            if (CheckUserAnswer())
            {
                MessageBox.Show("Right answer!", "Message", MessageBoxButtons.OK);
                UpdateTrueQuestionsNumber();
            }

            else
            {
                MessageBox.Show("Wrong answer!" + Environment.NewLine + $"Correct unswer is {GetSystemAnswer(Question.Number1, Question.Number2, Question.Operation)}", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                UpdateFalseQuestionsNumber();
            }
        }

        private void MoveToNextQuestion()
        {
            UpdateQuestionsNumber();
            ClearControlAfterAnswer();
            GenerateQuestion();
        }

        private bool IsQuizCompleted()
        {
            return QuestionsCounter == QuizInfo.Quiz.QuestionsNumber;
        }

        public bool IsUserPass()
        {
            return Convert.ToByte(lblTrueQs.Text) > Convert.ToByte(lblFalseQs.Text);
        }

        private void ShowResultsForm()
        {
            frmResults QuizResult = new frmResults(this);
            QuizResult.Show();
            this.Close();
        }

        private void EndQuizDueToCompletion()
        {
            QuizTimer.Enabled = false;
            MessageBox.Show("Great Job\n\nYou've completed the quiz.\nClick ok to see final results",
                "Game Finished",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            ShowResultsForm();
        }

        private bool IsAnswerChoosedInTrueFalseMode()
        {
            return radio != null;
        }

        private bool IsUserAnswerEntered()
        {
            return !string.IsNullOrWhiteSpace(msboxA.Text);
        }

        private bool IsAnswerChoosedInMultipleChoiceMode()
        {
            foreach (RadioButton radio in arrRadio)
            {
                if (radio.Checked)
                    return true;
            }
            return false;
        }

        private bool IsAnswerProvided()
        {
            switch(Question.Type)
            {
                case enQuestionsType.TrueFalse:
                    if (!IsAnswerChoosedInTrueFalseMode())
                    {
                        MessageBox.Show("You don't select answer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    break;

                case enQuestionsType.FillInBlank:
                    if (!IsUserAnswerEntered())
                    {
                        MessageBox.Show("You don't write answer!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    break;

                case enQuestionsType.MultipleChoice:
                    if (!IsAnswerChoosedInMultipleChoiceMode())
                    {
                        MessageBox.Show("You don't select answer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    break;
            }
            return true;
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (!IsAnswerProvided())
            {
                return;
            }

            else if (IsQuizCompleted())
            {
                UpdateQuestionsNumber();
                EndQuizDueToCompletion();
                return;
            }
            MoveToNextQuestion();
        }

        private void BackToMainScreen()
        {
            QuizInfo.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            BackToMainScreen();
        }
    }
}