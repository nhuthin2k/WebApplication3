using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models.ViewModels
{
    public class KhachHangViewModel
    {
        public string MaKhachHang { get; set; }

        public string TenKhachHang { get; set; }

        public string SoDienThoai { get; set; }
    }
}