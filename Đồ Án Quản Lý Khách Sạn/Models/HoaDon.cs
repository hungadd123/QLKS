namespace Đồ_Án_Quản_Lý_Khách_Sạn.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HoaDon")]
    public partial class HoaDon
    {
        [Key]
        [StringLength(5)]
        public string MaHD { get; set; }

        public int SoTien { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayLap { get; set; }

        [StringLength(10)]
        public string MaPDP { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNV { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKH { get; set; }

        [StringLength(10)]
        public string MaPP { get; set; }

        [Required]
        [StringLength(10)]
        public string MaPhong { get; set; }

        [StringLength(10)]
        public string MaPDV { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }

        public virtual PhieuDatPhong PhieuDatPhong { get; set; }

        public virtual PhieuDichVu PhieuDichVu { get; set; }

        public virtual PhieuPhat PhieuPhat { get; set; }

        public virtual Phong Phong { get; set; }
    }
}
