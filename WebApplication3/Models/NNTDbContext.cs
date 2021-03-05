using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace WebApplication3.Models
{
    public partial class NNTDbContext : DbContext
    {
        public NNTDbContext()
            : base("name=NNTDbContext")
        {
        }

        public virtual DbSet<HangHoa> HangHoas { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhaCC> NhaCCs { get; set; }
        public virtual DbSet<NhapKho> NhapKhos { get; set; }
        public virtual DbSet<PhieuNhap> PhieuNhaps { get; set; }
        public virtual DbSet<PhieuXuat> PhieuXuats { get; set; }
        public virtual DbSet<TonKho> TonKhos { get; set; }
        public virtual DbSet<XuatKho> XuatKhos { get; set; }
        public object CategoryOfProduct { get; internal set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HangHoa>()
                .Property(e => e.MaHangHoa)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.TenHH)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.DonGia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.DonViTinh)
                .IsUnicode(false);

            modelBuilder.Entity<HangHoa>()
                .Property(e => e.MaNCC)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.TenKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SoDienThoai)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCC>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCC>()
                .Property(e => e.TenNCC)
                .IsUnicode(false);

            modelBuilder.Entity<NhaCC>()
                .Property(e => e.SoDienThoai)
                .IsFixedLength();

            modelBuilder.Entity<NhapKho>()
                .Property(e => e.STT)
                .IsFixedLength();

            modelBuilder.Entity<NhapKho>()
                .Property(e => e.MaHangHoa)
                .IsFixedLength();

            modelBuilder.Entity<NhapKho>()
                .Property(e => e.MaNCCS)
                .IsFixedLength();

            modelBuilder.Entity<PhieuNhap>()
                .Property(e => e.MaNCC)
                .IsUnicode(false);

            modelBuilder.Entity<PhieuXuat>()
                .Property(e => e.MaPhieuXuat)
                .IsFixedLength();

            modelBuilder.Entity<PhieuXuat>()
                .Property(e => e.MaKhachHang)
                .IsUnicode(false);

            modelBuilder.Entity<TonKho>()
                .Property(e => e.MaHangHoa)
                .IsUnicode(false);

            modelBuilder.Entity<XuatKho>()
                .Property(e => e.MaHangHoa)
                .IsFixedLength();
        }
    }
}
