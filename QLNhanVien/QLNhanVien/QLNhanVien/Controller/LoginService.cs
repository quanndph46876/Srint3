using QLNhanVien.Models.DomainClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNhanVien.Controller
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
        public List<TaiKhoan> GetAllAcc() 
        { 
            return _repos.GetAllAcc(); 
        }

    }
}
