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
    public partial class frmMuonTra : Form
    {
        public frmMuonTra()
        {
            InitializeComponent();
            loadMuonTra();
        }
        public TheMuonTraVM selectMuonTra
        {
            get
            {
                return theMuonTraVMBindingSource.Current as TheMuonTraVM;
            }
        }
        void loadMuonTra()
        {
            var ls = TheMuonTraBLL.getListVM();
            theMuonTraVMBindingSource.DataSource = ls;
            dataGridView1.DataSource = theMuonTraVMBindingSource;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            var f = new frmThemSuaMuonTra();
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                loadMuonTra();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var f = new frmThemSuaMuonTra(selectMuonTra);
            var rs = f.ShowDialog();
            if (rs == DialogResult.OK)
            {
                loadMuonTra();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (selectMuonTra != null)
            {
                if (MessageBox.Show(
                    "Bạn có thực sự muốn xoá?",
                    "Chú ý",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                {
                    try
                    {
                        TheMuonTraBLL.Delete(selectMuonTra.ID);
                        theMuonTraVMBindingSource.RemoveCurrent();
                        MessageBox.Show("Đã xoá thẻ thành công!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";            
            loadMuonTra();
        }

        private void txtTimKiem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var timkiem = txtTimKiem.Text;
                if (timkiem == null)
                {
                    loadMuonTra();
                }
                else
                {
                    var ls = TheMuonTraBLL.getListVMbySearch(timkiem);
                    theMuonTraVMBindingSource.DataSource = ls;
                    dataGridView1.DataSource = theMuonTraVMBindingSource;
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var timkiem = txtTimKiem.Text;
            if (timkiem == null)
            {
                loadMuonTra();
            }
            else
            {
                var ls = TheMuonTraBLL.getListVMbySearch(timkiem);
                theMuonTraVMBindingSource.DataSource = ls;
                dataGridView1.DataSource = theMuonTraVMBindingSource;
            }
        }
    }
}
