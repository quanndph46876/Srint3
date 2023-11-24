using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QLNhanVien.Models.DomainClass
{
    [Table("NhanVien")]
    public partial class NhanVien
    {
        [Key]
        [Column("IDNhanVien")]
        public int IdnhanVien { get; set; }
        [StringLength(200)]
        public string? Hoten { get; set; }
        public bool? Gioitinh { get; set; }
        [Column("namsinh")]
        public int? Namsinh { get; set; }
        [Column("sdt")]
        [StringLength(10)]
        public string? Sdt { get; set; }
        [Column("email")]
        [StringLength(50)]
        public string? Email { get; set; }
        [Column("chucvu")]
        [StringLength(20)]
        public string? Chucvu { get; set; }
        [Column("IDTaiKhoan")]
        public int? IdtaiKhoan { get; set; }
        [Column("IDPhong")]
        public int? Idphong { get; set; }

        [ForeignKey("Idphong")]
        [InverseProperty("NhanViens")]
        public virtual Phongban? IdphongNavigation { get; set; }
        [ForeignKey("IdtaiKhoan")]
        [InverseProperty("NhanViens")]
        public virtual TaiKhoan? IdtaiKhoanNavigation { get; set; }
    }
}
