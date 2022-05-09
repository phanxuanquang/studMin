namespace studMin
{
    partial class SubjectModify_SubTab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OralTest_GroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.PassGrade_SaveButton = new Guna.UI2.WinForms.Guna2Button();
            this.PassGrade_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.MaxGrade_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.GridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TeahcherID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeahcherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeahcherBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeahcherEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeahcherStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.Notify_Label = new System.Windows.Forms.Label();
            this.NotifyContent_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.SendNotify_Button = new Guna.UI2.WinForms.Guna2Button();
            this.OralTest_GroupBox.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // OralTest_GroupBox
            // 
            this.OralTest_GroupBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.OralTest_GroupBox.BorderRadius = 5;
            this.OralTest_GroupBox.BorderThickness = 2;
            this.OralTest_GroupBox.Controls.Add(this.PassGrade_SaveButton);
            this.OralTest_GroupBox.Controls.Add(this.PassGrade_Box);
            this.OralTest_GroupBox.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.OralTest_GroupBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.OralTest_GroupBox.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.OralTest_GroupBox.ForeColor = System.Drawing.Color.White;
            this.OralTest_GroupBox.Location = new System.Drawing.Point(161, 15);
            this.OralTest_GroupBox.Name = "OralTest_GroupBox";
            this.OralTest_GroupBox.ShadowDecoration.Parent = this.OralTest_GroupBox;
            this.OralTest_GroupBox.Size = new System.Drawing.Size(285, 100);
            this.OralTest_GroupBox.TabIndex = 85;
            this.OralTest_GroupBox.Text = "Điểm đạt tối thiểu của môn học";
            this.OralTest_GroupBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PassGrade_SaveButton
            // 
            this.PassGrade_SaveButton.Animated = true;
            this.PassGrade_SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.PassGrade_SaveButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.PassGrade_SaveButton.BorderRadius = 5;
            this.PassGrade_SaveButton.BorderThickness = 2;
            this.PassGrade_SaveButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.PassGrade_SaveButton.CheckedState.Parent = this.PassGrade_SaveButton;
            this.PassGrade_SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PassGrade_SaveButton.CustomImages.Parent = this.PassGrade_SaveButton;
            this.PassGrade_SaveButton.FillColor = System.Drawing.Color.White;
            this.PassGrade_SaveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PassGrade_SaveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.PassGrade_SaveButton.HoverState.FillColor = System.Drawing.Color.White;
            this.PassGrade_SaveButton.HoverState.Parent = this.PassGrade_SaveButton;
            this.PassGrade_SaveButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.PassGrade_SaveButton.Location = new System.Drawing.Point(184, 51);
            this.PassGrade_SaveButton.Name = "PassGrade_SaveButton";
            this.PassGrade_SaveButton.PressedDepth = 20;
            this.PassGrade_SaveButton.ShadowDecoration.Parent = this.PassGrade_SaveButton;
            this.PassGrade_SaveButton.Size = new System.Drawing.Size(67, 36);
            this.PassGrade_SaveButton.TabIndex = 86;
            this.PassGrade_SaveButton.Text = "LƯU";
            this.PassGrade_SaveButton.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.PassGrade_SaveButton.Click += new System.EventHandler(this.PassGrade_SaveButton_Click);
            // 
            // PassGrade_Box
            // 
            this.PassGrade_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PassGrade_Box.Animated = true;
            this.PassGrade_Box.BackColor = System.Drawing.Color.Transparent;
            this.PassGrade_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.PassGrade_Box.BorderRadius = 5;
            this.PassGrade_Box.BorderThickness = 2;
            this.PassGrade_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassGrade_Box.DefaultText = "";
            this.PassGrade_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PassGrade_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PassGrade_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PassGrade_Box.DisabledState.Parent = this.PassGrade_Box;
            this.PassGrade_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PassGrade_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.PassGrade_Box.FocusedState.Parent = this.PassGrade_Box;
            this.PassGrade_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PassGrade_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.PassGrade_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.PassGrade_Box.HoverState.Parent = this.PassGrade_Box;
            this.PassGrade_Box.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.PassGrade_Box.Location = new System.Drawing.Point(34, 52);
            this.PassGrade_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PassGrade_Box.Name = "PassGrade_Box";
            this.PassGrade_Box.PasswordChar = '\0';
            this.PassGrade_Box.PlaceholderText = "";
            this.PassGrade_Box.SelectedText = "";
            this.PassGrade_Box.ShadowDecoration.BorderRadius = 12;
            this.PassGrade_Box.ShadowDecoration.Depth = 5;
            this.PassGrade_Box.ShadowDecoration.Parent = this.PassGrade_Box;
            this.PassGrade_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.PassGrade_Box.Size = new System.Drawing.Size(140, 36);
            this.PassGrade_Box.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.PassGrade_Box.TabIndex = 42;
            this.PassGrade_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.guna2GroupBox1.BorderRadius = 5;
            this.guna2GroupBox1.BorderThickness = 2;
            this.guna2GroupBox1.Controls.Add(this.MaxGrade_Box);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.guna2GroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.White;
            this.guna2GroupBox1.Location = new System.Drawing.Point(479, 15);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(285, 100);
            this.guna2GroupBox1.TabIndex = 87;
            this.guna2GroupBox1.Text = "Thang Điểm";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MaxGrade_Box
            // 
            this.MaxGrade_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MaxGrade_Box.Animated = true;
            this.MaxGrade_Box.BackColor = System.Drawing.Color.Transparent;
            this.MaxGrade_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.MaxGrade_Box.BorderRadius = 5;
            this.MaxGrade_Box.BorderThickness = 2;
            this.MaxGrade_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaxGrade_Box.DefaultText = "";
            this.MaxGrade_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MaxGrade_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MaxGrade_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MaxGrade_Box.DisabledState.Parent = this.MaxGrade_Box;
            this.MaxGrade_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MaxGrade_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.MaxGrade_Box.FocusedState.Parent = this.MaxGrade_Box;
            this.MaxGrade_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MaxGrade_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.MaxGrade_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.MaxGrade_Box.HoverState.Parent = this.MaxGrade_Box;
            this.MaxGrade_Box.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.MaxGrade_Box.Location = new System.Drawing.Point(89, 52);
            this.MaxGrade_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaxGrade_Box.Name = "MaxGrade_Box";
            this.MaxGrade_Box.PasswordChar = '\0';
            this.MaxGrade_Box.PlaceholderText = "";
            this.MaxGrade_Box.ReadOnly = true;
            this.MaxGrade_Box.SelectedText = "";
            this.MaxGrade_Box.ShadowDecoration.BorderRadius = 12;
            this.MaxGrade_Box.ShadowDecoration.Depth = 5;
            this.MaxGrade_Box.ShadowDecoration.Parent = this.MaxGrade_Box;
            this.MaxGrade_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.MaxGrade_Box.Size = new System.Drawing.Size(101, 36);
            this.MaxGrade_Box.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.MaxGrade_Box.TabIndex = 42;
            this.MaxGrade_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GridView
            // 
            this.GridView.AllowDrop = true;
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridView.BackgroundColor = System.Drawing.Color.White;
            this.GridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.GridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.GridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridView.ColumnHeadersHeight = 25;
            this.GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TeahcherID,
            this.TeahcherName,
            this.TeahcherBirthday,
            this.TeahcherEmail,
            this.TeahcherStartDate});
            this.GridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.GridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GridView.EnableHeadersVisualStyles = false;
            this.GridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.GridView.Location = new System.Drawing.Point(0, 329);
            this.GridView.Name = "GridView";
            this.GridView.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridView.RowHeadersVisible = false;
            this.GridView.RowHeadersWidth = 51;
            this.GridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.GridView.Size = new System.Drawing.Size(924, 359);
            this.GridView.TabIndex = 103;
            this.GridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.GridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.GridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.GridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.GridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.GridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.GridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.GridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.GridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.GridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.GridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GridView.ThemeStyle.HeaderStyle.Height = 25;
            this.GridView.ThemeStyle.ReadOnly = true;
            this.GridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.GridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.GridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.GridView.ThemeStyle.RowsStyle.Height = 22;
            this.GridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.GridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            // 
            // TeahcherID
            // 
            this.TeahcherID.HeaderText = "Mã giáo viên";
            this.TeahcherID.MinimumWidth = 6;
            this.TeahcherID.Name = "TeahcherID";
            this.TeahcherID.ReadOnly = true;
            // 
            // TeahcherName
            // 
            this.TeahcherName.HeaderText = "Họ và tên";
            this.TeahcherName.MinimumWidth = 6;
            this.TeahcherName.Name = "TeahcherName";
            this.TeahcherName.ReadOnly = true;
            // 
            // TeahcherBirthday
            // 
            this.TeahcherBirthday.HeaderText = "Ngày sinh";
            this.TeahcherBirthday.MinimumWidth = 6;
            this.TeahcherBirthday.Name = "TeahcherBirthday";
            this.TeahcherBirthday.ReadOnly = true;
            // 
            // TeahcherEmail
            // 
            this.TeahcherEmail.HeaderText = "E-mail";
            this.TeahcherEmail.MinimumWidth = 6;
            this.TeahcherEmail.Name = "TeahcherEmail";
            this.TeahcherEmail.ReadOnly = true;
            // 
            // TeahcherStartDate
            // 
            this.TeahcherStartDate.HeaderText = "Ngày vào trường";
            this.TeahcherStartDate.MinimumWidth = 6;
            this.TeahcherStartDate.Name = "TeahcherStartDate";
            this.TeahcherStartDate.ReadOnly = true;
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.BackColor = System.Drawing.Color.Transparent;
            this.SubjectLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SubjectLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.SubjectLabel.Location = new System.Drawing.Point(0, 284);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(924, 41);
            this.SubjectLabel.TabIndex = 113;
            this.SubjectLabel.Text = "DANH SÁCH GIÁO VIÊN PHỤ TRÁCH MÔN NGỮ VĂN";
            this.SubjectLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SubjectLabel.UseCompatibleTextRendering = true;
            // 
            // Notify_Label
            // 
            this.Notify_Label.BackColor = System.Drawing.Color.Transparent;
            this.Notify_Label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Notify_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Notify_Label.Location = new System.Drawing.Point(0, 119);
            this.Notify_Label.Name = "Notify_Label";
            this.Notify_Label.Size = new System.Drawing.Size(924, 41);
            this.Notify_Label.TabIndex = 114;
            this.Notify_Label.Text = "THÔNG BÁO ĐẾN GIÁO VIÊN BỘ MÔN NGỮ VĂN";
            this.Notify_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Notify_Label.UseCompatibleTextRendering = true;
            // 
            // NotifyContent_Box
            // 
            this.NotifyContent_Box.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NotifyContent_Box.Animated = true;
            this.NotifyContent_Box.BackColor = System.Drawing.Color.Transparent;
            this.NotifyContent_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.NotifyContent_Box.BorderRadius = 5;
            this.NotifyContent_Box.BorderThickness = 2;
            this.NotifyContent_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NotifyContent_Box.DefaultText = "";
            this.NotifyContent_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NotifyContent_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NotifyContent_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NotifyContent_Box.DisabledState.Parent = this.NotifyContent_Box;
            this.NotifyContent_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NotifyContent_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.NotifyContent_Box.FocusedState.Parent = this.NotifyContent_Box;
            this.NotifyContent_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.NotifyContent_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.NotifyContent_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.NotifyContent_Box.HoverState.Parent = this.NotifyContent_Box;
            this.NotifyContent_Box.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.NotifyContent_Box.Location = new System.Drawing.Point(9, 162);
            this.NotifyContent_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NotifyContent_Box.Multiline = true;
            this.NotifyContent_Box.Name = "NotifyContent_Box";
            this.NotifyContent_Box.PasswordChar = '\0';
            this.NotifyContent_Box.PlaceholderText = "";
            this.NotifyContent_Box.SelectedText = "";
            this.NotifyContent_Box.ShadowDecoration.BorderRadius = 12;
            this.NotifyContent_Box.ShadowDecoration.Depth = 5;
            this.NotifyContent_Box.ShadowDecoration.Parent = this.NotifyContent_Box;
            this.NotifyContent_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.NotifyContent_Box.Size = new System.Drawing.Size(906, 120);
            this.NotifyContent_Box.TabIndex = 87;
            // 
            // SendNotify_Button
            // 
            this.SendNotify_Button.Animated = true;
            this.SendNotify_Button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.SendNotify_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.SendNotify_Button.BorderRadius = 5;
            this.SendNotify_Button.BorderThickness = 2;
            this.SendNotify_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.SendNotify_Button.CheckedState.Parent = this.SendNotify_Button;
            this.SendNotify_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SendNotify_Button.CustomImages.Parent = this.SendNotify_Button;
            this.SendNotify_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.SendNotify_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.SendNotify_Button.ForeColor = System.Drawing.Color.White;
            this.SendNotify_Button.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.SendNotify_Button.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.SendNotify_Button.HoverState.Parent = this.SendNotify_Button;
            this.SendNotify_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SendNotify_Button.Location = new System.Drawing.Point(840, 238);
            this.SendNotify_Button.Name = "SendNotify_Button";
            this.SendNotify_Button.PressedDepth = 20;
            this.SendNotify_Button.ShadowDecoration.Parent = this.SendNotify_Button;
            this.SendNotify_Button.Size = new System.Drawing.Size(67, 36);
            this.SendNotify_Button.TabIndex = 87;
            this.SendNotify_Button.Text = "LƯU";
            this.SendNotify_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // SubjectModify_SubTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SendNotify_Button);
            this.Controls.Add(this.NotifyContent_Box);
            this.Controls.Add(this.Notify_Label);
            this.Controls.Add(this.SubjectLabel);
            this.Controls.Add(this.GridView);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.OralTest_GroupBox);
            this.Name = "SubjectModify_SubTab";
            this.Size = new System.Drawing.Size(924, 688);
            this.Load += new System.EventHandler(this.SubjectModify_SubTab_Load);
            this.OralTest_GroupBox.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox OralTest_GroupBox;
        private Guna.UI2.WinForms.Guna2TextBox PassGrade_Box;
        private Guna.UI2.WinForms.Guna2Button PassGrade_SaveButton;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2TextBox MaxGrade_Box;
        private Guna.UI2.WinForms.Guna2DataGridView GridView;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeahcherID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeahcherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeahcherBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeahcherEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeahcherStartDate;
        private System.Windows.Forms.Label Notify_Label;
        private Guna.UI2.WinForms.Guna2TextBox NotifyContent_Box;
        private Guna.UI2.WinForms.Guna2Button SendNotify_Button;
    }
}
