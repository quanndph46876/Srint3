using QL_NhanVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanVien.Controllers
{
    internal class NhanVienRepos : INhanVienRepos
    {
        QL_NHANVIEN_AGIContext _context = new QL_NHANVIEN_AGIContext();
        public NhanVienRepos()
        {
               
        }

        public NhanVienRepos(QL_NHANVIEN_AGIContext context)
        {
            _context = context;
        }

        public bool AddNhanVien(Nhanvien nvien)
        {
            try
            {
                _context.Nhanviens.Add(nvien);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool DeleteNhanVien(int ID)
        {
            try
            {
                var deleteItem = _context.Nhanviens.Find(ID);
                _context.Nhanviens.Remove(deleteItem);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public IEnumerable<Nhanvien> GetAllNhanVien()
        {
            return _context.Nhanviens.ToList();
        }

        public IEnumerable<Taikhoan> GetAllTaikhoan()
        {
            return _context.Taikhoans.ToList();
        }

        public List<Nhanvien> GetNhanVienByName(string name)
        {
            return _context.Nhanviens.Where(n => n.Ten.Contains(name)).ToList();
        }

        public bool UpdateNhanVien(Nhanvien nvien)
        {
            var updateNhanVien = _context.Nhanviens.Find(nvien.Id);

            updateNhanVien.Ten = nvien.Ten;
            updateNhanVien.Diachi = nvien.Diachi;
            updateNhanVien.Sodienthoai = nvien.Sodienthoai;
            updateNhanVien.Chucvu = nvien.Chucvu;
            updateNhanVien.Email = nvien.Email;

            _context.Nhanviens.Update(updateNhanVien);
            _context.SaveChanges();
            return true;
        }
    }
}
