namespace studMin
{
    partial class Timetable__Base
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
            this.FullGridView_Button = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // FullGridView_Button
            // 
            this.FullGridView_Button.Animated = true;
            this.FullGridView_Button.BackColor = System.Drawing.Color.White;
            this.FullGridView_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.FullGridView_Button.BorderRadius = 5;
            this.FullGridView_Button.BorderThickness = 2;
            this.FullGridView_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.FullGridView_Button.CheckedState.Parent = this.FullGridView_Button;
            this.FullGridView_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FullGridView_Button.CustomImages.Parent = this.FullGridView_Button;
            this.FullGridView_Button.FillColor = System.Drawing.Color.White;
            this.FullGridView_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FullGridView_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.FullGridView_Button.HoverState.FillColor = System.Drawing.Color.White;
            this.FullGridView_Button.HoverState.Parent = this.FullGridView_Button;
            this.FullGridView_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FullGridView_Button.Location = new System.Drawing.Point(36, 21);
            this.FullGridView_Button.Name = "FullGridView_Button";
            this.FullGridView_Button.PressedDepth = 20;
            this.FullGridView_Button.ShadowDecoration.Parent = this.FullGridView_Button;
            this.FullGridView_Button.Size = new System.Drawing.Size(107, 36);
            this.FullGridView_Button.TabIndex = 85;
            this.FullGridView_Button.Text = "CẢ LỚP";
            this.FullGridView_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // Timetable__Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.FullGridView_Button);
            this.Name = "Timetable__Base";
            this.Size = new System.Drawing.Size(924, 740);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button FullGridView_Button;
    }
}
