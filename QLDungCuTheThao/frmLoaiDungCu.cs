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
    public partial class frmLoaiDungCu : Form
    {
        public frmLoaiDungCu()
        {
            InitializeComponent();
            loadLoaiDungCu();
        }
        void loadLoaiDungCu()
        {
            var ls = LoaiDungCuBLL.getListVM();
            loaiDungCuVMBindingSource.DataSource = ls;
            dataGridView1.DataSource = loaiDungCuVMBindingSource;
        }
        public LoaiDungCuVM selectLoaiDungCu
        {
            get
            {
                return loaiDungCuVMBindingSource.Current as LoaiDungCuVM;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectLoaiDungCu != null)
            {
                if (MessageBox.Show(
                    "Bạn có thực sự muốn xoá?",
                    "Chú ý",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        LoaiDungCuBLL.Delete(selectLoaiDungCu.ID);
                        loaiDungCuVMBindingSource.RemoveCurrent();
                        MessageBox.Show("Đã xoá lọai thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var f = new frmThemSuaLoai();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                loadLoaiDungCu();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var f = new frmThemSuaLoai(selectLoaiDungCu);
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                loadLoaiDungCu();
            }

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var timkiem = txtTimKiem.Text;
            if (string.IsNullOrEmpty(timkiem))
            {
                loadLoaiDungCu();
            }
            else
            {
                var ls = LoaiDungCuBLL.getListVMbySearch(timkiem);
                loaiDungCuVMBindingSource.DataSource = ls;
                dataGridView1.DataSource = loaiDungCuVMBindingSource;
            }
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var timkiem = txtTimKiem.Text;
                if (string.IsNullOrEmpty(timkiem))
                {
                    loadLoaiDungCu();
                }
                else
                {
                    var ls = LoaiDungCuBLL.getListVMbySearch(timkiem);
                    loaiDungCuVMBindingSource.DataSource = ls;
                    dataGridView1.DataSource = loaiDungCuVMBindingSource;
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            loadLoaiDungCu();
        }
    }
}
