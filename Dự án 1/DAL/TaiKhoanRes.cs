using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.DAL
{
    internal class TaiKhoanRes
    {
        Duan1NhomContext db = new();

        public List<Taikhoan> getAllTaiKhoanRespo()
        {
            return db.Taikhoans.ToList();
        }

        public Taikhoan findTaiKhoan(string tk, string mk)
        {
            return db.Taikhoans.FirstOrDefault(t => t.Username == tk && t.Pass == mk);
        }

    }
}
