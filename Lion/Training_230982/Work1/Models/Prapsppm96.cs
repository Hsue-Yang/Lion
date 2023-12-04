using System;
using System.Collections.Generic;

namespace Work1.Models;

public partial class Prapsppm96
{
    public int Ppm96Id { get; set; }

    public string Ppm96Stfn { get; set; }

    public DateTime Ppm96Begin { get; set; }

    public DateTime Ppm96End { get; set; }

    public string Ppm95Id { get; set; }

    public string Ppd95Id { get; set; }

    public int Ppm96Sign { get; set; }
}
