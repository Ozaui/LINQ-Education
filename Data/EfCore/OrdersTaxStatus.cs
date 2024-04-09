﻿using System;
using System.Collections.Generic;

namespace LINQ_Education.Data.EfCore;

public partial class OrdersTaxStatus
{
    public sbyte Id { get; set; }

    public string TaxStatusName { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
