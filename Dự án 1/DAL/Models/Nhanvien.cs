using System;
using System.Collections.Generic;

namespace Dự_án_1.DAL.Models;

public partial class Nhanvien
{
    public string Manv { get; set; } = null!;

    public string Tennv { get; set; } = null!;

    public DateOnly? Ngaysinh { get; set; }

    public string Diachi { get; set; } = null!;

    public string Sdt { get; set; } = null!;

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();

    public virtual ICollection<Taikhoan> Taikhoans { get; set; } = new List<Taikhoan>();
}
