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

    public string? Taikhoan { get; set; }

    public string? Matkhau { get; set; }

    public string? Quyen { get; set; }

    public virtual ICollection<Hoadon> Hoadons { get; set; } = new List<Hoadon>();
}
