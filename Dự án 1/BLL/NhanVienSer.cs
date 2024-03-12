using Dự_án_1.DAL;
using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.BLL
{
    internal class NhanVienSer
    {
        NhanVienRes nvSer = new();

        public List<Nhanvien> getAllnhanvienSer()
        {
            return nvSer.getAllnhanvienrespo();
        }
    }
}
