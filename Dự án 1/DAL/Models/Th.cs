using System;
using System.Collections.Generic;

namespace Dự_án_1.DAL.Models;

public partial class Th
{
    public string Math { get; set; } = null!;

    public string Tenth { get; set; } = null!;

    public int Namtl { get; set; }

    public string Quocgia { get; set; } = null!;

    public virtual ICollection<Spct> Spcts { get; set; } = new List<Spct>();
}
