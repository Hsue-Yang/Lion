﻿using System;
using System.Collections.Generic;

namespace CoreMvc5_NorthwindPagination.Models;

public partial class OrderSubtotal
{
    public int OrderId { get; set; }

    public decimal? Subtotal { get; set; }
}
