using System;
using System.Collections.Generic;

namespace Dự_án_1.DAL.Models;

public partial class Taikhoan
{
    public string Id { get; set; } = null!;

    public string Username { get; set; } = null!;

    public string Pass { get; set; } = null!;

    public string Manv { get; set; } = null!;

    public virtual Nhanvien ManvNavigation { get; set; } = null!;
}
