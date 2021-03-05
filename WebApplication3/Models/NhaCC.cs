namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Nhaccs")]
    public partial class NhaCC
    {
        [Key]
        [StringLength(50)]
        public string MaNCC { get; set; }

        [StringLength(50)]
        public string TenNCC { get; set; }

        [StringLength(11)]
        public string SoDienThoai { get; set; }
    }
}
