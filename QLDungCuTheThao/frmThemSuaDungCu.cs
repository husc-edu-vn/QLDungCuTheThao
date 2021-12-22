using QLDungCuTheThao.BLL;
using QLDungCuTheThao.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDungCuTheThao
{
    public partial class frmThemSuaDungCu : Form
    {
        DungCu dungcu;
        public frmThemSuaDungCu(DungCu dungcu = null)
        {
            InitializeComponent();
            this.dungcu = dungcu;
            if (dungcu == null)
            {
                this.Text = "Thêm mới dụng cụ";
            }
            else
            {
                this.Text = "Cập nhật dụng cụ";
                MemoryStream stream = new MemoryStream(dungcu.AnhMoTa.ToArray());
                Image img = Image.FromStream(stream);
                picAnh.Image = img;
                txtTen.Text = dungcu.Ten;
                txtGia.Text = dungcu.Gia.ToString();
                txtSoluong.Text = dungcu.SoLuong.ToString();
                txtThuonghieu.Text = dungcu.ThuongHieu;
                dtNgay.Value = (DateTime)(dungcu.NgaySX!=null?dungcu.NgaySX:DateTime.Now);
                txtMota.Text = dungcu.MoTa;
            }
        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var tendungcu = txtTen.Text;
            var gia = txtGia.Text;
            var soluong = txtSoluong.Text;
            var thuonghieu = txtThuonghieu.Text;
            var ngaysx = dtNgay.Value;
            var mota = txtMota.Text;
            //Xu ly anh
            byte[] image;
            if (picAnh.Image != null)
            {
                MemoryStream stream = new MemoryStream();
                picAnh.Image.Save(stream, ImageFormat.Jpeg);
                 image = stream.ToArray();
            }
            else
            {
                errorProvider1.SetError(picAnh, "Chọn ảnh cho dụng cụ");
                return;
            }
            

            if (string.IsNullOrEmpty(tendungcu))
            {
                errorProvider1.SetError(txtTen, "Tên dụng cụ không được để trống");
                return;
            }
            if (string.IsNullOrEmpty(gia))
            {
                errorProvider1.SetError(txtGia, "Giá không được để trống");
                return;
            }
            long giadungcu;
            if (!long.TryParse(gia, out giadungcu))
            {
                errorProvider1.SetError(txtGia, "Giá phải là số");
                return;
            }
            if (giadungcu < 0)
            {
                errorProvider1.SetError(txtGia, "Giá phải là số dương");
                return;
            }
            if (string.IsNullOrEmpty(soluong))
            {
                errorProvider1.SetError(txtSoluong, "Số lượng không được để trống");
                return;
            }
            long soluongkho;
            if (!long.TryParse(soluong, out soluongkho))
            {
                errorProvider1.SetError(txtSoluong, "Số lượng phải là số");
                return;
            }
            if (soluongkho < 0)
            {
                errorProvider1.SetError(txtSoluong, "Số lượng phải là số dương");
                return;
            }
            var rs = KetQua.ThanhCong;
            if (dungcu == null)
            {
                //them moi
                rs = DungCuBLL.Add(new DungCu
                {
                    Ten = tendungcu,
                    Gia = giadungcu,
                    SoLuong = soluongkho,
                    ThuongHieu = thuonghieu,
                    NgaySX = ngaysx,
                    MoTa = mota,                    
                    AnhMoTa = image                 
                });
            }
            else
            {
                //cap nhat
                dungcu.Ten = tendungcu;
                dungcu.Gia = giadungcu;
                dungcu.SoLuong = soluongkho;
                dungcu.ThuongHieu = thuonghieu;
                dungcu.NgaySX = ngaysx;
                dungcu.MoTa = mota;
                dungcu.AnhMoTa = image;

                rs = DungCuBLL.Update(dungcu);
            }
            if (rs == KetQua.ThanhCong)
            {
                DialogResult = DialogResult.OK;
            }
            else if (rs == KetQua.TenTrung)
            {
                MessageBox.Show("Tên dụng cụ đã tồn tại!", "Thông báo");
            }
        }

        private void btnchonanh_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            String file = openFileDialog1.FileName;
            if (string.IsNullOrEmpty(file) || file.Equals("openFileDialog1"))
            {
                return;
            }
            Image image = Image.FromFile(file);
            picAnh.Image = image;
        }        
    }
}
