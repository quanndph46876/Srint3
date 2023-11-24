using QLNhanVien.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanVien.Controller
{
    internal class NhanVienService
    {
        NhanVienRepos _repos = new NhanVienRepos();

        public NhanVienService()
        {
               
        }

        public NhanVienService(NhanVienRepos repos)
        {
            _repos = repos;
        }

        public List<NhanVien> GetAllNhanVien()
        {
            return _repos.GetAllNhanVien().ToList();
        }

        public List<NhanVien> GetNhanVienByName(string name)
        {
            return _repos.GetNhanVienByName(name).ToList();
        }

        public bool AddNhanVien(string name, string namSinh, string email, string sdt, string gioiTinh)
        {
            var nhanvien = new NhanVien
            {
                Hoten = name,
                Namsinh = Convert.ToInt32(namSinh),
                Email = email,
                Sdt = sdt,
                Gioitinh = Convert.ToBoolean(gioiTinh)
            };
            return _repos.AddNhanVien(nhanvien);
        }

        public bool DeleteNhanVien(int ID)
        {
            return _repos.DeleteNhanVien(ID);
        }

        public bool UpdateNhanVien(string name, string namSinh, string email, string sdt, string gioiTinh)
        {
            var nhanvien = new NhanVien
            {
                Hoten = name,
                Namsinh = Convert.ToInt32(namSinh),
                Email = email,
                Sdt = sdt,
                Gioitinh = Convert.ToBoolean(gioiTinh)
            };
            try
            {
                return _repos.UpdateNhanVien(nhanvien);
            }
            catch (Exception)
            {
                return _repos.UpdateNhanVien(nhanvien);
            }
        }
    }
}
