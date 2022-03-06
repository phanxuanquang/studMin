namespace studMin
{
    partial class TeacherDashboard_Base
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuBar = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Badge = new System.Windows.Forms.Panel();
            this.StudentInfor_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ClassInfor_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.GradeModify_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.ContainerPanel = new System.Windows.Forms.Panel();
            this.BadgeMover = new Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnimEdit();
            this.panel1.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.panel1.Controls.Add(this.menuBar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 52);
            this.panel1.TabIndex = 16;
            // 
            // menuBar
            // 
            this.menuBar.Controls.Add(this.Badge);
            this.menuBar.Controls.Add(this.StudentInfor_Button);
            this.menuBar.Controls.Add(this.ClassInfor_Button);
            this.menuBar.Controls.Add(this.GradeModify_Button);
            this.menuBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.menuBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.menuBar.Location = new System.Drawing.Point(222, 5);
            this.menuBar.Name = "menuBar";
            this.menuBar.ShadowDecoration.Parent = this.menuBar;
            this.menuBar.Size = new System.Drawing.Size(480, 47);
            this.menuBar.TabIndex = 0;
            // 
            // Badge
            // 
            this.Badge.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Badge.BackColor = System.Drawing.Color.White;
            this.Badge.Location = new System.Drawing.Point(0, 42);
            this.Badge.Name = "Badge";
            this.Badge.Size = new System.Drawing.Size(160, 5);
            this.Badge.TabIndex = 23;
            // 
            // StudentInfor_Button
            // 
            this.StudentInfor_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.StudentInfor_Button.Animated = true;
            this.StudentInfor_Button.BackColor = System.Drawing.Color.White;
            this.StudentInfor_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.StudentInfor_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.StudentInfor_Button.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.StudentInfor_Button.CheckedState.Parent = this.StudentInfor_Button;
            this.StudentInfor_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentInfor_Button.CustomImages.Parent = this.StudentInfor_Button;
            this.StudentInfor_Button.FillColor = System.Drawing.Color.White;
            this.StudentInfor_Button.FillColor2 = System.Drawing.Color.White;
            this.StudentInfor_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.StudentInfor_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.StudentInfor_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.StudentInfor_Button.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.StudentInfor_Button.HoverState.Parent = this.StudentInfor_Button;
            this.StudentInfor_Button.Location = new System.Drawing.Point(160, 0);
            this.StudentInfor_Button.Name = "StudentInfor_Button";
            this.StudentInfor_Button.ShadowDecoration.Parent = this.StudentInfor_Button;
            this.StudentInfor_Button.Size = new System.Drawing.Size(160, 42);
            this.StudentInfor_Button.TabIndex = 23;
            this.StudentInfor_Button.Text = "HỌC SINH";
            this.StudentInfor_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.StudentInfor_Button.Click += new System.EventHandler(this.StudentInfor_Button_Click);
            // 
            // ClassInfor_Button
            // 
            this.ClassInfor_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ClassInfor_Button.Animated = true;
            this.ClassInfor_Button.BackColor = System.Drawing.Color.White;
            this.ClassInfor_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClassInfor_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClassInfor_Button.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClassInfor_Button.CheckedState.Parent = this.ClassInfor_Button;
            this.ClassInfor_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassInfor_Button.CustomImages.Parent = this.ClassInfor_Button;
            this.ClassInfor_Button.FillColor = System.Drawing.Color.White;
            this.ClassInfor_Button.FillColor2 = System.Drawing.Color.White;
            this.ClassInfor_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ClassInfor_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.ClassInfor_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClassInfor_Button.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ClassInfor_Button.HoverState.Parent = this.ClassInfor_Button;
            this.ClassInfor_Button.Location = new System.Drawing.Point(320, 0);
            this.ClassInfor_Button.Name = "ClassInfor_Button";
            this.ClassInfor_Button.ShadowDecoration.Parent = this.ClassInfor_Button;
            this.ClassInfor_Button.Size = new System.Drawing.Size(160, 42);
            this.ClassInfor_Button.TabIndex = 24;
            this.ClassInfor_Button.Text = "LỚP HỌC";
            this.ClassInfor_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.ClassInfor_Button.Click += new System.EventHandler(this.ClassInfor_Button_Click);
            // 
            // GradeModify_Button
            // 
            this.GradeModify_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.GradeModify_Button.Animated = true;
            this.GradeModify_Button.BackColor = System.Drawing.Color.White;
            this.GradeModify_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.GradeModify_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.GradeModify_Button.CheckedState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.GradeModify_Button.CheckedState.Parent = this.GradeModify_Button;
            this.GradeModify_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GradeModify_Button.CustomImages.Parent = this.GradeModify_Button;
            this.GradeModify_Button.FillColor = System.Drawing.Color.White;
            this.GradeModify_Button.FillColor2 = System.Drawing.Color.White;
            this.GradeModify_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GradeModify_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.GradeModify_Button.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.GradeModify_Button.HoverState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.GradeModify_Button.HoverState.Parent = this.GradeModify_Button;
            this.GradeModify_Button.Location = new System.Drawing.Point(0, 0);
            this.GradeModify_Button.Name = "GradeModify_Button";
            this.GradeModify_Button.ShadowDecoration.Parent = this.GradeModify_Button;
            this.GradeModify_Button.Size = new System.Drawing.Size(160, 42);
            this.GradeModify_Button.TabIndex = 22;
            this.GradeModify_Button.Text = "ĐIỂM SỐ";
            this.GradeModify_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.GradeModify_Button.Click += new System.EventHandler(this.GradeModify_Button_Click);
            // 
            // ContainerPanel
            // 
            this.ContainerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ContainerPanel.Location = new System.Drawing.Point(0, 52);
            this.ContainerPanel.Name = "ContainerPanel";
            this.ContainerPanel.Size = new System.Drawing.Size(924, 688);
            this.ContainerPanel.TabIndex = 17;
            // 
            // BadgeMover
            // 
            this.BadgeMover.Acceleration = 0.7F;
            this.BadgeMover.AnimationType = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnimEdit.animationType.Slide;
            this.BadgeMover.Control = this.Badge;
            this.BadgeMover.CordinateEnd_X = 0F;
            this.BadgeMover.CordinateEnd_Y = 47F;
            this.BadgeMover.CordinateStart_X = 0F;
            this.BadgeMover.CordinateStart_Y = 47F;
            this.BadgeMover.Duration = 800;
            this.BadgeMover.EasingEnd = 1F;
            this.BadgeMover.EasingNames = Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnimEdit.easingNames.BackEaseIn;
            this.BadgeMover.EasingStart = 0.2F;
            this.BadgeMover.Editor = new Zeroit.Framework.Transitions.AnimationEditors.ZeroitPizaroAnimatorInput(Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnimEdit.animationType.Slide, 0F, 47F, 0F, 47F, true, this.Badge, 800, 0.7F, 0.2F, 1F);
            this.BadgeMover.Fade_Begin = 0F;
            this.BadgeMover.Fade_Limit = 1F;
            this.BadgeMover.ResizeHeight_Begin = 10F;
            this.BadgeMover.ResizeHeight_Limit = 50F;
            this.BadgeMover.ResizeWidth_Begin = 10F;
            this.BadgeMover.ResizeWidth_Limit = 50F;
            // 
            // TeacherDashboard_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ContainerPanel);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Name = "TeacherDashboard_Base";
            this.Size = new System.Drawing.Size(924, 740);
            this.panel1.ResumeLayout(false);
            this.menuBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ContainerPanel;
        private Guna.UI2.WinForms.Guna2GradientButton GradeModify_Button;
        private Guna.UI2.WinForms.Guna2GradientButton ClassInfor_Button;
        private Guna.UI2.WinForms.Guna2GradientButton StudentInfor_Button;
        private Guna.UI2.WinForms.Guna2GradientPanel menuBar;
        private System.Windows.Forms.Panel Badge;
        private Zeroit.Framework.Transitions.ZeroitPizaroAnimator.ZeroitPizaroAnimEdit BadgeMover;
    }
}
