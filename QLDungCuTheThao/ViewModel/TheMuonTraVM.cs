using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDungCuTheThao.ViewModel
{
    public class TheMuonTraVM
    {
        public long ID { get; set; }
        public long IDDungCu { get; set; }
        public String TenDungCu { get; set; }
        public String TenNguoiMuon { get; set; }
        public String Lop { get; set; }
        public long SoLuongMuon { get; set; }
        public String NgayMuon { get; set; }
        public String NgayTra { get; set; }
        public String TrangThai { get; set; }
    }
}
