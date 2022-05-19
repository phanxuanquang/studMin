namespace studMin
{
    partial class StudentMoralQualify_SubTab
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
            this.Search_Box = new Guna.UI2.WinForms.Guna2TextBox();
            this.DataTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.sttDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sCHOOLYEARDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDCONDUCTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cONDUCTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRANSCRIPTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataGridViewExport_Button = new Guna.UI2.WinForms.Guna2Button();
            this.UpdateData_Button = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONDUCTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSCRIPTBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.Search_Box.Location = new System.Drawing.Point(13, 39);
            this.Search_Box.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Search_Box.Name = "Search_Box";
            this.Search_Box.PasswordChar = '\0';
            this.Search_Box.PlaceholderText = "Nhập họ tên hoặc mã học sinh . . .";
            this.Search_Box.SelectedText = "";
            this.Search_Box.ShadowDecoration.BorderRadius = 12;
            this.Search_Box.ShadowDecoration.Depth = 5;
            this.Search_Box.ShadowDecoration.Parent = this.Search_Box;
            this.Search_Box.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(3, 0, 5, 3);
            this.Search_Box.Size = new System.Drawing.Size(857, 44);
            this.Search_Box.TabIndex = 81;
            this.Search_Box.TextOffset = new System.Drawing.Point(6, 0);
            this.Search_Box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Search_Box_KeyPress);
            // 
            // DataTable
            // 
            this.DataTable.AllowDrop = true;
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataTable.AutoGenerateColumns = false;
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
            this.sttDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.sCHOOLYEARDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn,
            this.iDCONDUCTDataGridViewTextBoxColumn});
            this.DataTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataTable.DataSource = this.tRANSCRIPTBindingSource;
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
            this.DataTable.Location = new System.Drawing.Point(0, 106);
            this.DataTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataTable.Name = "DataTable";
            this.DataTable.RowHeadersVisible = false;
            this.DataTable.RowHeadersWidth = 51;
            this.DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataTable.Size = new System.Drawing.Size(1232, 741);
            this.DataTable.TabIndex = 78;
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
            this.DataTable.ThemeStyle.ReadOnly = false;
            this.DataTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.DataTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.DataTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.DataTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.DataTable.ThemeStyle.RowsStyle.Height = 22;
            this.DataTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.DataTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            // 
            // sttDataGridViewTextBoxColumn
            // 
            this.sttDataGridViewTextBoxColumn.HeaderText = "Thứ tự";
            this.sttDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sttDataGridViewTextBoxColumn.Name = "sttDataGridViewTextBoxColumn";
            this.sttDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.HeaderText = "Họ và tên";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sCHOOLYEARDataGridViewTextBoxColumn
            // 
            this.sCHOOLYEARDataGridViewTextBoxColumn.DataPropertyName = "SCHOOLYEAR";
            this.sCHOOLYEARDataGridViewTextBoxColumn.HeaderText = "Niên khóa";
            this.sCHOOLYEARDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.sCHOOLYEARDataGridViewTextBoxColumn.Name = "sCHOOLYEARDataGridViewTextBoxColumn";
            this.sCHOOLYEARDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Học kỳ";
            this.semesterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iDCONDUCTDataGridViewTextBoxColumn
            // 
            this.iDCONDUCTDataGridViewTextBoxColumn.DataPropertyName = "IDCONDUCT";
            this.iDCONDUCTDataGridViewTextBoxColumn.DataSource = this.cONDUCTBindingSource;
            this.iDCONDUCTDataGridViewTextBoxColumn.DisplayMember = "NAME";
            this.iDCONDUCTDataGridViewTextBoxColumn.HeaderText = "Hạnh kiểm";
            this.iDCONDUCTDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDCONDUCTDataGridViewTextBoxColumn.Name = "iDCONDUCTDataGridViewTextBoxColumn";
            this.iDCONDUCTDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDCONDUCTDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDCONDUCTDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // cONDUCTBindingSource
            // 
            this.cONDUCTBindingSource.DataSource = typeof(studMin.Database.Models.CONDUCT);
            // 
            // tRANSCRIPTBindingSource
            // 
            this.tRANSCRIPTBindingSource.DataSource = typeof(studMin.Database.Models.TRANSCRIPT);
            // 
            // DataGridViewExport_Button
            // 
            this.DataGridViewExport_Button.Animated = true;
            this.DataGridViewExport_Button.BackColor = System.Drawing.Color.Transparent;
            this.DataGridViewExport_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.DataGridViewExport_Button.BorderRadius = 5;
            this.DataGridViewExport_Button.CheckedState.Parent = this.DataGridViewExport_Button;
            this.DataGridViewExport_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataGridViewExport_Button.CustomImages.Parent = this.DataGridViewExport_Button;
            this.DataGridViewExport_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.DataGridViewExport_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.DataGridViewExport_Button.ForeColor = System.Drawing.Color.White;
            this.DataGridViewExport_Button.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.DataGridViewExport_Button.HoverState.Parent = this.DataGridViewExport_Button;
            this.DataGridViewExport_Button.Location = new System.Drawing.Point(1029, 39);
            this.DataGridViewExport_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DataGridViewExport_Button.Name = "DataGridViewExport_Button";
            this.DataGridViewExport_Button.ShadowDecoration.Parent = this.DataGridViewExport_Button;
            this.DataGridViewExport_Button.Size = new System.Drawing.Size(191, 44);
            this.DataGridViewExport_Button.TabIndex = 82;
            this.DataGridViewExport_Button.Text = "XUẤT DANH SÁCH";
            this.DataGridViewExport_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            // 
            // UpdateData_Button
            // 
            this.UpdateData_Button.Animated = true;
            this.UpdateData_Button.BackColor = System.Drawing.Color.White;
            this.UpdateData_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.UpdateData_Button.BorderRadius = 5;
            this.UpdateData_Button.BorderThickness = 2;
            this.UpdateData_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.UpdateData_Button.CheckedState.Parent = this.UpdateData_Button;
            this.UpdateData_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.UpdateData_Button.CustomImages.Parent = this.UpdateData_Button;
            this.UpdateData_Button.FillColor = System.Drawing.Color.White;
            this.UpdateData_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.UpdateData_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.UpdateData_Button.HoverState.FillColor = System.Drawing.Color.White;
            this.UpdateData_Button.HoverState.Parent = this.UpdateData_Button;
            this.UpdateData_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UpdateData_Button.Location = new System.Drawing.Point(880, 39);
            this.UpdateData_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UpdateData_Button.Name = "UpdateData_Button";
            this.UpdateData_Button.PressedDepth = 20;
            this.UpdateData_Button.ShadowDecoration.Parent = this.UpdateData_Button;
            this.UpdateData_Button.Size = new System.Drawing.Size(143, 44);
            this.UpdateData_Button.TabIndex = 83;
            this.UpdateData_Button.Text = "CẬP NHẬT";
            this.UpdateData_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.UpdateData_Button.Click += new System.EventHandler(this.UpdateData_Button_Click);
            // 
            // StudentMoralQualify_SubTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.UpdateData_Button);
            this.Controls.Add(this.DataGridViewExport_Button);
            this.Controls.Add(this.Search_Box);
            this.Controls.Add(this.DataTable);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "StudentMoralQualify_SubTab";
            this.Size = new System.Drawing.Size(1232, 847);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cONDUCTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRANSCRIPTBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected Guna.UI2.WinForms.Guna2TextBox Search_Box;
        private Guna.UI2.WinForms.Guna2DataGridView DataTable;
        private Guna.UI2.WinForms.Guna2Button DataGridViewExport_Button;
        private Guna.UI2.WinForms.Guna2Button UpdateData_Button;
        private System.Windows.Forms.BindingSource cONDUCTBindingSource;
        private System.Windows.Forms.BindingSource tRANSCRIPTBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn sttDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sCHOOLYEARDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDCONDUCTDataGridViewTextBoxColumn;
    }
}
