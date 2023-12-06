using System;
using System.Collections.Generic;

namespace QL_NhanVien.Models
{
    public partial class Nhanvien
    {
        public int Id { get; set; }
        public string Ten { get; set; } = null!;
        public string Diachi { get; set; } = null!;
        public string? Sodienthoai { get; set; }
        public string? Email { get; set; }
        public string? Chucvu { get; set; }
        public int? IdCn { get; set; }

        public virtual Phongban? IdCnNavigation { get; set; }
    }
}
