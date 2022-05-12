namespace studMin
{
    partial class PrincipalControl_SubTab
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
            this.PeopleManage_Button = new Guna.UI2.WinForms.Guna2Button();
            this.SubjectManage_Button = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // PeopleManage_Button
            // 
            this.PeopleManage_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PeopleManage_Button.Animated = true;
            this.PeopleManage_Button.BackColor = System.Drawing.Color.Transparent;
            this.PeopleManage_Button.BorderRadius = 40;
            this.PeopleManage_Button.CheckedState.Parent = this.PeopleManage_Button;
            this.PeopleManage_Button.CustomImages.Parent = this.PeopleManage_Button;
            this.PeopleManage_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.PeopleManage_Button.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PeopleManage_Button.ForeColor = System.Drawing.Color.White;
            this.PeopleManage_Button.HoverState.Parent = this.PeopleManage_Button;
            this.PeopleManage_Button.Location = new System.Drawing.Point(197, 235);
            this.PeopleManage_Button.Name = "PeopleManage_Button";
            this.PeopleManage_Button.ShadowDecoration.Parent = this.PeopleManage_Button;
            this.PeopleManage_Button.Size = new System.Drawing.Size(531, 94);
            this.PeopleManage_Button.TabIndex = 3;
            this.PeopleManage_Button.Text = "QUẢN LÝ NHÂN VIÊN";
            this.PeopleManage_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.PeopleManage_Button.Click += new System.EventHandler(this.PeopleManage_Button_Click);
            // 
            // SubjectManage_Button
            // 
            this.SubjectManage_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SubjectManage_Button.Animated = true;
            this.SubjectManage_Button.BackColor = System.Drawing.Color.Transparent;
            this.SubjectManage_Button.BorderRadius = 40;
            this.SubjectManage_Button.CheckedState.Parent = this.SubjectManage_Button;
            this.SubjectManage_Button.CustomImages.Parent = this.SubjectManage_Button;
            this.SubjectManage_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.SubjectManage_Button.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SubjectManage_Button.ForeColor = System.Drawing.Color.White;
            this.SubjectManage_Button.HoverState.Parent = this.SubjectManage_Button;
            this.SubjectManage_Button.Location = new System.Drawing.Point(197, 359);
            this.SubjectManage_Button.Name = "SubjectManage_Button";
            this.SubjectManage_Button.ShadowDecoration.Parent = this.SubjectManage_Button;
            this.SubjectManage_Button.Size = new System.Drawing.Size(531, 94);
            this.SubjectManage_Button.TabIndex = 4;
            this.SubjectManage_Button.Text = "QUẢN LÝ MÔN HỌC";
            this.SubjectManage_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;
            this.SubjectManage_Button.Click += new System.EventHandler(this.SubjectManage_Button_Click);
            // 
            // PrincipalControl_SubTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SubjectManage_Button);
            this.Controls.Add(this.PeopleManage_Button);
            this.Name = "PrincipalControl_SubTab";
            this.Size = new System.Drawing.Size(924, 688);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button PeopleManage_Button;
        private Guna.UI2.WinForms.Guna2Button SubjectManage_Button;
    }
}
