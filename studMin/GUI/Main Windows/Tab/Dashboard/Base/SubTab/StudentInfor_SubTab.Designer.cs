namespace studMin
{
    partial class StudentInfor_SubTab
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
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentNumber_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.Address_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.Email_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.Bloodline_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.Genre_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.Class_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.SchoolYear_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.FullName_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.ID_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaLabel16 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel17 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel18 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel7 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel8 = new Guna.UI.WinForms.GunaLabel();
            this.SchoolYear_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.gunaLabel10 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel11 = new Guna.UI.WinForms.GunaLabel();
            this.Search_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.Search_Button = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel12 = new Guna.UI.WinForms.GunaLabel();
            this.Class_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.DataTable = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Status
            // 
            this.Status.HeaderText = "Trạng thái";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // Class
            // 
            this.Class.HeaderText = "Lớp";
            this.Class.MinimumWidth = 6;
            this.Class.Name = "Class";
            this.Class.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.FillWeight = 120F;
            this.ID.HeaderText = "Mã học sinh";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // SchoolYear
            // 
            this.SchoolYear.HeaderText = "Niên khóa";
            this.SchoolYear.MinimumWidth = 6;
            this.SchoolYear.Name = "SchoolYear";
            this.SchoolYear.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Họ và tên";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // ParentNumber_Box
            // 
            this.ParentNumber_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ParentNumber_Box.Animated = true;
            this.ParentNumber_Box.BackColor = System.Drawing.Color.Transparent;
            this.ParentNumber_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.ParentNumber_Box.BorderRadius = 5;
            this.ParentNumber_Box.BorderThickness = 2;
            this.ParentNumber_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ParentNumber_Box.DefaultText = "";
            this.ParentNumber_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ParentNumber_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ParentNumber_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ParentNumber_Box.DisabledState.Parent = this.ParentNumber_Box;
            this.ParentNumber_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ParentNumber_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.ParentNumber_Box.FocusedState.Parent = this.ParentNumber_Box;
            this.ParentNumber_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ParentNumber_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.ParentNumber_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.ParentNumber_Box.HoverState.Parent = this.ParentNumber_Box;
            this.ParentNumber_Box.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.ParentNumber_Box.Location = new System.Drawing.Point(663, 146);
            this.ParentNumber_Box.Margin = new System.Windows.Forms.Padding(0);
            this.ParentNumber_Box.Name = "ParentNumber_Box";
            this.ParentNumber_Box.PasswordChar = '\0';
            this.ParentNumber_Box.PlaceholderText = "Không xác định";
            this.ParentNumber_Box.ReadOnly = true;
            this.ParentNumber_Box.SelectedText = "";
            this.ParentNumber_Box.ShadowDecoration.BorderRadius = 12;
            this.ParentNumber_Box.ShadowDecoration.Depth = 5;
            this.ParentNumber_Box.ShadowDecoration.Parent = this.ParentNumber_Box;
            this.ParentNumber_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.ParentNumber_Box.Size = new System.Drawing.Size(245, 22);
            this.ParentNumber_Box.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ParentNumber_Box.TabIndex = 120;
            this.ParentNumber_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Address_Box
            // 
            this.Address_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Address_Box.Animated = true;
            this.Address_Box.BackColor = System.Drawing.Color.Transparent;
            this.Address_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Address_Box.BorderRadius = 5;
            this.Address_Box.BorderThickness = 2;
            this.Address_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Address_Box.DefaultText = "";
            this.Address_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Address_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Address_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Address_Box.DisabledState.Parent = this.Address_Box;
            this.Address_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Address_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Address_Box.FocusedState.Parent = this.Address_Box;
            this.Address_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Address_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Address_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Address_Box.HoverState.Parent = this.Address_Box;
            this.Address_Box.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.Address_Box.Location = new System.Drawing.Point(663, 120);
            this.Address_Box.Margin = new System.Windows.Forms.Padding(0);
            this.Address_Box.Name = "Address_Box";
            this.Address_Box.PasswordChar = '\0';
            this.Address_Box.PlaceholderText = "Không xác định";
            this.Address_Box.ReadOnly = true;
            this.Address_Box.SelectedText = "";
            this.Address_Box.ShadowDecoration.BorderRadius = 12;
            this.Address_Box.ShadowDecoration.Depth = 5;
            this.Address_Box.ShadowDecoration.Parent = this.Address_Box;
            this.Address_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.Address_Box.Size = new System.Drawing.Size(245, 22);
            this.Address_Box.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Address_Box.TabIndex = 119;
            this.Address_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Email_Box
            // 
            this.Email_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Email_Box.Animated = true;
            this.Email_Box.BackColor = System.Drawing.Color.Transparent;
            this.Email_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Email_Box.BorderRadius = 5;
            this.Email_Box.BorderThickness = 2;
            this.Email_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email_Box.DefaultText = "";
            this.Email_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Email_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Email_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email_Box.DisabledState.Parent = this.Email_Box;
            this.Email_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Email_Box.FocusedState.Parent = this.Email_Box;
            this.Email_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Email_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Email_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Email_Box.HoverState.Parent = this.Email_Box;
            this.Email_Box.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.Email_Box.Location = new System.Drawing.Point(663, 94);
            this.Email_Box.Margin = new System.Windows.Forms.Padding(0);
            this.Email_Box.Name = "Email_Box";
            this.Email_Box.PasswordChar = '\0';
            this.Email_Box.PlaceholderText = "Không xác định";
            this.Email_Box.ReadOnly = true;
            this.Email_Box.SelectedText = "";
            this.Email_Box.ShadowDecoration.BorderRadius = 12;
            this.Email_Box.ShadowDecoration.Depth = 5;
            this.Email_Box.ShadowDecoration.Parent = this.Email_Box;
            this.Email_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.Email_Box.Size = new System.Drawing.Size(245, 22);
            this.Email_Box.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Email_Box.TabIndex = 118;
            this.Email_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Bloodline_Box
            // 
            this.Bloodline_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Bloodline_Box.Animated = true;
            this.Bloodline_Box.BackColor = System.Drawing.Color.Transparent;
            this.Bloodline_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Bloodline_Box.BorderRadius = 5;
            this.Bloodline_Box.BorderThickness = 2;
            this.Bloodline_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Bloodline_Box.DefaultText = "";
            this.Bloodline_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Bloodline_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Bloodline_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Bloodline_Box.DisabledState.Parent = this.Bloodline_Box;
            this.Bloodline_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Bloodline_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Bloodline_Box.FocusedState.Parent = this.Bloodline_Box;
            this.Bloodline_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Bloodline_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Bloodline_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Bloodline_Box.HoverState.Parent = this.Bloodline_Box;
            this.Bloodline_Box.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.Bloodline_Box.Location = new System.Drawing.Point(354, 146);
            this.Bloodline_Box.Margin = new System.Windows.Forms.Padding(0);
            this.Bloodline_Box.Name = "Bloodline_Box";
            this.Bloodline_Box.PasswordChar = '\0';
            this.Bloodline_Box.PlaceholderText = "Không xác định";
            this.Bloodline_Box.ReadOnly = true;
            this.Bloodline_Box.SelectedText = "";
            this.Bloodline_Box.ShadowDecoration.BorderRadius = 12;
            this.Bloodline_Box.ShadowDecoration.Depth = 5;
            this.Bloodline_Box.ShadowDecoration.Parent = this.Bloodline_Box;
            this.Bloodline_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.Bloodline_Box.Size = new System.Drawing.Size(139, 22);
            this.Bloodline_Box.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Bloodline_Box.TabIndex = 117;
            this.Bloodline_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Genre_Box
            // 
            this.Genre_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Genre_Box.Animated = true;
            this.Genre_Box.BackColor = System.Drawing.Color.Transparent;
            this.Genre_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Genre_Box.BorderRadius = 5;
            this.Genre_Box.BorderThickness = 2;
            this.Genre_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Genre_Box.DefaultText = "";
            this.Genre_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Genre_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Genre_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Genre_Box.DisabledState.Parent = this.Genre_Box;
            this.Genre_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Genre_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Genre_Box.FocusedState.Parent = this.Genre_Box;
            this.Genre_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.Genre_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Genre_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Genre_Box.HoverState.Parent = this.Genre_Box;
            this.Genre_Box.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.Genre_Box.Location = new System.Drawing.Point(354, 120);
            this.Genre_Box.Margin = new System.Windows.Forms.Padding(0);
            this.Genre_Box.Name = "Genre_Box";
            this.Genre_Box.PasswordChar = '\0';
            this.Genre_Box.PlaceholderText = "Không xác định";
            this.Genre_Box.ReadOnly = true;
            this.Genre_Box.SelectedText = "";
            this.Genre_Box.ShadowDecoration.BorderRadius = 12;
            this.Genre_Box.ShadowDecoration.Depth = 5;
            this.Genre_Box.ShadowDecoration.Parent = this.Genre_Box;
            this.Genre_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.Genre_Box.Size = new System.Drawing.Size(139, 22);
            this.Genre_Box.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.Genre_Box.TabIndex = 116;
            this.Genre_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Class_Box.Location = new System.Drawing.Point(354, 94);
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
            this.Class_Box.TabIndex = 115;
            this.Class_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SchoolYear_Box
            // 
            this.SchoolYear_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SchoolYear_Box.Animated = true;
            this.SchoolYear_Box.BackColor = System.Drawing.Color.Transparent;
            this.SchoolYear_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.SchoolYear_Box.BorderRadius = 5;
            this.SchoolYear_Box.BorderThickness = 2;
            this.SchoolYear_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SchoolYear_Box.DefaultText = "";
            this.SchoolYear_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SchoolYear_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SchoolYear_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SchoolYear_Box.DisabledState.Parent = this.SchoolYear_Box;
            this.SchoolYear_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SchoolYear_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.SchoolYear_Box.FocusedState.Parent = this.SchoolYear_Box;
            this.SchoolYear_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.SchoolYear_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.SchoolYear_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.SchoolYear_Box.HoverState.Parent = this.SchoolYear_Box;
            this.SchoolYear_Box.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.SchoolYear_Box.Location = new System.Drawing.Point(115, 146);
            this.SchoolYear_Box.Margin = new System.Windows.Forms.Padding(0);
            this.SchoolYear_Box.Name = "SchoolYear_Box";
            this.SchoolYear_Box.PasswordChar = '\0';
            this.SchoolYear_Box.PlaceholderText = "Không xác định";
            this.SchoolYear_Box.ReadOnly = true;
            this.SchoolYear_Box.SelectedText = "";
            this.SchoolYear_Box.ShadowDecoration.BorderRadius = 12;
            this.SchoolYear_Box.ShadowDecoration.Depth = 5;
            this.SchoolYear_Box.ShadowDecoration.Parent = this.SchoolYear_Box;
            this.SchoolYear_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.SchoolYear_Box.Size = new System.Drawing.Size(139, 22);
            this.SchoolYear_Box.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.SchoolYear_Box.TabIndex = 114;
            this.SchoolYear_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FullName_Box
            // 
            this.FullName_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.FullName_Box.Animated = true;
            this.FullName_Box.BackColor = System.Drawing.Color.Transparent;
            this.FullName_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.FullName_Box.BorderRadius = 5;
            this.FullName_Box.BorderThickness = 2;
            this.FullName_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FullName_Box.DefaultText = "";
            this.FullName_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FullName_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FullName_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FullName_Box.DisabledState.Parent = this.FullName_Box;
            this.FullName_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FullName_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.FullName_Box.FocusedState.Parent = this.FullName_Box;
            this.FullName_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.FullName_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.FullName_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.FullName_Box.HoverState.Parent = this.FullName_Box;
            this.FullName_Box.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.FullName_Box.Location = new System.Drawing.Point(115, 120);
            this.FullName_Box.Margin = new System.Windows.Forms.Padding(0);
            this.FullName_Box.Name = "FullName_Box";
            this.FullName_Box.PasswordChar = '\0';
            this.FullName_Box.PlaceholderText = "Không xác định";
            this.FullName_Box.ReadOnly = true;
            this.FullName_Box.SelectedText = "";
            this.FullName_Box.ShadowDecoration.BorderRadius = 12;
            this.FullName_Box.ShadowDecoration.Depth = 5;
            this.FullName_Box.ShadowDecoration.Parent = this.FullName_Box;
            this.FullName_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.FullName_Box.Size = new System.Drawing.Size(139, 22);
            this.FullName_Box.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.FullName_Box.TabIndex = 113;
            this.FullName_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ID_Box
            // 
            this.ID_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ID_Box.Animated = true;
            this.ID_Box.BackColor = System.Drawing.Color.Transparent;
            this.ID_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.ID_Box.BorderRadius = 5;
            this.ID_Box.BorderThickness = 2;
            this.ID_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID_Box.DefaultText = "";
            this.ID_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ID_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ID_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ID_Box.DisabledState.Parent = this.ID_Box;
            this.ID_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ID_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.ID_Box.FocusedState.Parent = this.ID_Box;
            this.ID_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.ID_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.ID_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.ID_Box.HoverState.Parent = this.ID_Box;
            this.ID_Box.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.ID_Box.Location = new System.Drawing.Point(115, 94);
            this.ID_Box.Margin = new System.Windows.Forms.Padding(0);
            this.ID_Box.Name = "ID_Box";
            this.ID_Box.PasswordChar = '\0';
            this.ID_Box.PlaceholderText = "Không xác định";
            this.ID_Box.ReadOnly = true;
            this.ID_Box.SelectedText = "";
            this.ID_Box.ShadowDecoration.BorderRadius = 12;
            this.ID_Box.ShadowDecoration.Depth = 5;
            this.ID_Box.ShadowDecoration.Parent = this.ID_Box;
            this.ID_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.ID_Box.Size = new System.Drawing.Size(139, 22);
            this.ID_Box.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.ID_Box.TabIndex = 112;
            this.ID_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel16
            // 
            this.gunaLabel16.AutoEllipsis = true;
            this.gunaLabel16.BackColor = System.Drawing.Color.White;
            this.gunaLabel16.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gunaLabel16.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.gunaLabel16.Location = new System.Drawing.Point(514, 149);
            this.gunaLabel16.Name = "gunaLabel16";
            this.gunaLabel16.Size = new System.Drawing.Size(169, 22);
            this.gunaLabel16.TabIndex = 111;
            this.gunaLabel16.Text = "• Email phụ huynh:";
            this.gunaLabel16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel16.UseCompatibleTextRendering = true;
            // 
            // gunaLabel17
            // 
            this.gunaLabel17.AutoEllipsis = true;
            this.gunaLabel17.BackColor = System.Drawing.Color.White;
            this.gunaLabel17.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gunaLabel17.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.gunaLabel17.Location = new System.Drawing.Point(514, 123);
            this.gunaLabel17.Name = "gunaLabel17";
            this.gunaLabel17.Size = new System.Drawing.Size(169, 22);
            this.gunaLabel17.TabIndex = 110;
            this.gunaLabel17.Text = "• Địa chỉ thường trú:";
            this.gunaLabel17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel17.UseCompatibleTextRendering = true;
            // 
            // gunaLabel18
            // 
            this.gunaLabel18.AutoEllipsis = true;
            this.gunaLabel18.BackColor = System.Drawing.Color.White;
            this.gunaLabel18.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gunaLabel18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.gunaLabel18.Location = new System.Drawing.Point(514, 97);
            this.gunaLabel18.Name = "gunaLabel18";
            this.gunaLabel18.Size = new System.Drawing.Size(169, 22);
            this.gunaLabel18.TabIndex = 109;
            this.gunaLabel18.Text = "• E-mail cá nhân:";
            this.gunaLabel18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel18.UseCompatibleTextRendering = true;
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoEllipsis = true;
            this.gunaLabel6.BackColor = System.Drawing.Color.White;
            this.gunaLabel6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.gunaLabel6.Location = new System.Drawing.Point(276, 149);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(96, 22);
            this.gunaLabel6.TabIndex = 108;
            this.gunaLabel6.Text = "• Dân tộc:";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel6.UseCompatibleTextRendering = true;
            // 
            // gunaLabel7
            // 
            this.gunaLabel7.AutoEllipsis = true;
            this.gunaLabel7.BackColor = System.Drawing.Color.White;
            this.gunaLabel7.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gunaLabel7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.gunaLabel7.Location = new System.Drawing.Point(276, 123);
            this.gunaLabel7.Name = "gunaLabel7";
            this.gunaLabel7.Size = new System.Drawing.Size(96, 22);
            this.gunaLabel7.TabIndex = 107;
            this.gunaLabel7.Text = "• Giới tính:";
            this.gunaLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel7.UseCompatibleTextRendering = true;
            // 
            // gunaLabel8
            // 
            this.gunaLabel8.AutoEllipsis = true;
            this.gunaLabel8.BackColor = System.Drawing.Color.White;
            this.gunaLabel8.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gunaLabel8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.gunaLabel8.Location = new System.Drawing.Point(17, 149);
            this.gunaLabel8.Name = "gunaLabel8";
            this.gunaLabel8.Size = new System.Drawing.Size(96, 22);
            this.gunaLabel8.TabIndex = 106;
            this.gunaLabel8.Text = "• Niên khóa:";
            this.gunaLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel8.UseCompatibleTextRendering = true;
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
            this.SchoolYear_ComboBox.Location = new System.Drawing.Point(147, 32);
            this.SchoolYear_ComboBox.Name = "SchoolYear_ComboBox";
            this.SchoolYear_ComboBox.ShadowDecoration.Parent = this.SchoolYear_ComboBox;
            this.SchoolYear_ComboBox.Size = new System.Drawing.Size(142, 36);
            this.SchoolYear_ComboBox.StartIndex = 0;
            this.SchoolYear_ComboBox.TabIndex = 105;
            this.SchoolYear_ComboBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // gunaLabel10
            // 
            this.gunaLabel10.AutoEllipsis = true;
            this.gunaLabel10.BackColor = System.Drawing.Color.White;
            this.gunaLabel10.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gunaLabel10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.gunaLabel10.Location = new System.Drawing.Point(276, 97);
            this.gunaLabel10.Name = "gunaLabel10";
            this.gunaLabel10.Size = new System.Drawing.Size(96, 22);
            this.gunaLabel10.TabIndex = 100;
            this.gunaLabel10.Text = "• Lớp học:";
            this.gunaLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel10.UseCompatibleTextRendering = true;
            // 
            // gunaLabel11
            // 
            this.gunaLabel11.AutoEllipsis = true;
            this.gunaLabel11.BackColor = System.Drawing.Color.White;
            this.gunaLabel11.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gunaLabel11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.gunaLabel11.Location = new System.Drawing.Point(17, 123);
            this.gunaLabel11.Name = "gunaLabel11";
            this.gunaLabel11.Size = new System.Drawing.Size(96, 22);
            this.gunaLabel11.TabIndex = 99;
            this.gunaLabel11.Text = "• Họ và tên:";
            this.gunaLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel11.UseCompatibleTextRendering = true;
            // 
            // Search_Box
            // 
            this.Search_Box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Search_Box.Animated = true;
            this.Search_Box.BackColor = System.Drawing.Color.Transparent;
            this.Search_Box.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Search_Box.BorderRadius = 5;
            this.Search_Box.BorderThickness = 2;
            this.Search_Box.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Search_Box.DefaultText = "";
            this.Search_Box.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Search_Box.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Search_Box.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_Box.DisabledState.Parent = this.Search_Box;
            this.Search_Box.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Search_Box.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Search_Box.FocusedState.Parent = this.Search_Box;
            this.Search_Box.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Search_Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Search_Box.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Search_Box.HoverState.Parent = this.Search_Box;
            this.Search_Box.IconLeftOffset = new System.Drawing.Point(8, 0);
            this.Search_Box.Location = new System.Drawing.Point(296, 32);
            this.Search_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Search_Box.Name = "Search_Box";
            this.Search_Box.PasswordChar = '\0';
            this.Search_Box.PlaceholderText = "Nhập họ tên hoặc mã học sinh . . .";
            this.Search_Box.SelectedText = "";
            this.Search_Box.ShadowDecoration.BorderRadius = 12;
            this.Search_Box.ShadowDecoration.Depth = 5;
            this.Search_Box.ShadowDecoration.Parent = this.Search_Box;
            this.Search_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.Search_Box.Size = new System.Drawing.Size(469, 36);
            this.Search_Box.TabIndex = 104;
            this.Search_Box.TextOffset = new System.Drawing.Point(6, 0);
            this.Search_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Search_Box_KeyPress);
            // 
            // Search_Button
            // 
            this.Search_Button.Animated = true;
            this.Search_Button.BackColor = System.Drawing.Color.White;
            this.Search_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Search_Button.BorderRadius = 5;
            this.Search_Button.BorderThickness = 2;
            this.Search_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.Search_Button.CheckedState.Parent = this.Search_Button;
            this.Search_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Search_Button.CustomImages.Parent = this.Search_Button;
            this.Search_Button.FillColor = System.Drawing.Color.White;
            this.Search_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Search_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Search_Button.HoverState.FillColor = System.Drawing.Color.White;
            this.Search_Button.HoverState.Parent = this.Search_Button;
            this.Search_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Search_Button.Location = new System.Drawing.Point(772, 32);
            this.Search_Button.Name = "Search_Button";
            this.Search_Button.PressedDepth = 20;
            this.Search_Button.ShadowDecoration.Parent = this.Search_Button;
            this.Search_Button.Size = new System.Drawing.Size(143, 36);
            this.Search_Button.TabIndex = 103;
            this.Search_Button.Text = "TÌM KIẾM";
            this.Search_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Search_Button.Click += new System.EventHandler(this.Search_Button_Click);
            // 
            // gunaLabel12
            // 
            this.gunaLabel12.AutoEllipsis = true;
            this.gunaLabel12.BackColor = System.Drawing.Color.White;
            this.gunaLabel12.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gunaLabel12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.gunaLabel12.Location = new System.Drawing.Point(17, 97);
            this.gunaLabel12.Name = "gunaLabel12";
            this.gunaLabel12.Size = new System.Drawing.Size(96, 22);
            this.gunaLabel12.TabIndex = 98;
            this.gunaLabel12.Text = "• Mã học sinh:";
            this.gunaLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.gunaLabel12.UseCompatibleTextRendering = true;
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
            "Mọi lớp"});
            this.Class_ComboBox.ItemsAppearance.Parent = this.Class_ComboBox;
            this.Class_ComboBox.Location = new System.Drawing.Point(10, 32);
            this.Class_ComboBox.Name = "Class_ComboBox";
            this.Class_ComboBox.ShadowDecoration.Parent = this.Class_ComboBox;
            this.Class_ComboBox.Size = new System.Drawing.Size(131, 36);
            this.Class_ComboBox.StartIndex = 0;
            this.Class_ComboBox.TabIndex = 102;
            this.Class_ComboBox.TextOffset = new System.Drawing.Point(5, 0);
            // 
            // DataTable
            // 
            this.DataTable.AllowDrop = true;
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataTable.BackgroundColor = System.Drawing.Color.White;
            this.DataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(147)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataTable.ColumnHeadersHeight = 25;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SchoolYear,
            this.ID,
            this.Class,
            this.FullName,
            this.Status});
            this.DataTable.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataTable.EnableHeadersVisualStyles = false;
            this.DataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.DataTable.Location = new System.Drawing.Point(0, 199);
            this.DataTable.MultiSelect = false;
            this.DataTable.Name = "DataTable";
            this.DataTable.ReadOnly = true;
            this.DataTable.RowHeadersVisible = false;
            this.DataTable.RowHeadersWidth = 51;
            this.DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataTable.Size = new System.Drawing.Size(924, 489);
            this.DataTable.TabIndex = 101;
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
            this.DataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTable_CellContentClick);
            // 
            // StudentInfor_SubTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ParentNumber_Box);
            this.Controls.Add(this.Address_Box);
            this.Controls.Add(this.Email_Box);
            this.Controls.Add(this.Bloodline_Box);
            this.Controls.Add(this.Genre_Box);
            this.Controls.Add(this.Class_Box);
            this.Controls.Add(this.SchoolYear_Box);
            this.Controls.Add(this.FullName_Box);
            this.Controls.Add(this.ID_Box);
            this.Controls.Add(this.gunaLabel16);
            this.Controls.Add(this.gunaLabel17);
            this.Controls.Add(this.gunaLabel18);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.gunaLabel7);
            this.Controls.Add(this.gunaLabel8);
            this.Controls.Add(this.SchoolYear_ComboBox);
            this.Controls.Add(this.gunaLabel10);
            this.Controls.Add(this.gunaLabel11);
            this.Controls.Add(this.Search_Box);
            this.Controls.Add(this.Search_Button);
            this.Controls.Add(this.gunaLabel12);
            this.Controls.Add(this.Class_ComboBox);
            this.Controls.Add(this.DataTable);
            this.DoubleBuffered = true;
            this.Name = "StudentInfor_SubTab";
            this.Size = new System.Drawing.Size(924, 688);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        protected Guna.UI2.WinForms.Guna2TextBox ParentNumber_Box;
        protected Guna.UI2.WinForms.Guna2TextBox Address_Box;
        protected Guna.UI2.WinForms.Guna2TextBox Email_Box;
        protected Guna.UI2.WinForms.Guna2TextBox Bloodline_Box;
        protected Guna.UI2.WinForms.Guna2TextBox Genre_Box;
        protected Guna.UI2.WinForms.Guna2TextBox Class_Box;
        protected Guna.UI2.WinForms.Guna2TextBox SchoolYear_Box;
        protected Guna.UI2.WinForms.Guna2TextBox FullName_Box;
        protected Guna.UI2.WinForms.Guna2TextBox ID_Box;
        private Guna.UI.WinForms.GunaLabel gunaLabel16;
        private Guna.UI.WinForms.GunaLabel gunaLabel17;
        private Guna.UI.WinForms.GunaLabel gunaLabel18;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaLabel gunaLabel7;
        private Guna.UI.WinForms.GunaLabel gunaLabel8;
        private Guna.UI2.WinForms.Guna2ComboBox SchoolYear_ComboBox;
        private Guna.UI.WinForms.GunaLabel gunaLabel10;
        private Guna.UI.WinForms.GunaLabel gunaLabel11;
        protected Guna.UI2.WinForms.Guna2TextBox Search_Box;
        protected Guna.UI2.WinForms.Guna2Button Search_Button;
        private Guna.UI.WinForms.GunaLabel gunaLabel12;
        private Guna.UI2.WinForms.Guna2ComboBox Class_ComboBox;
        private Guna.UI2.WinForms.Guna2DataGridView DataTable;
    }
}
