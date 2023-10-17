using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace Đồ_Án_Quản_Lý_Khách_Sạn.Models
{
    public partial class KhachSanModels : DbContext
    {
        public KhachSanModels()
            : base("name=KhachSanModels")
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
        public virtual DbSet<PhieuPhat> PhieuPhats { get; set; }
        public virtual DbSet<Phong> Phongs { get; set; }
        public virtual DbSet<TienNghi> TienNghis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ChiTietDichVu>()
                .Property(e => e.MaDV)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietDichVu>()
                .Property(e => e.MaHD)
                .IsFixedLength();

            modelBuilder.Entity<ChiTietDichVu>()
                .Property(e => e.DVT)
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
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaPDP)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaNV)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .Property(e => e.MaPP)
                .IsFixedLength();

            modelBuilder.Entity<HoaDon>()
                .HasMany(e => e.ChiTietDichVus)
                .WithRequired(e => e.HoaDon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.MaKH)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.UserName)
                .IsFixedLength();

            modelBuilder.Entity<KhachHang>()
                .Property(e => e.PassWord)
                .IsFixedLength();

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
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.SDT)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.ChucVu)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .Property(e => e.PassWord)
                .IsFixedLength();

            modelBuilder.Entity<NhanVien>()
                .HasMany(e => e.HoaDons)
                .WithRequired(e => e.NhanVien)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PhieuDatPhong>()
                .Property(e => e.MaPDP)
                .IsFixedLength();

            modelBuilder.Entity<PhieuDatPhong>()
                .HasMany(e => e.Phongs)
                .WithMany(e => e.PhieuDatPhongs)
                .Map(m => m.ToTable("ChiTietDatPhong").MapLeftKey("MaPDP").MapRightKey("MaPhong"));

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
