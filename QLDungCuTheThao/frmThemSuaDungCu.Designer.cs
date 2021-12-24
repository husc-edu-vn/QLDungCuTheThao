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
            this.btnchonanh = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lbmota = new System.Windows.Forms.Label();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbloai = new System.Windows.Forms.Label();
            this.cbloai = new System.Windows.Forms.ComboBox();
            this.picAnh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAnh)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(144, 359);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(282, 34);
            this.txtTen.TabIndex = 1;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoluong.Location = new System.Drawing.Point(144, 428);
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(282, 34);
            this.txtSoluong.TabIndex = 3;
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbten.Location = new System.Drawing.Point(12, 362);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(121, 28);
            this.lbten.TabIndex = 2;
            this.lbten.Text = "Tên dụng cụ:";
            // 
            // lbsl
            // 
            this.lbsl.AutoSize = true;
            this.lbsl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsl.Location = new System.Drawing.Point(12, 425);
            this.lbsl.Name = "lbsl";
            this.lbsl.Size = new System.Drawing.Size(96, 28);
            this.lbsl.TabIndex = 3;
            this.lbsl.Text = "Số lượng:";
            // 
            // btndongy
            // 
            this.btndongy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndongy.Location = new System.Drawing.Point(144, 618);
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
            this.btnboqua.Location = new System.Drawing.Point(301, 618);
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
            // lbmota
            // 
            this.lbmota.AutoSize = true;
            this.lbmota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmota.Location = new System.Drawing.Point(12, 497);
            this.lbmota.Name = "lbmota";
            this.lbmota.Size = new System.Drawing.Size(68, 28);
            this.lbmota.TabIndex = 15;
            this.lbmota.Text = "Mô tả:";
            // 
            // txtMota
            // 
            this.txtMota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMota.Location = new System.Drawing.Point(144, 497);
            this.txtMota.Multiline = true;
            this.txtMota.Name = "txtMota";
            this.txtMota.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtMota.Size = new System.Drawing.Size(282, 108);
            this.txtMota.TabIndex = 5;
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
            // lbloai
            // 
            this.lbloai.AutoSize = true;
            this.lbloai.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbloai.Location = new System.Drawing.Point(12, 293);
            this.lbloai.Name = "lbloai";
            this.lbloai.Size = new System.Drawing.Size(128, 28);
            this.lbloai.TabIndex = 18;
            this.lbloai.Text = "Loại dụng cụ:";
            // 
            // cbloai
            // 
            this.cbloai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbloai.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbloai.FormattingEnabled = true;
            this.cbloai.Location = new System.Drawing.Point(144, 290);
            this.cbloai.Name = "cbloai";
            this.cbloai.Size = new System.Drawing.Size(282, 36);
            this.cbloai.TabIndex = 19;
            // 
            // picAnh
            // 
            this.picAnh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.picAnh.Image = global::QLDungCuTheThao.Properties.Resources.null_image;
            this.picAnh.Location = new System.Drawing.Point(144, 12);
            this.picAnh.Name = "picAnh";
            this.picAnh.Size = new System.Drawing.Size(282, 196);
            this.picAnh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAnh.TabIndex = 6;
            this.picAnh.TabStop = false;
            // 
            // frmThemSuaDungCu
            // 
            this.AcceptButton = this.btndongy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnboqua;
            this.ClientSize = new System.Drawing.Size(458, 665);
            this.ControlBox = false;
            this.Controls.Add(this.cbloai);
            this.Controls.Add(this.lbloai);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbmota);
            this.Controls.Add(this.txtMota);
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
        private System.Windows.Forms.Label lbmota;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbloai;
        private System.Windows.Forms.Label lbloai;
    }
}