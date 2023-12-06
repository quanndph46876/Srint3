using QL_NhanVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhanVien.Controllers
{
    internal class LoginService
    {
        NhanVienRepos _repos = new NhanVienRepos();
        public LoginService()
        {

        }

        public LoginService(NhanVienRepos repos)
        {
            _repos = repos;
        }
        public List<Taikhoan> GetAllAcc()
        {
            return _repos.GetAllTaikhoan().ToList();
        }
    }
}
