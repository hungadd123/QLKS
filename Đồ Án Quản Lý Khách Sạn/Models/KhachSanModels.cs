using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Đồ_Án_Quản_Lý_Khách_Sạn.Models
{
    public partial class KhachSanmodels : DbContext
    {
        public KhachSanmodels()
            : base("name=KhachSanmodels")
        {
        }

        public virtual DbSet<ChiTietDichVu> ChiTietDichVus { get; set; }
        public virtual DbSet<ChiTietTienNghi> ChiTietTienNghis { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<LoaiPhong> LoaiPhongs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<PhieuDatPhong> PhieuDatPhongs { get; set; }
        public virtual DbSet<PhieuDichVu> PhieuDichVus { get; set; }
        public virtual DbSet<PhieuPhat> PhieuPhats { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<TienNghi> TienNghis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietDichVu>()
                .Property(e => e.MaDV)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietDichVu>()
                .Property(e => e.MaPDV)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietTienNghi>()
                .Property(e => e.MaPhong)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietTienNghi>()
                .Property(e => e.MaTNghi)
                .IsFixedLength();

            modelBuilder.Entity<DichVu>()
                .Property(e => e.MaDV)
                .IsFixedLength();

            modelBuilder.Entity<DichVu>()
                .HasMany(e => e.ChiTietDichVus)
                .WithRequired(e => e.DichVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaHD)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaPDP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaPP)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaPhong)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaPDV)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.PassWord)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<KhachHang>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.KhachHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LoaiPhong>()
                .Property(e => e.MaLoaiPhong)
                .IsFixedLength();

            modelBuilder.Entity<LoaiPhong>()
                .HasMany(e => e.Phongs)
                .WithRequired(e => e.LoaiPhong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.MaNV)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.ChucVu)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.PassWord)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuDatPhong>()
                .Property(e => e.MaPDP)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuDatPhong>()
                .Property(e => e.MaKh)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuDatPhong>()
                .Property(e => e.MaPhong)
                .IsFixedLength();

            modelBuilder.Entity<PhieuDichVu>()
                .Property(e => e.MaPDV)
                .IsFixedLength();

            modelBuilder.Entity<PhieuDichVu>()
                .Property(e => e.MaKH)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<PhieuDichVu>()
                .HasMany(e => e.ChiTietDichVus)
                .WithRequired(e => e.PhieuDichVu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuPhat>()
                .Property(e => e.MaPP)
                .IsFixedLength();

            modelBuilder.Entity<Phong>()
                .Property(e => e.MaPhong)
                .IsFixedLength();

            modelBuilder.Entity<Phong>()
                .Property(e => e.MaLoaiPhong)
                .IsFixedLength();

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.ChiTietTienNghis)
                .WithRequired(e => e.Phong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Phong>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.Phong)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TienNghi>()
                .Property(e => e.MaTNghi)
                .IsFixedLength();

            modelBuilder.Entity<TienNghi>()
                .HasMany(e => e.ChiTietTienNghis)
                .WithRequired(e => e.TienNghi)
                .WillCascadeOnDelete(false);
        }
    }
}
