using System;
using System.Collections.Generic;

namespace LINQ_Education.Data.EfCore;

public partial class InventoryTransactionType
{
    public sbyte Id { get; set; }

    public string TypeName { get; set; } = null!;

    public virtual ICollection<InventoryTransaction> InventoryTransactions { get; set; } = new List<InventoryTransaction>();
}
