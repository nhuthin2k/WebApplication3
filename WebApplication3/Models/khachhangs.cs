namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class khachhangs
    {
        [Key]
        [StringLength(50)]
        public string MaKhachHang { get; set; }

        [StringLength(50)]
        public string TenKhachHang { get; set; }

        [StringLength(11)]
        public string SoDienThoai { get; set; }

        public int NhaCC { get; set; }
    }
}
