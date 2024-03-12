using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.DAL
{
    internal class NhanVienRes
    {
        Duan1NhomContext db = new Duan1NhomContext();

        public List<Nhanvien> getAllnhanvienrespo()
        {
            return db.Nhanviens.ToList();
        }
    }
}
