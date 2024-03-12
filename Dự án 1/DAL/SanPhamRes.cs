using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.DAL
{
    internal class SanPhamRes
    {
        Duan1NhomContext db = new();

        public List<Sanpham> getAllSanPhamres()
        {
            return db.Sanphams.ToList();
        }

        public bool CreateProducts(Sanpham sp)
        {
            try
            {
                if (sp != null)
                {
                    db.Sanphams.Add(sp);
                    return db.SaveChanges() > 0;
                }
                else
                {
                    return false;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public bool UpdateProducts(Sanpham sp)
        {
            db.Sanphams.Update(sp);
            return db.SaveChanges() > 0;
        }

        public bool DeleteProducts(Sanpham sp)
        {
            db.Sanphams.Remove(sp);
            return db.SaveChanges() > 0;
        }
    }
}
