namespace BloxStreet_Trainer
{
    partial class Home
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.title = new System.Windows.Forms.Label();
            this.menu_title = new System.Windows.Forms.Label();
            this.timebtn = new System.Windows.Forms.Button();
            this.threebtn = new System.Windows.Forms.Button();
            this.trainbtn = new System.Windows.Forms.Button();
            this.made = new System.Windows.Forms.Label();
            this.setbtn = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.version = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(-3, 128);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(315, 47);
            this.title.TabIndex = 1;
            this.title.Text = "BloxStreet Trainer";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menu_title
            // 
            this.menu_title.AutoSize = true;
            this.menu_title.BackColor = System.Drawing.Color.Transparent;
            this.menu_title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu_title.Location = new System.Drawing.Point(-3, 171);
            this.menu_title.Name = "menu_title";
            this.menu_title.Size = new System.Drawing.Size(120, 30);
            this.menu_title.TabIndex = 2;
            this.menu_title.Text = "Main Menu";
            this.menu_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timebtn
            // 
            this.timebtn.BackColor = System.Drawing.Color.DimGray;
            this.timebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.timebtn.FlatAppearance.BorderSize = 0;
            this.timebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.timebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timebtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.timebtn.Location = new System.Drawing.Point(0, 254);
            this.timebtn.Name = "timebtn";
            this.timebtn.Size = new System.Drawing.Size(135, 57);
            this.timebtn.TabIndex = 3;
            this.timebtn.Text = "Time Table";
            this.timebtn.UseVisualStyleBackColor = false;
            this.timebtn.Click += new System.EventHandler(this.timebtn_Click);
            // 
            // threebtn
            // 
            this.threebtn.BackColor = System.Drawing.Color.DimGray;
            this.threebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.threebtn.FlatAppearance.BorderSize = 0;
            this.threebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threebtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.threebtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.threebtn.Location = new System.Drawing.Point(132, 254);
            this.threebtn.Name = "threebtn";
            this.threebtn.Size = new System.Drawing.Size(135, 57);
            this.threebtn.TabIndex = 4;
            this.threebtn.Text = "3 Lines";
            this.threebtn.UseVisualStyleBackColor = false;
            this.threebtn.Click += new System.EventHandler(this.threebtn_Click);
            // 
            // trainbtn
            // 
            this.trainbtn.BackColor = System.Drawing.Color.DimGray;
            this.trainbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.trainbtn.FlatAppearance.BorderSize = 0;
            this.trainbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trainbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.trainbtn.Location = new System.Drawing.Point(0, 327);
            this.trainbtn.Name = "trainbtn";
            this.trainbtn.Size = new System.Drawing.Size(135, 57);
            this.trainbtn.TabIndex = 5;
            this.trainbtn.Text = "Training";
            this.trainbtn.UseVisualStyleBackColor = false;
            this.trainbtn.Click += new System.EventHandler(this.trainbtn_Click);
            // 
            // made
            // 
            this.made.AutoSize = true;
            this.made.BackColor = System.Drawing.Color.Transparent;
            this.made.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.made.Location = new System.Drawing.Point(578, -1);
            this.made.Name = "made";
            this.made.Size = new System.Drawing.Size(223, 20);
            this.made.TabIndex = 6;
            this.made.Text = "Made with ♥ by StandartC0der";
            this.made.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // setbtn
            // 
            this.setbtn.BackColor = System.Drawing.Color.DimGray;
            this.setbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.setbtn.FlatAppearance.BorderSize = 0;
            this.setbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.setbtn.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setbtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.setbtn.Location = new System.Drawing.Point(132, 327);
            this.setbtn.Name = "setbtn";
            this.setbtn.Size = new System.Drawing.Size(135, 57);
            this.setbtn.TabIndex = 7;
            this.setbtn.Text = "Settings";
            this.setbtn.UseVisualStyleBackColor = false;
            this.setbtn.Click += new System.EventHandler(this.setbtn_Click);
            // 
            // logo
            // 
            this.logo.Image = global::BloxStreet_Trainer.Properties.Resources.logo;
            this.logo.Location = new System.Drawing.Point(0, 55);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(70, 70);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.Location = new System.Drawing.Point(706, 18);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(95, 20);
            this.version.TabIndex = 8;
            this.version.Text = "Version: 0.8.2";
            this.version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.version);
            this.Controls.Add(this.setbtn);
            this.Controls.Add(this.made);
            this.Controls.Add(this.trainbtn);
            this.Controls.Add(this.threebtn);
            this.Controls.Add(this.timebtn);
            this.Controls.Add(this.menu_title);
            this.Controls.Add(this.title);
            this.Controls.Add(this.logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Text = "BloxStreet Trainer";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label menu_title;
        private System.Windows.Forms.Button timebtn;
        private System.Windows.Forms.Button threebtn;
        private System.Windows.Forms.Button trainbtn;
        private System.Windows.Forms.Label made;
        private System.Windows.Forms.Button setbtn;
        public System.Windows.Forms.Label version;
    }
}

