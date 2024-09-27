using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Farm_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Farm_API.data;
public class ApplicationDbContext : DbContext
{
    //Define DbSets for entities
    public DbSet<AnimalType> AnimalTypes { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
}
