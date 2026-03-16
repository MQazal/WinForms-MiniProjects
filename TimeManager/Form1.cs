using System;
using System.Windows.Forms;

namespace TimeManager
{
    public partial class frmManager : Form
    {
        public frmManager()
        {
            InitializeComponent();
        }

        private static DateTime Current = DateTime.Now;

        private byte Seconds = (byte)Current.Second;

        private byte Minutes = (byte)Current.Minute;

        private byte Hours = 0;

        enum enTimeFormat
        {
            TwelveHour,
            TwentyFourHour
        }

        private void frmManager_Load(object sender, EventArgs e)
        {
            // Fires when form is showen
            Hours = (byte)GetHourFormat();
            ShowTime();
            RefreshDateAndDay();
        }

        private int GetHourFormat(enTimeFormat format = enTimeFormat.TwentyFourHour)
        {
            int hour = Current.Hour; // 0–23

            if (format == enTimeFormat.TwelveHour)
            {
                int hour12 = hour % 12;
                return hour12 == 0 ? 12 : hour12; // 1–12
            }

            return hour; // 0–23
        }

        private void SetTime()
        {
            if (Seconds == 59)
            {
                if (Minutes == 59)
                {
                    Hours += 1;
                    Minutes = 0;
                    Seconds = 0;
                }
                Seconds = 0;
                Minutes += 1;
            }
            else
                Seconds += 1;
        }

        private void UpdateClockLabels(Label HoursLabel, Label MinutesLabel, Label SecondsLabel)
        {
            HoursLabel.Text = Hours.ToString();
            MinutesLabel.Text = Minutes.ToString();
            SecondsLabel.Text = Seconds.ToString();
        }

        private string GetAmPm()
        {
            return Current.Hour < 12 ? "AM" : "PM";
        }

        private void ShowTime()
        {
            SetTime();
            UpdateClockLabels(lblHour, lblMinute, lblSecond);
            lblPMAM.Text = GetAmPm();
        }

        private void ShowDate()
        {
            lblDate.Text = Current.ToShortDateString();
        }

        private void ShowDayName()
        {
            lblShortDayName.Text = Current.DayOfWeek.ToString();
        }

        private void RefreshDateAndDay()
        {
            ShowDate();
            ShowDayName();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            // while timer enable is true
            Current = DateTime.Now; // Update time and date every day
            ShowTime();
            RefreshDateAndDay();
        }

        private void btnHoursMode1_Click(object sender, EventArgs e)
        {
            Hours = (byte)GetHourFormat(enTimeFormat.TwelveHour);
            lblHour.Text = Hours.ToString();
        }

        private void btnHoursMode2_Click(object sender, EventArgs e)
        {
            Hours = (byte)GetHourFormat();
            lblHour.Text = Hours.ToString();
        }

        private void btnStopWatch_Click(object sender, EventArgs e)
        {
            frmStopWatch frmStop = new frmStopWatch();
            frmStop.Show();
            this.Hide();
        }

        private void btnTimer_Click(object sender, EventArgs e)
        {
            frmTimer timer = new frmTimer();
            timer.Show();
            this.Hide();
        }
    }
}