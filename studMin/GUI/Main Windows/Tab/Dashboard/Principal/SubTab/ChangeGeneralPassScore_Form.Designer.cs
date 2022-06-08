namespace studMin
{
    partial class ChangeGeneralPassScore_Form
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
            this.Exit_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Confirm_Button = new Guna.UI2.WinForms.Guna2Button();
            this.SubjectName_Label = new System.Windows.Forms.Label();
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.Elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.PassScoreTrackBar = new Guna.UI2.WinForms.Guna2TrackBar();
            this.PassScoreLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit_Button
            // 
            this.Exit_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Exit_Button.Animated = true;
            this.Exit_Button.BackColor = System.Drawing.Color.Transparent;
            this.Exit_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Exit_Button.BorderRadius = 10;
            this.Exit_Button.CheckedState.Parent = this.Exit_Button;
            this.Exit_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_Button.CustomImages.Parent = this.Exit_Button;
            this.Exit_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Exit_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Exit_Button.ForeColor = System.Drawing.Color.White;
            this.Exit_Button.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Exit_Button.HoverState.Parent = this.Exit_Button;
            this.Exit_Button.Location = new System.Drawing.Point(337, 164);
            this.Exit_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.ShadowDecoration.Parent = this.Exit_Button;
            this.Exit_Button.Size = new System.Drawing.Size(191, 44);
            this.Exit_Button.TabIndex = 130;
            this.Exit_Button.Text = "THOÁT";
            this.Exit_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // Confirm_Button
            // 
            this.Confirm_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Confirm_Button.Animated = true;
            this.Confirm_Button.BackColor = System.Drawing.Color.White;
            this.Confirm_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Confirm_Button.BorderRadius = 10;
            this.Confirm_Button.BorderThickness = 2;
            this.Confirm_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.Confirm_Button.CheckedState.Parent = this.Confirm_Button;
            this.Confirm_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Confirm_Button.CustomImages.Parent = this.Confirm_Button;
            this.Confirm_Button.FillColor = System.Drawing.Color.White;
            this.Confirm_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Confirm_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Confirm_Button.HoverState.FillColor = System.Drawing.Color.White;
            this.Confirm_Button.HoverState.Parent = this.Confirm_Button;
            this.Confirm_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Confirm_Button.Location = new System.Drawing.Point(100, 164);
            this.Confirm_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.PressedDepth = 20;
            this.Confirm_Button.ShadowDecoration.Parent = this.Confirm_Button;
            this.Confirm_Button.Size = new System.Drawing.Size(191, 44);
            this.Confirm_Button.TabIndex = 129;
            this.Confirm_Button.Text = "XÁC NHẬN";
            this.Confirm_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Confirm_Button.Click += new System.EventHandler(this.Confirm_Button_Click);
            // 
            // SubjectName_Label
            // 
            this.SubjectName_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.SubjectName_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubjectName_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SubjectName_Label.ForeColor = System.Drawing.Color.White;
            this.SubjectName_Label.Location = new System.Drawing.Point(0, 0);
            this.SubjectName_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SubjectName_Label.Name = "SubjectName_Label";
            this.SubjectName_Label.Size = new System.Drawing.Size(627, 54);
            this.SubjectName_Label.TabIndex = 131;
            this.SubjectName_Label.Text = "THAY ĐỔI ĐIỂM ĐẠT ĐỂ LÊN LỚP";
            this.SubjectName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SubjectName_Label.UseCompatibleTextRendering = true;
            // 
            // Elipse
            // 
            this.Elipse.BorderRadius = 10;
            this.Elipse.TargetControl = this;
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this.SubjectName_Label;
            // 
            // PassScoreTrackBar
            // 
            this.PassScoreTrackBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.PassScoreTrackBar.HoverState.Parent = this.PassScoreTrackBar;
            this.PassScoreTrackBar.Location = new System.Drawing.Point(44, 106);
            this.PassScoreTrackBar.Margin = new System.Windows.Forms.Padding(4);
            this.PassScoreTrackBar.Maximum = 6;
            this.PassScoreTrackBar.Minimum = 2;
            this.PassScoreTrackBar.Name = "PassScoreTrackBar";
            this.PassScoreTrackBar.Size = new System.Drawing.Size(491, 28);
            this.PassScoreTrackBar.TabIndex = 133;
            this.PassScoreTrackBar.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.PassScoreTrackBar.Value = 6;
            this.PassScoreTrackBar.ValueChanged += new System.EventHandler(this.PassScoreTrackBar_ValueChanged);
            // 
            // PassScoreLabel
            // 
            this.PassScoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.PassScoreLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PassScoreLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.PassScoreLabel.Location = new System.Drawing.Point(44, 70);
            this.PassScoreLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PassScoreLabel.Name = "PassScoreLabel";
            this.PassScoreLabel.Size = new System.Drawing.Size(491, 34);
            this.PassScoreLabel.TabIndex = 136;
            this.PassScoreLabel.Text = "Điểm lên lớp hiện tại:";
            this.PassScoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PassScoreLabel.UseCompatibleTextRendering = true;
            // 
            // ChangeGeneralPassScore_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 226);
            this.Controls.Add(this.PassScoreLabel);
            this.Controls.Add(this.PassScoreTrackBar);
            this.Controls.Add(this.SubjectName_Label);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Confirm_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ChangeGeneralPassScore_Form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeSubjectName_Form";
            this.Load += new System.EventHandler(this.ChangeGeneralPassScore_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Exit_Button;
        protected Guna.UI2.WinForms.Guna2Button Confirm_Button;
        private System.Windows.Forms.Label SubjectName_Label;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private Guna.UI2.WinForms.Guna2Elipse Elipse;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2TrackBar PassScoreTrackBar;
        private System.Windows.Forms.Label PassScoreLabel;
    }
}