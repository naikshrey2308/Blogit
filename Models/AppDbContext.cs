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

        public DbSet<Category> Categories { get; set; }
        /*public DbSet<SavedBlog> SavedBlogs { get; set; }*/
        public DbSet<UserBlog> UserBlogs { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                        .HasIndex(user => user.Email)
                        .IsUnique();
           /* _ = builder.Entity<SavedBlog>().HasKey(sb => new { sb.BlogId, sb.UserId});

            builder.Entity<SavedBlog>()
                .HasOne<User>(sc => sc.Users)
                .WithMany(s => s.SavedBlogs)
                .HasForeignKey(sc => sc.UserId)
                .OnDelete(DeleteBehavior.NoAction);


            builder.Entity<SavedBlog>()
                .HasOne<Blog>(sc => sc.Blogs)
                .WithMany(s => s.SavedBlogs)
                .HasForeignKey(sc => sc.BlogId).OnDelete(DeleteBehavior.NoAction);*/

            builder.Entity<UserBlog>()
                .HasKey(s => new { s.UserId, s.BlogId });  
            
            builder.Entity<UserBlog>()
                .HasOne(bc => bc.User)
                .WithMany(b => b.SavedBlogs)
                .HasForeignKey(bc => bc.UserId);  
            
            builder.Entity<UserBlog>()
                .HasOne(bc => bc.Blog)
                .WithMany(c => c.SavedBlogs)
                .HasForeignKey(bc => bc.BlogId);
        }
    }
}   
