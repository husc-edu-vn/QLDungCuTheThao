using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLDungCuTheThao.DAL
{
    public partial class ModelQLDungCu : DbContext
    {
        public ModelQLDungCu()
            : base("name=QLDungCu")
        {
        }

        public virtual DbSet<DungCu> DungCus { get; set; }
        public virtual DbSet<LoaiDungCu> LoaiDungCus { get; set; }
        public virtual DbSet<TheMuonTra> TheMuonTras { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DungCu>()
                .HasMany(e => e.TheMuonTras)
                .WithRequired(e => e.DungCu)
                .HasForeignKey(e => e.IdDungCu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiDungCu>()
                .HasMany(e => e.DungCus)
                .WithRequired(e => e.LoaiDungCu)
                .HasForeignKey(e => e.IdLoai)
                .WillCascadeOnDelete(false);
        }
    }
}
