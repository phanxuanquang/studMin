namespace studMin
{
    partial class StatisticTab
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
            this.DataGridViewExport_Button = new Guna.UI2.WinForms.Guna2Button();
            this.DataTable = new Guna.UI2.WinForms.Guna2DataGridView();
            this.tittleLabel = new System.Windows.Forms.Label();
            this.Semester_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SchoolYear_ComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
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
            this.DataGridViewExport_Button.Location = new System.Drawing.Point(1029, 81);
            this.DataGridViewExport_Button.Margin = new System.Windows.Forms.Padding(4);
            this.DataGridViewExport_Button.Name = "DataGridViewExport_Button";
            this.DataGridViewExport_Button.ShadowDecoration.Parent = this.DataGridViewExport_Button;
            this.DataGridViewExport_Button.Size = new System.Drawing.Size(191, 44);
            this.DataGridViewExport_Button.TabIndex = 112;
            this.DataGridViewExport_Button.Text = "XUẤT DANH SÁCH";
            this.DataGridViewExport_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.DataGridViewExport_Button.Click += new System.EventHandler(this.DataGridViewExport_Button_Click);
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
            this.DataTable.Location = new System.Drawing.Point(0, 144);
            this.DataTable.Margin = new System.Windows.Forms.Padding(4);
            this.DataTable.Name = "DataTable";
            this.DataTable.ReadOnly = true;
            this.DataTable.RowHeadersVisible = false;
            this.DataTable.RowHeadersWidth = 51;
            this.DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataTable.Size = new System.Drawing.Size(1232, 767);
            this.DataTable.TabIndex = 110;
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
            // tittleLabel
            // 
            this.tittleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.tittleLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tittleLabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.tittleLabel.ForeColor = System.Drawing.Color.White;
            this.tittleLabel.Location = new System.Drawing.Point(0, 0);
            this.tittleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tittleLabel.Name = "tittleLabel";
            this.tittleLabel.Size = new System.Drawing.Size(1232, 64);
            this.tittleLabel.TabIndex = 109;
            this.tittleLabel.Text = "BẢNG THỐNG KÊ KẾT QUẢ HỌC TẬP HỌC KỲ 1 NĂM HỌC 2021-2022";
            this.tittleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            "Mọi học kỳ",
            "Học kỳ I",
            "Học kỳ II"});
            this.Semester_ComboBox.ItemsAppearance.Parent = this.Semester_ComboBox;
            this.Semester_ComboBox.Location = new System.Drawing.Point(658, 81);
            this.Semester_ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Semester_ComboBox.Name = "Semester_ComboBox";
            this.Semester_ComboBox.ShadowDecoration.Parent = this.Semester_ComboBox;
            this.Semester_ComboBox.Size = new System.Drawing.Size(173, 36);
            this.Semester_ComboBox.StartIndex = 0;
            this.Semester_ComboBox.TabIndex = 113;
            this.Semester_ComboBox.TextOffset = new System.Drawing.Point(5, 0);
            this.Semester_ComboBox.SelectedIndexChanged += new System.EventHandler(this.Semester_ComboBox_SelectedIndexChanged);
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
            "Mọi niên khóa",
            "2020",
            "2021",
            "2022"});
            this.SchoolYear_ComboBox.ItemsAppearance.Parent = this.SchoolYear_ComboBox;
            this.SchoolYear_ComboBox.Location = new System.Drawing.Point(839, 81);
            this.SchoolYear_ComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.SchoolYear_ComboBox.Name = "SchoolYear_ComboBox";
            this.SchoolYear_ComboBox.ShadowDecoration.Parent = this.SchoolYear_ComboBox;
            this.SchoolYear_ComboBox.Size = new System.Drawing.Size(185, 36);
            this.SchoolYear_ComboBox.StartIndex = 0;
            this.SchoolYear_ComboBox.TabIndex = 114;
            this.SchoolYear_ComboBox.TextOffset = new System.Drawing.Point(5, 0);
            this.SchoolYear_ComboBox.SelectedIndexChanged += new System.EventHandler(this.SchoolYear_ComboBox_SelectedIndexChanged);
            // 
            // StatisticTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SchoolYear_ComboBox);
            this.Controls.Add(this.Semester_ComboBox);
            this.Controls.Add(this.DataGridViewExport_Button);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.tittleLabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StatisticTab";
            this.Size = new System.Drawing.Size(1232, 911);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button DataGridViewExport_Button;
        private Guna.UI2.WinForms.Guna2DataGridView DataTable;
        private System.Windows.Forms.Label tittleLabel;
        private Guna.UI2.WinForms.Guna2ComboBox Semester_ComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox SchoolYear_ComboBox;
    }
}
