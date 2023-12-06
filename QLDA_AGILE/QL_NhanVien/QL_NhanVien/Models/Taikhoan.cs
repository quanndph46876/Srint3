using System;
using System.Collections.Generic;

namespace QL_NhanVien.Models
{
    public partial class Taikhoan
    {
        public int Id { get; set; }
        public string? Tendangnhap { get; set; }
        public string? Matkhau { get; set; }
        public int? Rolelogin { get; set; }
    }
}
