using System;
using System.Drawing;
using System.Windows.Forms;
using TicTacToeGame.Properties;

namespace TicTacToeGame
{
    public partial class frmGame : Form
    {
        public frmGame()
        {
            InitializeComponent();
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Resources.Wall;
            lblTurn.Text = "Player 1";
            lblWinner.Text = "In Progress";
        }

        private void frmGame_Paint(object sender, PaintEventArgs e)
        {
            Color Black = Color.FromArgb(255, 0, 0, 0);
            Pen BlackPen = new Pen(Black, 15)
            {
                StartCap = System.Drawing.Drawing2D.LineCap.Round,
                EndCap = System.Drawing.Drawing2D.LineCap.Round
            };
            // Draw Horizontal lines
            e.Graphics.DrawLine(BlackPen, 400, 300, 1050, 300);
            e.Graphics.DrawLine(BlackPen, 400, 460, 1050, 460);
            // Draw Vertical lines
            e.Graphics.DrawLine(BlackPen, 610, 140, 610, 620);
            e.Graphics.DrawLine(BlackPen, 840, 140, 840, 620);
        }

        private void ApplyPlayerMove(PictureBox Box)
        {
            if (Box.Tag.ToString() != "?") // Box is not available
            {
                MessageBox.Show("Box is not available", "Wrong Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Box is available
            if (lblTurn.Text == "Player 1")
            {
                Box.Image = Resources.X;
                Box.Tag = "X";
            }

            else
            {
                Box.Image = Resources.O;
                Box.Tag = "O";
            }
        }

        private void UpdatePlayerTurn(PictureBox Box)
        {
            if (Convert.ToChar(Box.Tag) == 'X')
                lblTurn.Text = "Player 2";
            else
                lblTurn.Text = "Player 1";
        }

        private bool AreBoxesEqual(PictureBox box1, PictureBox box2, PictureBox box3)
        {
            if (Convert.ToChar(box1.Tag) == '?')
                return false;

            if (Convert.ToChar(box1.Tag) == 'X' && Convert.ToChar(box2.Tag) == 'X' && Convert.ToChar(box3.Tag) == 'X')
                return true;

            if (Convert.ToChar(box1.Tag) == 'O' && Convert.ToChar(box2.Tag) == 'O' && Convert.ToChar(box3.Tag) == 'O')
                return true;

            return false;
        }

        private bool CheckWinner()
        {
            // Rows
            if (AreBoxesEqual(pb1, pb2, pb3))
            {
                ColorWinnerBoxes(pb1, pb2, pb3);
                return true;
            }

            else if (AreBoxesEqual(pb4, pb5, pb6))
            {
                ColorWinnerBoxes(pb4, pb5, pb6);
                return true;
            }

            else if (AreBoxesEqual(pb7, pb8, pb9))
            {
                ColorWinnerBoxes(pb7, pb8, pb9);
                return true;
            }

            // Columns
            else if (AreBoxesEqual(pb1, pb4, pb7))
            {
                ColorWinnerBoxes(pb1, pb4, pb7);
                return true;
            }

            else if (AreBoxesEqual(pb2, pb5, pb8))
            {
                ColorWinnerBoxes(pb2, pb5, pb8);
                return true;
            }

            else if (AreBoxesEqual(pb3, pb6, pb9))
            {
                ColorWinnerBoxes(pb3, pb6, pb9);
                return true;
            }

            // Diagonals
            else if (AreBoxesEqual(pb1, pb5, pb9))
            {
                ColorWinnerBoxes(pb1, pb5, pb9);
                return true;
            }

            else if (AreBoxesEqual(pb3, pb5, pb7))
            {
                ColorWinnerBoxes(pb3, pb5, pb7);
                return true;
            }

            else
                return false;
        }

        private void ColorWinnerBoxes(PictureBox box1, PictureBox box2, PictureBox box3)
        {
            box1.BackColor = Color.GreenYellow;
            box2.BackColor = Color.GreenYellow;
            box3.BackColor = Color.GreenYellow;
        }

        private bool IsDraw()
        {
            foreach(Control control in this.Controls)
            {
                if (control is PictureBox)
                {
                    if (control.Tag.ToString() == "?")
                        return false;
                }
            }
            return true;
        }

        private void DisableAllGridBoxes()
        {
            foreach(Control control in this.Controls)
            {
                if (control is PictureBox Box)
                {
                    Box.Enabled = false;
                }
            }
        }

        void GameOver()
        {
            if (CheckWinner())
                lblWinner.Text = lblTurn.Text;
            else
                lblWinner.Text = "Draw";

            lblTurn.Text = "Game Over";
            MessageBox.Show("Game Over", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DisableAllGridBoxes();
        }

        private void PictureBoxClick(object sender, EventArgs e)
        {
            // This global event is used to call 9 picture boxes, and when each picture box calls it, the sender object is casted to this control
            ApplyPlayerMove((PictureBox)sender);
            if (CheckWinner() || IsDraw())
            {
                GameOver();
                return;
            }
            UpdatePlayerTurn((PictureBox)sender);
        }

        private void ResetGame()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Label label1 && label1 == lblTurn)
                {
                    lblTurn.Text = "Player 1";
                }

                else if (control is Label label2 && label2 == lblWinner)
                {
                    lblWinner.Text = "In Progress";
                }

                else if (control is PictureBox Box)
                {
                    Box.Image = Resources.question_mark;
                    Box.BackColor = Color.Transparent;
                    Box.Tag = "?";
                    Box.Enabled = true;
                }
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            ResetGame();
        }
    }
}
