using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace QLNhanVien.Models.DomainClass
{
    [Table("Phongban")]
    public partial class Phongban
    {
        public Phongban()
        {
            NhanViens = new HashSet<NhanVien>();
        }

        [Key]
        [Column("IDPhong")]
        public int Idphong { get; set; }
        [StringLength(100)]
        public string? Tenphong { get; set; }

        [InverseProperty("IdphongNavigation")]
        public virtual ICollection<NhanVien> NhanViens { get; set; }
    }
}
