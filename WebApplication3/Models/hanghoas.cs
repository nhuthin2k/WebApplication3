namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class hanghoas
    {
        [Key]
        [StringLength(50)]
        public string MaHangHoa { get; set; }

        [Required]
        [StringLength(50)]
        public string TenHH { get; set; }

        public decimal DonGia { get; set; }

        [Required]
        [StringLength(50)]
        public string DonViTinh { get; set; }

        [Required]
        [StringLength(50)]
        public string MaNCC { get; set; }

        public virtual Nhaccs Nhaccs { get; set; }
    }
}
