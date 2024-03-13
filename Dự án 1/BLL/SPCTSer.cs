using Dự_án_1.DAL;
using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
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

        public string CreateSPCTSer(string ma , string ten , string math , string masize , string mamau , string masp ,decimal dongia , int soluong)
        {
            Spct newspct = new()
            {
                Maspct = ma, Tenspct = ten ,Math= math ,Masize=masize,Mamau=mamau,Masp=masp,Dongia=dongia ,Soluong=soluong
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
    }
}
