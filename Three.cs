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
using System.Threading;
using System.Management.Instrumentation;

namespace BloxStreet_Trainer
{
    public partial class Three : Form
    {
        public Three()
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
            btn1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn1.Width, btn1.Height, 20, 20));
            btn2.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn2.Width, btn2.Height, 20, 20));
            btn3.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn3.Width, btn3.Height, 20, 20));

            all.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, all.Width, all.Height, 20, 20));

            btn1.Text = Data.three_green_lines[0];
            btn2.Text = Data.three_green_lines[1];
            btn3.Text = Data.three_green_lines[2];
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

        private void btn1_Click(object sender, EventArgs e)
        {
            if (Program.settings.user.Text == "" || Program.settings.user.Text == "Username")
            {
                MessageBox.Show("Please enter a username first in Settings.");
                return;
            }

            Roblox.Chat(Data.three_green_lines[0].Replace("{username}", Program.settings.user.Text));
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Roblox.Chat(Data.three_green_lines[1]);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Roblox.Chat(Data.three_green_lines[2]);
        }

        private void all_Click(object sender, EventArgs e)
        {
            if (Program.settings.user.Text == "" || Program.settings.user.Text == "Username")
            {
                MessageBox.Show("Please enter a username first in Settings.");
                return;
            }

            List<string> green_lines = new List<string>
            {
                Data.three_green_lines[0].Replace("{username}", Program.settings.user.Text),
                Data.three_green_lines[1],
                Data.three_green_lines[2]
            };

            Roblox.ChatMany(green_lines);
        }
    }
}
