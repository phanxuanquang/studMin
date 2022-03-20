namespace studMin
{
    partial class Timetable_Tab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TopBanner = new System.Windows.Forms.Panel();
            this.menuBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Badge = new System.Windows.Forms.Panel();
            this.TeacherTimetable_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.StudentTimetable_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.TopBanner.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopBanner
            // 
            this.TopBanner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.TopBanner.Controls.Add(this.menuBar);
            this.TopBanner.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopBanner.Location = new System.Drawing.Point(0, 0);
            this.TopBanner.Name = "TopBanner";
            this.TopBanner.Size = new System.Drawing.Size(924, 52);
            this.TopBanner.TabIndex = 17;
            // 
            // menuBar
            // 
            this.menuBar.Controls.Add(this.Badge);
            this.menuBar.Controls.Add(this.TeacherTimetable_Button);
            this.menuBar.Controls.Add(this.StudentTimetable_Button);
            this.menuBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.menuBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.menuBar.Location = new System.Drawing.Point(142, 5);
            this.menuBar.Name = "menuBar";
            this.menuBar.ShadowDecoration.Parent = this.menuBar;
            this.menuBar.Size = new System.Drawing.Size(640, 47);
            this.menuBar.TabIndex = 0;
            // 
            // Badge
            // 
            this.Badge.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Badge.BackColor = System.Drawing.Color.White;
            this.Badge.Location = new System.Drawing.Point(160, 42);
            this.Badge.Name = "Badge";
            this.Badge.Size = new System.Drawing.Size(160, 5);
            this.Badge.TabIndex = 23;
            // 
            // TeacherTimetable_Button
            // 
            this.TeacherTimetable_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.TeacherTimetable_Button.Animated = true;
            this.TeacherTimetable_Button.BackColor = System.Drawing.Color.White;
            this.TeacherTimetable_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.TeacherTimetable_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.TeacherTimetable_Button.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.TeacherTimetable_Button.CheckedState.Parent = this.TeacherTimetable_Button;
            this.TeacherTimetable_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TeacherTimetable_Button.CustomImages.Parent = this.TeacherTimetable_Button;
            this.TeacherTimetable_Button.FillColor = System.Drawing.Color.White;
            this.TeacherTimetable_Button.FillColor2 = System.Drawing.Color.White;
            this.TeacherTimetable_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TeacherTimetable_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.TeacherTimetable_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.TeacherTimetable_Button.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.TeacherTimetable_Button.HoverState.Parent = this.TeacherTimetable_Button;
            this.TeacherTimetable_Button.Location = new System.Drawing.Point(320, 0);
            this.TeacherTimetable_Button.Name = "TeacherTimetable_Button";
            this.TeacherTimetable_Button.ShadowDecoration.Parent = this.TeacherTimetable_Button;
            this.TeacherTimetable_Button.Size = new System.Drawing.Size(160, 42);
            this.TeacherTimetable_Button.TabIndex = 23;
            this.TeacherTimetable_Button.Text = "GIÁO VIÊN";
            this.TeacherTimetable_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.TeacherTimetable_Button.Click += new System.EventHandler(this.TeacherTimetable_Button_Click);
            // 
            // StudentTimetable_Button
            // 
            this.StudentTimetable_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.StudentTimetable_Button.Animated = true;
            this.StudentTimetable_Button.BackColor = System.Drawing.Color.White;
            this.StudentTimetable_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.StudentTimetable_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.StudentTimetable_Button.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.StudentTimetable_Button.CheckedState.Parent = this.StudentTimetable_Button;
            this.StudentTimetable_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentTimetable_Button.CustomImages.Parent = this.StudentTimetable_Button;
            this.StudentTimetable_Button.FillColor = System.Drawing.Color.White;
            this.StudentTimetable_Button.FillColor2 = System.Drawing.Color.White;
            this.StudentTimetable_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.StudentTimetable_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.StudentTimetable_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.StudentTimetable_Button.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.StudentTimetable_Button.HoverState.Parent = this.StudentTimetable_Button;
            this.StudentTimetable_Button.Location = new System.Drawing.Point(160, 0);
            this.StudentTimetable_Button.Name = "StudentTimetable_Button";
            this.StudentTimetable_Button.ShadowDecoration.Parent = this.StudentTimetable_Button;
            this.StudentTimetable_Button.Size = new System.Drawing.Size(160, 42);
            this.StudentTimetable_Button.TabIndex = 22;
            this.StudentTimetable_Button.Text = "HỌC SINH";
            this.StudentTimetable_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.StudentTimetable_Button.Click += new System.EventHandler(this.StudentTimetable_Button_Click);
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ContainerPanel.Location = new System.Drawing.Point(0, 52);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(924, 688);
            this.ContainerPanel.TabIndex = 18;
            // 
            // Timetable_Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ContainerPanel);
            this.Controls.Add(this.TopBanner);
            this.Name = "Timetable_Tab";
            this.Size = new System.Drawing.Size(924, 740);
            this.TopBanner.ResumeLayout(false);
            this.menuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopBanner;
        protected Guna.UI2.WinForms.Guna2GradientPanel menuBar;
        protected System.Windows.Forms.Panel Badge;
        protected Guna.UI2.WinForms.Guna2GradientButton TeacherTimetable_Button;
        protected Guna.UI2.WinForms.Guna2GradientButton StudentTimetable_Button;
        protected System.Windows.Forms.Panel ContainerPanel;
    }
}
