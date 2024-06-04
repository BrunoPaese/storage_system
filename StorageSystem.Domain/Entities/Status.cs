using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageSystem.Domain.Entities;

public enum Status
{
    INSIDE,
    OUTSIDE,
    REQUIRED,
    RESERVED,
    WARNING
}
