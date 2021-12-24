using QLDungCuTheThao.BLL;
using QLDungCuTheThao.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDungCuTheThao
{
    public partial class frmThemSuaLoai : Form
    {
        LoaiDungCuVM loai;
        public frmThemSuaLoai(LoaiDungCuVM loai = null)
        {
            InitializeComponent();
            this.loai = loai;
            if (loai == null)
            {
                this.Text = "Thêm Mới Loại Dụng Cụ";
            }
            else
            {
                this.Text = "Cập Nhật Loại Dụng Cụ";
                txtTen.Text = loai.TenLoai;
                txtmota.Text = loai.MoTa;
            }
        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var ten = txtTen.Text;            
            var mota = txtmota.Text;
            if (string.IsNullOrEmpty(ten))
            {
                errorProvider1.SetError(txtTen, "Tên loại không được để trống");
                return;
            }
            var rs = KetQua.ThanhCong;
            if (loai == null)
            {
                //them moi
                rs = LoaiDungCuBLL.Add(new LoaiDungCuVM
                {                    
                    TenLoai = ten,
                    MoTa = mota
                });
            }
            else
            {
                //cap nhat
                loai.TenLoai = ten;                
                loai.MoTa = mota;                

                rs = LoaiDungCuBLL.Update(loai);
            }
            if (rs == KetQua.ThanhCong)
            {
                DialogResult = DialogResult.OK;
            }
            else if (rs == KetQua.TenTrung)
            {
                MessageBox.Show("Tên loại đã tồn tại!", "Thông báo");
            }
        }
    }
}
