namespace studMin
{
    partial class MainWinfow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWinfow));
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.DragForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.RoundCornerForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.menuBar = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.Setting_MenuButton = new Guna.UI2.WinForms.Guna2Button();
            this.Dashboard_MenuButton = new Guna.UI2.WinForms.Guna2Button();
            this.Statistic_MenuButton = new Guna.UI2.WinForms.Guna2Button();
            this.Logout_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Notification_MenuButton = new Guna.UI2.WinForms.Guna2Button();
            this.Timetable_MenuButton = new Guna.UI2.WinForms.Guna2Button();
            this.ContainerPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Minimize_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Exit_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // DragForm
            // 
            this.DragForm.TargetControl = this;
            // 
            // RoundCornerForm
            // 
            this.RoundCornerForm.BorderRadius = 20;
            this.RoundCornerForm.TargetControl = this;
            // 
            // menuBar
            // 
            this.menuBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.menuBar.BackColor = System.Drawing.Color.Transparent;
            this.menuBar.Controls.Add(this.Setting_MenuButton);
            this.menuBar.Controls.Add(this.Dashboard_MenuButton);
            this.menuBar.Controls.Add(this.Statistic_MenuButton);
            this.menuBar.Controls.Add(this.Logout_Button);
            this.menuBar.Controls.Add(this.Notification_MenuButton);
            this.menuBar.Controls.Add(this.Timetable_MenuButton);
            this.menuBar.FillColor = System.Drawing.Color.White;
            this.menuBar.Location = new System.Drawing.Point(19, 25);
            this.menuBar.Name = "menuBar";
            this.menuBar.Radius = 15;
            this.menuBar.ShadowColor = System.Drawing.Color.Black;
            this.menuBar.ShadowDepth = 0;
            this.menuBar.ShadowShift = 0;
            this.menuBar.Size = new System.Drawing.Size(60, 750);
            this.menuBar.TabIndex = 0;
            // 
            // Setting_MenuButton
            // 
            this.Setting_MenuButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Setting_MenuButton.Animated = true;
            this.Setting_MenuButton.AutoRoundedCorners = true;
            this.Setting_MenuButton.BorderRadius = 21;
            this.Setting_MenuButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.Setting_MenuButton.CheckedState.Parent = this.Setting_MenuButton;
            this.Setting_MenuButton.CustomImages.Parent = this.Setting_MenuButton;
            this.Setting_MenuButton.FillColor = System.Drawing.Color.White;
            this.Setting_MenuButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Setting_MenuButton.ForeColor = System.Drawing.Color.White;
            this.Setting_MenuButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.Setting_MenuButton.HoverState.Parent = this.Setting_MenuButton;
            this.Setting_MenuButton.Image = ((System.Drawing.Image)(resources.GetObject("Setting_MenuButton.Image")));
            this.Setting_MenuButton.ImageSize = new System.Drawing.Size(21, 21);
            this.Setting_MenuButton.Location = new System.Drawing.Point(8, 271);
            this.Setting_MenuButton.Name = "Setting_MenuButton";
            this.Setting_MenuButton.ShadowDecoration.Parent = this.Setting_MenuButton;
            this.Setting_MenuButton.Size = new System.Drawing.Size(44, 44);
            this.Setting_MenuButton.TabIndex = 22;
            // 
            // Dashboard_MenuButton
            // 
            this.Dashboard_MenuButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Dashboard_MenuButton.Animated = true;
            this.Dashboard_MenuButton.AutoRoundedCorners = true;
            this.Dashboard_MenuButton.BorderRadius = 21;
            this.Dashboard_MenuButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.Dashboard_MenuButton.CheckedState.Parent = this.Dashboard_MenuButton;
            this.Dashboard_MenuButton.CustomImages.Parent = this.Dashboard_MenuButton;
            this.Dashboard_MenuButton.FillColor = System.Drawing.Color.White;
            this.Dashboard_MenuButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Dashboard_MenuButton.ForeColor = System.Drawing.Color.White;
            this.Dashboard_MenuButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.Dashboard_MenuButton.HoverState.Parent = this.Dashboard_MenuButton;
            this.Dashboard_MenuButton.Image = ((System.Drawing.Image)(resources.GetObject("Dashboard_MenuButton.Image")));
            this.Dashboard_MenuButton.ImageSize = new System.Drawing.Size(21, 21);
            this.Dashboard_MenuButton.Location = new System.Drawing.Point(8, 11);
            this.Dashboard_MenuButton.Name = "Dashboard_MenuButton";
            this.Dashboard_MenuButton.ShadowDecoration.Parent = this.Dashboard_MenuButton;
            this.Dashboard_MenuButton.Size = new System.Drawing.Size(44, 44);
            this.Dashboard_MenuButton.TabIndex = 16;
            // 
            // Statistic_MenuButton
            // 
            this.Statistic_MenuButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Statistic_MenuButton.Animated = true;
            this.Statistic_MenuButton.AutoRoundedCorners = true;
            this.Statistic_MenuButton.BorderRadius = 21;
            this.Statistic_MenuButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.Statistic_MenuButton.CheckedState.Parent = this.Statistic_MenuButton;
            this.Statistic_MenuButton.CustomImages.Parent = this.Statistic_MenuButton;
            this.Statistic_MenuButton.FillColor = System.Drawing.Color.White;
            this.Statistic_MenuButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Statistic_MenuButton.ForeColor = System.Drawing.Color.White;
            this.Statistic_MenuButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.Statistic_MenuButton.HoverState.Parent = this.Statistic_MenuButton;
            this.Statistic_MenuButton.Image = ((System.Drawing.Image)(resources.GetObject("Statistic_MenuButton.Image")));
            this.Statistic_MenuButton.ImageSize = new System.Drawing.Size(21, 21);
            this.Statistic_MenuButton.Location = new System.Drawing.Point(8, 206);
            this.Statistic_MenuButton.Name = "Statistic_MenuButton";
            this.Statistic_MenuButton.ShadowDecoration.Parent = this.Statistic_MenuButton;
            this.Statistic_MenuButton.Size = new System.Drawing.Size(44, 44);
            this.Statistic_MenuButton.TabIndex = 17;
            // 
            // Logout_Button
            // 
            this.Logout_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Logout_Button.Animated = true;
            this.Logout_Button.AutoRoundedCorners = true;
            this.Logout_Button.BorderRadius = 21;
            this.Logout_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.Logout_Button.CheckedState.Parent = this.Logout_Button;
            this.Logout_Button.CustomImages.Parent = this.Logout_Button;
            this.Logout_Button.FillColor = System.Drawing.Color.White;
            this.Logout_Button.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Logout_Button.ForeColor = System.Drawing.Color.White;
            this.Logout_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.Logout_Button.HoverState.Parent = this.Logout_Button;
            this.Logout_Button.Image = ((System.Drawing.Image)(resources.GetObject("Logout_Button.Image")));
            this.Logout_Button.ImageOffset = new System.Drawing.Point(1, 0);
            this.Logout_Button.ImageSize = new System.Drawing.Size(35, 35);
            this.Logout_Button.Location = new System.Drawing.Point(8, 696);
            this.Logout_Button.Name = "Logout_Button";
            this.Logout_Button.ShadowDecoration.Parent = this.Logout_Button;
            this.Logout_Button.Size = new System.Drawing.Size(44, 44);
            this.Logout_Button.TabIndex = 18;
            this.Logout_Button.Click += new System.EventHandler(this.Logout_Button_Click);
            // 
            // Notification_MenuButton
            // 
            this.Notification_MenuButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Notification_MenuButton.Animated = true;
            this.Notification_MenuButton.AutoRoundedCorners = true;
            this.Notification_MenuButton.BorderRadius = 21;
            this.Notification_MenuButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.Notification_MenuButton.CheckedState.Parent = this.Notification_MenuButton;
            this.Notification_MenuButton.CustomImages.Parent = this.Notification_MenuButton;
            this.Notification_MenuButton.FillColor = System.Drawing.Color.White;
            this.Notification_MenuButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Notification_MenuButton.ForeColor = System.Drawing.Color.White;
            this.Notification_MenuButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.Notification_MenuButton.HoverState.Parent = this.Notification_MenuButton;
            this.Notification_MenuButton.Image = ((System.Drawing.Image)(resources.GetObject("Notification_MenuButton.Image")));
            this.Notification_MenuButton.ImageSize = new System.Drawing.Size(21, 21);
            this.Notification_MenuButton.Location = new System.Drawing.Point(8, 141);
            this.Notification_MenuButton.Name = "Notification_MenuButton";
            this.Notification_MenuButton.ShadowDecoration.Parent = this.Notification_MenuButton;
            this.Notification_MenuButton.Size = new System.Drawing.Size(44, 44);
            this.Notification_MenuButton.TabIndex = 20;
            // 
            // Timetable_MenuButton
            // 
            this.Timetable_MenuButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Timetable_MenuButton.Animated = true;
            this.Timetable_MenuButton.AutoRoundedCorners = true;
            this.Timetable_MenuButton.BorderRadius = 21;
            this.Timetable_MenuButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.Timetable_MenuButton.CheckedState.Parent = this.Timetable_MenuButton;
            this.Timetable_MenuButton.CustomImages.Parent = this.Timetable_MenuButton;
            this.Timetable_MenuButton.FillColor = System.Drawing.Color.White;
            this.Timetable_MenuButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Timetable_MenuButton.ForeColor = System.Drawing.Color.White;
            this.Timetable_MenuButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.Timetable_MenuButton.HoverState.Parent = this.Timetable_MenuButton;
            this.Timetable_MenuButton.Image = ((System.Drawing.Image)(resources.GetObject("Timetable_MenuButton.Image")));
            this.Timetable_MenuButton.ImageSize = new System.Drawing.Size(21, 21);
            this.Timetable_MenuButton.Location = new System.Drawing.Point(8, 76);
            this.Timetable_MenuButton.Name = "Timetable_MenuButton";
            this.Timetable_MenuButton.ShadowDecoration.Parent = this.Timetable_MenuButton;
            this.Timetable_MenuButton.Size = new System.Drawing.Size(44, 44);
            this.Timetable_MenuButton.TabIndex = 19;
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ContainerPanel.BorderRadius = 15;
            this.ContainerPanel.FillColor = System.Drawing.Color.White;
            this.ContainerPanel.FillColor2 = System.Drawing.Color.White;
            this.ContainerPanel.Location = new System.Drawing.Point(97, 36);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.ShadowDecoration.Parent = this.ContainerPanel;
            this.ContainerPanel.Size = new System.Drawing.Size(924, 740);
            this.ContainerPanel.TabIndex = 5;
            // 
            // Minimize_Button
            // 
            this.Minimize_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize_Button.BackColor = System.Drawing.Color.Transparent;
            this.Minimize_Button.CheckedState.Parent = this.Minimize_Button;
            this.Minimize_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_Button.HoverState.ImageSize = new System.Drawing.Size(21, 21);
            this.Minimize_Button.HoverState.Parent = this.Minimize_Button;
            this.Minimize_Button.Image = global::studMin.Properties.Resources.Minimize;
            this.Minimize_Button.Location = new System.Drawing.Point(998, 6);
            this.Minimize_Button.Name = "Minimize_Button";
            this.Minimize_Button.PressedState.Parent = this.Minimize_Button;
            this.Minimize_Button.Size = new System.Drawing.Size(25, 25);
            this.Minimize_Button.TabIndex = 2;
            this.Minimize_Button.Click += new System.EventHandler(this.Minimize_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit_Button.BackColor = System.Drawing.Color.Transparent;
            this.Exit_Button.CheckedState.Parent = this.Exit_Button;
            this.Exit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Button.HoverState.ImageSize = new System.Drawing.Size(21, 21);
            this.Exit_Button.HoverState.Parent = this.Exit_Button;
            this.Exit_Button.Image = global::studMin.Properties.Resources.Exit;
            this.Exit_Button.Location = new System.Drawing.Point(1026, 6);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.PressedState.Parent = this.Exit_Button;
            this.Exit_Button.Size = new System.Drawing.Size(25, 25);
            this.Exit_Button.TabIndex = 0;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // MainWinfow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(1058, 800);
            this.Controls.Add(this.ContainerPanel);
            this.Controls.Add(this.Minimize_Button);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.menuBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWinfow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "studMin";
            this.menuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private Guna.UI2.WinForms.Guna2DragControl DragForm;
        private Guna.UI2.WinForms.Guna2Elipse RoundCornerForm;
        private Guna.UI2.WinForms.Guna2ShadowPanel menuBar;
        private Guna.UI2.WinForms.Guna2Button Setting_MenuButton;
        private Guna.UI2.WinForms.Guna2Button Dashboard_MenuButton;
        private Guna.UI2.WinForms.Guna2Button Statistic_MenuButton;
        private Guna.UI2.WinForms.Guna2Button Logout_Button;
        private Guna.UI2.WinForms.Guna2Button Notification_MenuButton;
        private Guna.UI2.WinForms.Guna2Button Timetable_MenuButton;
        private Guna.UI2.WinForms.Guna2ImageButton Exit_Button;
        private Guna.UI2.WinForms.Guna2ImageButton Minimize_Button;
        private Guna.UI2.WinForms.Guna2GradientPanel ContainerPanel;
    }
}