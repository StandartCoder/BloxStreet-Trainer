using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BloxStreet_Trainer
{
    public partial class Time : Form
    {
        int time_index = 0;
        string[] long_timezone_names = { "Eastern Standard Time", "Central European Standard Time", "Central European Standard Time", "GMT Standard Time" }; // Updated to correct BST
        string[] timezones_names = { "EST (Standard)", "CEST/CET", "CET (24hr)", "BST" };
        string[] timezones = { "EST", "CET", "CET 24hr", "BST" };

        TimeSpan[] est_times = new[]
        {
            new TimeSpan(2, 0, 0),
            new TimeSpan(6, 0, 0),
            new TimeSpan(10, 0, 0),
            new TimeSpan(12, 0, 0),
            new TimeSpan(14, 0, 0),
            new TimeSpan(16, 0, 0),
            new TimeSpan(19, 0, 0),
            new TimeSpan(21, 0, 0),
            new TimeSpan(23, 0, 0)
        };

        string[] est_times_with_labels = {
            "02 AM (Weekend)", "06 AM (Weekend)", "10 AM", "12 PM", "02 PM", "04 PM", "07 PM", "09 PM", "11 PM"
        };

        public Time()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
            this.FormClosed += new FormClosedEventHandler(MyClosedHandler);

            // Move logo in center
            this.Cursor = Cursors.WaitCursor;
            this.Cursor = Cursors.Default;

            // Move logo in middle
            logo.Location = new Point(this.Width / 2 - logo.Width / 2, logo.Location.Y);

            // Round corners for logo
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, logo.Width - 3, logo.Height - 3);
            logo.Region = new Region(gp);

            title.Location = new Point(this.Width / 2 - title.Width / 2, title.Location.Y);
            menu_title.Location = new Point(this.Width / 2 - menu_title.Width / 2, menu_title.Location.Y);

            backbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, backbtn.Width, backbtn.Height, 20, 20));
            switchbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, switchbtn.Width, switchbtn.Height, 20, 20));
            times.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, times.Width, times.Height, 20, 20));
            timepanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, timepanel.Width, timepanel.Height, 20, 20));

            switchbtn.Text = timezones_names[time_index];

            timer.Start();
            doIt();
        }

        [System.Runtime.InteropServices.DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (int nLeftRect, // x-coordinate of upper-left corner
         int nTopRect, // y-coordinate of upper-left corner
         int nRightRect, // x-coordinate of lower-right corner
         int nBottomRect, // y-coordinate of lower-right corner
         int nWidthEllipse, // height of ellipse
         int nHeightEllipse // width of ellipse
        );

        private void set_background(Object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            // The rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            // Define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(210, 210, 210), Color.FromArgb(228, 217, 251), 65f);

            // Apply gradient         
            graphics.FillRectangle(b, gradient_rectangle);
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            Program.home.Show();
            Program.home.Location = this.Location;
            this.Hide();
        }

        private void switchbtn_Click(object sender, EventArgs e)
        {
            // Change timezone
            if (time_index == timezones.Length - 1)
            {
                time_index = 0;
            }
            else
            {
                time_index++;
            }

            switchbtn.Text = timezones_names[time_index];

            times.Items.Clear();

            TimeZoneInfo convertedTimezone = TimeZoneInfo.FindSystemTimeZoneById(long_timezone_names[time_index]);
            for (int i = 0; i < est_times.Length; i++)
            {
                var time = est_times[i];
                DateTime estTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, time.Hours, time.Minutes, time.Seconds, DateTimeKind.Unspecified);
                DateTime convertedTime = TimeZoneInfo.ConvertTime(estTime, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"), convertedTimezone);

                if (timezones[time_index] == "CET 24hr")
                {
                    string label = (i == 0 || i == 1) ? " (Weekend)" : "";
                    times.Items.Add(convertedTime.ToString("HH:mm") + label);
                }
                else
                {
                    string label = est_times_with_labels[i];
                    times.Items.Add(convertedTime.ToString("hh:mm tt") + " " + label.Substring(label.IndexOf(' ')));
                }
            }
        }

        private DateTime ConvertTime(DateTime time, string fromTimeZone, string toTimeZone)
        {
            TimeZoneInfo fromZone = TimeZoneInfo.FindSystemTimeZoneById(fromTimeZone);
            TimeZoneInfo toZone = TimeZoneInfo.FindSystemTimeZoneById(toTimeZone);
            DateTime fromTime = DateTime.SpecifyKind(time, DateTimeKind.Unspecified);
            DateTime fromTimeUtc = TimeZoneInfo.ConvertTimeToUtc(fromTime, fromZone);
            DateTime toTime = TimeZoneInfo.ConvertTime(fromTimeUtc, toZone);
            return toTime;
        }

        protected void MyClosedHandler(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void doIt()
        {
            var timesOfInterest = new[]
           {
                new TimeSpan(8, 0, 0),
                new TimeSpan(12, 0, 0),
                new TimeSpan(16, 0, 0),
                new TimeSpan(18, 0, 0),
                new TimeSpan(20, 0, 0),
                new TimeSpan(22, 0, 0),
                new TimeSpan(1, 0, 0),
                new TimeSpan(3, 0, 0),
                new TimeSpan(5, 0, 0)
            };

            TimeZoneInfo cetZone = TimeZoneInfo.FindSystemTimeZoneById("Central European Standard Time");
            DateTime now = TimeZoneInfo.ConvertTime(DateTime.Now, cetZone);

            DateTime? closestTime = null;
            foreach (var timeOfInterest in timesOfInterest)
            {
                DateTime nextOccurrence = GetNextOccurrence(now, timeOfInterest);

                if (closestTime == null || nextOccurrence < closestTime)
                {
                    closestTime = nextOccurrence;
                }
            }

            TimeSpan timeDifference = closestTime.Value - now;

            if (timeDifference.Minutes < 15 && timeDifference.Hours == 0)
            {
                join.Visible = true;
            }
            else
            {
                join.Visible = false;
            }

            seconds.Text = "in " + timeDifference.Seconds.ToString("00") + " seconds";
            minutes.Text = "in " + timeDifference.Minutes.ToString("00") + " minutes";
            hours.Text = "in " + timeDifference.Hours.ToString("00") + " hours";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            doIt();
            timer.Start();
        }

        static DateTime GetNextOccurrence(DateTime fromTime, TimeSpan timeOfDay)
        {
            DateTime todayOccurrence = fromTime.Date + timeOfDay;

            // If the time of day is already past for today, set it for tomorrow
            if (todayOccurrence <= fromTime)
            {
                todayOccurrence = todayOccurrence.AddDays(1);
            }

            return todayOccurrence;
        }

        private void Time_Load(object sender, EventArgs e)
        {

        }
    }
}
