using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageSystem.Domain.Entities;

public class Storage
{
    public Guid Id { get; set; }
    public List<Box> Boxes{ get; set; }
    public string Name { get; set; }
    
}
