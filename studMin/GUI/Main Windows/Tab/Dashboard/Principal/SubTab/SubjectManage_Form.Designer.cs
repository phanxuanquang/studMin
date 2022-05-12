namespace studMin
{
    partial class SubjectManage_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirePerson_Button = new Guna.UI2.WinForms.Guna2Button();
            this.ChangeSubjectName_Button = new Guna.UI2.WinForms.Guna2Button();
            this.AddSubject_Button = new Guna.UI2.WinForms.Guna2Button();
            this.ChangeSubjectHead_Button = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.ShadowForm = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTable
            // 
            this.DataTable.AllowDrop = true;
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataTable.BackgroundColor = System.Drawing.Color.White;
            this.DataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataTable.ColumnHeadersHeight = 25;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FullName,
            this.Status,
            this.TeacherRole});
            this.DataTable.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataTable.EnableHeadersVisualStyles = false;
            this.DataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.DataTable.Location = new System.Drawing.Point(0, 57);
            this.DataTable.Name = "DataTable";
            this.DataTable.ReadOnly = true;
            this.DataTable.RowHeadersVisible = false;
            this.DataTable.RowHeadersWidth = 51;
            this.DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataTable.Size = new System.Drawing.Size(977, 489);
            this.DataTable.TabIndex = 103;
            this.DataTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.DataTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.DataTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DataTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.DataTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataTable.ThemeStyle.HeaderStyle.Height = 25;
            this.DataTable.ThemeStyle.ReadOnly = true;
            this.DataTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.DataTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DataTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.DataTable.ThemeStyle.RowsStyle.Height = 22;
            this.DataTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.DataTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            // 
            // ID
            // 
            this.ID.FillWeight = 120F;
            this.ID.HeaderText = "Mã môn học";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Tên môn học";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Trưởng bộ môn";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // TeacherRole
            // 
            this.TeacherRole.HeaderText = "Số lượng giáo viên";
            this.TeacherRole.Name = "TeacherRole";
            this.TeacherRole.ReadOnly = true;
            // 
            // FirePerson_Button
            // 
            this.FirePerson_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.FirePerson_Button.Animated = true;
            this.FirePerson_Button.BackColor = System.Drawing.Color.Transparent;
            this.FirePerson_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.FirePerson_Button.BorderRadius = 5;
            this.FirePerson_Button.CheckedState.Parent = this.FirePerson_Button;
            this.FirePerson_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FirePerson_Button.CustomImages.Parent = this.FirePerson_Button;
            this.FirePerson_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.FirePerson_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.FirePerson_Button.ForeColor = System.Drawing.Color.White;
            this.FirePerson_Button.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.FirePerson_Button.HoverState.Parent = this.FirePerson_Button;
            this.FirePerson_Button.Location = new System.Drawing.Point(731, 12);
            this.FirePerson_Button.Name = "FirePerson_Button";
            this.FirePerson_Button.ShadowDecoration.Parent = this.FirePerson_Button;
            this.FirePerson_Button.Size = new System.Drawing.Size(234, 36);
            this.FirePerson_Button.TabIndex = 129;
            this.FirePerson_Button.Text = "THOÁT";
            this.FirePerson_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.FirePerson_Button.Click += new System.EventHandler(this.FirePerson_Button_Click);
            // 
            // ChangeSubjectName_Button
            // 
            this.ChangeSubjectName_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ChangeSubjectName_Button.Animated = true;
            this.ChangeSubjectName_Button.BackColor = System.Drawing.Color.White;
            this.ChangeSubjectName_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.ChangeSubjectName_Button.BorderRadius = 5;
            this.ChangeSubjectName_Button.BorderThickness = 2;
            this.ChangeSubjectName_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ChangeSubjectName_Button.CheckedState.Parent = this.ChangeSubjectName_Button;
            this.ChangeSubjectName_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeSubjectName_Button.CustomImages.Parent = this.ChangeSubjectName_Button;
            this.ChangeSubjectName_Button.FillColor = System.Drawing.Color.White;
            this.ChangeSubjectName_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ChangeSubjectName_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.ChangeSubjectName_Button.HoverState.FillColor = System.Drawing.Color.White;
            this.ChangeSubjectName_Button.HoverState.Parent = this.ChangeSubjectName_Button;
            this.ChangeSubjectName_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ChangeSubjectName_Button.Location = new System.Drawing.Point(251, 12);
            this.ChangeSubjectName_Button.Name = "ChangeSubjectName_Button";
            this.ChangeSubjectName_Button.PressedDepth = 20;
            this.ChangeSubjectName_Button.ShadowDecoration.Parent = this.ChangeSubjectName_Button;
            this.ChangeSubjectName_Button.Size = new System.Drawing.Size(234, 36);
            this.ChangeSubjectName_Button.TabIndex = 128;
            this.ChangeSubjectName_Button.Text = "THAY ĐỔI TÊN MÔN HỌC";
            this.ChangeSubjectName_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.ChangeSubjectName_Button.Click += new System.EventHandler(this.ChangeSubjectName_Button_Click);
            // 
            // AddSubject_Button
            // 
            this.AddSubject_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddSubject_Button.Animated = true;
            this.AddSubject_Button.BackColor = System.Drawing.Color.White;
            this.AddSubject_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.AddSubject_Button.BorderRadius = 5;
            this.AddSubject_Button.BorderThickness = 2;
            this.AddSubject_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.AddSubject_Button.CheckedState.Parent = this.AddSubject_Button;
            this.AddSubject_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddSubject_Button.CustomImages.Parent = this.AddSubject_Button;
            this.AddSubject_Button.FillColor = System.Drawing.Color.White;
            this.AddSubject_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.AddSubject_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.AddSubject_Button.HoverState.FillColor = System.Drawing.Color.White;
            this.AddSubject_Button.HoverState.Parent = this.AddSubject_Button;
            this.AddSubject_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AddSubject_Button.Location = new System.Drawing.Point(11, 12);
            this.AddSubject_Button.Name = "AddSubject_Button";
            this.AddSubject_Button.PressedDepth = 20;
            this.AddSubject_Button.ShadowDecoration.Parent = this.AddSubject_Button;
            this.AddSubject_Button.Size = new System.Drawing.Size(234, 36);
            this.AddSubject_Button.TabIndex = 131;
            this.AddSubject_Button.Text = "BỔ SUNG THÊM MÔN HỌC";
            this.AddSubject_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.AddSubject_Button.Click += new System.EventHandler(this.AddSubject_Button_Click);
            // 
            // ChangeSubjectHead_Button
            // 
            this.ChangeSubjectHead_Button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ChangeSubjectHead_Button.Animated = true;
            this.ChangeSubjectHead_Button.BackColor = System.Drawing.Color.White;
            this.ChangeSubjectHead_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.ChangeSubjectHead_Button.BorderRadius = 5;
            this.ChangeSubjectHead_Button.BorderThickness = 2;
            this.ChangeSubjectHead_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ChangeSubjectHead_Button.CheckedState.Parent = this.ChangeSubjectHead_Button;
            this.ChangeSubjectHead_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeSubjectHead_Button.CustomImages.Parent = this.ChangeSubjectHead_Button;
            this.ChangeSubjectHead_Button.FillColor = System.Drawing.Color.White;
            this.ChangeSubjectHead_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ChangeSubjectHead_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.ChangeSubjectHead_Button.HoverState.FillColor = System.Drawing.Color.White;
            this.ChangeSubjectHead_Button.HoverState.Parent = this.ChangeSubjectHead_Button;
            this.ChangeSubjectHead_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ChangeSubjectHead_Button.Location = new System.Drawing.Point(491, 12);
            this.ChangeSubjectHead_Button.Name = "ChangeSubjectHead_Button";
            this.ChangeSubjectHead_Button.PressedDepth = 20;
            this.ChangeSubjectHead_Button.ShadowDecoration.Parent = this.ChangeSubjectHead_Button;
            this.ChangeSubjectHead_Button.Size = new System.Drawing.Size(234, 36);
            this.ChangeSubjectHead_Button.TabIndex = 132;
            this.ChangeSubjectHead_Button.Text = "THAY ĐỔI TRƯỞNG BỘ MÔN";
            this.ChangeSubjectHead_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this;
            // 
            // SubjectManage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(977, 546);
            this.Controls.Add(this.ChangeSubjectHead_Button);
            this.Controls.Add(this.AddSubject_Button);
            this.Controls.Add(this.FirePerson_Button);
            this.Controls.Add(this.ChangeSubjectName_Button);
            this.Controls.Add(this.DataTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubjectManage_Form";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubjectManage_Form";
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView DataTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherRole;
        private Guna.UI2.WinForms.Guna2Button FirePerson_Button;
        protected Guna.UI2.WinForms.Guna2Button ChangeSubjectName_Button;
        protected Guna.UI2.WinForms.Guna2Button AddSubject_Button;
        protected Guna.UI2.WinForms.Guna2Button ChangeSubjectHead_Button;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm ShadowForm;
    }
}