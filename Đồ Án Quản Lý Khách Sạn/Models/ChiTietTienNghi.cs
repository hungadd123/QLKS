namespace Đồ_Án_Quản_Lý_Khách_Sạn.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietTienNghi")]
    public partial class ChiTietTienNghi
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        public string MaPhong { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(10)]
        public string MaTNghi { get; set; }

        public int SoLuong { get; set; }

        public virtual Phong Phong { get; set; }

        public virtual TienNghi TienNghi { get; set; }
    }
}
