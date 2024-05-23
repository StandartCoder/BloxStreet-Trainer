namespace BloxStreet_Trainer
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.menu_title = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.backbtn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.made = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lines = new System.Windows.Forms.Button();
            this.version = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // menu_title
            // 
            this.menu_title.AutoSize = true;
            this.menu_title.BackColor = System.Drawing.Color.Transparent;
            this.menu_title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_title.Location = new System.Drawing.Point(-3, 171);
            this.menu_title.Name = "menu_title";
            this.menu_title.Size = new System.Drawing.Size(87, 30);
            this.menu_title.TabIndex = 9;
            this.menu_title.Text = "Settings";
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
            this.logo.Image = global::BloxStreet_Trainer.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(0, 55);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(70, 70);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 7;
            this.logo.TabStop = false;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
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
            // user
            // 
            this.user.BackColor = System.Drawing.Color.DimGray;
            this.user.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.user.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.user.Location = new System.Drawing.Point(414, 265);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(161, 28);
            this.user.TabIndex = 15;
            this.user.Text = "Username";
            this.user.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(169, 259);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Roblox Username:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lines
            // 
            this.lines.BackColor = System.Drawing.Color.DimGray;
            this.lines.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.lines.FlatAppearance.BorderSize = 0;
            this.lines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lines.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lines.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lines.Location = new System.Drawing.Point(315, 312);
            this.lines.Name = "lines";
            this.lines.Size = new System.Drawing.Size(161, 31);
            this.lines.TabIndex = 17;
            this.lines.Text = "Edit Lines";
            this.lines.UseVisualStyleBackColor = false;
            this.lines.Click += new System.EventHandler(this.lines_Click);
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.Location = new System.Drawing.Point(706, 18);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(95, 20);
            this.version.TabIndex = 18;
            this.version.Text = "Version: 0.8.2";
            this.version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.version);
            this.Controls.Add(this.lines);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user);
            this.Controls.Add(this.made);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.menu_title);
            this.Controls.Add(this.title);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Settings";
            this.Text = "BloxStreet Trainer";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label menu_title;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label made;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lines;
        public System.Windows.Forms.TextBox user;
        public System.Windows.Forms.Label version;
    }
}