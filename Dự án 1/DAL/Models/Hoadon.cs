using System;
using System.Collections.Generic;

namespace Dự_án_1.DAL.Models;

public partial class Hoadon
{
    public string Mahd { get; set; } = null!;

    public DateOnly Ngaythang { get; set; }

    public string Manv { get; set; } = null!;

    public decimal Tongtien { get; set; }

    public decimal Thanhtoan { get; set; }

    public string Makh { get; set; } = null!;

    public virtual ICollection<Hdct> Hdcts { get; set; } = new List<Hdct>();

    public virtual Kh MakhNavigation { get; set; } = null!;

    public virtual Nhanvien ManvNavigation { get; set; } = null!;
}
