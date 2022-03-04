﻿namespace studMin
{
    partial class Login_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Window));
            this.Username_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.Password_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.Login_Button = new Guna.UI2.WinForms.Guna2Button();
            this.ForgetPassword_LinkLabel = new Guna.UI.WinForms.GunaLinkLabel();
            this.Exit_Button = new Guna.UI2.WinForms.Guna2Button();
            this.RoundCornerForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.DragForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.zeroitOJAnimEdit1 = new Zeroit.Framework.Transitions.ZeroitOJAnimEdit();
            this.forgetPassword_UC1 = new studMin.ForgetPassword_UC();
            this.ForgetPasswordUC_MoverUp = new Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnimEdit();
            this.SuspendLayout();
            // 
            // Username_Box
            // 
            this.Username_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Username_Box.Animated = true;
            this.Username_Box.BackColor = System.Drawing.Color.Transparent;
            this.Username_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Username_Box.BorderRadius = 15;
            this.Username_Box.BorderThickness = 2;
            this.Username_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Username_Box.DefaultText = "";
            this.Username_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Username_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Username_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username_Box.DisabledState.Parent = this.Username_Box;
            this.Username_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Username_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Username_Box.FocusedState.Parent = this.Username_Box;
            this.Username_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Username_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Username_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Username_Box.HoverState.Parent = this.Username_Box;
            this.Username_Box.IconLeft = ((System.Drawing.Image)(resources.GetObject("Username_Box.IconLeft")));
            this.Username_Box.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.Username_Box.Location = new System.Drawing.Point(50, 386);
            this.Username_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Username_Box.Name = "Username_Box";
            this.Username_Box.PasswordChar = '\0';
            this.Username_Box.PlaceholderText = " Tên đăng nhập";
            this.Username_Box.SelectedText = "";
            this.Username_Box.ShadowDecoration.BorderRadius = 12;
            this.Username_Box.ShadowDecoration.Depth = 5;
            this.Username_Box.ShadowDecoration.Parent = this.Username_Box;
            this.Username_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.Username_Box.Size = new System.Drawing.Size(340, 47);
            this.Username_Box.TabIndex = 0;
            this.Username_Box.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // Password_Box
            // 
            this.Password_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Password_Box.Animated = true;
            this.Password_Box.BackColor = System.Drawing.Color.Transparent;
            this.Password_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Password_Box.BorderRadius = 15;
            this.Password_Box.BorderThickness = 2;
            this.Password_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_Box.DefaultText = "";
            this.Password_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_Box.DisabledState.Parent = this.Password_Box;
            this.Password_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Password_Box.FocusedState.Parent = this.Password_Box;
            this.Password_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Password_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Password_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Password_Box.HoverState.Parent = this.Password_Box;
            this.Password_Box.IconLeft = ((System.Drawing.Image)(resources.GetObject("Password_Box.IconLeft")));
            this.Password_Box.IconLeftOffset = new System.Drawing.Point(9, 0);
            this.Password_Box.IconLeftSize = new System.Drawing.Size(18, 18);
            this.Password_Box.Location = new System.Drawing.Point(50, 456);
            this.Password_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.PasswordChar = '\0';
            this.Password_Box.PlaceholderText = " Mật khẩu";
            this.Password_Box.SelectedText = "";
            this.Password_Box.ShadowDecoration.BorderRadius = 12;
            this.Password_Box.ShadowDecoration.Depth = 5;
            this.Password_Box.ShadowDecoration.Parent = this.Password_Box;
            this.Password_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.Password_Box.Size = new System.Drawing.Size(340, 47);
            this.Password_Box.TabIndex = 1;
            this.Password_Box.TextOffset = new System.Drawing.Point(3, 0);
            this.Password_Box.UseSystemPasswordChar = true;
            // 
            // Login_Button
            // 
            this.Login_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Login_Button.Animated = true;
            this.Login_Button.BackColor = System.Drawing.Color.Transparent;
            this.Login_Button.BorderRadius = 15;
            this.Login_Button.CheckedState.Parent = this.Login_Button;
            this.Login_Button.CustomImages.Parent = this.Login_Button;
            this.Login_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Login_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Login_Button.ForeColor = System.Drawing.Color.White;
            this.Login_Button.HoverState.Parent = this.Login_Button;
            this.Login_Button.Location = new System.Drawing.Point(50, 538);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.ShadowDecoration.Parent = this.Login_Button;
            this.Login_Button.Size = new System.Drawing.Size(340, 47);
            this.Login_Button.TabIndex = 2;
            this.Login_Button.Text = "ĐĂNG NHẬP";
            this.Login_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // ForgetPassword_LinkLabel
            // 
            this.ForgetPassword_LinkLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ForgetPassword_LinkLabel.AutoSize = true;
            this.ForgetPassword_LinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.ForgetPassword_LinkLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ForgetPassword_LinkLabel.Location = new System.Drawing.Point(301, 508);
            this.ForgetPassword_LinkLabel.Name = "ForgetPassword_LinkLabel";
            this.ForgetPassword_LinkLabel.Size = new System.Drawing.Size(89, 15);
            this.ForgetPassword_LinkLabel.TabIndex = 4;
            this.ForgetPassword_LinkLabel.TabStop = true;
            this.ForgetPassword_LinkLabel.Text = "Quên mật khẩu";
            this.ForgetPassword_LinkLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ForgetPassword_LinkLabel.TextRenderingHint = Guna.UI.WinForms.DrawingTextRenderingHint.AntiAliasGridFit;
            this.ForgetPassword_LinkLabel.UseMnemonic = false;
            this.ForgetPassword_LinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ForgetPassword_LinkLabel_LinkClicked);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_Button.Animated = true;
            this.Exit_Button.BackColor = System.Drawing.Color.Transparent;
            this.Exit_Button.BorderRadius = 15;
            this.Exit_Button.CheckedState.Parent = this.Exit_Button;
            this.Exit_Button.CustomImages.Parent = this.Exit_Button;
            this.Exit_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Exit_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Exit_Button.ForeColor = System.Drawing.Color.White;
            this.Exit_Button.HoverState.Parent = this.Exit_Button;
            this.Exit_Button.Location = new System.Drawing.Point(50, 603);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.ShadowDecoration.Parent = this.Exit_Button;
            this.Exit_Button.Size = new System.Drawing.Size(340, 47);
            this.Exit_Button.TabIndex = 5;
            this.Exit_Button.Text = "THOÁT";
            this.Exit_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // RoundCornerForm
            // 
            this.RoundCornerForm.BorderRadius = 20;
            this.RoundCornerForm.TargetControl = this;
            // 
            // DragForm
            // 
            this.DragForm.TargetControl = this;
            // 
            // zeroitOJAnimEdit1
            // 
            this.zeroitOJAnimEdit1.AnimationMode = Zeroit.Framework.Transitions.ZeroitOJAnimEdit.ZeroitObjectAnimationMode.ColorAnimation;
            this.zeroitOJAnimEdit1.AnimationSpeed = 1;
            this.zeroitOJAnimEdit1.ColorAnimation = Zeroit.Framework.Transitions.ZeroitOJAnimEdit.ZeroitObjectColorAnimation.FillEllipse;
            this.zeroitOJAnimEdit1.ColorAnimationDelay = 10;
            this.zeroitOJAnimEdit1.ColorToAnimate = System.Drawing.Color.White;
            this.zeroitOJAnimEdit1.Delay = 200;
            this.zeroitOJAnimEdit1.FormAnimation = Zeroit.Framework.Transitions.ZeroitOJAnimEdit.ZeroitObjectFormAnimation.FadeIn;
            this.zeroitOJAnimEdit1.FormAnimationDelay = 50;
            this.zeroitOJAnimEdit1.KeepColor = false;
            this.zeroitOJAnimEdit1.LowerSpeedLimit = 1;
            this.zeroitOJAnimEdit1.StandardAnimation = Zeroit.Framework.Transitions.ZeroitOJAnimEdit.ZeroitObjectStandardAnimation.Hop;
            this.zeroitOJAnimEdit1.StandardHopDelay = 100;
            this.zeroitOJAnimEdit1.StandardShootDelay = 50;
            this.zeroitOJAnimEdit1.StandardSlideDelay = 40;
            this.zeroitOJAnimEdit1.StandardSlugDelay = new int[] {
        100,
        50};
            this.zeroitOJAnimEdit1.UpperSpeedLimit = 10;
            // 
            // forgetPassword_UC1
            // 
            this.forgetPassword_UC1.BackColor = System.Drawing.Color.Transparent;
            this.forgetPassword_UC1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("forgetPassword_UC1.BackgroundImage")));
            this.forgetPassword_UC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.forgetPassword_UC1.Location = new System.Drawing.Point(0, 659);
            this.forgetPassword_UC1.Name = "forgetPassword_UC1";
            this.forgetPassword_UC1.Size = new System.Drawing.Size(440, 351);
            this.forgetPassword_UC1.TabIndex = 6;
            // 
            // ForgetPasswordUC_MoverUp
            // 
            this.ForgetPasswordUC_MoverUp.Acceleration = 0.7F;
            this.ForgetPasswordUC_MoverUp.AnimationType = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnimEdit.animationType.Slide;
            this.ForgetPasswordUC_MoverUp.Control = this.forgetPassword_UC1;
            this.ForgetPasswordUC_MoverUp.CordinateEnd_X = 0F;
            this.ForgetPasswordUC_MoverUp.CordinateEnd_Y = 670F;
            this.ForgetPasswordUC_MoverUp.CordinateStart_X = 0F;
            this.ForgetPasswordUC_MoverUp.CordinateStart_Y = 350F;
            this.ForgetPasswordUC_MoverUp.Duration = 800;
            this.ForgetPasswordUC_MoverUp.EasingEnd = 1F;
            this.ForgetPasswordUC_MoverUp.EasingNames = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnimEdit.easingNames.BackEaseIn;
            this.ForgetPasswordUC_MoverUp.EasingStart = 0.2F;
            this.ForgetPasswordUC_MoverUp.Editor = new Zeroit.Framework.Transitions.AnimationEditors.ZeroitPizaroAnimatorInput(Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnimEdit.animationType.Slide, 0F, 350F, 0F, 670F, true, this.forgetPassword_UC1, 800, 0.7F, 0.2F, 1F);
            this.ForgetPasswordUC_MoverUp.Fade_Begin = 0F;
            this.ForgetPasswordUC_MoverUp.Fade_Limit = 1F;
            this.ForgetPasswordUC_MoverUp.ResizeHeight_Begin = 10F;
            this.ForgetPasswordUC_MoverUp.ResizeHeight_Limit = 50F;
            this.ForgetPasswordUC_MoverUp.ResizeWidth_Begin = 10F;
            this.ForgetPasswordUC_MoverUp.ResizeWidth_Limit = 50F;
            // 
            // Login_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::studMin.Properties.Resources.Login_BG;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(440, 720);
            this.Controls.Add(this.forgetPassword_UC1);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.ForgetPassword_LinkLabel);
            this.Controls.Add(this.Login_Button);
            this.Controls.Add(this.Password_Box);
            this.Controls.Add(this.Username_Box);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login_Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "studMin - Đăng nhập";
            this.Load += new System.EventHandler(this.Login_Window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox Username_Box;
        private Guna.UI2.WinForms.Guna2TextBox Password_Box;
        private Guna.UI2.WinForms.Guna2Button Login_Button;
        private Guna.UI.WinForms.GunaLinkLabel ForgetPassword_LinkLabel;
        private Guna.UI2.WinForms.Guna2Button Exit_Button;
        private Guna.UI2.WinForms.Guna2Elipse RoundCornerForm;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private Guna.UI2.WinForms.Guna2DragControl DragForm;
        private Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnimEdit ForgetPasswordUC_MoverUp;
        private ForgetPassword_UC forgetPassword_UC1;
        private Zeroit.Framework.Transitions.ZeroitOJAnimEdit zeroitOJAnimEdit1;
    }
}

