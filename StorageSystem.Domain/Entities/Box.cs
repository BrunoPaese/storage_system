using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageSystem.Domain.Entities;

public class Box : BaseEntitie
{
    public Product Product { get; set; }
    public Adress Adress { get; set; }
    public Status Status { get; set; }
}
