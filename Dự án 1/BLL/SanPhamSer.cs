using Dự_án_1.DAL;
using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.BLL
{
    internal class SanPhamSer
    {
        SanPhamRes spser = new();

        public List<Sanpham> getAllSanPhamSer()
        {
            return spser.getAllSanPhamres();
        }
        public string CreateSpSer(string maSP , string tenSp ,string loaiSp , string Cl )
        {
            Sanpham newProducts = new()
            {
                Masp = maSP ,Tensp= tenSp ,Loaisp=loaiSp,Chatlieu=Cl
            };
            if(spser.CreateProducts(newProducts) )
            {
                return "Them san pham thanh cong";
            }
            else
            {
                return "Them san pham that bai";
            }
        }
        public string UpdateSpser(string maSP, string tenSp, string loaiSp, string Cl)
        {
            Sanpham upProducts = spser.getAllSanPhamres().Find(x => x.Masp == maSP);
            upProducts.Masp = maSP;
            upProducts.Tensp = tenSp;
            upProducts.Loaisp = loaiSp;
            upProducts.Chatlieu = Cl;
            if(spser.UpdateProducts(upProducts) )
            {
                return "Sua thanh cong";
            }
            else
            {
                return "Sua that bai";
            }
        }
    }
}
