using System;
using System.Windows.Forms;
using System.Drawing;

namespace MathGame
{
    public partial class frmResults : Form
    {
        private readonly frmQuiz quiz;

        public frmResults(frmQuiz Quiz)
        {
            InitializeComponent();
            quiz = Quiz;
        }

        private void ShowQuizResult()
        {
            if (quiz.IsUserPass())
                lblResult.Text = "Good job, you Pass Quiz";
            else
                lblResult.Text = "Good luck, you failed";
        }

        private void ChangeBackgroundColor()
        {
            if (quiz.IsUserPass())
                this.BackColor = Color.DarkGreen;
            else
                this.BackColor = Color.IndianRed;
        }

        private void frmResults_Load(object sender, EventArgs e)
        {
            quiz.ShowQuizInformation(this);
            ShowQuizResult();
            ChangeBackgroundColor();
        }

        private void BackToMainScreen()
        {
            quiz.QuizInfo.Show();
            this.Close();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            BackToMainScreen();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}