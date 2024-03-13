using Dự_án_1.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dự_án_1.DAL
{
    internal class MauSacRes
    {
        Duan1NhomContext db = new();

        public List<M> getAllColorRes()
        {
            return db.Ms.ToList();
        }
    }
}
