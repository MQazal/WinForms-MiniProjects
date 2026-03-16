using System;
using System.Windows.Forms;
using RockPaperScissor.Properties;

namespace RockPaperScissor
{
    public partial class Form1 : Form
    {
        public static byte RoundsNumber = 0;

        public static string PlayerName = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.RockPaperSi;
        }

        private bool IsFormValid()
        {
            errorProvider1.Clear();
            if (numRounds.Value == 0)
            {
                errorProvider1.SetError(numRounds, "Select number of rounds!");
                return false;
            }
            if (tbxName.Text.Length == 0)
            {
                errorProvider1.SetError(tbxName, "Enter a name!");
                return false;
            }
            return true;
        }

        private void LoadFormData()
        {
            RoundsNumber = (byte)numRounds.Value;
            PlayerName = tbxName.Text;
        }

        private void StartGame()
        {
            frmGame game = new frmGame();
            game.Show();
            this.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!IsFormValid())
            {
                return;
            }
            LoadFormData();
            StartGame();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}