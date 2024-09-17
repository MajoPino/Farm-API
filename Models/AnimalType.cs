using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Farm_API.Models;

public class AnimalType
{
    public int Id { get; set; }
    public required string Name { get; set; } // Mammal, Bird, Reptile
    public required string Description { get; set; }
}
