using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageSystem.Domain.Entities;

public class Box
{
    public Guid Id { get; set; }
    public Product Product { get; set; }
    public Adress Adress { get; set; }
    public Status Status { get; set; }
    public float Weigth { get; set; }
}
