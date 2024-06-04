using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageSystem.Domain.Entities;

public abstract class BaseEntitie
{
    public Guid Id { get; set; }
    public float Weight { get; set; }

}
