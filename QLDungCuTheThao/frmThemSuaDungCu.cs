using QLDungCuTheThao.BLL;
using QLDungCuTheThao.DAL;
using QLDungCuTheThao.ViewModel;
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
        DungCuVM dungcu;
        public frmThemSuaDungCu(DungCuVM dungcu = null)
        {
            InitializeComponent();
            this.dungcu = dungcu;
            var ls = LoaiDungCuBLL.getList();
            cbloai.DataSource = ls;
            cbloai.DisplayMember = "TenLoai";
            cbloai.ValueMember = "Id";
            if (dungcu == null)
            {
                this.Text = "Thêm Mới Dụng Cụ";
            }
            else
            {
                this.Text = "Cập Nhật Dụng Cụ";
                MemoryStream stream = new MemoryStream(dungcu.AnhMoTa.ToArray());
                Image img = Image.FromStream(stream);
                picAnh.Image = img;
                cbloai.SelectedIndex = cbloai.FindStringExact(dungcu.TenLoai);
                txtTen.Text = dungcu.Ten;                
                txtSoluong.Text = dungcu.SoLuong.ToString();
                txtMota.Text = dungcu.MoTa;
            }
        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var tendungcu = txtTen.Text;            
            var soluong = txtSoluong.Text;            
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
                rs = DungCuBLL.Add(new DungCuVM
                {
                    IdLoai = long.Parse(cbloai.SelectedItem.ToString()),
                    Ten = tendungcu,
                    SoLuong = soluongkho,
                    MoTa = mota,                    
                    AnhMoTa = image
                });
            }
            else
            {
                //cap nhat
                dungcu.IdLoai = long.Parse(cbloai.SelectedItem.ToString());
                dungcu.Ten = tendungcu;                
                dungcu.SoLuong = soluongkho;               
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
