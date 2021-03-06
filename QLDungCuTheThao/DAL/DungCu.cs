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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DungCu()
        {
            TheMuonTras = new HashSet<TheMuonTra>();
        }

        public long Id { get; set; }

        public long IdLoai { get; set; }

        [Required]
        [StringLength(255)]
        public string Ten { get; set; }

        public long SoLuong { get; set; }

        public string MoTa { get; set; }

        public DateTime NgayThem { get; set; }

        public DateTime? NgayCapNhat { get; set; }

        [Column(TypeName = "image")]
        public byte[] AnhMoTa { get; set; }

        public virtual LoaiDungCu LoaiDungCu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TheMuonTra> TheMuonTras { get; set; }
    }
}
