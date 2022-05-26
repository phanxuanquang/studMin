namespace studMin
{
    partial class TimeTableTab_Staff
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Timetable_GridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ApplyDate_Label = new System.Windows.Forms.Label();
            this.DateApply_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Semester_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SchoolYear_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TimetableImport_Button = new Guna.UI2.WinForms.Guna2Button();
            this.TimetableExport_Button = new Guna.UI2.WinForms.Guna2Button();
            this.Class_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.Timetable_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Timetable_GridView
            // 
            this.Timetable_GridView.AllowDrop = true;
            this.Timetable_GridView.AllowUserToAddRows = false;
            this.Timetable_GridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.Timetable_GridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.Timetable_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Timetable_GridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Timetable_GridView.BackgroundColor = System.Drawing.Color.White;
            this.Timetable_GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Timetable_GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Timetable_GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Timetable_GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.Timetable_GridView.ColumnHeadersHeight = 25;
            this.Timetable_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Timetable_GridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Timetable_GridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.Timetable_GridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Timetable_GridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Timetable_GridView.EnableHeadersVisualStyles = false;
            this.Timetable_GridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.Timetable_GridView.Location = new System.Drawing.Point(0, 157);
            this.Timetable_GridView.Name = "Timetable_GridView";
            this.Timetable_GridView.ReadOnly = true;
            this.Timetable_GridView.RowHeadersVisible = false;
            this.Timetable_GridView.RowHeadersWidth = 82;
            this.Timetable_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.Timetable_GridView.Size = new System.Drawing.Size(924, 583);
            this.Timetable_GridView.TabIndex = 81;
            this.Timetable_GridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.Timetable_GridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Timetable_GridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Timetable_GridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Timetable_GridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Timetable_GridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Timetable_GridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.Timetable_GridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.Timetable_GridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.Timetable_GridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Timetable_GridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Timetable_GridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Timetable_GridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Timetable_GridView.ThemeStyle.HeaderStyle.Height = 25;
            this.Timetable_GridView.ThemeStyle.ReadOnly = true;
            this.Timetable_GridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.Timetable_GridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Timetable_GridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Timetable_GridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.Timetable_GridView.ThemeStyle.RowsStyle.Height = 22;
            this.Timetable_GridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.Timetable_GridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            // 
            // ApplyDate_Label
            // 
            this.ApplyDate_Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.ApplyDate_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.ApplyDate_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ApplyDate_Label.ForeColor = System.Drawing.Color.White;
            this.ApplyDate_Label.Location = new System.Drawing.Point(0, 0);
            this.ApplyDate_Label.Name = "ApplyDate_Label";
            this.ApplyDate_Label.Size = new System.Drawing.Size(924, 71);
            this.ApplyDate_Label.TabIndex = 113;
            this.ApplyDate_Label.Text = "BẮT ĐẦU ÁP DỤNG TỪ THỨ HAI, NGÀY 10 THÁNG 10 NĂM 2022";
            this.ApplyDate_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ApplyDate_Label.UseCompatibleTextRendering = true;
            // 
            // DateApply_ComboBox
            // 
            this.DateApply_ComboBox.Animated = true;
            this.DateApply_ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.DateApply_ComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.DateApply_ComboBox.BorderRadius = 5;
            this.DateApply_ComboBox.BorderThickness = 2;
            this.DateApply_ComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DateApply_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DateApply_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DateApply_ComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.DateApply_ComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.DateApply_ComboBox.FocusedState.Parent = this.DateApply_ComboBox;
            this.DateApply_ComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DateApply_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.DateApply_ComboBox.FormattingEnabled = true;
            this.DateApply_ComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.DateApply_ComboBox.HoverState.Parent = this.DateApply_ComboBox;
            this.DateApply_ComboBox.ItemHeight = 30;
            this.DateApply_ComboBox.Items.AddRange(new object[] {
            "Mới nhất"});
            this.DateApply_ComboBox.ItemsAppearance.Parent = this.DateApply_ComboBox;
            this.DateApply_ComboBox.Location = new System.Drawing.Point(398, 95);
            this.DateApply_ComboBox.Name = "DateApply_ComboBox";
            this.DateApply_ComboBox.ShadowDecoration.Parent = this.DateApply_ComboBox;
            this.DateApply_ComboBox.Size = new System.Drawing.Size(140, 36);
            this.DateApply_ComboBox.StartIndex = 0;
            this.DateApply_ComboBox.TabIndex = 127;
            this.DateApply_ComboBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // Semester_ComboBox
            // 
            this.Semester_ComboBox.Animated = true;
            this.Semester_ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.Semester_ComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Semester_ComboBox.BorderRadius = 5;
            this.Semester_ComboBox.BorderThickness = 2;
            this.Semester_ComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Semester_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Semester_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Semester_ComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Semester_ComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Semester_ComboBox.FocusedState.Parent = this.Semester_ComboBox;
            this.Semester_ComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Semester_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Semester_ComboBox.FormattingEnabled = true;
            this.Semester_ComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Semester_ComboBox.HoverState.Parent = this.Semester_ComboBox;
            this.Semester_ComboBox.ItemHeight = 30;
            this.Semester_ComboBox.Items.AddRange(new object[] {
            "Mọi học kỳ"});
            this.Semester_ComboBox.ItemsAppearance.Parent = this.Semester_ComboBox;
            this.Semester_ComboBox.Location = new System.Drawing.Point(280, 95);
            this.Semester_ComboBox.Name = "Semester_ComboBox";
            this.Semester_ComboBox.ShadowDecoration.Parent = this.Semester_ComboBox;
            this.Semester_ComboBox.Size = new System.Drawing.Size(114, 36);
            this.Semester_ComboBox.StartIndex = 0;
            this.Semester_ComboBox.TabIndex = 126;
            this.Semester_ComboBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // SchoolYear_ComboBox
            // 
            this.SchoolYear_ComboBox.Animated = true;
            this.SchoolYear_ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.SchoolYear_ComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.SchoolYear_ComboBox.BorderRadius = 5;
            this.SchoolYear_ComboBox.BorderThickness = 2;
            this.SchoolYear_ComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SchoolYear_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SchoolYear_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SchoolYear_ComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.SchoolYear_ComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.SchoolYear_ComboBox.FocusedState.Parent = this.SchoolYear_ComboBox;
            this.SchoolYear_ComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SchoolYear_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SchoolYear_ComboBox.FormattingEnabled = true;
            this.SchoolYear_ComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.SchoolYear_ComboBox.HoverState.Parent = this.SchoolYear_ComboBox;
            this.SchoolYear_ComboBox.ItemHeight = 30;
            this.SchoolYear_ComboBox.Items.AddRange(new object[] {
            "Mọi niên khóa"});
            this.SchoolYear_ComboBox.ItemsAppearance.Parent = this.SchoolYear_ComboBox;
            this.SchoolYear_ComboBox.Location = new System.Drawing.Point(140, 95);
            this.SchoolYear_ComboBox.Name = "SchoolYear_ComboBox";
            this.SchoolYear_ComboBox.ShadowDecoration.Parent = this.SchoolYear_ComboBox;
            this.SchoolYear_ComboBox.Size = new System.Drawing.Size(136, 36);
            this.SchoolYear_ComboBox.StartIndex = 0;
            this.SchoolYear_ComboBox.TabIndex = 125;
            this.SchoolYear_ComboBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // TimetableImport_Button
            // 
            this.TimetableImport_Button.Animated = true;
            this.TimetableImport_Button.BackColor = System.Drawing.Color.Transparent;
            this.TimetableImport_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.TimetableImport_Button.BorderRadius = 5;
            this.TimetableImport_Button.CheckedState.Parent = this.TimetableImport_Button;
            this.TimetableImport_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimetableImport_Button.CustomImages.Parent = this.TimetableImport_Button;
            this.TimetableImport_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.TimetableImport_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TimetableImport_Button.ForeColor = System.Drawing.Color.White;
            this.TimetableImport_Button.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.TimetableImport_Button.HoverState.Parent = this.TimetableImport_Button;
            this.TimetableImport_Button.Location = new System.Drawing.Point(542, 95);
            this.TimetableImport_Button.Name = "TimetableImport_Button";
            this.TimetableImport_Button.ShadowDecoration.Parent = this.TimetableImport_Button;
            this.TimetableImport_Button.Size = new System.Drawing.Size(181, 36);
            this.TimetableImport_Button.TabIndex = 124;
            this.TimetableImport_Button.Text = "NHẬP THỜI KHÓA BIỂU";
            this.TimetableImport_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // TimetableExport_Button
            // 
            this.TimetableExport_Button.Animated = true;
            this.TimetableExport_Button.BackColor = System.Drawing.Color.Transparent;
            this.TimetableExport_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.TimetableExport_Button.BorderRadius = 5;
            this.TimetableExport_Button.CheckedState.Parent = this.TimetableExport_Button;
            this.TimetableExport_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TimetableExport_Button.CustomImages.Parent = this.TimetableExport_Button;
            this.TimetableExport_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.TimetableExport_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TimetableExport_Button.ForeColor = System.Drawing.Color.White;
            this.TimetableExport_Button.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.TimetableExport_Button.HoverState.Parent = this.TimetableExport_Button;
            this.TimetableExport_Button.Location = new System.Drawing.Point(729, 95);
            this.TimetableExport_Button.Name = "TimetableExport_Button";
            this.TimetableExport_Button.ShadowDecoration.Parent = this.TimetableExport_Button;
            this.TimetableExport_Button.Size = new System.Drawing.Size(181, 36);
            this.TimetableExport_Button.TabIndex = 123;
            this.TimetableExport_Button.Text = "XUẤT THỜI KHÓA BIỂU";
            this.TimetableExport_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // Class_ComboBox
            // 
            this.Class_ComboBox.Animated = true;
            this.Class_ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.Class_ComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Class_ComboBox.BorderRadius = 5;
            this.Class_ComboBox.BorderThickness = 2;
            this.Class_ComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Class_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Class_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Class_ComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Class_ComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Class_ComboBox.FocusedState.Parent = this.Class_ComboBox;
            this.Class_ComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Class_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Class_ComboBox.FormattingEnabled = true;
            this.Class_ComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Class_ComboBox.HoverState.Parent = this.Class_ComboBox;
            this.Class_ComboBox.ItemHeight = 30;
            this.Class_ComboBox.Items.AddRange(new object[] {
            "Chọn lớp"});
            this.Class_ComboBox.ItemsAppearance.Parent = this.Class_ComboBox;
            this.Class_ComboBox.Location = new System.Drawing.Point(14, 95);
            this.Class_ComboBox.Name = "Class_ComboBox";
            this.Class_ComboBox.ShadowDecoration.Parent = this.Class_ComboBox;
            this.Class_ComboBox.Size = new System.Drawing.Size(120, 36);
            this.Class_ComboBox.StartIndex = 0;
            this.Class_ComboBox.TabIndex = 122;
            this.Class_ComboBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // Timetable_Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DateApply_ComboBox);
            this.Controls.Add(this.Semester_ComboBox);
            this.Controls.Add(this.SchoolYear_ComboBox);
            this.Controls.Add(this.TimetableImport_Button);
            this.Controls.Add(this.TimetableExport_Button);
            this.Controls.Add(this.Class_ComboBox);
            this.Controls.Add(this.ApplyDate_Label);
            this.Controls.Add(this.Timetable_GridView);
            this.Name = "Timetable_Tab";
            this.Size = new System.Drawing.Size(924, 740);
            ((System.ComponentModel.ISupportInitialize)(this.Timetable_GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView Timetable_GridView;
        private System.Windows.Forms.Label ApplyDate_Label;
        private Guna.UI2.WinForms.Guna2ComboBox DateApply_ComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox Semester_ComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox SchoolYear_ComboBox;
        private Guna.UI2.WinForms.Guna2Button TimetableImport_Button;
        private Guna.UI2.WinForms.Guna2Button TimetableExport_Button;
        private Guna.UI2.WinForms.Guna2ComboBox Class_ComboBox;
    }
}
