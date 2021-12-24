namespace QLDungCuTheThao.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiDungCu")]
    public partial class LoaiDungCu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiDungCu()
        {
            DungCus = new HashSet<DungCu>();
        }

        public long Id { get; set; }

        [Required]
        [StringLength(255)]
        public string TenLoai { get; set; }

        [StringLength(255)]
        public string MoTa { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DungCu> DungCus { get; set; }
    }
}
