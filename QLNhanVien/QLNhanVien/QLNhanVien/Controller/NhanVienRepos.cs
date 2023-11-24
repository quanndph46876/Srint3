using QLNhanVien.Models.Context;
using QLNhanVien.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanVien.Controller
{
    internal class NhanVienRepos
    {
        DBContext _context = new DBContext();

        public NhanVienRepos()
        {
                
        }

        public NhanVienRepos(DBContext context)
        {
            _context = context;
        }

        public IEnumerable<NhanVien> GetAllNhanVien()
        {
            return _context.NhanViens.ToList();
        }

        public List<NhanVien> GetNhanVienByName(string name)
        {
            return _context.NhanViens.Where(n => n.Hoten.Contains(name)).ToList();
        }

        public bool AddNhanVien(NhanVien nv)
        {
            try
            {
                _context.NhanViens.Add(nv);
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
                var deleteItem = _context.NhanViens.Find(ID);
                _context.NhanViens.Remove(deleteItem);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool UpdateNhanVien(NhanVien nv)
        {
            var updateNhanVien = _context.NhanViens.Find(nv.IdnhanVien);
            updateNhanVien.Hoten = nv.Hoten;
            updateNhanVien.Namsinh = nv.Namsinh;
            updateNhanVien.Email = nv.Email;
            updateNhanVien.Sdt = nv.Sdt;
            updateNhanVien.Gioitinh = nv.Gioitinh;

            _context.NhanViens.Update(updateNhanVien);
            _context.SaveChanges();
            return true;
        }
        public List<TaiKhoan> GetAllAcc()
        {
            return _context.TaiKhoans.ToList();
        }
    }
}
