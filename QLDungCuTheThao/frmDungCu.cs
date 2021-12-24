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
    public partial class frmDungCu : Form
    {
        public frmDungCu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            loadcomboLoai();
            loadDungCu();
        }
        void loadcomboLoai()
        {
            var ls = LoaiDungCuBLL.getList();
            ls.Insert(0, new LoaiDungCu { Id = -1, TenLoai = "Tất cả" });
            cbloai.DataSource = ls;
            cbloai.DisplayMember = "TenLoai";
            cbloai.ValueMember = "Id";
        }
        void loadDungCu()
        {            
            var ls = DungCuBLL.getListVM();
            dungCuVMBindingSource.DataSource = ls;
            dataGridView1.DataSource = dungCuVMBindingSource;
        }
        public DungCuVM selectDungCu
        {
            get
            {
                return dungCuVMBindingSource.Current as DungCuVM;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var f = new frmThemSuaDungCu();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                loadDungCu();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var f = new frmThemSuaDungCu(selectDungCu);
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                loadDungCu();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectDungCu != null)
            {
                if (MessageBox.Show(
                    "Bạn có thực sự muốn xoá?",
                    "Chú ý",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        DungCuBLL.Delete(selectDungCu.ID);
                        dungCuVMBindingSource.RemoveCurrent();
                        MessageBox.Show("Đã xoá dụng cụ thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var timkiem = txtTimKiem.Text;
            if (timkiem == null)
            {
                loadDungCu();
            }
            else
            {
                var ls = DungCuBLL.getListbySearch(timkiem);
                dungCuVMBindingSource.DataSource = ls;
                dataGridView1.DataSource = dungCuVMBindingSource;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
            cbloai.SelectedIndex = cbloai.FindStringExact("Tất cả");
            loadDungCu();
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var timkiem = txtTimKiem.Text;
                if (timkiem == null)
                {
                    loadDungCu();
                }
                else
                {
                    var ls = DungCuBLL.getListbySearch(timkiem);
                    dungCuVMBindingSource.DataSource = ls;
                    dataGridView1.DataSource = dungCuVMBindingSource;
                }
            }
        }

        private void cbloai_SelectedIndexChanged(object sender, EventArgs e)
        {                    
            var loai = cbloai.SelectedItem as LoaiDungCu;            
            if (loai != null && loai.Id < 0)
            {
                var ls = DungCuBLL.getListVM();
                dungCuVMBindingSource.DataSource = ls;
                dataGridView1.DataSource = dungCuVMBindingSource;
            }
            else if(loai != null && loai.Id > 0)
            {               
                var ls = DungCuBLL.getListVMbyID(loai.Id);
                dungCuVMBindingSource.DataSource = ls;
                dataGridView1.DataSource = dungCuVMBindingSource;
            }            
        }

        private void quảnLýLoạiDụngCụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoaiDungCu frm = new frmLoaiDungCu();
            frm.ShowDialog();
            loadcomboLoai();
        }

        private void quảnLýMượnTrảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMuonTra frm = new frmMuonTra();
            frm.ShowDialog();
            loadDungCu();
        }
    }
}
