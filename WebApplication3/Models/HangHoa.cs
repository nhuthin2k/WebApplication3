namespace WebApplication3.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("hanghoas")]
    public partial class HangHoa

    {
        [Key]
        [StringLength(50,ErrorMessage ="Mã Hàng Hóa Phải Ngắn hơn 50 ký tự")]
        [DisplayName(" mã hàng hóa")]
        public string MaHangHoa { get; set; }
        [DisplayName(" tên hàng hóa")]
        [Required]
        [StringLength(50)]
        public string TenHH { get; set; }
        [DisplayName(" đơn giá ")]
        public decimal DonGia { get; set; }
        [DisplayName(" đơn  vị tính ")]
        [Required]
        [StringLength(50)]
        public string DonViTinh { get; set; }
       
        [Required]
        [StringLength(50)]

        [DisplayName("Nhà Cung Cấp")]
        public string MaNCC { get; set; }
        [ForeignKey("MaNCC")]
        public NhaCC nhaCCs { get; set; }
    }
}
