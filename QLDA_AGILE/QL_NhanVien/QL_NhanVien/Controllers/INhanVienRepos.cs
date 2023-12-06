using QL_NhanVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanVien.Controllers
{
    internal interface INhanVienRepos
    {
        IEnumerable<Nhanvien> GetAllNhanVien();
        IEnumerable<Taikhoan> GetAllTaikhoan();
        List<Nhanvien> GetNhanVienByName(string name);
        bool AddNhanVien(Nhanvien nvien);
        bool UpdateNhanVien(Nhanvien nvien);
        bool DeleteNhanVien(int ID);
    }
}
