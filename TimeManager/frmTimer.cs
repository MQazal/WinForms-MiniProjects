using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;


namespace TimeManager
{
    public partial class frmTimer : Form
    {
        public frmTimer()
        {
            InitializeComponent();
        }

        private void frmTimer_Load(object sender, EventArgs e)
        {
            btnStart.Enabled = false;
        }

        private bool IsTimerRun = false;

        private void btnManager_Click(object sender, EventArgs e)
        {
            frmManager manager = new frmManager();
            manager.Show();
            this.Close();
        }

        //private void ConfigerTimer(object sender, EventArgs e)
        //{
        //    if (IsTimerRun)
        //        return;

        //    NumericUpDown numeric = (NumericUpDown)sender;
        //    if (numeric.Value > 0)
        //        btnStart.Enabled = true;
        //    else
        //        btnStart.Enabled = false;
        //}

        private void TypingValues(object sender, KeyEventArgs e)
        {
            if (IsTimerRun)
                return;

            NumericUpDown numeric = (NumericUpDown)sender;
            if (numeric.Value > 0)
                btnStart.Enabled = true;
            else
                btnStart.Enabled = false;
        }

        private bool IsTimerFinish()
        {
            return nmSecond.Value == 0 && nmMinute.Value == 0 && nmHour.Value == 0;
        }

        private void SendNotification()
        {
            Console.Beep(800, 700);
            notifyFinishTimer.Icon = SystemIcons.WinLogo;
            notifyFinishTimer.ShowBalloonTip(5, "Alert Message", "Timer is finshed!", ToolTipIcon.Info);
        }

        private void ResetTimerAfterFinish()
        {
            IsTimerRun = false;
            btnStart.ImageIndex = 1;
            btnStart.Tag = "Start";
            btnStart.Enabled = false;
        }

        private void FinishTimer()
        {
            timer1.Enabled = false;
            SendNotification();
            ResetTimerAfterFinish();
        }

        private bool IsBeginningOfMinute()
        {
            return nmSecond.Value == 0 && nmMinute.Value > 0;
        }

        private void SetNewMinute()
        {
            nmMinute.Value--;
            nmSecond.Value = 59;
        }

        private bool IsBeginningOfHour()
        {
            return nmSecond.Value == 0 && nmMinute.Value == 0 && nmHour.Value > 0;
        }

        private void SetNewHour()
        {
            nmHour.Value--;
            nmMinute.Value = 59;
            nmSecond.Value = 59;
        }

        private void SetTimerValues()
        {
            if (IsTimerFinish())
            {
                FinishTimer();
            }

            else if (nmSecond.Value > 0)
            {
                nmSecond.Value--;
            }

            else if (IsBeginningOfMinute())
            {
                SetNewMinute();
            }

            else if (IsBeginningOfHour())
            {
                SetNewHour();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SetTimerValues();
        }

        private void SetStartStopButtonState()
        {
            if (btnStart.Tag.ToString() == "Start")
            {
                timer1.Enabled = true;
                btnStart.ImageIndex = 3;
                btnStart.Tag = "Stop";
            }
            else
            {
                timer1.Enabled = false;
                btnStart.ImageIndex = 1;
                btnStart.Tag = "Start";
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            SetStartStopButtonState();
            IsTimerRun = true;
            btnStart.Focus();
        }

        private void ResetTimer()
        {
            IsTimerRun = false;
            foreach (NumericUpDown numeric in this.Controls.OfType<NumericUpDown>())
            {
                numeric.Value = 0;
            }
            btnStart.ImageIndex = 1;
            btnStart.Tag = "Start";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            ResetTimer();
        }
    }
}