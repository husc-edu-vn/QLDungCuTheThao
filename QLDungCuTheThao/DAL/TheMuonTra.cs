namespace QLDungCuTheThao.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TheMuonTra")]
    public partial class TheMuonTra
    {
        public long Id { get; set; }

        public long IdDungCu { get; set; }

        [Required]
        [StringLength(255)]
        public string TenNguoiMuon { get; set; }

        [Required]
        [StringLength(255)]
        public string Lop { get; set; }

        public long SoLuongMuon { get; set; }

        public DateTime NgayMuon { get; set; }

        public DateTime? NgayTra { get; set; }

        public bool TrangThai { get; set; }

        public virtual DungCu DungCu { get; set; }
    }
}
