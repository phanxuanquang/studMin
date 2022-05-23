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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeAgeRange_Form));
            this.Exit_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Confirm_Button = new Guna.UI2.WinForms.Guna2Button();
            this.SubjectName_Label = new System.Windows.Forms.Label();
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.MinAgeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.MaxAgeTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.MinAgeLabel = new System.Windows.Forms.Label();
            this.MaxAgeLabel = new System.Windows.Forms.Label();
            this.ValidProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.InvalidProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ValidProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvalidProvider)).BeginInit();
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
            this.Exit_Button.Location = new System.Drawing.Point(470, 396);
            this.Exit_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.ShadowDecoration.Parent = this.Exit_Button;
            this.Exit_Button.Size = new System.Drawing.Size(286, 69);
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
            this.Confirm_Button.Location = new System.Drawing.Point(114, 396);
            this.Confirm_Button.Margin = new System.Windows.Forms.Padding(6);
            this.Confirm_Button.Name = "Confirm_Button";
            this.Confirm_Button.PressedDepth = 20;
            this.Confirm_Button.ShadowDecoration.Parent = this.Confirm_Button;
            this.Confirm_Button.Size = new System.Drawing.Size(286, 69);
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
            this.SubjectName_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SubjectName_Label.Name = "SubjectName_Label";
            this.SubjectName_Label.Size = new System.Drawing.Size(868, 85);
            this.SubjectName_Label.TabIndex = 131;
            this.SubjectName_Label.Text = "THAY ĐỔI GIỚI HẠN TUỔI";
            this.SubjectName_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SubjectName_Label.UseCompatibleTextRendering = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // MinAgeTextBox
            // 
            this.MinAgeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MinAgeTextBox.Animated = true;
            this.MinAgeTextBox.BackColor = System.Drawing.Color.Transparent;
            this.MinAgeTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.MinAgeTextBox.BorderRadius = 15;
            this.MinAgeTextBox.BorderThickness = 2;
            this.MinAgeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MinAgeTextBox.DefaultText = "";
            this.MinAgeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MinAgeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MinAgeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MinAgeTextBox.DisabledState.Parent = this.MinAgeTextBox;
            this.MinAgeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MinAgeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.MinAgeTextBox.FocusedState.Parent = this.MinAgeTextBox;
            this.MinAgeTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MinAgeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.MinAgeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.MinAgeTextBox.HoverState.Parent = this.MinAgeTextBox;
            this.MinAgeTextBox.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.MinAgeTextBox.Location = new System.Drawing.Point(509, 127);
            this.MinAgeTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.MinAgeTextBox.Name = "MinAgeTextBox";
            this.MinAgeTextBox.PasswordChar = '\0';
            this.MinAgeTextBox.PlaceholderText = "10";
            this.MinAgeTextBox.SelectedText = "";
            this.MinAgeTextBox.ShadowDecoration.BorderRadius = 12;
            this.MinAgeTextBox.ShadowDecoration.Depth = 5;
            this.MinAgeTextBox.ShadowDecoration.Parent = this.MinAgeTextBox;
            this.MinAgeTextBox.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.MinAgeTextBox.Size = new System.Drawing.Size(295, 90);
            this.MinAgeTextBox.TabIndex = 134;
            this.MinAgeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinAgeTextBox.TextOffset = new System.Drawing.Point(3, 0);
            this.MinAgeTextBox.Validated += new System.EventHandler(this.MaxAgeTextBox_Validated);
            // 
            // MaxAgeTextBox
            // 
            this.MaxAgeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.MaxAgeTextBox.Animated = true;
            this.MaxAgeTextBox.BackColor = System.Drawing.Color.Transparent;
            this.MaxAgeTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.MaxAgeTextBox.BorderRadius = 15;
            this.MaxAgeTextBox.BorderThickness = 2;
            this.MaxAgeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaxAgeTextBox.DefaultText = "";
            this.MaxAgeTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MaxAgeTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MaxAgeTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MaxAgeTextBox.DisabledState.Parent = this.MaxAgeTextBox;
            this.MaxAgeTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MaxAgeTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.MaxAgeTextBox.FocusedState.Parent = this.MaxAgeTextBox;
            this.MaxAgeTextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaxAgeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.MaxAgeTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.MaxAgeTextBox.HoverState.Parent = this.MaxAgeTextBox;
            this.MaxAgeTextBox.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.MaxAgeTextBox.Location = new System.Drawing.Point(509, 254);
            this.MaxAgeTextBox.Margin = new System.Windows.Forms.Padding(8);
            this.MaxAgeTextBox.Name = "MaxAgeTextBox";
            this.MaxAgeTextBox.PasswordChar = '\0';
            this.MaxAgeTextBox.PlaceholderText = "18";
            this.MaxAgeTextBox.SelectedText = "";
            this.MaxAgeTextBox.ShadowDecoration.BorderRadius = 12;
            this.MaxAgeTextBox.ShadowDecoration.Depth = 5;
            this.MaxAgeTextBox.ShadowDecoration.Parent = this.MaxAgeTextBox;
            this.MaxAgeTextBox.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.MaxAgeTextBox.Size = new System.Drawing.Size(295, 90);
            this.MaxAgeTextBox.TabIndex = 135;
            this.MaxAgeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MaxAgeTextBox.TextOffset = new System.Drawing.Point(3, 0);
            this.MaxAgeTextBox.Validated += new System.EventHandler(this.MaxAgeTextBox_Validated);
            // 
            // DragControl
            // 
            this.DragControl.TargetControl = this;
            // 
            // MinAgeLabel
            // 
            this.MinAgeLabel.AutoSize = true;
            this.MinAgeLabel.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinAgeLabel.Location = new System.Drawing.Point(74, 152);
            this.MinAgeLabel.Name = "MinAgeLabel";
            this.MinAgeLabel.Size = new System.Drawing.Size(424, 50);
            this.MinAgeLabel.TabIndex = 136;
            this.MinAgeLabel.Text = "Tuổi nhập học tối thiểu";
            // 
            // MaxAgeLabel
            // 
            this.MaxAgeLabel.AutoSize = true;
            this.MaxAgeLabel.Font = new System.Drawing.Font("Segoe UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaxAgeLabel.Location = new System.Drawing.Point(74, 274);
            this.MaxAgeLabel.Name = "MaxAgeLabel";
            this.MaxAgeLabel.Size = new System.Drawing.Size(378, 50);
            this.MaxAgeLabel.TabIndex = 137;
            this.MaxAgeLabel.Text = "Tuổi nhập học tối đa";
            // 
            // ValidProvider
            // 
            this.ValidProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ValidProvider.ContainerControl = this;
            this.ValidProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ValidProvider.Icon")));
            // 
            // InvalidProvider
            // 
            this.InvalidProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.InvalidProvider.ContainerControl = this;
            this.InvalidProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("InvalidProvider.Icon")));
            // 
            // ChangeAgeRange_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 494);
            this.Controls.Add(this.MaxAgeLabel);
            this.Controls.Add(this.MinAgeLabel);
            this.Controls.Add(this.MaxAgeTextBox);
            this.Controls.Add(this.MinAgeTextBox);
            this.Controls.Add(this.SubjectName_Label);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.Confirm_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ChangeAgeRange_Form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChangeSubjectName_Form";
            ((System.ComponentModel.ISupportInitialize)(this.ValidProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvalidProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Exit_Button;
        protected Guna.UI2.WinForms.Guna2Button Confirm_Button;
        private System.Windows.Forms.Label SubjectName_Label;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2TextBox MaxAgeTextBox;
        private Guna.UI2.WinForms.Guna2TextBox MinAgeTextBox;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private System.Windows.Forms.Label MaxAgeLabel;
        private System.Windows.Forms.Label MinAgeLabel;
        private System.Windows.Forms.ErrorProvider ValidProvider;
        private System.Windows.Forms.ErrorProvider InvalidProvider;
    }
}