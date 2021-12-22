using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QLDungCuTheThao.DAL
{
    public partial class ModelQLDungCu : DbContext
    {
        public ModelQLDungCu()
            : base("name=ModelQLDungCu")
        {
        }

        public virtual DbSet<DungCu> DungCus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
