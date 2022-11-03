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
        public DbSet<likeBlog> likeBlog { get; set; }

        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<User>()
                        .HasIndex(user => user.Email)
                        .IsUnique();
            

            builder.Entity<UserBlog>()
                .HasKey(s => new { s.UserId, s.BlogId });

            builder.Entity<UserBlog>()
                .HasOne(bc => bc.User)
                .WithMany(b => b.SavedBlogs)
                .HasForeignKey(bc => bc.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<likeBlog>()
                .HasKey(s => new { s.UserId, s.BlogId });

            builder.Entity<likeBlog>()
                .HasOne(bc => bc.user)
                .WithMany(b => b.LikeBlogs)
                .HasForeignKey(bc => bc.UserId)
                .OnDelete(DeleteBehavior.NoAction);

            builder.Entity<Comment>()
                .HasOne(bc => bc.user)
                .WithMany(b => b.comments)
                .HasForeignKey(bc => bc.UserId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}   
