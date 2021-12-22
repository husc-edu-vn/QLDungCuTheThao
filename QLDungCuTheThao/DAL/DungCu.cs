namespace QLDungCuTheThao.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DungCu")]
    public partial class DungCu
    {
        public long Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Ten { get; set; }

        public long Gia { get; set; }

        public long SoLuong { get; set; }

        [StringLength(255)]
        public string ThuongHieu { get; set; }

        public DateTime? NgaySX { get; set; }

        public string MoTa { get; set; }

        public DateTime NgayThem { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        [Column(TypeName = "image")]
        public byte[] AnhMoTa { get; set; }
    }
}
