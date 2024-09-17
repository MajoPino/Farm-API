using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Farm_API.Models;

[Table("animal_types")]
public class AnimalType
{
    [Column("id")]
    public int Id { get; set; }

    [Column("name")]
    public required string Name { get; set; } // Mammal, Bird, Reptile
    
    [Column("description")]
    public required string Description { get; set; }
}
