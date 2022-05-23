namespace studMin
{
    partial class ChangeAgeRange_Form
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
            this.MinAge_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.MaxAge_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.MinAgeCurrent_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.MaxAgeCurrent_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
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
            this.Exit_Button.Location = new System.Drawing.Point(235, 206);
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
            this.Confirm_Button.Location = new System.Drawing.Point(57, 206);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.PressedDepth = 20;
            this.Confirm_Button.ShadowDecoration.Parent = this.Confirm_Button;
            this.Confirm_Button.Size = new System.Drawing.Size(143, 36);
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
            this.SubjectName_Label.Name = "SubjectName_Label";
            this.SubjectName_Label.Size = new System.Drawing.Size(434, 44);
            this.SubjectName_Label.TabIndex = 131;
            this.SubjectName_Label.Text = "THAY ĐỔI GIỚI HẠN TUỔI";
            this.SubjectName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SubjectName_Label.UseCompatibleTextRendering = true;
            // 
            // MinAge_Box
            // 
            this.MinAge_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MinAge_Box.Animated = true;
            this.MinAge_Box.BackColor = System.Drawing.Color.Transparent;
            this.MinAge_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.MinAge_Box.BorderRadius = 15;
            this.MinAge_Box.BorderThickness = 2;
            this.MinAge_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MinAge_Box.DefaultText = "";
            this.MinAge_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MinAge_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MinAge_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MinAge_Box.DisabledState.Parent = this.MinAge_Box;
            this.MinAge_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MinAge_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.MinAge_Box.FocusedState.Parent = this.MinAge_Box;
            this.MinAge_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MinAge_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.MinAge_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.MinAge_Box.HoverState.Parent = this.MinAge_Box;
            this.MinAge_Box.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.MinAge_Box.Location = new System.Drawing.Point(47, 66);
            this.MinAge_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinAge_Box.Name = "MinAge_Box";
            this.MinAge_Box.PasswordChar = '\0';
            this.MinAge_Box.PlaceholderText = " Tuổi nhập học tối thiểu";
            this.MinAge_Box.SelectedText = "";
            this.MinAge_Box.ShadowDecoration.BorderRadius = 12;
            this.MinAge_Box.ShadowDecoration.Depth = 5;
            this.MinAge_Box.ShadowDecoration.Parent = this.MinAge_Box;
            this.MinAge_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.MinAge_Box.Size = new System.Drawing.Size(246, 47);
            this.MinAge_Box.TabIndex = 132;
            this.MinAge_Box.TextOffset = new System.Drawing.Point(3, 0);
            this.MinAge_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Age_Box_KeyPress);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // MaxAge_Box
            // 
            this.MaxAge_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxAge_Box.Animated = true;
            this.MaxAge_Box.BackColor = System.Drawing.Color.Transparent;
            this.MaxAge_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.MaxAge_Box.BorderRadius = 15;
            this.MaxAge_Box.BorderThickness = 2;
            this.MaxAge_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaxAge_Box.DefaultText = "";
            this.MaxAge_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MaxAge_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MaxAge_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MaxAge_Box.DisabledState.Parent = this.MaxAge_Box;
            this.MaxAge_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MaxAge_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.MaxAge_Box.FocusedState.Parent = this.MaxAge_Box;
            this.MaxAge_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaxAge_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.MaxAge_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.MaxAge_Box.HoverState.Parent = this.MaxAge_Box;
            this.MaxAge_Box.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.MaxAge_Box.Location = new System.Drawing.Point(47, 132);
            this.MaxAge_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxAge_Box.Name = "MaxAge_Box";
            this.MaxAge_Box.PasswordChar = '\0';
            this.MaxAge_Box.PlaceholderText = "Tuổi tối đa của học sinh";
            this.MaxAge_Box.SelectedText = "";
            this.MaxAge_Box.ShadowDecoration.BorderRadius = 12;
            this.MaxAge_Box.ShadowDecoration.Depth = 5;
            this.MaxAge_Box.ShadowDecoration.Parent = this.MaxAge_Box;
            this.MaxAge_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.MaxAge_Box.Size = new System.Drawing.Size(246, 47);
            this.MaxAge_Box.TabIndex = 133;
            this.MaxAge_Box.TextOffset = new System.Drawing.Point(3, 0);
            this.MaxAge_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Age_Box_KeyPress);
            // 
            // MinAgeCurrent_Box
            // 
            this.MinAgeCurrent_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MinAgeCurrent_Box.Animated = true;
            this.MinAgeCurrent_Box.BackColor = System.Drawing.Color.Transparent;
            this.MinAgeCurrent_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.MinAgeCurrent_Box.BorderRadius = 15;
            this.MinAgeCurrent_Box.BorderThickness = 2;
            this.MinAgeCurrent_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MinAgeCurrent_Box.DefaultText = "";
            this.MinAgeCurrent_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MinAgeCurrent_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MinAgeCurrent_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MinAgeCurrent_Box.DisabledState.Parent = this.MinAgeCurrent_Box;
            this.MinAgeCurrent_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MinAgeCurrent_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.MinAgeCurrent_Box.FocusedState.Parent = this.MinAgeCurrent_Box;
            this.MinAgeCurrent_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MinAgeCurrent_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.MinAgeCurrent_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.MinAgeCurrent_Box.HoverState.Parent = this.MinAgeCurrent_Box;
            this.MinAgeCurrent_Box.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.MinAgeCurrent_Box.Location = new System.Drawing.Point(301, 66);
            this.MinAgeCurrent_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinAgeCurrent_Box.Name = "MinAgeCurrent_Box";
            this.MinAgeCurrent_Box.PasswordChar = '\0';
            this.MinAgeCurrent_Box.PlaceholderText = "";
            this.MinAgeCurrent_Box.ReadOnly = true;
            this.MinAgeCurrent_Box.SelectedText = "";
            this.MinAgeCurrent_Box.ShadowDecoration.BorderRadius = 12;
            this.MinAgeCurrent_Box.ShadowDecoration.Depth = 5;
            this.MinAgeCurrent_Box.ShadowDecoration.Parent = this.MinAgeCurrent_Box;
            this.MinAgeCurrent_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.MinAgeCurrent_Box.Size = new System.Drawing.Size(101, 47);
            this.MinAgeCurrent_Box.TabIndex = 134;
            this.MinAgeCurrent_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinAgeCurrent_Box.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // MaxAgeCurrent_Box
            // 
            this.MaxAgeCurrent_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxAgeCurrent_Box.Animated = true;
            this.MaxAgeCurrent_Box.BackColor = System.Drawing.Color.Transparent;
            this.MaxAgeCurrent_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.MaxAgeCurrent_Box.BorderRadius = 15;
            this.MaxAgeCurrent_Box.BorderThickness = 2;
            this.MaxAgeCurrent_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaxAgeCurrent_Box.DefaultText = "";
            this.MaxAgeCurrent_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MaxAgeCurrent_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MaxAgeCurrent_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MaxAgeCurrent_Box.DisabledState.Parent = this.MaxAgeCurrent_Box;
            this.MaxAgeCurrent_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MaxAgeCurrent_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.MaxAgeCurrent_Box.FocusedState.Parent = this.MaxAgeCurrent_Box;
            this.MaxAgeCurrent_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaxAgeCurrent_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.MaxAgeCurrent_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.MaxAgeCurrent_Box.HoverState.Parent = this.MaxAgeCurrent_Box;
            this.MaxAgeCurrent_Box.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.MaxAgeCurrent_Box.Location = new System.Drawing.Point(301, 132);
            this.MaxAgeCurrent_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxAgeCurrent_Box.Name = "MaxAgeCurrent_Box";
            this.MaxAgeCurrent_Box.PasswordChar = '\0';
            this.MaxAgeCurrent_Box.PlaceholderText = "";
            this.MaxAgeCurrent_Box.ReadOnly = true;
            this.MaxAgeCurrent_Box.SelectedText = "";
            this.MaxAgeCurrent_Box.ShadowDecoration.BorderRadius = 12;
            this.MaxAgeCurrent_Box.ShadowDecoration.Depth = 5;
            this.MaxAgeCurrent_Box.ShadowDecoration.Parent = this.MaxAgeCurrent_Box;
            this.MaxAgeCurrent_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.MaxAgeCurrent_Box.Size = new System.Drawing.Size(101, 47);
            this.MaxAgeCurrent_Box.TabIndex = 135;
            this.MaxAgeCurrent_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaxAgeCurrent_Box.TextOffset = new System.Drawing.Point(3, 0);
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this;
            // 
            // ChangeAgeRange_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 257);
            this.Controls.Add(this.MaxAgeCurrent_Box);
            this.Controls.Add(this.MinAgeCurrent_Box);
            this.Controls.Add(this.MaxAge_Box);
            this.Controls.Add(this.MinAge_Box);
            this.Controls.Add(this.SubjectName_Label);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Confirm_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChangeAgeRange_Form";
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
        private Guna.UI2.WinForms.Guna2TextBox MinAge_Box;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox MaxAge_Box;
        private Guna.UI2.WinForms.Guna2TextBox MaxAgeCurrent_Box;
        private Guna.UI2.WinForms.Guna2TextBox MinAgeCurrent_Box;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
    }
}