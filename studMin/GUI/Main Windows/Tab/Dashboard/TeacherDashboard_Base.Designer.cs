namespace studMin
{
    partial class TeacherDashboard_Base
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TeacherDashboard_Base));
            this.GradeModify_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.StudentInfor_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.DataTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Class_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Filter_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SchoolYear_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Semester_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DataGridViewExport_Button = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.AccountInfor_Button = new Guna.UI2.WinForms.Guna2GradientButton();
            this.SearchFilter_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            this.Search_Button = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // GradeModify_Button
            // 
            this.GradeModify_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GradeModify_Button.Animated = true;
            this.GradeModify_Button.BorderRadius = 22;
            this.GradeModify_Button.CheckedState.Parent = this.GradeModify_Button;
            this.GradeModify_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GradeModify_Button.CustomImages.Parent = this.GradeModify_Button;
            this.GradeModify_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.GradeModify_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GradeModify_Button.ForeColor = System.Drawing.Color.White;
            this.GradeModify_Button.HoverState.Parent = this.GradeModify_Button;
            this.GradeModify_Button.Location = new System.Drawing.Point(15, 12);
            this.GradeModify_Button.Name = "GradeModify_Button";
            this.GradeModify_Button.ShadowDecoration.Parent = this.GradeModify_Button;
            this.GradeModify_Button.Size = new System.Drawing.Size(280, 80);
            this.GradeModify_Button.TabIndex = 0;
            this.GradeModify_Button.Text = "HIỆU CHỈNH ĐIỂM SỐ";
            this.GradeModify_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // StudentInfor_Button
            // 
            this.StudentInfor_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.StudentInfor_Button.Animated = true;
            this.StudentInfor_Button.BorderRadius = 22;
            this.StudentInfor_Button.CheckedState.Parent = this.StudentInfor_Button;
            this.StudentInfor_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StudentInfor_Button.CustomImages.Parent = this.StudentInfor_Button;
            this.StudentInfor_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.StudentInfor_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.StudentInfor_Button.ForeColor = System.Drawing.Color.White;
            this.StudentInfor_Button.HoverState.Parent = this.StudentInfor_Button;
            this.StudentInfor_Button.Location = new System.Drawing.Point(322, 12);
            this.StudentInfor_Button.Name = "StudentInfor_Button";
            this.StudentInfor_Button.ShadowDecoration.Parent = this.StudentInfor_Button;
            this.StudentInfor_Button.Size = new System.Drawing.Size(280, 80);
            this.StudentInfor_Button.TabIndex = 1;
            this.StudentInfor_Button.Text = "THÔNG TIN HỌC SINH";
            this.StudentInfor_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // DataTable
            // 
            this.DataTable.AllowDrop = true;
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.DataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
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
            this.DataTable.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataTable.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataTable.EnableHeadersVisualStyles = false;
            this.DataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.DataTable.Location = new System.Drawing.Point(12, 211);
            this.DataTable.Name = "DataTable";
            this.DataTable.ReadOnly = true;
            this.DataTable.RowHeadersVisible = false;
            this.DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataTable.Size = new System.Drawing.Size(900, 521);
            this.DataTable.TabIndex = 4;
            this.DataTable.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.DataTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataTable.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
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
            "Tất cả lớp học"});
            this.Class_ComboBox.ItemsAppearance.Parent = this.Class_ComboBox;
            this.Class_ComboBox.Location = new System.Drawing.Point(12, 164);
            this.Class_ComboBox.Name = "Class_ComboBox";
            this.Class_ComboBox.ShadowDecoration.Parent = this.Class_ComboBox;
            this.Class_ComboBox.Size = new System.Drawing.Size(136, 36);
            this.Class_ComboBox.StartIndex = 0;
            this.Class_ComboBox.TabIndex = 7;
            this.Class_ComboBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // Filter_ComboBox
            // 
            this.Filter_ComboBox.Animated = true;
            this.Filter_ComboBox.BackColor = System.Drawing.Color.Transparent;
            this.Filter_ComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Filter_ComboBox.BorderRadius = 5;
            this.Filter_ComboBox.BorderThickness = 2;
            this.Filter_ComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Filter_ComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Filter_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Filter_ComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Filter_ComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Filter_ComboBox.FocusedState.Parent = this.Filter_ComboBox;
            this.Filter_ComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Filter_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Filter_ComboBox.FormattingEnabled = true;
            this.Filter_ComboBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Filter_ComboBox.HoverState.Parent = this.Filter_ComboBox;
            this.Filter_ComboBox.ItemHeight = 30;
            this.Filter_ComboBox.Items.AddRange(new object[] {
            "Danh sách lớp học",
            "Danh sách học sinh",
            "Bảng điểm tổng kết",
            "Thời khóa biểu",
            "Các giáo viên phụ trách"});
            this.Filter_ComboBox.ItemsAppearance.Parent = this.Filter_ComboBox;
            this.Filter_ComboBox.Location = new System.Drawing.Point(447, 164);
            this.Filter_ComboBox.Name = "Filter_ComboBox";
            this.Filter_ComboBox.ShadowDecoration.Parent = this.Filter_ComboBox;
            this.Filter_ComboBox.Size = new System.Drawing.Size(193, 36);
            this.Filter_ComboBox.StartIndex = 0;
            this.Filter_ComboBox.TabIndex = 8;
            this.Filter_ComboBox.TextOffset = new System.Drawing.Point(5, 0);
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
            "Niên khóa"});
            this.SchoolYear_ComboBox.ItemsAppearance.Parent = this.SchoolYear_ComboBox;
            this.SchoolYear_ComboBox.Location = new System.Drawing.Point(157, 164);
            this.SchoolYear_ComboBox.Name = "SchoolYear_ComboBox";
            this.SchoolYear_ComboBox.ShadowDecoration.Parent = this.SchoolYear_ComboBox;
            this.SchoolYear_ComboBox.Size = new System.Drawing.Size(136, 36);
            this.SchoolYear_ComboBox.StartIndex = 0;
            this.SchoolYear_ComboBox.TabIndex = 9;
            this.SchoolYear_ComboBox.TextOffset = new System.Drawing.Point(5, 0);
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
            "Học kỳ",
            "Học kỳ I",
            "Học kỳ II"});
            this.Semester_ComboBox.ItemsAppearance.Parent = this.Semester_ComboBox;
            this.Semester_ComboBox.Location = new System.Drawing.Point(302, 164);
            this.Semester_ComboBox.Name = "Semester_ComboBox";
            this.Semester_ComboBox.ShadowDecoration.Parent = this.Semester_ComboBox;
            this.Semester_ComboBox.Size = new System.Drawing.Size(136, 36);
            this.Semester_ComboBox.StartIndex = 0;
            this.Semester_ComboBox.TabIndex = 10;
            this.Semester_ComboBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // DataGridViewExport_Button
            // 
            this.DataGridViewExport_Button.Animated = true;
            this.DataGridViewExport_Button.BackColor = System.Drawing.Color.Transparent;
            this.DataGridViewExport_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.DataGridViewExport_Button.BorderRadius = 5;
            this.DataGridViewExport_Button.BorderThickness = 2;
            this.DataGridViewExport_Button.CheckedState.Parent = this.DataGridViewExport_Button;
            this.DataGridViewExport_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataGridViewExport_Button.CustomImages.Parent = this.DataGridViewExport_Button;
            this.DataGridViewExport_Button.FillColor = System.Drawing.Color.White;
            this.DataGridViewExport_Button.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DataGridViewExport_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.DataGridViewExport_Button.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.DataGridViewExport_Button.HoverState.FillColor = System.Drawing.Color.White;
            this.DataGridViewExport_Button.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.DataGridViewExport_Button.HoverState.Parent = this.DataGridViewExport_Button;
            this.DataGridViewExport_Button.Location = new System.Drawing.Point(719, 164);
            this.DataGridViewExport_Button.Name = "DataGridViewExport_Button";
            this.DataGridViewExport_Button.ShadowDecoration.Parent = this.DataGridViewExport_Button;
            this.DataGridViewExport_Button.Size = new System.Drawing.Size(193, 36);
            this.DataGridViewExport_Button.TabIndex = 11;
            this.DataGridViewExport_Button.Text = "XUẤT DANH SÁCH";
            this.DataGridViewExport_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoEllipsis = true;
            this.gunaLabel1.BackColor = System.Drawing.Color.White;
            this.gunaLabel1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.gunaLabel1.Location = new System.Drawing.Point(0, 105);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(924, 45);
            this.gunaLabel1.TabIndex = 14;
            this.gunaLabel1.Text = "TRA CỨU NÂNG CAO";
            this.gunaLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel1.UseCompatibleTextRendering = true;
            // 
            // AccountInfor_Button
            // 
            this.AccountInfor_Button.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AccountInfor_Button.Animated = true;
            this.AccountInfor_Button.BorderRadius = 22;
            this.AccountInfor_Button.CheckedState.Parent = this.AccountInfor_Button;
            this.AccountInfor_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccountInfor_Button.CustomImages.Parent = this.AccountInfor_Button;
            this.AccountInfor_Button.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.AccountInfor_Button.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.AccountInfor_Button.ForeColor = System.Drawing.Color.White;
            this.AccountInfor_Button.HoverState.Parent = this.AccountInfor_Button;
            this.AccountInfor_Button.Location = new System.Drawing.Point(629, 12);
            this.AccountInfor_Button.Name = "AccountInfor_Button";
            this.AccountInfor_Button.ShadowDecoration.Parent = this.AccountInfor_Button;
            this.AccountInfor_Button.Size = new System.Drawing.Size(280, 80);
            this.AccountInfor_Button.TabIndex = 15;
            this.AccountInfor_Button.Text = "THÔNG TIN TÀI KHOẢN";
            this.AccountInfor_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // SearchFilter_Button
            // 
            this.SearchFilter_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SearchFilter_Button.BackColor = System.Drawing.Color.White;
            this.SearchFilter_Button.CheckedState.Parent = this.SearchFilter_Button;
            this.SearchFilter_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchFilter_Button.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.SearchFilter_Button.HoverState.Parent = this.SearchFilter_Button;
            this.SearchFilter_Button.Image = global::studMin.Properties.Resources.Filter;
            this.SearchFilter_Button.ImageSize = new System.Drawing.Size(25, 25);
            this.SearchFilter_Button.Location = new System.Drawing.Point(644, 164);
            this.SearchFilter_Button.Name = "SearchFilter_Button";
            this.SearchFilter_Button.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.SearchFilter_Button.PressedState.Parent = this.SearchFilter_Button;
            this.SearchFilter_Button.Size = new System.Drawing.Size(36, 36);
            this.SearchFilter_Button.TabIndex = 6;
            // 
            // Search_Button
            // 
            this.Search_Button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_Button.BackColor = System.Drawing.Color.White;
            this.Search_Button.CheckedState.Parent = this.Search_Button;
            this.Search_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_Button.HoverState.ImageSize = new System.Drawing.Size(25, 25);
            this.Search_Button.HoverState.Parent = this.Search_Button;
            this.Search_Button.Image = ((System.Drawing.Image)(resources.GetObject("Search_Button.Image")));
            this.Search_Button.ImageSize = new System.Drawing.Size(25, 25);
            this.Search_Button.Location = new System.Drawing.Point(679, 164);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.Search_Button.PressedState.Parent = this.Search_Button;
            this.Search_Button.Size = new System.Drawing.Size(36, 36);
            this.Search_Button.TabIndex = 5;
            // 
            // TeacherDashboard_Base
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.AccountInfor_Button);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.DataGridViewExport_Button);
            this.Controls.Add(this.Semester_ComboBox);
            this.Controls.Add(this.SchoolYear_ComboBox);
            this.Controls.Add(this.Filter_ComboBox);
            this.Controls.Add(this.Class_ComboBox);
            this.Controls.Add(this.SearchFilter_Button);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.StudentInfor_Button);
            this.Controls.Add(this.GradeModify_Button);
            this.DoubleBuffered = true;
            this.Name = "TeacherDashboard_Base";
            this.Size = new System.Drawing.Size(924, 740);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton GradeModify_Button;
        private Guna.UI2.WinForms.Guna2GradientButton StudentInfor_Button;
        private Guna.UI2.WinForms.Guna2DataGridView DataTable;
        private Guna.UI2.WinForms.Guna2ImageButton Search_Button;
        private Guna.UI2.WinForms.Guna2ImageButton SearchFilter_Button;
        private Guna.UI2.WinForms.Guna2ComboBox Class_ComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox Filter_ComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox SchoolYear_ComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox Semester_ComboBox;
        private Guna.UI2.WinForms.Guna2Button DataGridViewExport_Button;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton AccountInfor_Button;
    }
}
