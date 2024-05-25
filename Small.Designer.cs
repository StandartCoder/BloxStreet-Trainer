namespace BloxStreet_Trainer
{
    partial class Small
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Small));
            this.title = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.made = new System.Windows.Forms.Label();
            this.text = new System.Windows.Forms.Label();
            this.right = new System.Windows.Forms.Button();
            this.left = new System.Windows.Forms.Button();
            this.phase = new System.Windows.Forms.Label();
            this.failed = new System.Windows.Forms.Button();
            this.send = new System.Windows.Forms.Button();
            this.prev = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.custom = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.title.Location = new System.Drawing.Point(2, 7);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(346, 41);
            this.title.TabIndex = 2;
            this.title.Text = "BloxStreet Trainer";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.BackColor = System.Drawing.Color.Transparent;
            this.version.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.version.Location = new System.Drawing.Point(295, 15);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(95, 20);
            this.version.TabIndex = 10;
            this.version.Text = "Version: 0.8.2";
            this.version.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // made
            // 
            this.made.AutoSize = true;
            this.made.BackColor = System.Drawing.Color.Transparent;
            this.made.Font = new System.Drawing.Font("Segoe UI Emoji", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.made.Location = new System.Drawing.Point(167, -4);
            this.made.Name = "made";
            this.made.Size = new System.Drawing.Size(223, 20);
            this.made.TabIndex = 9;
            this.made.Text = "Made with ♥ by StandartC0der";
            this.made.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // text
            // 
            this.text.BackColor = System.Drawing.Color.DimGray;
            this.text.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.text.Location = new System.Drawing.Point(10, 50);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(255, 173);
            this.text.TabIndex = 13;
            this.text.Text = "Current Text";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // right
            // 
            this.right.BackColor = System.Drawing.Color.DimGray;
            this.right.FlatAppearance.BorderSize = 0;
            this.right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.right.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.right.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.right.Location = new System.Drawing.Point(327, 230);
            this.right.Name = "right";
            this.right.Size = new System.Drawing.Size(51, 23);
            this.right.TabIndex = 25;
            this.right.Text = ">";
            this.right.UseVisualStyleBackColor = false;
            this.right.Click += new System.EventHandler(this.right_Click);
            // 
            // left
            // 
            this.left.BackColor = System.Drawing.Color.DimGray;
            this.left.FlatAppearance.BorderSize = 0;
            this.left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.left.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.left.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.left.Location = new System.Drawing.Point(271, 230);
            this.left.Name = "left";
            this.left.Size = new System.Drawing.Size(50, 23);
            this.left.TabIndex = 24;
            this.left.Text = "<";
            this.left.UseVisualStyleBackColor = false;
            this.left.Click += new System.EventHandler(this.left_Click);
            // 
            // phase
            // 
            this.phase.BackColor = System.Drawing.Color.DimGray;
            this.phase.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phase.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.phase.Location = new System.Drawing.Point(10, 230);
            this.phase.Name = "phase";
            this.phase.Size = new System.Drawing.Size(255, 23);
            this.phase.TabIndex = 23;
            this.phase.Text = "Phase: X";
            this.phase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // failed
            // 
            this.failed.BackColor = System.Drawing.Color.DimGray;
            this.failed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.failed.FlatAppearance.BorderSize = 0;
            this.failed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.failed.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failed.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.failed.Location = new System.Drawing.Point(271, 163);
            this.failed.Name = "failed";
            this.failed.Size = new System.Drawing.Size(107, 27);
            this.failed.TabIndex = 29;
            this.failed.Text = "Failed Message";
            this.failed.UseVisualStyleBackColor = false;
            this.failed.Click += new System.EventHandler(this.failed_Click);
            // 
            // send
            // 
            this.send.BackColor = System.Drawing.Color.DimGray;
            this.send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.send.FlatAppearance.BorderSize = 0;
            this.send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.send.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.send.Location = new System.Drawing.Point(271, 83);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(107, 41);
            this.send.TabIndex = 28;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = false;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // prev
            // 
            this.prev.BackColor = System.Drawing.Color.DimGray;
            this.prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.prev.FlatAppearance.BorderSize = 0;
            this.prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.prev.Location = new System.Drawing.Point(271, 130);
            this.prev.Name = "prev";
            this.prev.Size = new System.Drawing.Size(107, 27);
            this.prev.TabIndex = 27;
            this.prev.Text = "Previous";
            this.prev.UseVisualStyleBackColor = false;
            this.prev.Click += new System.EventHandler(this.prev_Click);
            // 
            // next
            // 
            this.next.BackColor = System.Drawing.Color.DimGray;
            this.next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.next.FlatAppearance.BorderSize = 0;
            this.next.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.next.Location = new System.Drawing.Point(271, 50);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(107, 27);
            this.next.TabIndex = 26;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // custom
            // 
            this.custom.BackColor = System.Drawing.Color.DimGray;
            this.custom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.custom.Enabled = false;
            this.custom.FlatAppearance.BorderSize = 0;
            this.custom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custom.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custom.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.custom.Location = new System.Drawing.Point(271, 196);
            this.custom.Name = "custom";
            this.custom.Size = new System.Drawing.Size(107, 27);
            this.custom.TabIndex = 30;
            this.custom.Text = "Custom";
            this.custom.UseVisualStyleBackColor = false;
            // 
            // Small
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.custom);
            this.Controls.Add(this.failed);
            this.Controls.Add(this.send);
            this.Controls.Add(this.prev);
            this.Controls.Add(this.next);
            this.Controls.Add(this.right);
            this.Controls.Add(this.left);
            this.Controls.Add(this.phase);
            this.Controls.Add(this.text);
            this.Controls.Add(this.version);
            this.Controls.Add(this.made);
            this.Controls.Add(this.title);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Small";
            this.Text = "BloxStreet Trainer";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        public System.Windows.Forms.Label version;
        private System.Windows.Forms.Label made;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.Button right;
        private System.Windows.Forms.Button left;
        private System.Windows.Forms.Label phase;
        private System.Windows.Forms.Button failed;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button prev;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Button custom;
    }
}