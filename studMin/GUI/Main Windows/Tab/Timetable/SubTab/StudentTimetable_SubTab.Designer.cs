namespace studMin
{
    partial class StudentTimetable_SubTab
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Timetable_GridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Class_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TimetableExport_Button = new Guna.UI2.WinForms.Guna2Button();
            this.ApplyDate_Label = new System.Windows.Forms.Label();
            this.Semester_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SchoolYear_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DateApply_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Timetable_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Timetable_GridView
            // 
            this.Timetable_GridView.AllowDrop = true;
            this.Timetable_GridView.AllowUserToAddRows = false;
            this.Timetable_GridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Timetable_GridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Timetable_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Timetable_GridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Timetable_GridView.BackgroundColor = System.Drawing.Color.White;
            this.Timetable_GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Timetable_GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.Timetable_GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Timetable_GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Timetable_GridView.ColumnHeadersHeight = 25;
            this.Timetable_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Timetable_GridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Timetable_GridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.Timetable_GridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.Timetable_GridView.EnableHeadersVisualStyles = false;
            this.Timetable_GridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.Timetable_GridView.Location = new System.Drawing.Point(0, 165);
            this.Timetable_GridView.Margin = new System.Windows.Forms.Padding(6);
            this.Timetable_GridView.Name = "Timetable_GridView";
            this.Timetable_GridView.ReadOnly = true;
            this.Timetable_GridView.RowHeadersVisible = false;
            this.Timetable_GridView.RowHeadersWidth = 82;
            this.Timetable_GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Timetable_GridView.Size = new System.Drawing.Size(1848, 979);
            this.Timetable_GridView.TabIndex = 79;
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
            this.Timetable_GridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Timetable_GridView_CellFormatting);
            this.Timetable_GridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.Timetable_GridView_CellPainting);
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
            this.Class_ComboBox.Location = new System.Drawing.Point(104, 1156);
            this.Class_ComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.Class_ComboBox.Name = "Class_ComboBox";
            this.Class_ComboBox.ShadowDecoration.Parent = this.Class_ComboBox;
            this.Class_ComboBox.Size = new System.Drawing.Size(308, 36);
            this.Class_ComboBox.StartIndex = 0;
            this.Class_ComboBox.TabIndex = 106;
            this.Class_ComboBox.TextOffset = new System.Drawing.Point(5, 0);
            this.toolTip.SetToolTip(this.Class_ComboBox, "Lớp học áp dụng");
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
            this.TimetableExport_Button.Location = new System.Drawing.Point(1384, 1156);
            this.TimetableExport_Button.Margin = new System.Windows.Forms.Padding(6);
            this.TimetableExport_Button.Name = "TimetableExport_Button";
            this.TimetableExport_Button.ShadowDecoration.Parent = this.TimetableExport_Button;
            this.TimetableExport_Button.Size = new System.Drawing.Size(362, 69);
            this.TimetableExport_Button.TabIndex = 107;
            this.TimetableExport_Button.Text = "XUẤT THỜI KHÓA BIỂU";
            this.TimetableExport_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.TimetableExport_Button.Click += new System.EventHandler(this.TimetableExport_Button_Click);
            // 
            // ApplyDate_Label
            // 
            this.ApplyDate_Label.BackColor = System.Drawing.Color.Transparent;
            this.ApplyDate_Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.ApplyDate_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ApplyDate_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.ApplyDate_Label.Location = new System.Drawing.Point(0, 0);
            this.ApplyDate_Label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ApplyDate_Label.Name = "ApplyDate_Label";
            this.ApplyDate_Label.Size = new System.Drawing.Size(1848, 137);
            this.ApplyDate_Label.TabIndex = 112;
            this.ApplyDate_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ApplyDate_Label.UseCompatibleTextRendering = true;
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
            this.Semester_ComboBox.Location = new System.Drawing.Point(744, 1156);
            this.Semester_ComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.Semester_ComboBox.Name = "Semester_ComboBox";
            this.Semester_ComboBox.ShadowDecoration.Parent = this.Semester_ComboBox;
            this.Semester_ComboBox.Size = new System.Drawing.Size(308, 36);
            this.Semester_ComboBox.StartIndex = 0;
            this.Semester_ComboBox.TabIndex = 115;
            this.Semester_ComboBox.TextOffset = new System.Drawing.Point(5, 0);
            this.toolTip.SetToolTip(this.Semester_ComboBox, "Học kỳ áp dụng");
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
            this.SchoolYear_ComboBox.Location = new System.Drawing.Point(424, 1156);
            this.SchoolYear_ComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.SchoolYear_ComboBox.Name = "SchoolYear_ComboBox";
            this.SchoolYear_ComboBox.ShadowDecoration.Parent = this.SchoolYear_ComboBox;
            this.SchoolYear_ComboBox.Size = new System.Drawing.Size(308, 36);
            this.SchoolYear_ComboBox.StartIndex = 0;
            this.SchoolYear_ComboBox.TabIndex = 114;
            this.SchoolYear_ComboBox.TextOffset = new System.Drawing.Point(5, 0);
            this.toolTip.SetToolTip(this.SchoolYear_ComboBox, "Năm học áp dụng");
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
            this.DateApply_ComboBox.Location = new System.Drawing.Point(1064, 1156);
            this.DateApply_ComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.DateApply_ComboBox.Name = "DateApply_ComboBox";
            this.DateApply_ComboBox.ShadowDecoration.Parent = this.DateApply_ComboBox;
            this.DateApply_ComboBox.Size = new System.Drawing.Size(308, 36);
            this.DateApply_ComboBox.StartIndex = 0;
            this.DateApply_ComboBox.TabIndex = 121;
            this.DateApply_ComboBox.TextOffset = new System.Drawing.Point(5, 0);
            this.toolTip.SetToolTip(this.DateApply_ComboBox, "Ngày bắt đầu áp dụng");
            // 
            // StudentTimetable_SubTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DateApply_ComboBox);
            this.Controls.Add(this.Semester_ComboBox);
            this.Controls.Add(this.SchoolYear_ComboBox);
            this.Controls.Add(this.ApplyDate_Label);
            this.Controls.Add(this.TimetableExport_Button);
            this.Controls.Add(this.Class_ComboBox);
            this.Controls.Add(this.Timetable_GridView);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "StudentTimetable_SubTab";
            this.Size = new System.Drawing.Size(1848, 1323);
            this.Load += new System.EventHandler(this.StudentTimetable_SubTab_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Timetable_GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView Timetable_GridView;
        private Guna.UI2.WinForms.Guna2ComboBox Class_ComboBox;
        private Guna.UI2.WinForms.Guna2Button TimetableExport_Button;
        private System.Windows.Forms.Label ApplyDate_Label;
        private Guna.UI2.WinForms.Guna2ComboBox Semester_ComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox SchoolYear_ComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox DateApply_ComboBox;
        private System.Windows.Forms.ToolTip toolTip;
    }
}
