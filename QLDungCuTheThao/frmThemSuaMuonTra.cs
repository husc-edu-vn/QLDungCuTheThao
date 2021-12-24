using QLDungCuTheThao.BLL;
using QLDungCuTheThao.DAL;
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
    public partial class frmThemSuaMuonTra : Form
    {
        TheMuonTraVM muontra;
        public frmThemSuaMuonTra(TheMuonTraVM muontra = null)
        {
            InitializeComponent();
            this.muontra = muontra;
            rdmuon.Checked = true;
            loadcmbDungCu();
            if (muontra == null)
            {
                this.Text = "Thêm Mới Thẻ Mượn Trả";
                dtngaytra.Hide();
            }
            else
            {
                lbthongbao.Dispose();
                dtngaytra.Show();
                this.Text = "Cập Nhật Thẻ Mượn Trả";
                loadForm();
            }
        }
        void loadForm()
        {            
            cbdungcu.SelectedIndex = cbdungcu.FindStringExact(muontra.TenDungCu);
            txtten.Text = muontra.TenNguoiMuon;
            txtlop.Text = muontra.Lop;
            txtsoluong.Text = muontra.SoLuongMuon.ToString();

            if (muontra.TrangThai.Equals("Đang mượn"))
                rdmuon.Checked = true;
            else
                rdtra.Checked = true;
        }
        void loadcmbDungCu()
        {
            var ls = DungCuBLL.getListVM();            
            cbdungcu.DataSource = ls;
            cbdungcu.DisplayMember = "Ten";
            cbdungcu.ValueMember = "ID";
        }

        private void btndongy_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var iddungcu = long.Parse(cbdungcu.SelectedValue.ToString());
            var tennguoimuon = txtten.Text;
            var lop = txtlop.Text;
            var soluong = txtsoluong.Text;
            var dtmuon = dtngaymuon.Value;
            var dttra = dtngaytra.Value;
            var trangthai = ((rdmuon.Checked == true) ? "Đang mượn" : "Đã trả");
            


            if (string.IsNullOrEmpty(tennguoimuon))
            {
                errorProvider1.SetError(txtten, "Tên người mượn không được để trống");
                return;
            }

            if (string.IsNullOrEmpty(lop))
            {
                errorProvider1.SetError(txtlop, "Lớp không được để trống");
                return;
            }

            if (string.IsNullOrEmpty(soluong))
            {
                errorProvider1.SetError(txtsoluong, "Số lượng không được để trống");
                return;
            }
            long soluongmuon;
            if (!long.TryParse(soluong, out soluongmuon))
            {
                errorProvider1.SetError(txtsoluong, "Số lượng phải là số");
                return;
            }
            if (soluongmuon < 0)
            {
                errorProvider1.SetError(txtsoluong, "Số lượng phải là số dương");
                return;
            }
            var rs = KetQua.ThanhCong;
            if (muontra == null)
            {
                //them moi
                rs = TheMuonTraBLL.Add(new TheMuonTraVM
                {                    
                    IDDungCu = iddungcu,
                    TenNguoiMuon = tennguoimuon,
                    Lop = lop,
                    SoLuongMuon = soluongmuon   
                });
            }
            else
            {
                //cap nhat
                muontra.IDDungCu = iddungcu;
                muontra.TenNguoiMuon = tennguoimuon;
                muontra.Lop = lop;
                muontra.SoLuongMuon = soluongmuon;
                muontra.NgayMuon = dtmuon.ToString();
                if(rdtra.Checked == true)
                {
                    muontra.NgayTra = dttra.ToString();
                }   
                else
                {
                    muontra.NgayTra = muontra.NgayTra;
                }
                muontra.TrangThai = trangthai;


                rs = TheMuonTraBLL.Update(muontra);
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
    }
}
