using System;
using System.Collections.Generic;

namespace Dự_án_1.DAL.Models;

public partial class Km
{
    public string Makm { get; set; } = null!;

    public string Tenkm { get; set; } = null!;

    public DateOnly Ngaybatdau { get; set; }

    public DateOnly Ngayketthuc { get; set; }

    public double Slgiam { get; set; }

    public virtual ICollection<Hdct> Hdcts { get; set; } = new List<Hdct>();

    public virtual ICollection<Spct> Spcts { get; set; } = new List<Spct>();
}
