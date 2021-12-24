namespace QLDungCuTheThao
{
    partial class frmThemSuaLoai
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
            this.lbmota = new System.Windows.Forms.Label();
            this.lbten = new System.Windows.Forms.Label();
            this.txtmota = new System.Windows.Forms.TextBox();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnboqua = new System.Windows.Forms.Button();
            this.btndongy = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbmota
            // 
            this.lbmota.AutoSize = true;
            this.lbmota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmota.Location = new System.Drawing.Point(9, 78);
            this.lbmota.Name = "lbmota";
            this.lbmota.Size = new System.Drawing.Size(68, 28);
            this.lbmota.TabIndex = 6;
            this.lbmota.Text = "Mô tả:";
            // 
            // lbten
            // 
            this.lbten.AutoSize = true;
            this.lbten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbten.Location = new System.Drawing.Point(9, 15);
            this.lbten.Name = "lbten";
            this.lbten.Size = new System.Drawing.Size(82, 28);
            this.lbten.TabIndex = 5;
            this.lbten.Text = "Tên loại:";
            // 
            // txtmota
            // 
            this.txtmota.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmota.Location = new System.Drawing.Point(141, 81);
            this.txtmota.Multiline = true;
            this.txtmota.Name = "txtmota";
            this.txtmota.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtmota.Size = new System.Drawing.Size(282, 249);
            this.txtmota.TabIndex = 7;
            // 
            // txtTen
            // 
            this.txtTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(141, 12);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(282, 34);
            this.txtTen.TabIndex = 4;
            // 
            // btnboqua
            // 
            this.btnboqua.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnboqua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnboqua.Location = new System.Drawing.Point(298, 336);
            this.btnboqua.Name = "btnboqua";
            this.btnboqua.Size = new System.Drawing.Size(125, 35);
            this.btnboqua.TabIndex = 9;
            this.btnboqua.Text = "Bỏ qua";
            this.btnboqua.UseVisualStyleBackColor = true;
            // 
            // btndongy
            // 
            this.btndongy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndongy.Location = new System.Drawing.Point(141, 336);
            this.btndongy.Name = "btndongy";
            this.btndongy.Size = new System.Drawing.Size(125, 35);
            this.btndongy.TabIndex = 8;
            this.btndongy.Text = "Đồng ý";
            this.btndongy.UseVisualStyleBackColor = true;
            this.btndongy.Click += new System.EventHandler(this.btndongy_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmThemSuaLoai
            // 
            this.AcceptButton = this.btndongy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnboqua;
            this.ClientSize = new System.Drawing.Size(449, 394);
            this.ControlBox = false;
            this.Controls.Add(this.btnboqua);
            this.Controls.Add(this.btndongy);
            this.Controls.Add(this.lbmota);
            this.Controls.Add(this.lbten);
            this.Controls.Add(this.txtmota);
            this.Controls.Add(this.txtTen);
            this.Name = "frmThemSuaLoai";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Sửa Loại Dụng Cụ";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbmota;
        private System.Windows.Forms.Label lbten;
        private System.Windows.Forms.TextBox txtmota;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnboqua;
        private System.Windows.Forms.Button btndongy;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}