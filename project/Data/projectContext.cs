using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace project.Models
{
    public class projectContext : DbContext
    {
        public projectContext (DbContextOptions<projectContext> options)
            : base(options)
        {
        }

        public DbSet<project.Models.Product> Product { get; set; }
    }
}
