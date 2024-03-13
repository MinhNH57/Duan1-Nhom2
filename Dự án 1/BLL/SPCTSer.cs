using Dự_án_1.DAL;
using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.BLL
{
    internal class SPCTSer
    {
        SPCTRes SPCTser = new();

        public List<Spct> getAllSPCTSer()
        {
            return SPCTser.getAllSPCTRes();
        }

        public string CreateSPCTSer(string ma , string ten , string math , string masize , string mamau , string masp ,decimal dongia , int soluong , byte[] hinhAnh)
        {
            Spct newspct = new()
            {
                Maspct = ma, Tenspct = ten ,Math= math ,Masize=masize,Mamau=mamau,Masp=masp,Dongia=dongia ,Soluong=soluong , HinhAnh = hinhAnh
            };
            if(SPCTser.CreateSPCTRes(newspct) )
            {
                return "Them thanh cong";
            }
            else
            {
                return "Them that bai";
            }
        }

        public string UpdateSPCTSer(string ma, string ten, string math, string masize, string mamau, string masp, decimal dongia, int soluong, byte[] hinhAnh)
        {
            Spct upSPCT = SPCTser.findbyID(ma);
            upSPCT.Maspct = ma;
            upSPCT.Tenspct = ten;
            upSPCT.Math = math;
            upSPCT.Masize = masize;
            upSPCT.Mamau = mamau;
            upSPCT.Masp=masp;
            upSPCT.Dongia = dongia;
            upSPCT.Soluong = soluong;
            upSPCT.HinhAnh = hinhAnh;
            if (SPCTser.UpdateSPCTRes(upSPCT))
            {
                return "Sua thanh cong";
            }
            else
            {
                return "Sua that bai";
            }
        }

        public Spct FindbyIDSer(string id)
        {
            return SPCTser.findbyID(id);
        }
    }
}
