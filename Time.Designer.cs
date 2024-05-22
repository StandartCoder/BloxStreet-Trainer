namespace BloxStreet_Trainer
{
    partial class Time
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Time));
            this.menu_title = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.timepanel = new System.Windows.Forms.Panel();
            this.times = new System.Windows.Forms.ListBox();
            this.seconds = new System.Windows.Forms.Label();
            this.minutes = new System.Windows.Forms.Label();
            this.hours = new System.Windows.Forms.Label();
            this.nearst = new System.Windows.Forms.Label();
            this.switchbtn = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.made = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.timepanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu_title
            // 
            this.menu_title.AutoSize = true;
            this.menu_title.BackColor = System.Drawing.Color.Transparent;
            this.menu_title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_title.Location = new System.Drawing.Point(-3, 171);
            this.menu_title.Name = "menu_title";
            this.menu_title.Size = new System.Drawing.Size(112, 30);
            this.menu_title.TabIndex = 9;
            this.menu_title.Text = "Time Table";
            this.menu_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(-3, 128);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(315, 47);
            this.title.TabIndex = 8;
            this.title.Text = "BloxStreet Trainer";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backbtn
            // 
            this.backbtn.BackColor = System.Drawing.Color.DimGray;
            this.backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.backbtn.FlatAppearance.BorderSize = 0;
            this.backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.backbtn.Location = new System.Drawing.Point(12, 12);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(70, 31);
            this.backbtn.TabIndex = 11;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = false;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // logo
            // 
            this.logo.Image = global::BloxStreet_Trainer.Properties.Resources.Png;
            this.logo.Location = new System.Drawing.Point(0, 55);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(70, 70);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            // 
            // timepanel
            // 
            this.timepanel.BackColor = System.Drawing.Color.DimGray;
            this.timepanel.Controls.Add(this.times);
            this.timepanel.Controls.Add(this.seconds);
            this.timepanel.Controls.Add(this.minutes);
            this.timepanel.Controls.Add(this.hours);
            this.timepanel.Controls.Add(this.nearst);
            this.timepanel.Location = new System.Drawing.Point(12, 241);
            this.timepanel.Name = "timepanel";
            this.timepanel.Size = new System.Drawing.Size(776, 197);
            this.timepanel.TabIndex = 12;
            // 
            // times
            // 
            this.times.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.times.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.times.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.times.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.times.FormattingEnabled = true;
            this.times.ItemHeight = 20;
            this.times.Items.AddRange(new object[] {
            "2 AM (Weekend)",
            "6 AM (Weekend)",
            "10 AM",
            "12 PM",
            "2 PM",
            "4 PM",
            "7 PM",
            "9 PM",
            "11 PM"});
            this.times.Location = new System.Drawing.Point(544, 8);
            this.times.Name = "times";
            this.times.Size = new System.Drawing.Size(218, 180);
            this.times.TabIndex = 4;
            // 
            // seconds
            // 
            this.seconds.AutoSize = true;
            this.seconds.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.seconds.Location = new System.Drawing.Point(17, 82);
            this.seconds.Name = "seconds";
            this.seconds.Size = new System.Drawing.Size(100, 21);
            this.seconds.TabIndex = 3;
            this.seconds.Text = "in 0 seconds";
            // 
            // minutes
            // 
            this.minutes.AutoSize = true;
            this.minutes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutes.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.minutes.Location = new System.Drawing.Point(17, 61);
            this.minutes.Name = "minutes";
            this.minutes.Size = new System.Drawing.Size(98, 21);
            this.minutes.TabIndex = 2;
            this.minutes.Text = "in 0 minutes";
            // 
            // hours
            // 
            this.hours.AutoSize = true;
            this.hours.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.hours.Location = new System.Drawing.Point(17, 40);
            this.hours.Name = "hours";
            this.hours.Size = new System.Drawing.Size(81, 21);
            this.hours.TabIndex = 1;
            this.hours.Text = "in 0 hours";
            // 
            // nearst
            // 
            this.nearst.AutoSize = true;
            this.nearst.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nearst.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nearst.Location = new System.Drawing.Point(16, 15);
            this.nearst.Name = "nearst";
            this.nearst.Size = new System.Drawing.Size(235, 25);
            this.nearst.TabIndex = 0;
            this.nearst.Text = "Nearest Training Session:";
            // 
            // switchbtn
            // 
            this.switchbtn.BackColor = System.Drawing.Color.DimGray;
            this.switchbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.switchbtn.FlatAppearance.BorderSize = 0;
            this.switchbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.switchbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.switchbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.switchbtn.Location = new System.Drawing.Point(630, 194);
            this.switchbtn.Name = "switchbtn";
            this.switchbtn.Size = new System.Drawing.Size(158, 41);
            this.switchbtn.TabIndex = 13;
            this.switchbtn.Text = "No Convert";
            this.switchbtn.UseVisualStyleBackColor = false;
            this.switchbtn.Click += new System.EventHandler(this.switchbtn_Click);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // made
            // 
            this.made.AutoSize = true;
            this.made.BackColor = System.Drawing.Color.Transparent;
            this.made.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.made.Location = new System.Drawing.Point(578, -1);
            this.made.Name = "made";
            this.made.Size = new System.Drawing.Size(223, 20);
            this.made.TabIndex = 14;
            this.made.Text = "Made with ♥ by StandartC0der";
            this.made.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Time
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.made);
            this.Controls.Add(this.switchbtn);
            this.Controls.Add(this.timepanel);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.menu_title);
            this.Controls.Add(this.title);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Time";
            this.Text = "BloxStreet Trainer <Coded by StandartCoder>";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Time_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.timepanel.ResumeLayout(false);
            this.timepanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label menu_title;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Panel timepanel;
        private System.Windows.Forms.Button switchbtn;
        private System.Windows.Forms.Label nearst;
        private System.Windows.Forms.Label seconds;
        private System.Windows.Forms.Label minutes;
        private System.Windows.Forms.Label hours;
        private System.Windows.Forms.ListBox times;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label made;
    }
}