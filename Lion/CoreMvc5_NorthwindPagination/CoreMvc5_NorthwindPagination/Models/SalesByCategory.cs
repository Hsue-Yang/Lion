﻿using System;
using System.Collections.Generic;

namespace CoreMvc5_NorthwindPagination.Models;

public partial class SalesByCategory
{
    public int CategoryId { get; set; }

    public string CategoryName { get; set; }

    public string ProductName { get; set; }

    public decimal? ProductSales { get; set; }
}
