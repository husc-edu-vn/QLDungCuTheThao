namespace QLDungCuTheThao
{
    partial class frmThemSuaDungCu
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.lbten = new System.Windows.Forms.Label();
            this.lbsl = new System.Windows.Forms.Label();
            this.btndongy = new System.Windows.Forms.Button();
            this.btnboqua = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.picAnh = new System.Windows.Forms.PictureBox();
            this.btnchonanh = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbgia = new System.Windows.Forms.Label();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lbthuonghieu = new System.Windows.Forms.Label();
            this.txtThuonghieu = new System.Windows.Forms.TextBox();
            this.lbnsx = new System.Windows.Forms.Label();
            this.lbmota = new System.Windows.Forms.Label();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.dtNgay = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(144, 280);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(282, 34);
            this.txtTen.TabIndex = 1;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluong.Location = new System.Drawing.Point(144, 390);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(282, 34);
            this.txtSoluong.TabIndex = 3;
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbten.Location = new System.Drawing.Point(12, 283);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(121, 28);
            this.lbten.TabIndex = 2;
            this.lbten.Text = "Tên dụng cụ:";
            // 
            // lbsl
            // 
            this.lbsl.AutoSize = true;
            this.lbsl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsl.Location = new System.Drawing.Point(12, 393);
            this.lbsl.Name = "lbsl";
            this.lbsl.Size = new System.Drawing.Size(96, 28);
            this.lbsl.TabIndex = 3;
            this.lbsl.Text = "Số lượng:";
            // 
            // btndongy
            // 
            this.btndongy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndongy.Location = new System.Drawing.Point(144, 669);
            this.btndongy.Name = "btndongy";
            this.btndongy.Size = new System.Drawing.Size(125, 35);
            this.btndongy.TabIndex = 6;
            this.btndongy.Text = "Đồng ý";
            this.btndongy.UseVisualStyleBackColor = true;
            this.btndongy.Click += new System.EventHandler(this.btndongy_Click);
            // 
            // btnboqua
            // 
            this.btnboqua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnboqua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnboqua.Location = new System.Drawing.Point(301, 669);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(125, 35);
            this.btnboqua.TabIndex = 7;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // picAnh
            // 
            this.picAnh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picAnh.Location = new System.Drawing.Point(144, 12);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(282, 196);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 6;
            this.picAnh.TabStop = false;
            // 
            // btnchonanh
            // 
            this.btnchonanh.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnchonanh.Location = new System.Drawing.Point(144, 214);
            this.btnchonanh.Name = "btnchonanh";
            this.btnchonanh.Size = new System.Drawing.Size(282, 35);
            this.btnchonanh.TabIndex = 7;
            this.btnchonanh.Text = "Chọn ảnh";
            this.btnchonanh.UseVisualStyleBackColor = true;
            this.btnchonanh.Click += new System.EventHandler(this.btnchonanh_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lbgia
            // 
            this.lbgia.AutoSize = true;
            this.lbgia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbgia.Location = new System.Drawing.Point(12, 338);
            this.lbgia.Name = "lbgia";
            this.lbgia.Size = new System.Drawing.Size(45, 28);
            this.lbgia.TabIndex = 9;
            this.lbgia.Text = "Giá:";
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(144, 335);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(282, 34);
            this.txtGia.TabIndex = 2;
            // 
            // lbthuonghieu
            // 
            this.lbthuonghieu.AutoSize = true;
            this.lbthuonghieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbthuonghieu.Location = new System.Drawing.Point(12, 448);
            this.lbthuonghieu.Name = "lbthuonghieu";
            this.lbthuonghieu.Size = new System.Drawing.Size(126, 28);
            this.lbthuonghieu.TabIndex = 11;
            this.lbthuonghieu.Text = "Thương hiệu:";
            // 
            // txtThuonghieu
            // 
            this.txtThuonghieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThuonghieu.Location = new System.Drawing.Point(144, 445);
            this.txtThuonghieu.Name = "txtThuonghieu";
            this.txtThuonghieu.Size = new System.Drawing.Size(282, 34);
            this.txtThuonghieu.TabIndex = 4;
            this.txtThuonghieu.Text = "Không";
            // 
            // lbnsx
            // 
            this.lbnsx.AutoSize = true;
            this.lbnsx.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbnsx.Location = new System.Drawing.Point(12, 503);
            this.lbnsx.Name = "lbnsx";
            this.lbnsx.Size = new System.Drawing.Size(85, 28);
            this.lbnsx.TabIndex = 13;
            this.lbnsx.Text = "Ngày sx:";
            // 
            // lbmota
            // 
            this.lbmota.AutoSize = true;
            this.lbmota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmota.Location = new System.Drawing.Point(12, 558);
            this.lbmota.Name = "lbmota";
            this.lbmota.Size = new System.Drawing.Size(68, 28);
            this.lbmota.TabIndex = 15;
            this.lbmota.Text = "Mô tả:";
            // 
            // txtMota
            // 
            this.txtMota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMota.Location = new System.Drawing.Point(144, 555);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMota.Size = new System.Drawing.Size(282, 108);
            this.txtMota.TabIndex = 5;
            // 
            // dtNgay
            // 
            this.dtNgay.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.dtNgay.Location = new System.Drawing.Point(144, 498);
            this.dtNgay.Name = "dtNgay";
            this.dtNgay.Size = new System.Drawing.Size(282, 34);
            this.dtNgay.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 28);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ảnh mô tả:";
            // 
            // frmThemSuaDungCu
            // 
            this.AcceptButton = this.btndongy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnboqua;
            this.ClientSize = new System.Drawing.Size(458, 731);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtNgay);
            this.Controls.Add(this.lbmota);
            this.Controls.Add(this.txtMota);
            this.Controls.Add(this.lbnsx);
            this.Controls.Add(this.lbthuonghieu);
            this.Controls.Add(this.txtThuonghieu);
            this.Controls.Add(this.lbgia);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.btnchonanh);
            this.Controls.Add(this.picAnh);
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btndongy);
            this.Controls.Add(this.lbsl);
            this.Controls.Add(this.lbten);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.txtTen);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "frmThemSuaDungCu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Sửa Dụng Cụ";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.Label lbsl;
        private System.Windows.Forms.Button btndongy;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnchonanh;
        private System.Windows.Forms.PictureBox picAnh;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lbgia;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lbnsx;
        private System.Windows.Forms.Label lbthuonghieu;
        private System.Windows.Forms.TextBox txtThuonghieu;
        private System.Windows.Forms.Label lbmota;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.DateTimePicker dtNgay;
        private System.Windows.Forms.Label label1;
    }
}