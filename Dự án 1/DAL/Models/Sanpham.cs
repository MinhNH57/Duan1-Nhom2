using System;
using System.Collections.Generic;

namespace Dự_án_1.DAL.Models;

public partial class Sanpham
{
    public string Masp { get; set; } = null!;

    public string Tensp { get; set; } = null!;

    public string Loaisp { get; set; } = null!;

    public string Chatlieu { get; set; } = null!;

    public virtual ICollection<Spct> Spcts { get; set; } = new List<Spct>();
}
