using QL_NhanVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace QL_NhanVien.Controllers
{
    internal class NhanVienService
    {
        NhanVienRepos _repos = new NhanVienRepos();
        public NhanVienService() { }

        public NhanVienService(NhanVienRepos repos)
        {
            _repos = repos;
        }

        public List<Nhanvien> GetAllNhanVien()
        {
            return _repos.GetAllNhanVien().ToList();
        }
        public List<Nhanvien> GetNhanVienByName(string name)
        {
            return _repos.GetNhanVienByName(name).ToList();
        }

        public bool AddNhanVien(string name, string address, string sdt, string email, string chucvu)
        {
            var nhanvien = new Nhanvien
            {
                Ten = name,
                Diachi = address,
                Sodienthoai = sdt,
                Email = email, 
                Chucvu = chucvu
            };
            return _repos.AddNhanVien(nhanvien);
        }

        public bool DeleteNhanVien(int ID)
        {
            return _repos.DeleteNhanVien(ID);
        }

        public bool UpdateNhanVien(int id, string name, string address, string sdt, string email, string chucvu)
        {
            Nhanvien nhanvien = new Nhanvien
            {
                Id = id,
                Ten = name,
                Diachi = address,
                Sodienthoai = sdt,
                Email = email,
                Chucvu = chucvu
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
