namespace QLDungCuTheThao
{
    partial class frmDungCu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDungCu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dungCuVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tool = new System.Windows.Forms.ToolStrip();
            this.menu = new System.Windows.Forms.ToolStripDropDownButton();
            this.quảnLýLoạiDụngCụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýMượnTrảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReset = new System.Windows.Forms.ToolStripButton();
            this.btnXoa = new System.Windows.Forms.ToolStripButton();
            this.btnSua = new System.Windows.Forms.ToolStripButton();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cbloai = new System.Windows.Forms.ComboBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.tenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.moTaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayCapNhatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dungCuVMBindingSource)).BeginInit();
            this.tool.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDataGridViewTextBoxColumn,
            this.tenLoaiDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.moTaDataGridViewTextBoxColumn,
            this.ngayThemDataGridViewTextBoxColumn,
            this.ngayCapNhatDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dungCuVMBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1110, 559);
            this.dataGridView1.TabIndex = 0;
            // 
            // dungCuVMBindingSource
            // 
            this.dungCuVMBindingSource.DataSource = typeof(QLDungCuTheThao.ViewModel.DungCuVM);
            // 
            // tool
            // 
            this.tool.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tool.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu,
            this.btnReset,
            this.btnXoa,
            this.btnSua,
            this.btnThem});
            this.tool.Location = new System.Drawing.Point(0, 0);
            this.tool.Name = "tool";
            this.tool.Size = new System.Drawing.Size(1134, 35);
            this.tool.TabIndex = 1;
            this.tool.Text = "toolStrip1";
            // 
            // menu
            // 
            this.menu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýLoạiDụngCụToolStripMenuItem,
            this.quảnLýMượnTrảToolStripMenuItem});
            this.menu.Image = ((System.Drawing.Image)(resources.GetObject("menu.Image")));
            this.menu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(76, 32);
            this.menu.Text = "Menu";
            // 
            // quảnLýLoạiDụngCụToolStripMenuItem
            // 
            this.quảnLýLoạiDụngCụToolStripMenuItem.Name = "quảnLýLoạiDụngCụToolStripMenuItem";
            this.quảnLýLoạiDụngCụToolStripMenuItem.Size = new System.Drawing.Size(290, 32);
            this.quảnLýLoạiDụngCụToolStripMenuItem.Text = "Quản Lý Loại Dụng Cụ";
            this.quảnLýLoạiDụngCụToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLoạiDụngCụToolStripMenuItem_Click);
            // 
            // quảnLýMượnTrảToolStripMenuItem
            // 
            this.quảnLýMượnTrảToolStripMenuItem.Name = "quảnLýMượnTrảToolStripMenuItem";
            this.quảnLýMượnTrảToolStripMenuItem.Size = new System.Drawing.Size(290, 32);
            this.quảnLýMượnTrảToolStripMenuItem.Text = "Quản Lý Mượn Trả";
            this.quảnLýMượnTrảToolStripMenuItem.Click += new System.EventHandler(this.quảnLýMượnTrảToolStripMenuItem_Click);
            // 
            // btnReset
            // 
            this.btnReset.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReset.Image = global::QLDungCuTheThao.Properties.Resources.refresh_24px;
            this.btnReset.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(29, 32);
            this.btnReset.Text = "Reset";
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnXoa.Image = global::QLDungCuTheThao.Properties.Resources.CloseCircle_Linear_32px;
            this.btnXoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(70, 32);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSua.Image = global::QLDungCuTheThao.Properties.Resources.Edit_Linear_32px;
            this.btnSua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(69, 32);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnThem.Image = global::QLDungCuTheThao.Properties.Resources.AddCircle_Linear_32px;
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(84, 32);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtTimKiem.Location = new System.Drawing.Point(12, 42);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(993, 34);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimKiem_KeyUp);
            // 
            // cbloai
            // 
            this.cbloai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbloai.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbloai.FormattingEnabled = true;
            this.cbloai.Location = new System.Drawing.Point(12, 84);
            this.cbloai.Name = "cbloai";
            this.cbloai.Size = new System.Drawing.Size(1110, 36);
            this.cbloai.TabIndex = 4;
            this.cbloai.SelectedIndexChanged += new System.EventHandler(this.cbloai_SelectedIndexChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTimKiem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.Image = global::QLDungCuTheThao.Properties.Resources.SearchNormal_Linear_24px;
            this.btnTimKiem.Location = new System.Drawing.Point(1011, 40);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(111, 38);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // tenDataGridViewTextBoxColumn
            // 
            this.tenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenDataGridViewTextBoxColumn.DataPropertyName = "Ten";
            this.tenDataGridViewTextBoxColumn.HeaderText = "Tên Dụng Cụ";
            this.tenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenDataGridViewTextBoxColumn.Name = "tenDataGridViewTextBoxColumn";
            this.tenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenLoaiDataGridViewTextBoxColumn
            // 
            this.tenLoaiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tenLoaiDataGridViewTextBoxColumn.DataPropertyName = "TenLoai";
            this.tenLoaiDataGridViewTextBoxColumn.HeaderText = "Tên Loại Dụng Cụ";
            this.tenLoaiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tenLoaiDataGridViewTextBoxColumn.Name = "tenLoaiDataGridViewTextBoxColumn";
            this.tenLoaiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.soLuongDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số Lượng";
            this.soLuongDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            this.soLuongDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // moTaDataGridViewTextBoxColumn
            // 
            this.moTaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.moTaDataGridViewTextBoxColumn.DataPropertyName = "MoTa";
            this.moTaDataGridViewTextBoxColumn.HeaderText = "Mô Tả";
            this.moTaDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.moTaDataGridViewTextBoxColumn.Name = "moTaDataGridViewTextBoxColumn";
            this.moTaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayThemDataGridViewTextBoxColumn
            // 
            this.ngayThemDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayThemDataGridViewTextBoxColumn.DataPropertyName = "NgayThem";
            this.ngayThemDataGridViewTextBoxColumn.HeaderText = "Ngày Thêm";
            this.ngayThemDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayThemDataGridViewTextBoxColumn.Name = "ngayThemDataGridViewTextBoxColumn";
            this.ngayThemDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ngayCapNhatDataGridViewTextBoxColumn
            // 
            this.ngayCapNhatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ngayCapNhatDataGridViewTextBoxColumn.DataPropertyName = "NgayCapNhat";
            this.ngayCapNhatDataGridViewTextBoxColumn.HeaderText = "Ngày Cập Nhật";
            this.ngayCapNhatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ngayCapNhatDataGridViewTextBoxColumn.Name = "ngayCapNhatDataGridViewTextBoxColumn";
            this.ngayCapNhatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // frmDungCu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 709);
            this.Controls.Add(this.cbloai);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.tool);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmDungCu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Dụng Cụ Thể Thao";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dungCuVMBindingSource)).EndInit();
            this.tool.ResumeLayout(false);
            this.tool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip tool;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.ToolStripButton btnSua;
        private System.Windows.Forms.ToolStripButton btnXoa;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDungCuDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn slKhoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton btnReset;
        private System.Windows.Forms.BindingSource dungCuVMBindingSource;
        private System.Windows.Forms.ComboBox cbloai;
        private System.Windows.Forms.ToolStripDropDownButton menu;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLoạiDụngCụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýMượnTrảToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn moTaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayCapNhatDataGridViewTextBoxColumn;
    }
}