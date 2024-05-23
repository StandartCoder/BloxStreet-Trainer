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
    public partial class Settings : Form
    {
        public Settings()
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
            user.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, user.Width, user.Height, 20, 20));
            lines.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, lines.Width, lines.Height, 20, 20));
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
            if (Config.getUsername() != user.Text && !Config.changeUsername(user.Text))
            {
                MessageBox.Show("Couldn't change the username in config. Please try again, if continues ping/dm StandartCoder in discord.");
            }

            string[] phases = { "introduction", "cafe_test", "register_test", "passing_lrs" };
            foreach (string phase in phases)
            {
                List<string> lines = Config.getLines(phase);
                
                if (phase == "introduction")
                {
                    Data.introduction_script = lines;
                }
                else if (phase == "cafe_test")
                {
                    Data.cafe_test_script = lines;
                }
                else if (phase == "register_test")
                {
                    Data.register_test_script = lines;
                }
                else if (phase == "passing_lrs")
                {
                    Data.passing_lrs_script = lines;
                }
            }

            Program.training = new Training();

            Program.home.Show();
            Program.home.Location = this.Location;
            this.Hide();
        }

        protected void MyClosedHandler(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lines_Click(object sender, EventArgs e)
        {
            // open explorer to the folder
            System.Diagnostics.Process.Start("explorer.exe", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\BloxStreet\\lines");
        }
    }
}
