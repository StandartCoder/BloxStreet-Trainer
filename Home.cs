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
    public partial class Home : Form
    {
        public Home()
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

            // make rounded corners for buttons
            timebtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, timebtn.Width, timebtn.Height, 20, 20));
            threebtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, threebtn.Width, threebtn.Height, 20, 20));
            trainbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, trainbtn.Width, trainbtn.Height, 20, 20));
            setbtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, setbtn.Width, setbtn.Height, 20, 20));

            // move buttons to center
            timebtn.Location = new Point((this.Width / 2 - 5) - timebtn.Width, timebtn.Location.Y);
            threebtn.Location = new Point((this.Width / 2 + 5) - threebtn.Width + timebtn.Width, threebtn.Location.Y);
            trainbtn.Location = new Point((this.Width / 2 - 5) - trainbtn.Width, trainbtn.Location.Y);
            setbtn.Location = new Point((this.Width / 2 + 5) - setbtn.Width + trainbtn.Width, setbtn.Location.Y);
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

        private void timebtn_Click(object sender, EventArgs e)
        {
            Program.time.Show();
            Program.time.Location = this.Location;
            this.Hide();
        }

        protected void MyClosedHandler(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void threebtn_Click(object sender, EventArgs e)
        {
            Program.three.Show();
            Program.three.Location = this.Location;
            this.Hide();
        }

        private void trainbtn_Click(object sender, EventArgs e)
        {
            Program.training.Show();
            Program.training.Location = this.Location;
            this.Hide();
        }

        private void setbtn_Click(object sender, EventArgs e)
        {
            Program.settings.Show();
            Program.settings.Location = this.Location;
            this.Hide();
        }
    }
}
