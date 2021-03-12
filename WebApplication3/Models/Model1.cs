using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication3.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<C__MigrationHistory> C__MigrationHistory { get; set; }
        public virtual DbSet<hanghoas> hanghoas { get; set; }
        public virtual DbSet<khachhangs> khachhangs { get; set; }
        public virtual DbSet<Nhaccs> Nhaccs { get; set; }
        public virtual DbSet<nhaps> nhaps { get; set; }
        public virtual DbSet<phieunhap> phieunhap { get; set; }
        public virtual DbSet<phieuxuat> phieuxuat { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tonkho> tonkho { get; set; }
        public virtual DbSet<xuat> xuat { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Nhaccs>()
                .HasMany(e => e.hanghoas)
                .WithRequired(e => e.Nhaccs)
                .HasForeignKey(e => e.MaNCC);
        }
    }
}
