namespace Đồ_Án_Quản_Lý_Khách_Sạn.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDichVu")]
    public partial class ChiTietDichVu
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaDV { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaHD { get; set; }

        public int SoLuong { get; set; }

        [Required]
        [StringLength(10)]
        public string DVT { get; set; }

        public virtual DichVu DichVu { get; set; }

        public virtual HoaDon HoaDon { get; set; }
    }
}
