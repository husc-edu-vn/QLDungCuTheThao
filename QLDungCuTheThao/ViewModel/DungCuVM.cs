using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDungCuTheThao.ViewModel
{
    public class DungCuVM
    {
        public long ID { get; set; }              

        public long IdLoai { get; set; }

        public string TenLoai { get; set; }

        public string Ten { get; set; }

        public long SoLuong { get; set; }

        public string MoTa { get; set; }

        public String NgayThem { get; set; }

        public String NgayCapNhat { get; set; }
        
        public byte[] AnhMoTa { get; set; }
    }
}
