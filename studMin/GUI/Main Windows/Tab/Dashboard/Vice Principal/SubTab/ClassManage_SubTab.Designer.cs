namespace studMin
{
    partial class ClassManage_SubTab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Update_Button = new Guna.UI2.WinForms.Guna2Button();
            this.AddClass_Button = new Guna.UI2.WinForms.Guna2Button();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.ChangeAgeRange_Button = new Guna.UI2.WinForms.Guna2Button();
            this.NameClassHeadTeacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASSNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cLASSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // GridView
            // 
            this.GridView.AllowDrop = true;
            this.GridView.AllowUserToAddRows = false;
            this.GridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.GridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GridView.AutoGenerateColumns = false;
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
            this.iDDataGridViewTextBoxColumn,
            this.cLASSNAMEDataGridViewTextBoxColumn,
            this.NameClassHeadTeacher,
            this.Quantity,
            this.MaxQuantity});
            this.GridView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GridView.DataSource = this.cLASSBindingSource;
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
            this.GridView.Location = new System.Drawing.Point(0, 148);
            this.GridView.Margin = new System.Windows.Forms.Padding(4);
            this.GridView.Name = "GridView";
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
            this.GridView.Size = new System.Drawing.Size(1232, 699);
            this.GridView.TabIndex = 104;
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
            this.GridView.ThemeStyle.ReadOnly = false;
            this.GridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(242)))), ((int)(((byte)(245)))));
            this.GridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.GridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.GridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            this.GridView.ThemeStyle.RowsStyle.Height = 22;
            this.GridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(228)))), ((int)(((byte)(232)))));
            this.GridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(115)))), ((int)(((byte)(247)))));
            // 
            // Update_Button
            // 
            this.Update_Button.Animated = true;
            this.Update_Button.BackColor = System.Drawing.Color.Transparent;
            this.Update_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Update_Button.BorderRadius = 5;
            this.Update_Button.CheckedState.Parent = this.Update_Button;
            this.Update_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Update_Button.CustomImages.Parent = this.Update_Button;
            this.Update_Button.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.Update_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Update_Button.ForeColor = System.Drawing.Color.White;
            this.Update_Button.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(190)))), ((int)(((byte)(250)))));
            this.Update_Button.HoverState.Parent = this.Update_Button;
            this.Update_Button.Location = new System.Drawing.Point(975, 96);
            this.Update_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Update_Button.Name = "Update_Button";
            this.Update_Button.ShadowDecoration.Parent = this.Update_Button;
            this.Update_Button.Size = new System.Drawing.Size(253, 44);
            this.Update_Button.TabIndex = 105;
            this.Update_Button.Text = "CẬP NHẬT";
            this.Update_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.Update_Button.Click += new System.EventHandler(this.Update_Button_Click);
            // 
            // AddClass_Button
            // 
            this.AddClass_Button.Animated = true;
            this.AddClass_Button.BackColor = System.Drawing.Color.White;
            this.AddClass_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.AddClass_Button.BorderRadius = 5;
            this.AddClass_Button.BorderThickness = 2;
            this.AddClass_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.AddClass_Button.CheckedState.Parent = this.AddClass_Button;
            this.AddClass_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddClass_Button.CustomImages.Parent = this.AddClass_Button;
            this.AddClass_Button.FillColor = System.Drawing.Color.White;
            this.AddClass_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.AddClass_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.AddClass_Button.HoverState.FillColor = System.Drawing.Color.White;
            this.AddClass_Button.HoverState.Parent = this.AddClass_Button;
            this.AddClass_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AddClass_Button.Location = new System.Drawing.Point(713, 96);
            this.AddClass_Button.Margin = new System.Windows.Forms.Padding(4);
            this.AddClass_Button.Name = "AddClass_Button";
            this.AddClass_Button.PressedDepth = 20;
            this.AddClass_Button.ShadowDecoration.Parent = this.AddClass_Button;
            this.AddClass_Button.Size = new System.Drawing.Size(253, 44);
            this.AddClass_Button.TabIndex = 106;
            this.AddClass_Button.Text = "THÊM LỚP HỌC";
            this.AddClass_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.AddClass_Button.Click += new System.EventHandler(this.AddClass_Button_Click);
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoEllipsis = true;
            this.gunaLabel6.BackColor = System.Drawing.Color.White;
            this.gunaLabel6.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.gunaLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.gunaLabel6.Location = new System.Drawing.Point(0, 25);
            this.gunaLabel6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(1232, 50);
            this.gunaLabel6.TabIndex = 151;
            this.gunaLabel6.Text = "QUẢN LÝ THÔNG TIN LỚP HỌC";
            this.gunaLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.gunaLabel6.UseCompatibleTextRendering = true;
            // 
            // ChangeAgeRange_Button
            // 
            this.ChangeAgeRange_Button.Animated = true;
            this.ChangeAgeRange_Button.BackColor = System.Drawing.Color.White;
            this.ChangeAgeRange_Button.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.ChangeAgeRange_Button.BorderRadius = 5;
            this.ChangeAgeRange_Button.BorderThickness = 2;
            this.ChangeAgeRange_Button.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(225)))), ((int)(((byte)(249)))));
            this.ChangeAgeRange_Button.CheckedState.Parent = this.ChangeAgeRange_Button;
            this.ChangeAgeRange_Button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ChangeAgeRange_Button.CustomImages.Parent = this.ChangeAgeRange_Button;
            this.ChangeAgeRange_Button.FillColor = System.Drawing.Color.White;
            this.ChangeAgeRange_Button.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ChangeAgeRange_Button.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(118)))), ((int)(((byte)(245)))));
            this.ChangeAgeRange_Button.HoverState.FillColor = System.Drawing.Color.White;
            this.ChangeAgeRange_Button.HoverState.Parent = this.ChangeAgeRange_Button;
            this.ChangeAgeRange_Button.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ChangeAgeRange_Button.Location = new System.Drawing.Point(452, 96);
            this.ChangeAgeRange_Button.Margin = new System.Windows.Forms.Padding(4);
            this.ChangeAgeRange_Button.Name = "ChangeAgeRange_Button";
            this.ChangeAgeRange_Button.PressedDepth = 20;
            this.ChangeAgeRange_Button.ShadowDecoration.Parent = this.ChangeAgeRange_Button;
            this.ChangeAgeRange_Button.Size = new System.Drawing.Size(253, 44);
            this.ChangeAgeRange_Button.TabIndex = 152;
            this.ChangeAgeRange_Button.Text = "THAY ĐỔI KHOẢNG TUỔI";
            this.ChangeAgeRange_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.ChangeAgeRange_Button.Click += new System.EventHandler(this.ChangeAgeRange_Button_Click);
            // 
            // NameClassHeadTeacher
            // 
            this.NameClassHeadTeacher.HeaderText = "Giáo viên chủ nhiệm";
            this.NameClassHeadTeacher.MinimumWidth = 6;
            this.NameClassHeadTeacher.Name = "NameClassHeadTeacher";
            this.NameClassHeadTeacher.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Sỉ số";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // MaxQuantity
            // 
            this.MaxQuantity.HeaderText = "Sỉ số tối đa";
            this.MaxQuantity.MinimumWidth = 6;
            this.MaxQuantity.Name = "MaxQuantity";
            this.MaxQuantity.ReadOnly = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "Mã lớp";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cLASSNAMEDataGridViewTextBoxColumn
            // 
            this.cLASSNAMEDataGridViewTextBoxColumn.DataPropertyName = "CLASSNAME";
            this.cLASSNAMEDataGridViewTextBoxColumn.HeaderText = "Tên lớp";
            this.cLASSNAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cLASSNAMEDataGridViewTextBoxColumn.Name = "cLASSNAMEDataGridViewTextBoxColumn";
            // 
            // cLASSBindingSource
            // 
            this.cLASSBindingSource.DataSource = typeof(studMin.Database.Models.CLASS);
            // 
            // ClassManage_SubTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ChangeAgeRange_Button);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.AddClass_Button);
            this.Controls.Add(this.Update_Button);
            this.Controls.Add(this.GridView);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ClassManage_SubTab";
            this.Size = new System.Drawing.Size(1232, 847);
            ((System.ComponentModel.ISupportInitialize)(this.GridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView GridView;
        private Guna.UI2.WinForms.Guna2Button Update_Button;
        private Guna.UI2.WinForms.Guna2Button AddClass_Button;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI2.WinForms.Guna2Button ChangeAgeRange_Button;
        private System.Windows.Forms.BindingSource cLASSBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cLASSNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameClassHeadTeacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxQuantity;
    }
}
