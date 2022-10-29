using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogIt.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { 
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.Entity<User>()
                .HasIndex(user => user.Email)
                .IsUnique();
        }
    }
}
