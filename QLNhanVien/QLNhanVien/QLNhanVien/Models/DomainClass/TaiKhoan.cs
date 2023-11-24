using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QLNhanVien.Models.DomainClass
{
    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        public TaiKhoan()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        [Key]
        [Column("IDTaiKhoan")]
        public int IdtaiKhoan { get; set; }
        [StringLength(50)]
        public string? Tendangnhap { get; set; }
        [StringLength(100)]
        public string? Matkhau { get; set; }
        [Column("rolelogin")]
        public int? Rolelogin { get; set; }

        [InverseProperty("IdtaiKhoanNavigation")]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
