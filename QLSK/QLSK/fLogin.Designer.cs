namespace QLSK
{
    partial class fLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLogin));
            this.tbUsername = new MetroFramework.Controls.MetroTextBox();
            this.tbPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUsername
            // 
            // 
            // 
            // 
            this.tbUsername.CustomButton.Image = null;
            this.tbUsername.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.tbUsername.CustomButton.Name = "";
            this.tbUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbUsername.CustomButton.TabIndex = 1;
            this.tbUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbUsername.CustomButton.UseSelectable = true;
            this.tbUsername.CustomButton.Visible = false;
            this.tbUsername.Lines = new string[0];
            this.tbUsername.Location = new System.Drawing.Point(191, 75);
            this.tbUsername.MaxLength = 32767;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.PasswordChar = '\0';
            this.tbUsername.PromptText = "Tên đăng nhập";
            this.tbUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbUsername.SelectedText = "";
            this.tbUsername.SelectionLength = 0;
            this.tbUsername.SelectionStart = 0;
            this.tbUsername.ShortcutsEnabled = true;
            this.tbUsername.Size = new System.Drawing.Size(260, 23);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.UseSelectable = true;
            this.tbUsername.WaterMark = "Tên đăng nhập";
            this.tbUsername.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tbPassword
            // 
            // 
            // 
            // 
            this.tbPassword.CustomButton.Image = null;
            this.tbPassword.CustomButton.Location = new System.Drawing.Point(238, 1);
            this.tbPassword.CustomButton.Name = "";
            this.tbPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbPassword.CustomButton.TabIndex = 1;
            this.tbPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbPassword.CustomButton.UseSelectable = true;
            this.tbPassword.CustomButton.Visible = false;
            this.tbPassword.Lines = new string[0];
            this.tbPassword.Location = new System.Drawing.Point(191, 114);
            this.tbPassword.MaxLength = 32767;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.PromptText = "Mật khẩu";
            this.tbPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbPassword.SelectedText = "";
            this.tbPassword.SelectionLength = 0;
            this.tbPassword.SelectionStart = 0;
            this.tbPassword.ShortcutsEnabled = true;
            this.tbPassword.Size = new System.Drawing.Size(260, 23);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.UseSelectable = true;
            this.tbPassword.WaterMark = "Mật khẩu";
            this.tbPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroButton1
            // 
            this.metroButton1.BackColor = System.Drawing.Color.Aqua;
            this.metroButton1.Location = new System.Drawing.Point(324, 143);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(127, 32);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Đăng nhập";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(31, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // fLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 221);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLogin";
            this.Text = "Đăng Nhập";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTextBox tbUsername;
        private MetroFramework.Controls.MetroTextBox tbPassword;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

