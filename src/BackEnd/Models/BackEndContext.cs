using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BackEnd.Models
{
    public class BackEndContext : DbContext
    {
        public BackEndContext(DbContextOptions<BackEndContext> options)
            : base(options)
        { }

        public DbSet<Recipe> Blogs { get; set; }
        public DbSet<Ingredient> Posts { get; set; }
    }
}