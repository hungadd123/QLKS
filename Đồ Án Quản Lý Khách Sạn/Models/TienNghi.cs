namespace Đồ_Án_Quản_Lý_Khách_Sạn.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TienNghi")]
    public partial class TienNghi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TienNghi()
        {
            ChiTietTienNghis = new HashSet<ChiTietTienNghi>();
        }

        [Key]
        [StringLength(10)]
        public string MaTNghi { get; set; }

        [Required]
        [StringLength(255)]
        public string TenTNghi { get; set; }

        public int SoLuong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietTienNghi> ChiTietTienNghis { get; set; }
    }
}
