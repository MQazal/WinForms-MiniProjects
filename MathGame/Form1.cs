using System;
using System.Linq;
using System.Windows.Forms;
using MathGame.Properties;

namespace MathGame
{
    public partial class Form1 : Form
    {
        public struct stQuizInfo
        {
            public string QuizLevel; // enum
            public string QuestionsType; // enum
            public string OperationType; // enum
            public byte QuestionsNumber;
            public byte QuizTime;
        }

        public stQuizInfo Quiz;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.Board2;
        }

        private string SelectQuizLevel()
        {
            foreach (RadioButton Level in gbxQuizLevels.Controls)
            {
                if (Level.Checked)
                {
                    return Level.Text;
                }
            }
            return null;
        }

        private string SelectQuestionsType()
        {
            foreach (RadioButton Type in gbxQuestionsType.Controls)
            {
                if (Type.Checked)
                {
                    return Type.Text;
                }
            }
            return null;
        }

        private string SelectOperationType()
        {
            foreach (RadioButton Operation in gbxOperations.Controls)
            {
                if (Operation.Checked)
                {
                    return Operation.Text;
                }
            }
            return null;
        }

        private bool IsOperationSelected()
        {
            foreach (RadioButton radio in gbxOperations.Controls.OfType<RadioButton>())
            {
                if (radio.Checked)
                    return true;
            }
            return false;
        }

        private bool IsQuestionsTypeSelected()
        {
            foreach (RadioButton radio in gbxQuestionsType.Controls.OfType<RadioButton>())
            {
                if (radio.Checked)
                    return true;
            }
            return false;
        }

        private bool IsQuestionsNumberEqualZero()
        {
            return (byte)numQuestionsNumber.Value == 0;
        }

        private bool IsQuizTimeEqualZero()
        {
            return (byte)numQuizTime.Value == 0;
        }

        private bool IsValidForm()
        {
            if (!IsOperationSelected())
            {
                errorProvider1.SetError(gbxOperations, "Select Mathmatical Operation!");
                return false;
            }

            else if (!IsQuestionsTypeSelected())
            {
                errorProvider1.SetError(gbxQuestionsType, "Select Questions Type!");
                return false;
            }

            else if (IsQuestionsNumberEqualZero())
            {
                errorProvider1.SetError(numQuestionsNumber, "Please enter questions number grater than 0.");
                return false;
            }

            else if (IsQuizTimeEqualZero())
            {
                errorProvider1.SetError(numQuizTime, "Please enter number of minutes grater than 0.");
                return false;
            }

            return true;
        }

        private void FillQuizInfo()
        {
            // fill valid form in quiz structure
            Quiz.QuizLevel = SelectQuizLevel();
            Quiz.QuestionsType = SelectQuestionsType();
            Quiz.OperationType = SelectOperationType();
            Quiz.QuestionsNumber = (byte)numQuestionsNumber.Value;
            Quiz.QuizTime = (byte)numQuizTime.Value;
        }

        private void StartGame()
        {
            frmQuiz Quiz = new frmQuiz(this); // constructor
            Quiz.Show();
            this.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            if (!IsValidForm())
            {
                return;
            }
            FillQuizInfo();
            StartGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}