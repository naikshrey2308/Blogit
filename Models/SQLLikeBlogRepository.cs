using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BlogIt.Models
{
    public class SQLLikeBlogRepository
    {
        private readonly AppDbContext context;
        public SQLLikeBlogRepository(AppDbContext context)
        {
            this.context = context;
        }

        public likeBlog Add(likeBlog blog)
        {
            Console.WriteLine("In like add");
            context.likeBlog.Add(blog);
            context.SaveChanges();
            return blog;
        }

        public IEnumerable<likeBlog> GetAllBlogs()
        {
            return context.likeBlog.Include(b => b.blog);
        }

        public likeBlog GetEntry(int blogId,int userId)
        {
            return context.likeBlog.FirstOrDefault(b => (b.BlogId == blogId && b.UserId == userId));
        }
    }
}
