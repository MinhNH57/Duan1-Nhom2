using Dự_án_1.DAL;
using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.BLL
{
    internal class TaiKhoanSer
    {
        TaiKhoanRes tkser = new();

        public List<Taikhoan> getAlltaikhoanSer()
        {
            return tkser.getAllTaiKhoanRespo();
        }

        public Taikhoan findTaiKhoanSer(string tk , string mk)
        {
            return tkser.findTaiKhoan(tk , mk);
        }
    }
}
