using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageSystem.Domain.Entities;

public class Product : BaseEntitie
{
    public string Name { get; set; }
    public bool Discontinued { get; set; }
    public int PackagingQuantity { get; set; }
}
    