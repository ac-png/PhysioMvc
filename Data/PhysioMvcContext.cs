using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PhysioMvc.Models;

namespace PhysioMvc.Data
{
    public class PhysioMvcContext : DbContext
    {
        public PhysioMvcContext (DbContextOptions<PhysioMvcContext> options)
            : base(options)
        {
        }

        public DbSet<PhysioMvc.Models.User> User { get; set; } = default!;
        public DbSet<PhysioMvc.Models.Exercise> Exercise { get; set; } = default!;
    }
}
