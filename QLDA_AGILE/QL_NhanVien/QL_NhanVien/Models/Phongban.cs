using System;
using System.Collections.Generic;

namespace QL_NhanVien.Models
{
    public partial class Phongban
    {
        public Phongban()
        {
            Nhanviens = new HashSet<Nhanvien>();
        }

        public int Id { get; set; }
        public string Ten { get; set; } = null!;

        public virtual ICollection<Nhanvien> Nhanviens { get; set; }
    }
}
