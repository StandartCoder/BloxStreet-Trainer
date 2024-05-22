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
    public partial class Training : Form
    {
        int current_phase = 0;
        string[] phases = { "Introduction", "Cafe Test", "Register Test", "Passing LRs" };
        List<List<string>> scripts = new List<List<string>>
        {
            Data.introduction_script, Data.cafe_test_script, Data.register_test_script, Data.passing_lrs_script
        };

        int current_index = 0;

        public Training()
        {
            InitializeComponent();
            this.Paint += new PaintEventHandler(set_background);
            this.FormClosed += new FormClosedEventHandler(MyClosedHandler);

            // move logo in center
            this.Cursor = Cursors.WaitCursor;
            this.Cursor = Cursors.Default;

            title.Location = new Point(this.Width / 2 - title.Width / 2, title.Location.Y);
            menu_title.Location = new Point(this.Width / 2 - menu_title.Width / 2, menu_title.Location.Y);

            backbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, backbtn.Width, backbtn.Height, 20, 20));
            text.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, text.Width, text.Height, 20, 20));

            next.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, next.Width, next.Height, 20, 20));
            prev.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, prev.Width, prev.Height, 20, 20));
            send.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, send.Width, send.Height, 20, 20));
            failed.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, failed.Width, failed.Height, 20, 20));
            soon.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, soon.Width, soon.Height, 20, 20));
            cafe.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cafe.Width, cafe.Height, 20, 20));

            soon.Enabled = false;
            soon.ForeColor = Color.WhiteSmoke;

            phase.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, phase.Width, phase.Height, 20, 20));
            left.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, left.Width, left.Height, 20, 20));
            right.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, right.Width, right.Height, 20, 20));
            status.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, status.Width, status.Height, 20, 20));

            phase.Text = "Current Phase: " + phases[current_phase];
            update();
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

        protected void MyClosedHandler(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void left_Click(object sender, EventArgs e)
        {
            if (current_phase == 0)
                return;

            current_phase--;
            phase.Text = "Current Phase: " + phases[current_phase];
            current_index = 0;
            update();
        }

        private void right_Click(object sender, EventArgs e)
        {
            if (current_phase == phases.Length - 1)
                return;

            current_phase++;
            phase.Text = "Current Phase: " + phases[current_phase];
            current_index = 0;
            update();
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (current_index == scripts[current_phase].Count - 1)
                return;

            current_index++;
            update();
        }

        private void prev_Click(object sender, EventArgs e)
        {
            if (current_index == 0)
                return;

            current_index--;
            update();
        }

        private void send_Click(object sender, EventArgs e)
        {
            Roblox.Chat(text.Text);
        }

        private void failed_Click(object sender, EventArgs e)
        {
            Roblox.Chat(Data.failed);
        }

        private void cafe_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int index = random.Next(Data.cafe_test_requests.Count);
            Roblox.Chat(Data.cafe_test_requests[index]);
        }

        void update_status()
        {
            status.Text = "Status: " + current_index + " / " + 10;
        }

        void update()
        {
            List<string> script = scripts[current_phase];
            text.Text = script[current_index];
        }
    }
}
