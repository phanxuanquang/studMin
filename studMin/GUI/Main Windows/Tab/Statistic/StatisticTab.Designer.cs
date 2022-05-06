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
            this.Order = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.DataGridViewExport_Button.Location = new System.Drawing.Point(772, 66);
            this.DataGridViewExport_Button.Name = "DataGridViewExport_Button";
            this.DataGridViewExport_Button.ShadowDecoration.Parent = this.DataGridViewExport_Button;
            this.DataGridViewExport_Button.Size = new System.Drawing.Size(143, 36);
            this.DataGridViewExport_Button.TabIndex = 112;
            this.DataGridViewExport_Button.Text = "XUẤT DANH SÁCH";
            this.DataGridViewExport_Button.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
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
            this.Order,
            this.ID,
            this.FullName,
            this.Result,
            this.Column1});
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
            this.DataTable.Location = new System.Drawing.Point(0, 117);
            this.DataTable.Name = "DataTable";
            this.DataTable.ReadOnly = true;
            this.DataTable.RowHeadersVisible = false;
            this.DataTable.RowHeadersWidth = 51;
            this.DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DataTable.Size = new System.Drawing.Size(924, 623);
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
            this.tittleLabel.Name = "tittleLabel";
            this.tittleLabel.Size = new System.Drawing.Size(924, 52);
            this.tittleLabel.TabIndex = 109;
            this.tittleLabel.Text = "BẢNG THỐNG KÊ KẾT QUẢ HỌC TẬP HỌC KỲ 1 NĂM HỌC 2021-2022";
            this.tittleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Order
            // 
            this.Order.HeaderText = "Thứ tự";
            this.Order.MinimumWidth = 6;
            this.Order.Name = "Order";
            this.Order.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.FillWeight = 120F;
            this.ID.HeaderText = "Lớp";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Sỉ số";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Result
            // 
            this.Result.HeaderText = "Số lượng đạt";
            this.Result.MinimumWidth = 6;
            this.Result.Name = "Result";
            this.Result.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tỉ lệ đạt";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // StatisticTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.DataGridViewExport_Button);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.tittleLabel);
            this.Name = "StatisticTab";
            this.Size = new System.Drawing.Size(924, 740);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button DataGridViewExport_Button;
        private Guna.UI2.WinForms.Guna2DataGridView DataTable;
        private System.Windows.Forms.Label tittleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
