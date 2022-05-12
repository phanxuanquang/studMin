namespace studMin
{
    partial class AddSubject_Form
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
            this.Class_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // Class_Box
            // 
            this.Class_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Class_Box.Animated = true;
            this.Class_Box.BackColor = System.Drawing.Color.Transparent;
            this.Class_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Class_Box.BorderRadius = 5;
            this.Class_Box.BorderThickness = 2;
            this.Class_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Class_Box.DefaultText = "";
            this.Class_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Class_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Class_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Class_Box.DisabledState.Parent = this.Class_Box;
            this.Class_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Class_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Class_Box.FocusedState.Parent = this.Class_Box;
            this.Class_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Class_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Class_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Class_Box.HoverState.Parent = this.Class_Box;
            this.Class_Box.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.Class_Box.Location = new System.Drawing.Point(191, 34);
            this.Class_Box.Margin = new System.Windows.Forms.Padding(0);
            this.Class_Box.Name = "Class_Box";
            this.Class_Box.PasswordChar = '\0';
            this.Class_Box.PlaceholderText = "Không xác định";
            this.Class_Box.ReadOnly = true;
            this.Class_Box.SelectedText = "";
            this.Class_Box.ShadowDecoration.BorderRadius = 12;
            this.Class_Box.ShadowDecoration.Depth = 5;
            this.Class_Box.ShadowDecoration.Parent = this.Class_Box;
            this.Class_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.Class_Box.Size = new System.Drawing.Size(139, 22);
            this.Class_Box.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Class_Box.TabIndex = 117;
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoEllipsis = true;
            this.gunaLabel10.BackColor = System.Drawing.Color.White;
            this.gunaLabel10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.gunaLabel10.Location = new System.Drawing.Point(70, 37);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(96, 22);
            this.gunaLabel10.TabIndex = 116;
            this.gunaLabel10.Text = "• Tên môn học:";
            this.gunaLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel10.UseCompatibleTextRendering = true;
            // 
            // AddSubject_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(671, 348);
            this.Controls.Add(this.Class_Box);
            this.Controls.Add(this.gunaLabel10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddSubject_Form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSubject_Form";
            this.ResumeLayout(false);

        }

        #endregion

        protected Guna.UI2.WinForms.Guna2TextBox Class_Box;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
    }
}