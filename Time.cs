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
        bool timeconverted = false;

        public Time()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
            this.FormClosed += new FormClosedEventHandler(MyClosedHandler);

            // move logo in center
            this.Cursor = Cursors.WaitCursor;
            this.Cursor = Cursors.Default;

            // move logo in middle
            logo.Location = new Point(this.Width / 2 - logo.Width / 2, logo.Location.Y);

            // round corners for logo
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, logo.Width - 3, logo.Height - 3);
            logo.Region = new Region(gp);

            title.Location = new Point(this.Width / 2 - title.Width / 2, title.Location.Y);
            menu_title.Location = new Point(this.Width / 2 - menu_title.Width / 2, menu_title.Location.Y);

            backbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, backbtn.Width, backbtn.Height, 20, 20));
            switchbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, switchbtn.Width, switchbtn.Height, 20, 20));
            times.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, times.Width, times.Height, 20, 20));
            timepanel.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, timepanel.Width, timepanel.Height, 20, 20));

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

            //the rectangle, the same size as our Form
            Rectangle gradient_rectangle = new Rectangle(0, 0, Width, Height);

            //define gradient's properties
            Brush b = new LinearGradientBrush(gradient_rectangle, Color.FromArgb(210, 210, 210), Color.FromArgb(228, 217, 251), 65f);

            //apply gradient         
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
            if (timeconverted == false)
            {
                switchbtn.Text = "EST to CET";

                times.Items.Clear();

                times.Items.Add("08:00 (Weekend)");
                times.Items.Add("12:00 (Weekend)");
                times.Items.Add("16:00");
                times.Items.Add("18:00");
                times.Items.Add("20:00");
                times.Items.Add("22:00");
                times.Items.Add("01:00");
                times.Items.Add("03:00");
                times.Items.Add("05:00");

                timeconverted = true;
            }
            else
            {
                switchbtn.Text = "No Convert";

                times.Items.Clear();

                times.Items.Add("2 AM (Weekend)");
                times.Items.Add("6 AM (Weekend)");
                times.Items.Add("10 AM");
                times.Items.Add("12 PM");
                times.Items.Add("2 PM");
                times.Items.Add("4 PM");
                times.Items.Add("7 PM");
                times.Items.Add("9 PM");
                times.Items.Add("11 PM");

                timeconverted = false;
            }
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
