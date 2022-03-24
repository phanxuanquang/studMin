namespace studMin.GUI.Login
{
    partial class OTPexample
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OTPexample));
            this.Confirm_Button = new Guna.UI2.WinForms.Guna2Button();
            this.NewPassword_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.OTP_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.ConfirmNewPassword_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.Exit_Button = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Confirm_Button.Animated = true;
            this.Confirm_Button.BackColor = System.Drawing.Color.Transparent;
            this.Confirm_Button.BorderRadius = 15;
            this.Confirm_Button.CheckedState.Parent = this.Confirm_Button;
            this.Confirm_Button.CustomImages.Parent = this.Confirm_Button;
            this.Confirm_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Confirm_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Confirm_Button.ForeColor = System.Drawing.Color.White;
            this.Confirm_Button.HoverState.Parent = this.Confirm_Button;
            this.Confirm_Button.Location = new System.Drawing.Point(50, 258);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.ShadowDecoration.Parent = this.Confirm_Button;
            this.Confirm_Button.Size = new System.Drawing.Size(340, 47);
            this.Confirm_Button.TabIndex = 8;
            this.Confirm_Button.Text = "XÁC NHẬN";
            this.Confirm_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.Confirm_Button.Click += new System.EventHandler(this.Confirm_Button_Click);
            // 
            // NewPassword_Box
            // 
            this.NewPassword_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.NewPassword_Box.Animated = true;
            this.NewPassword_Box.BackColor = System.Drawing.Color.Transparent;
            this.NewPassword_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.NewPassword_Box.BorderRadius = 15;
            this.NewPassword_Box.BorderThickness = 2;
            this.NewPassword_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NewPassword_Box.DefaultText = "";
            this.NewPassword_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NewPassword_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NewPassword_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewPassword_Box.DisabledState.Parent = this.NewPassword_Box;
            this.NewPassword_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NewPassword_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.NewPassword_Box.FocusedState.Parent = this.NewPassword_Box;
            this.NewPassword_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.NewPassword_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.NewPassword_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.NewPassword_Box.HoverState.Parent = this.NewPassword_Box;
            this.NewPassword_Box.IconLeft = ((System.Drawing.Image)(resources.GetObject("NewPassword_Box.IconLeft")));
            this.NewPassword_Box.IconLeftOffset = new System.Drawing.Point(9, 0);
            this.NewPassword_Box.IconLeftSize = new System.Drawing.Size(18, 18);
            this.NewPassword_Box.Location = new System.Drawing.Point(50, 134);
            this.NewPassword_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewPassword_Box.Name = "NewPassword_Box";
            this.NewPassword_Box.PasswordChar = '•';
            this.NewPassword_Box.PlaceholderText = " Mật khẩu mới";
            this.NewPassword_Box.SelectedText = "";
            this.NewPassword_Box.ShadowDecoration.BorderRadius = 12;
            this.NewPassword_Box.ShadowDecoration.Depth = 5;
            this.NewPassword_Box.ShadowDecoration.Parent = this.NewPassword_Box;
            this.NewPassword_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.NewPassword_Box.Size = new System.Drawing.Size(340, 47);
            this.NewPassword_Box.TabIndex = 7;
            this.NewPassword_Box.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // OTP_Box
            // 
            this.OTP_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OTP_Box.Animated = true;
            this.OTP_Box.BackColor = System.Drawing.Color.Transparent;
            this.OTP_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.OTP_Box.BorderRadius = 15;
            this.OTP_Box.BorderThickness = 2;
            this.OTP_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.OTP_Box.DefaultText = "";
            this.OTP_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.OTP_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.OTP_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OTP_Box.DisabledState.Parent = this.OTP_Box;
            this.OTP_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.OTP_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.OTP_Box.FocusedState.Parent = this.OTP_Box;
            this.OTP_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.OTP_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.OTP_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.OTP_Box.HoverState.Parent = this.OTP_Box;
            this.OTP_Box.IconLeft = ((System.Drawing.Image)(resources.GetObject("OTP_Box.IconLeft")));
            this.OTP_Box.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.OTP_Box.Location = new System.Drawing.Point(50, 72);
            this.OTP_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OTP_Box.Name = "OTP_Box";
            this.OTP_Box.PasswordChar = '\0';
            this.OTP_Box.PlaceholderText = " Mã xác thực";
            this.OTP_Box.SelectedText = "";
            this.OTP_Box.ShadowDecoration.BorderRadius = 12;
            this.OTP_Box.ShadowDecoration.Depth = 5;
            this.OTP_Box.ShadowDecoration.Parent = this.OTP_Box;
            this.OTP_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.OTP_Box.Size = new System.Drawing.Size(340, 47);
            this.OTP_Box.TabIndex = 6;
            this.OTP_Box.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // ConfirmNewPassword_Box
            // 
            this.ConfirmNewPassword_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmNewPassword_Box.Animated = true;
            this.ConfirmNewPassword_Box.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmNewPassword_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.ConfirmNewPassword_Box.BorderRadius = 15;
            this.ConfirmNewPassword_Box.BorderThickness = 2;
            this.ConfirmNewPassword_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmNewPassword_Box.DefaultText = "";
            this.ConfirmNewPassword_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ConfirmNewPassword_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ConfirmNewPassword_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmNewPassword_Box.DisabledState.Parent = this.ConfirmNewPassword_Box;
            this.ConfirmNewPassword_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmNewPassword_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.ConfirmNewPassword_Box.FocusedState.Parent = this.ConfirmNewPassword_Box;
            this.ConfirmNewPassword_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ConfirmNewPassword_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.ConfirmNewPassword_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.ConfirmNewPassword_Box.HoverState.Parent = this.ConfirmNewPassword_Box;
            this.ConfirmNewPassword_Box.IconLeft = ((System.Drawing.Image)(resources.GetObject("ConfirmNewPassword_Box.IconLeft")));
            this.ConfirmNewPassword_Box.IconLeftOffset = new System.Drawing.Point(9, 0);
            this.ConfirmNewPassword_Box.IconLeftSize = new System.Drawing.Size(18, 18);
            this.ConfirmNewPassword_Box.Location = new System.Drawing.Point(50, 196);
            this.ConfirmNewPassword_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfirmNewPassword_Box.Name = "ConfirmNewPassword_Box";
            this.ConfirmNewPassword_Box.PasswordChar = '•';
            this.ConfirmNewPassword_Box.PlaceholderText = " Nhập lại mật khẩu mới";
            this.ConfirmNewPassword_Box.SelectedText = "";
            this.ConfirmNewPassword_Box.ShadowDecoration.BorderRadius = 12;
            this.ConfirmNewPassword_Box.ShadowDecoration.Depth = 5;
            this.ConfirmNewPassword_Box.ShadowDecoration.Parent = this.ConfirmNewPassword_Box;
            this.ConfirmNewPassword_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.ConfirmNewPassword_Box.Size = new System.Drawing.Size(340, 47);
            this.ConfirmNewPassword_Box.TabIndex = 9;
            this.ConfirmNewPassword_Box.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Animated = true;
            this.Exit_Button.AutoRoundedCorners = true;
            this.Exit_Button.BackColor = System.Drawing.Color.Transparent;
            this.Exit_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Exit_Button.BorderRadius = 17;
            this.Exit_Button.BorderThickness = 2;
            this.Exit_Button.CheckedState.Parent = this.Exit_Button;
            this.Exit_Button.CustomImages.Parent = this.Exit_Button;
            this.Exit_Button.FillColor = System.Drawing.Color.White;
            this.Exit_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Exit_Button.ForeColor = System.Drawing.Color.White;
            this.Exit_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(241)))), ((int)(((byte)(255)))));
            this.Exit_Button.HoverState.Parent = this.Exit_Button;
            this.Exit_Button.Image = global::studMin.Properties.Resources.Exit;
            this.Exit_Button.ImageSize = new System.Drawing.Size(25, 25);
            this.Exit_Button.Location = new System.Drawing.Point(341, 12);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.ShadowDecoration.Parent = this.Exit_Button;
            this.Exit_Button.Size = new System.Drawing.Size(36, 36);
            this.Exit_Button.TabIndex = 10;
            this.Exit_Button.Visible = false;
            // 
            // OTPexample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::studMin.Properties.Resources.Bottom_SlideBG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(440, 332);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.ConfirmNewPassword_Box);
            this.Controls.Add(this.Confirm_Button);
            this.Controls.Add(this.NewPassword_Box);
            this.Controls.Add(this.OTP_Box);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OTPexample";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OTPexample";
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button Confirm_Button;
        private Guna.UI2.WinForms.Guna2TextBox NewPassword_Box;
        private Guna.UI2.WinForms.Guna2TextBox OTP_Box;
        private Guna.UI2.WinForms.Guna2TextBox ConfirmNewPassword_Box;
        public Guna.UI2.WinForms.Guna2Button Exit_Button;
    }
}