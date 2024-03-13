using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.DAL
{
    internal class SPCTRes
    {
        Duan1NhomContext db = new();
        public List<Spct> getAllSPCTRes()
        {
            return db.Spcts.ToList();
        }

        public bool CreateSPCTRes(Spct sanphamct)
        {
            if (sanphamct != null)
            {
                db.Spcts.Add(sanphamct);
                return db.SaveChanges() > 0;
            }
            else
            {
                return false;
            }
        }

    }
}
