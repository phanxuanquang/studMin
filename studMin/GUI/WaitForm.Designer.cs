namespace studMin
{
    partial class WaitForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ApplyDate_Label = new System.Windows.Forms.Label();
            this.RoundCornerForm = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.panel1.Cursor = System.Windows.Forms.Cursors.No;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.panel1.Location = new System.Drawing.Point(0, 177);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 15);
            this.panel1.TabIndex = 114;
            // 
            // ApplyDate_Label
            // 
            this.ApplyDate_Label.BackColor = System.Drawing.Color.Transparent;
            this.ApplyDate_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApplyDate_Label.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ApplyDate_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.ApplyDate_Label.Location = new System.Drawing.Point(0, 0);
            this.ApplyDate_Label.Name = "ApplyDate_Label";
            this.ApplyDate_Label.Size = new System.Drawing.Size(368, 177);
            this.ApplyDate_Label.TabIndex = 115;
            this.ApplyDate_Label.Text = "ĐANG TẢI DỮ LIỆU";
            this.ApplyDate_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ApplyDate_Label.UseCompatibleTextRendering = true;
            // 
            // RoundCornerForm
            // 
            this.RoundCornerForm.BorderRadius = 20;
            this.RoundCornerForm.TargetControl = this;
            // 
            // WaitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(368, 192);
            this.Controls.Add(this.ApplyDate_Label);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WaitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vui lòng đợi . . .";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ApplyDate_Label;
        private Guna.UI2.WinForms.Guna2Elipse RoundCornerForm;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
    }
}