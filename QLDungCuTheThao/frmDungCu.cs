using QLDungCuTheThao.BLL;
using QLDungCuTheThao.DAL;
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
            loadDungCu();
        }
        void loadDungCu()
        {
            var ls = DungCuBLL.getList();
            dungCuBindingSource.DataSource = ls;
            dataGridView1.DataSource = dungCuBindingSource;
        }
        public DungCu selectDungCu
        {
            get
            {
                return dungCuBindingSource.Current as DungCu;
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
                        DungCuBLL.Delete(selectDungCu.Id);
                        dungCuBindingSource.RemoveCurrent();
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
            if(timkiem == null)
            {
                loadDungCu();
            }
            else
            {
                var ls = DungCuBLL.getListbySearch(timkiem);
                dungCuBindingSource.DataSource = ls;
                dataGridView1.DataSource = dungCuBindingSource;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTimKiem.Text = "";
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
                    dungCuBindingSource.DataSource = ls;
                    dataGridView1.DataSource = dungCuBindingSource;
                }
            }
        }
    }
}
