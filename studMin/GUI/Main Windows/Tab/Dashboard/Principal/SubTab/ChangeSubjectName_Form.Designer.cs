namespace studMin
{
    partial class ChangeSubjectName_Form
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
            this.SubjectName_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ConfirmSubjectName_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
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
            this.Exit_Button.Location = new System.Drawing.Point(277, 206);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.ShadowDecoration.Parent = this.Exit_Button;
            this.Exit_Button.Size = new System.Drawing.Size(143, 36);
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
            this.Confirm_Button.Location = new System.Drawing.Point(99, 206);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.PressedDepth = 20;
            this.Confirm_Button.ShadowDecoration.Parent = this.Confirm_Button;
            this.Confirm_Button.Size = new System.Drawing.Size(143, 36);
            this.Confirm_Button.TabIndex = 2;
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
            this.SubjectName_Label.Name = "SubjectName_Label";
            this.SubjectName_Label.Size = new System.Drawing.Size(518, 44);
            this.SubjectName_Label.TabIndex = 131;
            this.SubjectName_Label.Text = "THAY ĐỔI TÊN MÔN ";
            this.SubjectName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SubjectName_Label.UseCompatibleTextRendering = true;
            // 
            // SubjectName_Box
            // 
            this.SubjectName_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SubjectName_Box.Animated = true;
            this.SubjectName_Box.BackColor = System.Drawing.Color.Transparent;
            this.SubjectName_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.SubjectName_Box.BorderRadius = 15;
            this.SubjectName_Box.BorderThickness = 2;
            this.SubjectName_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SubjectName_Box.DefaultText = "";
            this.SubjectName_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SubjectName_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SubjectName_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SubjectName_Box.DisabledState.Parent = this.SubjectName_Box;
            this.SubjectName_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SubjectName_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.SubjectName_Box.FocusedState.Parent = this.SubjectName_Box;
            this.SubjectName_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SubjectName_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.SubjectName_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.SubjectName_Box.HoverState.Parent = this.SubjectName_Box;
            this.SubjectName_Box.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.SubjectName_Box.Location = new System.Drawing.Point(47, 66);
            this.SubjectName_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SubjectName_Box.Name = "SubjectName_Box";
            this.SubjectName_Box.PasswordChar = '\0';
            this.SubjectName_Box.PlaceholderText = " Tên mới của môn học";
            this.SubjectName_Box.SelectedText = "";
            this.SubjectName_Box.ShadowDecoration.BorderRadius = 12;
            this.SubjectName_Box.ShadowDecoration.Depth = 5;
            this.SubjectName_Box.ShadowDecoration.Parent = this.SubjectName_Box;
            this.SubjectName_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.SubjectName_Box.Size = new System.Drawing.Size(424, 47);
            this.SubjectName_Box.TabIndex = 0;
            this.SubjectName_Box.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // ConfirmSubjectName_Box
            // 
            this.ConfirmSubjectName_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ConfirmSubjectName_Box.Animated = true;
            this.ConfirmSubjectName_Box.BackColor = System.Drawing.Color.Transparent;
            this.ConfirmSubjectName_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.ConfirmSubjectName_Box.BorderRadius = 15;
            this.ConfirmSubjectName_Box.BorderThickness = 2;
            this.ConfirmSubjectName_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ConfirmSubjectName_Box.DefaultText = "";
            this.ConfirmSubjectName_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ConfirmSubjectName_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ConfirmSubjectName_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmSubjectName_Box.DisabledState.Parent = this.ConfirmSubjectName_Box;
            this.ConfirmSubjectName_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ConfirmSubjectName_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.ConfirmSubjectName_Box.FocusedState.Parent = this.ConfirmSubjectName_Box;
            this.ConfirmSubjectName_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ConfirmSubjectName_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.ConfirmSubjectName_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.ConfirmSubjectName_Box.HoverState.Parent = this.ConfirmSubjectName_Box;
            this.ConfirmSubjectName_Box.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.ConfirmSubjectName_Box.Location = new System.Drawing.Point(47, 132);
            this.ConfirmSubjectName_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfirmSubjectName_Box.Name = "ConfirmSubjectName_Box";
            this.ConfirmSubjectName_Box.PasswordChar = '\0';
            this.ConfirmSubjectName_Box.PlaceholderText = "Xác nhận lại tên mới của môn học";
            this.ConfirmSubjectName_Box.SelectedText = "";
            this.ConfirmSubjectName_Box.ShadowDecoration.BorderRadius = 12;
            this.ConfirmSubjectName_Box.ShadowDecoration.Depth = 5;
            this.ConfirmSubjectName_Box.ShadowDecoration.Parent = this.ConfirmSubjectName_Box;
            this.ConfirmSubjectName_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.ConfirmSubjectName_Box.Size = new System.Drawing.Size(424, 47);
            this.ConfirmSubjectName_Box.TabIndex = 1;
            this.ConfirmSubjectName_Box.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.SubjectName_Label;
            // 
            // ChangeSubjectName_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 257);
            this.Controls.Add(this.ConfirmSubjectName_Box);
            this.Controls.Add(this.SubjectName_Box);
            this.Controls.Add(this.SubjectName_Label);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Confirm_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeSubjectName_Form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeSubjectName_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Exit_Button;
        protected Guna.UI2.WinForms.Guna2Button Confirm_Button;
        private System.Windows.Forms.Label SubjectName_Label;
        private Guna.UI2.WinForms.Guna2TextBox SubjectName_Box;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox ConfirmSubjectName_Box;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}