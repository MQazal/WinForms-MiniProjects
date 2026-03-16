using System;
using System.Windows.Forms;

namespace TimeManager
{
    public partial class frmStopWatch : Form
    {
        public frmStopWatch()
        {
            InitializeComponent();
        }

        private byte Hours = 0;

        private byte Minutes = 0;

        private byte Seconds = 0;

        private byte Milliseconds = 0;

        private void SetStopWatch()
        {
            if (Milliseconds == 100 && Seconds == 59 && Minutes == 59)
            {
                Hours += 1;
                Milliseconds = 0;
                Seconds = 0;
                Minutes = 0;
            }

            else if (Milliseconds == 100 && Seconds == 59)
            {
                Minutes += 1;
                Milliseconds = 0;
                Seconds = 0;
            }

            else if (Milliseconds == 100)
            {
                Seconds++;
                Milliseconds = 0;
            }

            else
                Milliseconds++;
        }

        private void UpdateStopWatchLabels(Label HoursLabel, Label MinutesLabel, Label SecondsLabel, Label MillisecondsLabel)
        {
            HoursLabel.Text = Hours.ToString();
            MinutesLabel.Text = Minutes.ToString();
            SecondsLabel.Text = Seconds.ToString();
            MillisecondsLabel.Text = Milliseconds.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SetStopWatch();
            UpdateStopWatchLabels(lblHour, lblMinute, lblSecond, lblMilliseconds);
        }

        private void SetStartStopButtonState()
        {
            if (btnStart.Tag.ToString() == "Start")
            {
                timer.Enabled = true;
                btnStart.ImageIndex = 3;
                btnStart.Tag = "Stop";
            }
            else
            {
                timer.Enabled = false;
                btnStart.ImageIndex = 1;
                btnStart.Tag = "Start";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SetStartStopButtonState();
        }

        private void ResetStopWatch()
        {
            timer.Enabled = false;
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
            Milliseconds = 0;
            UpdateStopWatchLabels(lblHour, lblMinute, lblSecond, lblMilliseconds);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetStopWatch();
        }

        private void btnClock_Click(object sender, EventArgs e)
        {
            frmManager manager = new frmManager();
            manager.Show();
            this.Close();
        }
    }
}